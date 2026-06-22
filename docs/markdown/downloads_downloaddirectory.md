---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DownloadDirectory | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/downloaddirectory
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set download directory'
locale: en-us
document_id: a351b209-dc94-fceb-c98b-a1de0b0477e8
document_version_independent_id: a351b209-dc94-fceb-c98b-a1de0b0477e8
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DownloadDirectory.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DownloadDirectory.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 255
asset_id: microsoft-edge-policies/downloaddirectory
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DownloadDirectory.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 01682fd9-28fe-ab02-6098-c392bbd9b4b7
---

# Microsoft Edge Browser Policy Documentation DownloadDirectory | Microsoft Learn

## Set download directory

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Configures the directory to use when downloading files.

If you enable this policy, Microsoft Edge uses the provided directory regardless of whether the user specified one or chose to be prompted for download location every time. See https://go.microsoft.com/fwlink/?linkid=2095041 for a list of variables that can be used.

If you disable or don't configure this policy, the default download directory is used, and the user can change it.

If you set an invalid path, Microsoft Edge defaults to the user's default download directory.

If the folder specified by the path doesn't exist, the download triggers a prompt that asks the user where they want to save their download.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DownloadDirectory
- GP name: Set download directory
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```

        Linux-based OSes (including Mac): /home/${user_name}/Downloads
        Windows: C:\Users\${user_name}\Downloads
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DownloadDirectory
- Value type: REG\_SZ

#### Example registry value

```

        Linux-based OSes (including Mac): /home/${user_name}/Downloads
        Windows: C:\Users\${user_name}\Downloads
```

## Mac information and settings

- Preference Key name: DownloadDirectory
- Example value:

```xml
<string>
        Linux-based OSes (including Mac): /home/${user_name}/Downloads
        Windows: C:\Users\${user_name}\Downloads</string>
```