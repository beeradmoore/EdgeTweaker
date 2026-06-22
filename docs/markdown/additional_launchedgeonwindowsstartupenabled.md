---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LaunchEdgeOnWindowsStartupEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/launchedgeonwindowsstartupenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Launch Microsoft Edge on Windows startup'
locale: en-us
document_id: 96493969-c21e-29c6-6824-455f196eea67
document_version_independent_id: 96493969-c21e-29c6-6824-455f196eea67
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LaunchEdgeOnWindowsStartupEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/LaunchEdgeOnWindowsStartupEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 190
asset_id: microsoft-edge-policies/launchedgeonwindowsstartupenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LaunchEdgeOnWindowsStartupEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8020c74f-5672-db04-e14b-44d633656345
---

# Microsoft Edge Browser Policy Documentation LaunchEdgeOnWindowsStartupEnabled | Microsoft Learn

## Launch Microsoft Edge on Windows startup

## Supported versions

- Windows: ≥ 152
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy lets you control whether Microsoft Edge automatically launches visibly when Windows starts.

If you enable this policy, Microsoft Edge will launch visibly automatically when Windows starts.

If you disable this policy, Microsoft Edge will never launch visibly automatically when Windows starts.

If you don't configure this policy, users will have an option to select whether or not they want Microsoft Edge to launch automatically when Windows starts.

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

- GP unique name: LaunchEdgeOnWindowsStartupEnabled
- GP name: Launch Microsoft Edge on Windows startup
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: LaunchEdgeOnWindowsStartupEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```