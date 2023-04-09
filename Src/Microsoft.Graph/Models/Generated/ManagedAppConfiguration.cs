// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Managed App Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ManagedAppConfiguration : ManagedAppPolicy
    {
    
		///<summary>
		/// The internal ManagedAppConfiguration constructor
		///</summary>
        protected internal ManagedAppConfiguration()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets custom settings.
        /// A set of string key and string value pairs to be sent to apps for users to whom the configuration is scoped, unalterned by this service
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customSettings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> CustomSettings { get; set; }
    
    }
}

