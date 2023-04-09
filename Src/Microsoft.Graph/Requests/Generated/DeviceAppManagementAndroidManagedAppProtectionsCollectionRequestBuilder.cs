// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementAndroidManagedAppProtectionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementAndroidManagedAppProtectionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementAndroidManagedAppProtectionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAndroidManagedAppProtectionRequestBuilder"/> for the specified DeviceAppManagementAndroidManagedAppProtection.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementAndroidManagedAppProtection.</param>
        /// <returns>The <see cref="IAndroidManagedAppProtectionRequestBuilder"/>.</returns>
        public IAndroidManagedAppProtectionRequestBuilder this[string id]
        {
            get
            {
                return new AndroidManagedAppProtectionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
