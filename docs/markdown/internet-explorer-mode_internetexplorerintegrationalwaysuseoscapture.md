---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationAlwaysUseOSCapture | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationalwaysuseoscapture
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Always use the OS capture engine to avoid issues with capturing Internet Explorer mode tabs'
locale: en-us
document_id: 728a87d7-33a2-d5a1-5fd9-faa6c9f7029e
document_version_independent_id: 728a87d7-33a2-d5a1-5fd9-faa6c9f7029e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationAlwaysUseOSCapture.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationAlwaysUseOSCapture.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 304
asset_id: microsoft-edge-policies/internetexplorerintegrationalwaysuseoscapture
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationAlwaysUseOSCapture.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: fdcb9046-5afa-f59b-61f6-07a7b3213dd2
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationAlwaysUseOSCapture | Microsoft Learn

## Always use the OS capture engine to avoid issues with capturing Internet Explorer mode tabs

## Supported versions

- Windows: ≥ 106
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configure this policy to control whether Microsoft Edge will use the "OS capture engine" or the "Browser capture engine" when capturing browser windows in the same process using the screen-share APIs.

You should configure this policy if you want to capture the contents of Internet Explorer mode tabs. However, enabling this policy may negatively impact performance when capturing browser windows in the same process.

This policy only affects window capture, not tab capture. The contents of Internet Explorer mode tabs won't be captured when you choose to capture only a single tab, even if you configure this policy.

If you enable this policy, Microsoft Edge always uses the OS capture engine for window capture. Internet Explorer mode tabs will have their contents captured.

If you disable or don't configure this policy, Microsoft Edge uses the Browser capture engine for browser windows in the same process. Internet Explorer mode tabs in these windows won't have their contents captured.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2174004

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

- GP unique name: InternetExplorerIntegrationAlwaysUseOSCapture
- GP name: Always use the OS capture engine to avoid issues with capturing Internet Explorer mode tabs
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
- Value name: InternetExplorerIntegrationAlwaysUseOSCapture
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```