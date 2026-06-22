---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerModeToolbarButtonEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorermodetoolbarbuttonenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show the Reload in Internet Explorer mode button in the toolbar'
locale: en-us
document_id: 9c1e2203-fa7a-1651-4d03-9d7b87a271da
document_version_independent_id: 9c1e2203-fa7a-1651-4d03-9d7b87a271da
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerModeToolbarButtonEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/InternetExplorerModeToolbarButtonEnabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 238
asset_id: microsoft-edge-policies/internetexplorermodetoolbarbuttonenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerModeToolbarButtonEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ea722730-ed7e-4254-4d1f-c0a7e6e262b0
---

# Microsoft Edge Browser Policy Documentation InternetExplorerModeToolbarButtonEnabled | Microsoft Learn

## Show the Reload in Internet Explorer mode button in the toolbar

## Supported versions

- Windows: ≥ 96
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Set this policy to show the Reload in Internet Explorer mode button in the toolbar. Users can hide the button in the toolbar through edge://settings/appearance. The button is only shown on the toolbar when the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy is enabled or if the user chose to enable "Allow sites to be reloaded in Internet Explorer mode".

If you enable this policy, the Reload in Internet mode button is pinned to the toolbar.

If you disable or don't configure this policy, the Reload in Internet Explorer mode button isn't shown in the toolbar by default. Users can toggle the Show Internet Explorer mode button in edge://settings/appearance.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerModeToolbarButtonEnabled
- GP name: Show the Reload in Internet Explorer mode button in the toolbar
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
- Value name: InternetExplorerModeToolbarButtonEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```