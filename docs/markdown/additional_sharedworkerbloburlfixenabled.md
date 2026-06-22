---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SharedWorkerBlobURLFixEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sharedworkerbloburlfixenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Make SharedWorker blob URL behavior aligned with the specification'
locale: en-us
document_id: c51a5b6d-2ff7-1641-b623-20f6b37b526c
document_version_independent_id: c51a5b6d-2ff7-1641-b623-20f6b37b526c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SharedWorkerBlobURLFixEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/SharedWorkerBlobURLFixEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 206
asset_id: microsoft-edge-policies/sharedworkerbloburlfixenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SharedWorkerBlobURLFixEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 47063aeb-77b3-64e3-e123-648a3233f4c2
---

# Microsoft Edge Browser Policy Documentation SharedWorkerBlobURLFixEnabled | Microsoft Learn

## Make SharedWorker blob URL behavior aligned with the specification

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: ≥ 134
- iOS: Not supported

## Description

According to Service Worker specification https://w3c.github.io/ServiceWorker/#control-and-use-worker-client, workers should inherit controllers for blob URLs. Currently, only DedicatedWorkers inherit the controller, while SharedWorkers do not.

Enabled/Unset: Microsoft Edge inherits the controller for SharedWorker blob URLs, aligning with the specification.

Disabled: Behavior remains unchanged, not aligning with the specification.

This policy is temporary and will be removed in a future update.

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

- GP unique name: SharedWorkerBlobURLFixEnabled
- GP name: Make SharedWorker blob URL behavior aligned with the specification
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
- Value name: SharedWorkerBlobURLFixEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SharedWorkerBlobURLFixEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: SharedWorkerBlobURLFixEnabled
- Example value:

```
true
```