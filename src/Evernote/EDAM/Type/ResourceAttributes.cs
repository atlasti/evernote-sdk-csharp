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
  /// Structure holding the optional attributes of a Resource
  /// <dl>
  /// <dt>sourceURL</dt>
  ///   <dd>the original location where the resource was hosted
  ///   <br/>
  ///    Length:  EDAM_ATTRIBUTE_LEN_MIN - EDAM_ATTRIBUTE_LEN_MAX
  ///   </dd>
  /// 
  /// <dt>timestamp</dt>
  ///   <dd>the date and time that is associated with this resource
  ///   (e.g. the time embedded in an image from a digital camera with a clock)
  ///   </dd>
  /// 
  /// <dt>latitude</dt>
  ///   <dd>the latitude where the resource was captured
  ///   </dd>
  /// 
  /// <dt>longitude</dt>
  ///   <dd>the longitude where the resource was captured
  ///   </dd>
  /// 
  /// <dt>altitude</dt>
  ///   <dd>the altitude where the resource was captured
  ///   </dd>
  /// 
  /// <dt>cameraMake</dt>
  ///   <dd>information about an image's camera, e.g. as embedded in
  ///   the image's EXIF data
  ///   <br/>
  ///   Length:  EDAM_ATTRIBUTE_LEN_MIN - EDAM_ATTRIBUTE_LEN_MAX
  ///   </dd>
  /// 
  /// <dt>cameraModel</dt>
  ///   <dd>information about an image's camera, e.g. as embedded
  ///   in the image's EXIF data
  ///   <br/>
  ///   Length:  EDAM_ATTRIBUTE_LEN_MIN - EDAM_ATTRIBUTE_LEN_MAX
  ///   </dd>
  /// 
  /// <dt>clientWillIndex</dt>
  ///   <dd>if true, then the original client that submitted
  ///   the resource plans to submit the recognition index for this resource at a
  ///   later time.
  ///   </dd>
  /// 
  /// <dt>recoType</dt>
  ///   <dd>DEPRECATED - this field is no longer set by the service, so should
  ///     be ignored.
  ///   </dd>
  /// 
  /// <dt>fileName</dt>
  ///   <dd>if the resource came from a source that provided an
  ///   explicit file name, the original name will be stored here.  Many resources
  ///   come from unnamed sources, so this will not always be set.
  ///   </dd>
  /// 
  /// <dt>attachment</dt>
  ///   <dd>this will be true if the resource should be displayed as an attachment,
  ///   or false if the resource should be displayed inline (if possible).
  ///   </dd>
  /// 
  /// <dt>applicationData</dt>
  /// <dd>Provides a location for applications to store a relatively small
  /// (4kb) blob of data associated with a Resource that is not visible to the user
  /// and that is opaque to the Evernote service. A single application may use at most
  /// one entry in this map, using its API consumer key as the map key. See the
  /// documentation for LazyMap for a description of when the actual map values
  /// are returned by the service.
  /// <p>To safely add or modify your application's entry in the map, use
  /// NoteStore.setResourceApplicationDataEntry. To safely remove your application's
  /// entry from the map, use NoteStore.unsetResourceApplicationDataEntry.</p>
  /// Minimum length of a name (key): EDAM_APPLICATIONDATA_NAME_LEN_MIN
  /// <br/>
  /// Sum max size of key and value: EDAM_APPLICATIONDATA_ENTRY_LEN_MAX
  /// <br/>
  /// Syntax regex for name (key): EDAM_APPLICATIONDATA_NAME_REGEX
  /// </dd>
  /// 
  /// </dl>
  /// </summary>
  public partial class ResourceAttributes : TBase
  {
    private string _sourceURL;
    private long _timestamp;
    private double _latitude;
    private double _longitude;
    private double _altitude;
    private string _cameraMake;
    private string _cameraModel;
    private bool _clientWillIndex;
    private string _recoType;
    private string _fileName;
    private bool _attachment;
    private global::Evernote.EDAM.Type.LazyMap _applicationData;

    public string SourceURL
    {
      get
      {
        return _sourceURL;
      }
      set
      {
        __isset.sourceURL = true;
        this._sourceURL = value;
      }
    }

    public long Timestamp
    {
      get
      {
        return _timestamp;
      }
      set
      {
        __isset.timestamp = true;
        this._timestamp = value;
      }
    }

    public double Latitude
    {
      get
      {
        return _latitude;
      }
      set
      {
        __isset.latitude = true;
        this._latitude = value;
      }
    }

    public double Longitude
    {
      get
      {
        return _longitude;
      }
      set
      {
        __isset.longitude = true;
        this._longitude = value;
      }
    }

    public double Altitude
    {
      get
      {
        return _altitude;
      }
      set
      {
        __isset.altitude = true;
        this._altitude = value;
      }
    }

    public string CameraMake
    {
      get
      {
        return _cameraMake;
      }
      set
      {
        __isset.cameraMake = true;
        this._cameraMake = value;
      }
    }

    public string CameraModel
    {
      get
      {
        return _cameraModel;
      }
      set
      {
        __isset.cameraModel = true;
        this._cameraModel = value;
      }
    }

    public bool ClientWillIndex
    {
      get
      {
        return _clientWillIndex;
      }
      set
      {
        __isset.clientWillIndex = true;
        this._clientWillIndex = value;
      }
    }

    public string RecoType
    {
      get
      {
        return _recoType;
      }
      set
      {
        __isset.recoType = true;
        this._recoType = value;
      }
    }

    public string FileName
    {
      get
      {
        return _fileName;
      }
      set
      {
        __isset.fileName = true;
        this._fileName = value;
      }
    }

    public bool Attachment
    {
      get
      {
        return _attachment;
      }
      set
      {
        __isset.attachment = true;
        this._attachment = value;
      }
    }

    public global::Evernote.EDAM.Type.LazyMap ApplicationData
    {
      get
      {
        return _applicationData;
      }
      set
      {
        __isset.applicationData = true;
        this._applicationData = value;
      }
    }


    public Isset __isset;
    public struct Isset
    {
      public bool sourceURL;
      public bool timestamp;
      public bool latitude;
      public bool longitude;
      public bool altitude;
      public bool cameraMake;
      public bool cameraModel;
      public bool clientWillIndex;
      public bool recoType;
      public bool fileName;
      public bool attachment;
      public bool applicationData;
    }

    public ResourceAttributes()
    {
    }

    public ResourceAttributes DeepCopy()
    {
      var tmp72 = new ResourceAttributes();
      if((SourceURL != null) && __isset.sourceURL)
      {
        tmp72.SourceURL = this.SourceURL;
      }
      tmp72.__isset.sourceURL = this.__isset.sourceURL;
      if(__isset.timestamp)
      {
        tmp72.Timestamp = this.Timestamp;
      }
      tmp72.__isset.timestamp = this.__isset.timestamp;
      if(__isset.latitude)
      {
        tmp72.Latitude = this.Latitude;
      }
      tmp72.__isset.latitude = this.__isset.latitude;
      if(__isset.longitude)
      {
        tmp72.Longitude = this.Longitude;
      }
      tmp72.__isset.longitude = this.__isset.longitude;
      if(__isset.altitude)
      {
        tmp72.Altitude = this.Altitude;
      }
      tmp72.__isset.altitude = this.__isset.altitude;
      if((CameraMake != null) && __isset.cameraMake)
      {
        tmp72.CameraMake = this.CameraMake;
      }
      tmp72.__isset.cameraMake = this.__isset.cameraMake;
      if((CameraModel != null) && __isset.cameraModel)
      {
        tmp72.CameraModel = this.CameraModel;
      }
      tmp72.__isset.cameraModel = this.__isset.cameraModel;
      if(__isset.clientWillIndex)
      {
        tmp72.ClientWillIndex = this.ClientWillIndex;
      }
      tmp72.__isset.clientWillIndex = this.__isset.clientWillIndex;
      if((RecoType != null) && __isset.recoType)
      {
        tmp72.RecoType = this.RecoType;
      }
      tmp72.__isset.recoType = this.__isset.recoType;
      if((FileName != null) && __isset.fileName)
      {
        tmp72.FileName = this.FileName;
      }
      tmp72.__isset.fileName = this.__isset.fileName;
      if(__isset.attachment)
      {
        tmp72.Attachment = this.Attachment;
      }
      tmp72.__isset.attachment = this.__isset.attachment;
      if((ApplicationData != null) && __isset.applicationData)
      {
        tmp72.ApplicationData = (global::Evernote.EDAM.Type.LazyMap)this.ApplicationData.DeepCopy();
      }
      tmp72.__isset.applicationData = this.__isset.applicationData;
      return tmp72;
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
              if (field.Type == TType.String)
              {
                SourceURL = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.I64)
              {
                Timestamp = await iprot.ReadI64Async(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 3:
              if (field.Type == TType.Double)
              {
                Latitude = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 4:
              if (field.Type == TType.Double)
              {
                Longitude = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 5:
              if (field.Type == TType.Double)
              {
                Altitude = await iprot.ReadDoubleAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 6:
              if (field.Type == TType.String)
              {
                CameraMake = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 7:
              if (field.Type == TType.String)
              {
                CameraModel = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 8:
              if (field.Type == TType.Bool)
              {
                ClientWillIndex = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 9:
              if (field.Type == TType.String)
              {
                RecoType = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 10:
              if (field.Type == TType.String)
              {
                FileName = await iprot.ReadStringAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 11:
              if (field.Type == TType.Bool)
              {
                Attachment = await iprot.ReadBoolAsync(cancellationToken);
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 12:
              if (field.Type == TType.Struct)
              {
                ApplicationData = new global::Evernote.EDAM.Type.LazyMap();
                await ApplicationData.ReadAsync(iprot, cancellationToken);
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
        var tmp73 = new TStruct("ResourceAttributes");
        await oprot.WriteStructBeginAsync(tmp73, cancellationToken);
        var tmp74 = new TField();
        if((SourceURL != null) && __isset.sourceURL)
        {
          tmp74.Name = "sourceURL";
          tmp74.Type = TType.String;
          tmp74.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteStringAsync(SourceURL, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.timestamp)
        {
          tmp74.Name = "timestamp";
          tmp74.Type = TType.I64;
          tmp74.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteI64Async(Timestamp, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.latitude)
        {
          tmp74.Name = "latitude";
          tmp74.Type = TType.Double;
          tmp74.ID = 3;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteDoubleAsync(Latitude, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.longitude)
        {
          tmp74.Name = "longitude";
          tmp74.Type = TType.Double;
          tmp74.ID = 4;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteDoubleAsync(Longitude, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.altitude)
        {
          tmp74.Name = "altitude";
          tmp74.Type = TType.Double;
          tmp74.ID = 5;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteDoubleAsync(Altitude, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((CameraMake != null) && __isset.cameraMake)
        {
          tmp74.Name = "cameraMake";
          tmp74.Type = TType.String;
          tmp74.ID = 6;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteStringAsync(CameraMake, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((CameraModel != null) && __isset.cameraModel)
        {
          tmp74.Name = "cameraModel";
          tmp74.Type = TType.String;
          tmp74.ID = 7;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteStringAsync(CameraModel, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.clientWillIndex)
        {
          tmp74.Name = "clientWillIndex";
          tmp74.Type = TType.Bool;
          tmp74.ID = 8;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteBoolAsync(ClientWillIndex, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((RecoType != null) && __isset.recoType)
        {
          tmp74.Name = "recoType";
          tmp74.Type = TType.String;
          tmp74.ID = 9;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteStringAsync(RecoType, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((FileName != null) && __isset.fileName)
        {
          tmp74.Name = "fileName";
          tmp74.Type = TType.String;
          tmp74.ID = 10;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteStringAsync(FileName, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if(__isset.attachment)
        {
          tmp74.Name = "attachment";
          tmp74.Type = TType.Bool;
          tmp74.ID = 11;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await oprot.WriteBoolAsync(Attachment, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((ApplicationData != null) && __isset.applicationData)
        {
          tmp74.Name = "applicationData";
          tmp74.Type = TType.Struct;
          tmp74.ID = 12;
          await oprot.WriteFieldBeginAsync(tmp74, cancellationToken);
          await ApplicationData.WriteAsync(oprot, cancellationToken);
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
      if (!(that is ResourceAttributes other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ((__isset.sourceURL == other.__isset.sourceURL) && ((!__isset.sourceURL) || (global::System.Object.Equals(SourceURL, other.SourceURL))))
        && ((__isset.timestamp == other.__isset.timestamp) && ((!__isset.timestamp) || (global::System.Object.Equals(Timestamp, other.Timestamp))))
        && ((__isset.latitude == other.__isset.latitude) && ((!__isset.latitude) || (global::System.Object.Equals(Latitude, other.Latitude))))
        && ((__isset.longitude == other.__isset.longitude) && ((!__isset.longitude) || (global::System.Object.Equals(Longitude, other.Longitude))))
        && ((__isset.altitude == other.__isset.altitude) && ((!__isset.altitude) || (global::System.Object.Equals(Altitude, other.Altitude))))
        && ((__isset.cameraMake == other.__isset.cameraMake) && ((!__isset.cameraMake) || (global::System.Object.Equals(CameraMake, other.CameraMake))))
        && ((__isset.cameraModel == other.__isset.cameraModel) && ((!__isset.cameraModel) || (global::System.Object.Equals(CameraModel, other.CameraModel))))
        && ((__isset.clientWillIndex == other.__isset.clientWillIndex) && ((!__isset.clientWillIndex) || (global::System.Object.Equals(ClientWillIndex, other.ClientWillIndex))))
        && ((__isset.recoType == other.__isset.recoType) && ((!__isset.recoType) || (global::System.Object.Equals(RecoType, other.RecoType))))
        && ((__isset.fileName == other.__isset.fileName) && ((!__isset.fileName) || (global::System.Object.Equals(FileName, other.FileName))))
        && ((__isset.attachment == other.__isset.attachment) && ((!__isset.attachment) || (global::System.Object.Equals(Attachment, other.Attachment))))
        && ((__isset.applicationData == other.__isset.applicationData) && ((!__isset.applicationData) || (global::System.Object.Equals(ApplicationData, other.ApplicationData))));
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((SourceURL != null) && __isset.sourceURL)
        {
          hashcode = (hashcode * 397) + SourceURL.GetHashCode();
        }
        if(__isset.timestamp)
        {
          hashcode = (hashcode * 397) + Timestamp.GetHashCode();
        }
        if(__isset.latitude)
        {
          hashcode = (hashcode * 397) + Latitude.GetHashCode();
        }
        if(__isset.longitude)
        {
          hashcode = (hashcode * 397) + Longitude.GetHashCode();
        }
        if(__isset.altitude)
        {
          hashcode = (hashcode * 397) + Altitude.GetHashCode();
        }
        if((CameraMake != null) && __isset.cameraMake)
        {
          hashcode = (hashcode * 397) + CameraMake.GetHashCode();
        }
        if((CameraModel != null) && __isset.cameraModel)
        {
          hashcode = (hashcode * 397) + CameraModel.GetHashCode();
        }
        if(__isset.clientWillIndex)
        {
          hashcode = (hashcode * 397) + ClientWillIndex.GetHashCode();
        }
        if((RecoType != null) && __isset.recoType)
        {
          hashcode = (hashcode * 397) + RecoType.GetHashCode();
        }
        if((FileName != null) && __isset.fileName)
        {
          hashcode = (hashcode * 397) + FileName.GetHashCode();
        }
        if(__isset.attachment)
        {
          hashcode = (hashcode * 397) + Attachment.GetHashCode();
        }
        if((ApplicationData != null) && __isset.applicationData)
        {
          hashcode = (hashcode * 397) + ApplicationData.GetHashCode();
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp75 = new StringBuilder("ResourceAttributes(");
      int tmp76 = 0;
      if((SourceURL != null) && __isset.sourceURL)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("SourceURL: ");
        SourceURL.ToString(tmp75);
      }
      if(__isset.timestamp)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("Timestamp: ");
        Timestamp.ToString(tmp75);
      }
      if(__isset.latitude)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("Latitude: ");
        Latitude.ToString(tmp75);
      }
      if(__isset.longitude)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("Longitude: ");
        Longitude.ToString(tmp75);
      }
      if(__isset.altitude)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("Altitude: ");
        Altitude.ToString(tmp75);
      }
      if((CameraMake != null) && __isset.cameraMake)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("CameraMake: ");
        CameraMake.ToString(tmp75);
      }
      if((CameraModel != null) && __isset.cameraModel)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("CameraModel: ");
        CameraModel.ToString(tmp75);
      }
      if(__isset.clientWillIndex)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("ClientWillIndex: ");
        ClientWillIndex.ToString(tmp75);
      }
      if((RecoType != null) && __isset.recoType)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("RecoType: ");
        RecoType.ToString(tmp75);
      }
      if((FileName != null) && __isset.fileName)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("FileName: ");
        FileName.ToString(tmp75);
      }
      if(__isset.attachment)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("Attachment: ");
        Attachment.ToString(tmp75);
      }
      if((ApplicationData != null) && __isset.applicationData)
      {
        if(0 < tmp76++) { tmp75.Append(", "); }
        tmp75.Append("ApplicationData: ");
        ApplicationData.ToString(tmp75);
      }
      tmp75.Append(')');
      return tmp75.ToString();
    }
  }

}
