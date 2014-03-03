using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.Services
{
    public class ControlService
    {
        public static string RenderControls(string contentHtml)
        {
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();

            List<HtmlAgilityPack.HtmlNode> controlElements = new List<HtmlAgilityPack.HtmlNode>();

            htmlDoc.LoadHtml(contentHtml);

            if (htmlDoc.ParseErrors != null && htmlDoc.ParseErrors.Count() > 0)
            {
                //TODO: O que fazer quando código HTML está com erro?
            }
            else
            {
                if (htmlDoc.DocumentNode != null)
                {
                    controlElements = htmlDoc.DocumentNode.Descendants("cc").ToList(); //Pego todos os elementos "<cc></cc>" da página
                }
            }

            //Inicio renderização de controles (Sempre passar contentHtml por referência)
            RenderPagePartials(ref contentHtml, controlElements);
            //Finalizo renderização de controles

            return contentHtml;
        }

        private static void RenderPagePartials(ref string contentHtml, List<HtmlAgilityPack.HtmlNode> controlElements)
        {
            Dictionary<string, string> dicPagePartials = new Dictionary<string, string>();

            foreach (HtmlAgilityPack.HtmlNode controlElement in controlElements)
            {
                /*
                    Estou esperando o elemento com a seguinte estrutura '<cc control="pagePartial" name="header"></cc>'
                */
                HtmlAgilityPack.HtmlAttribute attrControl = controlElement.Attributes.FirstOrDefault(a => a.Name.ToLower().Equals("control")); //Guardo atributo "control" do elemento
                HtmlAgilityPack.HtmlAttribute attrName = controlElement.Attributes.FirstOrDefault(a => a.Name.ToLower().Equals("name")); //Guardo atributo "name" do elemento

                if (attrControl != null && attrName != null)
                {
                    if (attrControl.Value.ToLower().Equals("pagepartial"))
                    {
                        dicPagePartials.Add(controlElement.OuterHtml, attrName.Value); //Adiciono ao dicionário o código html do controle e o valor do atributo name
                    }
                }
            }

            PortalEntities portal = new PortalEntities(Account.Context.GetConnectionStringEntity("Portal"));
            IEnumerable<Portal.porPagePartial> queryPagePartial;

            foreach (var dic in dicPagePartials)
            {
                queryPagePartial = from pp in portal.porPagePartials
                                   where pp.Name.Equals(dic.Value)
                                   select pp;

                if (queryPagePartial.FirstOrDefault() != null)
                {
                    contentHtml = contentHtml.Replace(dic.Key, queryPagePartial.FirstOrDefault().Html);
                }
                else 
                {
                    contentHtml = contentHtml.Replace(dic.Key, string.Format("<!-- Erro de Configuração: Página parcial \"{0}\" não existe -->", dic.Value));
                }
            }
        }

    }
}