---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceYouTubeRestrict | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forceyoutuberestrict
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force minimum YouTube Restricted Mode'
locale: en-us
document_id: df3f32d5-6e71-9623-db46-5cf712009318
document_version_independent_id: df3f32d5-6e71-9623-db46-5cf712009318
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceYouTubeRestrict.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ForceYouTubeRestrict.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 299
asset_id: microsoft-edge-policies/forceyoutuberestrict
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceYouTubeRestrict.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f80894ac-1b6d-df28-c44c-aa76c526a1b4
---

# Microsoft Edge Browser Policy Documentation ForceYouTubeRestrict | Microsoft Learn

## Force minimum YouTube Restricted Mode

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 55
- iOS: Not supported

## Description

Enforces a minimum Restricted Mode on YouTube and prevents users from picking a less restricted mode.

Set to 'Strict' to enforce Strict Restricted Mode on YouTube.

Set to 'Moderate' to enforce the user to only use Moderate Restricted Mode and Strict Restricted Mode on YouTube. They can't disable Restricted Mode.

Set to 'Off' or don't configure this policy to not enforce Restricted Mode on YouTube. External policies such as YouTube policies might still enforce Restricted Mode.

Policy options mapping:

- Off (0) = Do not enforce Restricted Mode on YouTube
- Moderate (1) = Enforce at least Moderate Restricted Mode on YouTube
- Strict (2) = Enforce Strict Restricted Mode for YouTube

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Off (0) = Do not enforce Restricted Mode on YouTube
- Moderate (1) = Enforce at least Moderate Restricted Mode on YouTube
- Strict (2) = Enforce Strict Restricted Mode for YouTube

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

- GP unique name: ForceYouTubeRestrict
- GP name: Force minimum YouTube Restricted Mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not enforce Restricted Mode on YouTube
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ForceYouTubeRestrict
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ForceYouTubeRestrict
- Example value:

```xml
<integer>0</integer>
```

## Android information and settings

- Preference Key name: ForceYouTubeRestrict
- Example value:

```
0
```