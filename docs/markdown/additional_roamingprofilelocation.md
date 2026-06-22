---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RoamingProfileLocation | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/roamingprofilelocation
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the roaming profile directory'
locale: en-us
document_id: 59389d09-abf7-e90c-562b-f93fee62c01c
document_version_independent_id: 59389d09-abf7-e90c-562b-f93fee62c01c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RoamingProfileLocation.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/RoamingProfileLocation.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 199
asset_id: microsoft-edge-policies/roamingprofilelocation
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RoamingProfileLocation.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9409caad-3baa-06c2-369a-1a685daa9ff4
---

# Microsoft Edge Browser Policy Documentation RoamingProfileLocation | Microsoft Learn

## Set the roaming profile directory

## Supported versions

- Windows: ≥ 85
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configures the directory to use to store the roaming copy of profiles.

If you enable this policy, Microsoft Edge uses the provided directory to store a roaming copy of the profiles, as long as you've also enabled the [RoamingProfileSupportEnabled](roamingprofilesupportenabled) policy. If you disable the [RoamingProfileSupportEnabled](roamingprofilesupportenabled) policy or don't configure it, the value stored in this policy isn't used.

See https://go.microsoft.com/fwlink/?linkid=2095041 for a list of variables you can use.

If you don't configure this policy, the default roaming profile path is used.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RoamingProfileLocation
- GP name: Set the roaming profile directory
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
${roaming_app_data}\edge-profile
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RoamingProfileLocation
- Value type: REG\_SZ

#### Example registry value

```
${roaming_app_data}\edge-profile
```