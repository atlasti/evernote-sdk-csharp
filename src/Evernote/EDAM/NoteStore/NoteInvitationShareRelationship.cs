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

namespace Evernote.EDAM.NoteStore
{

  /// <summary>
  /// Describes an invitation to a person to use their Evernote credentials
  /// to gain access to a note belonging to another user.
  /// 
  /// <dl>
  /// <dt>displayName</dt>
  /// <dd>The string that clients should show to users to represent this
  /// invitation.</dd>
  /// 
  /// <dt>recipientIdentityId</dt>
  /// <dd>Identifies the identity of the invitation recipient. Once the
  /// identity has been claimed by an Evernote user and they have accessed
  /// the note at least once, the invitation will be used up and will no
  /// longer be returned by the service to clients. Instead, that recipient
  /// will be included in the list of NoteMemberShareRelationships.</dd>
  /// 
  /// <dt>privilege</dt>
  /// <dd>The privilege level that the recipient will be granted when they
  /// accept this invitation. If the user already has a higher privilege to
  /// access this note then this will not affect the recipient's privileges.</dd>
  /// 
  /// <dt>sharerUserId</dt>
  /// <dd>The user id of the user who most recently shared this note to this
  /// recipient. This field is used by the service to convey information
  /// to the user, so clients should treat it as read-only.</dd>
  /// </summary>
  public partial class NoteInvitationShareRelationship : TBase
  {
    private string _displayName;
    private long _recipientIdentityId;
    private global::Evernote.EDAM.Type.SharedNotePrivilegeLevel _privilege;
    private int _sharerUserId;

    public string DisplayName
    {
      get
      {
        return _displayName;
      }
      set
      {
        __isset.displayName = true;
        this._displayName = value;
      }
    }

    public long RecipientIdentityId
    {
      get
      {
        return _recipientIdentityId;
      }
      set
      {
        __isset.recipientIdentityId = true;
        this._recipientIdentityId = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.SharedNotePrivilegeLevel"/>
    /// </summary>
    public global::Evernote.EDAM.Type.SharedNotePrivilegeLevel Privilege
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

    public int SharerUserId
    {
      get
      {
        return _sharerUserId;
      }
      set
      {
        __isset.sharerUserId = true;
        this._sharerUserId = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool displayName;
      public bool recipientIdentityId;
      public bool privilege;
      public bool sharerUserId;
    }

    public NoteInvitationShareRelationship()
    {
    }

    public NoteInvitationShareRelationship DeepCopy()
    {
      var tmp302 = new NoteInvitationShareRelationship();
      if((DisplayName != null) && __isset.displayName)
      {
        tmp302.DisplayName = this.DisplayName;
      }
      tmp302.__isset.displayName = this.__isset.displayName;
      if(__isset.recipientIdentityId)
      {
        tmp302.RecipientIdentityId = this.RecipientIdentityId;
      }
      tmp302.__isset.recipientIdentityId = this.__isset.recipientIdentityId;
      if(__isset.privilege)
      {
        tmp302.Privilege = this.Privilege;
      }
      tmp302.__isset.privilege = this.__isset.privilege;
      if(__isset.sharerUserId)
      {
        tmp302.SharerUserId = this.SharerUserId;
      }
      tmp302.__isset.sharerUserId = this.__isset.sharerUserId;
      return tmp302;
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
              if (field.Type == TType.String)
              {
                DisplayName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                RecipientIdentityId = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Privilege = (global::Evernote.EDAM.Type.SharedNotePrivilegeLevel)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                SharerUserId = await iprot.ReadI32Async(cancellationToken);
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
        var tmp303 = new TStruct("NoteInvitationShareRelationship");
        await oprot.WriteStructBeginAsync(tmp303, cancellationToken);
        var tmp304 = new TField();
        if((DisplayName != null) && __isset.displayName)
        {
          tmp304.Name = "displayName";
          tmp304.Type = TType.String;
          tmp304.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp304, cancellationToken);
          await oprot.WriteStringAsync(DisplayName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.recipientIdentityId)
        {
          tmp304.Name = "recipientIdentityId";
          tmp304.Type = TType.I64;
          tmp304.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp304, cancellationToken);
          await oprot.WriteI64Async(RecipientIdentityId, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.privilege)
        {
          tmp304.Name = "privilege";
          tmp304.Type = TType.I32;
          tmp304.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp304, cancellationToken);
          await oprot.WriteI32Async((int)Privilege, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.sharerUserId)
        {
          tmp304.Name = "sharerUserId";
          tmp304.Type = TType.I32;
          tmp304.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp304, cancellationToken);
          await oprot.WriteI32Async(SharerUserId, cancellationToken);
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
      if (!(that is NoteInvitationShareRelationship other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.displayName == other.__isset.displayName) && ((!__isset.displayName) || (global::System.Object.Equals(DisplayName, other.DisplayName))))
        && ((__isset.recipientIdentityId == other.__isset.recipientIdentityId) && ((!__isset.recipientIdentityId) || (global::System.Object.Equals(RecipientIdentityId, other.RecipientIdentityId))))
        && ((__isset.privilege == other.__isset.privilege) && ((!__isset.privilege) || (global::System.Object.Equals(Privilege, other.Privilege))))
        && ((__isset.sharerUserId == other.__isset.sharerUserId) && ((!__isset.sharerUserId) || (global::System.Object.Equals(SharerUserId, other.SharerUserId))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((DisplayName != null) && __isset.displayName)
        {
          hashcode = (hashcode * 397) + DisplayName.GetHashCode();
        }
        if(__isset.recipientIdentityId)
        {
          hashcode = (hashcode * 397) + RecipientIdentityId.GetHashCode();
        }
        if(__isset.privilege)
        {
          hashcode = (hashcode * 397) + Privilege.GetHashCode();
        }
        if(__isset.sharerUserId)
        {
          hashcode = (hashcode * 397) + SharerUserId.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp305 = new StringBuilder("NoteInvitationShareRelationship(");
      int tmp306 = 0;
      if((DisplayName != null) && __isset.displayName)
      {
        if(0 < tmp306++) { tmp305.Append(", "); }
        tmp305.Append("DisplayName: ");
        DisplayName.ToString(tmp305);
      }
      if(__isset.recipientIdentityId)
      {
        if(0 < tmp306++) { tmp305.Append(", "); }
        tmp305.Append("RecipientIdentityId: ");
        RecipientIdentityId.ToString(tmp305);
      }
      if(__isset.privilege)
      {
        if(0 < tmp306++) { tmp305.Append(", "); }
        tmp305.Append("Privilege: ");
        Privilege.ToString(tmp305);
      }
      if(__isset.sharerUserId)
      {
        if(0 < tmp306++) { tmp305.Append(", "); }
        tmp305.Append("SharerUserId: ");
        SharerUserId.ToString(tmp305);
      }
      tmp305.Append(')');
      return tmp305.ToString();
    }
  }

}
