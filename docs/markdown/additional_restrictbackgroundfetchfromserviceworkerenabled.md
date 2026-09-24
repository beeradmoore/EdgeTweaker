---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RestrictBackgroundFetchFromServiceWorkerEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/restrictbackgroundfetchfromserviceworkerenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-21T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict Background Fetch API when called from a Service Worker'
locale: en-us
document_id: 2513eb02-7e8b-42fb-81f5-55c4a3fb81cf
document_version_independent_id: 2513eb02-7e8b-42fb-81f5-55c4a3fb81cf
updated_at: 2026-07-23T17:24:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RestrictBackgroundFetchFromServiceWorkerEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/68812a75863f3e9c8e7f9a3c986f810f4a267a84/edgeenterprise/microsoft-edge-policies/RestrictBackgroundFetchFromServiceWorkerEnabled.md
git_commit_id: 68812a75863f3e9c8e7f9a3c986f810f4a267a84
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 228
asset_id: microsoft-edge-policies/restrictbackgroundfetchfromserviceworkerenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RestrictBackgroundFetchFromServiceWorkerEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e5fbdfa6-eb09-2af5-7bd3-ef5dc374ba25
---

# Microsoft Edge Browser Policy Documentation RestrictBackgroundFetchFromServiceWorkerEnabled | Microsoft Learn

## Restrict Background Fetch API when called from a Service Worker

## Supported versions

- Windows: ≥ 149
- macOS: ≥ 149
- Android: ≥ 149
- iOS: Not supported

## Description

This policy controls whether background fetch requests from Service Workers are restricted. If a feature that downloads files in the background is affected, this policy may be relevant.

If you enable this policy or don't configure it, the restriction is active, and background fetch requests from Service Worker contexts may be blocked.

If you disable this policy, the restriction is bypassed, allowing Service Workers to make background fetch requests.

This policy is temporary and will be removed after Microsoft Edge version 152.

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

- GP unique name: RestrictBackgroundFetchFromServiceWorkerEnabled
- GP name: Restrict Background Fetch API when called from a Service Worker
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
- Value name: RestrictBackgroundFetchFromServiceWorkerEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: RestrictBackgroundFetchFromServiceWorkerEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: RestrictBackgroundFetchFromServiceWorkerEnabled
- Example value:

```
true
```