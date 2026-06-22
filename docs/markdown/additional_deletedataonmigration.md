---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DeleteDataOnMigration | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/deletedataonmigration
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Delete old browser data on migration'
locale: en-us
document_id: 48298714-c811-b9c4-5262-6a5d74ca3080
document_version_independent_id: 48298714-c811-b9c4-5262-6a5d74ca3080
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DeleteDataOnMigration.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/DeleteDataOnMigration.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 220
asset_id: microsoft-edge-policies/deletedataonmigration
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DeleteDataOnMigration.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 09b13aff-f313-d6eb-c244-10a8933400e6
---

# Microsoft Edge Browser Policy Documentation DeleteDataOnMigration | Microsoft Learn

## Delete old browser data on migration

## Supported versions

- Windows: ≥ 83
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy determines whether user browsing data from Microsoft Edge Legacy will be deleted after migrating to the Microsoft Edge version 81 or later.

If you set this policy to "Enabled", all browsing data from Microsoft Edge Legacy after migrating to the Microsoft Edge version 81 or later is deleted. This policy must be set before migrating to the Microsoft Edge version 81 or later to have any effect on existing browsing data.

If you set this policy to "Disabled", or the policy isn't configured, user browsing data isn't deleted after migrating to the Microsoft Edge version 83 or later.

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

- GP unique name: DeleteDataOnMigration
- GP name: Delete old browser data on migration
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DeleteDataOnMigration
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```