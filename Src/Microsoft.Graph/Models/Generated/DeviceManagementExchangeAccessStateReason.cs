// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeviceManagementExchangeAccessStateReason.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceManagementExchangeAccessStateReason
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 1,
	
        /// <summary>
        /// Exchange Global Rule
        /// </summary>
        ExchangeGlobalRule = 2,
	
        /// <summary>
        /// Exchange Individual Rule
        /// </summary>
        ExchangeIndividualRule = 3,
	
        /// <summary>
        /// Exchange Device Rule
        /// </summary>
        ExchangeDeviceRule = 4,
	
        /// <summary>
        /// Exchange Upgrade
        /// </summary>
        ExchangeUpgrade = 5,
	
        /// <summary>
        /// Exchange Mailbox Policy
        /// </summary>
        ExchangeMailboxPolicy = 6,
	
        /// <summary>
        /// Other
        /// </summary>
        Other = 7,
	
        /// <summary>
        /// Compliant
        /// </summary>
        Compliant = 8,
	
        /// <summary>
        /// Not Compliant
        /// </summary>
        NotCompliant = 9,
	
        /// <summary>
        /// Not Enrolled
        /// </summary>
        NotEnrolled = 10,
	
        /// <summary>
        /// Unknown Location
        /// </summary>
        UnknownLocation = 12,
	
        /// <summary>
        /// Mfa Required
        /// </summary>
        MfaRequired = 13,
	
        /// <summary>
        /// Azure ADBlock Due To Access Policy
        /// </summary>
        AzureADBlockDueToAccessPolicy = 14,
	
        /// <summary>
        /// Compromised Password
        /// </summary>
        CompromisedPassword = 15,
	
        /// <summary>
        /// Device Not Known With Managed App
        /// </summary>
        DeviceNotKnownWithManagedApp = 16,
	
    }
}