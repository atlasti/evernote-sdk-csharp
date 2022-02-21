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
  /// Enumeration of the roles that a User can have within an Evernote Business account.
  /// 
  /// ADMIN: The user is an administrator of the Evernote Business account.
  /// 
  /// NORMAL: The user is a regular user within the Evernote Business account.
  /// </summary>
  public enum BusinessUserRole
  {
    ADMIN = 1,
    NORMAL = 2,
  }
}
