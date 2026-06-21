---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintRasterizationMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printrasterizationmode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Print Rasterization Mode'
locale: en-us
document_id: c682e7de-2cec-76f9-351a-264b82e6fc59
document_version_independent_id: c682e7de-2cec-76f9-351a-264b82e6fc59
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintRasterizationMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PrintRasterizationMode.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 228
asset_id: microsoft-edge-policies/printrasterizationmode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintRasterizationMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f35ef258-e82a-b3f4-7de4-32e41030b0fe
---

# Microsoft Edge Browser Policy Documentation PrintRasterizationMode | Microsoft Learn

## Print Rasterization Mode

## Supported versions

- Windows: ≥ 90
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Controls how Microsoft Edge prints on Windows. When printing to a non-PostScript printer on Windows, some print jobs need to be rasterized to print correctly.

If you set this policy to 'Full' or don't configure it, Microsoft Edge performs full page rasterization if necessary.

If you set this policy to 'Fast', Microsoft Edge reduces the amount of rasterization, which can decrease print job sizes and increase printing speed.

Policy options mapping:

- Full (0) = Full page rasterization
- Fast (1) = Avoid rasterization if possible

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Full (0) = Full page rasterization
- Fast (1) = Avoid rasterization if possible

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintRasterizationMode
- GP name: Print Rasterization Mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Avoid rasterization if possible
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrintRasterizationMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```