---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SearchbarIsEnabledOnStartup | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/searchbarisenabledonstartup
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow the Search bar at Windows startup'
locale: en-us
document_id: a531a7b4-4f13-4afc-f186-ff2a617d8df5
document_version_independent_id: a531a7b4-4f13-4afc-f186-ff2a617d8df5
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SearchbarIsEnabledOnStartup.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/SearchbarIsEnabledOnStartup.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 233
asset_id: microsoft-edge-policies/searchbarisenabledonstartup
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SearchbarIsEnabledOnStartup.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: f2dc6a9a-cb75-65b6-4219-1794bf703505
---

# Microsoft Edge Browser Policy Documentation SearchbarIsEnabledOnStartup | Microsoft Learn

## Allow the Search bar at Windows startup

## Supported versions

- Windows: ≥ 117
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Allows the Search bar to start running at Windows startup.

If you enable: The Search bar starts running at Windows startup by default. If the Search bar is disabled via [SearchbarAllowed](searchbarallowed) policy, this policy doesn't start the Search bar on Windows startup.

If you disable this policy: The Search bar doesn't start at Windows startup for all profiles. The option to start the search bar at Windows startup is disabled and toggled off in search bar settings.

If you don't configure the policy: The Search bar doesn't start at Windows startup for all profiles. The option to start the search bar at Windows startup is toggled off in search bar settings.

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

- GP unique name: SearchbarIsEnabledOnStartup
- GP name: Allow the Search bar at Windows startup
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
- Value name: SearchbarIsEnabledOnStartup
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```