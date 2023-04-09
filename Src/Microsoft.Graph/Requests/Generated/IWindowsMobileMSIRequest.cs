// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsMobileMSIRequest.
    /// </summary>
    public partial interface IWindowsMobileMSIRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsMobileMSI using POST.
        /// </summary>
        /// <param name="windowsMobileMSIToCreate">The WindowsMobileMSI to create.</param>
        /// <returns>The created WindowsMobileMSI.</returns>
        System.Threading.Tasks.Task<WindowsMobileMSI> CreateAsync(WindowsMobileMSI windowsMobileMSIToCreate);        /// <summary>
        /// Creates the specified WindowsMobileMSI using POST.
        /// </summary>
        /// <param name="windowsMobileMSIToCreate">The WindowsMobileMSI to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsMobileMSI.</returns>
        System.Threading.Tasks.Task<WindowsMobileMSI> CreateAsync(WindowsMobileMSI windowsMobileMSIToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsMobileMSI.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsMobileMSI.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsMobileMSI.
        /// </summary>
        /// <returns>The WindowsMobileMSI.</returns>
        System.Threading.Tasks.Task<WindowsMobileMSI> GetAsync();

        /// <summary>
        /// Gets the specified WindowsMobileMSI.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsMobileMSI.</returns>
        System.Threading.Tasks.Task<WindowsMobileMSI> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsMobileMSI using PATCH.
        /// </summary>
        /// <param name="windowsMobileMSIToUpdate">The WindowsMobileMSI to update.</param>
        /// <returns>The updated WindowsMobileMSI.</returns>
        System.Threading.Tasks.Task<WindowsMobileMSI> UpdateAsync(WindowsMobileMSI windowsMobileMSIToUpdate);

        /// <summary>
        /// Updates the specified WindowsMobileMSI using PATCH.
        /// </summary>
        /// <param name="windowsMobileMSIToUpdate">The WindowsMobileMSI to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsMobileMSI.</returns>
        System.Threading.Tasks.Task<WindowsMobileMSI> UpdateAsync(WindowsMobileMSI windowsMobileMSIToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMobileMSIRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMobileMSIRequest Expand(Expression<Func<WindowsMobileMSI, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMobileMSIRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsMobileMSIRequest Select(Expression<Func<WindowsMobileMSI, object>> selectExpression);

    }
}
