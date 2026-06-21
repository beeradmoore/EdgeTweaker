---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationSiteListRefreshInterval | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationsitelistrefreshinterval
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure how frequently the Enterprise Mode Site List is refreshed'
locale: en-us
document_id: a857a89e-784a-2d98-e6d4-ab3504f4d246
document_version_independent_id: a857a89e-784a-2d98-e6d4-ab3504f4d246
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationSiteListRefreshInterval.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationSiteListRefreshInterval.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 234
asset_id: microsoft-edge-policies/internetexplorerintegrationsitelistrefreshinterval
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationSiteListRefreshInterval.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 452d95fc-d952-f09f-7492-d411073ca620
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationSiteListRefreshInterval | Microsoft Learn

## Configure how frequently the Enterprise Mode Site List is refreshed

## Supported versions

- Windows: ≥ 93
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you specify a custom refresh interval for the Enterprise Mode Site List. The refresh interval is specified in minutes. The minimum refresh interval is 30 minutes.

This setting is applicable only when the [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) or [InternetExplorerIntegrationCloudSiteList](internetexplorerintegrationcloudsitelist) setting is configured.

If you configure this policy, Microsoft Edge attempts to retrieve an updated version of the configured Enterprise Mode Site List using the specified refresh interval.

If you disable or don't configure this policy, Microsoft Edge uses a default refresh interval, it's 10080 minutes (7 days) starting from version 110 or later, 120 minutes from version 93 to 110, and 30 minutes before version 93.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationSiteListRefreshInterval
- GP name: Configure how frequently the Enterprise Mode Site List is refreshed
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
240
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationSiteListRefreshInterval
- Value type: REG\_DWORD

#### Example registry value

```
0x000000f0
```