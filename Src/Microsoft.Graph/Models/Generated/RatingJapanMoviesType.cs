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
    /// The enum RatingJapanMoviesType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RatingJapanMoviesType
    {
    
        /// <summary>
        /// All Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// All Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// General
        /// </summary>
        General = 2,
	
        /// <summary>
        /// Parental Guidance
        /// </summary>
        ParentalGuidance = 3,
	
        /// <summary>
        /// Ages Above15
        /// </summary>
        AgesAbove15 = 4,
	
        /// <summary>
        /// Ages Above18
        /// </summary>
        AgesAbove18 = 5,
	
    }
}
