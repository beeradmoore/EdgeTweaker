---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UploadFromPhoneEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/uploadfromphoneenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable upload files from mobile in Microsoft Edge desktop'
locale: en-us
document_id: 6d5f8133-f026-d646-a78d-20c2f5edf30c
document_version_independent_id: 6d5f8133-f026-d646-a78d-20c2f5edf30c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UploadFromPhoneEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/UploadFromPhoneEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 203
asset_id: microsoft-edge-policies/uploadfromphoneenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UploadFromPhoneEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 98a6919d-a6a9-5d89-b696-8e2a0acb08bf
---

# Microsoft Edge Browser Policy Documentation UploadFromPhoneEnabled | Microsoft Learn

## Enable upload files from mobile in Microsoft Edge desktop

## Supported versions

- Windows: ≥ 117
- macOS: ≥ 118
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you configure the "Upload from mobile" feature in Microsoft Edge.

Upload from mobile lets users select file from mobile devices to desktop when user upload file in a webpage in Microsoft Edge.

If you enable or don't configure this policy, you can use the Upload from mobile feature in Microsoft Edge.

If you disable this policy, you can't use the Upload from mobile feature in Microsoft Edge.

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

- GP unique name: UploadFromPhoneEnabled
- GP name: Enable upload files from mobile in Microsoft Edge desktop
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
- Value name: UploadFromPhoneEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: UploadFromPhoneEnabled
- Example value:

```xml
<true/>
```