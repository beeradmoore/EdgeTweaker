---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintingWebpageLayout | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printingwebpagelayout
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Sets layout for printing'
locale: en-us
document_id: 7d9b694a-a75a-7e77-c454-362639319805
document_version_independent_id: 7d9b694a-a75a-7e77-c454-362639319805
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintingWebpageLayout.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/PrintingWebpageLayout.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 231
asset_id: microsoft-edge-policies/printingwebpagelayout
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintingWebpageLayout.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 19a3359d-21bb-3878-93dc-adcf93f32f96
---

# Microsoft Edge Browser Policy Documentation PrintingWebpageLayout | Microsoft Learn

## Sets layout for printing

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

Configuring this policy sets the layout for printing webpages.

If you disable or don't configure this policy, users can decide whether to print webpages in Portrait or Landscape layout.

If you enable this policy, the selected option is set as the layout option.

Policy options mapping:

- portrait (0) = Sets layout option as portrait
- landscape (1) = Sets layout option as landscape

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- portrait (0) = Sets layout option as portrait
- landscape (1) = Sets layout option as landscape

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintingWebpageLayout
- GP name: Sets layout for printing
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Printing
- GP ADMX file name: MSEdge.admx

#### Example value

```
Sets layout option as portrait
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: PrintingWebpageLayout
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: PrintingWebpageLayout
- Example value:

```xml
<integer>0</integer>
```