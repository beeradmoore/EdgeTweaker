---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShowDownloadsInsecureWarningsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/showdownloadsinsecurewarningsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable insecure download warnings'
locale: en-us
document_id: 08d9eb68-97e0-fb47-9261-0a87b47dc14d
document_version_independent_id: 08d9eb68-97e0-fb47-9261-0a87b47dc14d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShowDownloadsInsecureWarningsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/ShowDownloadsInsecureWarningsEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 192
asset_id: microsoft-edge-policies/showdownloadsinsecurewarningsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShowDownloadsInsecureWarningsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: fd2b3efd-e529-2ad7-06aa-de9b9d78394d
---

# Microsoft Edge Browser Policy Documentation ShowDownloadsInsecureWarningsEnabled | Microsoft Learn

## Enable insecure download warnings

## Supported versions

- Windows: ≥ 128
- macOS: ≥ 128
- Android: Not supported
- iOS: Not supported

## Description

Enables warnings when potentially dangerous content is downloaded over HTTP.

If you enable or don't configure this policy, when a user tries to download potentially dangerous content from an HTTP site, the user receives a UI warning, such as "Insecure download blocked". The user can still download the item.

If you disable this policy, the warnings for insecure downloads are suppressed.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ShowDownloadsInsecureWarningsEnabled
- GP name: Enable insecure download warnings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Downloads
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Downloads
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ShowDownloadsInsecureWarningsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ShowDownloadsInsecureWarningsEnabled
- Example value:

```xml
<true/>
```