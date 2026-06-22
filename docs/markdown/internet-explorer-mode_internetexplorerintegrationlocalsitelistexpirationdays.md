---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalSiteListExpirationDays | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationlocalsitelistexpirationdays
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specify the number of days that a site remains on the local IE mode site list'
locale: en-us
document_id: 658e6834-47ac-98ce-9fad-0a84ea3edab9
document_version_independent_id: 658e6834-47ac-98ce-9fad-0a84ea3edab9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalSiteListExpirationDays.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalSiteListExpirationDays.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 276
asset_id: microsoft-edge-policies/internetexplorerintegrationlocalsitelistexpirationdays
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalSiteListExpirationDays.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 76d70f4f-2b5e-7b95-71b2-0ddfe6865047
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalSiteListExpirationDays | Microsoft Learn

## Specify the number of days that a site remains on the local IE mode site list

## Supported versions

- Windows: ≥ 92
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

If the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy is enabled or not configured, users will be able to tell Microsoft Edge to load specific pages in Internet Explorer mode for a limited number of days.

You can use this setting to determine how many days that configuration is remembered in the browser. After this period has elapsed, the individual page will no longer automatically load in IE mode.

If you disable the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy, this policy has no effect.

If you disable or don't configure this policy, the default value of 30 days is used.

If you enable this policy, you must enter the number of days for which the sites are retained on the user's local site list in Microsoft Edge. The value can be from 0 to 90 days.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2094210

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationLocalSiteListExpirationDays
- GP name: Specify the number of days that a site remains on the local IE mode site list
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
30
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationLocalSiteListExpirationDays
- Value type: REG\_DWORD

#### Example registry value

```
0x0000001e
```