// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodCollectionPage.cs.tt

namespace Microsoft.Graph
{
    /// <summary>
    /// The type DirectoryObjectGetMemberGroupsCollectionPage.
    /// </summary>
    public partial class DirectoryObjectGetMemberGroupsCollectionPage : CollectionPage<string>, IDirectoryObjectGetMemberGroupsCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IDirectoryObjectGetMemberGroupsRequest"/> instance.
        /// </summary>
        public IDirectoryObjectGetMemberGroupsRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new DirectoryObjectGetMemberGroupsRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
