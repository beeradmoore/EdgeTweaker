---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RelatedWebsiteSetsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/relatedwebsitesetsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Related Website Sets (deprecated)'
locale: en-us
document_id: 9a342e0a-3847-15f6-4082-c0ece2d492fa
document_version_independent_id: 9a342e0a-3847-15f6-4082-c0ece2d492fa
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RelatedWebsiteSetsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/RelatedWebsiteSetsEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 245
asset_id: microsoft-edge-policies/relatedwebsitesetsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RelatedWebsiteSetsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b6e621e7-7e8b-9bfb-e3de-9f88511b7dca
---

# Microsoft Edge Browser Policy Documentation RelatedWebsiteSetsEnabled | Microsoft Learn

## Enable Related Website Sets (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 121
- macOS: ≥ 121
- Android: ≥ 121
- iOS: Not supported

## Description

This policy lets you control the enablement of the Related Website Sets feature. Related Website Sets (RWS) is a way for an organisation to declare relationships among sites, so that Microsoft Edge allows limited third-party cookie access for specific purposes across those sites.

If this policy set to True or unset, the Related Website Sets feature is enabled.

If this policy is set to False, the Related Website Sets feature is disabled.

This policy is deprecated as of Microsoft Edge version 144 with the deprecation of Related Website Sets.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RelatedWebsiteSetsEnabled
- GP name: Enable Related Website Sets (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Related Website Sets Settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RelatedWebsiteSetsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: RelatedWebsiteSetsEnabled
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: RelatedWebsiteSetsEnabled
- Example value:

```
false
```