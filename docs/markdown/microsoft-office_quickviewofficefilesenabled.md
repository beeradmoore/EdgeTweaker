---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation QuickViewOfficeFilesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/quickviewofficefilesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Manage QuickView Office files capability in Microsoft Edge'
locale: en-us
document_id: 7bc2834a-6852-85ad-b5e7-cc9da9e16abe
document_version_independent_id: 7bc2834a-6852-85ad-b5e7-cc9da9e16abe
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/QuickViewOfficeFilesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/QuickViewOfficeFilesEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 197
asset_id: microsoft-edge-policies/quickviewofficefilesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/QuickViewOfficeFilesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e1f3e4db-b360-4304-e428-9ea681af09c9
---

# Microsoft Edge Browser Policy Documentation QuickViewOfficeFilesEnabled | Microsoft Learn

## Manage QuickView Office files capability in Microsoft Edge

## Supported versions

- Windows: ≥ 90
- macOS: ≥ 90
- Android: Not supported
- iOS: Not supported

## Description

Allows you to set whether users can view publicly accessible Office files on the web that aren't on OneDrive or SharePoint. (For example: Word documents, PowerPoint presentations, and Excel spreadsheets)

If you enable or don't configure this policy, these files can be viewed in Microsoft Edge using Office Viewer instead of downloading the files.

If you disable this policy, these files are downloaded to be viewed.

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

- GP unique name: QuickViewOfficeFilesEnabled
- GP name: Manage QuickView Office files capability in Microsoft Edge
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
- Value name: QuickViewOfficeFilesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: QuickViewOfficeFilesEnabled
- Example value:

```xml
<true/>
```