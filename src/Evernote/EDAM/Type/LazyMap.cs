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
  /// A structure that wraps a map of name/value pairs whose values are not
  /// always present in the structure in order to reduce space when obtaining
  /// batches of entities that contain the map.
  /// 
  /// When the server provides the client with a LazyMap, it will fill in either
  /// the keysOnly field or the fullMap field, but never both, based on the API
  /// and parameters.
  /// 
  /// When a client provides a LazyMap to the server as part of an update to
  /// an object, the server will only update the LazyMap if the fullMap field is
  /// set. If the fullMap field is not set, the server will not make any changes
  /// to the map.
  /// 
  /// Check the API documentation of the individual calls involving the LazyMap
  /// for full details including the constraints of the names and values of the
  /// map.
  /// 
  /// <dl>
  /// <dt>keysOnly</dt>
  ///   <dd>The set of keys for the map.  This field is ignored by the
  ///       server when set.
  ///   </dd>
  /// 
  /// <dt>fullMap</dt>
  ///   <dd>The complete map, including all keys and values.
  ///   </dd>
  /// </dl>
  /// </summary>
  public partial class LazyMap : TBase
  {
    private THashSet<string> _keysOnly;
    private Dictionary<string, string> _fullMap;

    public THashSet<string> KeysOnly
    {
      get
      {
        return _keysOnly;
      }
      set
      {
        __isset.keysOnly = true;
        this._keysOnly = value;
      }
    }

    public Dictionary<string, string> FullMap
    {
      get
      {
        return _fullMap;
      }
      set
      {
        __isset.fullMap = true;
        this._fullMap = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool keysOnly;
      public bool fullMap;
    }

    public LazyMap()
    {
    }

    public LazyMap DeepCopy()
    {
      var tmp58 = new LazyMap();
      if((KeysOnly != null) && __isset.keysOnly)
      {
        tmp58.KeysOnly = this.KeysOnly.DeepCopy();
      }
      tmp58.__isset.keysOnly = this.__isset.keysOnly;
      if((FullMap != null) && __isset.fullMap)
      {
        tmp58.FullMap = this.FullMap.DeepCopy();
      }
      tmp58.__isset.fullMap = this.__isset.fullMap;
      return tmp58;
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
              if (field.Type == TType.Set)
              {
                {
                  TSet _set59 = await iprot.ReadSetBeginAsync(cancellationToken);
                  KeysOnly = new THashSet<string>(_set59.Count);
                  for(int _i60 = 0; _i60 < _set59.Count; ++_i60)
                  {
                    string _elem61;
                    _elem61 = await iprot.ReadStringAsync(cancellationToken);
                    KeysOnly.Add(_elem61);
                  }
                  await iprot.ReadSetEndAsync(cancellationToken);
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
                  TMap _map62 = await iprot.ReadMapBeginAsync(cancellationToken);
                  FullMap = new Dictionary<string, string>(_map62.Count);
                  for(int _i63 = 0; _i63 < _map62.Count; ++_i63)
                  {
                    string _key64;
                    string _val65;
                    _key64 = await iprot.ReadStringAsync(cancellationToken);
                    _val65 = await iprot.ReadStringAsync(cancellationToken);
                    FullMap[_key64] = _val65;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
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
        var tmp66 = new TStruct("LazyMap");
        await oprot.WriteStructBeginAsync(tmp66, cancellationToken);
        var tmp67 = new TField();
        if((KeysOnly != null) && __isset.keysOnly)
        {
          tmp67.Name = "keysOnly";
          tmp67.Type = TType.Set;
          tmp67.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp67, cancellationToken);
          {
            await oprot.WriteSetBeginAsync(new TSet(TType.String, KeysOnly.Count), cancellationToken);
            foreach (string _iter68 in KeysOnly)
            {
              await oprot.WriteStringAsync(_iter68, cancellationToken);
            }
            await oprot.WriteSetEndAsync(cancellationToken);
          }
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((FullMap != null) && __isset.fullMap)
        {
          tmp67.Name = "fullMap";
          tmp67.Type = TType.Map;
          tmp67.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp67, cancellationToken);
          {
            await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.String, FullMap.Count), cancellationToken);
            foreach (string _iter69 in FullMap.Keys)
            {
              await oprot.WriteStringAsync(_iter69, cancellationToken);
              await oprot.WriteStringAsync(FullMap[_iter69], cancellationToken);
            }
            await oprot.WriteMapEndAsync(cancellationToken);
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
      if (!(that is LazyMap other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.keysOnly == other.__isset.keysOnly) && ((!__isset.keysOnly) || (TCollections.Equals(KeysOnly, other.KeysOnly))))
        && ((__isset.fullMap == other.__isset.fullMap) && ((!__isset.fullMap) || (TCollections.Equals(FullMap, other.FullMap))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((KeysOnly != null) && __isset.keysOnly)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(KeysOnly);
        }
        if((FullMap != null) && __isset.fullMap)
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(FullMap);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp70 = new StringBuilder("LazyMap(");
      int tmp71 = 0;
      if((KeysOnly != null) && __isset.keysOnly)
      {
        if(0 < tmp71++) { tmp70.Append(", "); }
        tmp70.Append("KeysOnly: ");
        KeysOnly.ToString(tmp70);
      }
      if((FullMap != null) && __isset.fullMap)
      {
        if(0 < tmp71++) { tmp70.Append(", "); }
        tmp70.Append("FullMap: ");
        FullMap.ToString(tmp70);
      }
      tmp70.Append(')');
      return tmp70.ToString();
    }
  }

}
