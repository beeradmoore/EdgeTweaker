---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationCloudSiteList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationcloudsitelist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the Enterprise Mode Cloud Site List'
locale: en-us
document_id: ea7dfe74-55f5-dfea-72a3-7c65f287b495
document_version_independent_id: ea7dfe74-55f5-dfea-72a3-7c65f287b495
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudSiteList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudSiteList.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 305
asset_id: microsoft-edge-policies/internetexplorerintegrationcloudsitelist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudSiteList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: af379b31-12b0-68b4-b81a-71d3a20e9525
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationCloudSiteList | Microsoft Learn

## Configure the Enterprise Mode Cloud Site List

## Supported versions

- Windows: ≥ 93
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

The Microsoft Edge Site Lists setting in the Microsoft 365 Admin Center allows you to host your site list(s) in a compliant cloud location and manage the contents of your site list(s) through the built-in experience. This setting allows you to specify which site list within the Microsoft 365 Admin Center is to be deploy to your users. The user must be signed in to Microsoft Edge with a valid work or school account. Otherwise, Microsoft Edge doesn't download the site list from the cloud location.

This setting is applicable only when the [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) setting is configured.

If you configure this policy, Microsoft Edge uses the specified site list. When enabled, you can enter the identifier of the site list that you created and published to the cloud in M365 Admin Center.

This setting takes precedence over the [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) policy of Microsoft Edge as well as Internet Explorer's site list setting (Use the Enterprise mode IE website list). If you disable or don't configure this policy, Microsoft Edge will use the [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) policy instead.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2165707

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationCloudSiteList
- GP name: Configure the Enterprise Mode Cloud Site List
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
aba95e58-070f-4784-8dcd-e5fd46c2c6d6
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationCloudSiteList
- Value type: REG\_SZ

#### Example registry value

```
aba95e58-070f-4784-8dcd-e5fd46c2c6d6
```