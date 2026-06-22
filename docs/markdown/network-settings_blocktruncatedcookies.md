---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BlockTruncatedCookies | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/blocktruncatedcookies
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block truncated cookies (obsolete)'
locale: en-us
document_id: e83a959d-2041-2f12-4f94-ccca2fe8d1c5
document_version_independent_id: e83a959d-2041-2f12-4f94-ccca2fe8d1c5
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BlockTruncatedCookies.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/BlockTruncatedCookies.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 256
asset_id: microsoft-edge-policies/blocktruncatedcookies
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BlockTruncatedCookies.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9ce50afa-d9b4-add8-9121-ae8e45d8e4be
---

# Microsoft Edge Browser Policy Documentation BlockTruncatedCookies | Microsoft Learn

## Block truncated cookies (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 131.

## Supported versions

- Windows: 123-131
- macOS: 123-131
- Android: 123-131
- iOS: Not supported

## Description

This policy provides a temporary opt-out for changes to how Microsoft Edge handles cookies set via JavaScript that contain certain control characters (NULL, carriage return, and line feed). Previously, the presence of any of these characters in a cookie string would cause it to be truncated but still set. Now, the presence of these characters will cause the whole cookie string to be ignored.

If you enable or don't configure this policy, the new behavior is enabled.

If you disable this policy, the old behavior is enabled.

This policy is obsolete because this policy was originally implemented as a safety measure if there was a breakage, but none have been reported.

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

- GP unique name: BlockTruncatedCookies
- GP name: Block truncated cookies (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BlockTruncatedCookies
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: BlockTruncatedCookies
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: BlockTruncatedCookies
- Example value:

```
false
```