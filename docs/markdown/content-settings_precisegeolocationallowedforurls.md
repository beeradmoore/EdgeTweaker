---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PreciseGeolocationAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/precisegeolocationallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow precise geolocation on these sites'
locale: en-us
document_id: cdd9d506-e0a3-be68-f368-1b5220454f52
document_version_independent_id: cdd9d506-e0a3-be68-f368-1b5220454f52
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PreciseGeolocationAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/PreciseGeolocationAllowedForUrls.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 217
asset_id: microsoft-edge-policies/precisegeolocationallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PreciseGeolocationAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 8078f6bf-ef44-1da3-8cb5-723356c85117
---

# Microsoft Edge Browser Policy Documentation PreciseGeolocationAllowedForUrls | Microsoft Learn

## Allow precise geolocation on these sites

## Supported versions

- Windows: ≥ 144
- macOS: ≥ 144
- Android: ≥ 144
- iOS: Not supported

## Description

This policy lets you specify a list of URL patterns for sites that are allowed to access the user's high-accuracy geolocation without prompting for permission.

If you leave this policy unset, DefaultGeolocationSetting applies to all sites (if configured). Otherwise, the user's personal setting is used.

For information about valid url patterns, see [Filter formats for URL list-based policies](/en-us/deployedge/edge-learnmmore-url-list-filter%20format). Wildcards (\*) are supported.

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

- GP unique name: PreciseGeolocationAllowedForUrls
- GP name: Allow precise geolocation on these sites
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\PreciseGeolocationAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\PreciseGeolocationAllowedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\PreciseGeolocationAllowedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: PreciseGeolocationAllowedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: PreciseGeolocationAllowedForUrls
- Example value:

```
["https://www.example.com", "[*.]example.edu"]
```