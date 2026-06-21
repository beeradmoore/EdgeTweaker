---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultIdleDetectionSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultidledetectionsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default idle detection setting'
locale: en-us
document_id: 5d54eaad-a683-47a3-f678-22e712aa3e2b
document_version_independent_id: 5d54eaad-a683-47a3-f678-22e712aa3e2b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultIdleDetectionSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultIdleDetectionSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 327
asset_id: microsoft-edge-policies/defaultidledetectionsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultIdleDetectionSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: afb27a06-9552-9994-a53b-a2630782fc73
---

# Microsoft Edge Browser Policy Documentation DefaultIdleDetectionSetting | Microsoft Learn

## Default idle detection setting

## Supported versions

- Windows: ≥ 145
- macOS: ≥ 145
- Android: ≥ 145
- iOS: Not supported

## Description

Setting this policy to 1 - AllowIdleDetection allows websites to use the Idle Detection API without requesting user permission.

Setting this policy to 2 - BlockIdleDetection prevents websites from using the Idle Detection API.

Setting this policy to 3 - AskIdleDetection requires websites to request user permission each time before using the Idle Detection API.

If you do not configure this policy, users can decide whether to allow the Idle Detection API and can change this setting themselves.

Policy options mapping:

- AllowIdleDetection (1) = Allow sites to detect idle state without asking the user
- BlockIdleDetection (2) = Do not allow any site to detect the user's idle state
- AskIdleDetection (3) = Ask every time a site wants to detect the user's idle state

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowIdleDetection (1) = Allow sites to detect idle state without asking the user
- BlockIdleDetection (2) = Do not allow any site to detect the user's idle state
- AskIdleDetection (3) = Ask every time a site wants to detect the user's idle state

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

- GP unique name: DefaultIdleDetectionSetting
- GP name: Default idle detection setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow sites to detect idle state without asking the user
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultIdleDetectionSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultIdleDetectionSetting
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: DefaultIdleDetectionSetting
- Example value:

```
1
```