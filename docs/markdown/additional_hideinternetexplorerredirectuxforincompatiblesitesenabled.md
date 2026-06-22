---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HideInternetExplorerRedirectUXForIncompatibleSitesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/hideinternetexplorerredirectuxforincompatiblesitesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Hide the one-time redirection dialog and the banner on Microsoft Edge'
locale: en-us
document_id: 615efe28-2d31-8ad5-ef79-67a7fabc1efd
document_version_independent_id: 615efe28-2d31-8ad5-ef79-67a7fabc1efd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HideInternetExplorerRedirectUXForIncompatibleSitesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/HideInternetExplorerRedirectUXForIncompatibleSitesEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 261
asset_id: microsoft-edge-policies/hideinternetexplorerredirectuxforincompatiblesitesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HideInternetExplorerRedirectUXForIncompatibleSitesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8b03bc34-1b86-957f-99e1-37d25c6a0307
---

# Microsoft Edge Browser Policy Documentation HideInternetExplorerRedirectUXForIncompatibleSitesEnabled | Microsoft Learn

## Hide the one-time redirection dialog and the banner on Microsoft Edge

## Supported versions

- Windows: ≥ 87
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy gives an option to disable one-time redirection dialog and the banner. If you enable this policy, users don't see both the one-time dialog and the banner. Users continue to be redirected to Microsoft Edge when they encounter an incompatible website on Internet Explorer; however, their browsing data isn't imported.

- If you enable this policy, the one-time redirection dialog and banner are never shown to users. Users' browsing data isn't imported when a redirection happens.
- If you disable or don't set this policy, the redirection dialog is shown on the first redirection, and the persistent redirection banner is shown to users on sessions that begin with a redirection. Users' browsing data will be imported every time user encounters such redirection (ONLY IF user consents to it on the one-time dialog).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HideInternetExplorerRedirectUXForIncompatibleSitesEnabled
- GP name: Hide the one-time redirection dialog and the banner on Microsoft Edge
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: HideInternetExplorerRedirectUXForIncompatibleSitesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```