---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultPopupsSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultpopupssetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default pop-up window setting'
locale: en-us
document_id: e380ba28-d8d1-397d-9814-688186037521
document_version_independent_id: e380ba28-d8d1-397d-9814-688186037521
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultPopupsSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultPopupsSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 252
asset_id: microsoft-edge-policies/defaultpopupssetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultPopupsSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 08042b86-efaa-1b50-3ac9-99bc0a7ae6e6
---

# Microsoft Edge Browser Policy Documentation DefaultPopupsSetting | Microsoft Learn

## Default pop-up window setting

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 33
- iOS: ≥ 84

## Description

Set whether websites can show pop-up windows. You can allow them on all websites ('AllowPopups') or block them on all sites ('BlockPopups').

If you don't configure this policy, pop-up windows are blocked by default, and users can change this setting.

Policy options mapping:

- AllowPopups (1) = Allow all sites to show pop-ups
- BlockPopups (2) = Do not allow any site to show popups

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowPopups (1) = Allow all sites to show pop-ups
- BlockPopups (2) = Do not allow any site to show popups

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

- GP unique name: DefaultPopupsSetting
- GP name: Default pop-up window setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow all sites to show pop-ups
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultPopupsSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultPopupsSetting
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: DefaultPopupsSetting
- Example value:

```
1
```

## iOS information and settings

- Preference Key name: DefaultPopupsSetting
- Example value:

```xml
<integer>1</integer>
```