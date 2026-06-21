---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NativeHostsExecutablesLaunchDirectly | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nativehostsexecutableslaunchdirectly
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force Windows executable Native Messaging hosts to launch directly'
locale: en-us
document_id: 9f59b7c3-151c-ce37-e0e2-da34da372fab
document_version_independent_id: 9f59b7c3-151c-ce37-e0e2-da34da372fab
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NativeHostsExecutablesLaunchDirectly.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NativeHostsExecutablesLaunchDirectly.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 201
asset_id: microsoft-edge-policies/nativehostsexecutableslaunchdirectly
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NativeHostsExecutablesLaunchDirectly.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: d632955d-caae-db8d-1db0-d50808da890c
---

# Microsoft Edge Browser Policy Documentation NativeHostsExecutablesLaunchDirectly | Microsoft Learn

## Force Windows executable Native Messaging hosts to launch directly

## Supported versions

- Windows: ≥ 121
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether native host executables launch directly on Windows.

If you enable this policy, Microsoft Edge is forced to launch native messaging hosts implemented as executables directly.

If you disable this policy, Microsoft Edge launches hosts using cmd.exe as an intermediary process.

If you don't configure this policy, Microsoft Edge decides which approach to use based on a progressive rollout from the legacy behavior to the Launch Directly behavior, guided by ecosystem compatibility.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NativeHostsExecutablesLaunchDirectly
- GP name: Force Windows executable Native Messaging hosts to launch directly
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
- Value name: NativeHostsExecutablesLaunchDirectly
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```