﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace biegi_rejestracja.Tabela_baza_danych
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Bieg_rejestracja")]
	public partial class zawodnikDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertZawodnik(Zawodnik instance);
    partial void UpdateZawodnik(Zawodnik instance);
    partial void DeleteZawodnik(Zawodnik instance);
    #endregion
		
		public zawodnikDataContext() : 
				base(global::biegi_rejestracja.Properties.Settings.Default.Bieg_rejestracjaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public zawodnikDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public zawodnikDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public zawodnikDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public zawodnikDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Zawodnik> Zawodnik
		{
			get
			{
				return this.GetTable<Zawodnik>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Zawodnik")]
	public partial class Zawodnik : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Imie;
		
		private string _Nazwisko;
		
		private string _Login;
		
		private string _Haslo;
		
		private string _Email;
		
		private System.DateTime _Data_urodzenia;
		
		private string _Płeć;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnImieChanging(string value);
    partial void OnImieChanged();
    partial void OnNazwiskoChanging(string value);
    partial void OnNazwiskoChanged();
    partial void OnLoginChanging(string value);
    partial void OnLoginChanged();
    partial void OnHasloChanging(string value);
    partial void OnHasloChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnData_urodzeniaChanging(System.DateTime value);
    partial void OnData_urodzeniaChanged();
    partial void OnPłećChanging(string value);
    partial void OnPłećChanged();
    #endregion
		
		public Zawodnik()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imie", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Imie
		{
			get
			{
				return this._Imie;
			}
			set
			{
				if ((this._Imie != value))
				{
					this.OnImieChanging(value);
					this.SendPropertyChanging();
					this._Imie = value;
					this.SendPropertyChanged("Imie");
					this.OnImieChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nazwisko", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Nazwisko
		{
			get
			{
				return this._Nazwisko;
			}
			set
			{
				if ((this._Nazwisko != value))
				{
					this.OnNazwiskoChanging(value);
					this.SendPropertyChanging();
					this._Nazwisko = value;
					this.SendPropertyChanged("Nazwisko");
					this.OnNazwiskoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Login", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Login
		{
			get
			{
				return this._Login;
			}
			set
			{
				if ((this._Login != value))
				{
					this.OnLoginChanging(value);
					this.SendPropertyChanging();
					this._Login = value;
					this.SendPropertyChanged("Login");
					this.OnLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Haslo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Haslo
		{
			get
			{
				return this._Haslo;
			}
			set
			{
				if ((this._Haslo != value))
				{
					this.OnHasloChanging(value);
					this.SendPropertyChanging();
					this._Haslo = value;
					this.SendPropertyChanged("Haslo");
					this.OnHasloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data_urodzenia", DbType="Date NOT NULL")]
		public System.DateTime Data_urodzenia
		{
			get
			{
				return this._Data_urodzenia;
			}
			set
			{
				if ((this._Data_urodzenia != value))
				{
					this.OnData_urodzeniaChanging(value);
					this.SendPropertyChanging();
					this._Data_urodzenia = value;
					this.SendPropertyChanged("Data_urodzenia");
					this.OnData_urodzeniaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Płeć", DbType="VarChar(1) NOT NULL", CanBeNull=false)]
		public string Płeć
		{
			get
			{
				return this._Płeć;
			}
			set
			{
				if ((this._Płeć != value))
				{
					this.OnPłećChanging(value);
					this.SendPropertyChanging();
					this._Płeć = value;
					this.SendPropertyChanged("Płeć");
					this.OnPłećChanged();
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