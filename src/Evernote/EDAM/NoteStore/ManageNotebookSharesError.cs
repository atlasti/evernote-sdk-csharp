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
  /// A structure to capture certain errors that occurred during a call
  /// to manageNotebookShares.  That method can be run best-effort,
  /// meaning that some change requests can be applied while others fail.
  /// Note that some errors such as system errors will still fail the
  /// entire transaction regardless of running best effort.  When some
  /// change requests do not succeed, the error conditions are captured
  /// in instances of this class, captured by the identity of the share
  /// relationship and one of the exception fields.
  /// 
  /// <dl>
  /// <dt>userIdentity</dt>
  /// <dd>The identity of the share relationship whose update encountered
  /// an error.</dd>
  /// 
  /// <dt>userException</dt>
  /// <dd>If the error is represented as an EDAMUserException that would
  /// have otherwise been thrown without best-effort execution.  Only one
  /// exception field will be set.</dd>
  /// 
  /// <dt>notFoundException</dt>
  /// <dd>If the error is represented as an EDAMNotFoundException that would
  /// have otherwise been thrown without best-effort execution.  Only one
  /// exception field will be set.</dd>
  /// </dl>
  /// </summary>
  public partial class ManageNotebookSharesError : TBase
  {
    private global::Evernote.EDAM.Type.UserIdentity _userIdentity;
    private global::Evernote.EDAM.Error.EDAMUserException _userException;
    private global::Evernote.EDAM.Error.EDAMNotFoundException _notFoundException;

    public global::Evernote.EDAM.Type.UserIdentity UserIdentity
    {
      get
      {
        return _userIdentity;
      }
      set
      {
        __isset.userIdentity = true;
        this._userIdentity = value;
      }
    }

    public global::Evernote.EDAM.Error.EDAMUserException UserException
    {
      get
      {
        return _userException;
      }
      set
      {
        __isset.userException = true;
        this._userException = value;
      }
    }

    public global::Evernote.EDAM.Error.EDAMNotFoundException NotFoundException
    {
      get
      {
        return _notFoundException;
      }
      set
      {
        __isset.notFoundException = true;
        this._notFoundException = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool userIdentity;
      public bool userException;
      public bool notFoundException;
    }

    public ManageNotebookSharesError()
    {
    }

    public ManageNotebookSharesError DeepCopy()
    {
      var tmp251 = new ManageNotebookSharesError();
      if((UserIdentity != null) && __isset.userIdentity)
      {
        tmp251.UserIdentity = (global::Evernote.EDAM.Type.UserIdentity)this.UserIdentity.DeepCopy();
      }
      tmp251.__isset.userIdentity = this.__isset.userIdentity;
      if((UserException != null) && __isset.userException)
      {
        tmp251.UserException = (global::Evernote.EDAM.Error.EDAMUserException)this.UserException.DeepCopy();
      }
      tmp251.__isset.userException = this.__isset.userException;
      if((NotFoundException != null) && __isset.notFoundException)
      {
        tmp251.NotFoundException = (global::Evernote.EDAM.Error.EDAMNotFoundException)this.NotFoundException.DeepCopy();
      }
      tmp251.__isset.notFoundException = this.__isset.notFoundException;
      return tmp251;
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
              if (field.Type == TType.Struct)
              {
                UserIdentity = new global::Evernote.EDAM.Type.UserIdentity();
                await UserIdentity.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Struct)
              {
                UserException = new global::Evernote.EDAM.Error.EDAMUserException();
                await UserException.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Struct)
              {
                NotFoundException = new global::Evernote.EDAM.Error.EDAMNotFoundException();
                await NotFoundException.ReadAsync(iprot, cancellationToken);
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
        var tmp252 = new TStruct("ManageNotebookSharesError");
        await oprot.WriteStructBeginAsync(tmp252, cancellationToken);
        var tmp253 = new TField();
        if((UserIdentity != null) && __isset.userIdentity)
        {
          tmp253.Name = "userIdentity";
          tmp253.Type = TType.Struct;
          tmp253.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp253, cancellationToken);
          await UserIdentity.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((UserException != null) && __isset.userException)
        {
          tmp253.Name = "userException";
          tmp253.Type = TType.Struct;
          tmp253.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp253, cancellationToken);
          await UserException.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((NotFoundException != null) && __isset.notFoundException)
        {
          tmp253.Name = "notFoundException";
          tmp253.Type = TType.Struct;
          tmp253.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp253, cancellationToken);
          await NotFoundException.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ManageNotebookSharesError other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.userIdentity == other.__isset.userIdentity) && ((!__isset.userIdentity) || (global::System.Object.Equals(UserIdentity, other.UserIdentity))))
        && ((__isset.userException == other.__isset.userException) && ((!__isset.userException) || (global::System.Object.Equals(UserException, other.UserException))))
        && ((__isset.notFoundException == other.__isset.notFoundException) && ((!__isset.notFoundException) || (global::System.Object.Equals(NotFoundException, other.NotFoundException))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((UserIdentity != null) && __isset.userIdentity)
        {
          hashcode = (hashcode * 397) + UserIdentity.GetHashCode();
        }
        if((UserException != null) && __isset.userException)
        {
          hashcode = (hashcode * 397) + UserException.GetHashCode();
        }
        if((NotFoundException != null) && __isset.notFoundException)
        {
          hashcode = (hashcode * 397) + NotFoundException.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp254 = new StringBuilder("ManageNotebookSharesError(");
      int tmp255 = 0;
      if((UserIdentity != null) && __isset.userIdentity)
      {
        if(0 < tmp255++) { tmp254.Append(", "); }
        tmp254.Append("UserIdentity: ");
        UserIdentity.ToString(tmp254);
      }
      if((UserException != null) && __isset.userException)
      {
        if(0 < tmp255++) { tmp254.Append(", "); }
        tmp254.Append("UserException: ");
        UserException.ToString(tmp254);
      }
      if((NotFoundException != null) && __isset.notFoundException)
      {
        if(0 < tmp255++) { tmp254.Append(", "); }
        tmp254.Append("NotFoundException: ");
        NotFoundException.ToString(tmp254);
      }
      tmp254.Append(')');
      return tmp254.ToString();
    }
  }

}
