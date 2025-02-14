/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.16.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;

using Thrift.Protocol;
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Evernote.EDAM.Type
{

  /// <summary>
  ///  This represents the information about a single user account.
  /// <dl>
  ///  <dt>id</dt>
  ///    <dd>The unique numeric identifier for the account, which will not
  ///    change for the lifetime of the account.
  ///    </dd>
  /// 
  ///  <dt>username</dt>
  ///    <dd>The name that uniquely identifies a single user account. This name
  ///    may be presented by the user, along with their password, to log into
  ///    their account.
  ///    May only contain a-z, 0-9, or '-', and may not start or end with the '-'
  ///    <br/>
  ///    Length:  EDAM_USER_USERNAME_LEN_MIN - EDAM_USER_USERNAME_LEN_MAX
  ///    <br/>
  ///    Regex:  EDAM_USER_USERNAME_REGEX
  ///    </dd>
  /// 
  ///  <dt>email</dt>
  ///    <dd>The email address registered for the user.  Must comply with
  ///    RFC 2821 and RFC 2822.<br/>
  ///    Third party applications that authenticate using OAuth do not have
  ///    access to this field.
  ///    Length:  EDAM_EMAIL_LEN_MIN - EDAM_EMAIL_LEN_MAX
  ///    <br/>
  ///    Regex:  EDAM_EMAIL_REGEX
  ///    </dd>
  /// 
  ///  <dt>name</dt>
  ///    <dd>The printable name of the user, which may be a combination
  ///    of given and family names.  This is used instead of separate "first"
  ///    and "last" names due to variations in international name format/order.
  ///    May not start or end with a whitespace character.  May contain any
  ///    character but carriage return or newline (Unicode classes Zl and Zp).
  ///    <br/>
  ///    Length:  EDAM_USER_NAME_LEN_MIN - EDAM_USER_NAME_LEN_MAX
  ///    <br/>
  ///    Regex:  EDAM_USER_NAME_REGEX
  ///    </dd>
  /// 
  ///  <dt>timezone</dt>
  ///    <dd>The zone ID for the user's default location.  If present,
  ///    this may be used to localize the display of any timestamp for which no
  ///    other timezone is available.
  ///    The format must be encoded as a standard zone ID such as
  ///    "America/Los_Angeles" or "GMT+08:00"
  ///    <br/>
  ///    Length:  EDAM_TIMEZONE_LEN_MIN - EDAM_TIMEZONE_LEN_MAX
  ///    <br/>
  ///    Regex:  EDAM_TIMEZONE_REGEX
  ///    </dd>
  /// 
  ///  <dt>serviceLevel</dt>
  ///    <dd>The level of service the user currently receives. This will always be populated
  ///        for users retrieved from the Evernote service.
  ///    </dd>
  /// 
  ///  <dt>created</dt>
  ///    <dd>The date and time when this user account was created in the
  ///    service.
  ///    </dd>
  /// 
  ///  <dt>updated</dt>
  ///    <dd>The date and time when this user account was last modified
  ///    in the service.
  ///    </dd>
  /// 
  ///  <dt>deleted</dt>
  ///    <dd>If the account has been deleted from the system (e.g. as
  ///    the result of a legal request by the user), the date and time of the
  ///    deletion will be represented here.  If not, this value will not be set.
  ///    </dd>
  /// 
  ///  <dt>active</dt>
  ///    <dd>If the user account is available for login and
  ///    synchronization, this flag will be set to true.
  ///    </dd>
  /// 
  ///  <dt>shardId</dt>
  ///    <dd>DEPRECATED - Client applications should have no need to use this field.
  ///    </dd>
  /// 
  ///  <dt>attributes</dt>
  ///    <dd>If present, this will contain a list of the attributes
  ///    for this user account.
  ///    </dd>
  /// 
  ///  <dt>accounting</dt>
  ///    <dd>Bookkeeping information for the user's subscription.
  ///    </dd>
  /// 
  ///  <dt>businessUserInfo</dt>
  ///    <dd>If present, this will contain a set of business information
  ///    relating to the user's business membership.  If not present, the
  ///    user is not currently part of a business.
  ///    </dd>
  /// 
  ///  <dt>photoUrl</dt>
  ///    <dd>The URL of the photo that represents this User. This field is filled in by the
  ///    service and is read-only to clients. If <code>photoLastUpdated</code> is
  ///    not set, this url will point to a placeholder user photo generated by the
  ///    service.</dd>
  /// 
  ///  <dt>photoLastUpdated</dt>
  ///    <dd>The time at which the photo at 'photoUrl' was last updated by this User. This
  ///    field will be null if the User never set a profile photo. This field is filled in by
  ///    the service and is read-only to clients.</dd>
  /// 
  ///  <dt>accountLimits</dt>
  ///    <dd>Account limits applicable for this user.</dd>
  /// </summary>
  public partial class User : TBase
  {
    private int _id;
    private string _username;
    private string _email;
    private string _name;
    private string _timezone;
    private global::Evernote.EDAM.Type.PrivilegeLevel _privilege;
    private global::Evernote.EDAM.Type.ServiceLevel _serviceLevel;
    private long _created;
    private long _updated;
    private long _deleted;
    private bool _active;
    private string _shardId;
    private global::Evernote.EDAM.Type.UserAttributes _attributes;
    private global::Evernote.EDAM.Type.Accounting _accounting;
    private global::Evernote.EDAM.Type.BusinessUserInfo _businessUserInfo;
    private string _photoUrl;
    private long _photoLastUpdated;
    private global::Evernote.EDAM.Type.AccountLimits _accountLimits;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public string Username
    {
      get
      {
        return _username;
      }
      set
      {
        __isset.username = true;
        this._username = value;
      }
    }

    public string Email
    {
      get
      {
        return _email;
      }
      set
      {
        __isset.email = true;
        this._email = value;
      }
    }

    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        __isset.name = true;
        this._name = value;
      }
    }

    public string Timezone
    {
      get
      {
        return _timezone;
      }
      set
      {
        __isset.timezone = true;
        this._timezone = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.PrivilegeLevel"/>
    /// </summary>
    public global::Evernote.EDAM.Type.PrivilegeLevel Privilege
    {
      get
      {
        return _privilege;
      }
      set
      {
        __isset.privilege = true;
        this._privilege = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.ServiceLevel"/>
    /// </summary>
    public global::Evernote.EDAM.Type.ServiceLevel ServiceLevel
    {
      get
      {
        return _serviceLevel;
      }
      set
      {
        __isset.serviceLevel = true;
        this._serviceLevel = value;
      }
    }

    public long Created
    {
      get
      {
        return _created;
      }
      set
      {
        __isset.created = true;
        this._created = value;
      }
    }

    public long Updated
    {
      get
      {
        return _updated;
      }
      set
      {
        __isset.updated = true;
        this._updated = value;
      }
    }

    public long Deleted
    {
      get
      {
        return _deleted;
      }
      set
      {
        __isset.deleted = true;
        this._deleted = value;
      }
    }

    public bool Active
    {
      get
      {
        return _active;
      }
      set
      {
        __isset.active = true;
        this._active = value;
      }
    }

    public string ShardId
    {
      get
      {
        return _shardId;
      }
      set
      {
        __isset.shardId = true;
        this._shardId = value;
      }
    }

    public global::Evernote.EDAM.Type.UserAttributes Attributes
    {
      get
      {
        return _attributes;
      }
      set
      {
        __isset.attributes = true;
        this._attributes = value;
      }
    }

    public global::Evernote.EDAM.Type.Accounting Accounting
    {
      get
      {
        return _accounting;
      }
      set
      {
        __isset.accounting = true;
        this._accounting = value;
      }
    }

    public global::Evernote.EDAM.Type.BusinessUserInfo BusinessUserInfo
    {
      get
      {
        return _businessUserInfo;
      }
      set
      {
        __isset.businessUserInfo = true;
        this._businessUserInfo = value;
      }
    }

    public string PhotoUrl
    {
      get
      {
        return _photoUrl;
      }
      set
      {
        __isset.photoUrl = true;
        this._photoUrl = value;
      }
    }

    public long PhotoLastUpdated
    {
      get
      {
        return _photoLastUpdated;
      }
      set
      {
        __isset.photoLastUpdated = true;
        this._photoLastUpdated = value;
      }
    }

    public global::Evernote.EDAM.Type.AccountLimits AccountLimits
    {
      get
      {
        return _accountLimits;
      }
      set
      {
        __isset.accountLimits = true;
        this._accountLimits = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool id;
      public bool username;
      public bool email;
      public bool name;
      public bool timezone;
      public bool privilege;
      public bool serviceLevel;
      public bool created;
      public bool updated;
      public bool deleted;
      public bool active;
      public bool shardId;
      public bool attributes;
      public bool accounting;
      public bool businessUserInfo;
      public bool photoUrl;
      public bool photoLastUpdated;
      public bool accountLimits;
    }

    public User()
    {
    }

    public User DeepCopy()
    {
      var tmp38 = new User();
      if(__isset.id)
      {
        tmp38.Id = this.Id;
      }
      tmp38.__isset.id = this.__isset.id;
      if((Username != null) && __isset.username)
      {
        tmp38.Username = this.Username;
      }
      tmp38.__isset.username = this.__isset.username;
      if((Email != null) && __isset.email)
      {
        tmp38.Email = this.Email;
      }
      tmp38.__isset.email = this.__isset.email;
      if((Name != null) && __isset.name)
      {
        tmp38.Name = this.Name;
      }
      tmp38.__isset.name = this.__isset.name;
      if((Timezone != null) && __isset.timezone)
      {
        tmp38.Timezone = this.Timezone;
      }
      tmp38.__isset.timezone = this.__isset.timezone;
      if(__isset.privilege)
      {
        tmp38.Privilege = this.Privilege;
      }
      tmp38.__isset.privilege = this.__isset.privilege;
      if(__isset.serviceLevel)
      {
        tmp38.ServiceLevel = this.ServiceLevel;
      }
      tmp38.__isset.serviceLevel = this.__isset.serviceLevel;
      if(__isset.created)
      {
        tmp38.Created = this.Created;
      }
      tmp38.__isset.created = this.__isset.created;
      if(__isset.updated)
      {
        tmp38.Updated = this.Updated;
      }
      tmp38.__isset.updated = this.__isset.updated;
      if(__isset.deleted)
      {
        tmp38.Deleted = this.Deleted;
      }
      tmp38.__isset.deleted = this.__isset.deleted;
      if(__isset.active)
      {
        tmp38.Active = this.Active;
      }
      tmp38.__isset.active = this.__isset.active;
      if((ShardId != null) && __isset.shardId)
      {
        tmp38.ShardId = this.ShardId;
      }
      tmp38.__isset.shardId = this.__isset.shardId;
      if((Attributes != null) && __isset.attributes)
      {
        tmp38.Attributes = (global::Evernote.EDAM.Type.UserAttributes)this.Attributes.DeepCopy();
      }
      tmp38.__isset.attributes = this.__isset.attributes;
      if((Accounting != null) && __isset.accounting)
      {
        tmp38.Accounting = (global::Evernote.EDAM.Type.Accounting)this.Accounting.DeepCopy();
      }
      tmp38.__isset.accounting = this.__isset.accounting;
      if((BusinessUserInfo != null) && __isset.businessUserInfo)
      {
        tmp38.BusinessUserInfo = (global::Evernote.EDAM.Type.BusinessUserInfo)this.BusinessUserInfo.DeepCopy();
      }
      tmp38.__isset.businessUserInfo = this.__isset.businessUserInfo;
      if((PhotoUrl != null) && __isset.photoUrl)
      {
        tmp38.PhotoUrl = this.PhotoUrl;
      }
      tmp38.__isset.photoUrl = this.__isset.photoUrl;
      if(__isset.photoLastUpdated)
      {
        tmp38.PhotoLastUpdated = this.PhotoLastUpdated;
      }
      tmp38.__isset.photoLastUpdated = this.__isset.photoLastUpdated;
      if((AccountLimits != null) && __isset.accountLimits)
      {
        tmp38.AccountLimits = (global::Evernote.EDAM.Type.AccountLimits)this.AccountLimits.DeepCopy();
      }
      tmp38.__isset.accountLimits = this.__isset.accountLimits;
      return tmp38;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.I32)
              {
                Id = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Username = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.String)
              {
                Email = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Name = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                Timezone = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                Privilege = (global::Evernote.EDAM.Type.PrivilegeLevel)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 21:
              if (field.Type == TType.I32)
              {
                ServiceLevel = (global::Evernote.EDAM.Type.ServiceLevel)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.I64)
              {
                Created = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.I64)
              {
                Updated = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.I64)
              {
                Deleted = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 13:
              if (field.Type == TType.Bool)
              {
                Active = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 14:
              if (field.Type == TType.String)
              {
                ShardId = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 15:
              if (field.Type == TType.Struct)
              {
                Attributes = new global::Evernote.EDAM.Type.UserAttributes();
                await Attributes.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 16:
              if (field.Type == TType.Struct)
              {
                Accounting = new global::Evernote.EDAM.Type.Accounting();
                await Accounting.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 18:
              if (field.Type == TType.Struct)
              {
                BusinessUserInfo = new global::Evernote.EDAM.Type.BusinessUserInfo();
                await BusinessUserInfo.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 19:
              if (field.Type == TType.String)
              {
                PhotoUrl = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 20:
              if (field.Type == TType.I64)
              {
                PhotoLastUpdated = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 22:
              if (field.Type == TType.Struct)
              {
                AccountLimits = new global::Evernote.EDAM.Type.AccountLimits();
                await AccountLimits.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp39 = new TStruct("User");
        await oprot.WriteStructBeginAsync(tmp39, cancellationToken);
        var tmp40 = new TField();
        if(__isset.id)
        {
          tmp40.Name = "id";
          tmp40.Type = TType.I32;
          tmp40.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI32Async(Id, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Username != null) && __isset.username)
        {
          tmp40.Name = "username";
          tmp40.Type = TType.String;
          tmp40.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteStringAsync(Username, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Email != null) && __isset.email)
        {
          tmp40.Name = "email";
          tmp40.Type = TType.String;
          tmp40.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteStringAsync(Email, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Name != null) && __isset.name)
        {
          tmp40.Name = "name";
          tmp40.Type = TType.String;
          tmp40.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteStringAsync(Name, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Timezone != null) && __isset.timezone)
        {
          tmp40.Name = "timezone";
          tmp40.Type = TType.String;
          tmp40.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteStringAsync(Timezone, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.privilege)
        {
          tmp40.Name = "privilege";
          tmp40.Type = TType.I32;
          tmp40.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI32Async((int)Privilege, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.created)
        {
          tmp40.Name = "created";
          tmp40.Type = TType.I64;
          tmp40.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI64Async(Created, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.updated)
        {
          tmp40.Name = "updated";
          tmp40.Type = TType.I64;
          tmp40.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI64Async(Updated, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.deleted)
        {
          tmp40.Name = "deleted";
          tmp40.Type = TType.I64;
          tmp40.ID = 11;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI64Async(Deleted, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.active)
        {
          tmp40.Name = "active";
          tmp40.Type = TType.Bool;
          tmp40.ID = 13;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteBoolAsync(Active, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ShardId != null) && __isset.shardId)
        {
          tmp40.Name = "shardId";
          tmp40.Type = TType.String;
          tmp40.ID = 14;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteStringAsync(ShardId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Attributes != null) && __isset.attributes)
        {
          tmp40.Name = "attributes";
          tmp40.Type = TType.Struct;
          tmp40.ID = 15;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await Attributes.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Accounting != null) && __isset.accounting)
        {
          tmp40.Name = "accounting";
          tmp40.Type = TType.Struct;
          tmp40.ID = 16;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await Accounting.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((BusinessUserInfo != null) && __isset.businessUserInfo)
        {
          tmp40.Name = "businessUserInfo";
          tmp40.Type = TType.Struct;
          tmp40.ID = 18;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await BusinessUserInfo.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((PhotoUrl != null) && __isset.photoUrl)
        {
          tmp40.Name = "photoUrl";
          tmp40.Type = TType.String;
          tmp40.ID = 19;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteStringAsync(PhotoUrl, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.photoLastUpdated)
        {
          tmp40.Name = "photoLastUpdated";
          tmp40.Type = TType.I64;
          tmp40.ID = 20;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI64Async(PhotoLastUpdated, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.serviceLevel)
        {
          tmp40.Name = "serviceLevel";
          tmp40.Type = TType.I32;
          tmp40.ID = 21;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await oprot.WriteI32Async((int)ServiceLevel, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((AccountLimits != null) && __isset.accountLimits)
        {
          tmp40.Name = "accountLimits";
          tmp40.Type = TType.Struct;
          tmp40.ID = 22;
          await oprot.WriteFieldBeginAsync(tmp40, cancellationToken);
          await AccountLimits.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is User other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.id == other.__isset.id) && ((!__isset.id) || (global::System.Object.Equals(Id, other.Id))))
        && ((__isset.username == other.__isset.username) && ((!__isset.username) || (global::System.Object.Equals(Username, other.Username))))
        && ((__isset.email == other.__isset.email) && ((!__isset.email) || (global::System.Object.Equals(Email, other.Email))))
        && ((__isset.name == other.__isset.name) && ((!__isset.name) || (global::System.Object.Equals(Name, other.Name))))
        && ((__isset.timezone == other.__isset.timezone) && ((!__isset.timezone) || (global::System.Object.Equals(Timezone, other.Timezone))))
        && ((__isset.privilege == other.__isset.privilege) && ((!__isset.privilege) || (global::System.Object.Equals(Privilege, other.Privilege))))
        && ((__isset.serviceLevel == other.__isset.serviceLevel) && ((!__isset.serviceLevel) || (global::System.Object.Equals(ServiceLevel, other.ServiceLevel))))
        && ((__isset.created == other.__isset.created) && ((!__isset.created) || (global::System.Object.Equals(Created, other.Created))))
        && ((__isset.updated == other.__isset.updated) && ((!__isset.updated) || (global::System.Object.Equals(Updated, other.Updated))))
        && ((__isset.deleted == other.__isset.deleted) && ((!__isset.deleted) || (global::System.Object.Equals(Deleted, other.Deleted))))
        && ((__isset.active == other.__isset.active) && ((!__isset.active) || (global::System.Object.Equals(Active, other.Active))))
        && ((__isset.shardId == other.__isset.shardId) && ((!__isset.shardId) || (global::System.Object.Equals(ShardId, other.ShardId))))
        && ((__isset.attributes == other.__isset.attributes) && ((!__isset.attributes) || (global::System.Object.Equals(Attributes, other.Attributes))))
        && ((__isset.accounting == other.__isset.accounting) && ((!__isset.accounting) || (global::System.Object.Equals(Accounting, other.Accounting))))
        && ((__isset.businessUserInfo == other.__isset.businessUserInfo) && ((!__isset.businessUserInfo) || (global::System.Object.Equals(BusinessUserInfo, other.BusinessUserInfo))))
        && ((__isset.photoUrl == other.__isset.photoUrl) && ((!__isset.photoUrl) || (global::System.Object.Equals(PhotoUrl, other.PhotoUrl))))
        && ((__isset.photoLastUpdated == other.__isset.photoLastUpdated) && ((!__isset.photoLastUpdated) || (global::System.Object.Equals(PhotoLastUpdated, other.PhotoLastUpdated))))
        && ((__isset.accountLimits == other.__isset.accountLimits) && ((!__isset.accountLimits) || (global::System.Object.Equals(AccountLimits, other.AccountLimits))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.id)
        {
          hashcode = (hashcode * 397) + Id.GetHashCode();
        }
        if((Username != null) && __isset.username)
        {
          hashcode = (hashcode * 397) + Username.GetHashCode();
        }
        if((Email != null) && __isset.email)
        {
          hashcode = (hashcode * 397) + Email.GetHashCode();
        }
        if((Name != null) && __isset.name)
        {
          hashcode = (hashcode * 397) + Name.GetHashCode();
        }
        if((Timezone != null) && __isset.timezone)
        {
          hashcode = (hashcode * 397) + Timezone.GetHashCode();
        }
        if(__isset.privilege)
        {
          hashcode = (hashcode * 397) + Privilege.GetHashCode();
        }
        if(__isset.serviceLevel)
        {
          hashcode = (hashcode * 397) + ServiceLevel.GetHashCode();
        }
        if(__isset.created)
        {
          hashcode = (hashcode * 397) + Created.GetHashCode();
        }
        if(__isset.updated)
        {
          hashcode = (hashcode * 397) + Updated.GetHashCode();
        }
        if(__isset.deleted)
        {
          hashcode = (hashcode * 397) + Deleted.GetHashCode();
        }
        if(__isset.active)
        {
          hashcode = (hashcode * 397) + Active.GetHashCode();
        }
        if((ShardId != null) && __isset.shardId)
        {
          hashcode = (hashcode * 397) + ShardId.GetHashCode();
        }
        if((Attributes != null) && __isset.attributes)
        {
          hashcode = (hashcode * 397) + Attributes.GetHashCode();
        }
        if((Accounting != null) && __isset.accounting)
        {
          hashcode = (hashcode * 397) + Accounting.GetHashCode();
        }
        if((BusinessUserInfo != null) && __isset.businessUserInfo)
        {
          hashcode = (hashcode * 397) + BusinessUserInfo.GetHashCode();
        }
        if((PhotoUrl != null) && __isset.photoUrl)
        {
          hashcode = (hashcode * 397) + PhotoUrl.GetHashCode();
        }
        if(__isset.photoLastUpdated)
        {
          hashcode = (hashcode * 397) + PhotoLastUpdated.GetHashCode();
        }
        if((AccountLimits != null) && __isset.accountLimits)
        {
          hashcode = (hashcode * 397) + AccountLimits.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp41 = new StringBuilder("User(");
      int tmp42 = 0;
      if(__isset.id)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Id: ");
        Id.ToString(tmp41);
      }
      if((Username != null) && __isset.username)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Username: ");
        Username.ToString(tmp41);
      }
      if((Email != null) && __isset.email)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Email: ");
        Email.ToString(tmp41);
      }
      if((Name != null) && __isset.name)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Name: ");
        Name.ToString(tmp41);
      }
      if((Timezone != null) && __isset.timezone)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Timezone: ");
        Timezone.ToString(tmp41);
      }
      if(__isset.privilege)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Privilege: ");
        Privilege.ToString(tmp41);
      }
      if(__isset.serviceLevel)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("ServiceLevel: ");
        ServiceLevel.ToString(tmp41);
      }
      if(__isset.created)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Created: ");
        Created.ToString(tmp41);
      }
      if(__isset.updated)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Updated: ");
        Updated.ToString(tmp41);
      }
      if(__isset.deleted)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Deleted: ");
        Deleted.ToString(tmp41);
      }
      if(__isset.active)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Active: ");
        Active.ToString(tmp41);
      }
      if((ShardId != null) && __isset.shardId)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("ShardId: ");
        ShardId.ToString(tmp41);
      }
      if((Attributes != null) && __isset.attributes)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Attributes: ");
        Attributes.ToString(tmp41);
      }
      if((Accounting != null) && __isset.accounting)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("Accounting: ");
        Accounting.ToString(tmp41);
      }
      if((BusinessUserInfo != null) && __isset.businessUserInfo)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("BusinessUserInfo: ");
        BusinessUserInfo.ToString(tmp41);
      }
      if((PhotoUrl != null) && __isset.photoUrl)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("PhotoUrl: ");
        PhotoUrl.ToString(tmp41);
      }
      if(__isset.photoLastUpdated)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("PhotoLastUpdated: ");
        PhotoLastUpdated.ToString(tmp41);
      }
      if((AccountLimits != null) && __isset.accountLimits)
      {
        if(0 < tmp42++) { tmp41.Append(", "); }
        tmp41.Append("AccountLimits: ");
        AccountLimits.ToString(tmp41);
      }
      tmp41.Append(')');
      return tmp41.ToString();
    }
  }

}
