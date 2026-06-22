---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RedirectSitesFromInternetExplorerRedirectMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/redirectsitesfrominternetexplorerredirectmode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Redirect incompatible sites from Internet Explorer to Microsoft Edge'
locale: en-us
document_id: 0f572e4f-193e-e098-db23-6f73fbb29eec
document_version_independent_id: 0f572e4f-193e-e098-db23-6f73fbb29eec
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RedirectSitesFromInternetExplorerRedirectMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/RedirectSitesFromInternetExplorerRedirectMode.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 455
asset_id: microsoft-edge-policies/redirectsitesfrominternetexplorerredirectmode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RedirectSitesFromInternetExplorerRedirectMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 42f3a334-cc65-41b9-532b-2864abdad41a
---

# Microsoft Edge Browser Policy Documentation RedirectSitesFromInternetExplorerRedirectMode | Microsoft Learn

## Redirect incompatible sites from Internet Explorer to Microsoft Edge

## Supported versions

- Windows: ≥ 87
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you specify whether Internet Explorer redirects navigations to sites that require a modern browser to Microsoft Edge. If you set this policy to 'Disable' ('Prevent redirection', value 0), Internet Explorer doesn't redirect any traffic to Microsoft Edge.

If you set this policy to 'Sitelist', starting with Microsoft Edge major release 87, Internet Explorer (IE) redirects sites that require a modern browser to Microsoft Edge. (Note: The Sitelist setting is 'Redirect sites based on the incompatible sites sitelist', value 1.)

When a site is redirected from Internet Explorer to Microsoft Edge, the Internet Explorer tab that started loading the site is closed if it had no prior content. Otherwise, the user is taken to a Microsoft help page that explains why the site was redirected to Microsoft Edge. When Microsoft Edge is launched to load an IE site, an information bar explains that the site works best in a modern browser.

If you want to redirect all navigations, configure the Disable Internet Explorer 11 policy, which redirects all navigations from IE11 to Microsoft Edge. It also hides the IE11 app icon from the user after the first launch.

If you don't configure this policy:

- Starting with Microsoft Edge major release 87, you have the same experience as setting the policy to 'Sitelist': Internet Explorer redirects sites that require a modern browser to Microsoft Edge.
- In the future, the default for your organization changes to automatically redirect all navigations. If you don't want automatic redirection, set this policy to 'Disable' or 'Sitelist'.

For more information about this policy, see https://go.microsoft.com/fwlink/?linkid=2141715.

Policy options mapping:

- Disable (0) = Prevent redirection
- Sitelist (1) = Redirect sites based on the incompatible sites sitelist

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Disable (0) = Prevent redirection
- Sitelist (1) = Redirect sites based on the incompatible sites sitelist

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RedirectSitesFromInternetExplorerRedirectMode
- GP name: Redirect incompatible sites from Internet Explorer to Microsoft Edge
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Redirect sites based on the incompatible sites sitelist
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: RedirectSitesFromInternetExplorerRedirectMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```