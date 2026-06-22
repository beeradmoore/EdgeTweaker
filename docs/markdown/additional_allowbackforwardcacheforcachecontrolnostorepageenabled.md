---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowBackForwardCacheForCacheControlNoStorePageEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowbackforwardcacheforcachecontrolnostorepageenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow pages with Cache-Control: no-store header to enter back/forward cache'
locale: en-us
document_id: c7d5e06a-cb6c-5a95-9dc5-72f53e0561bd
document_version_independent_id: c7d5e06a-cb6c-5a95-9dc5-72f53e0561bd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowBackForwardCacheForCacheControlNoStorePageEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/AllowBackForwardCacheForCacheControlNoStorePageEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 247
asset_id: microsoft-edge-policies/allowbackforwardcacheforcachecontrolnostorepageenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowBackForwardCacheForCacheControlNoStorePageEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: efe695df-40d0-e4d0-9793-fca52a7c112c
---

# Microsoft Edge Browser Policy Documentation AllowBackForwardCacheForCacheControlNoStorePageEnabled | Microsoft Learn

## Allow pages with Cache-Control: no-store header to enter back/forward cache

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: ≥ 138
- iOS: Not supported

## Description

This policy controls whether a page with Cache-Control: no-store header can be stored in back/forward cache. The website setting in this header may not expect the page to be restored from back/forward cache since some sensitive information could still be displayed after the restoration even if it's no longer accessible.

If you enable or don't configure this policy, the page with Cache-Control: no-store header is restored from back/forward cache unless the cache eviction is triggered (for example, when there's HTTP-only cookie change to the site).

If you disable this policy, the page with Cache-Control: no-store header isn't stored in back/forward cache.

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

- GP unique name: AllowBackForwardCacheForCacheControlNoStorePageEnabled
- GP name: Allow pages with Cache-Control: no-store header to enter back/forward cache
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
- Value name: AllowBackForwardCacheForCacheControlNoStorePageEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AllowBackForwardCacheForCacheControlNoStorePageEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AllowBackForwardCacheForCacheControlNoStorePageEnabled
- Example value:

```
true
```