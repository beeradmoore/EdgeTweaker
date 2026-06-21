---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WindowManagementBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/windowmanagementblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block Window Management permission on specified sites'
locale: en-us
document_id: c9fa77c5-8f3f-7bac-f20c-4e06ec32ff09
document_version_independent_id: c9fa77c5-8f3f-7bac-f20c-4e06ec32ff09
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WindowManagementBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WindowManagementBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 259
asset_id: microsoft-edge-policies/windowmanagementblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WindowManagementBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 8c96d755-44cc-eed5-4034-b59e6aabe0c6
---

# Microsoft Edge Browser Policy Documentation WindowManagementBlockedForUrls | Microsoft Learn

## Block Window Management permission on specified sites

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: Not supported
- iOS: Not supported

## Description

Lets you configure a list of site URL patterns that specify sites which can automatically deny the window management permission. This limits the ability of sites to see information about the device's screens. This information can be used to open and place windows or request fullscreen on specific screens.

For detailed information on valid site URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. Wildcards, \*, are allowed. This policy only matches based on site origin, so any path in the URL pattern is ignored.

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

- GP unique name: WindowManagementBlockedForUrls
- GP name: Block Window Management permission on specified sites
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WindowManagementBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WindowManagementBlockedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\WindowManagementBlockedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: WindowManagementBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```