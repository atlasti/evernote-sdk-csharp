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
  /// Describes an invitation to a person to use their Evernote
  /// credentials to become a member of a notebook.
  /// 
  /// <dl>
  /// <dt>displayName</dt>
  /// <dd>The string that clients should show to users to represent this
  /// invitation.</dd>
  /// 
  /// <dt>recipientUserIdentity</dt>
  /// <dd>Identifies the recipient of the invitation. The user identity
  /// type can be either EMAIL, EVERNOTE or IDENTITYID. If the
  /// invitation was created using the classic notebook sharing APIs it will be EMAIL. If it
  /// was created using the new identity-based notebook sharing APIs it will either be
  /// EVERNOTE or IDENTITYID, depending on whether we can map the identity to an Evernote
  /// user at the time of creation.
  /// </dd>
  /// 
  /// <dt>privilege</dt>
  /// <dd>The privilege level at which the member will be joined, if it
  /// turns out that the member is not already joined at a higher level.
  /// Note that the <tt>identity</tt> field may not uniquely identify an
  /// Evernote User ID, and so we won't know until the invitation is
  /// redeemed whether or not the recipient already has privilege.</dd>
  /// 
  /// <dt>sharerUserId</dt>
  /// <dd>The user id of the user who most recently shared this notebook
  /// to this identity. This field is used by the service to convey information
  /// to the user, so clients should treat it as read-only.</dd>
  /// </dl>
  /// </summary>
  public partial class InvitationShareRelationship : TBase
  {
    private string _displayName;
    private global::Evernote.EDAM.Type.UserIdentity _recipientUserIdentity;
    private global::Evernote.EDAM.NoteStore.ShareRelationshipPrivilegeLevel _privilege;
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

    public global::Evernote.EDAM.Type.UserIdentity RecipientUserIdentity
    {
      get
      {
        return _recipientUserIdentity;
      }
      set
      {
        __isset.recipientUserIdentity = true;
        this._recipientUserIdentity = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.NoteStore.ShareRelationshipPrivilegeLevel"/>
    /// </summary>
    public global::Evernote.EDAM.NoteStore.ShareRelationshipPrivilegeLevel Privilege
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
      public bool recipientUserIdentity;
      public bool privilege;
      public bool sharerUserId;
    }

    public InvitationShareRelationship()
    {
    }

    public InvitationShareRelationship DeepCopy()
    {
      var tmp211 = new InvitationShareRelationship();
      if((DisplayName != null) && __isset.displayName)
      {
        tmp211.DisplayName = this.DisplayName;
      }
      tmp211.__isset.displayName = this.__isset.displayName;
      if((RecipientUserIdentity != null) && __isset.recipientUserIdentity)
      {
        tmp211.RecipientUserIdentity = (global::Evernote.EDAM.Type.UserIdentity)this.RecipientUserIdentity.DeepCopy();
      }
      tmp211.__isset.recipientUserIdentity = this.__isset.recipientUserIdentity;
      if(__isset.privilege)
      {
        tmp211.Privilege = this.Privilege;
      }
      tmp211.__isset.privilege = this.__isset.privilege;
      if(__isset.sharerUserId)
      {
        tmp211.SharerUserId = this.SharerUserId;
      }
      tmp211.__isset.sharerUserId = this.__isset.sharerUserId;
      return tmp211;
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
              if (field.Type == TType.Struct)
              {
                RecipientUserIdentity = new global::Evernote.EDAM.Type.UserIdentity();
                await RecipientUserIdentity.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                Privilege = (global::Evernote.EDAM.NoteStore.ShareRelationshipPrivilegeLevel)await iprot.ReadI32Async(cancellationToken);
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
        var tmp212 = new TStruct("InvitationShareRelationship");
        await oprot.WriteStructBeginAsync(tmp212, cancellationToken);
        var tmp213 = new TField();
        if((DisplayName != null) && __isset.displayName)
        {
          tmp213.Name = "displayName";
          tmp213.Type = TType.String;
          tmp213.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp213, cancellationToken);
          await oprot.WriteStringAsync(DisplayName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((RecipientUserIdentity != null) && __isset.recipientUserIdentity)
        {
          tmp213.Name = "recipientUserIdentity";
          tmp213.Type = TType.Struct;
          tmp213.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp213, cancellationToken);
          await RecipientUserIdentity.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.privilege)
        {
          tmp213.Name = "privilege";
          tmp213.Type = TType.I32;
          tmp213.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp213, cancellationToken);
          await oprot.WriteI32Async((int)Privilege, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.sharerUserId)
        {
          tmp213.Name = "sharerUserId";
          tmp213.Type = TType.I32;
          tmp213.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp213, cancellationToken);
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
      if (!(that is InvitationShareRelationship other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.displayName == other.__isset.displayName) && ((!__isset.displayName) || (global::System.Object.Equals(DisplayName, other.DisplayName))))
        && ((__isset.recipientUserIdentity == other.__isset.recipientUserIdentity) && ((!__isset.recipientUserIdentity) || (global::System.Object.Equals(RecipientUserIdentity, other.RecipientUserIdentity))))
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
        if((RecipientUserIdentity != null) && __isset.recipientUserIdentity)
        {
          hashcode = (hashcode * 397) + RecipientUserIdentity.GetHashCode();
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
      var tmp214 = new StringBuilder("InvitationShareRelationship(");
      int tmp215 = 0;
      if((DisplayName != null) && __isset.displayName)
      {
        if(0 < tmp215++) { tmp214.Append(", "); }
        tmp214.Append("DisplayName: ");
        DisplayName.ToString(tmp214);
      }
      if((RecipientUserIdentity != null) && __isset.recipientUserIdentity)
      {
        if(0 < tmp215++) { tmp214.Append(", "); }
        tmp214.Append("RecipientUserIdentity: ");
        RecipientUserIdentity.ToString(tmp214);
      }
      if(__isset.privilege)
      {
        if(0 < tmp215++) { tmp214.Append(", "); }
        tmp214.Append("Privilege: ");
        Privilege.ToString(tmp214);
      }
      if(__isset.sharerUserId)
      {
        if(0 < tmp215++) { tmp214.Append(", "); }
        tmp214.Append("SharerUserId: ");
        SharerUserId.ToString(tmp214);
      }
      tmp214.Append(')');
      return tmp214.ToString();
    }
  }

}
