---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultDownloadDirectory | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultdownloaddirectory
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set default download directory'
locale: en-us
document_id: a705b488-695f-e5e6-6b38-c4e0fb68dcd9
document_version_independent_id: a705b488-695f-e5e6-6b38-c4e0fb68dcd9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultDownloadDirectory.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/DefaultDownloadDirectory.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 186
asset_id: microsoft-edge-policies/defaultdownloaddirectory
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultDownloadDirectory.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9f1c3ee0-6091-d83a-c55b-f641e7f46d35
---

# Microsoft Edge Browser Policy Documentation DefaultDownloadDirectory | Microsoft Learn

## Set default download directory

## Supported versions

- Windows: ≥ 147
- macOS: ≥ 147
- Android: Not supported
- iOS: Not supported

## Description

This policy sets the default directory that Microsoft Edge uses to download files. Users can change the directory through browser settings.

If you don't configure this policy, Microsoft Edge uses the platform-specific default download directory.

This policy has no effect if the DownloadDirectory policy is set.

For a list of supported variables, see [Create user directory variables](/en-us/deployedge/edge-learnmore-create-user-directory-vars) .

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultDownloadDirectory
- GP name: Set default download directory
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Downloads
- GP ADMX file name: MSEdge.admx

#### Example value

```
/home/${user_name}/Downloads
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DefaultDownloadDirectory
- Value type: REG\_SZ

#### Example registry value

```
/home/${user_name}/Downloads
```

## Mac information and settings

- Preference Key name: DefaultDownloadDirectory
- Example value:

```xml
<string>/home/${user_name}/Downloads</string>
```