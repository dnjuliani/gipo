﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ArticleModel", "FK_artArticleWebSiteArticle_IdArticle", "artArticle", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Article.artArticle), "artArticleWebSiteArticle", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Article.artArticleWebSiteArticle), true)]
[assembly: EdmRelationshipAttribute("ArticleModel", "artArticleCategoryArticle", "artArticle", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Article.artArticle), "artArticleCategory", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Article.artArticleCategory))]

#endregion

namespace Article
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ArticleEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ArticleEntities object using the connection string found in the 'ArticleEntities' section of the application configuration file.
        /// </summary>
        public ArticleEntities() : base("name=ArticleEntities", "ArticleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ArticleEntities object.
        /// </summary>
        public ArticleEntities(string connectionString) : base(connectionString, "ArticleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ArticleEntities object.
        /// </summary>
        public ArticleEntities(EntityConnection connection) : base(connection, "ArticleEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<artArticle> artArticles
        {
            get
            {
                if ((_artArticles == null))
                {
                    _artArticles = base.CreateObjectSet<artArticle>("artArticles");
                }
                return _artArticles;
            }
        }
        private ObjectSet<artArticle> _artArticles;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<artArticleCategory> artArticleCategories
        {
            get
            {
                if ((_artArticleCategories == null))
                {
                    _artArticleCategories = base.CreateObjectSet<artArticleCategory>("artArticleCategories");
                }
                return _artArticleCategories;
            }
        }
        private ObjectSet<artArticleCategory> _artArticleCategories;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<artArticleWebSiteArticle> artArticleWebSiteArticles
        {
            get
            {
                if ((_artArticleWebSiteArticles == null))
                {
                    _artArticleWebSiteArticles = base.CreateObjectSet<artArticleWebSiteArticle>("artArticleWebSiteArticles");
                }
                return _artArticleWebSiteArticles;
            }
        }
        private ObjectSet<artArticleWebSiteArticle> _artArticleWebSiteArticles;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the artArticles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToartArticles(artArticle artArticle)
        {
            base.AddObject("artArticles", artArticle);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the artArticleCategories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToartArticleCategories(artArticleCategory artArticleCategory)
        {
            base.AddObject("artArticleCategories", artArticleCategory);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the artArticleWebSiteArticles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToartArticleWebSiteArticles(artArticleWebSiteArticle artArticleWebSiteArticle)
        {
            base.AddObject("artArticleWebSiteArticles", artArticleWebSiteArticle);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ArticleModel", Name="artArticle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class artArticle : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new artArticle object.
        /// </summary>
        /// <param name="idArticle">Initial value of the IdArticle property.</param>
        /// <param name="path">Initial value of the Path property.</param>
        /// <param name="title">Initial value of the Title property.</param>
        /// <param name="content">Initial value of the Content property.</param>
        /// <param name="author">Initial value of the Author property.</param>
        /// <param name="dtInsert">Initial value of the DtInsert property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static artArticle CreateartArticle(global::System.Int32 idArticle, global::System.String path, global::System.String title, global::System.String content, global::System.String author, global::System.DateTime dtInsert, global::System.Boolean isActive)
        {
            artArticle artArticle = new artArticle();
            artArticle.IdArticle = idArticle;
            artArticle.Path = path;
            artArticle.Title = title;
            artArticle.Content = content;
            artArticle.Author = author;
            artArticle.DtInsert = dtInsert;
            artArticle.IsActive = isActive;
            return artArticle;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdArticle
        {
            get
            {
                return _IdArticle;
            }
            set
            {
                if (_IdArticle != value)
                {
                    OnIdArticleChanging(value);
                    ReportPropertyChanging("IdArticle");
                    _IdArticle = StructuralObject.SetValidValue(value, "IdArticle");
                    ReportPropertyChanged("IdArticle");
                    OnIdArticleChanged();
                }
            }
        }
        private global::System.Int32 _IdArticle;
        partial void OnIdArticleChanging(global::System.Int32 value);
        partial void OnIdArticleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Path
        {
            get
            {
                return _Path;
            }
            set
            {
                OnPathChanging(value);
                ReportPropertyChanging("Path");
                _Path = StructuralObject.SetValidValue(value, false, "Path");
                ReportPropertyChanged("Path");
                OnPathChanged();
            }
        }
        private global::System.String _Path;
        partial void OnPathChanging(global::System.String value);
        partial void OnPathChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, false, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SubTitle
        {
            get
            {
                return _SubTitle;
            }
            set
            {
                OnSubTitleChanging(value);
                ReportPropertyChanging("SubTitle");
                _SubTitle = StructuralObject.SetValidValue(value, true, "SubTitle");
                ReportPropertyChanged("SubTitle");
                OnSubTitleChanged();
            }
        }
        private global::System.String _SubTitle;
        partial void OnSubTitleChanging(global::System.String value);
        partial void OnSubTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Content
        {
            get
            {
                return _Content;
            }
            set
            {
                OnContentChanging(value);
                ReportPropertyChanging("Content");
                _Content = StructuralObject.SetValidValue(value, false, "Content");
                ReportPropertyChanged("Content");
                OnContentChanged();
            }
        }
        private global::System.String _Content;
        partial void OnContentChanging(global::System.String value);
        partial void OnContentChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String KeyWords
        {
            get
            {
                return _KeyWords;
            }
            set
            {
                OnKeyWordsChanging(value);
                ReportPropertyChanging("KeyWords");
                _KeyWords = StructuralObject.SetValidValue(value, true, "KeyWords");
                ReportPropertyChanged("KeyWords");
                OnKeyWordsChanged();
            }
        }
        private global::System.String _KeyWords;
        partial void OnKeyWordsChanging(global::System.String value);
        partial void OnKeyWordsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Author
        {
            get
            {
                return _Author;
            }
            set
            {
                OnAuthorChanging(value);
                ReportPropertyChanging("Author");
                _Author = StructuralObject.SetValidValue(value, false, "Author");
                ReportPropertyChanged("Author");
                OnAuthorChanged();
            }
        }
        private global::System.String _Author;
        partial void OnAuthorChanging(global::System.String value);
        partial void OnAuthorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DtInsert
        {
            get
            {
                return _DtInsert;
            }
            set
            {
                OnDtInsertChanging(value);
                ReportPropertyChanging("DtInsert");
                _DtInsert = StructuralObject.SetValidValue(value, "DtInsert");
                ReportPropertyChanged("DtInsert");
                OnDtInsertChanged();
            }
        }
        private global::System.DateTime _DtInsert;
        partial void OnDtInsertChanging(global::System.DateTime value);
        partial void OnDtInsertChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DtUpdate
        {
            get
            {
                return _DtUpdate;
            }
            set
            {
                OnDtUpdateChanging(value);
                ReportPropertyChanging("DtUpdate");
                _DtUpdate = StructuralObject.SetValidValue(value, "DtUpdate");
                ReportPropertyChanged("DtUpdate");
                OnDtUpdateChanged();
            }
        }
        private Nullable<global::System.DateTime> _DtUpdate;
        partial void OnDtUpdateChanging(Nullable<global::System.DateTime> value);
        partial void OnDtUpdateChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DtRelease
        {
            get
            {
                return _DtRelease;
            }
            set
            {
                OnDtReleaseChanging(value);
                ReportPropertyChanging("DtRelease");
                _DtRelease = StructuralObject.SetValidValue(value, "DtRelease");
                ReportPropertyChanged("DtRelease");
                OnDtReleaseChanged();
            }
        }
        private Nullable<global::System.DateTime> _DtRelease;
        partial void OnDtReleaseChanging(Nullable<global::System.DateTime> value);
        partial void OnDtReleaseChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value, "IsActive");
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String backup
        {
            get
            {
                return _backup;
            }
            set
            {
                OnbackupChanging(value);
                ReportPropertyChanging("backup");
                _backup = StructuralObject.SetValidValue(value, true, "backup");
                ReportPropertyChanged("backup");
                OnbackupChanged();
            }
        }
        private global::System.String _backup;
        partial void OnbackupChanging(global::System.String value);
        partial void OnbackupChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ArticleModel", "FK_artArticleWebSiteArticle_IdArticle", "artArticleWebSiteArticle")]
        public EntityCollection<artArticleWebSiteArticle> artArticleWebSiteArticles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<artArticleWebSiteArticle>("ArticleModel.FK_artArticleWebSiteArticle_IdArticle", "artArticleWebSiteArticle");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<artArticleWebSiteArticle>("ArticleModel.FK_artArticleWebSiteArticle_IdArticle", "artArticleWebSiteArticle", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ArticleModel", "artArticleCategoryArticle", "artArticleCategory")]
        public EntityCollection<artArticleCategory> artArticleCategories
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<artArticleCategory>("ArticleModel.artArticleCategoryArticle", "artArticleCategory");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<artArticleCategory>("ArticleModel.artArticleCategoryArticle", "artArticleCategory", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ArticleModel", Name="artArticleCategory")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class artArticleCategory : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new artArticleCategory object.
        /// </summary>
        /// <param name="idArticleCategory">Initial value of the IdArticleCategory property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="isActive">Initial value of the IsActive property.</param>
        public static artArticleCategory CreateartArticleCategory(global::System.Int32 idArticleCategory, global::System.String name, global::System.Boolean isActive)
        {
            artArticleCategory artArticleCategory = new artArticleCategory();
            artArticleCategory.IdArticleCategory = idArticleCategory;
            artArticleCategory.Name = name;
            artArticleCategory.IsActive = isActive;
            return artArticleCategory;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdArticleCategory
        {
            get
            {
                return _IdArticleCategory;
            }
            set
            {
                if (_IdArticleCategory != value)
                {
                    OnIdArticleCategoryChanging(value);
                    ReportPropertyChanging("IdArticleCategory");
                    _IdArticleCategory = StructuralObject.SetValidValue(value, "IdArticleCategory");
                    ReportPropertyChanged("IdArticleCategory");
                    OnIdArticleCategoryChanged();
                }
            }
        }
        private global::System.Int32 _IdArticleCategory;
        partial void OnIdArticleCategoryChanging(global::System.Int32 value);
        partial void OnIdArticleCategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String KeyWords
        {
            get
            {
                return _KeyWords;
            }
            set
            {
                OnKeyWordsChanging(value);
                ReportPropertyChanging("KeyWords");
                _KeyWords = StructuralObject.SetValidValue(value, true, "KeyWords");
                ReportPropertyChanged("KeyWords");
                OnKeyWordsChanged();
            }
        }
        private global::System.String _KeyWords;
        partial void OnKeyWordsChanging(global::System.String value);
        partial void OnKeyWordsChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsActive
        {
            get
            {
                return _IsActive;
            }
            set
            {
                OnIsActiveChanging(value);
                ReportPropertyChanging("IsActive");
                _IsActive = StructuralObject.SetValidValue(value, "IsActive");
                ReportPropertyChanged("IsActive");
                OnIsActiveChanged();
            }
        }
        private global::System.Boolean _IsActive;
        partial void OnIsActiveChanging(global::System.Boolean value);
        partial void OnIsActiveChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ArticleModel", "artArticleCategoryArticle", "artArticle")]
        public EntityCollection<artArticle> artArticles
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<artArticle>("ArticleModel.artArticleCategoryArticle", "artArticle");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<artArticle>("ArticleModel.artArticleCategoryArticle", "artArticle", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ArticleModel", Name="artArticleWebSiteArticle")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class artArticleWebSiteArticle : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new artArticleWebSiteArticle object.
        /// </summary>
        /// <param name="idArticle">Initial value of the IdArticle property.</param>
        /// <param name="idWebSite">Initial value of the IdWebSite property.</param>
        public static artArticleWebSiteArticle CreateartArticleWebSiteArticle(global::System.Int32 idArticle, global::System.Int32 idWebSite)
        {
            artArticleWebSiteArticle artArticleWebSiteArticle = new artArticleWebSiteArticle();
            artArticleWebSiteArticle.IdArticle = idArticle;
            artArticleWebSiteArticle.IdWebSite = idWebSite;
            return artArticleWebSiteArticle;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdArticle
        {
            get
            {
                return _IdArticle;
            }
            set
            {
                if (_IdArticle != value)
                {
                    OnIdArticleChanging(value);
                    ReportPropertyChanging("IdArticle");
                    _IdArticle = StructuralObject.SetValidValue(value, "IdArticle");
                    ReportPropertyChanged("IdArticle");
                    OnIdArticleChanged();
                }
            }
        }
        private global::System.Int32 _IdArticle;
        partial void OnIdArticleChanging(global::System.Int32 value);
        partial void OnIdArticleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdWebSite
        {
            get
            {
                return _IdWebSite;
            }
            set
            {
                if (_IdWebSite != value)
                {
                    OnIdWebSiteChanging(value);
                    ReportPropertyChanging("IdWebSite");
                    _IdWebSite = StructuralObject.SetValidValue(value, "IdWebSite");
                    ReportPropertyChanged("IdWebSite");
                    OnIdWebSiteChanged();
                }
            }
        }
        private global::System.Int32 _IdWebSite;
        partial void OnIdWebSiteChanging(global::System.Int32 value);
        partial void OnIdWebSiteChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ArticleModel", "FK_artArticleWebSiteArticle_IdArticle", "artArticle")]
        public artArticle artArticle
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<artArticle>("ArticleModel.FK_artArticleWebSiteArticle_IdArticle", "artArticle").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<artArticle>("ArticleModel.FK_artArticleWebSiteArticle_IdArticle", "artArticle").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<artArticle> artArticleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<artArticle>("ArticleModel.FK_artArticleWebSiteArticle_IdArticle", "artArticle");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<artArticle>("ArticleModel.FK_artArticleWebSiteArticle_IdArticle", "artArticle", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
