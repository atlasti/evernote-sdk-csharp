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
  /// This structure captures information about the operations that cannot be performed on a given
  /// note that has been shared with a recipient via a SharedNote. The following operations are
  /// <b>never</b> allowed based on SharedNotes, and as such are left out of the NoteRestrictions
  /// structure for brevity:
  /// 
  /// <ul>
  ///   <li>Expunging a note (NoteStore.expungeNote)</li>
  ///   <li>Moving a note to the trash (Note.active)</li>
  ///   <li>Updating a note's notebook (Note.notebookGuid)</li>
  ///   <li>Updating a note's tags (Note.tagGuids, Note.tagNames)</li>
  ///   <li>Updating a note's attributes (Note.attributes)</li>
  ///   <li>Sharing a note with the business (NoteStore.shareNoteWithBusiness</li>
  ///   <li>Getting a note's version history (NoteStore.listNoteVersions,
  ///     NoteStore.getNoteVersion)</li>
  /// </ul>
  /// 
  /// When a client has permission to update a note's title or content, it may also update the
  /// Note.updated timestamp.
  /// 
  /// <b>This structure reflects only the privileges / restrictions conveyed by the SharedNote.</b>
  /// It does not incorporate privileges conveyed by a potential SharedNotebook to the same
  /// recipient. As such, the actual permissions that the recipient has on the note may differ from
  /// the permissions expressed in this structure.
  /// 
  /// For example, consider a user with read-only access to a shared notebook, and a read-write share
  /// of a specific note in the notebook. The note restrictions would contain noUpdateTitle = false,
  /// while the notebook restrictions would contain noUpdateNotes = true. In this case, the user is
  /// allowed to update the note title based on the note restrictions.
  /// 
  /// Alternatively, consider a user with read-write access to a shared notebook, and a read-only
  /// share of a specific note in that notebook. The note restrictions would contain
  /// noUpdateTitle = true, while the notebook restrictions would contain noUpdateNotes = false. In
  /// this case, the user would have full edit permissions on the note based on the notebook
  /// restrictions.
  /// 
  /// <dl>
  ///   <dt>noUpdateTitle</dt>
  ///   <dd>The client may not update the note's title (Note.title).</dd>
  /// 
  ///   <dt>noUpdateContent<dt>
  ///   <dd>The client may not update the note's content. Content includes Note.content
  ///     and Note.resources, as well as the related fields Note.contentHash and
  ///     Note.contentLength.</dd>
  /// 
  ///   <dt>noEmail</dt>
  ///   <dd>The client may not email the note (NoteStore.emailNote).</dd>
  /// 
  ///   <dt>noShare</dt>
  ///   <dd>The client may not share the note with specific recipients
  ///     (NoteStore.createOrUpdateSharedNotes).</dd>
  /// 
  ///   <dt>noSharePublicly</dt>
  ///   <dd>The client may not make the note public (NoteStore.shareNote).</dd>
  /// </dl>
  /// </summary>
  public partial class NoteRestrictions : TBase
  {
    private bool _noUpdateTitle;
    private bool _noUpdateContent;
    private bool _noEmail;
    private bool _noShare;
    private bool _noSharePublicly;

    public bool NoUpdateTitle
    {
      get
      {
        return _noUpdateTitle;
      }
      set
      {
        __isset.noUpdateTitle = true;
        this._noUpdateTitle = value;
      }
    }

    public bool NoUpdateContent
    {
      get
      {
        return _noUpdateContent;
      }
      set
      {
        __isset.noUpdateContent = true;
        this._noUpdateContent = value;
      }
    }

    public bool NoEmail
    {
      get
      {
        return _noEmail;
      }
      set
      {
        __isset.noEmail = true;
        this._noEmail = value;
      }
    }

    public bool NoShare
    {
      get
      {
        return _noShare;
      }
      set
      {
        __isset.noShare = true;
        this._noShare = value;
      }
    }

    public bool NoSharePublicly
    {
      get
      {
        return _noSharePublicly;
      }
      set
      {
        __isset.noSharePublicly = true;
        this._noSharePublicly = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool noUpdateTitle;
      public bool noUpdateContent;
      public bool noEmail;
      public bool noShare;
      public bool noSharePublicly;
    }

    public NoteRestrictions()
    {
    }

    public NoteRestrictions DeepCopy()
    {
      var tmp97 = new NoteRestrictions();
      if(__isset.noUpdateTitle)
      {
        tmp97.NoUpdateTitle = this.NoUpdateTitle;
      }
      tmp97.__isset.noUpdateTitle = this.__isset.noUpdateTitle;
      if(__isset.noUpdateContent)
      {
        tmp97.NoUpdateContent = this.NoUpdateContent;
      }
      tmp97.__isset.noUpdateContent = this.__isset.noUpdateContent;
      if(__isset.noEmail)
      {
        tmp97.NoEmail = this.NoEmail;
      }
      tmp97.__isset.noEmail = this.__isset.noEmail;
      if(__isset.noShare)
      {
        tmp97.NoShare = this.NoShare;
      }
      tmp97.__isset.noShare = this.__isset.noShare;
      if(__isset.noSharePublicly)
      {
        tmp97.NoSharePublicly = this.NoSharePublicly;
      }
      tmp97.__isset.noSharePublicly = this.__isset.noSharePublicly;
      return tmp97;
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
                NoUpdateTitle = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Bool)
              {
                NoUpdateContent = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Bool)
              {
                NoEmail = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Bool)
              {
                NoShare = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Bool)
              {
                NoSharePublicly = await iprot.ReadBoolAsync(cancellationToken);
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
        var tmp98 = new TStruct("NoteRestrictions");
        await oprot.WriteStructBeginAsync(tmp98, cancellationToken);
        var tmp99 = new TField();
        if(__isset.noUpdateTitle)
        {
          tmp99.Name = "noUpdateTitle";
          tmp99.Type = TType.Bool;
          tmp99.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp99, cancellationToken);
          await oprot.WriteBoolAsync(NoUpdateTitle, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noUpdateContent)
        {
          tmp99.Name = "noUpdateContent";
          tmp99.Type = TType.Bool;
          tmp99.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp99, cancellationToken);
          await oprot.WriteBoolAsync(NoUpdateContent, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noEmail)
        {
          tmp99.Name = "noEmail";
          tmp99.Type = TType.Bool;
          tmp99.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp99, cancellationToken);
          await oprot.WriteBoolAsync(NoEmail, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noShare)
        {
          tmp99.Name = "noShare";
          tmp99.Type = TType.Bool;
          tmp99.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp99, cancellationToken);
          await oprot.WriteBoolAsync(NoShare, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.noSharePublicly)
        {
          tmp99.Name = "noSharePublicly";
          tmp99.Type = TType.Bool;
          tmp99.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp99, cancellationToken);
          await oprot.WriteBoolAsync(NoSharePublicly, cancellationToken);
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
      if (!(that is NoteRestrictions other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.noUpdateTitle == other.__isset.noUpdateTitle) && ((!__isset.noUpdateTitle) || (global::System.Object.Equals(NoUpdateTitle, other.NoUpdateTitle))))
        && ((__isset.noUpdateContent == other.__isset.noUpdateContent) && ((!__isset.noUpdateContent) || (global::System.Object.Equals(NoUpdateContent, other.NoUpdateContent))))
        && ((__isset.noEmail == other.__isset.noEmail) && ((!__isset.noEmail) || (global::System.Object.Equals(NoEmail, other.NoEmail))))
        && ((__isset.noShare == other.__isset.noShare) && ((!__isset.noShare) || (global::System.Object.Equals(NoShare, other.NoShare))))
        && ((__isset.noSharePublicly == other.__isset.noSharePublicly) && ((!__isset.noSharePublicly) || (global::System.Object.Equals(NoSharePublicly, other.NoSharePublicly))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if(__isset.noUpdateTitle)
        {
          hashcode = (hashcode * 397) + NoUpdateTitle.GetHashCode();
        }
        if(__isset.noUpdateContent)
        {
          hashcode = (hashcode * 397) + NoUpdateContent.GetHashCode();
        }
        if(__isset.noEmail)
        {
          hashcode = (hashcode * 397) + NoEmail.GetHashCode();
        }
        if(__isset.noShare)
        {
          hashcode = (hashcode * 397) + NoShare.GetHashCode();
        }
        if(__isset.noSharePublicly)
        {
          hashcode = (hashcode * 397) + NoSharePublicly.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp100 = new StringBuilder("NoteRestrictions(");
      int tmp101 = 0;
      if(__isset.noUpdateTitle)
      {
        if(0 < tmp101++) { tmp100.Append(", "); }
        tmp100.Append("NoUpdateTitle: ");
        NoUpdateTitle.ToString(tmp100);
      }
      if(__isset.noUpdateContent)
      {
        if(0 < tmp101++) { tmp100.Append(", "); }
        tmp100.Append("NoUpdateContent: ");
        NoUpdateContent.ToString(tmp100);
      }
      if(__isset.noEmail)
      {
        if(0 < tmp101++) { tmp100.Append(", "); }
        tmp100.Append("NoEmail: ");
        NoEmail.ToString(tmp100);
      }
      if(__isset.noShare)
      {
        if(0 < tmp101++) { tmp100.Append(", "); }
        tmp100.Append("NoShare: ");
        NoShare.ToString(tmp100);
      }
      if(__isset.noSharePublicly)
      {
        if(0 < tmp101++) { tmp100.Append(", "); }
        tmp100.Append("NoSharePublicly: ");
        NoSharePublicly.ToString(tmp100);
      }
      tmp100.Append(')');
      return tmp100.ToString();
    }
  }

}
