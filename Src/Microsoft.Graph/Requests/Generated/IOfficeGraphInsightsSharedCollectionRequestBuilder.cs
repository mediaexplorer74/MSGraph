// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IOfficeGraphInsightsSharedCollectionRequestBuilder.
    /// </summary>
    public partial interface IOfficeGraphInsightsSharedCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IOfficeGraphInsightsSharedCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IOfficeGraphInsightsSharedCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="ISharedInsightRequestBuilder"/> for the specified SharedInsight.
        /// </summary>
        /// <param name="id">The ID for the SharedInsight.</param>
        /// <returns>The <see cref="ISharedInsightRequestBuilder"/>.</returns>
        ISharedInsightRequestBuilder this[string id] { get; }

        
    }
}
