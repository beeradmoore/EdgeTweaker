---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation StaticStorageQuotaEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/staticstoragequotaenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control whether storage quota APIs will return static values'
locale: en-us
document_id: 8777af31-9491-be25-7d54-830e57406b6d
document_version_independent_id: 8777af31-9491-be25-7d54-830e57406b6d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/StaticStorageQuotaEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/StaticStorageQuotaEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 235
asset_id: microsoft-edge-policies/staticstoragequotaenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/StaticStorageQuotaEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a1eb09ae-f506-a78e-3fc8-0bf4b9750c67
---

# Microsoft Edge Browser Policy Documentation StaticStorageQuotaEnabled | Microsoft Learn

## Control whether storage quota APIs will return static values

## Supported versions

- Windows: ≥ 145
- macOS: ≥ 145
- Android: ≥ 145
- iOS: Not supported

## Description

Controls how the Storage Quota APIs report the available quota to websites.

When enabled, the Storage Quota APIs return a static quota value equal to the current usage plus the smaller of 10 GiB or the device's total storage rounded up to the nearest 1 GiB.

When disabled, the Storage Quota APIs return a dynamic quota value that reflects the actual available device storage.

When unset, the browser uses the default platform behavior.

This policy does not affect sites with unlimited storage permissions or enforced quota settings.

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

- GP unique name: StaticStorageQuotaEnabled
- GP name: Control whether storage quota APIs will return static values
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
- Value name: StaticStorageQuotaEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: StaticStorageQuotaEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: StaticStorageQuotaEnabled
- Example value:

```
true
```