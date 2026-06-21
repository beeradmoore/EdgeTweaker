---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationCloudNeutralSitesReporting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationcloudneutralsitesreporting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure reporting of potentially misconfigured neutral site URLs to the M365 Admin Center Site Lists app'
locale: en-us
document_id: 1a2a8b4b-6498-329e-8aa5-53b2a9ac318e
document_version_independent_id: 1a2a8b4b-6498-329e-8aa5-53b2a9ac318e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudNeutralSitesReporting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudNeutralSitesReporting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 391
asset_id: microsoft-edge-policies/internetexplorerintegrationcloudneutralsitesreporting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudNeutralSitesReporting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/68e4b2d8-b70c-4019-b49a-d1f8881e2aea
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/67b2ba1a-6f74-4044-a48a-f0f8ad076b8f
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 126ec20b-5b93-8c22-e9f8-e471dd37eac9
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationCloudNeutralSitesReporting | Microsoft Learn

## Configure reporting of potentially misconfigured neutral site URLs to the M365 Admin Center Site Lists app

## Supported versions

- Windows: ≥ 99
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you enable reporting of sites that need to be configured as a neutral site on the Enterprise Mode Site List. The user must be signed in to Microsoft Edge with a valid work or school account for reports to be sent, and the user's account tenant must match the tenant specified by the policy.

If you configure this policy, Microsoft Edge sends a report to the Microsoft 365 Admin Center Site Lists app when a navigation appears stuck redirecting back and forth between the Microsoft Edge and Internet Explorer (IE) engines several times. This indicates that redirection to an authentication server is switching engines, which repeatedly fails in a loop. The report shows the URL of the site that's the redirect target, minus any query string or fragment. The user's identity isn't reported.

For this reporting to work correctly, you must have successfully visited the Microsoft Edge Site Lists app in the Microsoft 365 Admin Center at least once. This activates a per-tenant storage account used to store these reports. Microsoft Edge still attempts to send reports if this step hasn't been completed. However, the reports aren't stored in the Site Lists app.

If you enable this policy, you must specify your Office 365 tenant ID. To learn more about finding your Office 365 tenant ID, see https://go.microsoft.com/fwlink/?linkid=2185668.

If you disable or don't configure this policy, Microsoft Edge never sends reports about misconfigured neutral sites to the Site Lists app.

To learn more about IE mode, see https://go.microsoft.com/fwlink/?linkid=2165707.

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

- GP unique name: InternetExplorerIntegrationCloudNeutralSitesReporting
- GP name: Configure reporting of potentially misconfigured neutral site URLs to the M365 Admin Center Site Lists app
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
- Value name: InternetExplorerIntegrationCloudNeutralSitesReporting
- Value type: REG\_SZ

#### Example registry value

```
aba95e58-070f-4784-8dcd-e5fd46c2c6d6
```