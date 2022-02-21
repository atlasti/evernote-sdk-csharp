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

namespace Evernote.EDAM.Error
{

  /// <summary>
  /// This exception is thrown by EDAM procedures when a call fails as a result of
  /// a problem that a caller may be able to resolve.  For example, if the user
  /// attempts to add a note to their account which would exceed their storage
  /// quota, this type of exception may be thrown to indicate the source of the
  /// error so that they can choose an alternate action.
  /// 
  /// This exception would not be used for internal system errors that do not
  /// reflect user actions, but rather reflect a problem within the service that
  /// the user cannot resolve.
  /// 
  /// errorCode:  The numeric code indicating the type of error that occurred.
  ///   must be one of the values of EDAMErrorCode.
  /// 
  /// parameter:  If the error applied to a particular input parameter, this will
  ///   indicate which parameter. For some errors (USER_NOT_ASSOCIATED, USER_NOT_REGISTERED,
  ///   SSO_AUTHENTICATION_REQUIRED), this is the user's email.
  /// </summary>
  public partial class EDAMUserException : TException, TBase
  {
    private string _parameter;

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Error.EDAMErrorCode"/>
    /// </summary>
    public global::Evernote.EDAM.Error.EDAMErrorCode ErrorCode { get; set; }

    public string Parameter
    {
      get
      {
        return _parameter;
      }
      set
      {
        __isset.parameter = true;
        this._parameter = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool parameter;
    }

    public EDAMUserException()
    {
    }

    public EDAMUserException(global::Evernote.EDAM.Error.EDAMErrorCode errorCode) : this()
    {
      this.ErrorCode = errorCode;
    }

    public EDAMUserException DeepCopy()
    {
      var tmp0 = new EDAMUserException();
      tmp0.ErrorCode = this.ErrorCode;
      if((Parameter != null) && __isset.parameter)
      {
        tmp0.Parameter = this.Parameter;
      }
      tmp0.__isset.parameter = this.__isset.parameter;
      return tmp0;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_errorCode = false;
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
                ErrorCode = (global::Evernote.EDAM.Error.EDAMErrorCode)await iprot.ReadI32Async(cancellationToken);
                isset_errorCode = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.String)
              {
                Parameter = await iprot.ReadStringAsync(cancellationToken);
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
        if (!isset_errorCode)
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
        var tmp1 = new TStruct("EDAMUserException");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        tmp2.Name = "errorCode";
        tmp2.Type = TType.I32;
        tmp2.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
        await oprot.WriteI32Async((int)ErrorCode, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Parameter != null) && __isset.parameter)
        {
          tmp2.Name = "parameter";
          tmp2.Type = TType.String;
          tmp2.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(Parameter, cancellationToken);
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
      if (!(that is EDAMUserException other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(ErrorCode, other.ErrorCode)
        && ((__isset.parameter == other.__isset.parameter) && ((!__isset.parameter) || (global::System.Object.Equals(Parameter, other.Parameter))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + ErrorCode.GetHashCode();
        if((Parameter != null) && __isset.parameter)
        {
          hashcode = (hashcode * 397) + Parameter.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("EDAMUserException(");
      tmp3.Append(", ErrorCode: ");
      ErrorCode.ToString(tmp3);
      if((Parameter != null) && __isset.parameter)
      {
        tmp3.Append(", Parameter: ");
        Parameter.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}
