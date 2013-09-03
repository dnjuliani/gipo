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

namespace Connection
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ConnectionEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ConnectionEntities object using the connection string found in the 'ConnectionEntities' section of the application configuration file.
        /// </summary>
        public ConnectionEntities() : base("name=ConnectionEntities", "ConnectionEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ConnectionEntities object.
        /// </summary>
        public ConnectionEntities(string connectionString) : base(connectionString, "ConnectionEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ConnectionEntities object.
        /// </summary>
        public ConnectionEntities(EntityConnection connection) : base(connection, "ConnectionEntities")
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
        public ObjectSet<tb_con_Connection> tb_con_Connection
        {
            get
            {
                if ((_tb_con_Connection == null))
                {
                    _tb_con_Connection = base.CreateObjectSet<tb_con_Connection>("tb_con_Connection");
                }
                return _tb_con_Connection;
            }
        }
        private ObjectSet<tb_con_Connection> _tb_con_Connection;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tb_con_Connection EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotb_con_Connection(tb_con_Connection tb_con_Connection)
        {
            base.AddObject("tb_con_Connection", tb_con_Connection);
        }

        #endregion
    }


    #endregion

    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ConnectionModel", Name="tb_con_Connection")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tb_con_Connection : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tb_con_Connection object.
        /// </summary>
        /// <param name="idConnection">Initial value of the IdConnection property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="site">Initial value of the Site property.</param>
        /// <param name="connectionString">Initial value of the ConnectionString property.</param>
        public static tb_con_Connection Createtb_con_Connection(global::System.Int32 idConnection, global::System.String name, global::System.String site, global::System.String connectionString)
        {
            tb_con_Connection tb_con_Connection = new tb_con_Connection();
            tb_con_Connection.IdConnection = idConnection;
            tb_con_Connection.Name = name;
            tb_con_Connection.Site = site;
            tb_con_Connection.ConnectionString = connectionString;
            return tb_con_Connection;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdConnection
        {
            get
            {
                return _IdConnection;
            }
            set
            {
                if (_IdConnection != value)
                {
                    OnIdConnectionChanging(value);
                    ReportPropertyChanging("IdConnection");
                    _IdConnection = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdConnection");
                    OnIdConnectionChanged();
                }
            }
        }
        private global::System.Int32 _IdConnection;
        partial void OnIdConnectionChanging(global::System.Int32 value);
        partial void OnIdConnectionChanged();
    
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
        public global::System.String Site
        {
            get
            {
                return _Site;
            }
            set
            {
                OnSiteChanging(value);
                ReportPropertyChanging("Site");
                _Site = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Site");
                OnSiteChanged();
            }
        }
        private global::System.String _Site;
        partial void OnSiteChanging(global::System.String value);
        partial void OnSiteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                OnConnectionStringChanging(value);
                ReportPropertyChanging("ConnectionString");
                _ConnectionString = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ConnectionString");
                OnConnectionStringChanged();
            }
        }
        private global::System.String _ConnectionString;
        partial void OnConnectionStringChanging(global::System.String value);
        partial void OnConnectionStringChanged();

        #endregion
    
    }

    #endregion
    
}