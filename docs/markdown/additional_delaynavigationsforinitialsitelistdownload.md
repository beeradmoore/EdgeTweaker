---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DelayNavigationsForInitialSiteListDownload | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/delaynavigationsforinitialsitelistdownload
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Require that the Enterprise Mode Site List is available before tab navigation'
locale: en-us
document_id: bb9aabd2-ea27-250d-8e21-16528f3f64e4
document_version_independent_id: bb9aabd2-ea27-250d-8e21-16528f3f64e4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DelayNavigationsForInitialSiteListDownload.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DelayNavigationsForInitialSiteListDownload.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 522
asset_id: microsoft-edge-policies/delaynavigationsforinitialsitelistdownload
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DelayNavigationsForInitialSiteListDownload.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0a488884-478e-a83b-49d8-c33816ef78e5
---

# Microsoft Edge Browser Policy Documentation DelayNavigationsForInitialSiteListDownload | Microsoft Learn

## Require that the Enterprise Mode Site List is available before tab navigation

## Supported versions

- Windows: ≥ 84
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Lets you specify whether Microsoft Edge tabs wait to navigate until the browser downloaded the initial Enterprise Mode Site List. This setting is intended for the scenario where the browser home page should load in Internet Explorer (IE) mode, and it's important that it does so on browser first run after IE mode is enabled. If this scenario doesn't exist, we recommend not enabling this setting because it negatively impacts the performance of loading the home page. The setting only applies when Microsoft Edge doesn't have a cached Enterprise Mode Site List, such as on browser first run after IE mode is enabled.

This setting works if [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) is set to 'IEMode' and if either the [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) or the [InternetExplorerIntegrationCloudSiteList](internetexplorerintegrationcloudsitelist) policies be enabled, where the list has at least one entry.

The timeout behavior of this policy is configured with the [NavigationDelayForInitialSiteListDownloadTimeout](navigationdelayforinitialsitelistdownloadtimeout) policy.

If you set this policy to 'All' and when Microsoft Edge doesn't have a cached version of the Enterprise Mode Site List, tabs delay navigating until the browser downloaded the site list. Sites configured to open in Internet Explorer mode by the site list load in Internet Explorer mode, even during the initial navigation of the browser. Sites that can't be configured to open in Internet Explorer, such as any site with a scheme other than http:, https:, file:, or ftp: don't delay navigating and load immediately in Microsoft Edge mode.

When used with the [InternetExplorerIntegrationCloudSiteList](internetexplorerintegrationcloudsitelist) policy, during first launch of Microsoft Edge, there is a delay because implicit sign in needs to finish before Microsoft Edge attempts to download the site list from the Microsoft cloud since this requires authentication to the cloud service.

If you set this policy to 'None' or don't configure it and when Microsoft Edge doesn't have a cached version of the Enterprise Mode Site List, tabs navigate immediately and don't wait for the browser to download the Enterprise Mode Site List. Sites configured to open in Internet Explorer mode by the site list open in Microsoft Edge mode until the browser finished downloading the Enterprise Mode Site List.

Policy options mapping:

- None (0) = None
- All (1) = All eligible navigations

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- None (0) = None
- All (1) = All eligible navigations

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

- GP unique name: DelayNavigationsForInitialSiteListDownload
- GP name: Require that the Enterprise Mode Site List is available before tab navigation
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
All eligible navigations
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DelayNavigationsForInitialSiteListDownload
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```