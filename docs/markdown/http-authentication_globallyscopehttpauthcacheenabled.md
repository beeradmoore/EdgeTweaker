---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation GloballyScopeHTTPAuthCacheEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/globallyscopehttpauthcacheenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable globally scoped HTTP auth cache'
locale: en-us
document_id: c9c0e683-9797-094a-e457-9387ee924399
document_version_independent_id: c9c0e683-9797-094a-e457-9387ee924399
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/GloballyScopeHTTPAuthCacheEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/GloballyScopeHTTPAuthCacheEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 297
asset_id: microsoft-edge-policies/globallyscopehttpauthcacheenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/GloballyScopeHTTPAuthCacheEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b12116c7-b3f3-86ec-8658-00bd27ac804a
---

# Microsoft Edge Browser Policy Documentation GloballyScopeHTTPAuthCacheEnabled | Microsoft Learn

## Enable globally scoped HTTP auth cache

## Supported versions

- Windows: ≥ 81
- macOS: ≥ 81
- Android: ≥ 146
- iOS: Not supported

## Description

This policy configures a single global per profile cache with HTTP server authentication credentials.

If you disable or don't set this policy, the browser uses the default behavior of cross-site auth. This behavior is to scope HTTP server authentication credentials by top-level site. So, if two sites use resources from the same authenticating domain, credentials need to be provided independently in the context of both sites. Cached proxy credentials are reused across sites.

If you enable this policy, HTTP auth credentials entered in the context of one site is automatically used in the context of another site.

Enabling this policy leaves sites open to some types of cross-site attacks, and allows users to be tracked across sites even without cookies by adding entries to the HTTP auth cache using credentials embedded in URLs.

This policy is intended to give enterprises depending on the legacy behavior a chance to update their login procedures and will be removed in the future.

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

- GP unique name: GloballyScopeHTTPAuthCacheEnabled
- GP name: Enable globally scoped HTTP auth cache
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
- Value name: GloballyScopeHTTPAuthCacheEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: GloballyScopeHTTPAuthCacheEnabled
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: GloballyScopeHTTPAuthCacheEnabled
- Example value:

```
false
```