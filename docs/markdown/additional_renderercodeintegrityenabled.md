---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RendererCodeIntegrityEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/renderercodeintegrityenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable renderer code integrity (obsolete)'
locale: en-us
document_id: b5a9570f-c75d-7098-b7e2-8e19ddaa327e
document_version_independent_id: b5a9570f-c75d-7098-b7e2-8e19ddaa327e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RendererCodeIntegrityEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/RendererCodeIntegrityEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 207
asset_id: microsoft-edge-policies/renderercodeintegrityenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RendererCodeIntegrityEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1f5a3215-d4f1-d777-c676-d0e762c3368c
---

# Microsoft Edge Browser Policy Documentation RendererCodeIntegrityEnabled | Microsoft Learn

## Enable renderer code integrity (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 118.

## Supported versions

- Windows: 78-118
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy to Enabled or leaving it unset turns on Renderer Code Integrity. Setting the policy to Disabled has a detrimental effect on Microsoft Edge's security and stability as unknown and potentially hostile code can load inside Microsoft Edge's renderer processes. Only turn off the policy if there are compatibility issues with third-party software that must run inside Microsoft Edge's renderer processes.

This policy is removed in Microsoft Edge version 119 and is ignored if set.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RendererCodeIntegrityEnabled
- GP name: Enable renderer code integrity (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RendererCodeIntegrityEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```