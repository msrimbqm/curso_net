#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace alumnos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="GESTIONALU")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::alumnos.Properties.Settings.Default.GESTIONALUConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.listar")]
		public ISingleResult<listarResult> listar()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<listarResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.APbuscarcodigo")]
		public ISingleResult<APbuscarcodigoResult> APbuscarcodigo([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> codigo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), codigo);
			return ((ISingleResult<APbuscarcodigoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.APbuscardni")]
		public ISingleResult<APbuscardniResult> APbuscardni([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string dni)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dni);
			return ((ISingleResult<APbuscardniResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.APcontardni")]
		public ISingleResult<APcontardniResult> APcontardni([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string dni)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dni);
			return ((ISingleResult<APcontardniResult>)(result.ReturnValue));
		}
	}
	
	public partial class listarResult
	{
		
		private int _Codigo;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public listarResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="Int NOT NULL")]
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
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="VarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="VarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="VarChar(10)")]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="VarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class APbuscarcodigoResult
	{
		
		private int _Codigo;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public APbuscarcodigoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="Int NOT NULL")]
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
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="VarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="VarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="VarChar(10)")]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="VarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class APbuscardniResult
	{
		
		private int _Codigo;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public APbuscardniResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Codigo", DbType="Int NOT NULL")]
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
					this._Codigo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="VarChar(10)")]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="VarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="VarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="VarChar(10)")]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="VarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class APcontardniResult
	{
		
		private System.Nullable<int> _Column1;
		
		public APcontardniResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="", Storage="_Column1", DbType="Int")]
		public System.Nullable<int> Column1
		{
			get
			{
				return this._Column1;
			}
			set
			{
				if ((this._Column1 != value))
				{
					this._Column1 = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
