---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalMhtFileAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationlocalmhtfileallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow local MHTML files to open automatically in Internet Explorer mode'
locale: en-us
document_id: 8a914bc1-e274-5b52-4157-864e7ba38e36
document_version_independent_id: 8a914bc1-e274-5b52-4157-864e7ba38e36
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalMhtFileAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalMhtFileAllowed.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 251
asset_id: microsoft-edge-policies/internetexplorerintegrationlocalmhtfileallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalMhtFileAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7ab08e06-41d8-e245-89eb-eba5659ba868
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalMhtFileAllowed | Microsoft Learn

## Allow local MHTML files to open automatically in Internet Explorer mode

## Supported versions

- Windows: ≥ 107
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether local mht or mhtml files launched from the command line open automatically in Internet Explorer mode based on the file content without specifying the --ie-mode-file-url command line.

This setting works when [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) is set to 'IEMode' and [InternetExplorerIntegrationLocalFileAllowed](internetexplorerintegrationlocalfileallowed) is enabled or not configured.

If you enable or don't configure this policy, local mht or mhtml files launch in Microsoft Edge or Internet Explorer mode. Then, you can view these files in the best way.

If you disable this policy, local mht or mhtml files launch in Microsoft Edge.

If you use the --ie-mode-file-url command line argument for launching local mht or mhtml files, it takes precedence over how you configured this policy.

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

- GP unique name: InternetExplorerIntegrationLocalMhtFileAllowed
- GP name: Allow local MHTML files to open automatically in Internet Explorer mode
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
- Value name: InternetExplorerIntegrationLocalMhtFileAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```