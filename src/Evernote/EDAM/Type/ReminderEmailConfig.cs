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
  /// An enumeration describing the configuration state related to receiving
  /// reminder e-mails from the service.  Reminder e-mails summarize notes
  /// based on their Note.attributes.reminderTime values.
  /// 
  /// DO_NOT_SEND: The user has selected to not receive reminder e-mail.
  /// 
  /// SEND_DAILY_EMAIL: The user has selected to receive reminder e-mail for those
  ///   days when there is a reminder.
  /// </summary>
  public enum ReminderEmailConfig
  {
    DO_NOT_SEND = 1,
    SEND_DAILY_EMAIL = 2,
  }
}
