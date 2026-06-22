---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ClickOnceEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/clickonceenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to open files using the ClickOnce protocol'
locale: en-us
document_id: bde3d50f-267f-cfcd-2f20-9bd183103d63
document_version_independent_id: bde3d50f-267f-cfcd-2f20-9bd183103d63
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ClickOnceEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/ClickOnceEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 302
asset_id: microsoft-edge-policies/clickonceenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ClickOnceEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: fb0e4f97-b836-a44c-d27b-73ae953d85e3
---

# Microsoft Edge Browser Policy Documentation ClickOnceEnabled | Microsoft Learn

## Allow users to open files using the ClickOnce protocol

## Supported versions

- Windows: ≥ 78
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Allow users to open files using the ClickOnce protocol. The ClickOnce protocol allows websites to request that the browser open files from a specific URL using the ClickOnce file handler on the user's computer or device.

If you enable this policy, users can open files using the ClickOnce protocol. This policy overrides the user's ClickOnce setting in the edge://flags/ page.

If you disable this policy, users can't open files using the ClickOnce protocol. Instead, the file is saved to the file system using the browser. This policy overrides the user's ClickOnce setting in the edge://flags/ page.

If you don't configure this policy, users with Microsoft Edge versions before Microsoft Edge 87 can't open files using the ClickOnce protocol by default. However, they can enable the use of the ClickOnce protocol with the edge://flags/ page. Users with Microsoft Edge versions 87 and later can open files using the ClickOnce protocol by default but can disable the ClickOnce protocol with edge://flags/ page.

Disabling ClickOnce can prevent ClickOnce applications (.application files) from launching properly.

For more information about ClickOnce, see https://go.microsoft.com/fwlink/?linkid=2103872 and https://go.microsoft.com/fwlink/?linkid=2099880.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ClickOnceEnabled
- GP name: Allow users to open files using the ClickOnce protocol
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
- Value name: ClickOnceEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```