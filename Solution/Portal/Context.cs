using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Article;

namespace Portal
{
    public class Context
    {
        public static artArticle artArticle
        {
            get
            {
                return Article.Services.ArticleService.GetByUrl(Account.Context.WebSite.IdWebSite, Path);
            }
        }

        public static artArticleCategory artArticleCategory
        {
            get
            {
                return Article.Services.ArticleService.GetCategoryByUrl(Path);
            }
        }

        private static string _Path;
        public static string Path
        {
            get { return _Path; }
            set { _Path = value; }
        }
    }
}