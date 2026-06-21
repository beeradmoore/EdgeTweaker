---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation FileSystemReadBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/filesystemreadblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block read access via the File System API on these sites'
locale: en-us
document_id: 1d0a7aa5-94d7-6c38-af0e-98bcd9b6db62
document_version_independent_id: 1d0a7aa5-94d7-6c38-af0e-98bcd9b6db62
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/FileSystemReadBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/FileSystemReadBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 244
asset_id: microsoft-edge-policies/filesystemreadblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/FileSystemReadBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 4beeb97a-53e4-d6c7-4517-8f800a7e3ac6
---

# Microsoft Edge Browser Policy Documentation FileSystemReadBlockedForUrls | Microsoft Learn

## Block read access via the File System API on these sites

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

If you set this policy, you can list the URL patterns that specify which sites can't ask users to grant them read access to files or directories in the host operating system's file system via the File System API.

If you don't set this policy, [DefaultFileSystemReadGuardSetting](defaultfilesystemreadguardsetting) applies for all sites, if set. If not, users' personal settings apply.

URL patterns can't conflict with [FileSystemReadAskForUrls](filesystemreadaskforurls). Neither policy takes precedence if a URL matches with both.

For detailed information about valid url patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* isn't an accepted value for this policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: FileSystemReadBlockedForUrls
- GP name: Block read access via the File System API on these sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\FileSystemReadBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\FileSystemReadBlockedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\FileSystemReadBlockedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: FileSystemReadBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```