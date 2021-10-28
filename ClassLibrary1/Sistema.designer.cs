﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="db_sistema")]
	public partial class SistemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcategoria(categoria instance);
    partial void Updatecategoria(categoria instance);
    partial void Deletecategoria(categoria instance);
    partial void Insertproduto(produto instance);
    partial void Updateproduto(produto instance);
    partial void Deleteproduto(produto instance);
    partial void Insertcliente(cliente instance);
    partial void Updatecliente(cliente instance);
    partial void Deletecliente(cliente instance);
    #endregion
		
		public SistemaDataContext() : 
				base(global::ClassLibrary1.Properties.Settings.Default.db_sistemaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SistemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<categoria> categorias
		{
			get
			{
				return this.GetTable<categoria>();
			}
		}
		
		public System.Data.Linq.Table<produto> produtos
		{
			get
			{
				return this.GetTable<produto>();
			}
		}
		
		public System.Data.Linq.Table<cliente> clientes
		{
			get
			{
				return this.GetTable<cliente>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_categoria")]
	public partial class categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private EntitySet<produto> _produtos;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    #endregion
		
		public categoria()
		{
			this._produtos = new EntitySet<produto>(new Action<produto>(this.attach_produtos), new Action<produto>(this.detach_produtos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_categoria", Storage="_Descricao", DbType="NVarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_categoria_tb_produto", Storage="_produtos", ThisKey="Codigo", OtherKey="CodigoCategoria")]
		public EntitySet<produto> produtos
		{
			get
			{
				return this._produtos;
			}
			set
			{
				this._produtos.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_produtos(produto entity)
		{
			this.SendPropertyChanging();
			entity.categoria = this;
		}
		
		private void detach_produtos(produto entity)
		{
			this.SendPropertyChanging();
			entity.categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tb_produto")]
	public partial class produto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Codigo;
		
		private string _Descricao;
		
		private System.Nullable<decimal> _valor;
		
		private System.Nullable<int> _CodigoCategoria;
		
		private EntityRef<categoria> _categoria;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodigoChanging(int value);
    partial void OnCodigoChanged();
    partial void OnDescricaoChanging(string value);
    partial void OnDescricaoChanged();
    partial void OnvalorChanging(System.Nullable<decimal> value);
    partial void OnvalorChanged();
    partial void OnCodigoCategoriaChanging(System.Nullable<int> value);
    partial void OnCodigoCategoriaChanged();
    #endregion
		
		public produto()
		{
			this._categoria = default(EntityRef<categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_produto", Storage="_Codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Codigo
		{
			get
			{
				return this._Codigo;
			}
			set
			{
				if ((this._Codigo != value))
				{
					this.OnCodigoChanging(value);
					this.SendPropertyChanging();
					this._Codigo = value;
					this.SendPropertyChanged("Codigo");
					this.OnCodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="desc_produto", Storage="_Descricao", DbType="NVarChar(50)")]
		public string Descricao
		{
			get
			{
				return this._Descricao;
			}
			set
			{
				if ((this._Descricao != value))
				{
					this.OnDescricaoChanging(value);
					this.SendPropertyChanging();
					this._Descricao = value;
					this.SendPropertyChanged("Descricao");
					this.OnDescricaoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_valor", DbType="Decimal(25,2)")]
		public System.Nullable<decimal> valor
		{
			get
			{
				return this._valor;
			}
			set
			{
				if ((this._valor != value))
				{
					this.OnvalorChanging(value);
					this.SendPropertyChanging();
					this._valor = value;
					this.SendPropertyChanged("valor");
					this.OnvalorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_categoria", Storage="_CodigoCategoria", DbType="Int")]
		public System.Nullable<int> CodigoCategoria
		{
			get
			{
				return this._CodigoCategoria;
			}
			set
			{
				if ((this._CodigoCategoria != value))
				{
					this.OnCodigoCategoriaChanging(value);
					this.SendPropertyChanging();
					this._CodigoCategoria = value;
					this.SendPropertyChanged("CodigoCategoria");
					this.OnCodigoCategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tb_categoria_tb_produto", Storage="_categoria", ThisKey="CodigoCategoria", OtherKey="Codigo", IsForeignKey=true)]
		public categoria categoria
		{
			get
			{
				return this._categoria.Entity;
			}
			set
			{
				categoria previousValue = this._categoria.Entity;
				if (((previousValue != value) 
							|| (this._categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._categoria.Entity = null;
						previousValue.produtos.Remove(this);
					}
					this._categoria.Entity = value;
					if ((value != null))
					{
						value.produtos.Add(this);
						this._CodigoCategoria = value.Codigo;
					}
					else
					{
						this._CodigoCategoria = default(Nullable<int>);
					}
					this.SendPropertyChanged("categoria");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_cliente")]
	public partial class cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _codigo;
		
		private string _Nome;
		
		private System.Nullable<decimal> _Telefone;
		
		private string _Dados;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncodigoChanging(int value);
    partial void OncodigoChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnTelefoneChanging(System.Nullable<decimal> value);
    partial void OnTelefoneChanged();
    partial void OnDadosChanging(string value);
    partial void OnDadosChanged();
    #endregion
		
		public cliente()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="id_cliente", Storage="_codigo", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int codigo
		{
			get
			{
				return this._codigo;
			}
			set
			{
				if ((this._codigo != value))
				{
					this.OncodigoChanging(value);
					this.SendPropertyChanging();
					this._codigo = value;
					this.SendPropertyChanged("codigo");
					this.OncodigoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="NVarChar(50)")]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefone", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Telefone
		{
			get
			{
				return this._Telefone;
			}
			set
			{
				if ((this._Telefone != value))
				{
					this.OnTelefoneChanging(value);
					this.SendPropertyChanging();
					this._Telefone = value;
					this.SendPropertyChanged("Telefone");
					this.OnTelefoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Dados do Cliente]", Storage="_Dados", DbType="NVarChar(MAX)")]
		public string Dados
		{
			get
			{
				return this._Dados;
			}
			set
			{
				if ((this._Dados != value))
				{
					this.OnDadosChanging(value);
					this.SendPropertyChanging();
					this._Dados = value;
					this.SendPropertyChanged("Dados");
					this.OnDadosChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591