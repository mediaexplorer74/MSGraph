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
    /// The type DeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder : BaseRequestBuilder, IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceAppManagementTargetedManagedAppConfigurationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceAppManagementTargetedManagedAppConfigurationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceAppManagementTargetedManagedAppConfigurationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ITargetedManagedAppConfigurationRequestBuilder"/> for the specified DeviceAppManagementTargetedManagedAppConfiguration.
        /// </summary>
        /// <param name="id">The ID for the DeviceAppManagementTargetedManagedAppConfiguration.</param>
        /// <returns>The <see cref="ITargetedManagedAppConfigurationRequestBuilder"/>.</returns>
        public ITargetedManagedAppConfigurationRequestBuilder this[string id]
        {
            get
            {
                return new TargetedManagedAppConfigurationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
