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
  /// A structure containing the results of a call to createOrUpdateNotebookShares.
  /// 
  /// <dl>
  ///   <dt>updateSequenceNum</dt>
  ///   <dd>The USN of the notebook after the call.</dd>
  /// 
  ///   <dt>matchingShares</dt>
  ///   <dd>A list of SharedNotebook records that match the desired recipients. These
  ///       records may have been either created or updated by the call to
  ///       createOrUpdateNotebookShares, or they may have been at the desired privilege
  ///       privilege level prior to the call.</dd>
  /// </dl>
  /// </summary>
  public partial class CreateOrUpdateNotebookSharesResult : TBase
  {
    private int _updateSequenceNum;
    private List<global::Evernote.EDAM.Type.SharedNotebook> _matchingShares;

    public int UpdateSequenceNum
    {
      get
      {
        return _updateSequenceNum;
      }
      set
      {
        __isset.updateSequenceNum = true;
        this._updateSequenceNum = value;
      }
    }

    public List<global::Evernote.EDAM.Type.SharedNotebook> MatchingShares
    {
      get
      {
        return _matchingShares;
      }
      set
      {
        __isset.matchingShares = true;
        this._matchingShares = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool updateSequenceNum;
      public bool matchingShares;
    }

    public CreateOrUpdateNotebookSharesResult()
    {
    }

    public CreateOrUpdateNotebookSharesResult DeepCopy()
    {
      var tmp283 = new CreateOrUpdateNotebookSharesResult();
      if(__isset.updateSequenceNum)
      {
        tmp283.UpdateSequenceNum = this.UpdateSequenceNum;
      }
      tmp283.__isset.updateSequenceNum = this.__isset.updateSequenceNum;
      if((MatchingShares != null) && __isset.matchingShares)
      {
        tmp283.MatchingShares = this.MatchingShares.DeepCopy();
      }
      tmp283.__isset.matchingShares = this.__isset.matchingShares;
      return tmp283;
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
                UpdateSequenceNum = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.List)
              {
                {
                  TList _list284 = await iprot.ReadListBeginAsync(cancellationToken);
                  MatchingShares = new List<global::Evernote.EDAM.Type.SharedNotebook>(_list284.Count);
                  for(int _i285 = 0; _i285 < _list284.Count; ++_i285)
                  {
                    global::Evernote.EDAM.Type.SharedNotebook _elem286;
                    _elem286 = new global::Evernote.EDAM.Type.SharedNotebook();
                    await _elem286.ReadAsync(iprot, cancellationToken);
                    MatchingShares.Add(_elem286);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
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
        var tmp287 = new TStruct("CreateOrUpdateNotebookSharesResult");
        await oprot.WriteStructBeginAsync(tmp287, cancellationToken);
        var tmp288 = new TField();
        if(__isset.updateSequenceNum)
        {
          tmp288.Name = "updateSequenceNum";
          tmp288.Type = TType.I32;
          tmp288.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp288, cancellationToken);
          await oprot.WriteI32Async(UpdateSequenceNum, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((MatchingShares != null) && __isset.matchingShares)
        {
          tmp288.Name = "matchingShares";
          tmp288.Type = TType.List;
          tmp288.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp288, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.Struct, MatchingShares.Count), cancellationToken);
            foreach (global::Evernote.EDAM.Type.SharedNotebook _iter289 in MatchingShares)
            {
              await _iter289.WriteAsync(oprot, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
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
      if (!(that is CreateOrUpdateNotebookSharesResult other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.updateSequenceNum == other.__isset.updateSequenceNum) && ((!__isset.updateSequenceNum) || (global::System.Object.Equals(UpdateSequenceNum, other.UpdateSequenceNum))))
        && ((__isset.matchingShares == other.__isset.matchingShares) && ((!__isset.matchingShares) || (TCollections.Equals(MatchingShares, other.MatchingShares))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.updateSequenceNum)
        {
          hashcode = (hashcode * 397) + UpdateSequenceNum.GetHashCode();
        }
        if((MatchingShares != null) && __isset.matchingShares)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(MatchingShares);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp290 = new StringBuilder("CreateOrUpdateNotebookSharesResult(");
      int tmp291 = 0;
      if(__isset.updateSequenceNum)
      {
        if(0 < tmp291++) { tmp290.Append(", "); }
        tmp290.Append("UpdateSequenceNum: ");
        UpdateSequenceNum.ToString(tmp290);
      }
      if((MatchingShares != null) && __isset.matchingShares)
      {
        if(0 < tmp291++) { tmp290.Append(", "); }
        tmp290.Append("MatchingShares: ");
        MatchingShares.ToString(tmp290);
      }
      tmp290.Append(')');
      return tmp290.ToString();
    }
  }

}
