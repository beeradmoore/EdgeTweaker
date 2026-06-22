---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HomepageIsNewTabPage | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/homepageisnewtabpage
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the new tab page as the home page'
locale: en-us
document_id: a7db51f3-893b-7074-98dd-be770f800486
document_version_independent_id: a7db51f3-893b-7074-98dd-be770f800486
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HomepageIsNewTabPage.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/HomepageIsNewTabPage.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 324
asset_id: microsoft-edge-policies/homepageisnewtabpage
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HomepageIsNewTabPage.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 55ca6839-a2cf-2729-2215-91ccdbdfec26
---

# Microsoft Edge Browser Policy Documentation HomepageIsNewTabPage | Microsoft Learn

## Set the new tab page as the home page

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 148
- iOS: Not supported

## Description

Configures the default home page in Microsoft Edge. You can set the home page to a URL you specify or to the new tab page.

If you enable this policy, the Home button is set to the new tab page as configured by the user or with the policy [NewTabPageLocation](newtabpagelocation) and the URL set with the policy [HomepageLocation](homepagelocation) is not taken into consideration.

If you disable this policy, the Home button is the set URL as configured by the user or as configured in the policy [HomepageLocation](homepagelocation).

If you don't configure this policy, users can choose whether the set URL or the new tab page is their home page.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or instances that enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HomepageIsNewTabPage
- GP name: Set the new tab page as the home page
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: HomepageIsNewTabPage
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: HomepageIsNewTabPage
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: HomepageIsNewTabPage
- Example value:

```
true
```