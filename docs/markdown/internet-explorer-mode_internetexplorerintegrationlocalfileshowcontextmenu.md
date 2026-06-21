---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalFileShowContextMenu | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationlocalfileshowcontextmenu
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show context menu to open a file:// link in Internet Explorer mode'
locale: en-us
document_id: 04e7a4d8-c770-f52f-9df7-b0b841428b0f
document_version_independent_id: 04e7a4d8-c770-f52f-9df7-b0b841428b0f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalFileShowContextMenu.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalFileShowContextMenu.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 294
asset_id: microsoft-edge-policies/internetexplorerintegrationlocalfileshowcontextmenu
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalFileShowContextMenu.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ee5e87e9-3260-58e7-839e-a1cdce54d845
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalFileShowContextMenu | Microsoft Learn

## Show context menu to open a file:// link in Internet Explorer mode

## Supported versions

- Windows: ≥ 88
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls the visibility of the 'Open link in new Internet Explorer mode tab' option on the context menu for file:// links.

This setting works in conjunction with: [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel), which is set to 'IEMode'.

If you enable this policy, the 'Open link in new Internet Explorer mode tab' context menu item is available for file:// links.

If you disable or don't configure this policy, the context menu item won't be added.

If the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy allows users to reload sites in Internet Explorer mode, then the 'Open link in new Internet Explorer mode tab' context menu item is available for all links, except links to sites explicitly configured by the site list to use Microsoft Edge mode. In this case, if you enable this policy, the context menu item is available for file:// links even for sites configured to use Microsoft Edge mode. If you disable or don't configure this policy, the policy has no effect.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2094210

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationLocalFileShowContextMenu
- GP name: Show context menu to open a file:// link in Internet Explorer mode
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
- Value name: InternetExplorerIntegrationLocalFileShowContextMenu
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```