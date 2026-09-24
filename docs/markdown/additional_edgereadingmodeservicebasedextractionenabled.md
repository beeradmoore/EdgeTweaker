---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeReadingModeServiceBasedExtractionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgereadingmodeservicebasedextractionenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable service-based extraction for Reading Mode in Microsoft Edge'
locale: en-us
document_id: 56d0c428-2443-3e96-3155-4760ba4c80cb
document_version_independent_id: 56d0c428-2443-3e96-3155-4760ba4c80cb
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeReadingModeServiceBasedExtractionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/EdgeReadingModeServiceBasedExtractionEnabled.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 204
asset_id: microsoft-edge-policies/edgereadingmodeservicebasedextractionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeReadingModeServiceBasedExtractionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 36f18c50-6a8c-4eca-7e84-e55bf63e7e23
---

# Microsoft Edge Browser Policy Documentation EdgeReadingModeServiceBasedExtractionEnabled | Microsoft Learn

## Enable service-based extraction for Reading Mode in Microsoft Edge

## Supported versions

- Windows: ≥ 151
- macOS: ≥ 151
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge can use the Microsoft online extraction service to improve Reading Mode rendering.

If you enable or don't configure this policy, Microsoft Edge can send the text of the page being read to the service for processing.

If you disable this policy, Microsoft Edge doesn't send the text of the page being read to the service. Reading Mode remains available, but extraction quality may be limited.

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

- GP unique name: EdgeReadingModeServiceBasedExtractionEnabled
- GP name: Enable service-based extraction for Reading Mode in Microsoft Edge
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
- Value name: EdgeReadingModeServiceBasedExtractionEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EdgeReadingModeServiceBasedExtractionEnabled
- Example value:

```xml
<true/>
```