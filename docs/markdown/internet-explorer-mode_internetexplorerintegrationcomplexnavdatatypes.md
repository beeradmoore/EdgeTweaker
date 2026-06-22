---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationComplexNavDataTypes | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationcomplexnavdatatypes
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure whether form data and HTTP headers will be sent when entering or exiting Internet Explorer mode'
locale: en-us
document_id: b97386ee-000e-7bf8-94b1-761a2d8d7a27
document_version_independent_id: b97386ee-000e-7bf8-94b1-761a2d8d7a27
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationComplexNavDataTypes.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationComplexNavDataTypes.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 301
asset_id: microsoft-edge-policies/internetexplorerintegrationcomplexnavdatatypes
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationComplexNavDataTypes.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/97159432-14a9-4307-a469-d2f2c75f0e33
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/50565c62-5f6b-4687-be38-323113c72c2e
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e3622bae-7ead-1b8f-7568-bf5b76176a1d
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationComplexNavDataTypes | Microsoft Learn

## Configure whether form data and HTTP headers will be sent when entering or exiting Internet Explorer mode

## Supported versions

- Windows: ≥ 96
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

From Microsoft Edge version 96, navigations that switch between Internet Explorer mode and Microsoft Edge include form data.

If you enable this policy, you specify which data types are included in navigations between Microsoft Edge and Internet Explorer mode.

If you disable or don't configure this policy, Microsoft Edge uses the new behavior of including form data in navigations that change modes.

To learn more, see https://go.microsoft.com/fwlink/?linkid=2174004.

Policy options mapping:

- IncludeNone (0) = Do not send form data or headers
- IncludeFormDataOnly (1) = Send form data only
- IncludeHeadersOnly (2) = Send additional headers only
- IncludeFormDataAndHeaders (3) = Send form data and additional headers

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- IncludeNone (0) = Do not send form data or headers
- IncludeFormDataOnly (1) = Send form data only
- IncludeHeadersOnly (2) = Send additional headers only
- IncludeFormDataAndHeaders (3) = Send form data and additional headers

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationComplexNavDataTypes
- GP name: Configure whether form data and HTTP headers will be sent when entering or exiting Internet Explorer mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Send form data and additional headers
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationComplexNavDataTypes
- Value type: REG\_DWORD

#### Example registry value

```
0x00000003
```