---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WindowManagementAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/windowmanagementallowedforurls
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
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Window Management permission on specified sites'
locale: en-us
document_id: e92ccbc9-6252-8547-4667-d7b5d56b0280
document_version_independent_id: e92ccbc9-6252-8547-4667-d7b5d56b0280
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WindowManagementAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/WindowManagementAllowedForUrls.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 258
asset_id: microsoft-edge-policies/windowmanagementallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WindowManagementAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a7f49e0c-9590-e530-1c2e-3af4aac4b358
---

# Microsoft Edge Browser Policy Documentation WindowManagementAllowedForUrls | Microsoft Learn

## Allow Window Management permission on specified sites

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: Not supported
- iOS: Not supported

## Description

Lets you configure a list of site URL patterns that specify sites, which automatically grant the window management permission. This extends the ability of sites to see information about the device's screens. This information can be used to open and place windows or request fullscreen on specific screens.

For detailed information on valid site url patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. Wildcards, \*, are allowed. This policy only matches based on site origin, so any path in the URL pattern is ignored.

If this policy isn't configured for a site, then the policy from [DefaultWindowManagementSetting](defaultwindowmanagementsetting) applies to the site, if configured. Otherwise the permission follows the browser's defaults and lets users choose this permission per site.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WindowManagementAllowedForUrls
- GP name: Allow Window Management permission on specified sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WindowManagementAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WindowManagementAllowedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\WindowManagementAllowedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: WindowManagementAllowedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```