---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ClearCachedImagesAndFilesOnExit | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/clearcachedimagesandfilesonexit
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Clear cached images and files when Microsoft Edge closes'
locale: en-us
document_id: b0ae3668-34ec-9225-0a78-6d238eec89d7
document_version_independent_id: b0ae3668-34ec-9225-0a78-6d238eec89d7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ClearCachedImagesAndFilesOnExit.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ClearCachedImagesAndFilesOnExit.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 248
asset_id: microsoft-edge-policies/clearcachedimagesandfilesonexit
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ClearCachedImagesAndFilesOnExit.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0044df0a-3a03-9b2f-ef93-1f58329df58d
---

# Microsoft Edge Browser Policy Documentation ClearCachedImagesAndFilesOnExit | Microsoft Learn

## Clear cached images and files when Microsoft Edge closes

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge doesn't clear cached images and files by default when it closes.

If you enable this policy, cached images and files are deleted each time Microsoft Edge closes.

If you disable this policy, users can't configure the cached images and files option in edge://settings/clearBrowsingDataOnClose.

If you don't configure this policy, users can choose whether cached images and files are cleared on exit.

If you disable this policy, don't enable the [ClearBrowsingDataOnExit](clearbrowsingdataonexit) policy, because they both deal with deleting data. If you configure both, the [ClearBrowsingDataOnExit](clearbrowsingdataonexit) policy takes precedence and deletes all data when Microsoft Edge closes, regardless of how you configured [ClearCachedImagesAndFilesOnExit](clearcachedimagesandfilesonexit).

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ClearCachedImagesAndFilesOnExit
- GP name: Clear cached images and files when Microsoft Edge closes
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ClearCachedImagesAndFilesOnExit
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ClearCachedImagesAndFilesOnExit
- Example value:

```xml
<true/>
```