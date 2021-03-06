﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MOVIESDB.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="IES_Dev")]
	public partial class DataClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActor(Actor instance);
    partial void UpdateActor(Actor instance);
    partial void DeleteActor(Actor instance);
    partial void InsertMovie(Movie instance);
    partial void UpdateMovie(Movie instance);
    partial void DeleteMovie(Movie instance);
    partial void InsertProducer(Producer instance);
    partial void UpdateProducer(Producer instance);
    partial void DeleteProducer(Producer instance);
    partial void InsertFilmDetail(FilmDetail instance);
    partial void UpdateFilmDetail(FilmDetail instance);
    partial void DeleteFilmDetail(FilmDetail instance);
    #endregion
		
		public DataClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["IES_DevConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Actor> Actors
		{
			get
			{
				return this.GetTable<Actor>();
			}
		}
		
		public System.Data.Linq.Table<Movie> Movies
		{
			get
			{
				return this.GetTable<Movie>();
			}
		}
		
		public System.Data.Linq.Table<Producer> Producers
		{
			get
			{
				return this.GetTable<Producer>();
			}
		}
		
		public System.Data.Linq.Table<FilmDetail> FilmDetails
		{
			get
			{
				return this.GetTable<FilmDetail>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Actor")]
	public partial class Actor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ActorID;
		
		private string _Name;
		
		private string _Sex;
		
		private System.Nullable<System.DateTime> _Dob;
		
		private string _Bio;
		
		private EntitySet<FilmDetail> _FilmDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActorIDChanging(int value);
    partial void OnActorIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnDobChanging(System.Nullable<System.DateTime> value);
    partial void OnDobChanged();
    partial void OnBioChanging(string value);
    partial void OnBioChanged();
    #endregion
		
		public Actor()
		{
			this._FilmDetails = new EntitySet<FilmDetail>(new Action<FilmDetail>(this.attach_FilmDetails), new Action<FilmDetail>(this.detach_FilmDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ActorID
		{
			get
			{
				return this._ActorID;
			}
			set
			{
				if ((this._ActorID != value))
				{
					this.OnActorIDChanging(value);
					this.SendPropertyChanging();
					this._ActorID = value;
					this.SendPropertyChanged("ActorID");
					this.OnActorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NVarChar(20)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dob", DbType="DateTime")]
		public System.Nullable<System.DateTime> Dob
		{
			get
			{
				return this._Dob;
			}
			set
			{
				if ((this._Dob != value))
				{
					this.OnDobChanging(value);
					this.SendPropertyChanging();
					this._Dob = value;
					this.SendPropertyChanged("Dob");
					this.OnDobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bio", DbType="NVarChar(MAX)")]
		public string Bio
		{
			get
			{
				return this._Bio;
			}
			set
			{
				if ((this._Bio != value))
				{
					this.OnBioChanging(value);
					this.SendPropertyChanging();
					this._Bio = value;
					this.SendPropertyChanged("Bio");
					this.OnBioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Actor_FilmDetail", Storage="_FilmDetails", ThisKey="ActorID", OtherKey="ActorId")]
		public EntitySet<FilmDetail> FilmDetails
		{
			get
			{
				return this._FilmDetails;
			}
			set
			{
				this._FilmDetails.Assign(value);
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
		
		private void attach_FilmDetails(FilmDetail entity)
		{
			this.SendPropertyChanging();
			entity.Actor = this;
		}
		
		private void detach_FilmDetails(FilmDetail entity)
		{
			this.SendPropertyChanging();
			entity.Actor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movie")]
	public partial class Movie : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieID;
		
		private string _Name;
		
		private System.Nullable<System.DateTime> _YoR;
		
		private string _Plot;
		
		private EntitySet<FilmDetail> _FilmDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnYoRChanging(System.Nullable<System.DateTime> value);
    partial void OnYoRChanged();
    partial void OnPlotChanging(string value);
    partial void OnPlotChanged();
    #endregion
		
		public Movie()
		{
			this._FilmDetails = new EntitySet<FilmDetail>(new Action<FilmDetail>(this.attach_FilmDetails), new Action<FilmDetail>(this.detach_FilmDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YoR", DbType="DateTime")]
		public System.Nullable<System.DateTime> YoR
		{
			get
			{
				return this._YoR;
			}
			set
			{
				if ((this._YoR != value))
				{
					this.OnYoRChanging(value);
					this.SendPropertyChanging();
					this._YoR = value;
					this.SendPropertyChanged("YoR");
					this.OnYoRChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plot", DbType="NVarChar(MAX)")]
		public string Plot
		{
			get
			{
				return this._Plot;
			}
			set
			{
				if ((this._Plot != value))
				{
					this.OnPlotChanging(value);
					this.SendPropertyChanging();
					this._Plot = value;
					this.SendPropertyChanged("Plot");
					this.OnPlotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_FilmDetail", Storage="_FilmDetails", ThisKey="MovieID", OtherKey="MovieID")]
		public EntitySet<FilmDetail> FilmDetails
		{
			get
			{
				return this._FilmDetails;
			}
			set
			{
				this._FilmDetails.Assign(value);
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
		
		private void attach_FilmDetails(FilmDetail entity)
		{
			this.SendPropertyChanging();
			entity.Movie = this;
		}
		
		private void detach_FilmDetails(FilmDetail entity)
		{
			this.SendPropertyChanging();
			entity.Movie = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Producer")]
	public partial class Producer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProducerID;
		
		private string _Name;
		
		private string _Sex;
		
		private System.Nullable<System.DateTime> _Dob;
		
		private string _Bio;
		
		private EntitySet<FilmDetail> _FilmDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProducerIDChanging(int value);
    partial void OnProducerIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnDobChanging(System.Nullable<System.DateTime> value);
    partial void OnDobChanged();
    partial void OnBioChanging(string value);
    partial void OnBioChanged();
    #endregion
		
		public Producer()
		{
			this._FilmDetails = new EntitySet<FilmDetail>(new Action<FilmDetail>(this.attach_FilmDetails), new Action<FilmDetail>(this.detach_FilmDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProducerID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ProducerID
		{
			get
			{
				return this._ProducerID;
			}
			set
			{
				if ((this._ProducerID != value))
				{
					this.OnProducerIDChanging(value);
					this.SendPropertyChanging();
					this._ProducerID = value;
					this.SendPropertyChanged("ProducerID");
					this.OnProducerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NVarChar(20)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dob", DbType="DateTime")]
		public System.Nullable<System.DateTime> Dob
		{
			get
			{
				return this._Dob;
			}
			set
			{
				if ((this._Dob != value))
				{
					this.OnDobChanging(value);
					this.SendPropertyChanging();
					this._Dob = value;
					this.SendPropertyChanged("Dob");
					this.OnDobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bio", DbType="NVarChar(MAX)")]
		public string Bio
		{
			get
			{
				return this._Bio;
			}
			set
			{
				if ((this._Bio != value))
				{
					this.OnBioChanging(value);
					this.SendPropertyChanging();
					this._Bio = value;
					this.SendPropertyChanged("Bio");
					this.OnBioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producer_FilmDetail", Storage="_FilmDetails", ThisKey="ProducerID", OtherKey="ProducerID")]
		public EntitySet<FilmDetail> FilmDetails
		{
			get
			{
				return this._FilmDetails;
			}
			set
			{
				this._FilmDetails.Assign(value);
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
		
		private void attach_FilmDetails(FilmDetail entity)
		{
			this.SendPropertyChanging();
			entity.Producer = this;
		}
		
		private void detach_FilmDetails(FilmDetail entity)
		{
			this.SendPropertyChanging();
			entity.Producer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FilmDetails")]
	public partial class FilmDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _FilmId;
		
		private System.Nullable<int> _ActorId;
		
		private System.Nullable<int> _MovieID;
		
		private System.Nullable<int> _ProducerID;
		
		private EntityRef<Actor> _Actor;
		
		private EntityRef<Movie> _Movie;
		
		private EntityRef<Producer> _Producer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnFilmIdChanging(int value);
    partial void OnFilmIdChanged();
    partial void OnActorIdChanging(System.Nullable<int> value);
    partial void OnActorIdChanged();
    partial void OnMovieIDChanging(System.Nullable<int> value);
    partial void OnMovieIDChanged();
    partial void OnProducerIDChanging(System.Nullable<int> value);
    partial void OnProducerIDChanged();
    #endregion
		
		public FilmDetail()
		{
			this._Actor = default(EntityRef<Actor>);
			this._Movie = default(EntityRef<Movie>);
			this._Producer = default(EntityRef<Producer>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FilmId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int FilmId
		{
			get
			{
				return this._FilmId;
			}
			set
			{
				if ((this._FilmId != value))
				{
					this.OnFilmIdChanging(value);
					this.SendPropertyChanging();
					this._FilmId = value;
					this.SendPropertyChanged("FilmId");
					this.OnFilmIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActorId", DbType="Int")]
		public System.Nullable<int> ActorId
		{
			get
			{
				return this._ActorId;
			}
			set
			{
				if ((this._ActorId != value))
				{
					if (this._Actor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActorIdChanging(value);
					this.SendPropertyChanging();
					this._ActorId = value;
					this.SendPropertyChanged("ActorId");
					this.OnActorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", DbType="Int")]
		public System.Nullable<int> MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					if (this._Movie.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProducerID", DbType="Int")]
		public System.Nullable<int> ProducerID
		{
			get
			{
				return this._ProducerID;
			}
			set
			{
				if ((this._ProducerID != value))
				{
					if (this._Producer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProducerIDChanging(value);
					this.SendPropertyChanging();
					this._ProducerID = value;
					this.SendPropertyChanged("ProducerID");
					this.OnProducerIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Actor_FilmDetail", Storage="_Actor", ThisKey="ActorId", OtherKey="ActorID", IsForeignKey=true)]
		public Actor Actor
		{
			get
			{
				return this._Actor.Entity;
			}
			set
			{
				Actor previousValue = this._Actor.Entity;
				if (((previousValue != value) 
							|| (this._Actor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Actor.Entity = null;
						previousValue.FilmDetails.Remove(this);
					}
					this._Actor.Entity = value;
					if ((value != null))
					{
						value.FilmDetails.Add(this);
						this._ActorId = value.ActorID;
					}
					else
					{
						this._ActorId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Actor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movie_FilmDetail", Storage="_Movie", ThisKey="MovieID", OtherKey="MovieID", IsForeignKey=true)]
		public Movie Movie
		{
			get
			{
				return this._Movie.Entity;
			}
			set
			{
				Movie previousValue = this._Movie.Entity;
				if (((previousValue != value) 
							|| (this._Movie.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movie.Entity = null;
						previousValue.FilmDetails.Remove(this);
					}
					this._Movie.Entity = value;
					if ((value != null))
					{
						value.FilmDetails.Add(this);
						this._MovieID = value.MovieID;
					}
					else
					{
						this._MovieID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Movie");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Producer_FilmDetail", Storage="_Producer", ThisKey="ProducerID", OtherKey="ProducerID", IsForeignKey=true)]
		public Producer Producer
		{
			get
			{
				return this._Producer.Entity;
			}
			set
			{
				Producer previousValue = this._Producer.Entity;
				if (((previousValue != value) 
							|| (this._Producer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Producer.Entity = null;
						previousValue.FilmDetails.Remove(this);
					}
					this._Producer.Entity = value;
					if ((value != null))
					{
						value.FilmDetails.Add(this);
						this._ProducerID = value.ProducerID;
					}
					else
					{
						this._ProducerID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Producer");
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
