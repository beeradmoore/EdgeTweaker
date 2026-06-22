---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DiskCacheDir | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/diskcachedir
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set disk cache directory'
locale: en-us
document_id: 2474eab9-46c8-b8b8-4f33-fcc57f402449
document_version_independent_id: 2474eab9-46c8-b8b8-4f33-fcc57f402449
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DiskCacheDir.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DiskCacheDir.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 227
asset_id: microsoft-edge-policies/diskcachedir
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DiskCacheDir.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e72f2cec-1dc0-93ba-7ed5-7e919b621644
---

# Microsoft Edge Browser Policy Documentation DiskCacheDir | Microsoft Learn

## Set disk cache directory

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Configures the directory to use to store cached files.

If you enable this policy, Microsoft Edge uses the provided directory regardless of whether the user has specified the '--disk-cache-dir' flag. To avoid data loss or other unexpected errors, don't configure this policy to a volume's root directory or to a directory used for other purposes, because Microsoft Edge manages its contents.

See https://go.microsoft.com/fwlink/?linkid=2095041 for a list of variables you can use when specifying directories and paths.

If you don't configure this policy, the default cache directory is used, and users can override that default with the '--disk-cache-dir' command line flag.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DiskCacheDir
- GP name: Set disk cache directory
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
${user_home}/Edge_cache
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DiskCacheDir
- Value type: REG\_SZ

#### Example registry value

```
${user_home}/Edge_cache
```

## Mac information and settings

- Preference Key name: DiskCacheDir
- Example value:

```xml
<string>${user_home}/Edge_cache</string>
```