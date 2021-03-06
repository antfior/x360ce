﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using x360ce.Engine.Data;

namespace x360ce.Engine
{

    /// <summary>
    ///  Message which will be used to communicate with webservice.
    /// </summary>
    public class CloudMessage
    {

        public CloudMessage()
        {
            Values = new KeyValueList();
        }

        public CloudMessage(CloudAction action)
        {
            Action = action;
            Values = new KeyValueList();
        }

        [DefaultValue(0)]
        public int ErrorCode { get; set; }

        [DefaultValue(null)]
        public string ErrorMessage { get; set; }

        [DefaultValue(CloudAction.None)]
        public CloudAction Action { get; set; }

        [DefaultValue(null)]
        public KeyValueList Values { get; set; }

        #region Data

        /// <summary>
        /// Supply checksums of existing data to skip during synchronization in order to reduce traffic.
        /// </summary>
        [XmlArray] public Guid[] Checksums { get; set; }

        [XmlArray] public UserDevice[] UserDevices { get; set; }

        [XmlArray] public UserInstance[] UserInstances { get; set; }

        [XmlArray] public UserComputer[] UserComputers { get; set; }

        /// <summary>
        /// During request it will be used to specify search filters. If null then do not retrieve.
        /// During response it will contain used data.
        /// </summary>
        [XmlArray] public UserGame[] UserGames { get; set; }

        #endregion

    }
}
