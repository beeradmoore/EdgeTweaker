---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultLocalFontsSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultlocalfontssetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default Local Fonts permission setting'
locale: en-us
document_id: 554b1c5f-e32e-acda-1b64-317329c2576b
document_version_independent_id: 554b1c5f-e32e-acda-1b64-317329c2576b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultLocalFontsSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultLocalFontsSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 317
asset_id: microsoft-edge-policies/defaultlocalfontssetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultLocalFontsSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 00c9f791-f45f-f3ba-6841-8bd9a1ce7b8a
---

# Microsoft Edge Browser Policy Documentation DefaultLocalFontsSetting | Microsoft Learn

## Default Local Fonts permission setting

## Supported versions

- Windows: ≥ 149
- macOS: ≥ 149
- Android: Not supported
- iOS: Not supported

## Description

Setting this policy controls the default behavior for the local fonts permission.

If you set the policy to BlockLocalFonts (value 2), access to local fonts is denied by default. Sites are prevented from accessing information about local fonts.

If you set the policy to AskLocalFonts (value 3), users are prompted when a site requests access to local fonts. If permission is granted, the site can access information about local fonts.

If a site is included in [LocalFontsAllowedForUrls](localfontsallowedforurls) or [LocalFontsBlockedForUrls](localfontsblockedforurls), then that setting overrides the value set for this policy.

If you don't configure this policy, users are prompted by default and can change this setting.

Policy options mapping:

- BlockLocalFonts (2) = Denies the Local Fonts permission on all sites by default
- AskLocalFonts (3) = Ask every time a site wants to obtain the Local Fonts permission

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockLocalFonts (2) = Denies the Local Fonts permission on all sites by default
- AskLocalFonts (3) = Ask every time a site wants to obtain the Local Fonts permission

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

- GP unique name: DefaultLocalFontsSetting
- GP name: Default Local Fonts permission setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Denies the Local Fonts permission on all sites by default
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultLocalFontsSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultLocalFontsSetting
- Example value:

```xml
<integer>2</integer>
```