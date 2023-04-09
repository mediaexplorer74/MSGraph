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
    /// The type Event Message.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EventMessage : Message
    {
    
		///<summary>
		/// The EventMessage constructor
		///</summary>
        public EventMessage()
        {
            this.ODataType = "microsoft.graph.eventMessage";
        }
	
        /// <summary>
        /// Gets or sets meeting message type.
        /// The type of event message: none, meetingRequest, meetingCancelled, meetingAccepted, meetingTenativelyAccepted, meetingDeclined.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "meetingMessageType", Required = Newtonsoft.Json.Required.Default)]
        public MeetingMessageType? MeetingMessageType { get; set; }
    
        /// <summary>
        /// Gets or sets event.
        /// The event associated with the event message. The assumption for attendees or room resources is that the Calendar Attendant is set to automatically update the calendar with an event when meeting request event messages arrive. Navigation property.  Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "event", Required = Newtonsoft.Json.Required.Default)]
        public Event Event { get; set; }
    
    }
}
