---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebWidgetAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webwidgetallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable the Search bar (deprecated)'
locale: en-us
document_id: 0eb3d5fb-5bdf-8f2d-c40d-52f5ce163896
document_version_independent_id: 0eb3d5fb-5bdf-8f2d-c40d-52f5ce163896
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebWidgetAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/WebWidgetAllowed.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 431
asset_id: microsoft-edge-policies/webwidgetallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebWidgetAllowed.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 1f18aed4-893a-e593-5089-3598823e9dd9
---

# Microsoft Edge Browser Policy Documentation WebWidgetAllowed | Microsoft Learn

## Enable the Search bar (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 88
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Enables the search bar. When enabled, users can use the search bar to search the web from their desktop or from an application. The search bar provides a search box that shows web suggestions and opens all web searches in Microsoft Edge. The search box provides search (powered by Bing) and URL suggestions. The search bar can be launched from the "More tools" menu or jump list in Microsoft Edge.

If you enable or don't configure this policy, the following results are seen: The search bar is automatically enabled for all profiles. The option to enable the search bar at startup is toggled on if the [WebWidgetIsEnabledOnStartup](webwidgetisenabledonstartup) policy is enabled. If the [WebWidgetIsEnabledOnStartup](webwidgetisenabledonstartup) is disabled or not configured, the option to enable the search bar at startup is toggled off. Users will see the menu item to launch the search bar from the Microsoft Edge "More tools" menu. Users can launch the search bar from "More tools". Users will see the menu item to launch the search bar from the Microsoft Edge jump list menu. Users can launch the search bar from the Microsoft Edge jump list menu. The search bar can be turned off by the "Quit" option in the System tray or by closing the search bar from the three-dot menu. The search bar is restarted on system reboot if auto-start is enabled.

If you disable this policy, the following results are seen: The search bar is disabled for all profiles. The option to launch the search bar from Microsoft Edge "More tools" menu is disabled. The option to launch the search bar from Microsoft Edge jump list menu is disabled.

This policy is deprecated due to the deprecation of the Web widget's vertical layout. This policy will be made obsolete in 119 release.

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

- GP unique name: WebWidgetAllowed
- GP name: Enable the Search bar (deprecated)
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
- Value name: WebWidgetAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```