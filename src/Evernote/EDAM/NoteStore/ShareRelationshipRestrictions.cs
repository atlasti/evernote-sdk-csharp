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

  public partial class ShareRelationshipRestrictions : TBase
  {
    private bool _noSetReadOnly;
    private bool _noSetReadPlusActivity;
    private bool _noSetModify;
    private bool _noSetFullAccess;

    public bool NoSetReadOnly
    {
      get
      {
        return _noSetReadOnly;
      }
      set
      {
        __isset.noSetReadOnly = true;
        this._noSetReadOnly = value;
      }
    }

    public bool NoSetReadPlusActivity
    {
      get
      {
        return _noSetReadPlusActivity;
      }
      set
      {
        __isset.noSetReadPlusActivity = true;
        this._noSetReadPlusActivity = value;
      }
    }

    public bool NoSetModify
    {
      get
      {
        return _noSetModify;
      }
      set
      {
        __isset.noSetModify = true;
        this._noSetModify = value;
      }
    }

    public bool NoSetFullAccess
    {
      get
      {
        return _noSetFullAccess;
      }
      set
      {
        __isset.noSetFullAccess = true;
        this._noSetFullAccess = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool noSetReadOnly;
      public bool noSetReadPlusActivity;
      public bool noSetModify;
      public bool noSetFullAccess;
    }

    public ShareRelationshipRestrictions()
    {
    }

    public ShareRelationshipRestrictions DeepCopy()
    {
      var tmp206 = new ShareRelationshipRestrictions();
      if(__isset.noSetReadOnly)
      {
        tmp206.NoSetReadOnly = this.NoSetReadOnly;
      }
      tmp206.__isset.noSetReadOnly = this.__isset.noSetReadOnly;
      if(__isset.noSetReadPlusActivity)
      {
        tmp206.NoSetReadPlusActivity = this.NoSetReadPlusActivity;
      }
      tmp206.__isset.noSetReadPlusActivity = this.__isset.noSetReadPlusActivity;
      if(__isset.noSetModify)
      {
        tmp206.NoSetModify = this.NoSetModify;
      }
      tmp206.__isset.noSetModify = this.__isset.noSetModify;
      if(__isset.noSetFullAccess)
      {
        tmp206.NoSetFullAccess = this.NoSetFullAccess;
      }
      tmp206.__isset.noSetFullAccess = this.__isset.noSetFullAccess;
      return tmp206;
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
              if (field.Type == TType.Bool)
              {
                NoSetReadOnly = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Bool)
              {
                NoSetReadPlusActivity = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                NoSetModify = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                NoSetFullAccess = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp207 = new TStruct("ShareRelationshipRestrictions");
        await oprot.WriteStructBeginAsync(tmp207, cancellationToken);
        var tmp208 = new TField();
        if(__isset.noSetReadOnly)
        {
          tmp208.Name = "noSetReadOnly";
          tmp208.Type = TType.Bool;
          tmp208.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp208, cancellationToken);
          await oprot.WriteBoolAsync(NoSetReadOnly, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noSetReadPlusActivity)
        {
          tmp208.Name = "noSetReadPlusActivity";
          tmp208.Type = TType.Bool;
          tmp208.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp208, cancellationToken);
          await oprot.WriteBoolAsync(NoSetReadPlusActivity, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noSetModify)
        {
          tmp208.Name = "noSetModify";
          tmp208.Type = TType.Bool;
          tmp208.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp208, cancellationToken);
          await oprot.WriteBoolAsync(NoSetModify, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noSetFullAccess)
        {
          tmp208.Name = "noSetFullAccess";
          tmp208.Type = TType.Bool;
          tmp208.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp208, cancellationToken);
          await oprot.WriteBoolAsync(NoSetFullAccess, cancellationToken);
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
      if (!(that is ShareRelationshipRestrictions other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.noSetReadOnly == other.__isset.noSetReadOnly) && ((!__isset.noSetReadOnly) || (global::System.Object.Equals(NoSetReadOnly, other.NoSetReadOnly))))
        && ((__isset.noSetReadPlusActivity == other.__isset.noSetReadPlusActivity) && ((!__isset.noSetReadPlusActivity) || (global::System.Object.Equals(NoSetReadPlusActivity, other.NoSetReadPlusActivity))))
        && ((__isset.noSetModify == other.__isset.noSetModify) && ((!__isset.noSetModify) || (global::System.Object.Equals(NoSetModify, other.NoSetModify))))
        && ((__isset.noSetFullAccess == other.__isset.noSetFullAccess) && ((!__isset.noSetFullAccess) || (global::System.Object.Equals(NoSetFullAccess, other.NoSetFullAccess))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.noSetReadOnly)
        {
          hashcode = (hashcode * 397) + NoSetReadOnly.GetHashCode();
        }
        if(__isset.noSetReadPlusActivity)
        {
          hashcode = (hashcode * 397) + NoSetReadPlusActivity.GetHashCode();
        }
        if(__isset.noSetModify)
        {
          hashcode = (hashcode * 397) + NoSetModify.GetHashCode();
        }
        if(__isset.noSetFullAccess)
        {
          hashcode = (hashcode * 397) + NoSetFullAccess.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp209 = new StringBuilder("ShareRelationshipRestrictions(");
      int tmp210 = 0;
      if(__isset.noSetReadOnly)
      {
        if(0 < tmp210++) { tmp209.Append(", "); }
        tmp209.Append("NoSetReadOnly: ");
        NoSetReadOnly.ToString(tmp209);
      }
      if(__isset.noSetReadPlusActivity)
      {
        if(0 < tmp210++) { tmp209.Append(", "); }
        tmp209.Append("NoSetReadPlusActivity: ");
        NoSetReadPlusActivity.ToString(tmp209);
      }
      if(__isset.noSetModify)
      {
        if(0 < tmp210++) { tmp209.Append(", "); }
        tmp209.Append("NoSetModify: ");
        NoSetModify.ToString(tmp209);
      }
      if(__isset.noSetFullAccess)
      {
        if(0 < tmp210++) { tmp209.Append(", "); }
        tmp209.Append("NoSetFullAccess: ");
        NoSetFullAccess.ToString(tmp209);
      }
      tmp209.Append(')');
      return tmp209.ToString();
    }
  }

}
