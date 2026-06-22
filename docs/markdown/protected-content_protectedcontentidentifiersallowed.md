---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProtectedContentIdentifiersAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/protectedcontentidentifiersallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allows web pages to use identifiers for the purpose of protected content playback'
locale: en-us
document_id: b9cdb3bc-7e30-d650-6b70-943897a89359
document_version_independent_id: b9cdb3bc-7e30-d650-6b70-943897a89359
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProtectedContentIdentifiersAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ProtectedContentIdentifiersAllowed.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 204
asset_id: microsoft-edge-policies/protectedcontentidentifiersallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProtectedContentIdentifiersAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 8e5ba4cc-83ce-3303-fffd-b9857cfb4e81
---

# Microsoft Edge Browser Policy Documentation ProtectedContentIdentifiersAllowed | Microsoft Learn

## Allows web pages to use identifiers for the purpose of protected content playback

## Supported versions

- Windows: ≥ 147
- macOS: Not supported
- Android: ≥ 147
- iOS: Not supported

## Description

This policy controls whether sites can use hardware-specific device identifiers to enable hardware-secure DRM (for example, Widevine L1 or PlayReady SL3000), which may be required for high-resolution protected content playback.

If you enable this policy or do not configure it, sites are allowed to use protected content identifiers.

If you disable this policy, sites are not allowed to use protected content identifiers.

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

- GP unique name: ProtectedContentIdentifiersAllowed
- GP name: Allows web pages to use identifiers for the purpose of protected content playback
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Protected Content
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProtectedContentIdentifiersAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Android information and settings

- Preference Key name: ProtectedContentIdentifiersAllowed
- Example value:

```
false
```