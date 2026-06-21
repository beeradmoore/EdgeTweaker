---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerModeEnableSavePageAs | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorermodeenablesavepageas
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Save page as in Internet Explorer mode'
locale: en-us
document_id: dc7cee2c-f28f-a12c-7358-6e9d90611ab6
document_version_independent_id: dc7cee2c-f28f-a12c-7358-6e9d90611ab6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerModeEnableSavePageAs.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerModeEnableSavePageAs.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 227
asset_id: microsoft-edge-policies/internetexplorermodeenablesavepageas
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerModeEnableSavePageAs.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ad0746b8-c3bd-b1f0-fc13-6d7e19563e3c
---

# Microsoft Edge Browser Policy Documentation InternetExplorerModeEnableSavePageAs | Microsoft Learn

## Allow Save page as in Internet Explorer mode

## Supported versions

- Windows: ≥ 101
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy enables 'Save page as' functionality in Internet Explorer mode. Users can use this option to save the current page in the browser. When a user reopens a saved page, it's loaded in the default browser.

If you enable this policy, the "Save page as" option is clickable in "More tools".

If you disable or don't configure this policy, users can't select the "Save page as" option in "More tools".

Note: To make the "Ctrl+S" shortcut work, users must enable the Internet Explorer policy, namely 'Enable extended hot key in Internet Explorer mode'.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2094210

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerModeEnableSavePageAs
- GP name: Allow Save page as in Internet Explorer mode
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
- Value name: InternetExplorerModeEnableSavePageAs
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```