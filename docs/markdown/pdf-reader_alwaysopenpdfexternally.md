---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AlwaysOpenPdfExternally | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/alwaysopenpdfexternally
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Always open PDF files externally'
locale: en-us
document_id: f1a946f3-a5b0-07d2-ab54-fe30f0a1e108
document_version_independent_id: f1a946f3-a5b0-07d2-ab54-fe30f0a1e108
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AlwaysOpenPdfExternally.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/AlwaysOpenPdfExternally.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 192
asset_id: microsoft-edge-policies/alwaysopenpdfexternally
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AlwaysOpenPdfExternally.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6bf332a2-65f1-4925-bff8-d5130dc65ae5
---

# Microsoft Edge Browser Policy Documentation AlwaysOpenPdfExternally | Microsoft Learn

## Always open PDF files externally

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Disables the internal PDF viewer in Microsoft Edge.

If you enable this policy Microsoft Edge treats PDF files as downloads and lets users open them with the default application.

If Microsoft Edge is the default PDF reader, PDF files aren't downloaded and continue to open in Microsoft Edge.

If you don't configure this policy or disable it, Microsoft Edge opens PDF files (unless the user disables it).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AlwaysOpenPdfExternally
- GP name: Always open PDF files externally
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
- Value name: AlwaysOpenPdfExternally
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AlwaysOpenPdfExternally
- Example value:

```xml
<true/>
```