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
  /// This structure encapsulates the information about the state of the
  /// user's account for the purpose of "state based" synchronization.
  /// <dl>
  /// <dt>currentTime</dt>
  ///   <dd>
  ///   The server's current date and time.
  ///   </dd>
  /// <dt>fullSyncBefore</dt>
  ///   <dd>
  ///   The cutoff date and time for client caches to be
  ///   updated via incremental synchronization.  Any clients that were last
  ///   synched with the server before this date/time must do a full resync of all
  ///   objects.  This cutoff point will change over time as archival data is
  ///   deleted or special circumstances on the service require resynchronization.
  ///   </dd>
  /// <dt>updateCount</dt>
  ///   <dd>
  ///   Indicates the total number of transactions that have
  ///   been committed within the account.  This reflects (for example) the
  ///   number of discrete additions or modifications that have been made to
  ///   the data in this account (tags, notes, resources, etc.).
  ///   This number is the "high water mark" for Update Sequence Numbers (USN)
  ///   within the account.
  ///   </dd>
  /// <dt>uploaded</dt>
  ///   <dd>
  ///   The total number of bytes that have been uploaded to
  ///   this account in the current monthly period.  This can be compared against
  ///   Accounting.uploadLimit (from the UserStore) to determine how close the user
  ///   is to their monthly upload limit.
  ///   This value may not be present if the SyncState has been retrieved by
  ///   a caller that only has read access to the account.
  ///   </dd>
  /// <dt>userLastUpdated</dt>
  ///   <dd>
  ///   The last time when a user's account level information was changed. This value
  ///   is the latest time when a modification was made to any of the following:
  ///   accounting information (billing, quota, premium status, etc.), user attributes
  ///   and business user information (business name, business user attributes, etc.) if
  ///   the user is in a business.
  ///   Clients who need to maintain account information about a User should watch this
  ///   field for updates rather than polling UserStore.getUser for updates. Here is the
  ///   basic flow that clients should follow:
  ///   <ol>
  ///     <li>Call NoteStore.getSyncState to retrieve the SyncState object</li>
  ///     <li>Compare SyncState.userLastUpdated to previously stored value:
  ///         if (SyncState.userLastUpdated > previousValue)
  ///           call UserStore.getUser to get the latest User object;
  ///         else
  ///           do nothing;</li>
  ///     <li>Update previousValue = SyncState.userLastUpdated</li>
  ///   </ol>
  ///   </dd>
  /// <dt>userMaxMessageEventId</dt>
  ///   <dd>
  ///   The greatest MessageEventID for this user's account. Clients that do a full
  ///   sync should store this value locally and compare their local copy to the
  ///   value returned by getSyncState to determine if they need to sync with
  ///   MessageStore. This value will be omitted if the user has never sent or
  ///   received a message.
  ///   </dd>
  /// </dl>
  /// </summary>
  public partial class SyncState : TBase
  {
    private long _uploaded;
    private long _userLastUpdated;
    private long _userMaxMessageEventId;

    public long CurrentTime { get; set; }

    public long FullSyncBefore { get; set; }

    public int UpdateCount { get; set; }

    public long Uploaded
    {
      get
      {
        return _uploaded;
      }
      set
      {
        __isset.uploaded = true;
        this._uploaded = value;
      }
    }

    public long UserLastUpdated
    {
      get
      {
        return _userLastUpdated;
      }
      set
      {
        __isset.userLastUpdated = true;
        this._userLastUpdated = value;
      }
    }

    public long UserMaxMessageEventId
    {
      get
      {
        return _userMaxMessageEventId;
      }
      set
      {
        __isset.userMaxMessageEventId = true;
        this._userMaxMessageEventId = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool uploaded;
      public bool userLastUpdated;
      public bool userMaxMessageEventId;
    }

    public SyncState()
    {
    }

    public SyncState(long currentTime, long fullSyncBefore, int updateCount) : this()
    {
      this.CurrentTime = currentTime;
      this.FullSyncBefore = fullSyncBefore;
      this.UpdateCount = updateCount;
    }

    public SyncState DeepCopy()
    {
      var tmp0 = new SyncState();
      tmp0.CurrentTime = this.CurrentTime;
      tmp0.FullSyncBefore = this.FullSyncBefore;
      tmp0.UpdateCount = this.UpdateCount;
      if(__isset.uploaded)
      {
        tmp0.Uploaded = this.Uploaded;
      }
      tmp0.__isset.uploaded = this.__isset.uploaded;
      if(__isset.userLastUpdated)
      {
        tmp0.UserLastUpdated = this.UserLastUpdated;
      }
      tmp0.__isset.userLastUpdated = this.__isset.userLastUpdated;
      if(__isset.userMaxMessageEventId)
      {
        tmp0.UserMaxMessageEventId = this.UserMaxMessageEventId;
      }
      tmp0.__isset.userMaxMessageEventId = this.__isset.userMaxMessageEventId;
      return tmp0;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_currentTime = false;
        bool isset_fullSyncBefore = false;
        bool isset_updateCount = false;
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
                CurrentTime = await iprot.ReadI64Async(cancellationToken);
                isset_currentTime = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                FullSyncBefore = await iprot.ReadI64Async(cancellationToken);
                isset_fullSyncBefore = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                UpdateCount = await iprot.ReadI32Async(cancellationToken);
                isset_updateCount = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.I64)
              {
                Uploaded = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I64)
              {
                UserLastUpdated = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I64)
              {
                UserMaxMessageEventId = await iprot.ReadI64Async(cancellationToken);
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
        if (!isset_currentTime)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_fullSyncBefore)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_updateCount)
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
        var tmp1 = new TStruct("SyncState");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        tmp2.Name = "currentTime";
        tmp2.Type = TType.I64;
        tmp2.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
        await oprot.WriteI64Async(CurrentTime, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp2.Name = "fullSyncBefore";
        tmp2.Type = TType.I64;
        tmp2.ID = 2;
        await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
        await oprot.WriteI64Async(FullSyncBefore, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        tmp2.Name = "updateCount";
        tmp2.Type = TType.I32;
        tmp2.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
        await oprot.WriteI32Async(UpdateCount, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if(__isset.uploaded)
        {
          tmp2.Name = "uploaded";
          tmp2.Type = TType.I64;
          tmp2.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(Uploaded, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.userLastUpdated)
        {
          tmp2.Name = "userLastUpdated";
          tmp2.Type = TType.I64;
          tmp2.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(UserLastUpdated, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.userMaxMessageEventId)
        {
          tmp2.Name = "userMaxMessageEventId";
          tmp2.Type = TType.I64;
          tmp2.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI64Async(UserMaxMessageEventId, cancellationToken);
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
      if (!(that is SyncState other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(CurrentTime, other.CurrentTime)
        && global::System.Object.Equals(FullSyncBefore, other.FullSyncBefore)
        && global::System.Object.Equals(UpdateCount, other.UpdateCount)
        && ((__isset.uploaded == other.__isset.uploaded) && ((!__isset.uploaded) || (global::System.Object.Equals(Uploaded, other.Uploaded))))
        && ((__isset.userLastUpdated == other.__isset.userLastUpdated) && ((!__isset.userLastUpdated) || (global::System.Object.Equals(UserLastUpdated, other.UserLastUpdated))))
        && ((__isset.userMaxMessageEventId == other.__isset.userMaxMessageEventId) && ((!__isset.userMaxMessageEventId) || (global::System.Object.Equals(UserMaxMessageEventId, other.UserMaxMessageEventId))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + CurrentTime.GetHashCode();
        hashcode = (hashcode * 397) + FullSyncBefore.GetHashCode();
        hashcode = (hashcode * 397) + UpdateCount.GetHashCode();
        if(__isset.uploaded)
        {
          hashcode = (hashcode * 397) + Uploaded.GetHashCode();
        }
        if(__isset.userLastUpdated)
        {
          hashcode = (hashcode * 397) + UserLastUpdated.GetHashCode();
        }
        if(__isset.userMaxMessageEventId)
        {
          hashcode = (hashcode * 397) + UserMaxMessageEventId.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("SyncState(");
      tmp3.Append(", CurrentTime: ");
      CurrentTime.ToString(tmp3);
      tmp3.Append(", FullSyncBefore: ");
      FullSyncBefore.ToString(tmp3);
      tmp3.Append(", UpdateCount: ");
      UpdateCount.ToString(tmp3);
      if(__isset.uploaded)
      {
        tmp3.Append(", Uploaded: ");
        Uploaded.ToString(tmp3);
      }
      if(__isset.userLastUpdated)
      {
        tmp3.Append(", UserLastUpdated: ");
        UserLastUpdated.ToString(tmp3);
      }
      if(__isset.userMaxMessageEventId)
      {
        tmp3.Append(", UserMaxMessageEventId: ");
        UserMaxMessageEventId.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}
