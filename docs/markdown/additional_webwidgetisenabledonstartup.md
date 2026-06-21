---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebWidgetIsEnabledOnStartup | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webwidgetisenabledonstartup
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow the Search bar at Windows startup (obsolete)'
locale: en-us
document_id: 14616885-c208-21c1-1ebb-a8bbcff20796
document_version_independent_id: 14616885-c208-21c1-1ebb-a8bbcff20796
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebWidgetIsEnabledOnStartup.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebWidgetIsEnabledOnStartup.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 284
asset_id: microsoft-edge-policies/webwidgetisenabledonstartup
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebWidgetIsEnabledOnStartup.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 31b0c326-0704-1190-8050-b9666fecd20f
---

# Microsoft Edge Browser Policy Documentation WebWidgetIsEnabledOnStartup | Microsoft Learn

## Allow the Search bar at Windows startup (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 119.

## Supported versions

- Windows: 88-119
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete due to the deprecation of the Web widget, which is now known as Edge search bar. Admins should use the [SearchbarIsEnabledOnStartup](searchbarisenabledonstartup) policy for Edge search bar instead. This policy allows the Search bar to start running at Windows startup.

If you enable this policy, the Search bar starts running at Windows startup by default. If the Search bar is disabled via [WebWidgetAllowed](webwidgetallowed) policy, this policy doesn't start the Search bar on Windows startup.

If you disable this policy, the Search bar doesn't start at Windows startup for all profiles. The option to start the Edge search bar at Windows startup is disabled and toggled off in Microsoft Edge settings.

If you don't configure this policy, the Search bar doesn't start at Windows startup for all profiles. The option to start the Edge search bar at Windows startup is toggled off in Microsoft Edge settings.

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

- GP unique name: WebWidgetIsEnabledOnStartup
- GP name: Allow the Search bar at Windows startup (obsolete)
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
- Value name: WebWidgetIsEnabledOnStartup
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```