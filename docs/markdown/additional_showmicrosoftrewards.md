---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShowMicrosoftRewards | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/showmicrosoftrewards
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show Microsoft Rewards experiences'
locale: en-us
document_id: b0fe745e-31b3-a52b-2600-1d6ab6385134
document_version_independent_id: b0fe745e-31b3-a52b-2600-1d6ab6385134
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShowMicrosoftRewards.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ShowMicrosoftRewards.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 281
asset_id: microsoft-edge-policies/showmicrosoftrewards
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShowMicrosoftRewards.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2c1473d4-57b5-f3de-00a8-7a65f90ad40e
---

# Microsoft Edge Browser Policy Documentation ShowMicrosoftRewards | Microsoft Learn

## Show Microsoft Rewards experiences

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

Show Microsoft Rewards experience and notifications. If you enable this policy:

- Microsoft account users (excludes Azure AD accounts) in search, new tab page, and earn markets see the Microsoft Rewards experience in their Microsoft Edge user profile.
- The setting to enable Microsoft Rewards in Microsoft Edge settings is enabled and toggled on.

If you disable this policy:

- Microsoft account users (excludes Azure AD accounts) in search, new tab page, and earn markets won't see the Microsoft Rewards experience in their Microsoft Edge user profile.
- The setting to enable Microsoft Rewards in Microsoft Edge settings is disabled and toggled off.

If you don't configure this policy:

- Microsoft account users (excludes Azure AD accounts) in search, new tab page, and earn markets see the Microsoft Rewards experience in their Microsoft Edge user profile.
- The setting to enable Microsoft Rewards in Microsoft Edge settings is enabled and toggled on.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ShowMicrosoftRewards
- GP name: Show Microsoft Rewards experiences
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ShowMicrosoftRewards
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ShowMicrosoftRewards
- Example value:

```xml
<false/>
```