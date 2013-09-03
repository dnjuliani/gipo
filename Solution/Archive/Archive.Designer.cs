﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("ArchiveModel", "FK_tb_arc_Archive_IdArchiveType", "tb_arc_ArchiveType", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Archive.tb_arc_ArchiveType), "tb_arc_Archive", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Archive.tb_arc_Archive), true)]

#endregion

namespace Archive
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Entities object using the connection string found in the 'Entities' section of the application configuration file.
        /// </summary>
        public Entities() : base("name=Entities", "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(string connectionString) : base(connectionString, "Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Entities object.
        /// </summary>
        public Entities(EntityConnection connection) : base(connection, "Entities")
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
        public ObjectSet<tb_arc_Archive> tb_arc_Archive
        {
            get
            {
                if ((_tb_arc_Archive == null))
                {
                    _tb_arc_Archive = base.CreateObjectSet<tb_arc_Archive>("tb_arc_Archive");
                }
                return _tb_arc_Archive;
            }
        }
        private ObjectSet<tb_arc_Archive> _tb_arc_Archive;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tb_arc_ArchiveType> tb_arc_ArchiveType
        {
            get
            {
                if ((_tb_arc_ArchiveType == null))
                {
                    _tb_arc_ArchiveType = base.CreateObjectSet<tb_arc_ArchiveType>("tb_arc_ArchiveType");
                }
                return _tb_arc_ArchiveType;
            }
        }
        private ObjectSet<tb_arc_ArchiveType> _tb_arc_ArchiveType;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_arc_Archive EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_arc_Archive(tb_arc_Archive tb_arc_Archive)
        {
            base.AddObject("tb_arc_Archive", tb_arc_Archive);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_arc_ArchiveType EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_arc_ArchiveType(tb_arc_ArchiveType tb_arc_ArchiveType)
        {
            base.AddObject("tb_arc_ArchiveType", tb_arc_ArchiveType);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ArchiveModel", Name="tb_arc_Archive")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_arc_Archive : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_arc_Archive object.
        /// </summary>
        /// <param name="idArchive">Initial value of the IdArchive property.</param>
        /// <param name="idArchiveType">Initial value of the IdArchiveType property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="path">Initial value of the Path property.</param>
        public static tb_arc_Archive Createtb_arc_Archive(global::System.Int32 idArchive, global::System.Int32 idArchiveType, global::System.String name, global::System.String path)
        {
            tb_arc_Archive tb_arc_Archive = new tb_arc_Archive();
            tb_arc_Archive.IdArchive = idArchive;
            tb_arc_Archive.IdArchiveType = idArchiveType;
            tb_arc_Archive.Name = name;
            tb_arc_Archive.Path = path;
            return tb_arc_Archive;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdArchive
        {
            get
            {
                return _IdArchive;
            }
            set
            {
                if (_IdArchive != value)
                {
                    OnIdArchiveChanging(value);
                    ReportPropertyChanging("IdArchive");
                    _IdArchive = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdArchive");
                    OnIdArchiveChanged();
                }
            }
        }
        private global::System.Int32 _IdArchive;
        partial void OnIdArchiveChanging(global::System.Int32 value);
        partial void OnIdArchiveChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdArchiveType
        {
            get
            {
                return _IdArchiveType;
            }
            set
            {
                OnIdArchiveTypeChanging(value);
                ReportPropertyChanging("IdArchiveType");
                _IdArchiveType = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdArchiveType");
                OnIdArchiveTypeChanged();
            }
        }
        private global::System.Int32 _IdArchiveType;
        partial void OnIdArchiveTypeChanging(global::System.Int32 value);
        partial void OnIdArchiveTypeChanged();
    
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
                _Name = StructuralObject.SetValidValue(value, false);
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
                _Path = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Path");
                OnPathChanged();
            }
        }
        private global::System.String _Path;
        partial void OnPathChanging(global::System.String value);
        partial void OnPathChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ArchiveModel", "FK_tb_arc_Archive_IdArchiveType", "tb_arc_ArchiveType")]
        public tb_arc_ArchiveType tb_arc_ArchiveType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_arc_ArchiveType>("ArchiveModel.FK_tb_arc_Archive_IdArchiveType", "tb_arc_ArchiveType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_arc_ArchiveType>("ArchiveModel.FK_tb_arc_Archive_IdArchiveType", "tb_arc_ArchiveType").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<tb_arc_ArchiveType> tb_arc_ArchiveTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<tb_arc_ArchiveType>("ArchiveModel.FK_tb_arc_Archive_IdArchiveType", "tb_arc_ArchiveType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<tb_arc_ArchiveType>("ArchiveModel.FK_tb_arc_Archive_IdArchiveType", "tb_arc_ArchiveType", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ArchiveModel", Name="tb_arc_ArchiveType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_arc_ArchiveType : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_arc_ArchiveType object.
        /// </summary>
        /// <param name="idArchiveType">Initial value of the IdArchiveType property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static tb_arc_ArchiveType Createtb_arc_ArchiveType(global::System.Int32 idArchiveType, global::System.String name)
        {
            tb_arc_ArchiveType tb_arc_ArchiveType = new tb_arc_ArchiveType();
            tb_arc_ArchiveType.IdArchiveType = idArchiveType;
            tb_arc_ArchiveType.Name = name;
            return tb_arc_ArchiveType;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdArchiveType
        {
            get
            {
                return _IdArchiveType;
            }
            set
            {
                if (_IdArchiveType != value)
                {
                    OnIdArchiveTypeChanging(value);
                    ReportPropertyChanging("IdArchiveType");
                    _IdArchiveType = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdArchiveType");
                    OnIdArchiveTypeChanged();
                }
            }
        }
        private global::System.Int32 _IdArchiveType;
        partial void OnIdArchiveTypeChanging(global::System.Int32 value);
        partial void OnIdArchiveTypeChanged();
    
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
                _Name = StructuralObject.SetValidValue(value, false);
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
        public global::System.String Extension
        {
            get
            {
                return _Extension;
            }
            set
            {
                OnExtensionChanging(value);
                ReportPropertyChanging("Extension");
                _Extension = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Extension");
                OnExtensionChanged();
            }
        }
        private global::System.String _Extension;
        partial void OnExtensionChanging(global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> MaxSize
        {
            get
            {
                return _MaxSize;
            }
            set
            {
                OnMaxSizeChanging(value);
                ReportPropertyChanging("MaxSize");
                _MaxSize = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("MaxSize");
                OnMaxSizeChanged();
            }
        }
        private Nullable<global::System.Int32> _MaxSize;
        partial void OnMaxSizeChanging(Nullable<global::System.Int32> value);
        partial void OnMaxSizeChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("ArchiveModel", "FK_tb_arc_Archive_IdArchiveType", "tb_arc_Archive")]
        public EntityCollection<tb_arc_Archive> tb_arc_Archive
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<tb_arc_Archive>("ArchiveModel.FK_tb_arc_Archive_IdArchiveType", "tb_arc_Archive");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<tb_arc_Archive>("ArchiveModel.FK_tb_arc_Archive_IdArchiveType", "tb_arc_Archive", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
