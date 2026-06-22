---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultWindowManagementSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultwindowmanagementsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default Window Management permission setting'
locale: en-us
document_id: 6e3a36a5-5e0f-0e1e-a3e5-24f04c3de24f
document_version_independent_id: 6e3a36a5-5e0f-0e1e-a3e5-24f04c3de24f
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultWindowManagementSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/DefaultWindowManagementSetting.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 323
asset_id: microsoft-edge-policies/defaultwindowmanagementsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultWindowManagementSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: f6cff9ff-a789-cf3b-8c60-70fd9d2943ee
---

# Microsoft Edge Browser Policy Documentation DefaultWindowManagementSetting | Microsoft Learn

## Default Window Management permission setting

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy to "BlockWindowManagement" (value 2) automatically denies the window management permission to sites by default. This setting limits the ability of sites to see information about the device's screens and use that information to open and place windows or request fullscreen on specific screens.

Setting the policy to "AskWindowManagement" (value 3) by default prompts the user when the window management permission is requested. If users allow the permission, it extends the ability of sites to see information about the device's screens and use that information to open and place windows or request fullscreen on specific screens.

Not configuring the policy means the "AskWindowManagement" policy applies, but users can change this setting.

Policy options mapping:

- BlockWindowManagement (2) = Denies the Window Management permission on all sites by default
- AskWindowManagement (3) = Ask every time a site wants obtain the Window Management permission

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockWindowManagement (2) = Denies the Window Management permission on all sites by default
- AskWindowManagement (3) = Ask every time a site wants obtain the Window Management permission

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultWindowManagementSetting
- GP name: Default Window Management permission setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Denies the Window Management permission on all sites by default
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultWindowManagementSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultWindowManagementSetting
- Example value:

```xml
<integer>2</integer>
```