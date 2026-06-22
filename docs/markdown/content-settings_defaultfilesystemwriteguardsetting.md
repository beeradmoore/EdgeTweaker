---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultFileSystemWriteGuardSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultfilesystemwriteguardsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control use of the File System API for writing'
locale: en-us
document_id: 773e0e28-231d-5c37-3f18-b802f1ad0636
document_version_independent_id: 773e0e28-231d-5c37-3f18-b802f1ad0636
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultFileSystemWriteGuardSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/DefaultFileSystemWriteGuardSetting.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 280
asset_id: microsoft-edge-policies/defaultfilesystemwriteguardsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultFileSystemWriteGuardSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1a9e3b23-39ee-a67c-3a4e-a6f11f503e47
---

# Microsoft Edge Browser Policy Documentation DefaultFileSystemWriteGuardSetting | Microsoft Learn

## Control use of the File System API for writing

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

If you set this policy to 3, websites can ask for write access to the host operating system's filesystem using the File System API. If you set this policy to 2, access is denied.

If you don't set this policy, websites can ask for access. Users can change this setting.

Policy options mapping:

- BlockFileSystemWrite (2) = Don't allow any site to request write access to files and directories
- AskFileSystemWrite (3) = Allow sites to ask the user to grant write access to files and directories

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockFileSystemWrite (2) = Don't allow any site to request write access to files and directories
- AskFileSystemWrite (3) = Allow sites to ask the user to grant write access to files and directories

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultFileSystemWriteGuardSetting
- GP name: Control use of the File System API for writing
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Don't allow any site to request write access to files and directories
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultFileSystemWriteGuardSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultFileSystemWriteGuardSetting
- Example value:

```xml
<integer>2</integer>
```