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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="RDSICA")]
public partial class RDSICADataClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertTutorialCategory(TutorialCategory instance);
  partial void UpdateTutorialCategory(TutorialCategory instance);
  partial void DeleteTutorialCategory(TutorialCategory instance);
  partial void InsertTutorialItem(TutorialItem instance);
  partial void UpdateTutorialItem(TutorialItem instance);
  partial void DeleteTutorialItem(TutorialItem instance);
  partial void InsertUser(User instance);
  partial void UpdateUser(User instance);
  partial void DeleteUser(User instance);
  partial void InsertAdmin(Admin instance);
  partial void UpdateAdmin(Admin instance);
  partial void DeleteAdmin(Admin instance);
  partial void InserttblVideo(tblVideo instance);
  partial void UpdatetblVideo(tblVideo instance);
  partial void DeletetblVideo(tblVideo instance);
  #endregion
	
	public RDSICADataClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString1"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public RDSICADataClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public RDSICADataClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public RDSICADataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public RDSICADataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<TutorialCategory> TutorialCategories
	{
		get
		{
			return this.GetTable<TutorialCategory>();
		}
	}
	
	public System.Data.Linq.Table<TutorialItem> TutorialItems
	{
		get
		{
			return this.GetTable<TutorialItem>();
		}
	}
	
	public System.Data.Linq.Table<User> Users
	{
		get
		{
			return this.GetTable<User>();
		}
	}
	
	public System.Data.Linq.Table<Admin> Admins
	{
		get
		{
			return this.GetTable<Admin>();
		}
	}
	
	public System.Data.Linq.Table<tblVideo> tblVideos
	{
		get
		{
			return this.GetTable<tblVideo>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TutorialCategory")]
public partial class TutorialCategory : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _CategoryID;
	
	private string _CategoryName;
	
	private EntitySet<TutorialItem> _TutorialItems;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIDChanging(int value);
    partial void OnCategoryIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    #endregion
	
	public TutorialCategory()
	{
		this._TutorialItems = new EntitySet<TutorialItem>(new Action<TutorialItem>(this.attach_TutorialItems), new Action<TutorialItem>(this.detach_TutorialItems));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(50)")]
	public string CategoryName
	{
		get
		{
			return this._CategoryName;
		}
		set
		{
			if ((this._CategoryName != value))
			{
				this.OnCategoryNameChanging(value);
				this.SendPropertyChanging();
				this._CategoryName = value;
				this.SendPropertyChanged("CategoryName");
				this.OnCategoryNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TutorialCategory_TutorialItem", Storage="_TutorialItems", ThisKey="CategoryID", OtherKey="CategoryID")]
	public EntitySet<TutorialItem> TutorialItems
	{
		get
		{
			return this._TutorialItems;
		}
		set
		{
			this._TutorialItems.Assign(value);
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
	
	private void attach_TutorialItems(TutorialItem entity)
	{
		this.SendPropertyChanging();
		entity.TutorialCategory = this;
	}
	
	private void detach_TutorialItems(TutorialItem entity)
	{
		this.SendPropertyChanging();
		entity.TutorialCategory = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TutorialItem")]
public partial class TutorialItem : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _ItemID;
	
	private System.Nullable<int> _CategoryID;
	
	private System.Nullable<int> _UserID;
	
	private System.Nullable<int> _AdminID;
	
	private string _ItemName;
	
	private EntitySet<tblVideo> _tblVideos;
	
	private EntityRef<TutorialCategory> _TutorialCategory;
	
	private EntityRef<User> _User;
	
	private EntityRef<Admin> _Admin;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(int value);
    partial void OnItemIDChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnAdminIDChanging(System.Nullable<int> value);
    partial void OnAdminIDChanged();
    partial void OnItemNameChanging(string value);
    partial void OnItemNameChanged();
    #endregion
	
	public TutorialItem()
	{
		this._tblVideos = new EntitySet<tblVideo>(new Action<tblVideo>(this.attach_tblVideos), new Action<tblVideo>(this.detach_tblVideos));
		this._TutorialCategory = default(EntityRef<TutorialCategory>);
		this._User = default(EntityRef<User>);
		this._Admin = default(EntityRef<Admin>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int ItemID
	{
		get
		{
			return this._ItemID;
		}
		set
		{
			if ((this._ItemID != value))
			{
				this.OnItemIDChanging(value);
				this.SendPropertyChanging();
				this._ItemID = value;
				this.SendPropertyChanged("ItemID");
				this.OnItemIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
	public System.Nullable<int> CategoryID
	{
		get
		{
			return this._CategoryID;
		}
		set
		{
			if ((this._CategoryID != value))
			{
				if (this._TutorialCategory.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnCategoryIDChanging(value);
				this.SendPropertyChanging();
				this._CategoryID = value;
				this.SendPropertyChanged("CategoryID");
				this.OnCategoryIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
	public System.Nullable<int> UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				if (this._User.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", DbType="Int")]
	public System.Nullable<int> AdminID
	{
		get
		{
			return this._AdminID;
		}
		set
		{
			if ((this._AdminID != value))
			{
				if (this._Admin.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAdminIDChanging(value);
				this.SendPropertyChanging();
				this._AdminID = value;
				this.SendPropertyChanged("AdminID");
				this.OnAdminIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemName", DbType="NVarChar(50)")]
	public string ItemName
	{
		get
		{
			return this._ItemName;
		}
		set
		{
			if ((this._ItemName != value))
			{
				this.OnItemNameChanging(value);
				this.SendPropertyChanging();
				this._ItemName = value;
				this.SendPropertyChanged("ItemName");
				this.OnItemNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TutorialItem_tblVideo", Storage="_tblVideos", ThisKey="ItemID", OtherKey="Id")]
	public EntitySet<tblVideo> tblVideos
	{
		get
		{
			return this._tblVideos;
		}
		set
		{
			this._tblVideos.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TutorialCategory_TutorialItem", Storage="_TutorialCategory", ThisKey="CategoryID", OtherKey="CategoryID", IsForeignKey=true)]
	public TutorialCategory TutorialCategory
	{
		get
		{
			return this._TutorialCategory.Entity;
		}
		set
		{
			TutorialCategory previousValue = this._TutorialCategory.Entity;
			if (((previousValue != value) 
						|| (this._TutorialCategory.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._TutorialCategory.Entity = null;
					previousValue.TutorialItems.Remove(this);
				}
				this._TutorialCategory.Entity = value;
				if ((value != null))
				{
					value.TutorialItems.Add(this);
					this._CategoryID = value.CategoryID;
				}
				else
				{
					this._CategoryID = default(Nullable<int>);
				}
				this.SendPropertyChanged("TutorialCategory");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_TutorialItem", Storage="_User", ThisKey="UserID", OtherKey="UserId", IsForeignKey=true)]
	public User User
	{
		get
		{
			return this._User.Entity;
		}
		set
		{
			User previousValue = this._User.Entity;
			if (((previousValue != value) 
						|| (this._User.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._User.Entity = null;
					previousValue.TutorialItems.Remove(this);
				}
				this._User.Entity = value;
				if ((value != null))
				{
					value.TutorialItems.Add(this);
					this._UserID = value.UserId;
				}
				else
				{
					this._UserID = default(Nullable<int>);
				}
				this.SendPropertyChanged("User");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_TutorialItem", Storage="_Admin", ThisKey="AdminID", OtherKey="AdminID", IsForeignKey=true)]
	public Admin Admin
	{
		get
		{
			return this._Admin.Entity;
		}
		set
		{
			Admin previousValue = this._Admin.Entity;
			if (((previousValue != value) 
						|| (this._Admin.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Admin.Entity = null;
					previousValue.TutorialItems.Remove(this);
				}
				this._Admin.Entity = value;
				if ((value != null))
				{
					value.TutorialItems.Add(this);
					this._AdminID = value.AdminID;
				}
				else
				{
					this._AdminID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Admin");
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
	
	private void attach_tblVideos(tblVideo entity)
	{
		this.SendPropertyChanging();
		entity.TutorialItem = this;
	}
	
	private void detach_tblVideos(tblVideo entity)
	{
		this.SendPropertyChanging();
		entity.TutorialItem = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _UserId;
	
	private string _Username;
	
	private string _Password;
	
	private string _Email;
	
	private System.DateTime _CreatedDate;
	
	private System.Nullable<System.DateTime> _LastLoginDate;
	
	private System.Nullable<int> _AdminID;
	
	private EntitySet<TutorialItem> _TutorialItems;
	
	private EntityRef<Admin> _Admin;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnLastLoginDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastLoginDateChanged();
    partial void OnAdminIDChanging(System.Nullable<int> value);
    partial void OnAdminIDChanged();
    #endregion
	
	public User()
	{
		this._TutorialItems = new EntitySet<TutorialItem>(new Action<TutorialItem>(this.attach_TutorialItems), new Action<TutorialItem>(this.detach_TutorialItems));
		this._Admin = default(EntityRef<Admin>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int UserId
	{
		get
		{
			return this._UserId;
		}
		set
		{
			if ((this._UserId != value))
			{
				this.OnUserIdChanging(value);
				this.SendPropertyChanging();
				this._UserId = value;
				this.SendPropertyChanged("UserId");
				this.OnUserIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
	public string Username
	{
		get
		{
			return this._Username;
		}
		set
		{
			if ((this._Username != value))
			{
				this.OnUsernameChanging(value);
				this.SendPropertyChanging();
				this._Username = value;
				this.SendPropertyChanged("Username");
				this.OnUsernameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
	public System.DateTime CreatedDate
	{
		get
		{
			return this._CreatedDate;
		}
		set
		{
			if ((this._CreatedDate != value))
			{
				this.OnCreatedDateChanging(value);
				this.SendPropertyChanging();
				this._CreatedDate = value;
				this.SendPropertyChanged("CreatedDate");
				this.OnCreatedDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastLoginDate", DbType="DateTime")]
	public System.Nullable<System.DateTime> LastLoginDate
	{
		get
		{
			return this._LastLoginDate;
		}
		set
		{
			if ((this._LastLoginDate != value))
			{
				this.OnLastLoginDateChanging(value);
				this.SendPropertyChanging();
				this._LastLoginDate = value;
				this.SendPropertyChanged("LastLoginDate");
				this.OnLastLoginDateChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", DbType="Int")]
	public System.Nullable<int> AdminID
	{
		get
		{
			return this._AdminID;
		}
		set
		{
			if ((this._AdminID != value))
			{
				if (this._Admin.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnAdminIDChanging(value);
				this.SendPropertyChanging();
				this._AdminID = value;
				this.SendPropertyChanged("AdminID");
				this.OnAdminIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_TutorialItem", Storage="_TutorialItems", ThisKey="UserId", OtherKey="UserID")]
	public EntitySet<TutorialItem> TutorialItems
	{
		get
		{
			return this._TutorialItems;
		}
		set
		{
			this._TutorialItems.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_User", Storage="_Admin", ThisKey="AdminID", OtherKey="AdminID", IsForeignKey=true)]
	public Admin Admin
	{
		get
		{
			return this._Admin.Entity;
		}
		set
		{
			Admin previousValue = this._Admin.Entity;
			if (((previousValue != value) 
						|| (this._Admin.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Admin.Entity = null;
					previousValue.Users.Remove(this);
				}
				this._Admin.Entity = value;
				if ((value != null))
				{
					value.Users.Add(this);
					this._AdminID = value.AdminID;
				}
				else
				{
					this._AdminID = default(Nullable<int>);
				}
				this.SendPropertyChanged("Admin");
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
	
	private void attach_TutorialItems(TutorialItem entity)
	{
		this.SendPropertyChanging();
		entity.User = this;
	}
	
	private void detach_TutorialItems(TutorialItem entity)
	{
		this.SendPropertyChanging();
		entity.User = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Admin")]
public partial class Admin : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _AdminID;
	
	private System.Nullable<int> _UserID;
	
	private string _AdminName;
	
	private EntitySet<TutorialItem> _TutorialItems;
	
	private EntitySet<User> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdminIDChanging(int value);
    partial void OnAdminIDChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    partial void OnAdminNameChanging(string value);
    partial void OnAdminNameChanged();
    #endregion
	
	public Admin()
	{
		this._TutorialItems = new EntitySet<TutorialItem>(new Action<TutorialItem>(this.attach_TutorialItems), new Action<TutorialItem>(this.detach_TutorialItems));
		this._Users = new EntitySet<User>(new Action<User>(this.attach_Users), new Action<User>(this.detach_Users));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminID", DbType="Int NOT NULL", IsPrimaryKey=true)]
	public int AdminID
	{
		get
		{
			return this._AdminID;
		}
		set
		{
			if ((this._AdminID != value))
			{
				this.OnAdminIDChanging(value);
				this.SendPropertyChanging();
				this._AdminID = value;
				this.SendPropertyChanged("AdminID");
				this.OnAdminIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
	public System.Nullable<int> UserID
	{
		get
		{
			return this._UserID;
		}
		set
		{
			if ((this._UserID != value))
			{
				this.OnUserIDChanging(value);
				this.SendPropertyChanging();
				this._UserID = value;
				this.SendPropertyChanged("UserID");
				this.OnUserIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdminName", DbType="NVarChar(50)")]
	public string AdminName
	{
		get
		{
			return this._AdminName;
		}
		set
		{
			if ((this._AdminName != value))
			{
				this.OnAdminNameChanging(value);
				this.SendPropertyChanging();
				this._AdminName = value;
				this.SendPropertyChanged("AdminName");
				this.OnAdminNameChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_TutorialItem", Storage="_TutorialItems", ThisKey="AdminID", OtherKey="AdminID")]
	public EntitySet<TutorialItem> TutorialItems
	{
		get
		{
			return this._TutorialItems;
		}
		set
		{
			this._TutorialItems.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Admin_User", Storage="_Users", ThisKey="AdminID", OtherKey="AdminID")]
	public EntitySet<User> Users
	{
		get
		{
			return this._Users;
		}
		set
		{
			this._Users.Assign(value);
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
	
	private void attach_TutorialItems(TutorialItem entity)
	{
		this.SendPropertyChanging();
		entity.Admin = this;
	}
	
	private void detach_TutorialItems(TutorialItem entity)
	{
		this.SendPropertyChanging();
		entity.Admin = null;
	}
	
	private void attach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Admin = this;
	}
	
	private void detach_Users(User entity)
	{
		this.SendPropertyChanging();
		entity.Admin = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblVideos")]
public partial class tblVideo : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Id;
	
	private string _Name;
	
	private System.Nullable<int> _Size;
	
	private string _VideoPath;
	
	private EntityRef<TutorialItem> _TutorialItem;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSizeChanging(System.Nullable<int> value);
    partial void OnSizeChanged();
    partial void OnVideoPathChanging(string value);
    partial void OnVideoPathChanged();
    #endregion
	
	public tblVideo()
	{
		this._TutorialItem = default(EntityRef<TutorialItem>);
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
				if (this._TutorialItem.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnIdChanging(value);
				this.SendPropertyChanging();
				this._Id = value;
				this.SendPropertyChanged("Id");
				this.OnIdChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Size", DbType="Int")]
	public System.Nullable<int> Size
	{
		get
		{
			return this._Size;
		}
		set
		{
			if ((this._Size != value))
			{
				this.OnSizeChanging(value);
				this.SendPropertyChanging();
				this._Size = value;
				this.SendPropertyChanged("Size");
				this.OnSizeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VideoPath", DbType="VarChar(MAX)")]
	public string VideoPath
	{
		get
		{
			return this._VideoPath;
		}
		set
		{
			if ((this._VideoPath != value))
			{
				this.OnVideoPathChanging(value);
				this.SendPropertyChanging();
				this._VideoPath = value;
				this.SendPropertyChanged("VideoPath");
				this.OnVideoPathChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="TutorialItem_tblVideo", Storage="_TutorialItem", ThisKey="Id", OtherKey="ItemID", IsForeignKey=true)]
	public TutorialItem TutorialItem
	{
		get
		{
			return this._TutorialItem.Entity;
		}
		set
		{
			TutorialItem previousValue = this._TutorialItem.Entity;
			if (((previousValue != value) 
						|| (this._TutorialItem.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._TutorialItem.Entity = null;
					previousValue.tblVideos.Remove(this);
				}
				this._TutorialItem.Entity = value;
				if ((value != null))
				{
					value.tblVideos.Add(this);
					this._Id = value.ItemID;
				}
				else
				{
					this._Id = default(int);
				}
				this.SendPropertyChanged("TutorialItem");
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
#pragma warning restore 1591
