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
  /// An object that represents the relationship between a Contact that possibly
  /// belongs to an Evernote User.
  /// 
  /// <dl>
  ///  <dt>id</dt>
  ///  <dd>The unique identifier for this mapping.
  ///  </dd>
  /// 
  ///  <dt>contact<dt>
  ///  <dd>The Contact that can be used to address this Identity. May be unset.
  ///  </dd>
  /// 
  ///  <dt>userId</dt>
  ///  <dd>The Evernote User id that is connected to the Contact. May be unset
  ///      if this identity has not yet been claimed, or the caller is not
  ///      connected to this identity.
  ///  </dd>
  /// 
  ///  <dt>deactivated</dt>
  ///  <dd>Indicates that the contact for this identity is no longer active and
  ///  should not be used when creating new threads using Destination.recipients,
  ///  unless you know of another Identity instance with the same contact information
  ///  that is active.  If you are connected to the user (see userConnected), you
  ///  can still create threads using their Evernote-type contact.</dd>
  /// 
  ///  <dt>sameBusiness</dt>
  ///  <dd>Does this Identity belong to someone who is in the same business as the
  ///      caller?
  ///  </dd>
  /// 
  ///  <dt>blocked</dt>
  ///  <dd>Has the caller blocked the Evernote user this Identity represents?
  ///  </dd>
  /// 
  ///  <dt>userConnected</dt>
  ///  <dd>Indicates that the caller is "connected" to the user of this
  ///  identity via this identity.  When you have a connection via an
  ///  identity, you should always create new threads using the
  ///  Evernote-type contact (see ContactType) using the userId field
  ///  from a connected Identity.  On the Evernote service, the
  ///  Evernote-type contact is the most durable. Phone numbers and
  ///  e-mail addresses can get re-assigned but your Evernote account
  ///  user ID will remain the same.  A connection exists when both of
  ///  you are in the same business or the user has replied to a thread
  ///  that you are on.  When connected, you will also get to see more
  ///  information about the user who has claimed the identity.  Note
  ///  that you are never connected to yourself since you won't be
  ///  sending messages to yourself, but you will obviously see your own
  ///  profile information.
  ///  </dd>
  /// 
  ///  <dt>eventId</dt>
  ///  <dd>A server-assigned sequence number for the events in the messages
  ///  subsystem.
  ///  </dd>
  /// </dl>
  /// </summary>
  public partial class Identity : TBase
  {
    private global::Evernote.EDAM.Type.Contact _contact;
    private int _userId;
    private bool _deactivated;
    private bool _sameBusiness;
    private bool _blocked;
    private bool _userConnected;
    private long _eventId;

    public long Id { get; set; }

    public global::Evernote.EDAM.Type.Contact Contact
    {
      get
      {
        return _contact;
      }
      set
      {
        __isset.contact = true;
        this._contact = value;
      }
    }

    public int UserId
    {
      get
      {
        return _userId;
      }
      set
      {
        __isset.userId = true;
        this._userId = value;
      }
    }

    public bool Deactivated
    {
      get
      {
        return _deactivated;
      }
      set
      {
        __isset.deactivated = true;
        this._deactivated = value;
      }
    }

    public bool SameBusiness
    {
      get
      {
        return _sameBusiness;
      }
      set
      {
        __isset.sameBusiness = true;
        this._sameBusiness = value;
      }
    }

    public bool Blocked
    {
      get
      {
        return _blocked;
      }
      set
      {
        __isset.blocked = true;
        this._blocked = value;
      }
    }

    public bool UserConnected
    {
      get
      {
        return _userConnected;
      }
      set
      {
        __isset.userConnected = true;
        this._userConnected = value;
      }
    }

    public long EventId
    {
      get
      {
        return _eventId;
      }
      set
      {
        __isset.eventId = true;
        this._eventId = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool contact;
      public bool userId;
      public bool deactivated;
      public bool sameBusiness;
      public bool blocked;
      public bool userConnected;
      public bool eventId;
    }

    public Identity()
    {
    }

    public Identity(long id) : this()
    {
      this.Id = id;
    }

    public Identity DeepCopy()
    {
      var tmp48 = new Identity();
      tmp48.Id = this.Id;
      if((Contact != null) && __isset.contact)
      {
        tmp48.Contact = (global::Evernote.EDAM.Type.Contact)this.Contact.DeepCopy();
      }
      tmp48.__isset.contact = this.__isset.contact;
      if(__isset.userId)
      {
        tmp48.UserId = this.UserId;
      }
      tmp48.__isset.userId = this.__isset.userId;
      if(__isset.deactivated)
      {
        tmp48.Deactivated = this.Deactivated;
      }
      tmp48.__isset.deactivated = this.__isset.deactivated;
      if(__isset.sameBusiness)
      {
        tmp48.SameBusiness = this.SameBusiness;
      }
      tmp48.__isset.sameBusiness = this.__isset.sameBusiness;
      if(__isset.blocked)
      {
        tmp48.Blocked = this.Blocked;
      }
      tmp48.__isset.blocked = this.__isset.blocked;
      if(__isset.userConnected)
      {
        tmp48.UserConnected = this.UserConnected;
      }
      tmp48.__isset.userConnected = this.__isset.userConnected;
      if(__isset.eventId)
      {
        tmp48.EventId = this.EventId;
      }
      tmp48.__isset.eventId = this.__isset.eventId;
      return tmp48;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_id = false;
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
              if (field.Type == TType.I64)
              {
                Id = await iprot.ReadI64Async(cancellationToken);
                isset_id = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                Contact = new global::Evernote.EDAM.Type.Contact();
                await Contact.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                UserId = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                Deactivated = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Bool)
              {
                SameBusiness = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.Bool)
              {
                Blocked = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.Bool)
              {
                UserConnected = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I64)
              {
                EventId = await iprot.ReadI64Async(cancellationToken);
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
        if (!isset_id)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
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
        var tmp49 = new TStruct("Identity");
        await oprot.WriteStructBeginAsync(tmp49, cancellationToken);
        var tmp50 = new TField();
        tmp50.Name = "id";
        tmp50.Type = TType.I64;
        tmp50.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
        await oprot.WriteI64Async(Id, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Contact != null) && __isset.contact)
        {
          tmp50.Name = "contact";
          tmp50.Type = TType.Struct;
          tmp50.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await Contact.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.userId)
        {
          tmp50.Name = "userId";
          tmp50.Type = TType.I32;
          tmp50.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await oprot.WriteI32Async(UserId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.deactivated)
        {
          tmp50.Name = "deactivated";
          tmp50.Type = TType.Bool;
          tmp50.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await oprot.WriteBoolAsync(Deactivated, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.sameBusiness)
        {
          tmp50.Name = "sameBusiness";
          tmp50.Type = TType.Bool;
          tmp50.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await oprot.WriteBoolAsync(SameBusiness, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.blocked)
        {
          tmp50.Name = "blocked";
          tmp50.Type = TType.Bool;
          tmp50.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await oprot.WriteBoolAsync(Blocked, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.userConnected)
        {
          tmp50.Name = "userConnected";
          tmp50.Type = TType.Bool;
          tmp50.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await oprot.WriteBoolAsync(UserConnected, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.eventId)
        {
          tmp50.Name = "eventId";
          tmp50.Type = TType.I64;
          tmp50.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp50, cancellationToken);
          await oprot.WriteI64Async(EventId, cancellationToken);
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
      if (!(that is Identity other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(Id, other.Id)
        && ((__isset.contact == other.__isset.contact) && ((!__isset.contact) || (global::System.Object.Equals(Contact, other.Contact))))
        && ((__isset.userId == other.__isset.userId) && ((!__isset.userId) || (global::System.Object.Equals(UserId, other.UserId))))
        && ((__isset.deactivated == other.__isset.deactivated) && ((!__isset.deactivated) || (global::System.Object.Equals(Deactivated, other.Deactivated))))
        && ((__isset.sameBusiness == other.__isset.sameBusiness) && ((!__isset.sameBusiness) || (global::System.Object.Equals(SameBusiness, other.SameBusiness))))
        && ((__isset.blocked == other.__isset.blocked) && ((!__isset.blocked) || (global::System.Object.Equals(Blocked, other.Blocked))))
        && ((__isset.userConnected == other.__isset.userConnected) && ((!__isset.userConnected) || (global::System.Object.Equals(UserConnected, other.UserConnected))))
        && ((__isset.eventId == other.__isset.eventId) && ((!__isset.eventId) || (global::System.Object.Equals(EventId, other.EventId))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + Id.GetHashCode();
        if((Contact != null) && __isset.contact)
        {
          hashcode = (hashcode * 397) + Contact.GetHashCode();
        }
        if(__isset.userId)
        {
          hashcode = (hashcode * 397) + UserId.GetHashCode();
        }
        if(__isset.deactivated)
        {
          hashcode = (hashcode * 397) + Deactivated.GetHashCode();
        }
        if(__isset.sameBusiness)
        {
          hashcode = (hashcode * 397) + SameBusiness.GetHashCode();
        }
        if(__isset.blocked)
        {
          hashcode = (hashcode * 397) + Blocked.GetHashCode();
        }
        if(__isset.userConnected)
        {
          hashcode = (hashcode * 397) + UserConnected.GetHashCode();
        }
        if(__isset.eventId)
        {
          hashcode = (hashcode * 397) + EventId.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp51 = new StringBuilder("Identity(");
      tmp51.Append(", Id: ");
      Id.ToString(tmp51);
      if((Contact != null) && __isset.contact)
      {
        tmp51.Append(", Contact: ");
        Contact.ToString(tmp51);
      }
      if(__isset.userId)
      {
        tmp51.Append(", UserId: ");
        UserId.ToString(tmp51);
      }
      if(__isset.deactivated)
      {
        tmp51.Append(", Deactivated: ");
        Deactivated.ToString(tmp51);
      }
      if(__isset.sameBusiness)
      {
        tmp51.Append(", SameBusiness: ");
        SameBusiness.ToString(tmp51);
      }
      if(__isset.blocked)
      {
        tmp51.Append(", Blocked: ");
        Blocked.ToString(tmp51);
      }
      if(__isset.userConnected)
      {
        tmp51.Append(", UserConnected: ");
        UserConnected.ToString(tmp51);
      }
      if(__isset.eventId)
      {
        tmp51.Append(", EventId: ");
        EventId.ToString(tmp51);
      }
      tmp51.Append(')');
      return tmp51.ToString();
    }
  }

}
