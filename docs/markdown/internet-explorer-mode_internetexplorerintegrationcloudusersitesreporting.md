---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationCloudUserSitesReporting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationcloudusersitesreporting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure reporting of IE Mode user list entries to the M365 Admin Center Site Lists app'
locale: en-us
document_id: 57359cd7-552d-19b3-cfaf-61a449c5848c
document_version_independent_id: 57359cd7-552d-19b3-cfaf-61a449c5848c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudUserSitesReporting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudUserSitesReporting.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 366
asset_id: microsoft-edge-policies/internetexplorerintegrationcloudusersitesreporting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationCloudUserSitesReporting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/68e4b2d8-b70c-4019-b49a-d1f8881e2aea
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/67b2ba1a-6f74-4044-a48a-f0f8ad076b8f
platformId: c1e5c104-435c-cc44-8431-7454a4f27915
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationCloudUserSitesReporting | Microsoft Learn

## Configure reporting of IE Mode user list entries to the M365 Admin Center Site Lists app

## Supported versions

- Windows: ≥ 99
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you enable reporting of sites that Microsoft Edge users add to their local IE Mode site list. The user must be signed in to Microsoft Edge with a valid work or school account for reports to be sent, and the user's account tenant must match the tenant that the policy specifies.

If you configure this policy, Microsoft Edge sends a report to the Microsoft 365 Admin Center Site Lists app when a user adds a site to their local IE mode site list. The report shows the URL of the site the user added, minus any query string or fragment. The user's identity isn't reported.

For this reporting to work correctly, you must successfully visit the Microsoft Edge Site Lists app in the Microsoft 365 Admin Center at least once. This visit activates a per-tenant storage account used to store these reports. Microsoft Edge still attempts to send reports if this step isn't completed. However, the reports aren't stored in the Site Lists app.

If you enable this policy, you must specify your O365 tenant ID. To learn more about finding your O365 tenant ID, see https://go.microsoft.com/fwlink/?linkid=2185668.

If you disable or don't configure this policy, Microsoft Edge never sends reports about URLs added to a user's local site list to the Site Lists app.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2165707.

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

- GP unique name: InternetExplorerIntegrationCloudUserSitesReporting
- GP name: Configure reporting of IE Mode user list entries to the M365 Admin Center Site Lists app
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
- Value name: InternetExplorerIntegrationCloudUserSitesReporting
- Value type: REG\_SZ

#### Example registry value

```
aba95e58-070f-4784-8dcd-e5fd46c2c6d6
```