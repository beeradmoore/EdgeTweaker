---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoImportAtFirstRun | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autoimportatfirstrun
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Automatically import another browser&#x27;s data and settings at first run'
locale: en-us
document_id: d503e096-7abd-c5a5-d187-91d36ac1b9fd
document_version_independent_id: d503e096-7abd-c5a5-d187-91d36ac1b9fd
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoImportAtFirstRun.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AutoImportAtFirstRun.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 645
asset_id: microsoft-edge-policies/autoimportatfirstrun
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoImportAtFirstRun.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e80f5389-026e-fb0d-6533-9267207dda44
---

# Microsoft Edge Browser Policy Documentation AutoImportAtFirstRun | Microsoft Learn

## Automatically import another browser's data and settings at first run

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, all supported datatypes and settings from the specified browser are silently and automatically imported at first run. During the First Run Experience, the import section is also skipped.

The browser data from Microsoft Edge Legacy is always silently migrated at the first run, irrespective of the value of this policy.

If you set this policy to 'FromDefaultBrowser' to FromDefaultBrowser, then the datatypes corresponding to the default browser on the managed device are imported.

If the browser specified as the value of this policy isn't present in the managed device, Microsoft Edge simply skips the import without any notification to the user.

If you set this policy to DisabledAutoImport, the import section of the first-run experience is skipped entirely, and Microsoft Edge doesn't import browser data and settings automatically.

If you set this policy to FromInternetExplorer, the following datatypes are imported from Internet Explorer:

1. Favorites or bookmarks
2. Saved passwords
3. Search engines
4. Browsing history
5. Home page

If you set this policy to FromGoogleChrome, the following datatypes are imported from Google Chrome:

1. Favorites
2. Saved passwords
3. Addresses and more
4. Payment info
5. Browsing history
6. Settings
7. Pinned and Open tabs
8. Extensions
9. Cookies

Note: For more details on what is imported from Google Chrome, see https://go.microsoft.com/fwlink/?linkid=2120835

If you set this policy to FromSafari, user data is no longer imported into Microsoft Edge. This is because of the way in which Full Disk Access works on Mac. On macOS Mojave and above, it's no longer possible to have automated and unattended import of Safari data into Microsoft Edge.

Starting with Microsoft Edge version 83, if you set this policy to 'FromMozillaFirefox', the following datatypes are imported from Mozilla Firefox:

1. Favorites or bookmarks
2. Saved passwords
3. Addresses and more
4. Browsing History

If you want to restrict specific datatypes from getting imported onto the managed devices, use this policy with other policies such as [ImportAutofillFormData](importautofillformdata), [ImportBrowserSettings](importbrowsersettings), [ImportFavorites](importfavorites), and so on.

Policy options mapping:

- FromDefaultBrowser (0) = Automatically imports all supported datatypes and settings from the default browser
- FromInternetExplorer (1) = Automatically imports all supported datatypes and settings from Internet Explorer
- FromGoogleChrome (2) = Automatically imports all supported datatypes and settings from Google Chrome
- FromSafari (3) = Automatically imports all supported datatypes and settings from Safari
- DisabledAutoImport (4) = Disables automatic import, and the import section of the first-run experience is skipped
- FromMozillaFirefox (5) = Automatically imports all supported datatypes and settings from Mozilla Firefox

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- FromDefaultBrowser (0) = Automatically imports all supported datatypes and settings from the default browser
- FromInternetExplorer (1) = Automatically imports all supported datatypes and settings from Internet Explorer
- FromGoogleChrome (2) = Automatically imports all supported datatypes and settings from Google Chrome
- FromSafari (3) = Automatically imports all supported datatypes and settings from Safari
- DisabledAutoImport (4) = Disables automatic import, and the import section of the first-run experience is skipped
- FromMozillaFirefox (5) = Automatically imports all supported datatypes and settings from Mozilla Firefox

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AutoImportAtFirstRun
- GP name: Automatically import another browser's data and settings at first run
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Automatically imports all supported datatypes and settings from Google Chrome
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AutoImportAtFirstRun
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: AutoImportAtFirstRun
- Example value:

```xml
<integer>2</integer>
```