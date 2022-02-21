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
  /// This structure is used in the set of results returned by the
  /// findNotesMetadata function.  It represents the high-level information about
  /// a single Note, without some of the larger deep structure.  This allows
  /// for the information about a list of Notes to be returned relatively quickly
  /// with less marshalling and data transfer to remote clients.
  /// Most fields in this structure are identical to the corresponding field in
  /// the Note structure, with the exception of:
  /// 
  /// <dl>
  /// <dt>largestResourceMime</dt>
  ///   <dd>If set, then this will contain the MIME type of the largest Resource
  ///   (in bytes) within the Note.  This may be useful, for example, to choose
  ///   an appropriate icon or thumbnail to represent the Note.
  ///   </dd>
  /// 
  /// <dt>largestResourceSize</dt>
  ///  <dd>If set, this will contain the size of the largest Resource file, in
  ///  bytes, within the Note.  This may be useful, for example, to decide whether
  ///  to ask the server for a thumbnail to represent the Note.
  ///  </dd>
  /// </dl>
  /// </summary>
  public partial class NoteMetadata : TBase
  {
    private string _title;
    private int _contentLength;
    private long _created;
    private long _updated;
    private long _deleted;
    private int _updateSequenceNum;
    private string _notebookGuid;
    private List<string> _tagGuids;
    private global::Evernote.EDAM.Type.NoteAttributes _attributes;
    private string _largestResourceMime;
    private int _largestResourceSize;

    public string Guid { get; set; }

    public string Title
    {
      get
      {
        return _title;
      }
      set
      {
        __isset.title = true;
        this._title = value;
      }
    }

    public int ContentLength
    {
      get
      {
        return _contentLength;
      }
      set
      {
        __isset.contentLength = true;
        this._contentLength = value;
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

    public string NotebookGuid
    {
      get
      {
        return _notebookGuid;
      }
      set
      {
        __isset.notebookGuid = true;
        this._notebookGuid = value;
      }
    }

    public List<string> TagGuids
    {
      get
      {
        return _tagGuids;
      }
      set
      {
        __isset.tagGuids = true;
        this._tagGuids = value;
      }
    }

    public global::Evernote.EDAM.Type.NoteAttributes Attributes
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

    public string LargestResourceMime
    {
      get
      {
        return _largestResourceMime;
      }
      set
      {
        __isset.largestResourceMime = true;
        this._largestResourceMime = value;
      }
    }

    public int LargestResourceSize
    {
      get
      {
        return _largestResourceSize;
      }
      set
      {
        __isset.largestResourceSize = true;
        this._largestResourceSize = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool title;
      public bool contentLength;
      public bool created;
      public bool updated;
      public bool deleted;
      public bool updateSequenceNum;
      public bool notebookGuid;
      public bool tagGuids;
      public bool attributes;
      public bool largestResourceMime;
      public bool largestResourceSize;
    }

    public NoteMetadata()
    {
    }

    public NoteMetadata(string guid) : this()
    {
      this.Guid = guid;
    }

    public NoteMetadata DeepCopy()
    {
      var tmp89 = new NoteMetadata();
      if((Guid != null))
      {
        tmp89.Guid = this.Guid;
      }
      if((Title != null) && __isset.title)
      {
        tmp89.Title = this.Title;
      }
      tmp89.__isset.title = this.__isset.title;
      if(__isset.contentLength)
      {
        tmp89.ContentLength = this.ContentLength;
      }
      tmp89.__isset.contentLength = this.__isset.contentLength;
      if(__isset.created)
      {
        tmp89.Created = this.Created;
      }
      tmp89.__isset.created = this.__isset.created;
      if(__isset.updated)
      {
        tmp89.Updated = this.Updated;
      }
      tmp89.__isset.updated = this.__isset.updated;
      if(__isset.deleted)
      {
        tmp89.Deleted = this.Deleted;
      }
      tmp89.__isset.deleted = this.__isset.deleted;
      if(__isset.updateSequenceNum)
      {
        tmp89.UpdateSequenceNum = this.UpdateSequenceNum;
      }
      tmp89.__isset.updateSequenceNum = this.__isset.updateSequenceNum;
      if((NotebookGuid != null) && __isset.notebookGuid)
      {
        tmp89.NotebookGuid = this.NotebookGuid;
      }
      tmp89.__isset.notebookGuid = this.__isset.notebookGuid;
      if((TagGuids != null) && __isset.tagGuids)
      {
        tmp89.TagGuids = this.TagGuids.DeepCopy();
      }
      tmp89.__isset.tagGuids = this.__isset.tagGuids;
      if((Attributes != null) && __isset.attributes)
      {
        tmp89.Attributes = (global::Evernote.EDAM.Type.NoteAttributes)this.Attributes.DeepCopy();
      }
      tmp89.__isset.attributes = this.__isset.attributes;
      if((LargestResourceMime != null) && __isset.largestResourceMime)
      {
        tmp89.LargestResourceMime = this.LargestResourceMime;
      }
      tmp89.__isset.largestResourceMime = this.__isset.largestResourceMime;
      if(__isset.largestResourceSize)
      {
        tmp89.LargestResourceSize = this.LargestResourceSize;
      }
      tmp89.__isset.largestResourceSize = this.__isset.largestResourceSize;
      return tmp89;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_guid = false;
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
                Guid = await iprot.ReadStringAsync(cancellationToken);
                isset_guid = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Title = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                ContentLength = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.I64)
              {
                Created = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I64)
              {
                Updated = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.I64)
              {
                Deleted = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.I32)
              {
                UpdateSequenceNum = await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.String)
              {
                NotebookGuid = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 12:
              if (field.Type == TType.List)
              {
                {
                  TList _list90 = await iprot.ReadListBeginAsync(cancellationToken);
                  TagGuids = new List<string>(_list90.Count);
                  for(int _i91 = 0; _i91 < _list90.Count; ++_i91)
                  {
                    string _elem92;
                    _elem92 = await iprot.ReadStringAsync(cancellationToken);
                    TagGuids.Add(_elem92);
                  }
                  await iprot.ReadListEndAsync(cancellationToken);
                }
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 14:
              if (field.Type == TType.Struct)
              {
                Attributes = new global::Evernote.EDAM.Type.NoteAttributes();
                await Attributes.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 20:
              if (field.Type == TType.String)
              {
                LargestResourceMime = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 21:
              if (field.Type == TType.I32)
              {
                LargestResourceSize = await iprot.ReadI32Async(cancellationToken);
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
        if (!isset_guid)
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
        var tmp93 = new TStruct("NoteMetadata");
        await oprot.WriteStructBeginAsync(tmp93, cancellationToken);
        var tmp94 = new TField();
        if((Guid != null))
        {
          tmp94.Name = "guid";
          tmp94.Type = TType.String;
          tmp94.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteStringAsync(Guid, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Title != null) && __isset.title)
        {
          tmp94.Name = "title";
          tmp94.Type = TType.String;
          tmp94.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteStringAsync(Title, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.contentLength)
        {
          tmp94.Name = "contentLength";
          tmp94.Type = TType.I32;
          tmp94.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteI32Async(ContentLength, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.created)
        {
          tmp94.Name = "created";
          tmp94.Type = TType.I64;
          tmp94.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteI64Async(Created, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.updated)
        {
          tmp94.Name = "updated";
          tmp94.Type = TType.I64;
          tmp94.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteI64Async(Updated, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.deleted)
        {
          tmp94.Name = "deleted";
          tmp94.Type = TType.I64;
          tmp94.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteI64Async(Deleted, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.updateSequenceNum)
        {
          tmp94.Name = "updateSequenceNum";
          tmp94.Type = TType.I32;
          tmp94.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteI32Async(UpdateSequenceNum, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((NotebookGuid != null) && __isset.notebookGuid)
        {
          tmp94.Name = "notebookGuid";
          tmp94.Type = TType.String;
          tmp94.ID = 11;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteStringAsync(NotebookGuid, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((TagGuids != null) && __isset.tagGuids)
        {
          tmp94.Name = "tagGuids";
          tmp94.Type = TType.List;
          tmp94.ID = 12;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          {
            await oprot.WriteListBeginAsync(new TList(TType.String, TagGuids.Count), cancellationToken);
            foreach (string _iter95 in TagGuids)
            {
              await oprot.WriteStringAsync(_iter95, cancellationToken);
            }
            await oprot.WriteListEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Attributes != null) && __isset.attributes)
        {
          tmp94.Name = "attributes";
          tmp94.Type = TType.Struct;
          tmp94.ID = 14;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await Attributes.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((LargestResourceMime != null) && __isset.largestResourceMime)
        {
          tmp94.Name = "largestResourceMime";
          tmp94.Type = TType.String;
          tmp94.ID = 20;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteStringAsync(LargestResourceMime, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.largestResourceSize)
        {
          tmp94.Name = "largestResourceSize";
          tmp94.Type = TType.I32;
          tmp94.ID = 21;
          await oprot.WriteFieldBeginAsync(tmp94, cancellationToken);
          await oprot.WriteI32Async(LargestResourceSize, cancellationToken);
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
      if (!(that is NoteMetadata other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(Guid, other.Guid)
        && ((__isset.title == other.__isset.title) && ((!__isset.title) || (global::System.Object.Equals(Title, other.Title))))
        && ((__isset.contentLength == other.__isset.contentLength) && ((!__isset.contentLength) || (global::System.Object.Equals(ContentLength, other.ContentLength))))
        && ((__isset.created == other.__isset.created) && ((!__isset.created) || (global::System.Object.Equals(Created, other.Created))))
        && ((__isset.updated == other.__isset.updated) && ((!__isset.updated) || (global::System.Object.Equals(Updated, other.Updated))))
        && ((__isset.deleted == other.__isset.deleted) && ((!__isset.deleted) || (global::System.Object.Equals(Deleted, other.Deleted))))
        && ((__isset.updateSequenceNum == other.__isset.updateSequenceNum) && ((!__isset.updateSequenceNum) || (global::System.Object.Equals(UpdateSequenceNum, other.UpdateSequenceNum))))
        && ((__isset.notebookGuid == other.__isset.notebookGuid) && ((!__isset.notebookGuid) || (global::System.Object.Equals(NotebookGuid, other.NotebookGuid))))
        && ((__isset.tagGuids == other.__isset.tagGuids) && ((!__isset.tagGuids) || (TCollections.Equals(TagGuids, other.TagGuids))))
        && ((__isset.attributes == other.__isset.attributes) && ((!__isset.attributes) || (global::System.Object.Equals(Attributes, other.Attributes))))
        && ((__isset.largestResourceMime == other.__isset.largestResourceMime) && ((!__isset.largestResourceMime) || (global::System.Object.Equals(LargestResourceMime, other.LargestResourceMime))))
        && ((__isset.largestResourceSize == other.__isset.largestResourceSize) && ((!__isset.largestResourceSize) || (global::System.Object.Equals(LargestResourceSize, other.LargestResourceSize))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((Guid != null))
        {
          hashcode = (hashcode * 397) + Guid.GetHashCode();
        }
        if((Title != null) && __isset.title)
        {
          hashcode = (hashcode * 397) + Title.GetHashCode();
        }
        if(__isset.contentLength)
        {
          hashcode = (hashcode * 397) + ContentLength.GetHashCode();
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
        if(__isset.updateSequenceNum)
        {
          hashcode = (hashcode * 397) + UpdateSequenceNum.GetHashCode();
        }
        if((NotebookGuid != null) && __isset.notebookGuid)
        {
          hashcode = (hashcode * 397) + NotebookGuid.GetHashCode();
        }
        if((TagGuids != null) && __isset.tagGuids)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(TagGuids);
        }
        if((Attributes != null) && __isset.attributes)
        {
          hashcode = (hashcode * 397) + Attributes.GetHashCode();
        }
        if((LargestResourceMime != null) && __isset.largestResourceMime)
        {
          hashcode = (hashcode * 397) + LargestResourceMime.GetHashCode();
        }
        if(__isset.largestResourceSize)
        {
          hashcode = (hashcode * 397) + LargestResourceSize.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp96 = new StringBuilder("NoteMetadata(");
      if((Guid != null))
      {
        tmp96.Append(", Guid: ");
        Guid.ToString(tmp96);
      }
      if((Title != null) && __isset.title)
      {
        tmp96.Append(", Title: ");
        Title.ToString(tmp96);
      }
      if(__isset.contentLength)
      {
        tmp96.Append(", ContentLength: ");
        ContentLength.ToString(tmp96);
      }
      if(__isset.created)
      {
        tmp96.Append(", Created: ");
        Created.ToString(tmp96);
      }
      if(__isset.updated)
      {
        tmp96.Append(", Updated: ");
        Updated.ToString(tmp96);
      }
      if(__isset.deleted)
      {
        tmp96.Append(", Deleted: ");
        Deleted.ToString(tmp96);
      }
      if(__isset.updateSequenceNum)
      {
        tmp96.Append(", UpdateSequenceNum: ");
        UpdateSequenceNum.ToString(tmp96);
      }
      if((NotebookGuid != null) && __isset.notebookGuid)
      {
        tmp96.Append(", NotebookGuid: ");
        NotebookGuid.ToString(tmp96);
      }
      if((TagGuids != null) && __isset.tagGuids)
      {
        tmp96.Append(", TagGuids: ");
        TagGuids.ToString(tmp96);
      }
      if((Attributes != null) && __isset.attributes)
      {
        tmp96.Append(", Attributes: ");
        Attributes.ToString(tmp96);
      }
      if((LargestResourceMime != null) && __isset.largestResourceMime)
      {
        tmp96.Append(", LargestResourceMime: ");
        LargestResourceMime.ToString(tmp96);
      }
      if(__isset.largestResourceSize)
      {
        tmp96.Append(", LargestResourceSize: ");
        LargestResourceSize.ToString(tmp96);
      }
      tmp96.Append(')');
      return tmp96.ToString();
    }
  }

}
