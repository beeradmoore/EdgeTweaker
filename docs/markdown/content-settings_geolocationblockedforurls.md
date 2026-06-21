---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation GeolocationBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/geolocationblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block geolocation on these sites'
locale: en-us
document_id: c4278a52-1c71-2956-67c0-f69f6115a006
document_version_independent_id: c4278a52-1c71-2956-67c0-f69f6115a006
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/GeolocationBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/GeolocationBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 247
asset_id: microsoft-edge-policies/geolocationblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/GeolocationBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: cd0fc7fd-71dc-c376-289a-8cf36c942ea5
---

# Microsoft Edge Browser Policy Documentation GeolocationBlockedForUrls | Microsoft Learn

## Block geolocation on these sites

## Supported versions

- Windows: ≥ 144
- macOS: ≥ 144
- Android: ≥ 144
- iOS: Not supported

## Description

Use this policy to define a list of URL patterns for sites that are blocked from accessing the user's geolocation. These sites also can't prompt the user for location permissions.

If you enable this policy, the list you provide determines which sites are blocked from requesting or accessing geolocation.

If you disable or don't configure this policy, DefaultGeolocationSetting applies to all sites, if configured. If it's not configured, the user’s personal browser setting is used.

For detailed information on valid url patterns, see the documentation on pattern formats: [Filter formats for URL list-based policies](/en-us/deployedge/edge-learnmmore-url-list-filter%20format).

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

- GP unique name: GeolocationBlockedForUrls
- GP name: Block geolocation on these sites
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\GeolocationBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\GeolocationBlockedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\GeolocationBlockedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: GeolocationBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: GeolocationBlockedForUrls
- Example value:

```
["https://www.example.com", "[*.]example.edu"]
```