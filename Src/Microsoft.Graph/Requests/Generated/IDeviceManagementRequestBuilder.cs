// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IDeviceManagementRequestBuilder.
    /// </summary>
    public partial interface IDeviceManagementRequestBuilder : IEntityRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IDeviceManagementRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IDeviceManagementRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for TermsAndConditions.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTermsAndConditionsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementTermsAndConditionsCollectionRequestBuilder TermsAndConditions { get; }

        /// <summary>
        /// Gets the request builder for DeviceConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDeviceConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDeviceConfigurationsCollectionRequestBuilder DeviceConfigurations { get; }

        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicies.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDeviceCompliancePoliciesCollectionRequestBuilder DeviceCompliancePolicies { get; }

        /// <summary>
        /// Gets the request builder for SoftwareUpdateStatusSummary.
        /// </summary>
        /// <returns>The <see cref="ISoftwareUpdateStatusSummaryWithReferenceRequestBuilder"/>.</returns>
        ISoftwareUpdateStatusSummaryWithReferenceRequestBuilder SoftwareUpdateStatusSummary { get; }

        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicyDeviceStateSummary.
        /// </summary>
        /// <returns>The <see cref="IDeviceCompliancePolicyDeviceStateSummaryRequestBuilder"/>.</returns>
        IDeviceCompliancePolicyDeviceStateSummaryRequestBuilder DeviceCompliancePolicyDeviceStateSummary { get; }

        /// <summary>
        /// Gets the request builder for DeviceCompliancePolicySettingStateSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDeviceCompliancePolicySettingStateSummariesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDeviceCompliancePolicySettingStateSummariesCollectionRequestBuilder DeviceCompliancePolicySettingStateSummaries { get; }

        /// <summary>
        /// Gets the request builder for DeviceConfigurationDeviceStateSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceConfigurationDeviceStateSummaryRequestBuilder"/>.</returns>
        IDeviceConfigurationDeviceStateSummaryRequestBuilder DeviceConfigurationDeviceStateSummaries { get; }

        /// <summary>
        /// Gets the request builder for IosUpdateStatuses.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementIosUpdateStatusesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementIosUpdateStatusesCollectionRequestBuilder IosUpdateStatuses { get; }

        /// <summary>
        /// Gets the request builder for DeviceCategories.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDeviceCategoriesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDeviceCategoriesCollectionRequestBuilder DeviceCategories { get; }

        /// <summary>
        /// Gets the request builder for ExchangeConnectors.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementExchangeConnectorsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementExchangeConnectorsCollectionRequestBuilder ExchangeConnectors { get; }

        /// <summary>
        /// Gets the request builder for DeviceEnrollmentConfigurations.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDeviceEnrollmentConfigurationsCollectionRequestBuilder DeviceEnrollmentConfigurations { get; }

        /// <summary>
        /// Gets the request builder for ConditionalAccessSettings.
        /// </summary>
        /// <returns>The <see cref="IOnPremisesConditionalAccessSettingsRequestBuilder"/>.</returns>
        IOnPremisesConditionalAccessSettingsRequestBuilder ConditionalAccessSettings { get; }

        /// <summary>
        /// Gets the request builder for MobileThreatDefenseConnectors.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementMobileThreatDefenseConnectorsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementMobileThreatDefenseConnectorsCollectionRequestBuilder MobileThreatDefenseConnectors { get; }

        /// <summary>
        /// Gets the request builder for DeviceManagementPartners.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDeviceManagementPartnersCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDeviceManagementPartnersCollectionRequestBuilder DeviceManagementPartners { get; }

        /// <summary>
        /// Gets the request builder for ApplePushNotificationCertificate.
        /// </summary>
        /// <returns>The <see cref="IApplePushNotificationCertificateRequestBuilder"/>.</returns>
        IApplePushNotificationCertificateRequestBuilder ApplePushNotificationCertificate { get; }

        /// <summary>
        /// Gets the request builder for ManagedDeviceOverview.
        /// </summary>
        /// <returns>The <see cref="IManagedDeviceOverviewWithReferenceRequestBuilder"/>.</returns>
        IManagedDeviceOverviewWithReferenceRequestBuilder ManagedDeviceOverview { get; }

        /// <summary>
        /// Gets the request builder for DetectedApps.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementDetectedAppsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementDetectedAppsCollectionRequestBuilder DetectedApps { get; }

        /// <summary>
        /// Gets the request builder for ManagedDevices.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementManagedDevicesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementManagedDevicesCollectionRequestBuilder ManagedDevices { get; }

        /// <summary>
        /// Gets the request builder for NotificationMessageTemplates.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementNotificationMessageTemplatesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementNotificationMessageTemplatesCollectionRequestBuilder NotificationMessageTemplates { get; }

        /// <summary>
        /// Gets the request builder for RoleDefinitions.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementRoleDefinitionsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementRoleDefinitionsCollectionRequestBuilder RoleDefinitions { get; }

        /// <summary>
        /// Gets the request builder for RoleAssignments.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementRoleAssignmentsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementRoleAssignmentsCollectionRequestBuilder RoleAssignments { get; }

        /// <summary>
        /// Gets the request builder for ResourceOperations.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementResourceOperationsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementResourceOperationsCollectionRequestBuilder ResourceOperations { get; }

        /// <summary>
        /// Gets the request builder for RemoteAssistancePartners.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementRemoteAssistancePartnersCollectionRequestBuilder"/>.</returns>
        IDeviceManagementRemoteAssistancePartnersCollectionRequestBuilder RemoteAssistancePartners { get; }

        /// <summary>
        /// Gets the request builder for TelecomExpenseManagementPartners.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder"/>.</returns>
        IDeviceManagementTelecomExpenseManagementPartnersCollectionRequestBuilder TelecomExpenseManagementPartners { get; }

        /// <summary>
        /// Gets the request builder for TroubleshootingEvents.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementTroubleshootingEventsCollectionRequestBuilder"/>.</returns>
        IDeviceManagementTroubleshootingEventsCollectionRequestBuilder TroubleshootingEvents { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionAppLearningSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementWindowsInformationProtectionAppLearningSummariesCollectionRequestBuilder WindowsInformationProtectionAppLearningSummaries { get; }

        /// <summary>
        /// Gets the request builder for WindowsInformationProtectionNetworkLearningSummaries.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequestBuilder"/>.</returns>
        IDeviceManagementWindowsInformationProtectionNetworkLearningSummariesCollectionRequestBuilder WindowsInformationProtectionNetworkLearningSummaries { get; }
    
        /// <summary>
        /// Gets the request builder for DeviceManagementVerifyWindowsEnrollmentAutoDiscovery.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryRequestBuilder"/>.</returns>
        IDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryRequestBuilder VerifyWindowsEnrollmentAutoDiscovery(
            string domainName = null);

        /// <summary>
        /// Gets the request builder for DeviceManagementGetEffectivePermissions.
        /// </summary>
        /// <returns>The <see cref="IDeviceManagementGetEffectivePermissionsRequestBuilder"/>.</returns>
        IDeviceManagementGetEffectivePermissionsRequestBuilder GetEffectivePermissions(
            string scope = null);
    
    }
}
