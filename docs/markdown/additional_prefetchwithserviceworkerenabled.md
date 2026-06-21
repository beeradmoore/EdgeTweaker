---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrefetchWithServiceWorkerEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/prefetchwithserviceworkerenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow SpeculationRules prefetch for ServiceWorker-controlled URLs'
locale: en-us
document_id: cb693562-5a95-6c79-1ce8-dd8ea25fd5d4
document_version_independent_id: cb693562-5a95-6c79-1ce8-dd8ea25fd5d4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrefetchWithServiceWorkerEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PrefetchWithServiceWorkerEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/prefetchwithserviceworkerenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrefetchWithServiceWorkerEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ba6588d3-2b49-33c1-6a6f-91cdd4933307
---

# Microsoft Edge Browser Policy Documentation PrefetchWithServiceWorkerEnabled | Microsoft Learn

## Allow SpeculationRules prefetch for ServiceWorker-controlled URLs

## Supported versions

- Windows: ≥ 138
- macOS: ≥ 138
- Android: ≥ 138
- iOS: Not supported

## Description

Controls whether SpeculationRules prefetch requests are allowed for ServiceWorker-controlled URLs.

With Microsoft Edge version 138, prefetch requests to ServiceWorker-controlled URLs are allowed by default when the PrefetchServiceWorker feature is enabled.

If this policy is enabled or not configured, that default behavior is used.

To restore the legacy behavior from versions before 138, where prefetch requests to ServiceWorker-controlled URLs were blocked, set this policy to disabled.

This policy is intended to be temporary and will be removed in the future.

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

- GP unique name: PrefetchWithServiceWorkerEnabled
- GP name: Allow SpeculationRules prefetch for ServiceWorker-controlled URLs
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
- Value name: PrefetchWithServiceWorkerEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PrefetchWithServiceWorkerEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: PrefetchWithServiceWorkerEnabled
- Example value:

```
true
```