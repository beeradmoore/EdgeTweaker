---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: jalam
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-05-20T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: Windows and Mac documentation for all policies supported by the Microsoft Edge Browser
locale: en-us
document_id: 198c6f64-9e5c-f18e-8439-8d0d11d4228d
document_version_independent_id: 83f32be1-063c-284c-dfdc-6b5976a5b7cc
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 7711
asset_id: microsoft-edge-policies
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: c8b55903-5d7b-134b-f016-9eee01df8e62
---

# Microsoft Edge Browser Policy Documentation | Microsoft Learn

The latest version of Microsoft Edge includes the following policies. You can use these policies to configure how Microsoft Edge runs in your organization.

For information about an additional set of policies used to control how and when Microsoft Edge is updated, check out [Microsoft Edge update policy reference](microsoft-edge-update-policies).

You can download the [Microsoft Security Compliance Toolkit](https://www.microsoft.com/download/details.aspx?id=55319) for the recommended security configuration baseline settings for Microsoft Edge. For more information see the [Microsoft Security Baselines Blog](https://techcommunity.microsoft.com/t5/microsoft-security-baselines/bg-p/Microsoft-Security-Baselines).

Starting in Microsoft Edge version 116, certain policies will not be applied to a profile that is signed in with a Microsoft account. For more information, please check an individual policy for details on whether it applies to a profile that is signed in with a Microsoft account.

Note

This article applies to Microsoft Edge version 77 or later.

## New policies

There are no new policies in Microsoft Edge version 150.

The following table lists the new policies for Microsoft Edge version 149.

| Policy Name | Caption |
| --- | --- |
| [DefaultLocalFontsSetting](microsoft-edge-policies/defaultlocalfontssetting) | Default Local Fonts permission setting |
| [LocalFontsAllowedForUrls](microsoft-edge-policies/localfontsallowedforurls) | Allow Local Fonts permission on these sites |
| [LocalFontsBlockedForUrls](microsoft-edge-policies/localfontsblockedforurls) | Block Local Fonts permission on these sites |
| [CopilotAddressBarSuggestionsEnabled](microsoft-edge-policies/copilotaddressbarsuggestionsenabled) | Enable Copilot address bar suggestions |
| [CpuPerformanceTierOverride](microsoft-edge-policies/cpuperformancetieroverride) | Override for the CPU performance tier |
| [DataUrlInWebWorkerOpaqueOriginEnabled](microsoft-edge-policies/dataurlinwebworkeropaqueoriginenabled) | Enable opaque origins for data URLs in Web Workers |
| [ForceForegroundPriorityForUrls](microsoft-edge-policies/forceforegroundpriorityforurls) | Force foreground priority for specific URLs |

## Deprecated policies

The following table lists all deprecated policies.

| Policy Name | Caption |
| --- | --- |
| [ForceCertificatePromptsOnMultipleMatches](microsoft-edge-policies/forcecertificatepromptsonmultiplematches) | Configure whether Microsoft Edge should automatically select a certificate when there are multiple certificate matches for a site configured with "AutoSelectCertificateForUrls" (deprecated) |
| [AllowGamesMenu](microsoft-edge-policies/allowgamesmenu) | Allow users to access the games menu (deprecated) |
| [MicrosoftOfficeMenuEnabled](microsoft-edge-policies/microsoftofficemenuenabled) | Allow users to access the Microsoft Office menu (deprecated) |
| [ShowOfficeShortcutInFavoritesBar](microsoft-edge-policies/showofficeshortcutinfavoritesbar) | Show Microsoft Office shortcut in favorites bar (deprecated) |
| [ProxyBypassList](microsoft-edge-policies/proxybypasslist) | Configure proxy bypass rules (deprecated) |
| [ProxyMode](microsoft-edge-policies/proxymode) | Configure proxy server settings (deprecated) |
| [ProxyPacUrl](microsoft-edge-policies/proxypacurl) | Set the proxy .pac file URL (deprecated) |
| [ProxyServer](microsoft-edge-policies/proxyserver) | Configure address or URL of proxy server (deprecated) |
| [RelatedWebsiteSetsEnabled](microsoft-edge-policies/relatedwebsitesetsenabled) | Enable Related Website Sets (deprecated) |
| [RelatedWebsiteSetsOverrides](microsoft-edge-policies/relatedwebsitesetsoverrides) | Override Related Website Sets. (deprecated) |
| [BackgroundTemplateListUpdatesEnabled](microsoft-edge-policies/backgroundtemplatelistupdatesenabled) | Enables background updates to the list of available templates for Collections and other features that use templates (deprecated) |
| [EdgeWalletEtreeEnabled](microsoft-edge-policies/edgewalletetreeenabled) | Edge Wallet E-Tree Enabled (deprecated) |
| [InsecureFormsWarningsEnabled](microsoft-edge-policies/insecureformswarningsenabled) | Enable warnings for insecure forms (deprecated) |
| [NativeWindowOcclusionEnabled](microsoft-edge-policies/nativewindowocclusionenabled) | Enable Native Window Occlusion (deprecated) |
| [PromotionalTabsEnabled](microsoft-edge-policies/promotionaltabsenabled) | Enable full-tab promotional content (deprecated) |
| [UnthrottledNestedTimeoutEnabled](microsoft-edge-policies/unthrottlednestedtimeoutenabled) | JavaScript setTimeout will not be clamped until a higher nesting threshold is set (deprecated) |
| [WalletDonationEnabled](microsoft-edge-policies/walletdonationenabled) | Wallet Donation Enabled (deprecated) |
| [WebWidgetAllowed](microsoft-edge-policies/webwidgetallowed) | Enable the Search bar (deprecated) |

## Obsolete policies

The following table lists the obsoleted policies for Microsoft Edge version 150.

| Policy Name | Caption |
| --- | --- |
| [DisabledMiniApps](microsoft-edge-policies/disabledminiapps) | List of disabled Mini Apps (obsolete) |

There are no obsoleted policies in Microsoft Edge version 149.

## Available policies

These tables list all of the browser-related group policies available in this release of Microsoft Edge. Use the links in the table to get more details about specific policies.

- Accessibility
- Address Bar
- Application Guard settings
- Cast
- Certificate management settings
- Connector
- Content settings
- Copilot
- Cryptography compliance policies
- Default search provider
- Diagnostic Data
- Downloads
- Edge Website Typo Protection settings
- Edge Workspaces settings
- Enhanced Security Mode
- Experimentation
- Extensions
- Games settings
- Generative AI
- HTTP authentication
- Identity and sign-in
- Idle Browser Actions
- Immersive Reader settings
- Import
- Internet Explorer Mode
- Kiosk Mode settings
- Manageability
- Microsoft Office
- Native Messaging
- Network settings
- PDF Reader
- Password manager and protection
- Performance
- Permit or deny screen capture
- Personalization
- Printing
- Private Network Request Settings
- Profile settings
- Protected Content
- Proxy server
- Related Website Sets Settings
- Scareware Blocker settings
- Sleeping tabs settings
- SmartScreen settings
- Startup, home page and new tab page
- WebRtc settings
- Additional

### Accessibility

| Policy Name | Caption |
| --- | --- |
| [AccessibilityImageLabelsEnabled](microsoft-edge-policies/accessibilityimagelabelsenabled) | Let screen reader users get image descriptions from Microsoft |
| [AccessibilityPerformanceFilteringAllowed](microsoft-edge-policies/accessibilityperformancefilteringallowed) | Allow Accessibility Performance Filtering. |
| [LiveCaptionsAllowed](microsoft-edge-policies/livecaptionsallowed) | Live captions allowed |

### Address Bar

| Policy Name | Caption |
| --- | --- |
| [AddressBarEditingEnabled](microsoft-edge-policies/addressbareditingenabled) | Configure address bar editing |
| [AddressBarMicrosoftSearchInBingProviderEnabled](microsoft-edge-policies/addressbarmicrosoftsearchinbingproviderenabled) | Enable Microsoft Search in Bing suggestions in the address bar (obsolete) |
| [AddressBarTrendingSuggestEnabled](microsoft-edge-policies/addressbartrendingsuggestenabled) | Enable Microsoft Bing trending suggestions in the address bar |
| [AddressBarWorkSearchResultsEnabled](microsoft-edge-policies/addressbarworksearchresultsenabled) | Enable Work Search suggestions in the address bar |

### Application Guard settings

| Policy Name | Caption |
| --- | --- |
| [ApplicationGuardContainerProxy](microsoft-edge-policies/applicationguardcontainerproxy) | Application Guard Container Proxy |
| [ApplicationGuardFavoritesSyncEnabled](microsoft-edge-policies/applicationguardfavoritessyncenabled) | Application Guard Favorites Sync Enabled |
| [ApplicationGuardPassiveModeEnabled](microsoft-edge-policies/applicationguardpassivemodeenabled) | Ignore Application Guard site list configuration and browse Microsoft Edge normally |
| [ApplicationGuardTrafficIdentificationEnabled](microsoft-edge-policies/applicationguardtrafficidentificationenabled) | Application Guard Traffic Identification |
| [ApplicationGuardUploadBlockingEnabled](microsoft-edge-policies/applicationguarduploadblockingenabled) | Prevents files from being uploaded while in Application Guard |

### Cast

| Policy Name | Caption |
| --- | --- |
| [EdgeDisableDialProtocolForCastDiscovery](microsoft-edge-policies/edgedisabledialprotocolforcastdiscovery) | Disable DIAL protocol for cast device discovery |
| [EnableMediaRouter](microsoft-edge-policies/enablemediarouter) | Enable Google Cast |
| [ShowCastIconInToolbar](microsoft-edge-policies/showcasticonintoolbar) | Show the cast icon in the toolbar |

### Certificate management settings

| Policy Name | Caption |
| --- | --- |
| [CACertificateManagementAllowed](microsoft-edge-policies/cacertificatemanagementallowed) | Allow users to manage installed CA certificates. |
| [CACertificates](microsoft-edge-policies/cacertificates) | TLS server certificates that should be trusted by Microsoft Edge |
| [CACertificatesWithConstraints](microsoft-edge-policies/cacertificateswithconstraints) | TLS certificates that should be trusted by Microsoft Edge for server authentication with constraints |
| [CADistrustedCertificates](microsoft-edge-policies/cadistrustedcertificates) | TLS certificates that should be distrusted by Microsoft Edge for server authentication |
| [CAHintCertificates](microsoft-edge-policies/cahintcertificates) | TLS certificates that are not trusted or distrusted but can be used in path-building for server authentication |
| [CAPlatformIntegrationEnabled](microsoft-edge-policies/caplatformintegrationenabled) | Use user-added TLS certificates from platform trust stores for server authentication |
| [CertificateTransparencyEnforcementDisabledForCas](microsoft-edge-policies/certificatetransparencyenforcementdisabledforcas) | Disable Certificate Transparency enforcement for a list of subjectPublicKeyInfo hashes |
| [CertificateTransparencyEnforcementDisabledForLegacyCas](microsoft-edge-policies/certificatetransparencyenforcementdisabledforlegacycas) | Disable Certificate Transparency enforcement for a list of legacy certificate authorities (obsolete) |
| [CertificateTransparencyEnforcementDisabledForUrls](microsoft-edge-policies/certificatetransparencyenforcementdisabledforurls) | Disable Certificate Transparency enforcement for specific URLs |
| [ForceCertificatePromptsOnMultipleMatches](microsoft-edge-policies/forcecertificatepromptsonmultiplematches) | Configure whether Microsoft Edge should automatically select a certificate when there are multiple certificate matches for a site configured with "AutoSelectCertificateForUrls" (deprecated) |
| [PromptOnMultipleMatchingCertificates](microsoft-edge-policies/promptonmultiplematchingcertificates) | Prompt the user to select a certificate when multiple certificates match |

### Connector

| Policy Name | Caption |
| --- | --- |
| [OnBulkDataEntryEnterpriseConnector](microsoft-edge-policies/onbulkdataentryenterpriseconnector) | Configuration policy for bulk data entry for Microsoft Edge for Business Data Loss Prevention Connectors |
| [OnFileAttachedEnterpriseConnector](microsoft-edge-policies/onfileattachedenterpriseconnector) | Configuration policy for files attached for Microsoft Edge for Business Data Loss Prevention Connectors |
| [OnPrintEnterpriseConnector](microsoft-edge-policies/onprintenterpriseconnector) | Configuration policy for print for Microsoft Edge for Business Data Loss Prevention Connectors |
| [OnSecurityEventEnterpriseConnector](microsoft-edge-policies/onsecurityevententerpriseconnector) | Configuration policy for Microsoft Edge for Business Reporting Connectors |

### Content settings

| Policy Name | Caption |
| --- | --- |
| [AutoSelectCertificateForUrls](microsoft-edge-policies/autoselectcertificateforurls) | Automatically select client certificates for these sites |
| [AutomaticDownloadsAllowedForUrls](microsoft-edge-policies/automaticdownloadsallowedforurls) | Allow multiple automatic downloads in quick succession on specific sites |
| [AutomaticDownloadsBlockedForUrls](microsoft-edge-policies/automaticdownloadsblockedforurls) | Block multiple automatic downloads in quick succession on specific sites |
| [AutomaticFullscreenAllowedForUrls](microsoft-edge-policies/automaticfullscreenallowedforurls) | Allow automatic full screen on specified sites |
| [AutomaticFullscreenBlockedForUrls](microsoft-edge-policies/automaticfullscreenblockedforurls) | Block automatic full screen on specified sites |
| [CookiesAllowedForUrls](microsoft-edge-policies/cookiesallowedforurls) | Allow cookies on specific sites |
| [CookiesBlockedForUrls](microsoft-edge-policies/cookiesblockedforurls) | Block cookies on specific sites |
| [CookiesSessionOnlyForUrls](microsoft-edge-policies/cookiessessiononlyforurls) | Limit cookies from specific websites to the current session |
| [DataUrlInSvgUseEnabled](microsoft-edge-policies/dataurlinsvguseenabled) | Data URL support for SVGUseElement |
| [DefaultAutomaticDownloadsSetting](microsoft-edge-policies/defaultautomaticdownloadssetting) | Default automatic downloads setting |
| [DefaultCookiesSetting](microsoft-edge-policies/defaultcookiessetting) | Configure cookies |
| [DefaultDesktopSiteSetting](microsoft-edge-policies/defaultdesktopsitesetting) | Configure the default view mode for websites |
| [DefaultFileSystemReadGuardSetting](microsoft-edge-policies/defaultfilesystemreadguardsetting) | Control use of the File System API for reading |
| [DefaultFileSystemWriteGuardSetting](microsoft-edge-policies/defaultfilesystemwriteguardsetting) | Control use of the File System API for writing |
| [DefaultGeolocationSetting](microsoft-edge-policies/defaultgeolocationsetting) | Default geolocation setting |
| [DefaultIdleDetectionSetting](microsoft-edge-policies/defaultidledetectionsetting) | Default idle detection setting |
| [DefaultImagesSetting](microsoft-edge-policies/defaultimagessetting) | Default images setting |
| [DefaultInsecureContentSetting](microsoft-edge-policies/defaultinsecurecontentsetting) | Control use of insecure content exceptions |
| [DefaultJavaScriptJitSetting](microsoft-edge-policies/defaultjavascriptjitsetting) | Control use of JavaScript JIT |
| [DefaultJavaScriptOptimizerSetting](microsoft-edge-policies/defaultjavascriptoptimizersetting) | Control use of JavaScript optimizers |
| [DefaultJavaScriptSetting](microsoft-edge-policies/defaultjavascriptsetting) | Default JavaScript setting |
| [DefaultLocalFontsSetting](microsoft-edge-policies/defaultlocalfontssetting) | Default Local Fonts permission setting |
| [DefaultNotificationsSetting](microsoft-edge-policies/defaultnotificationssetting) | Default notification setting |
| [DefaultPluginsSetting](microsoft-edge-policies/defaultpluginssetting) | Default Adobe Flash setting (obsolete) |
| [DefaultPopupsSetting](microsoft-edge-policies/defaultpopupssetting) | Default pop-up window setting |
| [DefaultThirdPartyStoragePartitioningSetting](microsoft-edge-policies/defaultthirdpartystoragepartitioningsetting) | Default setting for third-party storage partitioning (obsolete) |
| [DefaultWebBluetoothGuardSetting](microsoft-edge-policies/defaultwebbluetoothguardsetting) | Control use of the Web Bluetooth API |
| [DefaultWebHidGuardSetting](microsoft-edge-policies/defaultwebhidguardsetting) | Control use of the WebHID API |
| [DefaultWebUsbGuardSetting](microsoft-edge-policies/defaultwebusbguardsetting) | Control use of the WebUSB API |
| [DefaultWindowManagementSetting](microsoft-edge-policies/defaultwindowmanagementsetting) | Default Window Management permission setting |
| [DesktopSiteForceForUrls](microsoft-edge-policies/desktopsiteforceforurls) | Force Desktop Site for these sites |
| [EdgeFileUploadAllowedForUrls](microsoft-edge-policies/edgefileuploadallowedforurls) | File upload allowed for urls |
| [EdgeFileUploadBlockedForUrls](microsoft-edge-policies/edgefileuploadblockedforurls) | File upload blocked for urls |
| [FileSystemReadAskForUrls](microsoft-edge-policies/filesystemreadaskforurls) | Allow read access via the File System API on these sites |
| [FileSystemReadBlockedForUrls](microsoft-edge-policies/filesystemreadblockedforurls) | Block read access via the File System API on these sites |
| [FileSystemWriteAskForUrls](microsoft-edge-policies/filesystemwriteaskforurls) | Allow write access to files and directories on these sites |
| [FileSystemWriteBlockedForUrls](microsoft-edge-policies/filesystemwriteblockedforurls) | Block write access to files and directories on these sites |
| [GeolocationBlockedForUrls](microsoft-edge-policies/geolocationblockedforurls) | Block geolocation on these sites |
| [IdleDetectionAllowedForUrls](microsoft-edge-policies/idledetectionallowedforurls) | Allow idle detection on these sites |
| [IdleDetectionBlockedForUrls](microsoft-edge-policies/idledetectionblockedforurls) | Block idle detection on these sites |
| [ImagesAllowedForUrls](microsoft-edge-policies/imagesallowedforurls) | Allow images on these sites |
| [ImagesBlockedForUrls](microsoft-edge-policies/imagesblockedforurls) | Block images on specific sites |
| [InsecureContentAllowedForUrls](microsoft-edge-policies/insecurecontentallowedforurls) | Allow insecure content on specified sites |
| [InsecureContentBlockedForUrls](microsoft-edge-policies/insecurecontentblockedforurls) | Block insecure content on specified sites |
| [IntranetFileLinksEnabled](microsoft-edge-policies/intranetfilelinksenabled) | Allow intranet zone file URL links from Microsoft Edge to open in Windows File Explorer |
| [JavaScriptAllowedForUrls](microsoft-edge-policies/javascriptallowedforurls) | Allow JavaScript on specific sites |
| [JavaScriptBlockedForUrls](microsoft-edge-policies/javascriptblockedforurls) | Block JavaScript on specific sites |
| [JavaScriptJitAllowedForSites](microsoft-edge-policies/javascriptjitallowedforsites) | Allow JavaScript to use JIT on these sites |
| [JavaScriptJitBlockedForSites](microsoft-edge-policies/javascriptjitblockedforsites) | Block JavaScript from using JIT on these sites |
| [JavaScriptOptimizerAllowedForSites](microsoft-edge-policies/javascriptoptimizerallowedforsites) | Allow JavaScript optimization on these sites |
| [JavaScriptOptimizerBlockedForSites](microsoft-edge-policies/javascriptoptimizerblockedforsites) | Block JavaScript optimizations on these sites |
| [LegacySameSiteCookieBehaviorEnabled](microsoft-edge-policies/legacysamesitecookiebehaviorenabled) | Enable default legacy SameSite cookie behavior setting (obsolete) |
| [LegacySameSiteCookieBehaviorEnabledForDomainList](microsoft-edge-policies/legacysamesitecookiebehaviorenabledfordomainlist) | Revert to legacy SameSite behavior for cookies on specified sites (obsolete) |
| [LocalFontsAllowedForUrls](microsoft-edge-policies/localfontsallowedforurls) | Allow Local Fonts permission on these sites |
| [LocalFontsBlockedForUrls](microsoft-edge-policies/localfontsblockedforurls) | Block Local Fonts permission on these sites |
| [MobileSiteForceForUrls](microsoft-edge-policies/mobilesiteforceforurls) | Force Mobile Site for these sites |
| [NotificationsAllowedForUrls](microsoft-edge-policies/notificationsallowedforurls) | Allow notifications on specific sites |
| [NotificationsBlockedForUrls](microsoft-edge-policies/notificationsblockedforurls) | Block notifications on specific sites |
| [PartitionedBlobUrlUsage](microsoft-edge-policies/partitionedbloburlusage) | Manage Blob URL Partitioning During Fetching and Navigation |
| [PdfLocalFileAccessAllowedForDomains](microsoft-edge-policies/pdflocalfileaccessallowedfordomains) | Allow specified sites to access file:// URLs in the PDF Viewer |
| [PluginsAllowedForUrls](microsoft-edge-policies/pluginsallowedforurls) | Allow the Adobe Flash plug-in on specific sites (obsolete) |
| [PluginsBlockedForUrls](microsoft-edge-policies/pluginsblockedforurls) | Block the Adobe Flash plug-in on specific sites (obsolete) |
| [PopupsAllowedForUrls](microsoft-edge-policies/popupsallowedforurls) | Allow pop-up windows on specific sites |
| [PopupsBlockedForUrls](microsoft-edge-policies/popupsblockedforurls) | Block pop-up windows on specific sites |
| [PreciseGeolocationAllowedForUrls](microsoft-edge-policies/precisegeolocationallowedforurls) | Allow precise geolocation on these sites |
| [RegisteredProtocolHandlers](microsoft-edge-policies/registeredprotocolhandlers) | Register protocol handlers |
| [SerialAllowAllPortsForUrls](microsoft-edge-policies/serialallowallportsforurls) | Automatically grant sites permission to connect all serial ports |
| [SerialAllowUsbDevicesForUrls](microsoft-edge-policies/serialallowusbdevicesforurls) | Automatically grant sites permission to connect to USB serial devices |
| [ShowPDFDefaultRecommendationsEnabled](microsoft-edge-policies/showpdfdefaultrecommendationsenabled) | Allow notifications to set Microsoft Edge as default PDF reader |
| [SpotlightExperiencesAndRecommendationsEnabled](microsoft-edge-policies/spotlightexperiencesandrecommendationsenabled) | Choose whether users can receive customized background images and text, suggestions, notifications, and tips for Microsoft services |
| [ThirdPartyStoragePartitioningBlockedForOrigins](microsoft-edge-policies/thirdpartystoragepartitioningblockedfororigins) | Disable third-party storage partitioning for specific top-level origins (obsolete) |
| [WebHidAllowAllDevicesForUrls](microsoft-edge-policies/webhidallowalldevicesforurls) | Allow listed sites to connect to any HID device |
| [WebHidAllowDevicesForUrls](microsoft-edge-policies/webhidallowdevicesforurls) | Allow listed sites connect to specific HID devices |
| [WebHidAllowDevicesWithHidUsagesForUrls](microsoft-edge-policies/webhidallowdeviceswithhidusagesforurls) | Automatically grant permission to these sites to connect to HID devices containing top-level collections with the given HID usage |
| [WebHidAskForUrls](microsoft-edge-policies/webhidaskforurls) | Allow the WebHID API on these sites |
| [WebHidBlockedForUrls](microsoft-edge-policies/webhidblockedforurls) | Block the WebHID API on these sites |
| [WebUsbAllowDevicesForUrls](microsoft-edge-policies/webusballowdevicesforurls) | Grant access to specific sites to connect to specific USB devices |
| [WebUsbAskForUrls](microsoft-edge-policies/webusbaskforurls) | Allow WebUSB on specific sites |
| [WebUsbBlockedForUrls](microsoft-edge-policies/webusbblockedforurls) | Block WebUSB on specific sites |
| [WindowManagementAllowedForUrls](microsoft-edge-policies/windowmanagementallowedforurls) | Allow Window Management permission on specified sites |
| [WindowManagementBlockedForUrls](microsoft-edge-policies/windowmanagementblockedforurls) | Block Window Management permission on specified sites |

### Copilot

| Policy Name | Caption |
| --- | --- |
| [CopilotCDPPageContext](microsoft-edge-policies/copilotcdppagecontext) | Control Copilot with Commercial Data Protection access to page context for Microsoft Entra ID profiles (obsolete) |
| [CopilotPageContext](microsoft-edge-policies/copilotpagecontext) | Control Copilot access to page context for Microsoft Entra ID profiles |
| [EdgeCopilotEnabled](microsoft-edge-policies/edgecopilotenabled) | Enable Copilot |
| [EdgeEntraCopilotPageContext](microsoft-edge-policies/edgeentracopilotpagecontext) | Control Copilot access to Microsoft Edge page content for Entra account user profiles when using Copilot in the Microsoft Edge sidepane |
| [Microsoft365CopilotChatIconEnabled](microsoft-edge-policies/microsoft365copilotchaticonenabled) | Control whether Microsoft 365 Copilot Chat shows in the Microsoft Edge for Business toolbar |

### Cryptography compliance policies

| Policy Name | Caption |
| --- | --- |
| [PreferSlowCiphers](microsoft-edge-policies/preferslowciphers) | Prefer specific encryption cipher algorithms for TLS |
| [PreferSlowKexAlgorithms](microsoft-edge-policies/preferslowkexalgorithms) | Prefer specific key exchange algorithms for TLS |

### Default search provider

| Policy Name | Caption |
| --- | --- |
| [DefaultSearchProviderContextMenuAccessAllowed](microsoft-edge-policies/defaultsearchprovidercontextmenuaccessallowed) | Allow default search provider context menu search access |
| [DefaultSearchProviderEnabled](microsoft-edge-policies/defaultsearchproviderenabled) | Enable the default search provider |
| [DefaultSearchProviderEncodings](microsoft-edge-policies/defaultsearchproviderencodings) | Default search provider encodings |
| [DefaultSearchProviderImageURL](microsoft-edge-policies/defaultsearchproviderimageurl) | Specifies the search-by-image feature for the default search provider |
| [DefaultSearchProviderImageURLPostParams](microsoft-edge-policies/defaultsearchproviderimageurlpostparams) | Parameters for an image URL that uses POST |
| [DefaultSearchProviderKeyword](microsoft-edge-policies/defaultsearchproviderkeyword) | Default search provider keyword |
| [DefaultSearchProviderName](microsoft-edge-policies/defaultsearchprovidername) | Default search provider name |
| [DefaultSearchProviderSearchURL](microsoft-edge-policies/defaultsearchprovidersearchurl) | Default search provider search URL |
| [DefaultSearchProviderSuggestURL](microsoft-edge-policies/defaultsearchprovidersuggesturl) | Default search provider URL for suggestions |
| [NewTabPageSearchBox](microsoft-edge-policies/newtabpagesearchbox) | Configure the new tab page search box experience |

### Diagnostic Data

| Policy Name | Caption |
| --- | --- |
| [DiagnosticData](microsoft-edge-policies/diagnosticdata) | Send required and optional diagnostic data about browser usage |
| [UrlDiagnosticDataEnabled](microsoft-edge-policies/urldiagnosticdataenabled) | URL reporting in Edge diagnostic data enabled |

### Downloads

| Policy Name | Caption |
| --- | --- |
| [AutoOpenAllowedForURLs](microsoft-edge-policies/autoopenallowedforurls) | URLs where AutoOpenFileTypes can apply |
| [AutoOpenFileTypes](microsoft-edge-policies/autoopenfiletypes) | List of file types that should be automatically opened on download |
| [DefaultDownloadDirectory](microsoft-edge-policies/defaultdownloaddirectory) | Set default download directory |
| [DownloadBlockedForFileTypes](microsoft-edge-policies/downloadblockedforfiletypes) | Block downloads of specific file types |
| [DownloadDirectory](microsoft-edge-policies/downloaddirectory) | Set download directory |
| [DownloadRestrictions](microsoft-edge-policies/downloadrestrictions) | Allow download restrictions |
| [ExemptFileTypeDownloadWarnings](microsoft-edge-policies/exemptfiletypedownloadwarnings) | Disable download file type extension-based warnings for specified file types on domains |
| [PromptForDownloadLocation](microsoft-edge-policies/promptfordownloadlocation) | Ask where to save downloaded files |
| [ShowDownloadsInsecureWarningsEnabled](microsoft-edge-policies/showdownloadsinsecurewarningsenabled) | Enable insecure download warnings |

### Edge Website Typo Protection settings

| Policy Name | Caption |
| --- | --- |
| [PreventTyposquattingPromptOverride](microsoft-edge-policies/preventtyposquattingpromptoverride) | Prevent bypassing Edge Website Typo Protection prompts for sites |
| [TyposquattingAllowListDomains](microsoft-edge-policies/typosquattingallowlistdomains) | Configure the list of domains for which Microsoft Edge Website Typo Protection won't trigger warnings |
| [TyposquattingCheckerEnabled](microsoft-edge-policies/typosquattingcheckerenabled) | Configure Edge Website Typo Protection |

### Edge Workspaces settings

| Policy Name | Caption |
| --- | --- |
| [EdgeWorkspacesEnabled](microsoft-edge-policies/edgeworkspacesenabled) | Enable Workspaces |
| [WorkspacesNavigationSettings](microsoft-edge-policies/workspacesnavigationsettings) | Configure navigation settings per groups of URLs in Microsoft Edge Workspaces |

### Enhanced Security Mode

| Policy Name | Caption |
| --- | --- |
| [EnhanceSecurityMode](microsoft-edge-policies/enhancesecuritymode) | Enhance the security state in Microsoft Edge |
| [EnhanceSecurityModeAllowUserBypass](microsoft-edge-policies/enhancesecuritymodeallowuserbypass) | Allow users to bypass Enhanced Security Mode |
| [EnhanceSecurityModeBypassIntranet](microsoft-edge-policies/enhancesecuritymodebypassintranet) | Enhanced Security Mode configuration for Intranet zone sites |
| [EnhanceSecurityModeBypassListDomains](microsoft-edge-policies/enhancesecuritymodebypasslistdomains) | Configure the list of domains for which enhance security mode will not be enforced |
| [EnhanceSecurityModeEnforceListDomains](microsoft-edge-policies/enhancesecuritymodeenforcelistdomains) | Configure the list of domains for which enhance security mode will always be enforced |
| [EnhanceSecurityModeIndicatorUIEnabled](microsoft-edge-policies/enhancesecuritymodeindicatoruienabled) | Manage the indicator UI of the Enhanced Security Mode (ESM) feature in Microsoft Edge |
| [EnhanceSecurityModeOptOutUXEnabled](microsoft-edge-policies/enhancesecuritymodeoptoutuxenabled) | Manage opt-out user experience for Enhanced Security Mode (ESM) in Microsoft Edge (obsolete) |

### Experimentation

| Policy Name | Caption |
| --- | --- |
| [FeatureFlagOverridesControl](microsoft-edge-policies/featureflagoverridescontrol) | Configure users ability to override feature flags |

### Extensions

| Policy Name | Caption |
| --- | --- |
| [BlockExternalExtensions](microsoft-edge-policies/blockexternalextensions) | Blocks external extensions from being installed |
| [ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled](microsoft-edge-policies/controldefaultstateofallowextensionfromotherstoressettingenabled) | Configure default state of Allow extensions from other stores setting |
| [EdgeSafeHostingExtensionEnabled](microsoft-edge-policies/edgesafehostingextensionenabled) | Control Microsoft Edge Safe Hosting Extension |
| [ExtensionAllowedTypes](microsoft-edge-policies/extensionallowedtypes) | Configure allowed extension types |
| [ExtensionDeveloperModeSettings](microsoft-edge-policies/extensiondevelopermodesettings) | Control the availability of developer mode on extensions page |
| [ExtensionExtendedBackgroundLifetimeForPortConnectionsToUrls](microsoft-edge-policies/extensionextendedbackgroundlifetimeforportconnectionstourls) | Configure a list of origins that grant an extended background lifetime to connecting extensions. |
| [ExtensionInstallAllowlist](microsoft-edge-policies/extensioninstallallowlist) | Allow specific extensions to be installed |
| [ExtensionInstallBlocklist](microsoft-edge-policies/extensioninstallblocklist) | Control which extensions cannot be installed |
| [ExtensionInstallForcelist](microsoft-edge-policies/extensioninstallforcelist) | Control which extensions are installed silently |
| [ExtensionInstallSources](microsoft-edge-policies/extensioninstallsources) | Configure extension and user script install sources |
| [ExtensionInstallTypeBlocklist](microsoft-edge-policies/extensioninstalltypeblocklist) | Blocklist for extension install types |
| [ExtensionManifestV2Availability](microsoft-edge-policies/extensionmanifestv2availability) | Control Manifest v2 extension availability |
| [ExtensionSettings](microsoft-edge-policies/extensionsettings) | Configure extension management settings |
| [MandatoryExtensionsForInPrivateNavigation](microsoft-edge-policies/mandatoryextensionsforinprivatenavigation) | Specify extensions users must allow in order to navigate using InPrivate mode |

### Games settings

| Policy Name | Caption |
| --- | --- |
| [AllowGamesMenu](microsoft-edge-policies/allowgamesmenu) | Allow users to access the games menu (deprecated) |
| [AllowSurfGame](microsoft-edge-policies/allowsurfgame) | Allow surf game |
| [GamerModeEnabled](microsoft-edge-policies/gamermodeenabled) | Enable Gamer Mode (obsolete) |

### Generative AI

| Policy Name | Caption |
| --- | --- |
| [AIGenThemesEnabled](microsoft-edge-policies/aigenthemesenabled) | Enables DALL-E themes generation |
| [GenAILocalFoundationalModelSettings](microsoft-edge-policies/genailocalfoundationalmodelsettings) | Settings for GenAI local foundational model |

### HTTP authentication

| Policy Name | Caption |
| --- | --- |
| [AllHttpAuthSchemesAllowedForOrigins](microsoft-edge-policies/allhttpauthschemesallowedfororigins) | List of origins that allow all HTTP authentication |
| [AllowCrossOriginAuthPrompt](microsoft-edge-policies/allowcrossoriginauthprompt) | Allow cross-origin HTTP Authentication prompts |
| [AuthAndroidNegotiateAccountType](microsoft-edge-policies/authandroidnegotiateaccounttype) | Account type for HTTP Negotiate authentication |
| [AuthNegotiateDelegateAllowlist](microsoft-edge-policies/authnegotiatedelegateallowlist) | Specifies a list of servers that Microsoft Edge can delegate user credentials to |
| [AuthNegotiateDelegateByKdcPolicy](microsoft-edge-policies/authnegotiatedelegatebykdcpolicy) | Use KDC policy to delegate credentials. |
| [AuthSchemes](microsoft-edge-policies/authschemes) | Supported authentication schemes |
| [AuthServerAllowlist](microsoft-edge-policies/authserverallowlist) | Configure list of allowed authentication servers |
| [BasicAuthOverHttpEnabled](microsoft-edge-policies/basicauthoverhttpenabled) | Allow Basic authentication for HTTP |
| [DisableAuthNegotiateCnameLookup](microsoft-edge-policies/disableauthnegotiatecnamelookup) | Disable CNAME lookup when negotiating Kerberos authentication |
| [EnableAuthNegotiatePort](microsoft-edge-policies/enableauthnegotiateport) | Include non-standard port in Kerberos SPN |
| [GloballyScopeHTTPAuthCacheEnabled](microsoft-edge-policies/globallyscopehttpauthcacheenabled) | Enable globally scoped HTTP auth cache |
| [NtlmV2Enabled](microsoft-edge-policies/ntlmv2enabled) | Control whether NTLMv2 authentication is enabled |
| [WindowsHelloForHTTPAuthEnabled](microsoft-edge-policies/windowshelloforhttpauthenabled) | Windows Hello For HTTP Auth Enabled |

### Identity and sign-in

| Policy Name | Caption |
| --- | --- |
| [AutomaticProfileSwitchingSiteList](microsoft-edge-policies/automaticprofileswitchingsitelist) | Configure the automatic profile switching site list |
| [EdgeBlockSignInEnabled](microsoft-edge-policies/edgeblocksigninenabled) | Block Sign In to Edge |
| [EdgeDefaultProfileEnabled](microsoft-edge-policies/edgedefaultprofileenabled) | Default Profile Setting Enabled |
| [EdgeOpenExternalLinksWithAppSpecifiedProfile](microsoft-edge-policies/edgeopenexternallinkswithappspecifiedprofile) | Prioritize App specified profile to open external links |
| [EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled](microsoft-edge-policies/edgeopenexternallinkswithprimaryworkprofileenabled) | Use Primary Work Profile as default to open external links |
| [EditProfileEnabled](microsoft-edge-policies/editprofileenabled) | Enable editing profile in settings |
| [GuidedSwitchEnabled](microsoft-edge-policies/guidedswitchenabled) | Guided Switch Enabled |
| [ImplicitSignInEnabled](microsoft-edge-policies/implicitsigninenabled) | Enable implicit sign-in |
| [LinkedAccountEnabled](microsoft-edge-policies/linkedaccountenabled) | Enable the linked account feature (obsolete) |
| [M365AuthPopupsInWorkEnabled](microsoft-edge-policies/m365authpopupsinworkenabled) | Allow M365 authentication popups in work profiles |
| [OneAuthAuthenticationEnforced](microsoft-edge-policies/oneauthauthenticationenforced) | OneAuth Authentication Flow Enforced for signin |
| [OnlyOnPremisesImplicitSigninEnabled](microsoft-edge-policies/onlyonpremisesimplicitsigninenabled) | Only on-premises account enabled for implicit sign-in |
| [ProactiveAuthWorkflowEnabled](microsoft-edge-policies/proactiveauthworkflowenabled) | Enable proactive authentication |
| [SeamlessWebToBrowserSignInEnabled](microsoft-edge-policies/seamlesswebtobrowsersigninenabled) | Seamless Web To Browser Sign-in Enabled |
| [SignInCtaOnNtpEnabled](microsoft-edge-policies/signinctaonntpenabled) | Enable sign in click to action dialog (obsolete) |
| [SwitchIntranetSitesToWorkProfile](microsoft-edge-policies/switchintranetsitestoworkprofile) | Switch intranet sites to a work or school profile |
| [SwitchSitesOnIEModeSiteListToWorkProfile](microsoft-edge-policies/switchsitesoniemodesitelisttoworkprofile) | Switch sites on the IE mode site list to a work or school profile |
| [WAMAuthBelowWin10RS3Enabled](microsoft-edge-policies/wamauthbelowwin10rs3enabled) | WAM for authentication below Windows 10 RS3 enabled |
| [WebSSOInIframeEnabled](microsoft-edge-policies/webssoiniframeenabled) | Enable Web SSO for iframe requests |
| [WebToBrowserSignInEnabled](microsoft-edge-policies/webtobrowsersigninenabled) | Web To Browser Sign-in Enabled |

### Idle Browser Actions

| Policy Name | Caption |
| --- | --- |
| [IdleTimeout](microsoft-edge-policies/idletimeout) | Delay before running idle actions |
| [IdleTimeoutActions](microsoft-edge-policies/idletimeoutactions) | Actions to run when the computer is idle |

### Immersive Reader settings

| Policy Name | Caption |
| --- | --- |
| [ImmersiveReaderGrammarToolsEnabled](microsoft-edge-policies/immersivereadergrammartoolsenabled) | Enable Grammar Tools feature within Immersive Reader in Microsoft Edge (obsolete) |
| [ImmersiveReaderPictureDictionaryEnabled](microsoft-edge-policies/immersivereaderpicturedictionaryenabled) | Enable Picture Dictionary feature within Immersive Reader in Microsoft Edge (obsolete) |

### Import

| Policy Name | Caption |
| --- | --- |
| [ImportAutofillFormData](microsoft-edge-policies/importautofillformdata) | Allow importing of autofill form data |
| [ImportBrowserSettings](microsoft-edge-policies/importbrowsersettings) | Allow importing of browser settings |
| [ImportCookies](microsoft-edge-policies/importcookies) | Allow importing of Cookies |
| [ImportExtensions](microsoft-edge-policies/importextensions) | Allow importing of extensions |
| [ImportFavorites](microsoft-edge-policies/importfavorites) | Allow importing of favorites |
| [ImportHistory](microsoft-edge-policies/importhistory) | Allow importing of browsing history |
| [ImportHomepage](microsoft-edge-policies/importhomepage) | Allow importing of home page settings |
| [ImportOnEachLaunch](microsoft-edge-policies/importoneachlaunch) | Allow import of data from other browsers on each Microsoft Edge launch |
| [ImportOpenTabs](microsoft-edge-policies/importopentabs) | Allow importing of open tabs |
| [ImportPasswordsDisabled](microsoft-edge-policies/importpasswordsdisabled) | Prevent importing passwords from Password Manager |
| [ImportPaymentInfo](microsoft-edge-policies/importpaymentinfo) | Allow importing of payment info |
| [ImportSavedPasswords](microsoft-edge-policies/importsavedpasswords) | Allow importing of saved passwords |
| [ImportSearchEngine](microsoft-edge-policies/importsearchengine) | Allow importing of search engine settings |
| [ImportShortcuts](microsoft-edge-policies/importshortcuts) | Allow importing of shortcuts |
| [ImportStartupPageSettings](microsoft-edge-policies/importstartuppagesettings) | Allow importing of startup page settings |

### Internet Explorer Mode

| Policy Name | Caption |
| --- | --- |
| [InternetExplorerIntegrationAlwaysUseOSCapture](microsoft-edge-policies/internetexplorerintegrationalwaysuseoscapture) | Always use the OS capture engine to avoid issues with capturing Internet Explorer mode tabs |
| [InternetExplorerIntegrationAlwaysWaitForUnload](microsoft-edge-policies/internetexplorerintegrationalwayswaitforunload) | Wait for Internet Explorer mode tabs to completely unload before ending the browser session |
| [InternetExplorerIntegrationCloudNeutralSitesReporting](microsoft-edge-policies/internetexplorerintegrationcloudneutralsitesreporting) | Configure reporting of potentially misconfigured neutral site URLs to the M365 Admin Center Site Lists app |
| [InternetExplorerIntegrationCloudSiteList](microsoft-edge-policies/internetexplorerintegrationcloudsitelist) | Configure the Enterprise Mode Cloud Site List |
| [InternetExplorerIntegrationCloudUserSitesReporting](microsoft-edge-policies/internetexplorerintegrationcloudusersitesreporting) | Configure reporting of IE Mode user list entries to the M365 Admin Center Site Lists app |
| [InternetExplorerIntegrationComplexNavDataTypes](microsoft-edge-policies/internetexplorerintegrationcomplexnavdatatypes) | Configure whether form data and HTTP headers will be sent when entering or exiting Internet Explorer mode |
| [InternetExplorerIntegrationEnhancedHangDetection](microsoft-edge-policies/internetexplorerintegrationenhancedhangdetection) | Configure enhanced hang detection for Internet Explorer mode |
| [InternetExplorerIntegrationLevel](microsoft-edge-policies/internetexplorerintegrationlevel) | Configure Internet Explorer integration |
| [InternetExplorerIntegrationLocalFileAllowed](microsoft-edge-policies/internetexplorerintegrationlocalfileallowed) | Allow launching of local files in Internet Explorer mode |
| [InternetExplorerIntegrationLocalFileExtensionAllowList](microsoft-edge-policies/internetexplorerintegrationlocalfileextensionallowlist) | Open local files in Internet Explorer mode file extension allow list |
| [InternetExplorerIntegrationLocalFileShowContextMenu](microsoft-edge-policies/internetexplorerintegrationlocalfileshowcontextmenu) | Show context menu to open a file:// link in Internet Explorer mode |
| [InternetExplorerIntegrationLocalMhtFileAllowed](microsoft-edge-policies/internetexplorerintegrationlocalmhtfileallowed) | Allow local MHTML files to open automatically in Internet Explorer mode |
| [InternetExplorerIntegrationLocalSiteListExpirationDays](microsoft-edge-policies/internetexplorerintegrationlocalsitelistexpirationdays) | Specify the number of days that a site remains on the local IE mode site list |
| [InternetExplorerIntegrationReloadInIEModeAllowed](microsoft-edge-policies/internetexplorerintegrationreloadiniemodeallowed) | Allow unconfigured sites to be reloaded in Internet Explorer mode |
| [InternetExplorerIntegrationSiteList](microsoft-edge-policies/internetexplorerintegrationsitelist) | Configure the Enterprise Mode Site List |
| [InternetExplorerIntegrationSiteListRefreshInterval](microsoft-edge-policies/internetexplorerintegrationsitelistrefreshinterval) | Configure how frequently the Enterprise Mode Site List is refreshed |
| [InternetExplorerIntegrationSiteRedirect](microsoft-edge-policies/internetexplorerintegrationsiteredirect) | Specify how "in-page" navigations to unconfigured sites behave when started from Internet Explorer mode pages |
| [InternetExplorerIntegrationTestingAllowed](microsoft-edge-policies/internetexplorerintegrationtestingallowed) | Allow Internet Explorer mode testing (obsolete) |
| [InternetExplorerIntegrationWindowOpenHeightAdjustment](microsoft-edge-policies/internetexplorerintegrationwindowopenheightadjustment) | Configure the pixel adjustment between window.open heights sourced from IE mode pages vs. Edge mode pages |
| [InternetExplorerIntegrationWindowOpenWidthAdjustment](microsoft-edge-policies/internetexplorerintegrationwindowopenwidthadjustment) | Configure the pixel adjustment between window.open widths sourced from IE mode pages vs. Edge mode pages |
| [InternetExplorerIntegrationZoneIdentifierMhtFileAllowed](microsoft-edge-policies/internetexplorerintegrationzoneidentifiermhtfileallowed) | Automatically open downloaded MHT or MHTML files from the web in Internet Explorer mode |
| [InternetExplorerModeClearDataOnExitEnabled](microsoft-edge-policies/internetexplorermodecleardataonexitenabled) | Clear history for IE and IE mode every time you exit |
| [InternetExplorerModeEnableSavePageAs](microsoft-edge-policies/internetexplorermodeenablesavepageas) | Allow Save page as in Internet Explorer mode |
| [InternetExplorerModeTabInEdgeModeAllowed](microsoft-edge-policies/internetexplorermodetabinedgemodeallowed) | Allow sites configured for Internet Explorer mode to open in Microsoft Edge |
| [InternetExplorerModeToolbarButtonEnabled](microsoft-edge-policies/internetexplorermodetoolbarbuttonenabled) | Show the Reload in Internet Explorer mode button in the toolbar |
| [InternetExplorerSetForegroundWhenActive](microsoft-edge-policies/internetexplorersetforegroundwhenactive) | Keep the active Microsoft Edge window with an Internet Explorer mode tab always in the foreground. |
| [InternetExplorerZoomDisplay](microsoft-edge-policies/internetexplorerzoomdisplay) | Display zoom in IE Mode tabs with DPI Scale included like it is in Internet Explorer |

### Kiosk Mode settings

| Policy Name | Caption |
| --- | --- |
| [EdgeEnableKioskMode](microsoft-edge-policies/edgeenablekioskmode) | Enable Microsoft Edge kiosk mode on Android |
| [EdgeShowAddressBarInKioskMode](microsoft-edge-policies/edgeshowaddressbarinkioskmode) | Show address bar in Microsoft Edge Android kiosk mode |
| [EdgeShowBottomBarInKioskMode](microsoft-edge-policies/edgeshowbottombarinkioskmode) | Show bottom action bar in Microsoft Edge Android kiosk mode |
| [KioskAddressBarEditingEnabled](microsoft-edge-policies/kioskaddressbareditingenabled) | Configure address bar editing for kiosk mode public browsing experience |
| [KioskDeleteDownloadsOnExit](microsoft-edge-policies/kioskdeletedownloadsonexit) | Delete files downloaded as part of kiosk session when Microsoft Edge closes |
| [KioskSwipeGesturesEnabled](microsoft-edge-policies/kioskswipegesturesenabled) | Swipe gestures in Microsoft Edge kiosk mode enabled |

### Manageability

| Policy Name | Caption |
| --- | --- |
| [AllowEdgeDataInBackups](microsoft-edge-policies/allowedgedatainbackups) | Allow backup of Microsoft Edge data |
| [EdgeAllowedAccountOnly](microsoft-edge-policies/edgeallowedaccountonly) | Restrict sign-in to allowed accounts only |
| [EdgeAllowedAccountUPN](microsoft-edge-policies/edgeallowedaccountupn) | Configure allowed account UPN pattern for sign-in |
| [EdgeManagementEnabled](microsoft-edge-policies/edgemanagementenabled) | Microsoft Edge management enabled |
| [EdgeManagementEnrollmentToken](microsoft-edge-policies/edgemanagementenrollmenttoken) | Microsoft Edge management enrollment token |
| [EdgeManagementExtensionsFeedbackEnabled](microsoft-edge-policies/edgemanagementextensionsfeedbackenabled) | Microsoft Edge management extensions feedback enabled |
| [EdgeManagementPolicyOverridesPlatformPolicy](microsoft-edge-policies/edgemanagementpolicyoverridesplatformpolicy) | Microsoft Edge management service policy overrides platform policy. |
| [EdgeManagementUserPolicyOverridesCloudMachinePolicy](microsoft-edge-policies/edgemanagementuserpolicyoverridescloudmachinepolicy) | Allow cloud-based Microsoft Edge management service user policies to override local user policies. |
| [MAMEnabled](microsoft-edge-policies/mamenabled) | Mobile App Management Enabled |
| [MAMWithDeviceDLPEnabled](microsoft-edge-policies/mamwithdevicedlpenabled) | Allow MAM enrollment when managed device has Purview DLP policy configured |
| [ManagedTopSites](microsoft-edge-policies/managedtopsites) | Configure managed top sites on New Tab Page |

### Microsoft Office

| Policy Name | Caption |
| --- | --- |
| [MicrosoftOfficeMenuEnabled](microsoft-edge-policies/microsoftofficemenuenabled) | Allow users to access the Microsoft Office menu (deprecated) |
| [OutlookHubMenuEnabled](microsoft-edge-policies/outlookhubmenuenabled) | Allow users to access the Outlook menu (obsolete) |
| [QuickViewOfficeFilesEnabled](microsoft-edge-policies/quickviewofficefilesenabled) | Manage QuickView Office files capability in Microsoft Edge |
| [ShowOfficeShortcutInFavoritesBar](microsoft-edge-policies/showofficeshortcutinfavoritesbar) | Show Microsoft Office shortcut in favorites bar (deprecated) |

### Native Messaging

| Policy Name | Caption |
| --- | --- |
| [NativeMessagingAllowlist](microsoft-edge-policies/nativemessagingallowlist) | Control which native messaging hosts users can use |
| [NativeMessagingBlocklist](microsoft-edge-policies/nativemessagingblocklist) | Configure native messaging block list |
| [NativeMessagingUserLevelHosts](microsoft-edge-policies/nativemessaginguserlevelhosts) | Allow user-level native messaging hosts (installed without admin permissions) |

### Network settings

| Policy Name | Caption |
| --- | --- |
| [AccessControlAllowMethodsInCORSPreflightSpecConformant](microsoft-edge-policies/accesscontrolallowmethodsincorspreflightspecconformant) | Make Access-Control-Allow-Methods matching in CORS preflight spec conformant |
| [AdditionalDnsQueryTypesEnabled](microsoft-edge-policies/additionaldnsquerytypesenabled) | Allow DNS queries for more DNS record types |
| [BlockTruncatedCookies](microsoft-edge-policies/blocktruncatedcookies) | Block truncated cookies (obsolete) |
| [BuiltInDnsClientEnabled](microsoft-edge-policies/builtindnsclientenabled) | Use built-in DNS client |
| [CompressionDictionaryTransportEnabled](microsoft-edge-policies/compressiondictionarytransportenabled) | Enable compression dictionary transport support |
| [DataURLWhitespacePreservationEnabled](microsoft-edge-policies/dataurlwhitespacepreservationenabled) | DataURL Whitespace Preservation for all media types |
| [DnsOverHttpsMode](microsoft-edge-policies/dnsoverhttpsmode) | Control the mode of DNS-over-HTTPS |
| [DnsOverHttpsTemplates](microsoft-edge-policies/dnsoverhttpstemplates) | Specify URI template of desired DNS-over-HTTPS resolver |
| [EdgeNetworkStackPref](microsoft-edge-policies/edgenetworkstackpref) | Switch network stack between Chromium and iOS |
| [ExplicitlyAllowedNetworkPorts](microsoft-edge-policies/explicitlyallowednetworkports) | Explicitly allowed network ports |
| [FetchKeepaliveDurationSecondsOnShutdown](microsoft-edge-policies/fetchkeepalivedurationsecondsonshutdown) | Fetch keepalive duration on shutdown |
| [HappyEyeballsV3Enabled](microsoft-edge-policies/happyeyeballsv3enabled) | Use the Happy Eyeballs V3 algorithm for connection attempts |
| [IPv6ReachabilityOverrideEnabled](microsoft-edge-policies/ipv6reachabilityoverrideenabled) | Enable IPv6 reachability check override |
| [LocalNetworkAccessAllowedForUrls](microsoft-edge-policies/localnetworkaccessallowedforurls) | Allow sites to make network requests to local devices and local network endpoints. |
| [LocalNetworkAccessBlockedForUrls](microsoft-edge-policies/localnetworkaccessblockedforurls) | Block sites from making network requests to local devices and local network endpoints. |
| [LocalNetworkAccessIpAddressSpaceOverrides](microsoft-edge-policies/localnetworkaccessipaddressspaceoverrides) | Override IP address space mappings |
| [LocalNetworkAccessPermissionsPolicyDefaultEnabled](microsoft-edge-policies/localnetworkaccesspermissionspolicydefaultenabled) | Allow Local Network Access (LNA) requests in subframes without explicit delegation |
| [LocalNetworkAccessRestrictionsEnabled](microsoft-edge-policies/localnetworkaccessrestrictionsenabled) | Specifies whether to block requests from public websites to devices on a user's local network. (obsolete) |
| [LocalNetworkAccessRestrictionsTemporaryOptOut](microsoft-edge-policies/localnetworkaccessrestrictionstemporaryoptout) | Specifies whether to opt out of Local Network Access restrictions |
| [LocalNetworkAllowedForUrls](microsoft-edge-policies/localnetworkallowedforurls) | Allow sites to make network requests to local network endpoints. |
| [LocalNetworkBlockedForUrls](microsoft-edge-policies/localnetworkblockedforurls) | Block sites from making network requests to local network endpoints. |
| [LoopbackNetworkAllowedForUrls](microsoft-edge-policies/loopbacknetworkallowedforurls) | Allow sites to make network requests to the local device. |
| [LoopbackNetworkBlockedForUrls](microsoft-edge-policies/loopbacknetworkblockedforurls) | Block sites from making network requests to the local device. |
| [NetworkPredictionOptions](microsoft-edge-policies/networkpredictionoptions) | Enable network prediction |
| [QuicAllowed](microsoft-edge-policies/quicallowed) | Allow QUIC protocol |
| [ZstdContentEncodingEnabled](microsoft-edge-policies/zstdcontentencodingenabled) | Enable zstd content encoding support (obsolete) |

### PDF Reader

| Policy Name | Caption |
| --- | --- |
| [AlwaysOpenPdfExternally](microsoft-edge-policies/alwaysopenpdfexternally) | Always open PDF files externally |
| [NewPDFReaderEnabled](microsoft-edge-policies/newpdfreaderenabled) | Microsoft Edge built-in PDF reader powered by Adobe Acrobat enabled |
| [PDFSecureMode](microsoft-edge-policies/pdfsecuremode) | Secure mode and Certificate-based Digital Signature validation in native PDF reader |
| [PDFXFAEnabled](microsoft-edge-policies/pdfxfaenabled) | XFA support in native PDF reader enabled |
| [PdfViewerOutOfProcessIframeEnabled](microsoft-edge-policies/pdfvieweroutofprocessiframeenabled) | Use out-of-process iframe PDF Viewer |
| [RestorePdfView](microsoft-edge-policies/restorepdfview) | Restore PDF view |
| [ShowAcrobatSubscriptionButton](microsoft-edge-policies/showacrobatsubscriptionbutton) | Shows button on native PDF viewer in Microsoft Edge that allows users to sign up for Adobe Acrobat subscription |
| [ViewXFAPDFInIEModeAllowedFileHash](microsoft-edge-policies/viewxfapdfiniemodeallowedfilehash) | View XFA-based PDF files using IE Mode for allowed file hash. |
| [ViewXFAPDFInIEModeAllowedOrigins](microsoft-edge-policies/viewxfapdfiniemodeallowedorigins) | View XFA-based PDF files using IE Mode for allowed file origin. |

### Password manager and protection

| Policy Name | Caption |
| --- | --- |
| [BiometricAuthenticationBeforeFilling](microsoft-edge-policies/biometricauthenticationbeforefilling) | Enable Device authentication for password autofill |
| [DeletingUndecryptablePasswordsEnabled](microsoft-edge-policies/deletingundecryptablepasswordsenabled) | Enable deleting undecryptable passwords |
| [PasswordDeleteOnBrowserCloseEnabled](microsoft-edge-policies/passworddeleteonbrowsercloseenabled) | Prevent passwords from being deleted if any Edge settings is enabled to delete browsing data when Microsoft Edge closes |
| [PasswordExportEnabled](microsoft-edge-policies/passwordexportenabled) | Enable exporting saved passwords from Password Manager |
| [PasswordGeneratorEnabled](microsoft-edge-policies/passwordgeneratorenabled) | Allow users to get a strong password suggestion whenever they are creating an account online |
| [PasswordManagerBlocklist](microsoft-edge-policies/passwordmanagerblocklist) | Configure the list of domains for which the password manager UI (Save and Fill) will be disabled |
| [PasswordManagerEnabled](microsoft-edge-policies/passwordmanagerenabled) | Enable saving passwords to the password manager |
| [PasswordManagerPasskeysEnabled](microsoft-edge-policies/passwordmanagerpasskeysenabled) | Enable saving passkeys to the password manager |
| [PasswordManagerRestrictLengthEnabled](microsoft-edge-policies/passwordmanagerrestrictlengthenabled) | Restrict the length of passwords that can be saved in the Password Manager |
| [PasswordMonitorAllowed](microsoft-edge-policies/passwordmonitorallowed) | Allow users to be alerted if their passwords are found to be unsafe |
| [PasswordProtectionChangePasswordURL](microsoft-edge-policies/passwordprotectionchangepasswordurl) | Configure the change password URL |
| [PasswordProtectionLoginURLs](microsoft-edge-policies/passwordprotectionloginurls) | Configure the list of enterprise login URLs where the password protection service should capture salted hashes of a password |
| [PasswordProtectionWarningTrigger](microsoft-edge-policies/passwordprotectionwarningtrigger) | Configure password protection warning trigger |
| [PasswordRevealEnabled](microsoft-edge-policies/passwordrevealenabled) | Enable Password reveal button |
| [PrimaryPasswordSetting](microsoft-edge-policies/primarypasswordsetting) | Configures a setting that asks users to enter their device password while using password autofill |
| [ThirdPartyPasswordManagersAllowed](microsoft-edge-policies/thirdpartypasswordmanagersallowed) | Allow using Third-Party Password Managers in Microsoft Edge on Android |

### Performance

| Policy Name | Caption |
| --- | --- |
| [EfficiencyMode](microsoft-edge-policies/efficiencymode) | Configure when energy saver (previously named efficiency mode) should become active |
| [EfficiencyModeEnabled](microsoft-edge-policies/efficiencymodeenabled) | Efficiency mode enabled |
| [EfficiencyModeOnPowerEnabled](microsoft-edge-policies/efficiencymodeonpowerenabled) | Enable efficiency mode when the device is connected to a power source |
| [ExtensionsPerformanceDetectorEnabled](microsoft-edge-policies/extensionsperformancedetectorenabled) | Extensions Performance Detector enabled |
| [IntensiveWakeUpThrottlingEnabled](microsoft-edge-policies/intensivewakeupthrottlingenabled) | Control the IntensiveWakeUpThrottling feature |
| [PerformanceDetectorEnabled](microsoft-edge-policies/performancedetectorenabled) | Performance Detector Enabled |
| [PinBrowserEssentialsToolbarButton](microsoft-edge-policies/pinbrowseressentialstoolbarbutton) | Pin browser essentials toolbar button |
| [RAMResourceControlsEnabled](microsoft-edge-policies/ramresourcecontrolsenabled) | Enable RAM (memory) resource controls |
| [StartupBoostEnabled](microsoft-edge-policies/startupboostenabled) | Enable startup boost |
| [TotalMemoryLimitMb](microsoft-edge-policies/totalmemorylimitmb) | Set limit on megabytes of memory a single Microsoft Edge instance can use |

### Permit or deny screen capture

| Policy Name | Caption |
| --- | --- |
| [AudioCaptureAllowed](microsoft-edge-policies/audiocaptureallowed) | Allow or block audio capture |
| [AudioCaptureAllowedUrls](microsoft-edge-policies/audiocaptureallowedurls) | Sites that can access audio capture devices without requesting permission |
| [DisableScreenshots](microsoft-edge-policies/disablescreenshots) | Disable taking screenshots |
| [SameOriginTabCaptureAllowedByOrigins](microsoft-edge-policies/sameorigintabcaptureallowedbyorigins) | Allow Same Origin Tab capture by these origins |
| [ScreenCaptureAllowed](microsoft-edge-policies/screencaptureallowed) | Allow or deny screen capture |
| [ScreenCaptureAllowedByOrigins](microsoft-edge-policies/screencaptureallowedbyorigins) | Allow Desktop, Window, and Tab capture by these origins |
| [ScreenCaptureWithoutGestureAllowedForOrigins](microsoft-edge-policies/screencapturewithoutgestureallowedfororigins) | Allow screen capture without prior user gesture |
| [TabCaptureAllowedByOrigins](microsoft-edge-policies/tabcaptureallowedbyorigins) | Allow Tab capture by these origins |
| [VideoCaptureAllowed](microsoft-edge-policies/videocaptureallowed) | Allow or block video capture |
| [VideoCaptureAllowedUrls](microsoft-edge-policies/videocaptureallowedurls) | Sites that can access video capture devices without requesting permission |
| [WebCaptureEnabled](microsoft-edge-policies/webcaptureenabled) | Enable the Screenshot (previously named Web Capture) feature in Microsoft Edge |
| [WindowCaptureAllowedByOrigins](microsoft-edge-policies/windowcaptureallowedbyorigins) | Allow Window and Tab capture by these origins |

### Personalization

| Policy Name | Caption |
| --- | --- |
| [PersonalizationReportingEnabled](microsoft-edge-policies/personalizationreportingenabled) | Allow personalization of ads, Microsoft Edge, search, news and other Microsoft services by sending browsing history, favorites and collections, usage and other browsing data to Microsoft |
| [PersonalizeTopSitesInCustomizeSidebarEnabled](microsoft-edge-policies/personalizetopsitesincustomizesidebarenabled) | Personalize my top sites in Customize Sidebar enabled by default |

### Printing

| Policy Name | Caption |
| --- | --- |
| [DefaultPrinterSelection](microsoft-edge-policies/defaultprinterselection) | Default printer selection rules |
| [OopPrintDriversAllowed](microsoft-edge-policies/oopprintdriversallowed) | Out-of-process print drivers allowed |
| [PrintHeaderFooter](microsoft-edge-policies/printheaderfooter) | Print headers and footers |
| [PrintPdfAsImageDefault](microsoft-edge-policies/printpdfasimagedefault) | Print PDF as Image Default |
| [PrintPostScriptMode](microsoft-edge-policies/printpostscriptmode) | Print PostScript Mode |
| [PrintPreviewStickySettings](microsoft-edge-policies/printpreviewstickysettings) | Configure the sticky print preview settings |
| [PrintPreviewUseSystemDefaultPrinter](microsoft-edge-policies/printpreviewusesystemdefaultprinter) | Set the system default printer as the default printer |
| [PrintRasterizationMode](microsoft-edge-policies/printrasterizationmode) | Print Rasterization Mode |
| [PrintRasterizePdfDpi](microsoft-edge-policies/printrasterizepdfdpi) | Print Rasterize PDF DPI |
| [PrintStickySettings](microsoft-edge-policies/printstickysettings) | Print preview sticky settings |
| [PrinterTypeDenyList](microsoft-edge-policies/printertypedenylist) | Disable printer types on the deny list |
| [PrintingAllowedBackgroundGraphicsModes](microsoft-edge-policies/printingallowedbackgroundgraphicsmodes) | Restrict background graphics printing mode |
| [PrintingBackgroundGraphicsDefault](microsoft-edge-policies/printingbackgroundgraphicsdefault) | Default background graphics printing mode |
| [PrintingEnabled](microsoft-edge-policies/printingenabled) | Enable printing |
| [PrintingLPACSandboxEnabled](microsoft-edge-policies/printinglpacsandboxenabled) | Enable Printing LPAC Sandbox |
| [PrintingPaperSizeDefault](microsoft-edge-policies/printingpapersizedefault) | Default printing page size |
| [PrintingWebpageLayout](microsoft-edge-policies/printingwebpagelayout) | Sets layout for printing |
| [UseSystemPrintDialog](microsoft-edge-policies/usesystemprintdialog) | Print using system print dialog |

### Private Network Request Settings

| Policy Name | Caption |
| --- | --- |
| [InsecurePrivateNetworkRequestsAllowed](microsoft-edge-policies/insecureprivatenetworkrequestsallowed) | Specifies whether to allow websites to make requests to any network endpoint in an insecure manner. (obsolete) |
| [InsecurePrivateNetworkRequestsAllowedForUrls](microsoft-edge-policies/insecureprivatenetworkrequestsallowedforurls) | Allow the listed sites to make requests to more-private network endpoints from in an insecure manner (obsolete) |
| [PrivateNetworkAccessRestrictionsEnabled](microsoft-edge-policies/privatenetworkaccessrestrictionsenabled) | Specifies whether to apply restrictions to requests to more private network endpoints (obsolete) |

### Profile settings

| Policy Name | Caption |
| --- | --- |
| [ProfileTypeInProfileButtonEnabled](microsoft-edge-policies/profiletypeinprofilebuttonenabled) | Controls the display of the profile button label for the work or school profile |

### Protected Content

| Policy Name | Caption |
| --- | --- |
| [ProtectedContentIdentifiersAllowed](microsoft-edge-policies/protectedcontentidentifiersallowed) | Allows web pages to use identifiers for the purpose of protected content playback |

### Proxy server

| Policy Name | Caption |
| --- | --- |
| [ProxyBypassList](microsoft-edge-policies/proxybypasslist) | Configure proxy bypass rules (deprecated) |
| [ProxyMode](microsoft-edge-policies/proxymode) | Configure proxy server settings (deprecated) |
| [ProxyOverrideRules](microsoft-edge-policies/proxyoverriderules) | Proxy override rules |
| [ProxyPacUrl](microsoft-edge-policies/proxypacurl) | Set the proxy .pac file URL (deprecated) |
| [ProxyServer](microsoft-edge-policies/proxyserver) | Configure address or URL of proxy server (deprecated) |
| [ProxySettings](microsoft-edge-policies/proxysettings) | Proxy settings |

### Related Website Sets Settings

| Policy Name | Caption |
| --- | --- |
| [RelatedWebsiteSetsEnabled](microsoft-edge-policies/relatedwebsitesetsenabled) | Enable Related Website Sets (deprecated) |
| [RelatedWebsiteSetsOverrides](microsoft-edge-policies/relatedwebsitesetsoverrides) | Override Related Website Sets. (deprecated) |

### Scareware Blocker settings

| Policy Name | Caption |
| --- | --- |
| [ScarewareBlockerAllowListDomains](microsoft-edge-policies/scarewareblockerallowlistdomains) | Configure the list of domains where Microsoft Edge Scareware blockers don't run |
| [ScarewareBlockerBlocksDetectedSitesEnabled](microsoft-edge-policies/scarewareblockerblocksdetectedsitesenabled) | Configure Microsoft Edge scareware blocker to block sites detected as potential tech scams |
| [ScarewareBlockerProtectionEnabled](microsoft-edge-policies/scarewareblockerprotectionenabled) | Configure Microsoft Edge Scareware blocker protection |
| [ScarewareBlockerSendDetectedSitesToSmartScreenEnabled](microsoft-edge-policies/scarewareblockersenddetectedsitestosmartscreenenabled) | Configure Microsoft Edge Scareware blocker to share URLs of sites detected as potential tech scams with Microsoft Defender SmartScreen |

### Sleeping tabs settings

| Policy Name | Caption |
| --- | --- |
| [AutoDiscardSleepingTabsEnabled](microsoft-edge-policies/autodiscardsleepingtabsenabled) | Configure auto discard sleeping tabs |
| [SleepingTabsBlockedForUrls](microsoft-edge-policies/sleepingtabsblockedforurls) | Block sleeping tabs on specific sites |
| [SleepingTabsEnabled](microsoft-edge-policies/sleepingtabsenabled) | Configure sleeping tabs |
| [SleepingTabsTimeout](microsoft-edge-policies/sleepingtabstimeout) | Set the background tab inactivity timeout for sleeping tabs |

### SmartScreen settings

| Policy Name | Caption |
| --- | --- |
| [ExemptSmartScreenDownloadWarnings](microsoft-edge-policies/exemptsmartscreendownloadwarnings) | Disable SmartScreen AppRep based warnings for specified file types on specified domains |
| [NewSmartScreenLibraryEnabled](microsoft-edge-policies/newsmartscreenlibraryenabled) | Enable new SmartScreen library (obsolete) |
| [PreventSmartScreenPromptOverride](microsoft-edge-policies/preventsmartscreenpromptoverride) | Prevent bypassing Microsoft Defender SmartScreen prompts for sites |
| [PreventSmartScreenPromptOverrideForFiles](microsoft-edge-policies/preventsmartscreenpromptoverrideforfiles) | Prevent bypassing of Microsoft Defender SmartScreen warnings about downloads |
| [SmartScreenAllowListDomains](microsoft-edge-policies/smartscreenallowlistdomains) | Configure the list of domains for which Microsoft Defender SmartScreen won't trigger warnings |
| [SmartScreenDnsRequestsEnabled](microsoft-edge-policies/smartscreendnsrequestsenabled) | Enable Microsoft Defender SmartScreen DNS requests |
| [SmartScreenEnabled](microsoft-edge-policies/smartscreenenabled) | Configure Microsoft Defender SmartScreen |
| [SmartScreenForTrustedDownloadsEnabled](microsoft-edge-policies/smartscreenfortrusteddownloadsenabled) | Force Microsoft Defender SmartScreen checks on downloads from trusted sources |
| [SmartScreenPuaEnabled](microsoft-edge-policies/smartscreenpuaenabled) | Configure Microsoft Defender SmartScreen to block potentially unwanted apps |

### Startup, home page and new tab page

| Policy Name | Caption |
| --- | --- |
| [ConfigureNTPFeedTabVisibility](microsoft-edge-policies/configurentpfeedtabvisibility) | Configure whether the Discover or Work feed tabs are shown on the New Tab Page. |
| [HomepageIsNewTabPage](microsoft-edge-policies/homepageisnewtabpage) | Set the new tab page as the home page |
| [HomepageLocation](microsoft-edge-policies/homepagelocation) | Configure the home page URL |
| [NewTabPageAllowedBackgroundTypes](microsoft-edge-policies/newtabpageallowedbackgroundtypes) | Configure the background types allowed for the new tab page layout |
| [NewTabPageAppLauncherEnabled](microsoft-edge-policies/newtabpageapplauncherenabled) | Hide App Launcher on Microsoft Edge new tab page |
| [NewTabPageBingChatEnabled](microsoft-edge-policies/newtabpagebingchatenabled) | Disable Bing chat entry-points on Microsoft Edge Enterprise new tab page |
| [NewTabPageCompanyLogo](microsoft-edge-policies/newtabpagecompanylogo) | Set new tab page company logo (obsolete) |
| [NewTabPageCompanyLogoBackplateColor](microsoft-edge-policies/newtabpagecompanylogobackplatecolor) | Set the company logo backplate color on the new tab page. |
| [NewTabPageCompanyLogoEnabled](microsoft-edge-policies/newtabpagecompanylogoenabled) | Hide the company logo on the Microsoft Edge new tab page |
| [NewTabPageContentEnabled](microsoft-edge-policies/newtabpagecontentenabled) | Allow Microsoft content on the new tab page |
| [NewTabPageHideDefaultTopSites](microsoft-edge-policies/newtabpagehidedefaulttopsites) | Hide the default top sites from the new tab page |
| [NewTabPageLocation](microsoft-edge-policies/newtabpagelocation) | Configure the new tab page URL |
| [NewTabPageManagedQuickLinks](microsoft-edge-policies/newtabpagemanagedquicklinks) | Set new tab page quick links |
| [NewTabPagePrerenderEnabled](microsoft-edge-policies/newtabpageprerenderenabled) | Enable preload of the new tab page for faster rendering |
| [NewTabPageQuickLinksEnabled](microsoft-edge-policies/newtabpagequicklinksenabled) | Allow quick links on the new tab page |
| [NewTabPageSetFeedType](microsoft-edge-policies/newtabpagesetfeedtype) | Configure the Microsoft Edge new tab page experience (obsolete) |
| [RestoreOnStartup](microsoft-edge-policies/restoreonstartup) | Action to take on Microsoft Edge startup |
| [RestoreOnStartupURLs](microsoft-edge-policies/restoreonstartupurls) | Sites to open when the browser starts |
| [RestoreOnStartupUserURLsEnabled](microsoft-edge-policies/restoreonstartupuserurlsenabled) | Allow users to add and remove their own sites during startup when the RestoreOnStartupURLs policy is configured. |
| [SetNTPDefaultFeedTab](microsoft-edge-policies/setntpdefaultfeedtab) | Set the default New Tab Page feed tab to Work or Discover |
| [ShowHomeButton](microsoft-edge-policies/showhomebutton) | Show Home button on toolbar |

### WebRtc settings

| Policy Name | Caption |
| --- | --- |
| [WebRtcAllowLegacyTLSProtocols](microsoft-edge-policies/webrtcallowlegacytlsprotocols) | Allow legacy TLS/DTLS downgrade in WebRTC (obsolete) |
| [WebRtcIPHandlingUrl](microsoft-edge-policies/webrtciphandlingurl) | WebRTC IP Handling Policy for URL Patterns |
| [WebRtcLocalIpsAllowedUrls](microsoft-edge-policies/webrtclocalipsallowedurls) | Manage exposure of local IP addressess by WebRTC |
| [WebRtcLocalhostIpHandling](microsoft-edge-policies/webrtclocalhostiphandling) | Restrict exposure of local IP address by WebRTC |
| [WebRtcPostQuantumKeyAgreement](microsoft-edge-policies/webrtcpostquantumkeyagreement) | Enable post-quantum key agreement for WebRTC |
| [WebRtcRespectOsRoutingTableEnabled](microsoft-edge-policies/webrtcrespectosroutingtableenabled) | Enable support for Windows OS routing table rules when making peer to peer connections via WebRTC |
| [WebRtcUdpPortRange](microsoft-edge-policies/webrtcudpportrange) | Restrict the range of local UDP ports used by WebRTC |

### Additional

| Policy Name | Caption |
| --- | --- |
| [AADWebSiteSSOUsingThisProfileEnabled](microsoft-edge-policies/aadwebsitessousingthisprofileenabled) | Single sign-on for work or school sites using this profile enabled |
| [AdHocCodeSigningForPWAsEnabled](microsoft-edge-policies/adhoccodesigningforpwasenabled) | Native application signing during Progressive Web Application installation |
| [AdditionalSearchBoxEnabled](microsoft-edge-policies/additionalsearchboxenabled) | Enable additional search box in browser |
| [AdsSettingForIntrusiveAdsSites](microsoft-edge-policies/adssettingforintrusiveadssites) | Ads setting for sites with intrusive ads |
| [AdsTransparencyEnabled](microsoft-edge-policies/adstransparencyenabled) | Configure if the ads transparency feature is enabled |
| [AllowBackForwardCacheForCacheControlNoStorePageEnabled](microsoft-edge-policies/allowbackforwardcacheforcachecontrolnostorepageenabled) | Allow pages with Cache-Control: no-store header to enter back/forward cache |
| [AllowBrowsingWithCopilot](microsoft-edge-policies/allowbrowsingwithcopilot) | Controls the availability of browsing with Copilot in Microsoft Edge. |
| [AllowDeletingBrowserHistory](microsoft-edge-policies/allowdeletingbrowserhistory) | Enable deleting browser and download history |
| [AllowFileSelectionDialogs](microsoft-edge-policies/allowfileselectiondialogs) | Allow file selection dialogs |
| [AllowPopupsDuringPageUnload](microsoft-edge-policies/allowpopupsduringpageunload) | Allows a page to show popups during its unloading (obsolete) |
| [AllowSyncXHRInPageDismissal](microsoft-edge-policies/allowsyncxhrinpagedismissal) | Allow pages to send synchronous XHR requests during page dismissal (obsolete) |
| [AllowSystemNotifications](microsoft-edge-policies/allowsystemnotifications) | Allows system notifications |
| [AllowTokenBindingForUrls](microsoft-edge-policies/allowtokenbindingforurls) | Configure the list of sites for which Microsoft Edge will attempt to establish a Token Binding with (obsolete) |
| [AllowTrackingForUrls](microsoft-edge-policies/allowtrackingforurls) | Configure tracking prevention exceptions for specific sites |
| [AllowWebAuthnWithBrokenTlsCerts](microsoft-edge-policies/allowwebauthnwithbrokentlscerts) | Allow Web Authentication requests on sites with broken TLS certificates. |
| [AllowedDomainsForApps](microsoft-edge-policies/alloweddomainsforapps) | Define domains allowed to access Google Workspace |
| [AlternateErrorPagesEnabled](microsoft-edge-policies/alternateerrorpagesenabled) | Suggest similar pages when a webpage can't be found |
| [AmbientAuthenticationInPrivateModesEnabled](microsoft-edge-policies/ambientauthenticationinprivatemodesenabled) | Enable Ambient Authentication for InPrivate and Guest profiles |
| [AntiParallelOnStartUpEnabled](microsoft-edge-policies/antiparallelonstartupenabled) | Anti-Parallel On Start Up |
| [AppCacheForceEnabled](microsoft-edge-policies/appcacheforceenabled) | Allows the AppCache feature to be re-enabled, even if it's turned off by default (obsolete) |
| [ApplicationBoundEncryptionEnabled](microsoft-edge-policies/applicationboundencryptionenabled) | Enable Application Bound Encryption |
| [ApplicationLocaleValue](microsoft-edge-policies/applicationlocalevalue) | Set application locale |
| [AskBeforeCloseEnabled](microsoft-edge-policies/askbeforecloseenabled) | Get user confirmation before closing a browser window with multiple tabs |
| [AudioProcessHighPriorityEnabled](microsoft-edge-policies/audioprocesshighpriorityenabled) | Allow the audio process to run with priority above normal on Windows |
| [AudioSandboxEnabled](microsoft-edge-policies/audiosandboxenabled) | Allow the audio sandbox to run |
| [AutoImportAtFirstRun](microsoft-edge-policies/autoimportatfirstrun) | Automatically import another browser's data and settings at first run |
| [AutoLaunchProtocolsComponentEnabled](microsoft-edge-policies/autolaunchprotocolscomponentenabled) | AutoLaunch Protocols Component Enabled |
| [AutoLaunchProtocolsFromOrigins](microsoft-edge-policies/autolaunchprotocolsfromorigins) | Define a list of protocols that can launch an external application from listed origins without prompting the user |
| [AutofillAddressEnabled](microsoft-edge-policies/autofilladdressenabled) | Enable AutoFill for addresses |
| [AutofillCreditCardEnabled](microsoft-edge-policies/autofillcreditcardenabled) | Enable AutoFill for payment instruments |
| [AutofillMembershipsEnabled](microsoft-edge-policies/autofillmembershipsenabled) | Save and fill memberships |
| [AutomaticHttpsDefault](microsoft-edge-policies/automatichttpsdefault) | Configure Automatic HTTPS (obsolete) |
| [AutoplayAllowed](microsoft-edge-policies/autoplayallowed) | Allow media autoplay for websites |
| [AutoplayAllowlist](microsoft-edge-policies/autoplayallowlist) | Allow media autoplay on specific sites |
| [BackForwardCacheEnabled](microsoft-edge-policies/backforwardcacheenabled) | Control the BackForwardCache feature. |
| [BackgroundModeEnabled](microsoft-edge-policies/backgroundmodeenabled) | Continue running background apps after Microsoft Edge closes |
| [BackgroundTemplateListUpdatesEnabled](microsoft-edge-policies/backgroundtemplatelistupdatesenabled) | Enables background updates to the list of available templates for Collections and other features that use templates (deprecated) |
| [BeforeunloadEventCancelByPreventDefaultEnabled](microsoft-edge-policies/beforeunloadeventcancelbypreventdefaultenabled) | Control the behavior for the cancel dialog produced by the beforeunload event (obsolete) |
| [BingAdsSuppression](microsoft-edge-policies/bingadssuppression) | Block all ads on Bing search results |
| [BlockThirdPartyCookies](microsoft-edge-policies/blockthirdpartycookies) | Block third party cookies |
| [BrowserAddProfileEnabled](microsoft-edge-policies/browseraddprofileenabled) | Enable profile creation from the Identity flyout menu or the Settings page |
| [BrowserCodeIntegritySetting](microsoft-edge-policies/browsercodeintegritysetting) | Configure browser process code integrity guard setting |
| [BrowserGuestModeEnabled](microsoft-edge-policies/browserguestmodeenabled) | Enable guest mode |
| [BrowserGuestModeEnforced](microsoft-edge-policies/browserguestmodeenforced) | Enforce Edge guest mode |
| [BrowserLegacyExtensionPointsBlockingEnabled](microsoft-edge-policies/browserlegacyextensionpointsblockingenabled) | Enable browser legacy extension point blocking |
| [BrowserNetworkTimeQueriesEnabled](microsoft-edge-policies/browsernetworktimequeriesenabled) | Allow queries to a Browser Network Time service |
| [BrowserSignin](microsoft-edge-policies/browsersignin) | Browser sign-in settings |
| [BrowsingDataLifetime](microsoft-edge-policies/browsingdatalifetime) | Browsing Data Lifetime Settings |
| [BrowsingWithCopilotAllowList](microsoft-edge-policies/browsingwithcopilotallowlist) | Browsing with Copilot Allowed URLs |
| [BrowsingWithCopilotBlockList](microsoft-edge-policies/browsingwithcopilotblocklist) | Browsing with Copilot Blocked URLs |
| [BuiltInAIAPIsEnabled](microsoft-edge-policies/builtinaiapisenabled) | Allow pages to use the built-in AI APIs. |
| [BuiltinCertificateVerifierEnabled](microsoft-edge-policies/builtincertificateverifierenabled) | Determines whether the built-in certificate verifier will be used to verify server certificates (obsolete) |
| [CECPQ2Enabled](microsoft-edge-policies/cecpq2enabled) | CECPQ2 post-quantum key-agreement enabled for TLS (obsolete) |
| [CORSNonWildcardRequestHeadersSupport](microsoft-edge-policies/corsnonwildcardrequestheaderssupport) | CORS non-wildcard request header support enabled |
| [CSSCustomStateDeprecatedSyntaxEnabled](microsoft-edge-policies/csscustomstatedeprecatedsyntaxenabled) | Controls whether the deprecated :--foo syntax for CSS custom state is enabled (obsolete) |
| [ClearBrowsingDataOnExit](microsoft-edge-policies/clearbrowsingdataonexit) | Clear browsing data when Microsoft Edge closes |
| [ClearCachedImagesAndFilesOnExit](microsoft-edge-policies/clearcachedimagesandfilesonexit) | Clear cached images and files when Microsoft Edge closes |
| [ClickOnceEnabled](microsoft-edge-policies/clickonceenabled) | Allow users to open files using the ClickOnce protocol |
| [ClipboardAllowedForUrls](microsoft-edge-policies/clipboardallowedforurls) | Allow clipboard use on specific sites |
| [ClipboardBlockedForUrls](microsoft-edge-policies/clipboardblockedforurls) | Block clipboard use on specific sites |
| [CollectionsServicesAndExportsBlockList](microsoft-edge-policies/collectionsservicesandexportsblocklist) | Block access to a specified list of services and export targets in Collections |
| [CommandLineFlagSecurityWarningsEnabled](microsoft-edge-policies/commandlineflagsecuritywarningsenabled) | Enable security warnings for command-line flags |
| [ComponentUpdatesEnabled](microsoft-edge-policies/componentupdatesenabled) | Enable component updates in Microsoft Edge |
| [ComposeInlineEnabled](microsoft-edge-policies/composeinlineenabled) | Control access to Microsoft 365 Copilot writing assistance in Microsoft Edge for Business |
| [ConfigureDoNotTrack](microsoft-edge-policies/configuredonottrack) | Configure Do Not Track |
| [ConfigureFriendlyURLFormat](microsoft-edge-policies/configurefriendlyurlformat) | Configure the default paste format of URLs copied from Microsoft Edge, and determine if additional formats will be available to users |
| [ConfigureKeyboardShortcuts](microsoft-edge-policies/configurekeyboardshortcuts) | Configure the list of commands for which to disable keyboard shortcuts |
| [ConfigureOnPremisesAccountAutoSignIn](microsoft-edge-policies/configureonpremisesaccountautosignin) | Configure automatic sign in with an Active Directory domain account when there is no Azure AD domain account |
| [ConfigureOnlineTextToSpeech](microsoft-edge-policies/configureonlinetexttospeech) | Configure Online Text To Speech |
| [ConfigureShare](microsoft-edge-policies/configureshare) | Configure the Share experience |
| [ConfigureViewInFileExplorer](microsoft-edge-policies/configureviewinfileexplorer) | Configure the View in File Explorer feature for SharePoint pages in Microsoft Edge |
| [CopilotAddressBarSuggestionsEnabled](microsoft-edge-policies/copilotaddressbarsuggestionsenabled) | Enable Copilot address bar suggestions |
| [CopilotNewTabPageEnabled](microsoft-edge-policies/copilotnewtabpageenabled) | Enable the Copilot new tab page |
| [CpuPerformanceTierOverride](microsoft-edge-policies/cpuperformancetieroverride) | Override for the CPU performance tier |
| [CreatePasskeysInICloudKeychain](microsoft-edge-policies/createpasskeysinicloudkeychain) | Control whether passkey creation will default to iCloud Keychain. |
| [CredentialProviderPromoEnabled](microsoft-edge-policies/credentialproviderpromoenabled) | Allows users to be shown the Credential Provider Extension promo |
| [CrossOriginWebAssemblyModuleSharingEnabled](microsoft-edge-policies/crossoriginwebassemblymodulesharingenabled) | Specifies whether WebAssembly modules can be sent cross-origin (obsolete) |
| [CryptoWalletEnabled](microsoft-edge-policies/cryptowalletenabled) | Enable CryptoWallet feature (obsolete) |
| [CustomHelpLink](microsoft-edge-policies/customhelplink) | Specify custom help link |
| [DNSInterceptionChecksEnabled](microsoft-edge-policies/dnsinterceptionchecksenabled) | DNS interception checks enabled |
| [DataUrlInWebWorkerOpaqueOriginEnabled](microsoft-edge-policies/dataurlinwebworkeropaqueoriginenabled) | Enable opaque origins for data URLs in Web Workers |
| [DefaultBrowserSettingEnabled](microsoft-edge-policies/defaultbrowsersettingenabled) | Set Microsoft Edge as default browser |
| [DefaultBrowserSettingsCampaignEnabled](microsoft-edge-policies/defaultbrowsersettingscampaignenabled) | Enables default browser settings campaigns |
| [DefaultClipboardSetting](microsoft-edge-policies/defaultclipboardsetting) | Default clipboard site permission |
| [DefaultSensorsSetting](microsoft-edge-policies/defaultsensorssetting) | Default sensors setting |
| [DefaultSerialGuardSetting](microsoft-edge-policies/defaultserialguardsetting) | Control use of the Serial API |
| [DefaultShareAdditionalOSRegionSetting](microsoft-edge-policies/defaultshareadditionalosregionsetting) | Set the default "share additional operating system region" setting |
| [DefinePreferredLanguages](microsoft-edge-policies/definepreferredlanguages) | Define an ordered list of preferred languages that websites should display in if the site supports the language |
| [DelayNavigationsForInitialSiteListDownload](microsoft-edge-policies/delaynavigationsforinitialsitelistdownload) | Require that the Enterprise Mode Site List is available before tab navigation |
| [DeleteDataOnMigration](microsoft-edge-policies/deletedataonmigration) | Delete old browser data on migration |
| [DeveloperToolsAvailability](microsoft-edge-policies/developertoolsavailability) | Control where developer tools can be used |
| [DeveloperToolsAvailabilityAllowlist](microsoft-edge-policies/developertoolsavailabilityallowlist) | List of URL patterns for which developer tools are allowed to be opened |
| [DeveloperToolsAvailabilityBlocklist](microsoft-edge-policies/developertoolsavailabilityblocklist) | List of URL patterns for which developer tools are blocked |
| [DirectInvokeEnabled](microsoft-edge-policies/directinvokeenabled) | Allow users to open files using the DirectInvoke protocol |
| [Disable3DAPIs](microsoft-edge-policies/disable3dapis) | Disable support for 3D graphics APIs |
| [DisabledMiniApps](microsoft-edge-policies/disabledminiapps) | List of disabled Mini Apps (obsolete) |
| [DiscoverPageContextEnabled](microsoft-edge-policies/discoverpagecontextenabled) | Enable Discover access to page contents for AAD profiles (obsolete) |
| [DiskCacheDir](microsoft-edge-policies/diskcachedir) | Set disk cache directory |
| [DiskCacheSize](microsoft-edge-policies/diskcachesize) | Set disk cache size, in bytes |
| [DisplayCapturePermissionsPolicyEnabled](microsoft-edge-policies/displaycapturepermissionspolicyenabled) | Specifies whether the display-capture permissions-policy is checked or skipped (obsolete) |
| [DoNotSilentlyBlockProtocolsFromOrigins](microsoft-edge-policies/donotsilentlyblockprotocolsfromorigins) | Define a list of protocols that can not be silently blocked by anti-flood protection |
| [DoubleClickCloseTabEnabled](microsoft-edge-policies/doubleclickclosetabenabled) | Double Click feature in Microsoft Edge enabled (only available in China) |
| [DynamicCodeSettings](microsoft-edge-policies/dynamiccodesettings) | Dynamic Code Settings |
| [Edge3PSerpTelemetryEnabled](microsoft-edge-policies/edge3pserptelemetryenabled) | Edge 3P SERP Telemetry Enabled |
| [EdgeAssetDeliveryServiceEnabled](microsoft-edge-policies/edgeassetdeliveryserviceenabled) | Allow features to download assets from the Asset Delivery Service |
| [EdgeAutofillMlEnabled](microsoft-edge-policies/edgeautofillmlenabled) | Machine learning powered autofill suggestions |
| [EdgeBrandColor](microsoft-edge-policies/edgebrandcolor) | Configure the organization color shown on the New Tab Page for iOS and Android |
| [EdgeBrandLogo](microsoft-edge-policies/edgebrandlogo) | Configure the organization logo shown on the New Tab Page for iOS and Android |
| [EdgeCollectionsEnabled](microsoft-edge-policies/edgecollectionsenabled) | Enable the Collections feature |
| [EdgeDisableShareUsageData](microsoft-edge-policies/edgedisableshareusagedata) | Disable data sharing usage data for personalization for iOS and Android |
| [EdgeDiscoverEnabled](microsoft-edge-policies/edgediscoverenabled) | Discover feature In Microsoft Edge (obsolete) |
| [EdgeEDropEnabled](microsoft-edge-policies/edgeedropenabled) | Enable Drop feature in Microsoft Edge |
| [EdgeEnhanceImagesEnabled](microsoft-edge-policies/edgeenhanceimagesenabled) | Enhance images enabled (obsolete) |
| [EdgeFollowEnabled](microsoft-edge-policies/edgefollowenabled) | Enable Follow service in Microsoft Edge (obsolete) |
| [EdgeHistoryAISearchEnabled](microsoft-edge-policies/edgehistoryaisearchenabled) | Control access to AI-enhanced search in History |
| [EdgeLockedViewModeAllowedActions](microsoft-edge-policies/edgelockedviewmodeallowedactions) | Configure allowed actions in locked view mode |
| [EdgeLockedViewModeEnabled](microsoft-edge-policies/edgelockedviewmodeenabled) | Configure locked view mode on iOS and Android |
| [EdgeMyApps](microsoft-edge-policies/edgemyapps) | Display My Apps bookmark |
| [EdgeOneAuthProxy](microsoft-edge-policies/edgeoneauthproxy) | OneAuth Proxy Server For Microsoft Edge Android |
| [EdgeOpenInSidebarEnabled](microsoft-edge-policies/edgeopeninsidebarenabled) | Enable open in sidebar |
| [EdgeProxyPacFailOpenEnabled](microsoft-edge-policies/edgeproxypacfailopenenabled) | Enable fail-open behavior for Proxy PAC on iOS |
| [EdgeProxyPacUrl](microsoft-edge-policies/edgeproxypacurl) | Configure Proxy Auto-Config (PAC) URL on iOS |
| [EdgeSharedDeviceSupportEnabled](microsoft-edge-policies/edgeshareddevicesupportenabled) | Enable Shared Device Support |
| [EdgeShoppingAssistantEnabled](microsoft-edge-policies/edgeshoppingassistantenabled) | Shopping in Microsoft Edge Enabled |
| [EdgeSidebarAppUrlHostAllowList](microsoft-edge-policies/edgesidebarappurlhostallowlist) | Allow specific apps to be opened in Microsoft Edge sidebar |
| [EdgeSidebarAppUrlHostBlockList](microsoft-edge-policies/edgesidebarappurlhostblocklist) | Control which apps cannot be opened in Microsoft Edge sidebar |
| [EdgeSidebarAppUrlHostForceList](microsoft-edge-policies/edgesidebarappurlhostforcelist) | Control which apps are forced to be shown in Microsoft Edge sidebar |
| [EdgeSidebarCustomizeEnabled](microsoft-edge-policies/edgesidebarcustomizeenabled) | Enable sidebar customize |
| [EdgeWalletCheckoutEnabled](microsoft-edge-policies/edgewalletcheckoutenabled) | Enable Wallet Checkout feature |
| [EdgeWalletEtreeEnabled](microsoft-edge-policies/edgewalletetreeenabled) | Edge Wallet E-Tree Enabled (deprecated) |
| [EditFavoritesEnabled](microsoft-edge-policies/editfavoritesenabled) | Allows users to edit favorites |
| [EnableDeprecatedWebPlatformFeatures](microsoft-edge-policies/enabledeprecatedwebplatformfeatures) | Re-enable deprecated web platform features for a limited time (obsolete) |
| [EnableDomainActionsDownload](microsoft-edge-policies/enabledomainactionsdownload) | Enable Domain Actions Download from Microsoft (obsolete) |
| [EnableOnlineRevocationChecks](microsoft-edge-policies/enableonlinerevocationchecks) | Enable online OCSP/CRL checks |
| [EnableSha1ForLocalAnchors](microsoft-edge-policies/enablesha1forlocalanchors) | Allow certificates signed using SHA-1 when issued by local trust anchors (obsolete) |
| [EnableUnsafeSwiftShader](microsoft-edge-policies/enableunsafeswiftshader) | Allow software WebGL fallback using SwiftShader |
| [EncryptedClientHelloEnabled](microsoft-edge-policies/encryptedclienthelloenabled) | TLS Encrypted ClientHello Enabled |
| [EnforceLocalAnchorConstraintsEnabled](microsoft-edge-policies/enforcelocalanchorconstraintsenabled) | Determines whether the built-in certificate verifier will enforce constraints encoded into trust anchors loaded from the platform trust store (obsolete) |
| [EnterpriseHardwarePlatformAPIEnabled](microsoft-edge-policies/enterprisehardwareplatformapienabled) | Allow managed extensions to use the Enterprise Hardware Platform API |
| [EnterpriseModeSiteListManagerAllowed](microsoft-edge-policies/enterprisemodesitelistmanagerallowed) | Allow access to the Enterprise Mode Site List Manager tool |
| [EventPathEnabled](microsoft-edge-policies/eventpathenabled) | Re-enable the Event.path API until Microsoft Edge version 115 (obsolete) |
| [ExemptDomainFileTypePairsFromFileTypeDownloadWarnings](microsoft-edge-policies/exemptdomainfiletypepairsfromfiletypedownloadwarnings) | Disable download file type extension-based warnings for specified file types on domains (obsolete) |
| [ExperimentationAndConfigurationServiceControl](microsoft-edge-policies/experimentationandconfigurationservicecontrol) | Control communication with the Experimentation and Configuration Service |
| [ExternalProtocolDialogShowAlwaysOpenCheckbox](microsoft-edge-policies/externalprotocoldialogshowalwaysopencheckbox) | Show an "Always open" checkbox in external protocol dialog |
| [FamilySafetySettingsEnabled](microsoft-edge-policies/familysafetysettingsenabled) | Allow users to configure Family safety and Kids Mode |
| [FavoritesBarEnabled](microsoft-edge-policies/favoritesbarenabled) | Enable favorites bar |
| [FileOrDirectoryPickerWithoutGestureAllowedForOrigins](microsoft-edge-policies/fileordirectorypickerwithoutgestureallowedfororigins) | Allow file or directory picker APIs to be called without prior user gesture |
| [ForceBingSafeSearch](microsoft-edge-policies/forcebingsafesearch) | Enforce Bing SafeSearch |
| [ForceBuiltInPushMessagingClient](microsoft-edge-policies/forcebuiltinpushmessagingclient) | Forces Microsoft Edge to use its built-in WNS push client to connect to the Windows Push Notification Service. |
| [ForceEphemeralProfiles](microsoft-edge-policies/forceephemeralprofiles) | Enable use of ephemeral profiles |
| [ForceForegroundPriorityForAllTabs](microsoft-edge-policies/forceforegroundpriorityforalltabs) | Force foreground priority for all tabs |
| [ForceForegroundPriorityForUrls](microsoft-edge-policies/forceforegroundpriorityforurls) | Force foreground priority for specific URLs |
| [ForceGoogleSafeSearch](microsoft-edge-policies/forcegooglesafesearch) | Enforce Google SafeSearch |
| [ForceLegacyDefaultReferrerPolicy](microsoft-edge-policies/forcelegacydefaultreferrerpolicy) | Use a default referrer policy of no-referrer-when-downgrade (obsolete) |
| [ForceMajorVersionToMinorPositionInUserAgent](microsoft-edge-policies/forcemajorversiontominorpositioninuseragent) | Enable or disable freezing the User-Agent string at major version 99 (obsolete) |
| [ForceNetworkInProcess](microsoft-edge-policies/forcenetworkinprocess) | Force networking code to run in the browser process (obsolete) |
| [ForcePermissionPolicyUnloadDefaultEnabled](microsoft-edge-policies/forcepermissionpolicyunloaddefaultenabled) | Controls whether unload event handlers can be disabled. |
| [ForceSync](microsoft-edge-policies/forcesync) | Force synchronization of browser data and do not show the sync consent prompt |
| [ForceSyncTypes](microsoft-edge-policies/forcesynctypes) | Configure the list of types that are included for synchronization |
| [ForceYouTubeRestrict](microsoft-edge-policies/forceyoutuberestrict) | Force minimum YouTube Restricted Mode |
| [FullscreenAllowed](microsoft-edge-policies/fullscreenallowed) | Allow full screen mode |
| [GoToIntranetSiteForSingleWordEntryInAddressBar](microsoft-edge-policies/gotointranetsiteforsinglewordentryinaddressbar) | Force direct intranet site navigation instead of searching on single word entries in the Address Bar |
| [HSTSPolicyBypassList](microsoft-edge-policies/hstspolicybypasslist) | Configure the list of names that will bypass the HSTS policy check |
| [HardwareAccelerationModeEnabled](microsoft-edge-policies/hardwareaccelerationmodeenabled) | Use graphics acceleration when available |
| [HeadlessModeEnabled](microsoft-edge-policies/headlessmodeenabled) | Control use of the Headless Mode |
| [HideFirstRunExperience](microsoft-edge-policies/hidefirstrunexperience) | Hide the First-run experience and splash screen |
| [HideInternetExplorerRedirectUXForIncompatibleSitesEnabled](microsoft-edge-policies/hideinternetexplorerredirectuxforincompatiblesitesenabled) | Hide the one-time redirection dialog and the banner on Microsoft Edge |
| [HideRestoreDialogEnabled](microsoft-edge-policies/hiderestoredialogenabled) | Hide restore pages dialog after browser crash |
| [HttpAllowlist](microsoft-edge-policies/httpallowlist) | HTTP Allowlist |
| [HttpsOnlyMode](microsoft-edge-policies/httpsonlymode) | Allow HTTPS-Only Mode to be enabled |
| [HttpsUpgradesEnabled](microsoft-edge-policies/httpsupgradesenabled) | Enable automatic HTTPS upgrades |
| [HubsSidebarEnabled](microsoft-edge-policies/hubssidebarenabled) | Show Hubs Sidebar |
| [InAppSupportEnabled](microsoft-edge-policies/inappsupportenabled) | In-app support Enabled |
| [InPrivateModeAvailability](microsoft-edge-policies/inprivatemodeavailability) | Configure InPrivate mode availability |
| [InPrivateModeUrlAllowlist](microsoft-edge-policies/inprivatemodeurlallowlist) | Allow access to a list of URLs in InPrivate mode. |
| [InPrivateModeUrlBlocklist](microsoft-edge-policies/inprivatemodeurlblocklist) | Block access to a list of URLs in InPrivate mode. |
| [InsecureFormsWarningsEnabled](microsoft-edge-policies/insecureformswarningsenabled) | Enable warnings for insecure forms (deprecated) |
| [IntranetRedirectBehavior](microsoft-edge-policies/intranetredirectbehavior) | Intranet Redirection Behavior |
| [IsolateOrigins](microsoft-edge-policies/isolateorigins) | Enable site isolation for specific origins |
| [KeyboardFocusableScrollersEnabled](microsoft-edge-policies/keyboardfocusablescrollersenabled) | Enable keyboard focusable scrollers (obsolete) |
| [LaunchEdgeOnWindowsStartupEnabled](microsoft-edge-policies/launchedgeonwindowsstartupenabled) | Launch Microsoft Edge on Windows startup |
| [LiveVideoTranslationEnabled](microsoft-edge-policies/livevideotranslationenabled) | Allows users to translate videos to different languages. |
| [LocalBrowserDataShareEnabled](microsoft-edge-policies/localbrowserdatashareenabled) | Enable Windows to search local Microsoft Edge browsing data |
| [LocalProvidersEnabled](microsoft-edge-policies/localprovidersenabled) | Allow suggestions from local providers |
| [M365LinksAutoOpenCopilotEnabled](microsoft-edge-policies/m365linksautoopencopilotenabled) | Automatically open Copilot side pane with contextual insights for links opened from Outlook |
| [MAUEnabled](microsoft-edge-policies/mauenabled) | Always use Microsoft AutoUpdate as the updater for Microsoft Edge (obsolete) |
| [MSAWebSiteSSOUsingThisProfileAllowed](microsoft-edge-policies/msawebsitessousingthisprofileallowed) | Allow single sign-on for Microsoft personal sites using this profile |
| [ManagedConfigurationPerOrigin](microsoft-edge-policies/managedconfigurationperorigin) | Sets managed configuration values for websites to specific origins |
| [ManagedFavorites](microsoft-edge-policies/managedfavorites) | Configure favorites |
| [ManagedNtpShortcuts](microsoft-edge-policies/managedntpshortcuts) | Configure managed shortcuts on the New Tab Page |
| [ManagedSearchEngines](microsoft-edge-policies/managedsearchengines) | Manage Search Engines |
| [MathSolverEnabled](microsoft-edge-policies/mathsolverenabled) | Let users snip a Math problem and get the solution with a step-by-step explanation in Microsoft Edge (obsolete) |
| [MaxConnectionsPerProxy](microsoft-edge-policies/maxconnectionsperproxy) | Maximum number of concurrent connections to the proxy server for non-WebSocket requests |
| [MaxConnectionsPerProxyForWebSocket](microsoft-edge-policies/maxconnectionsperproxyforwebsocket) | Maximum number of concurrent connections to the proxy server for WebSocket requests |
| [MediaRouterCastAllowAllIPs](microsoft-edge-policies/mediaroutercastallowallips) | Allow Google Cast to connect to Cast devices on all IP addresses |
| [MetricsReportingEnabled](microsoft-edge-policies/metricsreportingenabled) | Enable usage and crash-related data reporting (obsolete) |
| [MicrosoftEdgeInsiderPromotionEnabled](microsoft-edge-policies/microsoftedgeinsiderpromotionenabled) | Microsoft Edge Insider Promotion Enabled |
| [MicrosoftEditorProofingEnabled](microsoft-edge-policies/microsofteditorproofingenabled) | Spell checking provided by Microsoft Editor |
| [MicrosoftEditorSynonymsEnabled](microsoft-edge-policies/microsofteditorsynonymsenabled) | Synonyms are provided when using Microsoft Editor spell checker |
| [MicrosoftRootStoreEnabled](microsoft-edge-policies/microsoftrootstoreenabled) | Determines whether the Microsoft Root Store and built-in certificate verifier will be used to verify server certificates (obsolete) |
| [MouseGestureEnabled](microsoft-edge-policies/mousegestureenabled) | Mouse Gesture Enabled |
| [MutationEventsEnabled](microsoft-edge-policies/mutationeventsenabled) | Enable deprecated/removed Mutation Events (obsolete) |
| [NTPContentSuggestionsEnabled](microsoft-edge-policies/ntpcontentsuggestionsenabled) | Show content suggestions on the New Tab page |
| [NativeHostsExecutablesLaunchDirectly](microsoft-edge-policies/nativehostsexecutableslaunchdirectly) | Force Windows executable Native Messaging hosts to launch directly |
| [NativeWindowOcclusionEnabled](microsoft-edge-policies/nativewindowocclusionenabled) | Enable Native Window Occlusion (deprecated) |
| [NavigationDelayForInitialSiteListDownloadTimeout](microsoft-edge-policies/navigationdelayforinitialsitelistdownloadtimeout) | Set a timeout for delay of tab navigation for the Enterprise Mode Site List |
| [NetworkServiceSandboxEnabled](microsoft-edge-policies/networkservicesandboxenabled) | Enable the network service sandbox |
| [NewBaseUrlInheritanceBehaviorAllowed](microsoft-edge-policies/newbaseurlinheritancebehaviorallowed) | Allows enabling the feature NewBaseUrlInheritanceBehavior (obsolete) |
| [NonRemovableProfileEnabled](microsoft-edge-policies/nonremovableprofileenabled) | Configure whether a user always has a default profile automatically signed in with their work or school account |
| [OrganizationLogoOverlayOnAppIconEnabled](microsoft-edge-policies/organizationlogooverlayonappiconenabled) | Allow your organization's logo from Microsoft Entra to be overlaid on the Microsoft Edge app icon of a work or school profile |
| [OrganizationalBrandingOnWorkProfileUIEnabled](microsoft-edge-policies/organizationalbrandingonworkprofileuienabled) | Allow the use of your organization's branding assets from Microsoft Entra on the profile-related UI of a work or school profile |
| [OriginAgentClusterDefaultEnabled](microsoft-edge-policies/originagentclusterdefaultenabled) | Origin-keyed agent clustering enabled by default |
| [OriginKeyedProcessesEnabled](microsoft-edge-policies/originkeyedprocessesenabled) | Enable origin-keyed process isolation for improved security |
| [OverlayPermissionDetectionEnabled](microsoft-edge-policies/overlaypermissiondetectionenabled) | Enable Overlay Permission Detection |
| [OverrideSecurityRestrictionsOnInsecureOrigin](microsoft-edge-policies/overridesecurityrestrictionsoninsecureorigin) | Control where security restrictions on insecure origins apply |
| [PaymentMethodQueryEnabled](microsoft-edge-policies/paymentmethodqueryenabled) | Allow websites to query for available payment methods |
| [PictureInPictureOverlayEnabled](microsoft-edge-policies/pictureinpictureoverlayenabled) | Enable Picture in Picture overlay feature on supported webpages in Microsoft Edge |
| [PinningWizardAllowed](microsoft-edge-policies/pinningwizardallowed) | Allow Pin to taskbar wizard |
| [PolicyRefreshRate](microsoft-edge-policies/policyrefreshrate) | Refresh rate for user policy |
| [PostQuantumKeyAgreementEnabled](microsoft-edge-policies/postquantumkeyagreementenabled) | Enable post-quantum key agreement for TLS (obsolete) |
| [PrefetchWithServiceWorkerEnabled](microsoft-edge-policies/prefetchwithserviceworkerenabled) | Allow SpeculationRules prefetch for ServiceWorker-controlled URLs |
| [ProactiveAuthEnabled](microsoft-edge-policies/proactiveauthenabled) | Enable Proactive Authentication (obsolete) |
| [PromotionalTabsEnabled](microsoft-edge-policies/promotionaltabsenabled) | Enable full-tab promotional content (deprecated) |
| [ProvisionalNotificationsAllowed](microsoft-edge-policies/provisionalnotificationsallowed) | Allows the app to use provisional notification authorization on iOS |
| [QRCodeGeneratorEnabled](microsoft-edge-policies/qrcodegeneratorenabled) | Enable QR Code Generator |
| [QuickSearchShowMiniMenu](microsoft-edge-policies/quicksearchshowminimenu) | Enables Microsoft Edge mini menu |
| [RSAKeyUsageForLocalAnchorsEnabled](microsoft-edge-policies/rsakeyusageforlocalanchorsenabled) | Check RSA key usage for server certificates issued by local trust anchors (obsolete) |
| [ReadAloudEnabled](microsoft-edge-policies/readaloudenabled) | Enable Read Aloud feature in Microsoft Edge |
| [ReadExtendedCertificateLocationsEnabled](microsoft-edge-policies/readextendedcertificatelocationsenabled) | Enable Extended Keychain Certificate Authentication |
| [RedirectSitesFromInternetExplorerPreventBHOInstall](microsoft-edge-policies/redirectsitesfrominternetexplorerpreventbhoinstall) | Prevent install of the BHO to redirect incompatible sites from Internet Explorer to Microsoft Edge |
| [RedirectSitesFromInternetExplorerRedirectMode](microsoft-edge-policies/redirectsitesfrominternetexplorerredirectmode) | Redirect incompatible sites from Internet Explorer to Microsoft Edge |
| [ReduceIPAddressChangeNotificationEnabled](microsoft-edge-policies/reduceipaddresschangenotificationenabled) | Enable Reduce IP Address Change Notification |
| [RelatedMatchesCloudServiceEnabled](microsoft-edge-policies/relatedmatchescloudserviceenabled) | Configure Related Matches in Find on Page (obsolete) |
| [RelaunchFastIfOutdated](microsoft-edge-policies/relaunchfastifoutdated) | Relaunch browser quickly when the current version is outdated |
| [RelaunchNotification](microsoft-edge-policies/relaunchnotification) | Notify a user that a browser restart is recommended or required for pending updates |
| [RelaunchNotificationPeriod](microsoft-edge-policies/relaunchnotificationperiod) | Set the time period for update notifications |
| [RelaunchWindow](microsoft-edge-policies/relaunchwindow) | Set the time interval for relaunch |
| [RemoteDebuggingAllowed](microsoft-edge-policies/remotedebuggingallowed) | Allow remote debugging |
| [RendererAppContainerEnabled](microsoft-edge-policies/rendererappcontainerenabled) | Enable renderer in app container |
| [RendererCodeIntegrityEnabled](microsoft-edge-policies/renderercodeintegrityenabled) | Enable renderer code integrity (obsolete) |
| [RequireOnlineRevocationChecksForLocalAnchors](microsoft-edge-policies/requireonlinerevocationchecksforlocalanchors) | Specify if online OCSP/CRL checks are required for local trust anchors |
| [ResolveNavigationErrorsUseWebService](microsoft-edge-policies/resolvenavigationerrorsusewebservice) | Enable resolution of navigation errors using a web service |
| [RestrictCoreSharingOnRenderer](microsoft-edge-policies/restrictcoresharingonrenderer) | Restrict CPU core sharing for renderer process |
| [RestrictSigninToPattern](microsoft-edge-policies/restrictsignintopattern) | Restrict which accounts can be used to sign in to Microsoft Edge |
| [RoamingProfileLocation](microsoft-edge-policies/roamingprofilelocation) | Set the roaming profile directory |
| [RoamingProfileSupportEnabled](microsoft-edge-policies/roamingprofilesupportenabled) | Enable using roaming copies for Microsoft Edge profile data |
| [RunAllFlashInAllowMode](microsoft-edge-policies/runallflashinallowmode) | Extend Adobe Flash content setting to all content (obsolete) |
| [SSLErrorOverrideAllowed](microsoft-edge-policies/sslerroroverrideallowed) | Allow users to proceed from the HTTPS warning page |
| [SSLErrorOverrideAllowedForOrigins](microsoft-edge-policies/sslerroroverrideallowedfororigins) | Allow users to proceed from the HTTPS warning page for specific origins |
| [SSLVersionMin](microsoft-edge-policies/sslversionmin) | Minimum TLS version enabled (obsolete) |
| [SandboxExternalProtocolBlocked](microsoft-edge-policies/sandboxexternalprotocolblocked) | Allow Microsoft Edge to block navigations to external protocols in a sandboxed iframe |
| [SaveCookiesOnExit](microsoft-edge-policies/savecookiesonexit) | Save cookies when Microsoft Edge closes |
| [SavingBrowserHistoryDisabled](microsoft-edge-policies/savingbrowserhistorydisabled) | Disable saving browser history |
| [ScrollToTextFragmentEnabled](microsoft-edge-policies/scrolltotextfragmentenabled) | Enable scrolling to text specified in URL fragments |
| [SearchFiltersEnabled](microsoft-edge-policies/searchfiltersenabled) | Search Filters Enabled |
| [SearchForImageEnabled](microsoft-edge-policies/searchforimageenabled) | Search for image enabled |
| [SearchInSidebarEnabled](microsoft-edge-policies/searchinsidebarenabled) | Search in Sidebar enabled |
| [SearchSuggestEnabled](microsoft-edge-policies/searchsuggestenabled) | Enable search suggestions |
| [SearchbarAllowed](microsoft-edge-policies/searchbarallowed) | Enable the Search bar |
| [SearchbarIsEnabledOnStartup](microsoft-edge-policies/searchbarisenabledonstartup) | Allow the Search bar at Windows startup |
| [SecurityKeyPermitAttestation](microsoft-edge-policies/securitykeypermitattestation) | Websites or domains that don't need permission to use direct Security Key attestation |
| [SelectParserRelaxationEnabled](microsoft-edge-policies/selectparserrelaxationenabled) | Controls whether the new HTML parser behavior for the &lt;select&gt; element is enabled (obsolete) |
| [SendIntranetToInternetExplorer](microsoft-edge-policies/sendintranettointernetexplorer) | Send all intranet sites to Internet Explorer |
| [SendMouseEventsDisabledFormControlsEnabled](microsoft-edge-policies/sendmouseeventsdisabledformcontrolsenabled) | Control the new behavior for event dispatching on disabled form controls (obsolete) |
| [SendSiteInfoToImproveServices](microsoft-edge-policies/sendsiteinfotoimproveservices) | Send site information to improve Microsoft services (obsolete) |
| [SensorsAllowedForUrls](microsoft-edge-policies/sensorsallowedforurls) | Allow access to sensors on specific sites |
| [SensorsBlockedForUrls](microsoft-edge-policies/sensorsblockedforurls) | Block access to sensors on specific sites |
| [SerialAskForUrls](microsoft-edge-policies/serialaskforurls) | Allow the Serial API on specific sites |
| [SerialBlockedForUrls](microsoft-edge-policies/serialblockedforurls) | Block the Serial API on specific sites |
| [ServiceWorkerAutoPreloadEnabled](microsoft-edge-policies/serviceworkerautopreloadenabled) | Allow ServiceWorker to dispatch navigation requests without waiting for its startup |
| [ServiceWorkerToControlSrcdocIframeEnabled](microsoft-edge-policies/serviceworkertocontrolsrcdociframeenabled) | Allow ServiceWorker to control srcdoc iframes |
| [SetTimeoutWithout1MsClampEnabled](microsoft-edge-policies/settimeoutwithout1msclampenabled) | Control Javascript setTimeout() function minimum timeout (obsolete) |
| [ShadowStackCrashRollbackBehavior](microsoft-edge-policies/shadowstackcrashrollbackbehavior) | Configure ShadowStack crash rollback behavior (obsolete) |
| [ShareBrowsingHistoryWithCopilotSearchAllowed](microsoft-edge-policies/sharebrowsinghistorywithcopilotsearchallowed) | Allow sharing tenant-approved browsing history with Microsoft 365 Copilot Search |
| [SharedArrayBufferUnrestrictedAccessAllowed](microsoft-edge-policies/sharedarraybufferunrestrictedaccessallowed) | Specifies whether SharedArrayBuffers can be used in a non cross-origin-isolated context |
| [SharedLinksEnabled](microsoft-edge-policies/sharedlinksenabled) | Show links shared from Microsoft 365 apps in History |
| [SharedWorkerBlobURLFixEnabled](microsoft-edge-policies/sharedworkerbloburlfixenabled) | Make SharedWorker blob URL behavior aligned with the specification |
| [SharedWorkerExtendedLifetimeEnabled](microsoft-edge-policies/sharedworkerextendedlifetimeenabled) | Enable the extended lifetime option for SharedWorkers |
| [ShowDownloadsToolbarButton](microsoft-edge-policies/showdownloadstoolbarbutton) | Show Downloads button on the toolbar |
| [ShowHistoryThumbnails](microsoft-edge-policies/showhistorythumbnails) | Show thumbnail images for browsing history |
| [ShowMicrosoftRewards](microsoft-edge-policies/showmicrosoftrewards) | Show Microsoft Rewards experiences |
| [ShowRecommendationsEnabled](microsoft-edge-policies/showrecommendationsenabled) | Allow feature recommendations and browser assistance notifications from Microsoft Edge |
| [ShowTabPreviewEnabled](microsoft-edge-policies/showtabpreviewenabled) | Enable tab preview on hover |
| [SignedHTTPExchangeEnabled](microsoft-edge-policies/signedhttpexchangeenabled) | Enable Signed HTTP Exchange (SXG) support |
| [SilentPrintingEnabled](microsoft-edge-policies/silentprintingenabled) | Enable Silent Printing |
| [SitePerProcess](microsoft-edge-policies/siteperprocess) | Enable site isolation for every site |
| [SiteSafetyServicesEnabled](microsoft-edge-policies/sitesafetyservicesenabled) | Allow users to configure Site safety services (obsolete) |
| [SmartActionsBlockList](microsoft-edge-policies/smartactionsblocklist) | Block smart actions for a list of services |
| [SpeechRecognitionEnabled](microsoft-edge-policies/speechrecognitionenabled) | Configure Speech Recognition |
| [SpellcheckEnabled](microsoft-edge-policies/spellcheckenabled) | Enable spellcheck |
| [SpellcheckLanguage](microsoft-edge-policies/spellchecklanguage) | Enable specific spellcheck languages |
| [SpellcheckLanguageBlocklist](microsoft-edge-policies/spellchecklanguageblocklist) | Force disable spellcheck languages |
| [SplitScreenEnabled](microsoft-edge-policies/splitscreenenabled) | Enable split screen feature in Microsoft Edge |
| [StandaloneHubsSidebarEnabled](microsoft-edge-policies/standalonehubssidebarenabled) | Standalone Sidebar Enabled |
| [StandardizedBrowserZoomEnabled](microsoft-edge-policies/standardizedbrowserzoomenabled) | Enable Standardized Browser Zoom Behavior |
| [StaticStorageQuotaEnabled](microsoft-edge-policies/staticstoragequotaenabled) | Control whether storage quota APIs will return static values |
| [StricterMixedContentTreatmentEnabled](microsoft-edge-policies/strictermixedcontenttreatmentenabled) | Enable stricter treatment for mixed content (obsolete) |
| [SuperDragDropEnabled](microsoft-edge-policies/superdragdropenabled) | Super Drag Drop Enabled |
| [SuppressUnsupportedOSWarning](microsoft-edge-policies/suppressunsupportedoswarning) | Suppress the unsupported OS warning |
| [SyncDisabled](microsoft-edge-policies/syncdisabled) | Disable synchronization of data using Microsoft sync services |
| [SyncTypesListDisabled](microsoft-edge-policies/synctypeslistdisabled) | Configure the list of types that are excluded from synchronization |
| [TLS13EarlyDataEnabled](microsoft-edge-policies/tls13earlydataenabled) | Control whether TLS 1.3 Early Data is enabled in Microsoft Edge |
| [TLS13HardeningForLocalAnchorsEnabled](microsoft-edge-policies/tls13hardeningforlocalanchorsenabled) | Enable a TLS 1.3 security feature for local trust anchors (obsolete) |
| [TLSCipherSuiteDenyList](microsoft-edge-policies/tlsciphersuitedenylist) | Specify the TLS cipher suites to disable |
| [TabFreezingEnabled](microsoft-edge-policies/tabfreezingenabled) | Allow freezing of background tabs (obsolete) |
| [TabServicesEnabled](microsoft-edge-policies/tabservicesenabled) | Enable tab organization suggestions |
| [TargetBlankImpliesNoOpener](microsoft-edge-policies/targetblankimpliesnoopener) | Do not set window.opener for links targeting \_blank (obsolete) |
| [TaskManagerEndProcessEnabled](microsoft-edge-policies/taskmanagerendprocessenabled) | Enable ending processes in the Browser task manager |
| [TextPredictionEnabled](microsoft-edge-policies/textpredictionenabled) | Text prediction enabled by default |
| [ThrottleNonVisibleCrossOriginIframesAllowed](microsoft-edge-policies/throttlenonvisiblecrossoriginiframesallowed) | Allows enabling throttling of non-visible, cross-origin iframes (obsolete) |
| [TrackingPrevention](microsoft-edge-policies/trackingprevention) | Block tracking of users' web-browsing activity |
| [TranslateEnabled](microsoft-edge-policies/translateenabled) | Enable Translate |
| [TravelAssistanceEnabled](microsoft-edge-policies/travelassistanceenabled) | Enable travel assistance (obsolete) |
| [TripleDESEnabled](microsoft-edge-policies/tripledesenabled) | Enable 3DES cipher suites in TLS (obsolete) |
| [TwaDisclosureUiMode](microsoft-edge-policies/twadisclosureuimode) | Configure Trusted Web Activity disclosure UI mode |
| [U2fSecurityKeyApiEnabled](microsoft-edge-policies/u2fsecuritykeyapienabled) | Allow using the deprecated U2F Security Key API (obsolete) |
| [URLAllowlist](microsoft-edge-policies/urlallowlist) | Define a list of allowed URLs |
| [URLBlocklist](microsoft-edge-policies/urlblocklist) | Block access to a list of URLs |
| [UnthrottledNestedTimeoutEnabled](microsoft-edge-policies/unthrottlednestedtimeoutenabled) | JavaScript setTimeout will not be clamped until a higher nesting threshold is set (deprecated) |
| [UpdatePolicyOverride](microsoft-edge-policies/updatepolicyoverride) | Specifies how Microsoft Edge Update handles available updates from Microsoft Edge |
| [UploadFromPhoneEnabled](microsoft-edge-policies/uploadfromphoneenabled) | Enable upload files from mobile in Microsoft Edge desktop |
| [UserAgentClientHintsEnabled](microsoft-edge-policies/useragentclienthintsenabled) | Enable the User-Agent Client Hints feature (obsolete) |
| [UserAgentClientHintsGREASEUpdateEnabled](microsoft-edge-policies/useragentclienthintsgreaseupdateenabled) | Control the User-Agent Client Hints GREASE Update feature (obsolete) |
| [UserAgentReduction](microsoft-edge-policies/useragentreduction) | Enable or disable the User-Agent Reduction (obsolete) |
| [UserDataDir](microsoft-edge-policies/userdatadir) | Set the user data directory |
| [UserDataSnapshotRetentionLimit](microsoft-edge-policies/userdatasnapshotretentionlimit) | Limits the number of user data snapshots retained for use in case of emergency rollback |
| [UserFeedbackAllowed](microsoft-edge-policies/userfeedbackallowed) | Allow user feedback |
| [VerticalTabsAllowed](microsoft-edge-policies/verticaltabsallowed) | Configures availability of a vertical layout for tabs on the side of the browser |
| [VisualSearchEnabled](microsoft-edge-policies/visualsearchenabled) | Visual search enabled |
| [WPADQuickCheckEnabled](microsoft-edge-policies/wpadquickcheckenabled) | Set WPAD optimization |
| [WalletDonationEnabled](microsoft-edge-policies/walletdonationenabled) | Wallet Donation Enabled (deprecated) |
| [WarnBeforeQuittingEnabled](microsoft-edge-policies/warnbeforequittingenabled) | Show a warning dialog when the user is attempting to quit |
| [WebAnnotations](microsoft-edge-policies/webannotations) | Allow detecting plain text entities in web pages. |
| [WebAppInstallByUserEnabled](microsoft-edge-policies/webappinstallbyuserenabled) | Enable User Web App Install From Browser |
| [WebAppInstallForceList](microsoft-edge-policies/webappinstallforcelist) | Configure list of force-installed Web Apps |
| [WebAppSettings](microsoft-edge-policies/webappsettings) | Web App management settings |
| [WebAudioOutputBufferingEnabled](microsoft-edge-policies/webaudiooutputbufferingenabled) | Enable adaptive buffering for Web Audio |
| [WebAuthenticationRemoteDesktopAllowedOrigins](microsoft-edge-policies/webauthenticationremotedesktopallowedorigins) | Allowed Origins for Proxied WebAuthn Requests from Remote Desktop Applications. |
| [WebComponentsV0Enabled](microsoft-edge-policies/webcomponentsv0enabled) | Re-enable Web Components v0 API until M84 (obsolete) |
| [WebContentFilteringBlockedCategories](microsoft-edge-policies/webcontentfilteringblockedcategories) | Configure Web Content Filtering |
| [WebDriverOverridesIncompatiblePolicies](microsoft-edge-policies/webdriveroverridesincompatiblepolicies) | Allow WebDriver to Override Incompatible Policies (obsolete) |
| [WebSQLAccess](microsoft-edge-policies/websqlaccess) | Force WebSQL to be enabled (obsolete) |
| [WebSQLInThirdPartyContextEnabled](microsoft-edge-policies/websqlinthirdpartycontextenabled) | Force WebSQL in third-party contexts to be re-enabled (obsolete) |
| [WebSQLNonSecureContextEnabled](microsoft-edge-policies/websqlnonsecurecontextenabled) | Force WebSQL in non-secure contexts to be enabled (obsolete) |
| [WebSelectEnabled](microsoft-edge-policies/webselectenabled) | Web Select Enabled (obsolete) |
| [WebWidgetAllowed](microsoft-edge-policies/webwidgetallowed) | Enable the Search bar (deprecated) |
| [WebWidgetIsEnabledOnStartup](microsoft-edge-policies/webwidgetisenabledonstartup) | Allow the Search bar at Windows startup (obsolete) |
| [WebXRImmersiveArEnabled](microsoft-edge-policies/webxrimmersivearenabled) | Allow creating WebXR's "immersive-ar" sessions |
| [WhatsNewPageForEntraProfilesEnabled](microsoft-edge-policies/whatsnewpageforentraprofilesenabled) | Control whether an informational webpage for Edge for Business is shown in the new tab after major browser updates |
| [WinHttpProxyResolverEnabled](microsoft-edge-policies/winhttpproxyresolverenabled) | Use Windows proxy resolver |
| [WindowOcclusionEnabled](microsoft-edge-policies/windowocclusionenabled) | Enable Window Occlusion |
| [XSLTEnabled](microsoft-edge-policies/xsltenabled) | Control the availability of the XSLT feature |