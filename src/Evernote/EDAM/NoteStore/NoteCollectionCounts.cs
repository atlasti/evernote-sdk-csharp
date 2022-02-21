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
  ///  A data structure representing the number of notes for each notebook
  ///  and tag with a non-zero set of applicable notes.
  /// 
  /// <dl>
  ///  <dt>notebookCounts</dt>
  ///    <dd>
  ///    A mapping from the Notebook GUID to the number of
  ///    notes (from some selection) that are in the corresponding notebook.
  ///    </dd>
  /// 
  ///  <dt>tagCounts</dt>
  ///    <dd>
  ///    A mapping from the Tag GUID to the number of notes (from some
  ///    selection) that have the corresponding tag.
  ///    </dd>
  /// 
  ///  <dt>trashCount</dt>
  ///    <dd>
  ///    If this is set, then this is the number of notes that are in the trash.
  ///    If this is not set, then the number of notes in the trash hasn't been
  ///    reported.  (I.e. if there are no notes in the trash, this will be set
  ///    to 0.)
  ///    </dd>
  ///  </dl>
  /// </summary>
  public partial class NoteCollectionCounts : TBase
  {
    private Dictionary<string, int> _notebookCounts;
    private Dictionary<string, int> _tagCounts;
    private int _trashCount;

    public Dictionary<string, int> NotebookCounts
    {
      get
      {
        return _notebookCounts;
      }
      set
      {
        __isset.notebookCounts = true;
        this._notebookCounts = value;
      }
    }

    public Dictionary<string, int> TagCounts
    {
      get
      {
        return _tagCounts;
      }
      set
      {
        __isset.tagCounts = true;
        this._tagCounts = value;
      }
    }

    public int TrashCount
    {
      get
      {
        return _trashCount;
      }
      set
      {
        __isset.trashCount = true;
        this._trashCount = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool notebookCounts;
      public bool tagCounts;
      public bool trashCount;
    }

    public NoteCollectionCounts()
    {
    }

    public NoteCollectionCounts DeepCopy()
    {
      var tmp120 = new NoteCollectionCounts();
      if((NotebookCounts != null) && __isset.notebookCounts)
      {
        tmp120.NotebookCounts = this.NotebookCounts.DeepCopy();
      }
      tmp120.__isset.notebookCounts = this.__isset.notebookCounts;
      if((TagCounts != null) && __isset.tagCounts)
      {
        tmp120.TagCounts = this.TagCounts.DeepCopy();
      }
      tmp120.__isset.tagCounts = this.__isset.tagCounts;
      if(__isset.trashCount)
      {
        tmp120.TrashCount = this.TrashCount;
      }
      tmp120.__isset.trashCount = this.__isset.trashCount;
      return tmp120;
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
              if (field.Type == TType.Map)
              {
                {
                  TMap _map121 = await iprot.ReadMapBeginAsync(cancellationToken);
                  NotebookCounts = new Dictionary<string, int>(_map121.Count);
                  for(int _i122 = 0; _i122 < _map121.Count; ++_i122)
                  {
                    string _key123;
                    int _val124;
                    _key123 = await iprot.ReadStringAsync(cancellationToken);
                    _val124 = await iprot.ReadI32Async(cancellationToken);
                    NotebookCounts[_key123] = _val124;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Map)
              {
                {
                  TMap _map125 = await iprot.ReadMapBeginAsync(cancellationToken);
                  TagCounts = new Dictionary<string, int>(_map125.Count);
                  for(int _i126 = 0; _i126 < _map125.Count; ++_i126)
                  {
                    string _key127;
                    int _val128;
                    _key127 = await iprot.ReadStringAsync(cancellationToken);
                    _val128 = await iprot.ReadI32Async(cancellationToken);
                    TagCounts[_key127] = _val128;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I32)
              {
                TrashCount = await iprot.ReadI32Async(cancellationToken);
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
        var tmp129 = new TStruct("NoteCollectionCounts");
        await oprot.WriteStructBeginAsync(tmp129, cancellationToken);
        var tmp130 = new TField();
        if((NotebookCounts != null) && __isset.notebookCounts)
        {
          tmp130.Name = "notebookCounts";
          tmp130.Type = TType.Map;
          tmp130.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp130, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.I32, NotebookCounts.Count), cancellationToken);
            foreach (string _iter131 in NotebookCounts.Keys)
            {
              await oprot.WriteStringAsync(_iter131, cancellationToken);
              await oprot.WriteI32Async(NotebookCounts[_iter131], cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((TagCounts != null) && __isset.tagCounts)
        {
          tmp130.Name = "tagCounts";
          tmp130.Type = TType.Map;
          tmp130.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp130, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.I32, TagCounts.Count), cancellationToken);
            foreach (string _iter132 in TagCounts.Keys)
            {
              await oprot.WriteStringAsync(_iter132, cancellationToken);
              await oprot.WriteI32Async(TagCounts[_iter132], cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.trashCount)
        {
          tmp130.Name = "trashCount";
          tmp130.Type = TType.I32;
          tmp130.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp130, cancellationToken);
          await oprot.WriteI32Async(TrashCount, cancellationToken);
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
      if (!(that is NoteCollectionCounts other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.notebookCounts == other.__isset.notebookCounts) && ((!__isset.notebookCounts) || (TCollections.Equals(NotebookCounts, other.NotebookCounts))))
        && ((__isset.tagCounts == other.__isset.tagCounts) && ((!__isset.tagCounts) || (TCollections.Equals(TagCounts, other.TagCounts))))
        && ((__isset.trashCount == other.__isset.trashCount) && ((!__isset.trashCount) || (global::System.Object.Equals(TrashCount, other.TrashCount))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((NotebookCounts != null) && __isset.notebookCounts)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(NotebookCounts);
        }
        if((TagCounts != null) && __isset.tagCounts)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(TagCounts);
        }
        if(__isset.trashCount)
        {
          hashcode = (hashcode * 397) + TrashCount.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp133 = new StringBuilder("NoteCollectionCounts(");
      int tmp134 = 0;
      if((NotebookCounts != null) && __isset.notebookCounts)
      {
        if(0 < tmp134++) { tmp133.Append(", "); }
        tmp133.Append("NotebookCounts: ");
        NotebookCounts.ToString(tmp133);
      }
      if((TagCounts != null) && __isset.tagCounts)
      {
        if(0 < tmp134++) { tmp133.Append(", "); }
        tmp133.Append("TagCounts: ");
        TagCounts.ToString(tmp133);
      }
      if(__isset.trashCount)
      {
        if(0 < tmp134++) { tmp133.Append(", "); }
        tmp133.Append("TrashCount: ");
        TrashCount.ToString(tmp133);
      }
      tmp133.Append(')');
      return tmp133.ToString();
    }
  }

}
