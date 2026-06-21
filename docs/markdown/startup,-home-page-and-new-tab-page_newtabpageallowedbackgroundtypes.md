---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageAllowedBackgroundTypes | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpageallowedbackgroundtypes
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the background types allowed for the new tab page layout'
locale: en-us
document_id: b9e02e5b-83c0-9f08-d2aa-a611b409eb68
document_version_independent_id: b9e02e5b-83c0-9f08-d2aa-a611b409eb68
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageAllowedBackgroundTypes.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NewTabPageAllowedBackgroundTypes.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 253
asset_id: microsoft-edge-policies/newtabpageallowedbackgroundtypes
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageAllowedBackgroundTypes.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0c1bdda0-92b9-caa2-ee02-16f0c92d7cb0
---

# Microsoft Edge Browser Policy Documentation NewTabPageAllowedBackgroundTypes | Microsoft Learn

## Configure the background types allowed for the new tab page layout

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

You can configure which types of background image that are allowed on the new tab page layout in Microsoft Edge.

If you don't configure this policy, all background image types on the new tab page are enabled.

Policy options mapping:

- DisableImageOfTheDay (1) = Disable daily background image type
- DisableCustomImage (2) = Disable custom background image type
- DisableAll (3) = Disable all background image types

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- DisableImageOfTheDay (1) = Disable daily background image type
- DisableCustomImage (2) = Disable custom background image type
- DisableAll (3) = Disable all background image types

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NewTabPageAllowedBackgroundTypes
- GP name: Configure the background types allowed for the new tab page layout
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disable custom background image type
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NewTabPageAllowedBackgroundTypes
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: NewTabPageAllowedBackgroundTypes
- Example value:

```xml
<integer>2</integer>
```