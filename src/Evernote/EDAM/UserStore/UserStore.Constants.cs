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


#nullable disable                // suppress C# 8.0 nullable contexts (we still support earlier versions)
#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Evernote.EDAM.UserStore
{
  public static class UserStoreConstants
  {
    /// <summary>
    /// The major version number for the current revision of the EDAM protocol.
    /// Clients pass this to the service using UserStore.checkVersion at the
    /// beginning of a session to confirm that they are not out of date.
    /// </summary>
    public const short EDAM_VERSION_MAJOR = 1;
    /// <summary>
    /// The minor version number for the current revision of the EDAM protocol.
    /// Clients pass this to the service using UserStore.checkVersion at the
    /// beginning of a session to confirm that they are not out of date.
    /// </summary>
    public const short EDAM_VERSION_MINOR = 28;
  }
}
