---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShowOfficeShortcutInFavoritesBar | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/showofficeshortcutinfavoritesbar
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show Microsoft Office shortcut in favorites bar (deprecated)'
locale: en-us
document_id: fea1e4e8-09e6-0a40-08bf-fdd9d3700500
document_version_independent_id: fea1e4e8-09e6-0a40-08bf-fdd9d3700500
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShowOfficeShortcutInFavoritesBar.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ShowOfficeShortcutInFavoritesBar.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 233
asset_id: microsoft-edge-policies/showofficeshortcutinfavoritesbar
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShowOfficeShortcutInFavoritesBar.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/e93f3d5f-c77d-4365-a7fb-c9f2234416c7
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/62e8d07a-cc62-4934-b30b-e168a571e51d
platformId: 47c8f911-2f82-918c-c059-a4db16c60b45
---

# Microsoft Edge Browser Policy Documentation ShowOfficeShortcutInFavoritesBar | Microsoft Learn

## Show Microsoft Office shortcut in favorites bar (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

This policy didn't work as expected due to changes in operational requirements. Therefore, the policy is deprecated and shouldn't be used.

Specifies whether to include a shortcut to Office.com in the favorites bar. For users signed into Microsoft Edge, the shortcut takes users to their Microsoft Office apps and docs. If you enable or don't configure this policy, users can choose whether to see the shortcut by changing the toggle in the favorites bar context menu. If you disable this policy, the shortcut isn't shown.

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

- GP unique name: ShowOfficeShortcutInFavoritesBar
- GP name: Show Microsoft Office shortcut in favorites bar (deprecated)
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
- Value name: ShowOfficeShortcutInFavoritesBar
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ShowOfficeShortcutInFavoritesBar
- Example value:

```xml
<false/>
```