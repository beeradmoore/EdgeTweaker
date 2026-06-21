---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UserDataDir | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/userdatadir
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the user data directory'
locale: en-us
document_id: cc52f725-3c52-5b75-52f5-ac3b67c0750c
document_version_independent_id: cc52f725-3c52-5b75-52f5-ac3b67c0750c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UserDataDir.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/UserDataDir.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 238
asset_id: microsoft-edge-policies/userdatadir
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UserDataDir.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 102c0a13-ccac-971b-f670-f4cc06034805
---

# Microsoft Edge Browser Policy Documentation UserDataDir | Microsoft Learn

## Set the user data directory

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Set the directory to use for storing user data.

If you enable this policy, Microsoft Edge uses the specified directory regardless of whether the user has set the '--user-data-dir' command-line flag.

If you don't enable this policy, the default profile path is used, but the user can override it by using the '--user-data-dir' flag. Users can find the directory for the profile at edge://version/ under profile path.

To avoid data loss or other errors, don't configure this policy to a volume's root directory or to a directory that's used for other purposes, because Microsoft Edge manages its contents.

See https://go.microsoft.com/fwlink/?linkid=2095041 for a list of variables that can be used.

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

- GP unique name: UserDataDir
- GP name: Set the user data directory
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
${users}/${user_name}/Edge
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: UserDataDir
- Value type: REG\_SZ

#### Example registry value

```
${users}/${user_name}/Edge
```

## Mac information and settings

- Preference Key name: UserDataDir
- Example value:

```xml
<string>${users}/${user_name}/Edge</string>
```