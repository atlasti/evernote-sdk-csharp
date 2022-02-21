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
  /// An enumeration defining the possible states of a BusinessInvitation.
  /// 
  /// APPROVED: The invitation was created or approved by a business admin and may be redeemed by the
  ///   invited email.
  /// 
  /// REQUESTED: The invitation was requested by a non-admin member of the business and must be
  ///   approved by an admin before it may be redeemed. Invitations in this state do not count
  ///   against a business' seat limit.
  /// 
  /// REDEEMED: The invitation has already been redeemed. Invitations in this state do not count
  ///   against a business' seat limit.
  /// </summary>
  public enum BusinessInvitationStatus
  {
    APPROVED = 0,
    REQUESTED = 1,
    REDEEMED = 2,
  }
}
