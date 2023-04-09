// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsSeriesSumRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookFunctionsSeriesSumRequestBody
    {
    
        /// <summary>
        /// Gets or sets X.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "x", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken X { get; set; }
    
        /// <summary>
        /// Gets or sets N.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "n", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken N { get; set; }
    
        /// <summary>
        /// Gets or sets M.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "m", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken M { get; set; }
    
        /// <summary>
        /// Gets or sets Coefficients.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "coefficients", Required = Newtonsoft.Json.Required.Default)]
        public Newtonsoft.Json.Linq.JToken Coefficients { get; set; }
    
    }
}
