---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultImagesSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultimagessetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default images setting'
locale: en-us
document_id: 9afcb3e3-bd36-b40f-372c-eb25b230dfbc
document_version_independent_id: 9afcb3e3-bd36-b40f-372c-eb25b230dfbc
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultImagesSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultImagesSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 228
asset_id: microsoft-edge-policies/defaultimagessetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultImagesSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a75884fe-0bf6-4941-e944-a671f36eb538
---

# Microsoft Edge Browser Policy Documentation DefaultImagesSetting | Microsoft Learn

## Default images setting

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Set whether websites can display images. You can allow images on all sites ('AllowImages') or block them on all sites ('BlockImages').

If you don't configure this policy, images are allowed by default, and the user can change this setting.

Policy options mapping:

- AllowImages (1) = Allow all sites to show all images
- BlockImages (2) = Don't allow any site to show images

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowImages (1) = Allow all sites to show all images
- BlockImages (2) = Don't allow any site to show images

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

- GP unique name: DefaultImagesSetting
- GP name: Default images setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow all sites to show all images
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultImagesSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultImagesSetting
- Example value:

```xml
<integer>1</integer>
```