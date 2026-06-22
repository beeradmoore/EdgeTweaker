---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ServiceWorkerAutoPreloadEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/serviceworkerautopreloadenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow ServiceWorker to dispatch navigation requests without waiting for its startup'
locale: en-us
document_id: a7fb2ec1-c5b7-5025-1237-52ca82d25818
document_version_independent_id: a7fb2ec1-c5b7-5025-1237-52ca82d25818
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ServiceWorkerAutoPreloadEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ServiceWorkerAutoPreloadEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 237
asset_id: microsoft-edge-policies/serviceworkerautopreloadenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ServiceWorkerAutoPreloadEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 71922ca1-6b5b-4fc7-b9db-49e40f778017
---

# Microsoft Edge Browser Policy Documentation ServiceWorkerAutoPreloadEnabled | Microsoft Learn

## Allow ServiceWorker to dispatch navigation requests without waiting for its startup

## Supported versions

- Windows: ≥ 140
- macOS: ≥ 140
- Android: ≥ 140
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge enables the ServiceWorkerAutoPreload feature.

If you enable or don't configure this policy, Microsoft Edge can initiate the main resource network request concurrently with the Service Worker bootstrap process. This can improve performance in scenarios where the Service Worker isn't already running.

If you disable this policy, Microsoft Edge will wait to dispatch the navigation request until after the Service Worker starts.

This is a temporary policy and is removed in version 144 of Microsoft Edge.

For more information on the feature, see https://github.com/WICG/service-worker-auto-preload.

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

- GP unique name: ServiceWorkerAutoPreloadEnabled
- GP name: Allow ServiceWorker to dispatch navigation requests without waiting for its startup
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
- Value name: ServiceWorkerAutoPreloadEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ServiceWorkerAutoPreloadEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: ServiceWorkerAutoPreloadEnabled
- Example value:

```
true
```