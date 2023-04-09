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
    /// The type GraphServiceSharesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceSharesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceSharesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceSharesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceSharesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceSharesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceSharesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceSharesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ISharedDriveItemRequestBuilder"/> for the specified GraphServiceSharedDriveItem.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceSharedDriveItem.</param>
        /// <returns>The <see cref="ISharedDriveItemRequestBuilder"/>.</returns>
        public ISharedDriveItemRequestBuilder this[string id]
        {
            get
            {
                return new SharedDriveItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
