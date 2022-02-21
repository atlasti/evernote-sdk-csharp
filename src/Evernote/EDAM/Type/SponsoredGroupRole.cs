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
  /// Enumeration of the roles that a User can have within a sponsored group.
  /// 
  /// GROUP_MEMBER: The user is a member of the group with no special privileges.
  /// 
  /// GROUP_ADMIN: The user is an administrator within the group.
  /// 
  /// GROUP_OWNER: The user is the owner of the group.
  /// </summary>
  public enum SponsoredGroupRole
  {
    GROUP_MEMBER = 1,
    GROUP_ADMIN = 2,
    GROUP_OWNER = 3,
  }
}
