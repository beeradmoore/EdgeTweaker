---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SyncDisabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/syncdisabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable synchronization of data using Microsoft sync services'
locale: en-us
document_id: 88fd3479-9fce-9ad5-d37d-37b8e9585183
document_version_independent_id: 88fd3479-9fce-9ad5-d37d-37b8e9585183
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SyncDisabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/SyncDisabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 225
asset_id: microsoft-edge-policies/syncdisabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SyncDisabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c6afd0c3-deb5-d322-a2ad-cbdf0d245162
---

# Microsoft Edge Browser Policy Documentation SyncDisabled | Microsoft Learn

## Disable synchronization of data using Microsoft sync services

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 142
- iOS: ≥ 142

## Description

Disables data synchronization in Microsoft Edge. This policy also prevents the sync consent prompt from appearing.

This policy disables cloud synchronization only and has no impact on the [RoamingProfileSupportEnabled](roamingprofilesupportenabled) policy.

If you don't set this policy or apply it as recommended, users can turn on or turn off sync. If you apply this policy as mandatory, users won't be able to turn on sync.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SyncDisabled
- GP name: Disable synchronization of data using Microsoft sync services
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SyncDisabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SyncDisabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: SyncDisabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: SyncDisabled
- Example value:

```xml
<true/>
```