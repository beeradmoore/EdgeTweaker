---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShowPDFDefaultRecommendationsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/showpdfdefaultrecommendationsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow notifications to set Microsoft Edge as default PDF reader'
locale: en-us
document_id: dc685dc4-c103-a52e-8d89-dc6cfbc91c6d
document_version_independent_id: dc685dc4-c103-a52e-8d89-dc6cfbc91c6d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShowPDFDefaultRecommendationsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ShowPDFDefaultRecommendationsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 201
asset_id: microsoft-edge-policies/showpdfdefaultrecommendationsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShowPDFDefaultRecommendationsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e00ec133-dced-1c21-fdff-b18178f5368f
---

# Microsoft Edge Browser Policy Documentation ShowPDFDefaultRecommendationsEnabled | Microsoft Learn

## Allow notifications to set Microsoft Edge as default PDF reader

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

This policy setting lets you decide whether employees should receive recommendations to set Microsoft Edge as PDF handler.

If you enable or don't configure this setting, employees receive recommendations from Microsoft Edge to set itself as the default PDF handler.

If you disable this setting, employees can't receive any notifications from Microsoft Edge to set itself as the default PDF handler.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ShowPDFDefaultRecommendationsEnabled
- GP name: Allow notifications to set Microsoft Edge as default PDF reader
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ShowPDFDefaultRecommendationsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ShowPDFDefaultRecommendationsEnabled
- Example value:

```xml
<true/>
```