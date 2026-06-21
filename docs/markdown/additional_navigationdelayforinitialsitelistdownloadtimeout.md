---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NavigationDelayForInitialSiteListDownloadTimeout | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/navigationdelayforinitialsitelistdownloadtimeout
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set a timeout for delay of tab navigation for the Enterprise Mode Site List'
locale: en-us
document_id: ae34119b-1f90-3ad8-a47c-4cf4f0e4b95f
document_version_independent_id: ae34119b-1f90-3ad8-a47c-4cf4f0e4b95f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NavigationDelayForInitialSiteListDownloadTimeout.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NavigationDelayForInitialSiteListDownloadTimeout.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 318
asset_id: microsoft-edge-policies/navigationdelayforinitialsitelistdownloadtimeout
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NavigationDelayForInitialSiteListDownloadTimeout.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7233c534-b978-d86c-6eb8-fbde99852ad8
---

# Microsoft Edge Browser Policy Documentation NavigationDelayForInitialSiteListDownloadTimeout | Microsoft Learn

## Set a timeout for delay of tab navigation for the Enterprise Mode Site List

## Supported versions

- Windows: ≥ 84
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Allows you to set a timeout, in seconds, for Microsoft Edge tabs waiting to navigate until the browser has downloaded the initial Enterprise Mode Site List.

This setting works in conjunction with: [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) is set to 'IEMode' and [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) policy where the list has at least one entry and [DelayNavigationsForInitialSiteListDownload](delaynavigationsforinitialsitelistdownload) is set to "All eligible navigations" (1).

Tabs won't wait longer than this timeout for the Enterprise Mode Site List to download. If the browser hasn't finished downloading the Enterprise Mode Site List when the timeout expires, Microsoft Edge tabs continue navigating anyway. The value of the timeout should be no greater than 20 seconds and no fewer than 1 second.

If you set the timeout in this policy to a value greater than 2 seconds, an information bar is shown to the user after 2 seconds. The information bar contains a button that allows the user to quit waiting for the Enterprise Mode Site List download to complete.

If you don't configure this policy, the default timeout of 4 seconds is used. This default is subject to change in the future.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NavigationDelayForInitialSiteListDownloadTimeout
- GP name: Set a timeout for delay of tab navigation for the Enterprise Mode Site List
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
10
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NavigationDelayForInitialSiteListDownloadTimeout
- Value type: REG\_DWORD

#### Example registry value

```
0x0000000a
```