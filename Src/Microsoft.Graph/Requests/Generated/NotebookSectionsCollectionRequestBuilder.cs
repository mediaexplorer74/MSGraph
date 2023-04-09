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
    /// The type NotebookSectionsCollectionRequestBuilder.
    /// </summary>
    public partial class NotebookSectionsCollectionRequestBuilder : BaseRequestBuilder, INotebookSectionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new NotebookSectionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public NotebookSectionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public INotebookSectionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public INotebookSectionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new NotebookSectionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOnenoteSectionRequestBuilder"/> for the specified NotebookOnenoteSection.
        /// </summary>
        /// <param name="id">The ID for the NotebookOnenoteSection.</param>
        /// <returns>The <see cref="IOnenoteSectionRequestBuilder"/>.</returns>
        public IOnenoteSectionRequestBuilder this[string id]
        {
            get
            {
                return new OnenoteSectionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
