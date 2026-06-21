---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DiskCacheSize | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/diskcachesize
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set disk cache size, in bytes'
locale: en-us
document_id: f3ef91b9-c3c5-e695-9c77-1ce01abf6fc4
document_version_independent_id: f3ef91b9-c3c5-e695-9c77-1ce01abf6fc4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DiskCacheSize.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DiskCacheSize.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 297
asset_id: microsoft-edge-policies/diskcachesize
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DiskCacheSize.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3a382454-ed18-3b9e-0e11-db22e52cc635
---

# Microsoft Edge Browser Policy Documentation DiskCacheSize | Microsoft Learn

## Set disk cache size, in bytes

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

This policy configures the disk cache size in Microsoft Edge.

If you enable this policy, Microsoft Edge uses the specified cache size, regardless of whether the user set the --disk-cache-size command-line flag.

The value defined in this policy is treated as a suggestion to the caching system, not a strict limit. Values below a few megabytes are rounded up to a reasonable minimum.

If you set the value to 0, the default cache size is used and users can't override it.

It's recommended not to configure a custom value, as Microsoft Edge automatically manages the cache size for optimal performance. Setting a small value can degrade performance and increase network usage.

If you don’t configure this policy, the default size is used, but users can override it with the --disk-cache-size flag.

Note: The specified value is treated as a hint to multiple cache subsystems. The total disk usage of all caches can be larger than (but within the same order of magnitude as) the configured value.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DiskCacheSize
- GP name: Set disk cache size, in bytes
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
335544320
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DiskCacheSize
- Value type: REG\_DWORD

#### Example registry value

```
0x14000000
```

## Mac information and settings

- Preference Key name: DiskCacheSize
- Example value:

```xml
<integer>335544320</integer>
```