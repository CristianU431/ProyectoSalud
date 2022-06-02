﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDato.logindc
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bdSalud")]
	public partial class dcLoginDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    partial void InsertMedico(Medico instance);
    partial void UpdateMedico(Medico instance);
    partial void DeleteMedico(Medico instance);
    partial void InsertPaciente(Paciente instance);
    partial void UpdatePaciente(Paciente instance);
    partial void DeletePaciente(Paciente instance);
    #endregion
		
		public dcLoginDataContext() : 
				base(global::CapaDato.Properties.Settings.Default.bdSaludConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dcLoginDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcLoginDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcLoginDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dcLoginDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Login> Login
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<Medico> Medico
		{
			get
			{
				return this.GetTable<Medico>();
			}
		}
		
		public System.Data.Linq.Table<Paciente> Paciente
		{
			get
			{
				return this.GetTable<Paciente>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TLogin")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IdLoguin;
		
		private string _Usuario;
		
		private string _Contrasenia;
		
		private string _Rol;
		
		private string _CodPaciente;
		
		private string _CodMedico;
		
		private EntityRef<Medico> _Medico;
		
		private EntityRef<Paciente> _Paciente;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdLoguinChanging(int value);
    partial void OnIdLoguinChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContraseniaChanging(string value);
    partial void OnContraseniaChanged();
    partial void OnRolChanging(string value);
    partial void OnRolChanged();
    partial void OnCodPacienteChanging(string value);
    partial void OnCodPacienteChanged();
    partial void OnCodMedicoChanging(string value);
    partial void OnCodMedicoChanged();
    #endregion
		
		public Login()
		{
			this._Medico = default(EntityRef<Medico>);
			this._Paciente = default(EntityRef<Paciente>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdLoguin", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int IdLoguin
		{
			get
			{
				return this._IdLoguin;
			}
			set
			{
				if ((this._IdLoguin != value))
				{
					this.OnIdLoguinChanging(value);
					this.SendPropertyChanging();
					this._IdLoguin = value;
					this.SendPropertyChanged("IdLoguin");
					this.OnIdLoguinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasenia", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Contrasenia
		{
			get
			{
				return this._Contrasenia;
			}
			set
			{
				if ((this._Contrasenia != value))
				{
					this.OnContraseniaChanging(value);
					this.SendPropertyChanging();
					this._Contrasenia = value;
					this.SendPropertyChanged("Contrasenia");
					this.OnContraseniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rol", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Rol
		{
			get
			{
				return this._Rol;
			}
			set
			{
				if ((this._Rol != value))
				{
					this.OnRolChanging(value);
					this.SendPropertyChanging();
					this._Rol = value;
					this.SendPropertyChanged("Rol");
					this.OnRolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodPaciente", DbType="VarChar(15)")]
		public string CodPaciente
		{
			get
			{
				return this._CodPaciente;
			}
			set
			{
				if ((this._CodPaciente != value))
				{
					if (this._Paciente.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodPacienteChanging(value);
					this.SendPropertyChanging();
					this._CodPaciente = value;
					this.SendPropertyChanged("CodPaciente");
					this.OnCodPacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodMedico", DbType="VarChar(10)")]
		public string CodMedico
		{
			get
			{
				return this._CodMedico;
			}
			set
			{
				if ((this._CodMedico != value))
				{
					if (this._Medico.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCodMedicoChanging(value);
					this.SendPropertyChanging();
					this._CodMedico = value;
					this.SendPropertyChanged("CodMedico");
					this.OnCodMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TMedico_TLogin", Storage="_Medico", ThisKey="CodMedico", OtherKey="CodMedico", IsForeignKey=true)]
		public Medico Medico
		{
			get
			{
				return this._Medico.Entity;
			}
			set
			{
				Medico previousValue = this._Medico.Entity;
				if (((previousValue != value) 
							|| (this._Medico.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Medico.Entity = null;
						previousValue.Login.Remove(this);
					}
					this._Medico.Entity = value;
					if ((value != null))
					{
						value.Login.Add(this);
						this._CodMedico = value.CodMedico;
					}
					else
					{
						this._CodMedico = default(string);
					}
					this.SendPropertyChanged("Medico");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TPaciente_TLogin", Storage="_Paciente", ThisKey="CodPaciente", OtherKey="Dni", IsForeignKey=true)]
		public Paciente Paciente
		{
			get
			{
				return this._Paciente.Entity;
			}
			set
			{
				Paciente previousValue = this._Paciente.Entity;
				if (((previousValue != value) 
							|| (this._Paciente.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Paciente.Entity = null;
						previousValue.Login.Remove(this);
					}
					this._Paciente.Entity = value;
					if ((value != null))
					{
						value.Login.Add(this);
						this._CodPaciente = value.Dni;
					}
					else
					{
						this._CodPaciente = default(string);
					}
					this.SendPropertyChanged("Paciente");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TMedico")]
	public partial class Medico : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CodMedico;
		
		private string _NombreMedico;
		
		private string _ApellidoMedico;
		
		private string _IdEspecialidad;
		
		private EntitySet<Login> _Login;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodMedicoChanging(string value);
    partial void OnCodMedicoChanged();
    partial void OnNombreMedicoChanging(string value);
    partial void OnNombreMedicoChanged();
    partial void OnApellidoMedicoChanging(string value);
    partial void OnApellidoMedicoChanged();
    partial void OnIdEspecialidadChanging(string value);
    partial void OnIdEspecialidadChanged();
    #endregion
		
		public Medico()
		{
			this._Login = new EntitySet<Login>(new Action<Login>(this.attach_Login), new Action<Login>(this.detach_Login));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodMedico", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CodMedico
		{
			get
			{
				return this._CodMedico;
			}
			set
			{
				if ((this._CodMedico != value))
				{
					this.OnCodMedicoChanging(value);
					this.SendPropertyChanging();
					this._CodMedico = value;
					this.SendPropertyChanged("CodMedico");
					this.OnCodMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreMedico", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string NombreMedico
		{
			get
			{
				return this._NombreMedico;
			}
			set
			{
				if ((this._NombreMedico != value))
				{
					this.OnNombreMedicoChanging(value);
					this.SendPropertyChanging();
					this._NombreMedico = value;
					this.SendPropertyChanged("NombreMedico");
					this.OnNombreMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoMedico", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string ApellidoMedico
		{
			get
			{
				return this._ApellidoMedico;
			}
			set
			{
				if ((this._ApellidoMedico != value))
				{
					this.OnApellidoMedicoChanging(value);
					this.SendPropertyChanging();
					this._ApellidoMedico = value;
					this.SendPropertyChanged("ApellidoMedico");
					this.OnApellidoMedicoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdEspecialidad", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string IdEspecialidad
		{
			get
			{
				return this._IdEspecialidad;
			}
			set
			{
				if ((this._IdEspecialidad != value))
				{
					this.OnIdEspecialidadChanging(value);
					this.SendPropertyChanging();
					this._IdEspecialidad = value;
					this.SendPropertyChanged("IdEspecialidad");
					this.OnIdEspecialidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TMedico_TLogin", Storage="_Login", ThisKey="CodMedico", OtherKey="CodMedico")]
		public EntitySet<Login> Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				this._Login.Assign(value);
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
		
		private void attach_Login(Login entity)
		{
			this.SendPropertyChanging();
			entity.Medico = this;
		}
		
		private void detach_Login(Login entity)
		{
			this.SendPropertyChanging();
			entity.Medico = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TPaciente")]
	public partial class Paciente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Dni;
		
		private string _NombrePaciente;
		
		private string _ApellidoPaciente;
		
		private string _Direccion;
		
		private string _Genero;
		
		private string _FechaNacimiento;
		
		private EntitySet<Login> _Login;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDniChanging(string value);
    partial void OnDniChanged();
    partial void OnNombrePacienteChanging(string value);
    partial void OnNombrePacienteChanged();
    partial void OnApellidoPacienteChanging(string value);
    partial void OnApellidoPacienteChanged();
    partial void OnDireccionChanging(string value);
    partial void OnDireccionChanged();
    partial void OnGeneroChanging(string value);
    partial void OnGeneroChanged();
    partial void OnFechaNacimientoChanging(string value);
    partial void OnFechaNacimientoChanged();
    #endregion
		
		public Paciente()
		{
			this._Login = new EntitySet<Login>(new Action<Login>(this.attach_Login), new Action<Login>(this.detach_Login));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dni", DbType="VarChar(15) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Dni
		{
			get
			{
				return this._Dni;
			}
			set
			{
				if ((this._Dni != value))
				{
					this.OnDniChanging(value);
					this.SendPropertyChanging();
					this._Dni = value;
					this.SendPropertyChanged("Dni");
					this.OnDniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombrePaciente", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string NombrePaciente
		{
			get
			{
				return this._NombrePaciente;
			}
			set
			{
				if ((this._NombrePaciente != value))
				{
					this.OnNombrePacienteChanging(value);
					this.SendPropertyChanging();
					this._NombrePaciente = value;
					this.SendPropertyChanged("NombrePaciente");
					this.OnNombrePacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApellidoPaciente", DbType="VarChar(45) NOT NULL", CanBeNull=false)]
		public string ApellidoPaciente
		{
			get
			{
				return this._ApellidoPaciente;
			}
			set
			{
				if ((this._ApellidoPaciente != value))
				{
					this.OnApellidoPacienteChanging(value);
					this.SendPropertyChanging();
					this._ApellidoPaciente = value;
					this.SendPropertyChanged("ApellidoPaciente");
					this.OnApellidoPacienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Direccion", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Direccion
		{
			get
			{
				return this._Direccion;
			}
			set
			{
				if ((this._Direccion != value))
				{
					this.OnDireccionChanging(value);
					this.SendPropertyChanging();
					this._Direccion = value;
					this.SendPropertyChanged("Direccion");
					this.OnDireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Genero
		{
			get
			{
				return this._Genero;
			}
			set
			{
				if ((this._Genero != value))
				{
					this.OnGeneroChanging(value);
					this.SendPropertyChanging();
					this._Genero = value;
					this.SendPropertyChanged("Genero");
					this.OnGeneroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FechaNacimiento", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string FechaNacimiento
		{
			get
			{
				return this._FechaNacimiento;
			}
			set
			{
				if ((this._FechaNacimiento != value))
				{
					this.OnFechaNacimientoChanging(value);
					this.SendPropertyChanging();
					this._FechaNacimiento = value;
					this.SendPropertyChanged("FechaNacimiento");
					this.OnFechaNacimientoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TPaciente_TLogin", Storage="_Login", ThisKey="Dni", OtherKey="CodPaciente")]
		public EntitySet<Login> Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				this._Login.Assign(value);
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
		
		private void attach_Login(Login entity)
		{
			this.SendPropertyChanging();
			entity.Paciente = this;
		}
		
		private void detach_Login(Login entity)
		{
			this.SendPropertyChanging();
			entity.Paciente = null;
		}
	}
}
#pragma warning restore 1591