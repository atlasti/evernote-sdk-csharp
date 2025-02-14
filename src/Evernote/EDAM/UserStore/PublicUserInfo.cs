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

namespace Evernote.EDAM.UserStore
{

  /// <summary>
  ///  This structure is used to provide publicly-available user information
  ///  about a particular account.
  /// <dl>
  ///  <dt>userId:</dt>
  ///    <dd>
  ///    The unique numeric user identifier for the user account.
  ///    </dd>
  ///  <dt>serviceLevel:</dt>
  ///    <dd>
  ///    The service level of the account.
  ///    </dd>
  ///  <dt>noteStoreUrl:</dt>
  ///    <dd>
  ///    This field will contain the full URL that clients should use to make
  ///    NoteStore requests to the server shard that contains that user's data.
  ///    I.e. this is the URL that should be used to create the Thrift HTTP client
  ///    transport to send messages to the NoteStore service for the account.
  ///    </dd>
  ///  <dt>webApiUrlPrefix:</dt>
  ///    <dd>
  ///    This field will contain the initial part of the URLs that should be used
  ///    to make requests to Evernote's thin client "web API", which provide
  ///    optimized operations for clients that aren't capable of manipulating
  ///    the full contents of accounts via the full Thrift data model. Clients
  ///    should concatenate the relative path for the various servlets onto the
  ///    end of this string to construct the full URL, as documented on our
  ///    developer web site.
  ///    </dd>
  ///  </dl>
  /// </summary>
  public partial class PublicUserInfo : TBase
  {
    private global::Evernote.EDAM.Type.ServiceLevel _serviceLevel;
    private string _username;
    private string _noteStoreUrl;
    private string _webApiUrlPrefix;

    public int UserId { get; set; }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.ServiceLevel"/>
    /// </summary>
    public global::Evernote.EDAM.Type.ServiceLevel ServiceLevel
    {
      get
      {
        return _serviceLevel;
      }
      set
      {
        __isset.serviceLevel = true;
        this._serviceLevel = value;
      }
    }

    public string Username
    {
      get
      {
        return _username;
      }
      set
      {
        __isset.username = true;
        this._username = value;
      }
    }

    public string NoteStoreUrl
    {
      get
      {
        return _noteStoreUrl;
      }
      set
      {
        __isset.noteStoreUrl = true;
        this._noteStoreUrl = value;
      }
    }

    public string WebApiUrlPrefix
    {
      get
      {
        return _webApiUrlPrefix;
      }
      set
      {
        __isset.webApiUrlPrefix = true;
        this._webApiUrlPrefix = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool serviceLevel;
      public bool username;
      public bool noteStoreUrl;
      public bool webApiUrlPrefix;
    }

    public PublicUserInfo()
    {
    }

    public PublicUserInfo(int userId) : this()
    {
      this.UserId = userId;
    }

    public PublicUserInfo DeepCopy()
    {
      var tmp0 = new PublicUserInfo();
      tmp0.UserId = this.UserId;
      if(__isset.serviceLevel)
      {
        tmp0.ServiceLevel = this.ServiceLevel;
      }
      tmp0.__isset.serviceLevel = this.__isset.serviceLevel;
      if((Username != null) && __isset.username)
      {
        tmp0.Username = this.Username;
      }
      tmp0.__isset.username = this.__isset.username;
      if((NoteStoreUrl != null) && __isset.noteStoreUrl)
      {
        tmp0.NoteStoreUrl = this.NoteStoreUrl;
      }
      tmp0.__isset.noteStoreUrl = this.__isset.noteStoreUrl;
      if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
      {
        tmp0.WebApiUrlPrefix = this.WebApiUrlPrefix;
      }
      tmp0.__isset.webApiUrlPrefix = this.__isset.webApiUrlPrefix;
      return tmp0;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_userId = false;
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
                UserId = await iprot.ReadI32Async(cancellationToken);
                isset_userId = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.I32)
              {
                ServiceLevel = (global::Evernote.EDAM.Type.ServiceLevel)await iprot.ReadI32Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Username = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.String)
              {
                NoteStoreUrl = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                WebApiUrlPrefix = await iprot.ReadStringAsync(cancellationToken);
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
        if (!isset_userId)
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
        var tmp1 = new TStruct("PublicUserInfo");
        await oprot.WriteStructBeginAsync(tmp1, cancellationToken);
        var tmp2 = new TField();
        tmp2.Name = "userId";
        tmp2.Type = TType.I32;
        tmp2.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
        await oprot.WriteI32Async(UserId, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((Username != null) && __isset.username)
        {
          tmp2.Name = "username";
          tmp2.Type = TType.String;
          tmp2.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(Username, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((NoteStoreUrl != null) && __isset.noteStoreUrl)
        {
          tmp2.Name = "noteStoreUrl";
          tmp2.Type = TType.String;
          tmp2.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(NoteStoreUrl, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
        {
          tmp2.Name = "webApiUrlPrefix";
          tmp2.Type = TType.String;
          tmp2.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteStringAsync(WebApiUrlPrefix, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.serviceLevel)
        {
          tmp2.Name = "serviceLevel";
          tmp2.Type = TType.I32;
          tmp2.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp2, cancellationToken);
          await oprot.WriteI32Async((int)ServiceLevel, cancellationToken);
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
      if (!(that is PublicUserInfo other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(UserId, other.UserId)
        && ((__isset.serviceLevel == other.__isset.serviceLevel) && ((!__isset.serviceLevel) || (global::System.Object.Equals(ServiceLevel, other.ServiceLevel))))
        && ((__isset.username == other.__isset.username) && ((!__isset.username) || (global::System.Object.Equals(Username, other.Username))))
        && ((__isset.noteStoreUrl == other.__isset.noteStoreUrl) && ((!__isset.noteStoreUrl) || (global::System.Object.Equals(NoteStoreUrl, other.NoteStoreUrl))))
        && ((__isset.webApiUrlPrefix == other.__isset.webApiUrlPrefix) && ((!__isset.webApiUrlPrefix) || (global::System.Object.Equals(WebApiUrlPrefix, other.WebApiUrlPrefix))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + UserId.GetHashCode();
        if(__isset.serviceLevel)
        {
          hashcode = (hashcode * 397) + ServiceLevel.GetHashCode();
        }
        if((Username != null) && __isset.username)
        {
          hashcode = (hashcode * 397) + Username.GetHashCode();
        }
        if((NoteStoreUrl != null) && __isset.noteStoreUrl)
        {
          hashcode = (hashcode * 397) + NoteStoreUrl.GetHashCode();
        }
        if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
        {
          hashcode = (hashcode * 397) + WebApiUrlPrefix.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp3 = new StringBuilder("PublicUserInfo(");
      tmp3.Append(", UserId: ");
      UserId.ToString(tmp3);
      if(__isset.serviceLevel)
      {
        tmp3.Append(", ServiceLevel: ");
        ServiceLevel.ToString(tmp3);
      }
      if((Username != null) && __isset.username)
      {
        tmp3.Append(", Username: ");
        Username.ToString(tmp3);
      }
      if((NoteStoreUrl != null) && __isset.noteStoreUrl)
      {
        tmp3.Append(", NoteStoreUrl: ");
        NoteStoreUrl.ToString(tmp3);
      }
      if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
      {
        tmp3.Append(", WebApiUrlPrefix: ");
        WebApiUrlPrefix.ToString(tmp3);
      }
      tmp3.Append(')');
      return tmp3.ToString();
    }
  }

}
