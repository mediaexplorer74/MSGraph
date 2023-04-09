// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows81General Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows81GeneralConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The Windows81GeneralConfiguration constructor
		///</summary>
        public Windows81GeneralConfiguration()
        {
            this.ODataType = "microsoft.graph.windows81GeneralConfiguration";
        }
	
        /// <summary>
        /// Gets or sets accounts block adding non microsoft account email.
        /// Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountsBlockAddingNonMicrosoftAccountEmail", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail { get; set; }
    
        /// <summary>
        /// Gets or sets apply only to windows81.
        /// Value indicating whether this policy only applies to Windows 8.1. This property is read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applyOnlyToWindows81", Required = Newtonsoft.Json.Required.Default)]
        public bool? ApplyOnlyToWindows81 { get; set; }
    
        /// <summary>
        /// Gets or sets browser block autofill.
        /// Indicates whether or not to block auto fill.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockAutofill", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockAutofill { get; set; }
    
        /// <summary>
        /// Gets or sets browser block automatic detection of intranet sites.
        /// Indicates whether or not to block automatic detection of Intranet sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockAutomaticDetectionOfIntranetSites", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockAutomaticDetectionOfIntranetSites { get; set; }
    
        /// <summary>
        /// Gets or sets browser block enterprise mode access.
        /// Indicates whether or not to block enterprise mode access.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockEnterpriseModeAccess", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockEnterpriseModeAccess { get; set; }
    
        /// <summary>
        /// Gets or sets browser block java script.
        /// Indicates whether or not to Block the user from using JavaScript.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockJavaScript", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockJavaScript { get; set; }
    
        /// <summary>
        /// Gets or sets browser block plugins.
        /// Indicates whether or not to block plug-ins.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockPlugins", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockPlugins { get; set; }
    
        /// <summary>
        /// Gets or sets browser block popups.
        /// Indicates whether or not to block popups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockPopups", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockPopups { get; set; }
    
        /// <summary>
        /// Gets or sets browser block sending do not track header.
        /// Indicates whether or not to Block the user from sending the do not track header.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockSendingDoNotTrackHeader", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockSendingDoNotTrackHeader { get; set; }
    
        /// <summary>
        /// Gets or sets browser block single word entry on intranet sites.
        /// Indicates whether or not to block a single word entry on Intranet sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserBlockSingleWordEntryOnIntranetSites", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserBlockSingleWordEntryOnIntranetSites { get; set; }
    
        /// <summary>
        /// Gets or sets browser require smart screen.
        /// Indicates whether or not to require the user to use the smart screen filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireSmartScreen", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireSmartScreen { get; set; }
    
        /// <summary>
        /// Gets or sets browser enterprise mode site list location.
        /// The enterprise mode site list location. Could be a local file, local network or http location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserEnterpriseModeSiteListLocation", Required = Newtonsoft.Json.Required.Default)]
        public string BrowserEnterpriseModeSiteListLocation { get; set; }
    
        /// <summary>
        /// Gets or sets browser internet security level.
        /// The internet security level. Possible values are: userDefined, medium, mediumHigh, high.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserInternetSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public InternetSiteSecurityLevel? BrowserInternetSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets browser intranet security level.
        /// The Intranet security level. Possible values are: userDefined, low, mediumLow, medium, mediumHigh, high.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserIntranetSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public SiteSecurityLevel? BrowserIntranetSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets browser logging report location.
        /// The logging report location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserLoggingReportLocation", Required = Newtonsoft.Json.Required.Default)]
        public string BrowserLoggingReportLocation { get; set; }
    
        /// <summary>
        /// Gets or sets browser require high security for restricted sites.
        /// Indicates whether or not to require high security for restricted sites.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireHighSecurityForRestrictedSites", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireHighSecurityForRestrictedSites { get; set; }
    
        /// <summary>
        /// Gets or sets browser require firewall.
        /// Indicates whether or not to require a firewall.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireFirewall", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireFirewall { get; set; }
    
        /// <summary>
        /// Gets or sets browser require fraud warning.
        /// Indicates whether or not to require fraud warning.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserRequireFraudWarning", Required = Newtonsoft.Json.Required.Default)]
        public bool? BrowserRequireFraudWarning { get; set; }
    
        /// <summary>
        /// Gets or sets browser trusted sites security level.
        /// The trusted sites security level. Possible values are: userDefined, low, mediumLow, medium, mediumHigh, high.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "browserTrustedSitesSecurityLevel", Required = Newtonsoft.Json.Required.Default)]
        public SiteSecurityLevel? BrowserTrustedSitesSecurityLevel { get; set; }
    
        /// <summary>
        /// Gets or sets cellular block data roaming.
        /// Indicates whether or not to block data roaming.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cellularBlockDataRoaming", Required = Newtonsoft.Json.Required.Default)]
        public bool? CellularBlockDataRoaming { get; set; }
    
        /// <summary>
        /// Gets or sets diagnostics block data submission.
        /// Indicates whether or not to block diagnostic data submission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "diagnosticsBlockDataSubmission", Required = Newtonsoft.Json.Required.Default)]
        public bool? DiagnosticsBlockDataSubmission { get; set; }
    
        /// <summary>
        /// Gets or sets password block picture password and pin.
        /// Indicates whether or not to Block the user from using a pictures password and pin.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordBlockPicturePasswordAndPin", Required = Newtonsoft.Json.Required.Default)]
        public bool? PasswordBlockPicturePasswordAndPin { get; set; }
    
        /// <summary>
        /// Gets or sets password expiration days.
        /// Password expiration in days.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordExpirationDays", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordExpirationDays { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum length.
        /// The minimum password length.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumLength { get; set; }
    
        /// <summary>
        /// Gets or sets password minutes of inactivity before screen timeout.
        /// The minutes of inactivity before the screen times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinutesOfInactivityBeforeScreenTimeout", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
    
        /// <summary>
        /// Gets or sets password minimum character set count.
        /// The number of character sets required in the password.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordMinimumCharacterSetCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordMinimumCharacterSetCount { get; set; }
    
        /// <summary>
        /// Gets or sets password previous password block count.
        /// The number of previous passwords to prevent re-use of. Valid values 0 to 24
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPreviousPasswordBlockCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordPreviousPasswordBlockCount { get; set; }
    
        /// <summary>
        /// Gets or sets password required type.
        /// The required password type. Possible values are: deviceDefault, alphanumeric, numeric.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordRequiredType", Required = Newtonsoft.Json.Required.Default)]
        public RequiredPasswordType? PasswordRequiredType { get; set; }
    
        /// <summary>
        /// Gets or sets password sign in failure count before factory reset.
        /// The number of sign in failures before factory reset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordSignInFailureCountBeforeFactoryReset", Required = Newtonsoft.Json.Required.Default)]
        public Int32? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
    
        /// <summary>
        /// Gets or sets storage require device encryption.
        /// Indicates whether or not to require encryption on a mobile device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "storageRequireDeviceEncryption", Required = Newtonsoft.Json.Required.Default)]
        public bool? StorageRequireDeviceEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets updates require automatic updates.
        /// Indicates whether or not to require automatic updates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "updatesRequireAutomaticUpdates", Required = Newtonsoft.Json.Required.Default)]
        public bool? UpdatesRequireAutomaticUpdates { get; set; }
    
        /// <summary>
        /// Gets or sets user account control settings.
        /// The user account control settings. Possible values are: userDefined, alwaysNotify, notifyOnAppChanges, notifyOnAppChangesWithoutDimming, neverNotify.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userAccountControlSettings", Required = Newtonsoft.Json.Required.Default)]
        public WindowsUserAccountControlSettings? UserAccountControlSettings { get; set; }
    
        /// <summary>
        /// Gets or sets work folders url.
        /// The work folders url.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "workFoldersUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WorkFoldersUrl { get; set; }
    
    }
}

