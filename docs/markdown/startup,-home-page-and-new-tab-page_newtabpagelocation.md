---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageLocation | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagelocation
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the new tab page URL'
locale: en-us
document_id: 3ad385d1-0d5c-709b-c6f6-25ffa88874f7
document_version_independent_id: 3ad385d1-0d5c-709b-c6f6-25ffa88874f7
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageLocation.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/NewTabPageLocation.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 355
asset_id: microsoft-edge-policies/newtabpagelocation
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageLocation.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: c8254f62-e8e1-927f-63bf-40f1cc211636
---

# Microsoft Edge Browser Policy Documentation NewTabPageLocation | Microsoft Learn

## Configure the new tab page URL

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 142
- iOS: ≥ 142

## Description

Configures the default URL for the new tab page.

The recommended version of this policy doesn't currently work and functions exactly like the mandatory version.

This policy determines the page that opens when new tabs are created (including when new windows are opened). It also affects the startup page if this page opens to the new tab page.

This policy doesn't determine which page opens on startup; that factor is controlled by the [RestoreOnStartup](restoreonstartup) policy. It also doesn't affect the home page if this home page opens to the new tab page.

If you don't configure this policy, the default new tab page is used.

If you configure this policy *and* the [NewTabPageSetFeedType](newtabpagesetfeedtype) policy, this policy takes precedence.

If a blank tab is preferred, "about:blank" is the correct URL to use, not "about://blank".

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or joined to instances that enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

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

- GP unique name: NewTabPageLocation
- GP name: Configure the new tab page URL
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.fabrikam.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NewTabPageLocation
- Value type: REG\_SZ

#### Example registry value

```
https://www.fabrikam.com
```

## Mac information and settings

- Preference Key name: NewTabPageLocation
- Example value:

```xml
<string>https://www.fabrikam.com</string>
```

## Android information and settings

- Preference Key name: NewTabPageLocation
- Example value:

```
https://www.fabrikam.com
```

## iOS information and settings

- Preference Key name: NewTabPageLocation
- Example value:

```xml
<string>https://www.fabrikam.com</string>
```