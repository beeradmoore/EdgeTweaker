---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BackForwardCacheEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/backforwardcacheenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the BackForwardCache feature.'
locale: en-us
document_id: 598307b7-c83b-5917-e4f2-8e118fdf4b39
document_version_independent_id: 598307b7-c83b-5917-e4f2-8e118fdf4b39
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BackForwardCacheEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/BackForwardCacheEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 199
asset_id: microsoft-edge-policies/backforwardcacheenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BackForwardCacheEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9aa57452-fa9a-444a-0f7e-65418226395f
---

# Microsoft Edge Browser Policy Documentation BackForwardCacheEnabled | Microsoft Learn

## Control the BackForwardCache feature.

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 138
- iOS: Not supported

## Description

When enabled, the BackForwardCache feature allows the use of the back-forward cache. When navigating away from a page, its current state (document tree, script, and so on) may be preserved in the back-forward cache. If the browser navigates back to the page, the page may be restored from the back-forward cache and displayed in the state it was in before being cached.

This feature might cause issues for some websites that don't expect this caching. In particular, some websites depend on the unload event being dispatched when the browser navigates away from the page. The "unload" event isn't dispatched if the page enters the back-forward cache.

If you enable or don't configure this policy, the BackForwardCache feature is enabled.

If you disable this policy, then the feature is force disabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Android information and settings

- Preference Key name: BackForwardCacheEnabled
- Example value:

```
true
```