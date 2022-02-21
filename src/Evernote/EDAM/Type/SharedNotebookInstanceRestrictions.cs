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
  /// An enumeration describing restrictions on the domain of shared notebook
  /// instances that are valid for a given operation, as used, for example, in
  /// NotebookRestrictions.
  /// 
  /// ASSIGNED: The domain consists of shared notebooks that belong, or are assigned,
  /// to the recipient.
  /// 
  /// NO_SHARED_NOTEBOOKS: No shared notebooks are applicable to the operation.
  /// </summary>
  public enum SharedNotebookInstanceRestrictions
  {
    ASSIGNED = 1,
    NO_SHARED_NOTEBOOKS = 2,
  }
}
