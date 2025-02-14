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
  /// A description of the thing for which we are searching for related
  /// entities.
  /// 
  /// You must specify either <em>noteGuid</em> or <em>plainText</em>, but
  /// not both. <em>filter</em> and <em>referenceUri</em> are optional.
  /// 
  /// <dl>
  /// <dt>noteGuid</dt>
  /// <dd>The GUID of an existing note in your account for which related
  ///     entities will be found.</dd>
  /// 
  /// <dt>plainText</dt>
  /// <dd>A string of plain text for which to find related entities.
  ///     You should provide a text block with a number of characters between
  ///     EDAM_RELATED_PLAINTEXT_LEN_MIN and EDAM_RELATED_PLAINTEXT_LEN_MAX.
  ///     </dd>
  /// 
  /// <dt>filter</dt>
  /// <dd>The list of criteria that will constrain the notes being considered
  ///     related.
  ///     Please note that some of the parameters may be ignored, such as
  ///     <em>order</em> and <em>ascending</em>.
  /// </dd>
  /// 
  /// <dt>referenceUri</dt>
  /// <dd>A URI string specifying a reference entity, around which "relatedness"
  ///     should be based. This can be an URL pointing to a web page, for example.
  /// </dd>
  /// 
  /// <dt>context</dt>
  /// <dd>Specifies the context to consider when determining related results.
  ///     Clients must leave this value unset unless they wish to explicitly specify a known
  ///     non-default context.
  /// </dd>
  /// 
  /// <dt>cacheKey</dt>
  /// <dd>If set and non-empty, this is an indicator for the server whether it is actually
  ///     necessary to perform a new findRelated call at all. Cache Keys are opaque strings
  ///     which are returned by the server as part of "RelatedResult" in response
  ///     to a "NoteStore.findRelated" query. Cache Keys are inherently query specific.
  /// 
  ///     If set to an empty string, this indicates that the server should generate a cache
  ///     key in the response as part of "RelatedResult".
  /// 
  ///     If not set, the server will not attempt to generate a cache key at all.
  /// </dd>
  /// </dl>
  /// </summary>
  public partial class RelatedQuery : TBase
  {
    private string _noteGuid;
    private string _plainText;
    private global::Evernote.EDAM.NoteStore.NoteFilter _filter;
    private string _referenceUri;
    private string _context;
    private string _cacheKey;

    public string NoteGuid
    {
      get
      {
        return _noteGuid;
      }
      set
      {
        __isset.noteGuid = true;
        this._noteGuid = value;
      }
    }

    public string PlainText
    {
      get
      {
        return _plainText;
      }
      set
      {
        __isset.plainText = true;
        this._plainText = value;
      }
    }

    public global::Evernote.EDAM.NoteStore.NoteFilter Filter
    {
      get
      {
        return _filter;
      }
      set
      {
        __isset.filter = true;
        this._filter = value;
      }
    }

    public string ReferenceUri
    {
      get
      {
        return _referenceUri;
      }
      set
      {
        __isset.referenceUri = true;
        this._referenceUri = value;
      }
    }

    public string Context
    {
      get
      {
        return _context;
      }
      set
      {
        __isset.context = true;
        this._context = value;
      }
    }

    public string CacheKey
    {
      get
      {
        return _cacheKey;
      }
      set
      {
        __isset.cacheKey = true;
        this._cacheKey = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool noteGuid;
      public bool plainText;
      public bool filter;
      public bool referenceUri;
      public bool context;
      public bool cacheKey;
    }

    public RelatedQuery()
    {
    }

    public RelatedQuery DeepCopy()
    {
      var tmp158 = new RelatedQuery();
      if((NoteGuid != null) && __isset.noteGuid)
      {
        tmp158.NoteGuid = this.NoteGuid;
      }
      tmp158.__isset.noteGuid = this.__isset.noteGuid;
      if((PlainText != null) && __isset.plainText)
      {
        tmp158.PlainText = this.PlainText;
      }
      tmp158.__isset.plainText = this.__isset.plainText;
      if((Filter != null) && __isset.filter)
      {
        tmp158.Filter = (global::Evernote.EDAM.NoteStore.NoteFilter)this.Filter.DeepCopy();
      }
      tmp158.__isset.filter = this.__isset.filter;
      if((ReferenceUri != null) && __isset.referenceUri)
      {
        tmp158.ReferenceUri = this.ReferenceUri;
      }
      tmp158.__isset.referenceUri = this.__isset.referenceUri;
      if((Context != null) && __isset.context)
      {
        tmp158.Context = this.Context;
      }
      tmp158.__isset.context = this.__isset.context;
      if((CacheKey != null) && __isset.cacheKey)
      {
        tmp158.CacheKey = this.CacheKey;
      }
      tmp158.__isset.cacheKey = this.__isset.cacheKey;
      return tmp158;
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
                NoteGuid = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                PlainText = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                Filter = new global::Evernote.EDAM.NoteStore.NoteFilter();
                await Filter.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                ReferenceUri = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                Context = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                CacheKey = await iprot.ReadStringAsync(cancellationToken);
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
        var tmp159 = new TStruct("RelatedQuery");
        await oprot.WriteStructBeginAsync(tmp159, cancellationToken);
        var tmp160 = new TField();
        if((NoteGuid != null) && __isset.noteGuid)
        {
          tmp160.Name = "noteGuid";
          tmp160.Type = TType.String;
          tmp160.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp160, cancellationToken);
          await oprot.WriteStringAsync(NoteGuid, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((PlainText != null) && __isset.plainText)
        {
          tmp160.Name = "plainText";
          tmp160.Type = TType.String;
          tmp160.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp160, cancellationToken);
          await oprot.WriteStringAsync(PlainText, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Filter != null) && __isset.filter)
        {
          tmp160.Name = "filter";
          tmp160.Type = TType.Struct;
          tmp160.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp160, cancellationToken);
          await Filter.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ReferenceUri != null) && __isset.referenceUri)
        {
          tmp160.Name = "referenceUri";
          tmp160.Type = TType.String;
          tmp160.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp160, cancellationToken);
          await oprot.WriteStringAsync(ReferenceUri, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Context != null) && __isset.context)
        {
          tmp160.Name = "context";
          tmp160.Type = TType.String;
          tmp160.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp160, cancellationToken);
          await oprot.WriteStringAsync(Context, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((CacheKey != null) && __isset.cacheKey)
        {
          tmp160.Name = "cacheKey";
          tmp160.Type = TType.String;
          tmp160.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp160, cancellationToken);
          await oprot.WriteStringAsync(CacheKey, cancellationToken);
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
      if (!(that is RelatedQuery other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.noteGuid == other.__isset.noteGuid) && ((!__isset.noteGuid) || (global::System.Object.Equals(NoteGuid, other.NoteGuid))))
        && ((__isset.plainText == other.__isset.plainText) && ((!__isset.plainText) || (global::System.Object.Equals(PlainText, other.PlainText))))
        && ((__isset.filter == other.__isset.filter) && ((!__isset.filter) || (global::System.Object.Equals(Filter, other.Filter))))
        && ((__isset.referenceUri == other.__isset.referenceUri) && ((!__isset.referenceUri) || (global::System.Object.Equals(ReferenceUri, other.ReferenceUri))))
        && ((__isset.context == other.__isset.context) && ((!__isset.context) || (global::System.Object.Equals(Context, other.Context))))
        && ((__isset.cacheKey == other.__isset.cacheKey) && ((!__isset.cacheKey) || (global::System.Object.Equals(CacheKey, other.CacheKey))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((NoteGuid != null) && __isset.noteGuid)
        {
          hashcode = (hashcode * 397) + NoteGuid.GetHashCode();
        }
        if((PlainText != null) && __isset.plainText)
        {
          hashcode = (hashcode * 397) + PlainText.GetHashCode();
        }
        if((Filter != null) && __isset.filter)
        {
          hashcode = (hashcode * 397) + Filter.GetHashCode();
        }
        if((ReferenceUri != null) && __isset.referenceUri)
        {
          hashcode = (hashcode * 397) + ReferenceUri.GetHashCode();
        }
        if((Context != null) && __isset.context)
        {
          hashcode = (hashcode * 397) + Context.GetHashCode();
        }
        if((CacheKey != null) && __isset.cacheKey)
        {
          hashcode = (hashcode * 397) + CacheKey.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp161 = new StringBuilder("RelatedQuery(");
      int tmp162 = 0;
      if((NoteGuid != null) && __isset.noteGuid)
      {
        if(0 < tmp162++) { tmp161.Append(", "); }
        tmp161.Append("NoteGuid: ");
        NoteGuid.ToString(tmp161);
      }
      if((PlainText != null) && __isset.plainText)
      {
        if(0 < tmp162++) { tmp161.Append(", "); }
        tmp161.Append("PlainText: ");
        PlainText.ToString(tmp161);
      }
      if((Filter != null) && __isset.filter)
      {
        if(0 < tmp162++) { tmp161.Append(", "); }
        tmp161.Append("Filter: ");
        Filter.ToString(tmp161);
      }
      if((ReferenceUri != null) && __isset.referenceUri)
      {
        if(0 < tmp162++) { tmp161.Append(", "); }
        tmp161.Append("ReferenceUri: ");
        ReferenceUri.ToString(tmp161);
      }
      if((Context != null) && __isset.context)
      {
        if(0 < tmp162++) { tmp161.Append(", "); }
        tmp161.Append("Context: ");
        Context.ToString(tmp161);
      }
      if((CacheKey != null) && __isset.cacheKey)
      {
        if(0 < tmp162++) { tmp161.Append(", "); }
        tmp161.Append("CacheKey: ");
        CacheKey.ToString(tmp161);
      }
      tmp161.Append(')');
      return tmp161.ToString();
    }
  }

}
