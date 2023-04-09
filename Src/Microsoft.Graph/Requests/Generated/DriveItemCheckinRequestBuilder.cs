// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type DriveItemCheckinRequestBuilder.
    /// </summary>
    public partial class DriveItemCheckinRequestBuilder : BaseActionMethodRequestBuilder<IDriveItemCheckinRequest>, IDriveItemCheckinRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="DriveItemCheckinRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="checkInAs">A checkInAs parameter for the OData method call.</param>
        /// <param name="comment">A comment parameter for the OData method call.</param>
        public DriveItemCheckinRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string checkInAs,
            string comment)
            : base(requestUrl, client)
        {
            this.SetParameter("checkInAs", checkInAs, true);
            this.SetParameter("comment", comment, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IDriveItemCheckinRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new DriveItemCheckinRequest(functionUrl, this.Client, options);

            if (this.HasParameter("checkInAs"))
            {
                request.RequestBody.CheckInAs = this.GetParameter<string>("checkInAs");
            }

            if (this.HasParameter("comment"))
            {
                request.RequestBody.Comment = this.GetParameter<string>("comment");
            }

            return request;
        }
    }
}
