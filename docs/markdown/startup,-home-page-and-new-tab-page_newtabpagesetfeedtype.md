---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageSetFeedType | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagesetfeedtype
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the Microsoft Edge new tab page experience (obsolete)'
locale: en-us
document_id: 2a640fd7-5a34-d06a-9334-a72b759e7edd
document_version_independent_id: 2a640fd7-5a34-d06a-9334-a72b759e7edd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageSetFeedType.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/NewTabPageSetFeedType.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 395
asset_id: microsoft-edge-policies/newtabpagesetfeedtype
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageSetFeedType.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/6ab06385-661e-4214-8870-bbe4071c960d
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/131ba09e-4280-4ae7-8622-1f9f1c0daad1
platformId: 8aeae27c-c38e-f24b-f356-9ee1206bd6d1
---

# Microsoft Edge Browser Policy Documentation NewTabPageSetFeedType | Microsoft Learn

## Configure the Microsoft Edge new tab page experience (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 92.

## Supported versions

- Windows: 79-92
- macOS: 79-92
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because the new version of the enterprise new tab page no longer requires choosing between different content types. Instead, the content that's presented to the user can be controlled via the Microsoft 365 admin center. To get to the Microsoft 365 admin center, sign in at https://admin.microsoft.com with your admin account.

Lets you choose either the Microsoft News or Office 365 feed experience for the new tab page.

If you set this policy to 'News', users see the Microsoft News feed experience on the new tab page.

If you set this policy to 'Office', users with an Azure Active Directory browser sign-in see the Office 365 feed experience on the new tab page.

If you disable or don't configure this policy, users with an Azure Active Directory browser sign-in are offered the Office 365 new tab page feed experience, and the standard new tab page feed experience. Users without an Azure Active Directory browser sign-in to see the standard new tab page experience.

If you enable this policy *and* the [NewTabPageLocation](newtabpagelocation) policy, [NewTabPageLocation](newtabpagelocation) has precedence.

Policy options mapping:

- News (0) = Microsoft News feed experience
- Office (1) = Office 365 feed experience

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- News (0) = Microsoft News feed experience
- Office (1) = Office 365 feed experience

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NewTabPageSetFeedType
- GP name: Configure the Microsoft Edge new tab page experience (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
Microsoft News feed experience
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NewTabPageSetFeedType
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: NewTabPageSetFeedType
- Example value:

```xml
<integer>0</integer>
```