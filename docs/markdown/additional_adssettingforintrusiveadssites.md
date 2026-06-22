---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AdsSettingForIntrusiveAdsSites | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/adssettingforintrusiveadssites
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Ads setting for sites with intrusive ads'
locale: en-us
document_id: 686ac1e9-2e5f-eaab-ae5f-0f05032288cd
document_version_independent_id: 686ac1e9-2e5f-eaab-ae5f-0f05032288cd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AdsSettingForIntrusiveAdsSites.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/AdsSettingForIntrusiveAdsSites.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 215
asset_id: microsoft-edge-policies/adssettingforintrusiveadssites
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AdsSettingForIntrusiveAdsSites.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 99309a3b-04da-5a5e-0d0d-07cd9df68e63
---

# Microsoft Edge Browser Policy Documentation AdsSettingForIntrusiveAdsSites | Microsoft Learn

## Ads setting for sites with intrusive ads

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: ≥ 149
- iOS: Not supported

## Description

Controls whether ads are blocked on sites with intrusive ads.

Policy options mapping:

- AllowAds (1) = Allow ads on all sites
- BlockAds (2) = Block ads on sites with intrusive ads. (Default value)

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowAds (1) = Allow ads on all sites
- BlockAds (2) = Block ads on sites with intrusive ads. (Default value)

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

- GP unique name: AdsSettingForIntrusiveAdsSites
- GP name: Ads setting for sites with intrusive ads
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow ads on all sites
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AdsSettingForIntrusiveAdsSites
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AdsSettingForIntrusiveAdsSites
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: AdsSettingForIntrusiveAdsSites
- Example value:

```
1
```