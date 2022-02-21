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
  /// A structure describing an invitation to join a business account.
  /// 
  /// <dl>
  ///   <dt>businessId</dt>
  ///     <dd>
  ///       The ID of the business to which the invitation grants access.
  ///     </dd>
  /// 
  ///   <dt>email</dt>
  ///     <dd>
  ///       The email address that was invited to join the business.
  ///     </dd>
  /// 
  ///   <dt>role</dt>
  ///     <dd>
  ///       The role to grant the user after the invitation is accepted.
  ///     </dd>
  /// 
  ///   <dt>status</dt>
  ///     <dd>
  ///       The status of the invitation.
  ///     </dd>
  /// 
  ///   <dt>requesterId</dt>
  ///     <dd>
  ///       For invitations that were initially requested by a non-admin member of the business,
  ///       this field specifies the user ID of the requestor. For all other invitations, this field
  ///       will be unset.
  ///     </dd>
  ///   <dt>fromWorkChat</dt>
  ///     <dd>
  ///       If this invitation was created implicitly via a WorkChat, this field
  ///       will be true.
  ///     </dd>
  ///   <dt>created</dt>
  ///     <dd>
  ///       The timestamp at which this invitation was created.
  ///     </dd>
  ///   <dt>mostRecentReminder</dt>
  ///     <dd>
  ///       The timestamp at which the most recent reminder was sent.
  ///     </dd>
  /// </dl>
  /// </summary>
  public partial class BusinessInvitation : TBase
  {
    private int _businessId;
    private string _email;
    private global::Evernote.EDAM.Type.BusinessUserRole _role;
    private global::Evernote.EDAM.Type.BusinessInvitationStatus _status;
    private int _requesterId;
    private bool _fromWorkChat;
    private long _created;
    private long _mostRecentReminder;

    public int BusinessId
    {
      get
      {
        return _businessId;
      }
      set
      {
        __isset.businessId = true;
        this._businessId = value;
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

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.BusinessUserRole"/>
    /// </summary>
    public global::Evernote.EDAM.Type.BusinessUserRole Role
    {
      get
      {
        return _role;
      }
      set
      {
        __isset.role = true;
        this._role = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.BusinessInvitationStatus"/>
    /// </summary>
    public global::Evernote.EDAM.Type.BusinessInvitationStatus Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public int RequesterId
    {
      get
      {
        return _requesterId;
      }
      set
      {
        __isset.requesterId = true;
        this._requesterId = value;
      }
    }

    public bool FromWorkChat
    {
      get
      {
        return _fromWorkChat;
      }
      set
      {
        __isset.fromWorkChat = true;
        this._fromWorkChat = value;
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

    public long MostRecentReminder
    {
      get
      {
        return _mostRecentReminder;
      }
      set
      {
        __isset.mostRecentReminder = true;
        this._mostRecentReminder = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool businessId;
      public bool email;
      public bool role;
      public bool status;
      public bool requesterId;
      public bool fromWorkChat;
      public bool created;
      public bool mostRecentReminder;
    }

    public BusinessInvitation()
    {
    }

    public BusinessInvitation DeepCopy()
    {
      var tmp219 = new BusinessInvitation();
      if(__isset.businessId)
      {
        tmp219.BusinessId = this.BusinessId;
      }
      tmp219.__isset.businessId = this.__isset.businessId;
      if((Email != null) && __isset.email)
      {
        tmp219.Email = this.Email;
      }
      tmp219.__isset.email = this.__isset.email;
      if(__isset.role)
      {
        tmp219.Role = this.Role;
      }
      tmp219.__isset.role = this.__isset.role;
      if(__isset.status)
      {
        tmp219.Status = this.Status;
      }
      tmp219.__isset.status = this.__isset.status;
      if(__isset.requesterId)
      {
        tmp219.RequesterId = this.RequesterId;
      }
      tmp219.__isset.requesterId = this.__isset.requesterId;
      if(__isset.fromWorkChat)
      {
        tmp219.FromWorkChat = this.FromWorkChat;
      }
      tmp219.__isset.fromWorkChat = this.__isset.fromWorkChat;
      if(__isset.created)
      {
        tmp219.Created = this.Created;
      }
      tmp219.__isset.created = this.__isset.created;
      if(__isset.mostRecentReminder)
      {
        tmp219.MostRecentReminder = this.MostRecentReminder;
      }
      tmp219.__isset.mostRecentReminder = this.__isset.mostRecentReminder;
      return tmp219;
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
                BusinessId = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Email = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Role = (global::Evernote.EDAM.Type.BusinessUserRole)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I32)
              {
                Status = (global::Evernote.EDAM.Type.BusinessInvitationStatus)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                RequesterId = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Bool)
              {
                FromWorkChat = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I64)
              {
                Created = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I64)
              {
                MostRecentReminder = await iprot.ReadI64Async(cancellationToken);
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
        var tmp220 = new TStruct("BusinessInvitation");
        await oprot.WriteStructBeginAsync(tmp220, cancellationToken);
        var tmp221 = new TField();
        if(__isset.businessId)
        {
          tmp221.Name = "businessId";
          tmp221.Type = TType.I32;
          tmp221.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteI32Async(BusinessId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Email != null) && __isset.email)
        {
          tmp221.Name = "email";
          tmp221.Type = TType.String;
          tmp221.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteStringAsync(Email, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.role)
        {
          tmp221.Name = "role";
          tmp221.Type = TType.I32;
          tmp221.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteI32Async((int)Role, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.status)
        {
          tmp221.Name = "status";
          tmp221.Type = TType.I32;
          tmp221.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteI32Async((int)Status, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.requesterId)
        {
          tmp221.Name = "requesterId";
          tmp221.Type = TType.I32;
          tmp221.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteI32Async(RequesterId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.fromWorkChat)
        {
          tmp221.Name = "fromWorkChat";
          tmp221.Type = TType.Bool;
          tmp221.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteBoolAsync(FromWorkChat, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.created)
        {
          tmp221.Name = "created";
          tmp221.Type = TType.I64;
          tmp221.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteI64Async(Created, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.mostRecentReminder)
        {
          tmp221.Name = "mostRecentReminder";
          tmp221.Type = TType.I64;
          tmp221.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp221, cancellationToken);
          await oprot.WriteI64Async(MostRecentReminder, cancellationToken);
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
      if (!(that is BusinessInvitation other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.businessId == other.__isset.businessId) && ((!__isset.businessId) || (global::System.Object.Equals(BusinessId, other.BusinessId))))
        && ((__isset.email == other.__isset.email) && ((!__isset.email) || (global::System.Object.Equals(Email, other.Email))))
        && ((__isset.role == other.__isset.role) && ((!__isset.role) || (global::System.Object.Equals(Role, other.Role))))
        && ((__isset.status == other.__isset.status) && ((!__isset.status) || (global::System.Object.Equals(Status, other.Status))))
        && ((__isset.requesterId == other.__isset.requesterId) && ((!__isset.requesterId) || (global::System.Object.Equals(RequesterId, other.RequesterId))))
        && ((__isset.fromWorkChat == other.__isset.fromWorkChat) && ((!__isset.fromWorkChat) || (global::System.Object.Equals(FromWorkChat, other.FromWorkChat))))
        && ((__isset.created == other.__isset.created) && ((!__isset.created) || (global::System.Object.Equals(Created, other.Created))))
        && ((__isset.mostRecentReminder == other.__isset.mostRecentReminder) && ((!__isset.mostRecentReminder) || (global::System.Object.Equals(MostRecentReminder, other.MostRecentReminder))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.businessId)
        {
          hashcode = (hashcode * 397) + BusinessId.GetHashCode();
        }
        if((Email != null) && __isset.email)
        {
          hashcode = (hashcode * 397) + Email.GetHashCode();
        }
        if(__isset.role)
        {
          hashcode = (hashcode * 397) + Role.GetHashCode();
        }
        if(__isset.status)
        {
          hashcode = (hashcode * 397) + Status.GetHashCode();
        }
        if(__isset.requesterId)
        {
          hashcode = (hashcode * 397) + RequesterId.GetHashCode();
        }
        if(__isset.fromWorkChat)
        {
          hashcode = (hashcode * 397) + FromWorkChat.GetHashCode();
        }
        if(__isset.created)
        {
          hashcode = (hashcode * 397) + Created.GetHashCode();
        }
        if(__isset.mostRecentReminder)
        {
          hashcode = (hashcode * 397) + MostRecentReminder.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp222 = new StringBuilder("BusinessInvitation(");
      int tmp223 = 0;
      if(__isset.businessId)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("BusinessId: ");
        BusinessId.ToString(tmp222);
      }
      if((Email != null) && __isset.email)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("Email: ");
        Email.ToString(tmp222);
      }
      if(__isset.role)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("Role: ");
        Role.ToString(tmp222);
      }
      if(__isset.status)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("Status: ");
        Status.ToString(tmp222);
      }
      if(__isset.requesterId)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("RequesterId: ");
        RequesterId.ToString(tmp222);
      }
      if(__isset.fromWorkChat)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("FromWorkChat: ");
        FromWorkChat.ToString(tmp222);
      }
      if(__isset.created)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("Created: ");
        Created.ToString(tmp222);
      }
      if(__isset.mostRecentReminder)
      {
        if(0 < tmp223++) { tmp222.Append(", "); }
        tmp222.Append("MostRecentReminder: ");
        MostRecentReminder.ToString(tmp222);
      }
      tmp222.Append(')');
      return tmp222.ToString();
    }
  }

}
