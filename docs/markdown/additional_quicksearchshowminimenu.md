---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation QuickSearchShowMiniMenu | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/quicksearchshowminimenu
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enables Microsoft Edge mini menu'
locale: en-us
document_id: 97f7c4a6-95d7-82c8-4359-f46835bfdd53
document_version_independent_id: 97f7c4a6-95d7-82c8-4359-f46835bfdd53
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/QuickSearchShowMiniMenu.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/QuickSearchShowMiniMenu.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 220
asset_id: microsoft-edge-policies/quicksearchshowminimenu
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/QuickSearchShowMiniMenu.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 81b26110-086c-2d69-a478-ece00aa46e60
---

# Microsoft Edge Browser Policy Documentation QuickSearchShowMiniMenu | Microsoft Learn

## Enables Microsoft Edge mini menu

## Supported versions

- Windows: ≥ 104
- macOS: 104-142
- Android: Not supported
- iOS: Not supported

## Description

Enables the Microsoft Edge mini menu on websites and PDFs. The mini menu appears when users select text and provides basic actions like Copy and smart actions such as Definitions.

If you enable or don't configure this policy, selecting text on websites or PDFs shows the mini menu.

If you disable this policy, the mini menu doesn't appear when users select text on websites or PDFs.

Note: Starting in Microsoft Edge for Mac version 143, this policy is obsolete because the mini menu feature is removed on Mac.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: QuickSearchShowMiniMenu
- GP name: Enables Microsoft Edge mini menu
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: QuickSearchShowMiniMenu
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: QuickSearchShowMiniMenu
- Example value:

```xml
<true/>
```