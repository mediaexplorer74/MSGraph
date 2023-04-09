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
    /// The interface IMacOSCompliancePolicyRequest.
    /// </summary>
    public partial interface IMacOSCompliancePolicyRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified MacOSCompliancePolicy using POST.
        /// </summary>
        /// <param name="macOSCompliancePolicyToCreate">The MacOSCompliancePolicy to create.</param>
        /// <returns>The created MacOSCompliancePolicy.</returns>
        System.Threading.Tasks.Task<MacOSCompliancePolicy> CreateAsync(MacOSCompliancePolicy macOSCompliancePolicyToCreate);        /// <summary>
        /// Creates the specified MacOSCompliancePolicy using POST.
        /// </summary>
        /// <param name="macOSCompliancePolicyToCreate">The MacOSCompliancePolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MacOSCompliancePolicy.</returns>
        System.Threading.Tasks.Task<MacOSCompliancePolicy> CreateAsync(MacOSCompliancePolicy macOSCompliancePolicyToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified MacOSCompliancePolicy.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified MacOSCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified MacOSCompliancePolicy.
        /// </summary>
        /// <returns>The MacOSCompliancePolicy.</returns>
        System.Threading.Tasks.Task<MacOSCompliancePolicy> GetAsync();

        /// <summary>
        /// Gets the specified MacOSCompliancePolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MacOSCompliancePolicy.</returns>
        System.Threading.Tasks.Task<MacOSCompliancePolicy> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified MacOSCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="macOSCompliancePolicyToUpdate">The MacOSCompliancePolicy to update.</param>
        /// <returns>The updated MacOSCompliancePolicy.</returns>
        System.Threading.Tasks.Task<MacOSCompliancePolicy> UpdateAsync(MacOSCompliancePolicy macOSCompliancePolicyToUpdate);

        /// <summary>
        /// Updates the specified MacOSCompliancePolicy using PATCH.
        /// </summary>
        /// <param name="macOSCompliancePolicyToUpdate">The MacOSCompliancePolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MacOSCompliancePolicy.</returns>
        System.Threading.Tasks.Task<MacOSCompliancePolicy> UpdateAsync(MacOSCompliancePolicy macOSCompliancePolicyToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCompliancePolicyRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCompliancePolicyRequest Expand(Expression<Func<MacOSCompliancePolicy, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCompliancePolicyRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IMacOSCompliancePolicyRequest Select(Expression<Func<MacOSCompliancePolicy, object>> selectExpression);

    }
}
