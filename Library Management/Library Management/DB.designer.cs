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

namespace Library_Management
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LMS")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    partial void InsertMR(MR instance);
    partial void UpdateMR(MR instance);
    partial void DeleteMR(MR instance);
    partial void InsertFR(FR instance);
    partial void UpdateFR(FR instance);
    partial void DeleteFR(FR instance);
    partial void InsertAB(AB instance);
    partial void UpdateAB(AB instance);
    partial void DeleteAB(AB instance);
    #endregion
		
		public DBDataContext() : 
				base(global::Library_Management.Properties.Settings.Default.LMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Login> Logins
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<MR> MRs
		{
			get
			{
				return this.GetTable<MR>();
			}
		}
		
		public System.Data.Linq.Table<FR> FRs
		{
			get
			{
				return this.GetTable<FR>();
			}
		}
		
		public System.Data.Linq.Table<AB> ABs
		{
			get
			{
				return this.GetTable<AB>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Username;
		
		private string _Password;
		
		private string _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    #endregion
		
		public Login()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NVarChar(50)")]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MR")]
	public partial class MR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _Password;
		
		private string _Name;
		
		private string _Email;
		
		private string _Member_Type;
		
		private string _Department;
		
		private string _Address;
		
		private string _Contact_No;
		
		private string _Gender;
		
		private string _Blood_Group;
		
		private string _Books_Type;
		
		private string _Books_Name;
		
		private string _Author_Editor;
		
		private string _Book_Can_Hold;
		
		private System.Nullable<System.DateTime> _Issue_Date;
		
		private System.Nullable<System.DateTime> _Due_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnMember_TypeChanging(string value);
    partial void OnMember_TypeChanged();
    partial void OnDepartmentChanging(string value);
    partial void OnDepartmentChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnContact_NoChanging(string value);
    partial void OnContact_NoChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnBlood_GroupChanging(string value);
    partial void OnBlood_GroupChanged();
    partial void OnBooks_TypeChanging(string value);
    partial void OnBooks_TypeChanged();
    partial void OnBooks_NameChanging(string value);
    partial void OnBooks_NameChanged();
    partial void OnAuthor_EditorChanging(string value);
    partial void OnAuthor_EditorChanged();
    partial void OnBook_Can_HoldChanging(string value);
    partial void OnBook_Can_HoldChanged();
    partial void OnIssue_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnIssue_DateChanged();
    partial void OnDue_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnDue_DateChanged();
    #endregion
		
		public MR()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Member Type]", Storage="_Member_Type", DbType="NVarChar(50)")]
		public string Member_Type
		{
			get
			{
				return this._Member_Type;
			}
			set
			{
				if ((this._Member_Type != value))
				{
					this.OnMember_TypeChanging(value);
					this.SendPropertyChanging();
					this._Member_Type = value;
					this.SendPropertyChanged("Member_Type");
					this.OnMember_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="NVarChar(50)")]
		public string Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Contact No]", Storage="_Contact_No", DbType="NVarChar(50)")]
		public string Contact_No
		{
			get
			{
				return this._Contact_No;
			}
			set
			{
				if ((this._Contact_No != value))
				{
					this.OnContact_NoChanging(value);
					this.SendPropertyChanging();
					this._Contact_No = value;
					this.SendPropertyChanged("Contact_No");
					this.OnContact_NoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Blood Group]", Storage="_Blood_Group", DbType="NVarChar(50)")]
		public string Blood_Group
		{
			get
			{
				return this._Blood_Group;
			}
			set
			{
				if ((this._Blood_Group != value))
				{
					this.OnBlood_GroupChanging(value);
					this.SendPropertyChanging();
					this._Blood_Group = value;
					this.SendPropertyChanged("Blood_Group");
					this.OnBlood_GroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Books Type]", Storage="_Books_Type", DbType="NVarChar(50)")]
		public string Books_Type
		{
			get
			{
				return this._Books_Type;
			}
			set
			{
				if ((this._Books_Type != value))
				{
					this.OnBooks_TypeChanging(value);
					this.SendPropertyChanging();
					this._Books_Type = value;
					this.SendPropertyChanged("Books_Type");
					this.OnBooks_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Books Name]", Storage="_Books_Name", DbType="NVarChar(50)")]
		public string Books_Name
		{
			get
			{
				return this._Books_Name;
			}
			set
			{
				if ((this._Books_Name != value))
				{
					this.OnBooks_NameChanging(value);
					this.SendPropertyChanging();
					this._Books_Name = value;
					this.SendPropertyChanged("Books_Name");
					this.OnBooks_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Author/Editor]", Storage="_Author_Editor", DbType="NVarChar(50)")]
		public string Author_Editor
		{
			get
			{
				return this._Author_Editor;
			}
			set
			{
				if ((this._Author_Editor != value))
				{
					this.OnAuthor_EditorChanging(value);
					this.SendPropertyChanging();
					this._Author_Editor = value;
					this.SendPropertyChanged("Author_Editor");
					this.OnAuthor_EditorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Book Can Hold]", Storage="_Book_Can_Hold", DbType="NVarChar(50)")]
		public string Book_Can_Hold
		{
			get
			{
				return this._Book_Can_Hold;
			}
			set
			{
				if ((this._Book_Can_Hold != value))
				{
					this.OnBook_Can_HoldChanging(value);
					this.SendPropertyChanging();
					this._Book_Can_Hold = value;
					this.SendPropertyChanged("Book_Can_Hold");
					this.OnBook_Can_HoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Issue Date]", Storage="_Issue_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Issue_Date
		{
			get
			{
				return this._Issue_Date;
			}
			set
			{
				if ((this._Issue_Date != value))
				{
					this.OnIssue_DateChanging(value);
					this.SendPropertyChanging();
					this._Issue_Date = value;
					this.SendPropertyChanged("Issue_Date");
					this.OnIssue_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Due Date]", Storage="_Due_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Due_Date
		{
			get
			{
				return this._Due_Date;
			}
			set
			{
				if ((this._Due_Date != value))
				{
					this.OnDue_DateChanging(value);
					this.SendPropertyChanging();
					this._Due_Date = value;
					this.SendPropertyChanged("Due_Date");
					this.OnDue_DateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.FR")]
	public partial class FR : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _Password;
		
		private string _Name;
		
		private string _Email;
		
		private string _Designation;
		
		private string _Address;
		
		private string _Contact_Number;
		
		private string _Gender;
		
		private string _Blood_Group;
		
		private string _Books_Type;
		
		private string _Books_Name;
		
		private string _Author_Editor;
		
		private string _Book_Can_Hold;
		
		private System.Nullable<System.DateTime> _Issue_Date;
		
		private System.Nullable<System.DateTime> _Due_Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDesignationChanging(string value);
    partial void OnDesignationChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnContact_NumberChanging(string value);
    partial void OnContact_NumberChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnBlood_GroupChanging(string value);
    partial void OnBlood_GroupChanged();
    partial void OnBooks_TypeChanging(string value);
    partial void OnBooks_TypeChanged();
    partial void OnBooks_NameChanging(string value);
    partial void OnBooks_NameChanged();
    partial void OnAuthor_EditorChanging(string value);
    partial void OnAuthor_EditorChanged();
    partial void OnBook_Can_HoldChanging(string value);
    partial void OnBook_Can_HoldChanged();
    partial void OnIssue_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnIssue_DateChanged();
    partial void OnDue_DateChanging(System.Nullable<System.DateTime> value);
    partial void OnDue_DateChanged();
    #endregion
		
		public FR()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Designation", DbType="NVarChar(50)")]
		public string Designation
		{
			get
			{
				return this._Designation;
			}
			set
			{
				if ((this._Designation != value))
				{
					this.OnDesignationChanging(value);
					this.SendPropertyChanging();
					this._Designation = value;
					this.SendPropertyChanged("Designation");
					this.OnDesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(MAX)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Contact Number]", Storage="_Contact_Number", DbType="NVarChar(50)")]
		public string Contact_Number
		{
			get
			{
				return this._Contact_Number;
			}
			set
			{
				if ((this._Contact_Number != value))
				{
					this.OnContact_NumberChanging(value);
					this.SendPropertyChanging();
					this._Contact_Number = value;
					this.SendPropertyChanged("Contact_Number");
					this.OnContact_NumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Blood Group]", Storage="_Blood_Group", DbType="NVarChar(50)")]
		public string Blood_Group
		{
			get
			{
				return this._Blood_Group;
			}
			set
			{
				if ((this._Blood_Group != value))
				{
					this.OnBlood_GroupChanging(value);
					this.SendPropertyChanging();
					this._Blood_Group = value;
					this.SendPropertyChanged("Blood_Group");
					this.OnBlood_GroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Books Type]", Storage="_Books_Type", DbType="NVarChar(50)")]
		public string Books_Type
		{
			get
			{
				return this._Books_Type;
			}
			set
			{
				if ((this._Books_Type != value))
				{
					this.OnBooks_TypeChanging(value);
					this.SendPropertyChanging();
					this._Books_Type = value;
					this.SendPropertyChanged("Books_Type");
					this.OnBooks_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Books Name]", Storage="_Books_Name", DbType="NVarChar(50)")]
		public string Books_Name
		{
			get
			{
				return this._Books_Name;
			}
			set
			{
				if ((this._Books_Name != value))
				{
					this.OnBooks_NameChanging(value);
					this.SendPropertyChanging();
					this._Books_Name = value;
					this.SendPropertyChanged("Books_Name");
					this.OnBooks_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Author/Editor]", Storage="_Author_Editor", DbType="NVarChar(50)")]
		public string Author_Editor
		{
			get
			{
				return this._Author_Editor;
			}
			set
			{
				if ((this._Author_Editor != value))
				{
					this.OnAuthor_EditorChanging(value);
					this.SendPropertyChanging();
					this._Author_Editor = value;
					this.SendPropertyChanged("Author_Editor");
					this.OnAuthor_EditorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Book Can Hold]", Storage="_Book_Can_Hold", DbType="NVarChar(50)")]
		public string Book_Can_Hold
		{
			get
			{
				return this._Book_Can_Hold;
			}
			set
			{
				if ((this._Book_Can_Hold != value))
				{
					this.OnBook_Can_HoldChanging(value);
					this.SendPropertyChanging();
					this._Book_Can_Hold = value;
					this.SendPropertyChanged("Book_Can_Hold");
					this.OnBook_Can_HoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Issue Date]", Storage="_Issue_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Issue_Date
		{
			get
			{
				return this._Issue_Date;
			}
			set
			{
				if ((this._Issue_Date != value))
				{
					this.OnIssue_DateChanging(value);
					this.SendPropertyChanging();
					this._Issue_Date = value;
					this.SendPropertyChanged("Issue_Date");
					this.OnIssue_DateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Due Date]", Storage="_Due_Date", DbType="Date")]
		public System.Nullable<System.DateTime> Due_Date
		{
			get
			{
				return this._Due_Date;
			}
			set
			{
				if ((this._Due_Date != value))
				{
					this.OnDue_DateChanging(value);
					this.SendPropertyChanging();
					this._Due_Date = value;
					this.SendPropertyChanged("Due_Date");
					this.OnDue_DateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AB")]
	public partial class AB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Book_Id;
		
		private string _Book_Name;
		
		private string _Quantity;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnBook_IdChanging(string value);
    partial void OnBook_IdChanged();
    partial void OnBook_NameChanging(string value);
    partial void OnBook_NameChanged();
    partial void OnQuantityChanging(string value);
    partial void OnQuantityChanged();
    #endregion
		
		public AB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Book Id]", Storage="_Book_Id", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Book_Id
		{
			get
			{
				return this._Book_Id;
			}
			set
			{
				if ((this._Book_Id != value))
				{
					this.OnBook_IdChanging(value);
					this.SendPropertyChanging();
					this._Book_Id = value;
					this.SendPropertyChanged("Book_Id");
					this.OnBook_IdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Book Name]", Storage="_Book_Name", DbType="NVarChar(50)")]
		public string Book_Name
		{
			get
			{
				return this._Book_Name;
			}
			set
			{
				if ((this._Book_Name != value))
				{
					this.OnBook_NameChanging(value);
					this.SendPropertyChanging();
					this._Book_Name = value;
					this.SendPropertyChanged("Book_Name");
					this.OnBook_NameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="NVarChar(50)")]
		public string Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
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
