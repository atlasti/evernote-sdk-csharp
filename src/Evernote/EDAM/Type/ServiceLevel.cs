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
  /// This enumeration defines the possible tiers of service that a user may have. A
  /// ServiceLevel of BUSINESS signifies a business-only account, which can never be any
  /// other ServiceLevel.
  /// </summary>
  public enum ServiceLevel
  {
    BASIC = 1,
    PLUS = 2,
    PREMIUM = 3,
    BUSINESS = 4,
  }
}
