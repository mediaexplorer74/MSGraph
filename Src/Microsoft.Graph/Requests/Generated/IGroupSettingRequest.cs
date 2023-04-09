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
    /// The interface IGroupSettingRequest.
    /// </summary>
    public partial interface IGroupSettingRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified GroupSetting using POST.
        /// </summary>
        /// <param name="groupSettingToCreate">The GroupSetting to create.</param>
        /// <returns>The created GroupSetting.</returns>
        System.Threading.Tasks.Task<GroupSetting> CreateAsync(GroupSetting groupSettingToCreate);        /// <summary>
        /// Creates the specified GroupSetting using POST.
        /// </summary>
        /// <param name="groupSettingToCreate">The GroupSetting to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created GroupSetting.</returns>
        System.Threading.Tasks.Task<GroupSetting> CreateAsync(GroupSetting groupSettingToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified GroupSetting.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified GroupSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified GroupSetting.
        /// </summary>
        /// <returns>The GroupSetting.</returns>
        System.Threading.Tasks.Task<GroupSetting> GetAsync();

        /// <summary>
        /// Gets the specified GroupSetting.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The GroupSetting.</returns>
        System.Threading.Tasks.Task<GroupSetting> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified GroupSetting using PATCH.
        /// </summary>
        /// <param name="groupSettingToUpdate">The GroupSetting to update.</param>
        /// <returns>The updated GroupSetting.</returns>
        System.Threading.Tasks.Task<GroupSetting> UpdateAsync(GroupSetting groupSettingToUpdate);

        /// <summary>
        /// Updates the specified GroupSetting using PATCH.
        /// </summary>
        /// <param name="groupSettingToUpdate">The GroupSetting to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated GroupSetting.</returns>
        System.Threading.Tasks.Task<GroupSetting> UpdateAsync(GroupSetting groupSettingToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupSettingRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IGroupSettingRequest Expand(Expression<Func<GroupSetting, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupSettingRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IGroupSettingRequest Select(Expression<Func<GroupSetting, object>> selectExpression);

    }
}
