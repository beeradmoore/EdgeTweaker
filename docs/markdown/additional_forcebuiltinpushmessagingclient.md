---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceBuiltInPushMessagingClient | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcebuiltinpushmessagingclient
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Forces Microsoft Edge to use its built-in WNS push client to connect to the Windows Push Notification Service.'
locale: en-us
document_id: 396611bd-61b2-3ca7-4083-5e71175693fa
document_version_independent_id: 396611bd-61b2-3ca7-4083-5e71175693fa
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceBuiltInPushMessagingClient.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/ForceBuiltInPushMessagingClient.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 216
asset_id: microsoft-edge-policies/forcebuiltinpushmessagingclient
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceBuiltInPushMessagingClient.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 805efcb4-4481-6d46-67ef-689f2dedcdec
---

# Microsoft Edge Browser Policy Documentation ForceBuiltInPushMessagingClient | Microsoft Learn

## Forces Microsoft Edge to use its built-in WNS push client to connect to the Windows Push Notification Service.

## Supported versions

- Windows: ≥ 118
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

In some environments, the Windows OS client can't connect to the Windows Push Notification Service (WNS). For these environments, you can use the Microsoft Edge built-in WNS push client, which can connect successfully.

If enabled, Microsoft Edge uses its built-in WNS push client to connect to WNS.

If disabled or not configured, Microsoft Edge uses the Windows OS client to connect to the Windows Push Notification Service. This is the default setting.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceBuiltInPushMessagingClient
- GP name: Forces Microsoft Edge to use its built-in WNS push client to connect to the Windows Push Notification Service.
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ForceBuiltInPushMessagingClient
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```