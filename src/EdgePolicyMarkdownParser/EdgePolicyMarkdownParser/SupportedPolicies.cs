namespace EdgePolicyMarkdownParser;

public static class SupportedPolicies
{
	static Dictionary<string, bool> _supportedPolicies = new Dictionary<string, bool>()
	{
        // Application Guard settings
        { "ApplicationGuardContainerProxy", true },
		{ "ApplicationGuardFavoritesSyncEnabled", true },
		{ "ApplicationGuardPassiveModeEnabled", true },
		{ "ApplicationGuardTrafficIdentificationEnabled", true },
		{ "ApplicationGuardUploadBlockingEnabled", true },

        // Cast
        { "EdgeDisableDialProtocolForCastDiscovery", true },
		{ "EnableMediaRouter", true },
		{ "ShowCastIconInToolbar", true },

        // Certificate management settings
        { "CACertificateManagementAllowed", true },
		{ "CACertificates", true },
		{ "CACertificatesWithConstraints", true },
		{ "CADistrustedCertificates", true },
		{ "CAHintCertificates", true },
		{ "CAPlatformIntegrationEnabled", true },

        // Content settings
        { "AutoSelectCertificateForUrls", true },
		{ "AutomaticDownloadsAllowedForUrls", true },
		{ "AutomaticDownloadsBlockedForUrls", true },
		{ "AutomaticFullscreenAllowedForUrls", true },
		{ "AutomaticFullscreenBlockedForUrls", true },
		{ "CookiesAllowedForUrls", true },
		{ "CookiesBlockedForUrls", true },
		{ "CookiesSessionOnlyForUrls", true },
		{ "DataUrlInSvgUseEnabled", true },
		{ "DefaultAutomaticDownloadsSetting", true },
		{ "DefaultCookiesSetting", true },
		{ "DefaultFileSystemReadGuardSetting", true },
		{ "DefaultFileSystemWriteGuardSetting", true },
		{ "DefaultGeolocationSetting", true },
		{ "DefaultImagesSetting", true },
		{ "DefaultInsecureContentSetting", true },
		{ "DefaultJavaScriptJitSetting", true },
		{ "DefaultJavaScriptOptimizerSetting", true },
		{ "DefaultJavaScriptSetting", true },
		{ "DefaultNotificationsSetting", true },
		{ "DefaultPluginsSetting", true },
		{ "DefaultPopupsSetting", true },
		{ "DefaultThirdPartyStoragePartitioningSetting", true },
		{ "DefaultWebBluetoothGuardSetting", true },
		{ "DefaultWebHidGuardSetting", true },
		{ "DefaultWebUsbGuardSetting", true },
		{ "DefaultWindowManagementSetting", true },
		{ "FileSystemReadAskForUrls", true },
		{ "FileSystemReadBlockedForUrls", true },
		{ "FileSystemWriteAskForUrls", true },
		{ "FileSystemWriteBlockedForUrls", true },
		{ "ImagesAllowedForUrls", true },
		{ "ImagesBlockedForUrls", true },
		{ "InsecureContentAllowedForUrls", true },
		{ "InsecureContentBlockedForUrls", true },
		{ "IntranetFileLinksEnabled", true },
		{ "JavaScriptAllowedForUrls", true },
		{ "JavaScriptBlockedForUrls", true },
		{ "JavaScriptJitAllowedForSites", true },
		{ "JavaScriptJitBlockedForSites", true },
		{ "JavaScriptOptimizerAllowedForSites", true },
		{ "JavaScriptOptimizerBlockedForSites", true },
		{ "LegacySameSiteCookieBehaviorEnabled", true },
		{ "LegacySameSiteCookieBehaviorEnabledForDomainList", true },
		{ "NotificationsAllowedForUrls", true },
		{ "NotificationsBlockedForUrls", true },
		{ "PartitionedBlobUrlUsage", true },
		{ "PluginsAllowedForUrls", true },
		{ "PluginsBlockedForUrls", true },
		{ "PopupsAllowedForUrls", true },
		{ "PopupsBlockedForUrls", true },
		{ "RegisteredProtocolHandlers", true },
		{ "SerialAllowAllPortsForUrls", true },
		{ "SerialAllowUsbDevicesForUrls", true },
		{ "ShowPDFDefaultRecommendationsEnabled", true },
		{ "SpotlightExperiencesAndRecommendationsEnabled", true },
		{ "ThirdPartyStoragePartitioningBlockedForOrigins", true },
		{ "WebHidAllowAllDevicesForUrls", true },
		{ "WebHidAllowDevicesForUrls", true },
		{ "WebHidAllowDevicesWithHidUsagesForUrls", true },
		{ "WebHidAskForUrls", true },
		{ "WebHidBlockedForUrls", true },
		{ "WebUsbAllowDevicesForUrls", true },
		{ "WebUsbAskForUrls", true },
		{ "WebUsbBlockedForUrls", true },
		{ "WindowManagementAllowedForUrls", true },
		{ "WindowManagementBlockedForUrls", true },
        // Default search provider
        { "DefaultSearchProviderEnabled", true },
		{ "DefaultSearchProviderEncodings", true },
		{ "DefaultSearchProviderImageURL", true },
		{ "DefaultSearchProviderImageURLPostParams", true },
		{ "DefaultSearchProviderKeyword", true },
		{ "DefaultSearchProviderName", true },
		{ "DefaultSearchProviderSearchURL", true },
		{ "DefaultSearchProviderSuggestURL", true },
		{ "NewTabPageSearchBox", true },

        // Downloads
        { "ShowDownloadsInsecureWarningsEnabled", true },

        // Edge Website Typo Protection settings
        { "PreventTyposquattingPromptOverride", true },
		{ "TyposquattingAllowListDomains", true },
		{ "TyposquattingCheckerEnabled", true },

        // Edge Workspaces settings
        { "EdgeWorkspacesEnabled", true },
		{ "WorkspacesNavigationSettings", true },

        // Experimentation
        { "FeatureFlagOverridesControl", true },

        // Extensions
        { "BlockExternalExtensions", true },
		{ "ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled", true },
		{ "ExtensionAllowedTypes", true },
		{ "ExtensionDeveloperModeSettings", true },
		{ "ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls", true },
		{ "ExtensionInstallAllowlist", true },
		{ "ExtensionInstallBlocklist", true },
		{ "ExtensionInstallForcelist", true },
		{ "ExtensionInstallSources", true },
		{ "ExtensionInstallTypeBlocklist", true },
		{ "ExtensionManifestV2Availability", true },
		{ "ExtensionSettings", true },

        // Games settings
        { "GamerModeEnabled", true },

        // Generative AI
        { "GenAILocalFoundationalModelSettings", true },

        // HTTP authentication
        { "AllHttpAuthSchemesAllowedForOrigins", true },
		{ "AllowCrossOriginAuthPrompt", true },
		{ "AuthNegotiateDelegateAllowlist", true },
		{ "AuthSchemes", true },
		{ "AuthServerAllowlist", true },
		{ "BasicAuthOverHttpEnabled", true },
		{ "DisableAuthNegotiateCnameLookup", true },
		{ "EnableAuthNegotiatePort", true },
		{ "NtlmV2Enabled", true },
		{ "WindowsHelloForHTTPAuthEnabled", true },

        // Identity and sign-in
        { "AutomaticProfileSwitchingSiteList", true },
		{ "EdgeDefaultProfileEnabled", true },
		{ "GuidedSwitchEnabled", true },
		{ "ImplicitSignInEnabled", true },
		{ "LinkedAccountEnabled", true },
		{ "OneAuthAuthenticationEnforced", true },
		{ "OnlyOnPremisesImplicitSigninEnabled", true },
		{ "ProactiveAuthWorkflowEnabled", true },
		{ "SeamlessWebToBrowserSignInEnabled", true },
		{ "SignInCtaOnNtpEnabled", true },
		{ "SwitchIntranetSitesToWorkProfile", true },
		{ "SwitchSitesOnIEModeSiteListToWorkProfile", true },
		{ "WAMAuthBelowWin10RS3Enabled", true },
		{ "WebToBrowserSignInEnabled", true },

        // Idle Browser Actions
		{ "IdleTimeout", true },
		{ "IdleTimeoutActions", true },

        // Immersive Reader settings
        { "ImmersiveReaderGrammarToolsEnabled", true },
		{ "ImmersiveReaderPictureDictionaryEnabled", true },

        // Kiosk Mode settings
        { "KioskAddressBarEditingEnabled", true },
		{ "KioskDeleteDownloadsOnExit", true },
		{ "KioskSwipeGesturesEnabled", true },

        // Manageability
        { "EdgeManagementEnabled", true },
		{ "EdgeManagementEnrollmentToken", true },
		{ "EdgeManagementExtensionsFeedbackEnabled", true },
		{ "EdgeManagementPolicyOverridesPlatformPolicy", true },
		{ "EdgeManagementUserPolicyOverridesCloudMachinePolicy", true },
		{ "MAMEnabled", true },

        // Native Messaging
        { "NativeMessagingAllowlist", true },
		{ "NativeMessagingBlocklist", true },
		{ "NativeMessagingUserLevelHosts", true },

        // Network settings
        { "AccessControlAllowMethodsInCORSPreflightSpecConformant", true },
		{ "BlockTruncatedCookies", true },
		{ "CompressionDictionaryTransportEnabled", true },
		{ "DataURLWhitespacePreservationEnabled", true },
		{ "IPv6ReachabilityOverrideEnabled", true },
		{ "ZstdContentEncodingEnabled", true },

        // PDF Reader
        { "ViewXFAPDFInIEModeAllowedFileHash", true },
		{ "ViewXFAPDFInIEModeAllowedOrigins", true },

        // Password manager and protection
        { "DeletingUndecryptablePasswordsEnabled", true },
		{ "PasswordDeleteOnBrowserCloseEnabled", true },
		{ "PasswordExportEnabled", true },
		{ "PasswordGeneratorEnabled", true },
		{ "PasswordManagerBlocklist", true },
		{ "PasswordManagerEnabled", true },
		{ "PasswordManagerRestrictLengthEnabled", true },
		{ "PasswordMonitorAllowed", true },
		{ "PasswordProtectionChangePasswordURL", true },
		{ "PasswordProtectionLoginURLs", true },
		{ "PasswordProtectionWarningTrigger", true },
		{ "PasswordRevealEnabled", true },
		{ "PrimaryPasswordSetting", true },

        // Performance
        { "EfficiencyMode", true },
		{ "EfficiencyModeEnabled", true },
		{ "EfficiencyModeOnPowerEnabled", true },
		{ "ExtensionsPerformanceDetectorEnabled", true },
		{ "PerformanceDetectorEnabled", true },
		{ "PinBrowserEssentialsToolbarButton", true },
		{ "StartupBoostEnabled", true },

        // Permit or deny screen capture
        { "SameOriginTabCaptureAllowedByOrigins", true },
		{ "ScreenCaptureAllowedByOrigins", true },
		{ "TabCaptureAllowedByOrigins", true },
		{ "WindowCaptureAllowedByOrigins", true },

        // Printing
        { "DefaultPrinterSelection", true },
		{ "OopPrintDriversAllowed", true },
		{ "PrintHeaderFooter", true },
		{ "PrintPdfAsImageDefault", true },
		{ "PrintPostScriptMode", true },
		{ "PrintPreviewStickySettings", true },
		{ "PrintPreviewUseSystemDefaultPrinter", true },
		{ "PrintRasterizationMode", true },
		{ "PrintRasterizePdfDpi", true },
		{ "PrintStickySettings", true },
		{ "PrinterTypeDenyList", true },
		{ "PrintingAllowedBackgroundGraphicsModes", true },
		{ "PrintingBackgroundGraphicsDefault", true },
		{ "PrintingEnabled", true },
		{ "PrintingLPACSandboxEnabled", true },
		{ "PrintingPaperSizeDefault", true },
		{ "PrintingWebpageLayout", true },
		{ "UseSystemPrintDialog", true },

        // Private Network Request Settings
        { "InsecurePrivateNetworkRequestsAllowed", true },
		{ "InsecurePrivateNetworkRequestsAllowedForUrls", true },
		{ "PrivateNetworkAccessRestrictionsEnabled", true },

		// Profile settings
		{ "ProfileTypeInProfileButtonEnabled", true },

        // Proxy server
        { "ProxyBypassList", true },
		{ "ProxyMode", true },
		{ "ProxyPacUrl", true },
		{ "ProxyServer", true },
		{ "ProxySettings", true },

        // Related Website Sets Settings
        { "RelatedWebsiteSetsEnabled", true },
		{ "RelatedWebsiteSetsOverrides", true },

		// Scareware Blocker settings
		{ "ScarewareBlockerProtectionEnabled", true },

        // Sleeping tabs settings
        { "AutoDiscardSleepingTabsEnabled", true },
		{ "SleepingTabsBlockedForUrls", true },
		{ "SleepingTabsEnabled", true },
		{ "SleepingTabsTimeout", true },

        // SmartScreen settings
        { "ExemptSmartScreenDownloadWarnings", true },
		{ "NewSmartScreenLibraryEnabled", true },
		{ "PreventSmartScreenPromptOverride", true },
		{ "PreventSmartScreenPromptOverrideForFiles", true },
		{ "SmartScreenAllowListDomains", true },
		{ "SmartScreenDnsRequestsEnabled", true },
		{ "SmartScreenEnabled", true },
		{ "SmartScreenForTrustedDownloadsEnabled", true },
		{ "SmartScreenPuaEnabled", true },

		// Startup, home page and new tab page
		{ "HomepageIsNewTabPage", true },
		{ "HomepageLocation", true },
		{ "NewTabPageAllowedBackgroundTypes", true },
		{ "NewTabPageAppLauncherEnabled", true },
		{ "NewTabPageBingChatEnabled", true },
		{ "NewTabPageCompanyLogo", true },
		{ "NewTabPageCompanyLogoBackplateColor", true },
		{ "NewTabPageCompanyLogoEnabled", true },
		{ "NewTabPageContentEnabled", true },
		{ "NewTabPageHideDefaultTopSites", true },
		{ "NewTabPageLocation", true },
		{ "NewTabPageManagedQuickLinks", true },
		{ "NewTabPagePrerenderEnabled", true },
		{ "NewTabPageQuickLinksEnabled", true },
		{ "NewTabPageSetFeedType", true },
		{ "RestoreOnStartup", true },
		{ "RestoreOnStartupURLs", true },
		{ "RestoreOnStartupUserURLsEnabled", true },
		{ "ShowHomeButton", true },

		// WebRtc settings
		{ "WebRtcIPHandlingUrl", true },
		{ "WebRtcLocalhostIpHandling", true },

        // Additional
        { "AADWebSiteSSOUsingThisProfileEnabled", true },
		{ "AIGenThemesEnabled", true },
		{ "AccessibilityImageLabelsEnabled", true },
		{ "AdHocCodeSigningForPWAsEnabled", true },
		{ "AdditionalSearchBoxEnabled", true },
		{ "AddressBarEditingEnabled", true },
		{ "AddressBarMicrosoftSearchInBingProviderEnabled", true },
		{ "AddressBarTrendingSuggestEnabled", true },
		{ "AddressBarWorkSearchResultsEnabled", true },
		{ "AdsSettingForIntrusiveAdsSites", true },
		{ "AdsTransparencyEnabled", true },
		{ "AllowBackForwardCacheForCacheControlNoStorePageEnabled", true },
		{ "AllowDeletingBrowserHistory", true },
		{ "AllowFileSelectionDialogs", true },
		{ "AllowGamesMenu", true },
		{ "AllowPopupsDuringPageUnload", true },
		{ "AllowSurfGame", true },
		{ "AllowSyncXHRInPageDismissal", true },
		{ "AllowSystemNotifications", true },
		{ "AllowTokenBindingForUrls", true },
		{ "AllowTrackingForUrls", true },
		{ "AllowWebAuthnWithBrokenTlsCerts", true },
		{ "AllowedDomainsForApps", true },
		{ "AlternateErrorPagesEnabled", true },
		{ "AlwaysOpenPdfExternally", true },
		{ "AmbientAuthenticationInPrivateModesEnabled", true },
		{ "AppCacheForceEnabled", true },
		{ "ApplicationBoundEncryptionEnabled", true },
		{ "ApplicationLocaleValue", true },
		{ "AskBeforeCloseEnabled", true },
		{ "AudioCaptureAllowed", true },
		{ "AudioCaptureAllowedUrls", true },
		{ "AudioProcessHighPriorityEnabled", true },
		{ "AudioSandboxEnabled", true },
		{ "AutoImportAtFirstRun", true },
		{ "AutoLaunchProtocolsComponentEnabled", true },
		{ "AutoLaunchProtocolsFromOrigins", true },
		{ "AutoOpenAllowedForURLs", true },
		{ "AutoOpenFileTypes", true },
		{ "AutofillAddressEnabled", true },
		{ "AutofillCreditCardEnabled", true },
		{ "AutofillMembershipsEnabled", true },
		{ "AutomaticHttpsDefault", true },
		{ "AutoplayAllowed", true },
		{ "AutoplayAllowlist", true },
		{ "BackgroundModeEnabled", true },
		{ "BackgroundTemplateListUpdatesEnabled", true },
		{ "BeforeunloadEventCancelByPreventDefaultEnabled", true },
		{ "BingAdsSuppression", true },
		{ "BlockThirdPartyCookies", true },
		{ "BrowserAddProfileEnabled", true },
		{ "BrowserCodeIntegritySetting", true },
		{ "BrowserGuestModeEnabled", true },
		{ "BrowserLegacyExtensionPointsBlockingEnabled", true },
		{ "BrowserNetworkTimeQueriesEnabled", true },
		{ "BrowserSignin", true },
		{ "BrowsingDataLifetime", true },
		{ "BuiltInDnsClientEnabled", true },
		{ "BuiltinCertificateVerifierEnabled", true },
		{ "CECPQ2Enabled", true },
		{ "CORSNonWildcardRequestHeadersSupport", true },
		{ "CSSCustomStateDeprecatedSyntaxEnabled", true },
		{ "CertificateTransparencyEnforcementDisabledForCas", true },
		{ "CertificateTransparencyEnforcementDisabledForLegacyCas", true },
		{ "CertificateTransparencyEnforcementDisabledForUrls", true },
		{ "ClearBrowsingDataOnExit", true },
		{ "ClearCachedImagesAndFilesOnExit", true },
		{ "ClickOnceEnabled", true },
		{ "ClipboardAllowedForUrls", true },
		{ "ClipboardBlockedForUrls", true },
		{ "CollectionsServicesAndExportsBlockList", true },
		{ "CommandLineFlagSecurityWarningsEnabled", true },
		{ "ComponentUpdatesEnabled", true },
		{ "ComposeInlineEnabled", true },
		{ "ConfigureDoNotTrack", true },
		{ "ConfigureFriendlyURLFormat", true },
		{ "ConfigureKeyboardShortcuts", true },
		{ "ConfigureOnPremisesAccountAutoSignIn", true },
		{ "ConfigureOnlineTextToSpeech", true },
		{ "ConfigureShare", true },
		{ "ConfigureViewInFileExplorer", true },
		{ "CopilotCDPPageContext", true },
		{ "CopilotPageContext", true },
		{ "CreatePasskeysInICloudKeychain", true },
		{ "CrossOriginWebAssemblyModuleSharingEnabled", true },
		{ "CryptoWalletEnabled", true },
		{ "CustomHelpLink", true },
		{ "DNSInterceptionChecksEnabled", true },
		{ "DefaultBrowserSettingEnabled", true },
		{ "DefaultBrowserSettingsCampaignEnabled", true },
		{ "DefaultClipboardSetting", true },
		{ "DefaultSearchProviderContextMenuAccessAllowed", true },
		{ "DefaultSensorsSetting", true },
		{ "DefaultSerialGuardSetting", true },
		{ "DefaultShareAdditionalOSRegionSetting", true },
		{ "DefinePreferredLanguages", true },
		{ "DelayNavigationsForInitialSiteListDownload", true },
		{ "DeleteDataOnMigration", true },
		{ "DeveloperToolsAvailability", true },
		{ "DiagnosticData", true },
		{ "DirectInvokeEnabled", true },
		{ "Disable3DAPIs", true },
		{ "DisableScreenshots", true },
		{ "DiscoverPageContextEnabled", true },
		{ "DiskCacheDir", true },
		{ "DiskCacheSize", true },
		{ "DisplayCapturePermissionsPolicyEnabled", true },
		{ "DnsOverHttpsMode", true },
		{ "DnsOverHttpsTemplates", true },
		{ "DoNotSilentlyBlockProtocolsFromOrigins", true },
		{ "DoubleClickCloseTabEnabled", true },
		{ "DownloadDirectory", true },
		{ "DownloadRestrictions", true },
		{ "DynamicCodeSettings", true },
		{ "Edge3PSerpTelemetryEnabled", true },
		{ "EdgeAssetDeliveryServiceEnabled", true },
		{ "EdgeAutofillMlEnabled", true },
		{ "EdgeCollectionsEnabled", true },
		{ "EdgeDiscoverEnabled", true },
		{ "EdgeEDropEnabled", true },
		{ "EdgeEnhanceImagesEnabled", true },
		{ "EdgeEntraCopilotPageContext", true },
		{ "EdgeFollowEnabled", true },
		{ "EdgeOpenInSidebarEnabled", true },
		{ "EdgeShoppingAssistantEnabled", true },
		{ "EdgeSidebarAppUrlHostAllowList", true },
		{ "EdgeSidebarAppUrlHostBlockList", true },
		{ "EdgeSidebarAppUrlHostForceList", true },
		{ "EdgeSidebarCustomizeEnabled", true },
		{ "EdgeWalletCheckoutEnabled", true },
		{ "EdgeWalletEtreeEnabled", true },
		{ "EditFavoritesEnabled", true },
		{ "EnableDeprecatedWebPlatformFeatures", true },
		{ "EnableDomainActionsDownload", true },
		{ "EnableOnlineRevocationChecks", true },
		{ "EnableSha1ForLocalAnchors", true },
		{ "EncryptedClientHelloEnabled", true },
		{ "EnforceLocalAnchorConstraintsEnabled", true },
		{ "EnhanceSecurityMode", true },
		{ "EnhanceSecurityModeAllowUserBypass", true },
		{ "EnhanceSecurityModeBypassIntranet", true },
		{ "EnhanceSecurityModeBypassListDomains", true },
		{ "EnhanceSecurityModeEnforceListDomains", true },
		{ "EnhanceSecurityModeIndicatorUIEnabled", true },
		{ "EnhanceSecurityModeOptOutUXEnabled", true },
		{ "EnterpriseHardwarePlatformAPIEnabled", true },
		{ "EnterpriseModeSiteListManagerAllowed", true },
		{ "EventPathEnabled", true },
		{ "ExemptDomainFileTypePairsFromFileTypeDownloadWarnings", true },
		{ "ExemptFileTypeDownloadWarnings", true },
		{ "ExperimentationAndConfigurationServiceControl", true },
		{ "ExplicitlyAllowedNetworkPorts", true },
		{ "ExternalProtocolDialogShowAlwaysOpenCheckbox", true },
		{ "FamilySafetySettingsEnabled", true },
		{ "FavoritesBarEnabled", true },
		{ "FetchKeepaliveDurationSecondsOnShutdown", true },
		{ "FileOrDirectoryPickerWithoutGestureAllowedForOrigins", true },
		{ "ForceBingSafeSearch", true },
		{ "ForceBuiltInPushMessagingClient", true },
		{ "ForceCertificatePromptsOnMultipleMatches", true },
		{ "ForceEphemeralProfiles", true },
		{ "ForceGoogleSafeSearch", true },
		{ "ForceLegacyDefaultReferrerPolicy", true },
		{ "ForceMajorVersionToMinorPositionInUserAgent", true },
		{ "ForceNetworkInProcess", true },
		{ "ForcePermissionPolicyUnloadDefaultEnabled", true },
		{ "ForceSync", true },
		{ "ForceSyncTypes", true },
		{ "ForceYouTubeRestrict", true },
		{ "FullscreenAllowed", true },
		{ "GloballyScopeHTTPAuthCacheEnabled", true },
		{ "GoToIntranetSiteForSingleWordEntryInAddressBar", true },
		{ "HSTSPolicyBypassList", true },
		{ "HardwareAccelerationModeEnabled", true },
		{ "HeadlessModeEnabled", true },
		{ "HideFirstRunExperience", true },
		{ "HideInternetExplorerRedirectUXForIncompatibleSitesEnabled", true },
		{ "HideRestoreDialogEnabled", true },
		{ "HttpAllowlist", true },
		{ "HttpsUpgradesEnabled", true },
		{ "HubsSidebarEnabled", true },
		{ "ImportAutofillFormData", true },
		{ "ImportBrowserSettings", true },
		{ "ImportCookies", true },
		{ "ImportExtensions", true },
		{ "ImportFavorites", true },
		{ "ImportHistory", true },
		{ "ImportHomepage", true },
		{ "ImportOnEachLaunch", true },
		{ "ImportOpenTabs", true },
		{ "ImportPaymentInfo", true },
		{ "ImportSavedPasswords", true },
		{ "ImportSearchEngine", true },
		{ "ImportShortcuts", true },
		{ "ImportStartupPageSettings", true },
		{ "InAppSupportEnabled", true },
		{ "InPrivateModeAvailability", true },
		{ "InsecureFormsWarningsEnabled", true },
		{ "IntensiveWakeUpThrottlingEnabled", true },
		{ "InternetExplorerIntegrationAlwaysUseOSCapture", true },
		{ "InternetExplorerIntegrationAlwaysWaitForUnload", true },
		{ "InternetExplorerIntegrationCloudNeutralSitesReporting", true },
		{ "InternetExplorerIntegrationCloudSiteList", true },
		{ "InternetExplorerIntegrationCloudUserSitesReporting", true },
		{ "InternetExplorerIntegrationComplexNavDataTypes", true },
		{ "InternetExplorerIntegrationEnhancedHangDetection", true },
		{ "InternetExplorerIntegrationLevel", true },
		{ "InternetExplorerIntegrationLocalFileAllowed", true },
		{ "InternetExplorerIntegrationLocalFileExtensionAllowList", true },
		{ "InternetExplorerIntegrationLocalFileShowContextMenu", true },
		{ "InternetExplorerIntegrationLocalMhtFileAllowed", true },
		{ "InternetExplorerIntegrationLocalSiteListExpirationDays", true },
		{ "InternetExplorerIntegrationReloadInIEModeAllowed", true },
		{ "InternetExplorerIntegrationSiteList", true },
		{ "InternetExplorerIntegrationSiteListRefreshInterval", true },
		{ "InternetExplorerIntegrationSiteRedirect", true },
		{ "InternetExplorerIntegrationTestingAllowed", true },
		{ "InternetExplorerIntegrationWindowOpenHeightAdjustment", true },
		{ "InternetExplorerIntegrationWindowOpenWidthAdjustment", true },
		{ "InternetExplorerIntegrationZoneIdentifierMhtFileAllowed", true },
		{ "InternetExplorerModeClearDataOnExitEnabled", true },
		{ "InternetExplorerModeEnableSavePageAs", true },
		{ "InternetExplorerModeTabInEdgeModeAllowed", true },
		{ "InternetExplorerModeToolbarButtonEnabled", true },
		{ "InternetExplorerSetForegroundWhenActive", true },
		{ "InternetExplorerZoomDisplay", true },
		{ "IntranetRedirectBehavior", true },
		{ "IsolateOrigins", true },
		{ "KeyboardFocusableScrollersEnabled", true },
		{ "LiveCaptionsAllowed", true },
        // { "LiveTranslationAllowed", true }, // Removed: https://github.com/MicrosoftDocs/Edge-Enterprise/commit/8976938f1392e151f363097fae7dfac9384a66a9
        { "LocalBrowserDataShareEnabled", true },
		{ "LocalProvidersEnabled", true },
		{ "MAUEnabled", true },
		{ "MSAWebSiteSSOUsingThisProfileAllowed", true },
		{ "ManagedConfigurationPerOrigin", true },
		{ "ManagedFavorites", true },
		{ "ManagedSearchEngines", true },
		{ "MathSolverEnabled", true },
		{ "MaxConnectionsPerProxy", true },
		{ "MediaRouterCastAllowAllIPs", true },
		{ "MetricsReportingEnabled", true },
		{ "MicrosoftEdgeInsiderPromotionEnabled", true },
		{ "MicrosoftEditorProofingEnabled", true },
		{ "MicrosoftEditorSynonymsEnabled", true },
		{ "MicrosoftOfficeMenuEnabled", true },
		{ "MicrosoftRootStoreEnabled", true },
		{ "MouseGestureEnabled", true },
		{ "MutationEventsEnabled", true },
		{ "NativeHostsExecutablesLaunchDirectly", true },
		{ "NativeWindowOcclusionEnabled", true },
		{ "NavigationDelayForInitialSiteListDownloadTimeout", true },
		{ "NetworkPredictionOptions", true },
		{ "NetworkServiceSandboxEnabled", true },
		{ "NewBaseUrlInheritanceBehaviorAllowed", true },
		{ "NewPDFReaderEnabled", true },
		{ "NonRemovableProfileEnabled", true },
		{ "OrganizationLogoOverlayOnAppIconEnabled", true },
		{ "OrganizationalBrandingOnWorkProfileUIEnabled", true },
		{ "OriginAgentClusterDefaultEnabled", true },
		{ "OutlookHubMenuEnabled", true },
		{ "OverrideSecurityRestrictionsOnInsecureOrigin", true },
		{ "PDFSecureMode", true },
		{ "PDFXFAEnabled", true },
		{ "PaymentMethodQueryEnabled", true },
		{ "PdfViewerOutOfProcessIframeEnabled", true },
		{ "PersonalizationReportingEnabled", true },
		{ "PersonalizeTopSitesInCustomizeSidebarEnabled", true },
		{ "PictureInPictureOverlayEnabled", true },
		{ "PinningWizardAllowed", true },
		{ "PostQuantumKeyAgreementEnabled", true },
		{ "ProactiveAuthEnabled", true },
		{ "PromotionalTabsEnabled", true },
		{ "PromptForDownloadLocation", true },
		{ "PromptOnMultipleMatchingCertificates", true },
		{ "QRCodeGeneratorEnabled", true },
		{ "QuicAllowed", true },
		{ "QuickSearchShowMiniMenu", true },
		{ "QuickViewOfficeFilesEnabled", true },
		{ "RSAKeyUsageForLocalAnchorsEnabled", true },
		{ "ReadAloudEnabled", true },
		{ "RedirectSitesFromInternetExplorerPreventBHOInstall", true },
		{ "RedirectSitesFromInternetExplorerRedirectMode", true },
		{ "RelatedMatchesCloudServiceEnabled", true },
		{ "RelaunchNotification", true },
		{ "RelaunchNotificationPeriod", true },
		{ "RelaunchWindow", true },
		{ "RemoteDebuggingAllowed", true },
		{ "RendererAppContainerEnabled", true },
		{ "RendererCodeIntegrityEnabled", true },
		{ "RequireOnlineRevocationChecksForLocalAnchors", true },
		{ "ResolveNavigationErrorsUseWebService", true },
		{ "RestorePdfView", true },
		{ "RestrictSigninToPattern", true },
		{ "RoamingProfileLocation", true },
		{ "RoamingProfileSupportEnabled", true },
		{ "RunAllFlashInAllowMode", true },
		{ "SSLErrorOverrideAllowed", true },
		{ "SSLErrorOverrideAllowedForOrigins", true },
		{ "SSLVersionMin", true },
		{ "SandboxExternalProtocolBlocked", true },
		{ "SaveCookiesOnExit", true },
		{ "SavingBrowserHistoryDisabled", true },
		{ "ScreenCaptureAllowed", true },
		{ "ScreenCaptureWithoutGestureAllowedForOrigins", true },
		{ "ScrollToTextFragmentEnabled", true },
		{ "SearchFiltersEnabled", true },
		{ "SearchForImageEnabled", true },
		{ "SearchInSidebarEnabled", true },
		{ "SearchSuggestEnabled", true },
		{ "SearchbarAllowed", true },
		{ "SearchbarIsEnabledOnStartup", true },
		{ "SecurityKeyPermitAttestation", true },
		{ "SelectParserRelaxationEnabled", true },
		{ "SendIntranetToInternetExplorer", true },
		{ "SendMouseEventsDisabledFormControlsEnabled", true },
		{ "SendSiteInfoToImproveServices", true },
		{ "SensorsAllowedForUrls", true },
		{ "SensorsBlockedForUrls", true },
		{ "SerialAskForUrls", true },
		{ "SerialBlockedForUrls", true },
		{ "ServiceWorkerToControlSrcdocIframeEnabled", true },
		{ "SetTimeoutWithout1MsClampEnabled", true },
		{ "ShadowStackCrashRollbackBehavior", true },
		{ "SharedArrayBufferUnrestrictedAccessAllowed", true },
		{ "SharedLinksEnabled", true },
		{ "SharedWorkerBlobURLFixEnabled", true },
		{ "ShowAcrobatSubscriptionButton", true },
		{ "ShowDownloadsToolbarButton", true },
		{ "ShowHistoryThumbnails", true },
		{ "ShowMicrosoftRewards", true },
		{ "ShowOfficeShortcutInFavoritesBar", true },
		{ "ShowRecommendationsEnabled", true },
		{ "SignedHTTPExchangeEnabled", true },
		{ "SitePerProcess", true },
		{ "SiteSafetyServicesEnabled", true },
		{ "SmartActionsBlockList", true },
		{ "SpeechRecognitionEnabled", true },
		{ "SpellcheckEnabled", true },
		{ "SpellcheckLanguage", true },
		{ "SpellcheckLanguageBlocklist", true },
		{ "SplitScreenEnabled", true },
		{ "StandaloneHubsSidebarEnabled", true },
		{ "StricterMixedContentTreatmentEnabled", true },
		{ "SuperDragDropEnabled", true },
		{ "SuppressUnsupportedOSWarning", true },
		{ "SyncDisabled", true },
		{ "SyncTypesListDisabled", true },
		{ "TLS13HardeningForLocalAnchorsEnabled", true },
		{ "TLSCipherSuiteDenyList", true },
		{ "TabFreezingEnabled", true },
		{ "TabServicesEnabled", true },
		{ "TargetBlankImpliesNoOpener", true },
		{ "TaskManagerEndProcessEnabled", true },
		{ "TextPredictionEnabled", true },
		{ "ThrottleNonVisibleCrossOriginIframesAllowed", true },
		{ "TotalMemoryLimitMb", true },
		{ "TrackingPrevention", true },
		{ "TranslateEnabled", true },
		{ "TravelAssistanceEnabled", true },
		{ "TripleDESEnabled", true },
		{ "U2fSecurityKeyApiEnabled", true },
		{ "URLAllowlist", true },
		{ "URLBlocklist", true },
		{ "UnthrottledNestedTimeoutEnabled", true },
		{ "UpdatePolicyOverride", true },
		{ "UploadFromPhoneEnabled", true },
		{ "UrlDiagnosticDataEnabled", true },
		{ "UserAgentClientHintsEnabled", true },
		{ "UserAgentClientHintsGREASEUpdateEnabled", true },
		{ "UserAgentReduction", true },
		{ "UserDataDir", true },
		{ "UserDataSnapshotRetentionLimit", true },
		{ "UserFeedbackAllowed", true },
		{ "VerticalTabsAllowed", true },
		{ "VideoCaptureAllowed", true },
		{ "VideoCaptureAllowedUrls", true },
		{ "VisualSearchEnabled", true },
		{ "WPADQuickCheckEnabled", true },
		{ "WalletDonationEnabled", true },
		{ "WebAppInstallForceList", true },
		{ "WebAppSettings", true },
		{ "WebAudioOutputBufferingEnabled", true },
		{ "WebCaptureEnabled", true },
		{ "WebComponentsV0Enabled", true },
		{ "WebContentFilteringBlockedCategories", true },
		{ "WebDriverOverridesIncompatiblePolicies", true },
		{ "WebRtcAllowLegacyTLSProtocols", true },
		{ "WebRtcLocalIpsAllowedUrls", true },
		{ "WebRtcRespectOsRoutingTableEnabled", true },
		{ "WebRtcUdpPortRange", true },
		{ "WebSQLAccess", true },
		{ "WebSQLInThirdPartyContextEnabled", true },
		{ "WebSQLNonSecureContextEnabled", true },
		{ "WebSelectEnabled", true },
		{ "WebWidgetAllowed", true },
		{ "WebWidgetIsEnabledOnStartup", true },
		{ "WinHttpProxyResolverEnabled", true },
		{ "WindowOcclusionEnabled", true },
	};

	/// <summary>
	/// Whenever a policy is checked in IsSupported we log it here.
	/// At the end we check if this has all policies in it.
	/// If it doesn't have all, it means a policy was maybe removed.
	/// </summary>
	static Dictionary<string, bool> _checkedPolicies = new Dictionary<string, bool>();

	public static bool IsSupported(string policyId)
	{
		if (_supportedPolicies.TryGetValue(policyId, out var supported))
		{
			_checkedPolicies[policyId] = true;
			return supported;
		}

		Console.WriteLine($"WARNING: Unknown policy - {policyId}");

		return false;
	}

	public static List<string> PoliciesNotCheckedForSupport()
	{
		var policiesNotChecked = new List<string>();

		foreach (var policyKeyValue in _supportedPolicies)
		{
			if (_checkedPolicies.ContainsKey(policyKeyValue.Key) == false)
			{
				policiesNotChecked.Add(policyKeyValue.Key);
			}
		}

		return policiesNotChecked;
	}
}
