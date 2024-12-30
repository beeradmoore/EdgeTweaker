namespace EdgePolicyMarkdownParser;

public static class SupportedPolicies
{
    static Dictionary<string, bool> _supportedPolicies = new Dictionary<string, bool>()
    {
        // Application Guard settings
        { "ApplicationGuardContainerProxy", false },
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
        { "CACertificates", false },
        { "CACertificatesWithConstraints", false },
        { "CADistrustedCertificates", false },
        { "CAHintCertificates", false },
        { "CAPlatformIntegrationEnabled", true },
        
        // Content settings
        { "AutoSelectCertificateForUrls", false },
        { "AutomaticDownloadsAllowedForUrls", false },
        { "AutomaticDownloadsBlockedForUrls", false },
        { "AutomaticFullscreenAllowedForUrls", false },
        { "AutomaticFullscreenBlockedForUrls", false },
        { "CookiesAllowedForUrls", false },
        { "CookiesBlockedForUrls", false },
        { "CookiesSessionOnlyForUrls", false },
        { "DataUrlInSvgUseEnabled", true },
        { "DefaultAutomaticDownloadsSetting", true },
        { "DefaultCookiesSetting", true },
        { "DefaultFileSystemReadGuardSetting", true },
        { "DefaultFileSystemWriteGuardSetting", true },
        { "DefaultGeolocationSetting", true },
        { "DefaultImagesSetting", true },
        { "DefaultInsecureContentSetting", true },
        { "DefaultJavaScriptJitSetting", true },
        { "DefaultJavaScriptSetting", true },
        { "DefaultNotificationsSetting", true },
        { "DefaultPluginsSetting", true },
        { "DefaultPopupsSetting", true },
        { "DefaultThirdPartyStoragePartitioningSetting", true },
        { "DefaultWebBluetoothGuardSetting", true },
        { "DefaultWebHidGuardSetting", true },
        { "DefaultWebUsbGuardSetting", true },
        { "DefaultWindowManagementSetting", true },
        { "FileSystemReadAskForUrls", false },
        { "FileSystemReadBlockedForUrls", false },
        { "FileSystemWriteAskForUrls", false },
        { "FileSystemWriteBlockedForUrls", false },
        { "ImagesAllowedForUrls", false },
        { "ImagesBlockedForUrls", false },
        { "InsecureContentAllowedForUrls", false },
        { "InsecureContentBlockedForUrls", false },
        { "IntranetFileLinksEnabled", true },
        { "JavaScriptAllowedForUrls", false },
        { "JavaScriptBlockedForUrls", false },
        { "JavaScriptJitAllowedForSites", false },
        { "JavaScriptJitBlockedForSites", false },
        { "LegacySameSiteCookieBehaviorEnabled", true },
        { "LegacySameSiteCookieBehaviorEnabledForDomainList", false },
        { "NotificationsAllowedForUrls", false },
        { "NotificationsBlockedForUrls", false },
        { "PluginsAllowedForUrls", false },
        { "PluginsBlockedForUrls", false },
        { "PopupsAllowedForUrls", false },
        { "PopupsBlockedForUrls", false },
        { "RegisteredProtocolHandlers", false },
        { "SerialAllowAllPortsForUrls", false },
        { "SerialAllowUsbDevicesForUrls", false },
        { "ShowPDFDefaultRecommendationsEnabled", true },
        { "SpotlightExperiencesAndRecommendationsEnabled", true },
        { "ThirdPartyStoragePartitioningBlockedForOrigins", false },
        { "WebHidAllowAllDevicesForUrls", false },
        { "WebHidAllowDevicesForUrls", false },
        { "WebHidAllowDevicesWithHidUsagesForUrls", false },
        { "WebHidAskForUrls", false },
        { "WebHidBlockedForUrls", false },
        { "WebUsbAllowDevicesForUrls", false },
        { "WebUsbAskForUrls", false },
        { "WebUsbBlockedForUrls", false },
        { "WindowManagementAllowedForUrls", false },
        { "WindowManagementBlockedForUrls", false },
        // Default search provider
        { "DefaultSearchProviderEnabled", true },
        { "DefaultSearchProviderEncodings", false },
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
        { "TyposquattingAllowListDomains", false },
        { "TyposquattingCheckerEnabled", true },
        
        // Edge Workspaces settings
        { "EdgeWorkspacesEnabled", true },
        { "WorkspacesNavigationSettings", false },
        
        // Experimentation
        { "FeatureFlagOverridesControl", true },
        
        // Extensions
        { "BlockExternalExtensions", true },
        { "ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled", true },
        { "ExtensionAllowedTypes", false },
        { "ExtensionDeveloperModeSettings", true },
        { "ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls", false },
        { "ExtensionInstallAllowlist", false },
        { "ExtensionInstallBlocklist", false },
        { "ExtensionInstallForcelist", false },
        { "ExtensionInstallSources", false },
        { "ExtensionInstallTypeBlocklist", false },
        { "ExtensionManifestV2Availability", true },
        { "ExtensionSettings", false },
        
        // Games settings
        { "GamerModeEnabled", true },
        
        // Generative AI
        { "GenAILocalFoundationalModelSettings", true },
        
        // HTTP authentication
        { "AllHttpAuthSchemesAllowedForOrigins", false },
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
        { "AutomaticProfileSwitchingSiteList", false },
        { "EdgeDefaultProfileEnabled", true },
        { "GuidedSwitchEnabled", true },
        { "ImplicitSignInEnabled", true },
        { "LinkedAccountEnabled", true },
        { "OneAuthAuthenticationEnforced", true },
        { "OnlyOnPremisesImplicitSigninEnabled", true },
        { "ProactiveAuthWorkflowEnabled", true },
        { "SignInCtaOnNtpEnabled", true },
        { "SwitchIntranetSitesToWorkProfile", true },
        { "SwitchSitesOnIEModeSiteListToWorkProfile", true },
        { "WAMAuthBelowWin10RS3Enabled", true },
        
        // Idle Browser Actions
        
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
        { "NativeMessagingAllowlist", false },
        { "NativeMessagingBlocklist", false },
        { "NativeMessagingUserLevelHosts", true },
        
        // Network settings
        { "AccessControlAllowMethodsInCORSPreflightSpecConformant", true },
        { "BlockTruncatedCookies", true },
        { "CompressionDictionaryTransportEnabled", true },
        { "DataURLWhitespacePreservationEnabled", true },
        { "IPv6ReachabilityOverrideEnabled", true },
        { "ZstdContentEncodingEnabled", true },
        
        // PDF Reader
        { "ViewXFAPDFInIEModeAllowedFileHash", false },
        { "ViewXFAPDFInIEModeAllowedOrigins", false },
        
        // Password manager and protection
        { "DeletingUndecryptablePasswordsEnabled", true },
        { "PasswordDeleteOnBrowserCloseEnabled", true },
        { "PasswordGeneratorEnabled", true },
        { "PasswordManagerBlocklist", false },
        { "PasswordManagerEnabled", true },
        { "PasswordManagerRestrictLengthEnabled", true },
        { "PasswordMonitorAllowed", true },
        { "PasswordProtectionChangePasswordURL", true },
        { "PasswordProtectionLoginURLs", false },
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
        { "SameOriginTabCaptureAllowedByOrigins", false },
        { "ScreenCaptureAllowedByOrigins", false },
        { "TabCaptureAllowedByOrigins", false },
        { "WindowCaptureAllowedByOrigins", false },
        
        // Printing
        { "DefaultPrinterSelection", true },
        { "PrintHeaderFooter", true },
        { "PrintPdfAsImageDefault", true },
        { "PrintPostScriptMode", true },
        { "PrintPreviewStickySettings", false },
        { "PrintPreviewUseSystemDefaultPrinter", true },
        { "PrintRasterizationMode", true },
        { "PrintRasterizePdfDpi", true },
        { "PrintStickySettings", true },
        { "PrinterTypeDenyList", false },
        { "PrintingAllowedBackgroundGraphicsModes", true },
        { "PrintingBackgroundGraphicsDefault", true },
        { "PrintingEnabled", true },
        { "PrintingLPACSandboxEnabled", true },
        { "PrintingPaperSizeDefault", false },
        { "PrintingWebpageLayout", true },
        { "UseSystemPrintDialog", true },
        
        // Private Network Request Settings
        { "InsecurePrivateNetworkRequestsAllowed", true },
        { "InsecurePrivateNetworkRequestsAllowedForUrls", false },
        { "PrivateNetworkAccessRestrictionsEnabled", true },
        
        // Proxy server
        { "ProxyBypassList", true },
        { "ProxyMode", true },
        { "ProxyPacUrl", true },
        { "ProxyServer", true },
        { "ProxySettings", false },
        
        // Related Website Sets Settings
        { "RelatedWebsiteSetsEnabled", true },
        { "RelatedWebsiteSetsOverrides", false },
        
        // Sleeping tabs settings
        { "AutoDiscardSleepingTabsEnabled", true },
        { "SleepingTabsBlockedForUrls", false },
        { "SleepingTabsEnabled", true },
        { "SleepingTabsTimeout", true },
        
        // SmartScreen settings
        { "ExemptSmartScreenDownloadWarnings", false },
        { "NewSmartScreenLibraryEnabled", true },
        { "PreventSmartScreenPromptOverride", true },
        { "PreventSmartScreenPromptOverrideForFiles", true },
        { "SmartScreenAllowListDomains", false },
        { "SmartScreenDnsRequestsEnabled", true },
        { "SmartScreenEnabled", true },
        { "SmartScreenForTrustedDownloadsEnabled", true },
        { "SmartScreenPuaEnabled", true },
        
        // Additional
        { "AADWebSiteSSOUsingThisProfileEnabled", true },
        { "AIGenThemesEnabled", true },
        { "AccessibilityImageLabelsEnabled", true },
        { "AdHocCodeSigningForPWAsEnabled", true },
        { "AdditionalSearchBoxEnabled", true },
        { "AddressBarEditingEnabled", true },
        { "AddressBarMicrosoftSearchInBingProviderEnabled", true },
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
        { "AllowTokenBindingForUrls", false },
        { "AllowTrackingForUrls", false },
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
        { "AudioCaptureAllowedUrls", false },
        { "AudioProcessHighPriorityEnabled", true },
        { "AudioSandboxEnabled", true },
        { "AutoImportAtFirstRun", true },
        { "AutoLaunchProtocolsComponentEnabled", true },
        { "AutoLaunchProtocolsFromOrigins", false },
        { "AutoOpenAllowedForURLs", false },
        { "AutoOpenFileTypes", false },
        { "AutofillAddressEnabled", true },
        { "AutofillCreditCardEnabled", true },
        { "AutofillMembershipsEnabled", true },
        { "AutomaticHttpsDefault", true },
        { "AutoplayAllowed", true },
        { "AutoplayAllowlist", false },
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
        { "BrowsingDataLifetime", false },
        { "BuiltInDnsClientEnabled", true },
        { "BuiltinCertificateVerifierEnabled", true },
        { "CECPQ2Enabled", true },
        { "CORSNonWildcardRequestHeadersSupport", true },
        { "CSSCustomStateDeprecatedSyntaxEnabled", true },
        { "CertificateTransparencyEnforcementDisabledForCas", false },
        { "CertificateTransparencyEnforcementDisabledForLegacyCas", false },
        { "CertificateTransparencyEnforcementDisabledForUrls", false },
        { "ClearBrowsingDataOnExit", true },
        { "ClearCachedImagesAndFilesOnExit", true },
        { "ClickOnceEnabled", true },
        { "ClipboardAllowedForUrls", false },
        { "ClipboardBlockedForUrls", false },
        { "CollectionsServicesAndExportsBlockList", false },
        { "CommandLineFlagSecurityWarningsEnabled", true },
        { "ComponentUpdatesEnabled", true },
        { "ComposeInlineEnabled", true },
        { "ConfigureDoNotTrack", true },
        { "ConfigureFriendlyURLFormat", true },
        { "ConfigureKeyboardShortcuts", false },
        { "ConfigureOnPremisesAccountAutoSignIn", true },
        { "ConfigureOnlineTextToSpeech", true },
        { "ConfigureShare", true },
        { "ConfigureViewInFileExplorer", false },
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
        { "DoNotSilentlyBlockProtocolsFromOrigins", false },
        { "DoubleClickCloseTabEnabled", true },
        { "DownloadDirectory", true },
        { "DownloadRestrictions", true },
        { "DynamicCodeSettings", true },
        { "Edge3PSerpTelemetryEnabled", true },
        { "EdgeAssetDeliveryServiceEnabled", true },
        { "EdgeCollectionsEnabled", true },
        { "EdgeDiscoverEnabled", true },
        { "EdgeEDropEnabled", true },
        { "EdgeEnhanceImagesEnabled", true },
        { "EdgeEntraCopilotPageContext", true },
        { "EdgeFollowEnabled", true },
        { "EdgeOpenInSidebarEnabled", true },
        { "EdgeShoppingAssistantEnabled", true },
        { "EdgeSidebarAppUrlHostAllowList", false },
        { "EdgeSidebarAppUrlHostBlockList", false },
        { "EdgeSidebarAppUrlHostForceList", false },
        { "EdgeSidebarCustomizeEnabled", true },
        { "EdgeWalletCheckoutEnabled", true },
        { "EdgeWalletEtreeEnabled", true },
        { "EditFavoritesEnabled", true },
        { "EnableDeprecatedWebPlatformFeatures", false },
        { "EnableDomainActionsDownload", true },
        { "EnableOnlineRevocationChecks", true },
        { "EnableSha1ForLocalAnchors", true },
        { "EncryptedClientHelloEnabled", true },
        { "EnforceLocalAnchorConstraintsEnabled", true },
        { "EnhanceSecurityMode", true },
        { "EnhanceSecurityModeAllowUserBypass", true },
        { "EnhanceSecurityModeBypassIntranet", true },
        { "EnhanceSecurityModeBypassListDomains", false },
        { "EnhanceSecurityModeEnforceListDomains", false },
        { "EnhanceSecurityModeIndicatorUIEnabled", true },
        { "EnhanceSecurityModeOptOutUXEnabled", true },
        { "EnterpriseHardwarePlatformAPIEnabled", true },
        { "EnterpriseModeSiteListManagerAllowed", true },
        { "EventPathEnabled", true },
        { "ExemptDomainFileTypePairsFromFileTypeDownloadWarnings", false },
        { "ExemptFileTypeDownloadWarnings", false },
        { "ExperimentationAndConfigurationServiceControl", true },
        { "ExplicitlyAllowedNetworkPorts", false },
        { "ExternalProtocolDialogShowAlwaysOpenCheckbox", true },
        { "FamilySafetySettingsEnabled", true },
        { "FavoritesBarEnabled", true },
        { "FetchKeepaliveDurationSecondsOnShutdown", true },
        { "FileOrDirectoryPickerWithoutGestureAllowedForOrigins", false },
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
        { "ForceSyncTypes", false },
        { "ForceYouTubeRestrict", true },
        { "FullscreenAllowed", true },
        { "GloballyScopeHTTPAuthCacheEnabled", true },
        { "GoToIntranetSiteForSingleWordEntryInAddressBar", true },
        { "HSTSPolicyBypassList", false },
        { "HardwareAccelerationModeEnabled", true },
        { "HeadlessModeEnabled", true },
        { "HideFirstRunExperience", true },
        { "HideInternetExplorerRedirectUXForIncompatibleSitesEnabled", true },
        { "HideRestoreDialogEnabled", true },
        { "HttpAllowlist", false },
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
        { "InternetExplorerIntegrationLocalFileExtensionAllowList", false },
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
        { "LiveTranslationAllowed", true },
        { "LocalBrowserDataShareEnabled", true },
        { "LocalProvidersEnabled", true },
        { "MAUEnabled", true },
        { "MSAWebSiteSSOUsingThisProfileAllowed", true },
        { "ManagedConfigurationPerOrigin", false },
        { "ManagedFavorites", false },
        { "ManagedSearchEngines", false },
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
        { "OverrideSecurityRestrictionsOnInsecureOrigin", false },
        { "PDFSecureMode", true },
        { "PDFXFAEnabled", true },
        { "PaymentMethodQueryEnabled", true },
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
        { "RelaunchWindow", false },
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
        { "SSLErrorOverrideAllowedForOrigins", false },
        { "SSLVersionMin", true },
        { "SandboxExternalProtocolBlocked", true },
        { "SaveCookiesOnExit", false },
        { "SavingBrowserHistoryDisabled", true },
        { "ScreenCaptureAllowed", true },
        { "ScreenCaptureWithoutGestureAllowedForOrigins", false },
        { "ScrollToTextFragmentEnabled", true },
        { "SearchFiltersEnabled", true },
        { "SearchForImageEnabled", true },
        { "SearchInSidebarEnabled", true },
        { "SearchSuggestEnabled", true },
        { "SearchbarAllowed", true },
        { "SearchbarIsEnabledOnStartup", true },
        { "SecurityKeyPermitAttestation", false },
        { "SelectParserRelaxationEnabled", true },
        { "SendIntranetToInternetExplorer", true },
        { "SendMouseEventsDisabledFormControlsEnabled", true },
        { "SendSiteInfoToImproveServices", true },
        { "SensorsAllowedForUrls", false },
        { "SensorsBlockedForUrls", false },
        { "SerialAskForUrls", false },
        { "SerialBlockedForUrls", false },
        { "SetTimeoutWithout1MsClampEnabled", true },
        { "ShadowStackCrashRollbackBehavior", true },
        { "SharedArrayBufferUnrestrictedAccessAllowed", true },
        { "SharedLinksEnabled", true },
        { "ShowAcrobatSubscriptionButton", true },
        { "ShowDownloadsToolbarButton", true },
        { "ShowHistoryThumbnails", true },
        { "ShowMicrosoftRewards", true },
        { "ShowOfficeShortcutInFavoritesBar", true },
        { "ShowRecommendationsEnabled", true },
        { "SignedHTTPExchangeEnabled", true },
        { "SitePerProcess", true },
        { "SiteSafetyServicesEnabled", true },
        { "SmartActionsBlockList", false },
        { "SpeechRecognitionEnabled", true },
        { "SpellcheckEnabled", true },
        { "SpellcheckLanguage", false },
        { "SpellcheckLanguageBlocklist", false },
        { "SplitScreenEnabled", true },
        { "StandaloneHubsSidebarEnabled", true },
        { "StricterMixedContentTreatmentEnabled", true },
        { "SuperDragDropEnabled", true },
        { "SuppressUnsupportedOSWarning", true },
        { "SyncDisabled", true },
        { "SyncTypesListDisabled", false },
        { "TLS13HardeningForLocalAnchorsEnabled", true },
        { "TLSCipherSuiteDenyList", false },
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
        { "URLAllowlist", false },
        { "URLBlocklist", false },
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
        { "VideoCaptureAllowedUrls", false },
        { "VisualSearchEnabled", true },
        { "WPADQuickCheckEnabled", true },
        { "WalletDonationEnabled", true },
        { "WebAppInstallForceList", false },
        { "WebAppSettings", false },
        { "WebCaptureEnabled", true },
        { "WebComponentsV0Enabled", true },
        { "WebDriverOverridesIncompatiblePolicies", true },
        { "WebRtcAllowLegacyTLSProtocols", true },
        { "WebRtcLocalIpsAllowedUrls", false },
        { "WebRtcLocalhostIpHandling", true },
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