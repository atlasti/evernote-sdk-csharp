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

namespace Evernote.EDAM.Error
{
  /// <summary>
  /// An enumeration that provides a reason for why a given contact was invalid, for example,
  /// as thrown via an EDAMInvalidContactsException.
  /// 
  /// <dl>
  ///   <dt>BAD_ADDRESS</dt>
  ///     <dd>The contact information does not represent a valid address for a recipient.
  ///         Clients should be validating and normalizing contacts, so receiving this
  ///         error code commonly represents a client error.
  ///         </dd>
  ///   <dt>DUPLICATE_CONTACT</dt>
  ///     <dd>If the method throwing this exception accepts a list of contacts, this error
  ///         code indicates that the given contact is a duplicate of another contact in
  ///         the list.  Note that the server may clean up contacts, and that this cleanup
  ///         occurs before checking for duplication.  Receiving this error is commonly
  ///         an indication of a client issue, since client should be normalizing contacts
  ///         and removing duplicates. All instances that are duplicates are returned.  For
  ///         example, if a list of 5 contacts has the same e-mail address twice, the two
  ///         conflicting e-mail address contacts will be returned.
  ///         </dd>
  ///   <dt>NO_CONNECTION</dt>
  ///     <dd>Indicates that the given contact, an Evernote type contact, is not connected
  ///         to the user for which the call is being made. It is possible that clients are
  ///         out of sync with the server and should re-synchronize their identities and
  ///         business user state. See Identity.userConnected for more information on user
  ///         connections.
  ///         </dd>
  /// </dl>
  /// 
  /// Note that if multiple reasons may apply, only one is returned. The precedence order
  /// is BAD_ADDRESS, DUPLICATE_CONTACT, NO_CONNECTION, meaning that if a contact has a bad
  /// address and is also duplicated, it will be returned as a BAD_ADDRESS.
  /// </summary>
  public enum EDAMInvalidContactReason
  {
    BAD_ADDRESS = 0,
    DUPLICATE_CONTACT = 1,
    NO_CONNECTION = 2,
  }
}
