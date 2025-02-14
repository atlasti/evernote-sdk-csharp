/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.16.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */

#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Evernote.EDAM.Type
{
  /// <summary>
  /// Privilege levels for accessing a shared note. All privilege levels convey "activity feed" access,
  /// which allows the recipient to access information about other recipients and the activity stream.
  /// 
  /// READ_NOTE: Recipient has rights to read the shared note.
  /// 
  /// MODIFY_NOTE: Recipient has all of the rights of READ_NOTE, plus rights to modify the shared
  ///   note's content, title and resources. Other fields, including the notebook, tags and metadata,
  ///   may not be modified.
  /// 
  /// FULL_ACCESS: Recipient has all of the rights of MODIFY_NOTE, plus rights to share the note with
  ///   other users via email, public note links, and note sharing. Recipient may also update and
  ///   remove other recipient's note sharing rights.
  /// </summary>
  public enum SharedNotePrivilegeLevel
  {
    READ_NOTE = 0,
    MODIFY_NOTE = 1,
    FULL_ACCESS = 2,
  }
}
