---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DirectInvokeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/directinvokeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to open files using the DirectInvoke protocol'
locale: en-us
document_id: b79b8850-fd49-1102-a78b-56b4d1511661
document_version_independent_id: b79b8850-fd49-1102-a78b-56b4d1511661
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DirectInvokeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DirectInvokeEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 219
asset_id: microsoft-edge-policies/directinvokeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DirectInvokeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 13d8ef74-1c8e-f2c6-f45f-f91f8d3a481e
---

# Microsoft Edge Browser Policy Documentation DirectInvokeEnabled | Microsoft Learn

## Allow users to open files using the DirectInvoke protocol

## Supported versions

- Windows: ≥ 78
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Allow users to open files using the DirectInvoke protocol. The DirectInvoke protocol allows websites to request that the browser open files from a specific URL using a specific file handler on the user's computer or device.

If you enable or don't configure this policy, users can open files using the DirectInvoke protocol.

If you disable this policy, users can't open files using the DirectInvoke protocol. Instead, the file is saved to the file system.

Note: Disabling DirectInvoke can prevent certain Microsoft SharePoint Online features from working as expected.

For more information about DirectInvoke, see https://go.microsoft.com/fwlink/?linkid=2103872 and https://go.microsoft.com/fwlink/?linkid=2099871.

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

- GP unique name: DirectInvokeEnabled
- GP name: Allow users to open files using the DirectInvoke protocol
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
- Value name: DirectInvokeEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```