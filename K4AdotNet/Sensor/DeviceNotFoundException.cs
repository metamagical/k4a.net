﻿using System;
using System.Runtime.Serialization;

namespace K4AdotNet.Sensor
{
    /// <summary>Exception: Azure Kinect device not found.</summary>
    /// <seealso cref="Device.Open(int)"/>
    [Serializable]
    public class DeviceNotFoundException : DeviceException
    {
        /// <summary>Creates exception for device with specified index.</summary>
        /// <param name="deviceIndex">Zero-based device index. Can be reached then via <see cref="DeviceException.DeviceIndex"/> property.</param>
        /// <seealso cref="Device.DeviceIndex"/>
        public DeviceNotFoundException(int deviceIndex)
            : base("Azure Kinect device" + FormatDeviceIndex(deviceIndex) + " not found. Make sure that Azure Kinect device is connected and has power supply.",
                  deviceIndex)
        { }

        /// <summary>Constructor for deserialization needs.</summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected DeviceNotFoundException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}