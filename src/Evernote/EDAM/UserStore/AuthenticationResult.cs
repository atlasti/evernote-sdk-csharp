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
  ///  When an authentication (or re-authentication) is performed, this structure
  ///  provides the result to the client.
  /// <dl>
  ///  <dt>currentTime:</dt>
  ///    <dd>
  ///    The server-side date and time when this result was
  ///    generated.
  ///    </dd>
  ///  <dt>authenticationToken:</dt>
  ///    <dd>
  ///    Holds an opaque, ASCII-encoded token that can be
  ///    used by the client to perform actions on a NoteStore.
  ///    </dd>
  ///  <dt>expiration:</dt>
  ///    <dd>
  ///    Holds the server-side date and time when the
  ///    authentication token will expire.
  ///    This time can be compared to "currentTime" to produce an expiration
  ///    time that can be reconciled with the client's local clock.
  ///    </dd>
  ///  <dt>user:</dt>
  ///    <dd>
  ///    Holds the information about the account which was
  ///    authenticated if this was a full authentication.  May be absent if this
  ///    particular authentication did not require user information.
  ///    </dd>
  ///  <dt>publicUserInfo:</dt>
  ///    <dd>
  ///    If this authentication result was achieved without full permissions to
  ///    access the full User structure, this field may be set to give back
  ///    a more limited public set of data.
  ///    </dd>
  ///  <dt>noteStoreUrl:</dt>
  ///    <dd>
  ///    DEPRECATED - Client applications should use urls.noteStoreUrl.
  ///    </dd>
  ///  <dt>webApiUrlPrefix:</dt>
  ///    <dd>
  ///    DEPRECATED - Client applications should use urls.webApiUrlPrefix.
  ///    </dd>
  ///  <dt>secondFactorRequired:</dt>
  ///    <dd>
  ///    If set to true, this field indicates that the user has enabled two-factor
  ///    authentication and must enter their second factor in order to complete
  ///    authentication. In this case the value of authenticationResult will be
  ///    a short-lived authentication token that may only be used to make a
  ///    subsequent call to completeTwoFactorAuthentication.
  ///    </dd>
  ///  <dt>secondFactorDeliveryHint:</dt>
  ///    <dd>
  ///    When secondFactorRequired is set to true, this field may contain a string
  ///    describing the second factor delivery method that the user has configured.
  ///    This will typically be an obfuscated mobile device number, such as
  ///    "(xxx) xxx-x095". This string can be displayed to the user to remind them
  ///    how to obtain the required second factor.
  ///    </dd>
  ///  <dt>urls</dt>
  ///    <dd>
  ///    This structure will contain all of the URLs that clients need to make requests to the
  ///    Evernote service on behalf of the authenticated User.
  ///    </dd>
  ///  </dl>
  /// </summary>
  public partial class AuthenticationResult : TBase
  {
    private global::Evernote.EDAM.Type.User _user;
    private global::Evernote.EDAM.UserStore.PublicUserInfo _publicUserInfo;
    private string _noteStoreUrl;
    private string _webApiUrlPrefix;
    private bool _secondFactorRequired;
    private string _secondFactorDeliveryHint;
    private global::Evernote.EDAM.UserStore.UserUrls _urls;

    public long CurrentTime { get; set; }

    public string AuthenticationToken { get; set; }

    public long Expiration { get; set; }

    public global::Evernote.EDAM.Type.User User
    {
      get
      {
        return _user;
      }
      set
      {
        __isset.user = true;
        this._user = value;
      }
    }

    public global::Evernote.EDAM.UserStore.PublicUserInfo PublicUserInfo
    {
      get
      {
        return _publicUserInfo;
      }
      set
      {
        __isset.publicUserInfo = true;
        this._publicUserInfo = value;
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

    public bool SecondFactorRequired
    {
      get
      {
        return _secondFactorRequired;
      }
      set
      {
        __isset.secondFactorRequired = true;
        this._secondFactorRequired = value;
      }
    }

    public string SecondFactorDeliveryHint
    {
      get
      {
        return _secondFactorDeliveryHint;
      }
      set
      {
        __isset.secondFactorDeliveryHint = true;
        this._secondFactorDeliveryHint = value;
      }
    }

    public global::Evernote.EDAM.UserStore.UserUrls Urls
    {
      get
      {
        return _urls;
      }
      set
      {
        __isset.urls = true;
        this._urls = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool user;
      public bool publicUserInfo;
      public bool noteStoreUrl;
      public bool webApiUrlPrefix;
      public bool secondFactorRequired;
      public bool secondFactorDeliveryHint;
      public bool urls;
    }

    public AuthenticationResult()
    {
    }

    public AuthenticationResult(long currentTime, string authenticationToken, long expiration) : this()
    {
      this.CurrentTime = currentTime;
      this.AuthenticationToken = authenticationToken;
      this.Expiration = expiration;
    }

    public AuthenticationResult DeepCopy()
    {
      var tmp10 = new AuthenticationResult();
      tmp10.CurrentTime = this.CurrentTime;
      if((AuthenticationToken != null))
      {
        tmp10.AuthenticationToken = this.AuthenticationToken;
      }
      tmp10.Expiration = this.Expiration;
      if((User != null) && __isset.user)
      {
        tmp10.User = (global::Evernote.EDAM.Type.User)this.User.DeepCopy();
      }
      tmp10.__isset.user = this.__isset.user;
      if((PublicUserInfo != null) && __isset.publicUserInfo)
      {
        tmp10.PublicUserInfo = (global::Evernote.EDAM.UserStore.PublicUserInfo)this.PublicUserInfo.DeepCopy();
      }
      tmp10.__isset.publicUserInfo = this.__isset.publicUserInfo;
      if((NoteStoreUrl != null) && __isset.noteStoreUrl)
      {
        tmp10.NoteStoreUrl = this.NoteStoreUrl;
      }
      tmp10.__isset.noteStoreUrl = this.__isset.noteStoreUrl;
      if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
      {
        tmp10.WebApiUrlPrefix = this.WebApiUrlPrefix;
      }
      tmp10.__isset.webApiUrlPrefix = this.__isset.webApiUrlPrefix;
      if(__isset.secondFactorRequired)
      {
        tmp10.SecondFactorRequired = this.SecondFactorRequired;
      }
      tmp10.__isset.secondFactorRequired = this.__isset.secondFactorRequired;
      if((SecondFactorDeliveryHint != null) && __isset.secondFactorDeliveryHint)
      {
        tmp10.SecondFactorDeliveryHint = this.SecondFactorDeliveryHint;
      }
      tmp10.__isset.secondFactorDeliveryHint = this.__isset.secondFactorDeliveryHint;
      if((Urls != null) && __isset.urls)
      {
        tmp10.Urls = (global::Evernote.EDAM.UserStore.UserUrls)this.Urls.DeepCopy();
      }
      tmp10.__isset.urls = this.__isset.urls;
      return tmp10;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_currentTime = false;
        bool isset_authenticationToken = false;
        bool isset_expiration = false;
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
              if (field.Type == TType.String)
              {
                AuthenticationToken = await iprot.ReadStringAsync(cancellationToken);
                isset_authenticationToken = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.I64)
              {
                Expiration = await iprot.ReadI64Async(cancellationToken);
                isset_expiration = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Struct)
              {
                User = new global::Evernote.EDAM.Type.User();
                await User.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Struct)
              {
                PublicUserInfo = new global::Evernote.EDAM.UserStore.PublicUserInfo();
                await PublicUserInfo.ReadAsync(iprot, cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                NoteStoreUrl = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.String)
              {
                WebApiUrlPrefix = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Bool)
              {
                SecondFactorRequired = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.String)
              {
                SecondFactorDeliveryHint = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.Struct)
              {
                Urls = new global::Evernote.EDAM.UserStore.UserUrls();
                await Urls.ReadAsync(iprot, cancellationToken);
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
        if (!isset_authenticationToken)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_expiration)
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
        var tmp11 = new TStruct("AuthenticationResult");
        await oprot.WriteStructBeginAsync(tmp11, cancellationToken);
        var tmp12 = new TField();
        tmp12.Name = "currentTime";
        tmp12.Type = TType.I64;
        tmp12.ID = 1;
        await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
        await oprot.WriteI64Async(CurrentTime, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((AuthenticationToken != null))
        {
          tmp12.Name = "authenticationToken";
          tmp12.Type = TType.String;
          tmp12.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(AuthenticationToken, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        tmp12.Name = "expiration";
        tmp12.Type = TType.I64;
        tmp12.ID = 3;
        await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
        await oprot.WriteI64Async(Expiration, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
        if((User != null) && __isset.user)
        {
          tmp12.Name = "user";
          tmp12.Type = TType.Struct;
          tmp12.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await User.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((PublicUserInfo != null) && __isset.publicUserInfo)
        {
          tmp12.Name = "publicUserInfo";
          tmp12.Type = TType.Struct;
          tmp12.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await PublicUserInfo.WriteAsync(oprot, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((NoteStoreUrl != null) && __isset.noteStoreUrl)
        {
          tmp12.Name = "noteStoreUrl";
          tmp12.Type = TType.String;
          tmp12.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(NoteStoreUrl, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
        {
          tmp12.Name = "webApiUrlPrefix";
          tmp12.Type = TType.String;
          tmp12.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(WebApiUrlPrefix, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.secondFactorRequired)
        {
          tmp12.Name = "secondFactorRequired";
          tmp12.Type = TType.Bool;
          tmp12.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteBoolAsync(SecondFactorRequired, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((SecondFactorDeliveryHint != null) && __isset.secondFactorDeliveryHint)
        {
          tmp12.Name = "secondFactorDeliveryHint";
          tmp12.Type = TType.String;
          tmp12.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await oprot.WriteStringAsync(SecondFactorDeliveryHint, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Urls != null) && __isset.urls)
        {
          tmp12.Name = "urls";
          tmp12.Type = TType.Struct;
          tmp12.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp12, cancellationToken);
          await Urls.WriteAsync(oprot, cancellationToken);
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
      if (!(that is AuthenticationResult other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(CurrentTime, other.CurrentTime)
        && global::System.Object.Equals(AuthenticationToken, other.AuthenticationToken)
        && global::System.Object.Equals(Expiration, other.Expiration)
        && ((__isset.user == other.__isset.user) && ((!__isset.user) || (global::System.Object.Equals(User, other.User))))
        && ((__isset.publicUserInfo == other.__isset.publicUserInfo) && ((!__isset.publicUserInfo) || (global::System.Object.Equals(PublicUserInfo, other.PublicUserInfo))))
        && ((__isset.noteStoreUrl == other.__isset.noteStoreUrl) && ((!__isset.noteStoreUrl) || (global::System.Object.Equals(NoteStoreUrl, other.NoteStoreUrl))))
        && ((__isset.webApiUrlPrefix == other.__isset.webApiUrlPrefix) && ((!__isset.webApiUrlPrefix) || (global::System.Object.Equals(WebApiUrlPrefix, other.WebApiUrlPrefix))))
        && ((__isset.secondFactorRequired == other.__isset.secondFactorRequired) && ((!__isset.secondFactorRequired) || (global::System.Object.Equals(SecondFactorRequired, other.SecondFactorRequired))))
        && ((__isset.secondFactorDeliveryHint == other.__isset.secondFactorDeliveryHint) && ((!__isset.secondFactorDeliveryHint) || (global::System.Object.Equals(SecondFactorDeliveryHint, other.SecondFactorDeliveryHint))))
        && ((__isset.urls == other.__isset.urls) && ((!__isset.urls) || (global::System.Object.Equals(Urls, other.Urls))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        hashcode = (hashcode * 397) + CurrentTime.GetHashCode();
        if((AuthenticationToken != null))
        {
          hashcode = (hashcode * 397) + AuthenticationToken.GetHashCode();
        }
        hashcode = (hashcode * 397) + Expiration.GetHashCode();
        if((User != null) && __isset.user)
        {
          hashcode = (hashcode * 397) + User.GetHashCode();
        }
        if((PublicUserInfo != null) && __isset.publicUserInfo)
        {
          hashcode = (hashcode * 397) + PublicUserInfo.GetHashCode();
        }
        if((NoteStoreUrl != null) && __isset.noteStoreUrl)
        {
          hashcode = (hashcode * 397) + NoteStoreUrl.GetHashCode();
        }
        if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
        {
          hashcode = (hashcode * 397) + WebApiUrlPrefix.GetHashCode();
        }
        if(__isset.secondFactorRequired)
        {
          hashcode = (hashcode * 397) + SecondFactorRequired.GetHashCode();
        }
        if((SecondFactorDeliveryHint != null) && __isset.secondFactorDeliveryHint)
        {
          hashcode = (hashcode * 397) + SecondFactorDeliveryHint.GetHashCode();
        }
        if((Urls != null) && __isset.urls)
        {
          hashcode = (hashcode * 397) + Urls.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp13 = new StringBuilder("AuthenticationResult(");
      tmp13.Append(", CurrentTime: ");
      CurrentTime.ToString(tmp13);
      if((AuthenticationToken != null))
      {
        tmp13.Append(", AuthenticationToken: ");
        AuthenticationToken.ToString(tmp13);
      }
      tmp13.Append(", Expiration: ");
      Expiration.ToString(tmp13);
      if((User != null) && __isset.user)
      {
        tmp13.Append(", User: ");
        User.ToString(tmp13);
      }
      if((PublicUserInfo != null) && __isset.publicUserInfo)
      {
        tmp13.Append(", PublicUserInfo: ");
        PublicUserInfo.ToString(tmp13);
      }
      if((NoteStoreUrl != null) && __isset.noteStoreUrl)
      {
        tmp13.Append(", NoteStoreUrl: ");
        NoteStoreUrl.ToString(tmp13);
      }
      if((WebApiUrlPrefix != null) && __isset.webApiUrlPrefix)
      {
        tmp13.Append(", WebApiUrlPrefix: ");
        WebApiUrlPrefix.ToString(tmp13);
      }
      if(__isset.secondFactorRequired)
      {
        tmp13.Append(", SecondFactorRequired: ");
        SecondFactorRequired.ToString(tmp13);
      }
      if((SecondFactorDeliveryHint != null) && __isset.secondFactorDeliveryHint)
      {
        tmp13.Append(", SecondFactorDeliveryHint: ");
        SecondFactorDeliveryHint.ToString(tmp13);
      }
      if((Urls != null) && __isset.urls)
      {
        tmp13.Append(", Urls: ");
        Urls.ToString(tmp13);
      }
      tmp13.Append(')');
      return tmp13.ToString();
    }
  }

}
