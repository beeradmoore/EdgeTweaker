---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RestoreOnStartup | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/restoreonstartup
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Action to take on Microsoft Edge startup'
locale: en-us
document_id: 79e99be3-e2af-0bf6-e6ec-d6e9b82f9f85
document_version_independent_id: 79e99be3-e2af-0bf6-e6ec-d6e9b82f9f85
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RestoreOnStartup.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/RestoreOnStartup.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 438
asset_id: microsoft-edge-policies/restoreonstartup
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RestoreOnStartup.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b76c80ce-bbeb-6f1d-0ff6-cb7648c4b090
---

# Microsoft Edge Browser Policy Documentation RestoreOnStartup | Microsoft Learn

## Action to take on Microsoft Edge startup

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Specify how Microsoft Edge behaves when it starts.

If you want a new tab to always open on startup, choose 'RestoreOnStartupIsNewTabPage'.

If you want to reopen URLs that were open the last time Microsoft Edge closed, choose 'RestoreOnStartupIsLastSession'. The browsing session is restored as it was. This option disables some settings that rely on sessions or that perform actions on exit (such as Clear browsing data on exit or session-only cookies).

If you want to open a specific set of URLs, choose 'RestoreOnStartupIsURLs'.

Starting in Microsoft Edge version 125, if you want to reopen URLs that were open the last time Microsoft Edge closed and open a specific set of URLs, choose 'RestoreOnStartupIsLastSessionAndURLs'.

Disabling this setting is the same as leaving it not configured. Users can change it in Microsoft Edge.

This policy is only available on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or instances that enrolled for device management. On macOS, this policy is only available on instances that are managed via MDM or joined to a domain via MCX.

Policy options mapping:

- RestoreOnStartupIsNewTabPage (5) = Open a new tab
- RestoreOnStartupIsLastSession (1) = Restore the last session
- RestoreOnStartupIsURLs (4) = Open a list of URLs
- RestoreOnStartupIsLastSessionAndURLs (6) = Open a list of URLs and restore the last session

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- RestoreOnStartupIsNewTabPage (5) = Open a new tab
- RestoreOnStartupIsLastSession (1) = Restore the last session
- RestoreOnStartupIsURLs (4) = Open a list of URLs
- RestoreOnStartupIsLastSessionAndURLs (6) = Open a list of URLs and restore the last session
    - Windows: ≥ 125
    - macOS: ≥ 125
    - Android: Not supported
    - iOS: Not supported

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

- GP unique name: RestoreOnStartup
- GP name: Action to take on Microsoft Edge startup
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
Open a list of URLs
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: RestoreOnStartup
- Value type: REG\_DWORD

#### Example registry value

```
0x00000004
```

## Mac information and settings

- Preference Key name: RestoreOnStartup
- Example value:

```xml
<integer>4</integer>
```