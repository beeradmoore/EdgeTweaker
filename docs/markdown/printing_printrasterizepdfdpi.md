---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintRasterizePdfDpi | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printrasterizepdfdpi
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Print Rasterize PDF DPI'
locale: en-us
document_id: 83525fda-3569-d4cd-5eb3-35864a8c45a4
document_version_independent_id: 83525fda-3569-d4cd-5eb3-35864a8c45a4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintRasterizePdfDpi.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PrintRasterizePdfDpi.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 225
asset_id: microsoft-edge-policies/printrasterizepdfdpi
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintRasterizePdfDpi.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0fdbe786-323b-9472-28ea-b05aea2f43a3
---

# Microsoft Edge Browser Policy Documentation PrintRasterizePdfDpi | Microsoft Learn

## Print Rasterize PDF DPI

## Supported versions

- Windows: ≥ 96
- macOS: ≥ 96
- Android: Not supported
- iOS: Not supported

## Description

Controls print image resolution when Microsoft Edge prints PDFs with rasterization.

When printing a PDF using the Print to image option, it can be beneficial to specify a print resolution other than a device's printer setting or the PDF default. A high resolution significantly increases the processing and printing time while a low resolution can lead to poor imaging quality.

If you set this policy, it allows a particular resolution to be specified for use when rasterizing PDFs for printing.

If you set this policy to zero or don't configure it, the system default resolution is used during rasterization of page images.

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

- GP unique name: PrintRasterizePdfDpi
- GP name: Print Rasterize PDF DPI
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
300
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrintRasterizePdfDpi
- Value type: REG\_DWORD

#### Example registry value

```
0x0000012c
```

## Mac information and settings

- Preference Key name: PrintRasterizePdfDpi
- Example value:

```xml
<integer>300</integer>
```