---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HomepageLocation | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/homepagelocation
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the home page URL'
locale: en-us
document_id: df5c2a14-99f2-35f9-ecf0-55c7bc8120c9
document_version_independent_id: df5c2a14-99f2-35f9-ecf0-55c7bc8120c9
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HomepageLocation.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/HomepageLocation.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 367
asset_id: microsoft-edge-policies/homepagelocation
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HomepageLocation.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3aed2d75-a7a8-6c8c-aaee-eec2df7c6f57
---

# Microsoft Edge Browser Policy Documentation HomepageLocation | Microsoft Learn

## Configure the home page URL

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 81
- iOS: Not supported

## Description

Configures the default home page URL in Microsoft Edge.

The home page is the page opened by the Home button. [RestoreOnStartup](restoreonstartup) policies control the pages that open on startup.

You can either set a URL here or set the home page to open the new tab page 'edge://newtab'. By default, the Home button opens the new tab page (as configured by the user or with the policy [NewTabPageLocation](newtabpagelocation)), and the user is able to choose between the URL configured by this policy and the new tab page.

If you enable this policy, users can't change their home page URL, but they can choose the behavior for the Home button to open either the set URL or the new tab page. If you wish to enforce the usage of the set URL, you must also configure [HomepageIsNewTabPage](homepageisnewtabpage)=Disabled.

If you disable or don't configure this policy, users can choose their own home page, as long as the [HomepageIsNewTabPage](homepageisnewtabpage) policy isn't enabled.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or instances that enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HomepageLocation
- GP name: Configure the home page URL
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: HomepageLocation
- Value type: REG\_SZ

#### Example registry value

```
https://www.contoso.com
```

## Mac information and settings

- Preference Key name: HomepageLocation
- Example value:

```xml
<string>https://www.contoso.com</string>
```

## Android information and settings

- Preference Key name: HomepageLocation
- Example value:

```
https://www.contoso.com
```