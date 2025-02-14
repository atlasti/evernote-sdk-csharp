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
  /// Settings meant for the recipient of a notebook share.
  /// 
  /// Some of these fields have a 3-state read value but a 2-state write value.
  /// On read, it is possible to observe "unset", true, or false. The initial
  /// state is "unset". When you choose to set a value, you may set it to either
  /// true or false, but you cannot unset the value. Once one of these members
  /// has a true/false value, it will always have a true/false value.
  /// 
  /// <dl>
  /// <dt>reminderNotifyEmail</dt>
  /// <dd>Indicates that the user wishes to receive daily e-mail notifications
  ///     for reminders associated with the notebook. This may be
  ///     true only for business notebooks that belong to the business of
  ///     which the user is a member. You may only set this value on a
  ///     notebook in your business. This value will initially be unset.</dd>
  /// <dt>reminderNotifyInApp</dt>
  /// <dd>Indicates that the user wishes to receive notifications for
  ///     reminders by applications that support providing such
  ///     notifications.  The exact nature of the notification is defined
  ///     by the individual applications. This value will initially be unset.</dd>
  /// </dl>
  /// <dt>inMyList</dt>
  /// <dd>DEPRECATED: Use recipientStatus instead.
  ///     The notebook is on the recipient's notebook list (formerly, we would say
  ///     that the recipient has "joined" the notebook)</dd>
  /// <dt>recipientStatus</dt>
  /// <dd>The notebook is on/off the recipient's notebook list (formerly, we would say
  ///     that the recipient has "joined" the notebook) and perhaps also their
  ///     default notebook</dd>
  /// <dt>stack</dt>
  /// <dd>The stack the recipient has put this notebook into. See Notebook.stack
  /// for a definition. Every recipient can have their own stack value for the same
  /// notebook.</dd>
  /// </dl>
  /// 
  /// </summary>
  public partial class NotebookRecipientSettings : TBase
  {
    private bool _reminderNotifyEmail;
    private bool _reminderNotifyInApp;
    private bool _inMyList;
    private string _stack;
    private global::Evernote.EDAM.Type.RecipientStatus _recipientStatus;

    public bool ReminderNotifyEmail
    {
      get
      {
        return _reminderNotifyEmail;
      }
      set
      {
        __isset.reminderNotifyEmail = true;
        this._reminderNotifyEmail = value;
      }
    }

    public bool ReminderNotifyInApp
    {
      get
      {
        return _reminderNotifyInApp;
      }
      set
      {
        __isset.reminderNotifyInApp = true;
        this._reminderNotifyInApp = value;
      }
    }

    public bool InMyList
    {
      get
      {
        return _inMyList;
      }
      set
      {
        __isset.inMyList = true;
        this._inMyList = value;
      }
    }

    public string Stack
    {
      get
      {
        return _stack;
      }
      set
      {
        __isset.stack = true;
        this._stack = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="global::Evernote.EDAM.Type.RecipientStatus"/>
    /// </summary>
    public global::Evernote.EDAM.Type.RecipientStatus RecipientStatus
    {
      get
      {
        return _recipientStatus;
      }
      set
      {
        __isset.recipientStatus = true;
        this._recipientStatus = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool reminderNotifyEmail;
      public bool reminderNotifyInApp;
      public bool inMyList;
      public bool stack;
      public bool recipientStatus;
    }

    public NotebookRecipientSettings()
    {
    }

    public NotebookRecipientSettings DeepCopy()
    {
      var tmp153 = new NotebookRecipientSettings();
      if(__isset.reminderNotifyEmail)
      {
        tmp153.ReminderNotifyEmail = this.ReminderNotifyEmail;
      }
      tmp153.__isset.reminderNotifyEmail = this.__isset.reminderNotifyEmail;
      if(__isset.reminderNotifyInApp)
      {
        tmp153.ReminderNotifyInApp = this.ReminderNotifyInApp;
      }
      tmp153.__isset.reminderNotifyInApp = this.__isset.reminderNotifyInApp;
      if(__isset.inMyList)
      {
        tmp153.InMyList = this.InMyList;
      }
      tmp153.__isset.inMyList = this.__isset.inMyList;
      if((Stack != null) && __isset.stack)
      {
        tmp153.Stack = this.Stack;
      }
      tmp153.__isset.stack = this.__isset.stack;
      if(__isset.recipientStatus)
      {
        tmp153.RecipientStatus = this.RecipientStatus;
      }
      tmp153.__isset.recipientStatus = this.__isset.recipientStatus;
      return tmp153;
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
                ReminderNotifyEmail = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Bool)
              {
                ReminderNotifyInApp = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                InMyList = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.String)
              {
                Stack = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.I32)
              {
                RecipientStatus = (global::Evernote.EDAM.Type.RecipientStatus)await iprot.ReadI32Async(cancellationToken);
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
        var tmp154 = new TStruct("NotebookRecipientSettings");
        await oprot.WriteStructBeginAsync(tmp154, cancellationToken);
        var tmp155 = new TField();
        if(__isset.reminderNotifyEmail)
        {
          tmp155.Name = "reminderNotifyEmail";
          tmp155.Type = TType.Bool;
          tmp155.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp155, cancellationToken);
          await oprot.WriteBoolAsync(ReminderNotifyEmail, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.reminderNotifyInApp)
        {
          tmp155.Name = "reminderNotifyInApp";
          tmp155.Type = TType.Bool;
          tmp155.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp155, cancellationToken);
          await oprot.WriteBoolAsync(ReminderNotifyInApp, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.inMyList)
        {
          tmp155.Name = "inMyList";
          tmp155.Type = TType.Bool;
          tmp155.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp155, cancellationToken);
          await oprot.WriteBoolAsync(InMyList, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Stack != null) && __isset.stack)
        {
          tmp155.Name = "stack";
          tmp155.Type = TType.String;
          tmp155.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp155, cancellationToken);
          await oprot.WriteStringAsync(Stack, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.recipientStatus)
        {
          tmp155.Name = "recipientStatus";
          tmp155.Type = TType.I32;
          tmp155.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp155, cancellationToken);
          await oprot.WriteI32Async((int)RecipientStatus, cancellationToken);
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
      if (!(that is NotebookRecipientSettings other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.reminderNotifyEmail == other.__isset.reminderNotifyEmail) && ((!__isset.reminderNotifyEmail) || (global::System.Object.Equals(ReminderNotifyEmail, other.ReminderNotifyEmail))))
        && ((__isset.reminderNotifyInApp == other.__isset.reminderNotifyInApp) && ((!__isset.reminderNotifyInApp) || (global::System.Object.Equals(ReminderNotifyInApp, other.ReminderNotifyInApp))))
        && ((__isset.inMyList == other.__isset.inMyList) && ((!__isset.inMyList) || (global::System.Object.Equals(InMyList, other.InMyList))))
        && ((__isset.stack == other.__isset.stack) && ((!__isset.stack) || (global::System.Object.Equals(Stack, other.Stack))))
        && ((__isset.recipientStatus == other.__isset.recipientStatus) && ((!__isset.recipientStatus) || (global::System.Object.Equals(RecipientStatus, other.RecipientStatus))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.reminderNotifyEmail)
        {
          hashcode = (hashcode * 397) + ReminderNotifyEmail.GetHashCode();
        }
        if(__isset.reminderNotifyInApp)
        {
          hashcode = (hashcode * 397) + ReminderNotifyInApp.GetHashCode();
        }
        if(__isset.inMyList)
        {
          hashcode = (hashcode * 397) + InMyList.GetHashCode();
        }
        if((Stack != null) && __isset.stack)
        {
          hashcode = (hashcode * 397) + Stack.GetHashCode();
        }
        if(__isset.recipientStatus)
        {
          hashcode = (hashcode * 397) + RecipientStatus.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp156 = new StringBuilder("NotebookRecipientSettings(");
      int tmp157 = 0;
      if(__isset.reminderNotifyEmail)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("ReminderNotifyEmail: ");
        ReminderNotifyEmail.ToString(tmp156);
      }
      if(__isset.reminderNotifyInApp)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("ReminderNotifyInApp: ");
        ReminderNotifyInApp.ToString(tmp156);
      }
      if(__isset.inMyList)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("InMyList: ");
        InMyList.ToString(tmp156);
      }
      if((Stack != null) && __isset.stack)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("Stack: ");
        Stack.ToString(tmp156);
      }
      if(__isset.recipientStatus)
      {
        if(0 < tmp157++) { tmp156.Append(", "); }
        tmp156.Append("RecipientStatus: ");
        RecipientStatus.ToString(tmp156);
      }
      tmp156.Append(')');
      return tmp156.ToString();
    }
  }

}
