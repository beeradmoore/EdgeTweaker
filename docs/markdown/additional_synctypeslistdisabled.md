---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SyncTypesListDisabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/synctypeslistdisabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of types that are excluded from synchronization'
locale: en-us
document_id: a4a3a1b5-111d-1c8f-4308-d5f94f635e6a
document_version_independent_id: a4a3a1b5-111d-1c8f-4308-d5f94f635e6a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SyncTypesListDisabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/SyncTypesListDisabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 255
asset_id: microsoft-edge-policies/synctypeslistdisabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SyncTypesListDisabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 94328e0e-359a-d547-d7e3-737dc106d800
---

# Microsoft Edge Browser Policy Documentation SyncTypesListDisabled | Microsoft Learn

## Configure the list of types that are excluded from synchronization

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: ≥ 79
- iOS: ≥ 149

## Description

If you enable this policy, all the specified data types are excluded from synchronization. This policy can be used to limit the type of data uploaded to the Microsoft Edge synchronization service.

You can provide one of the following data types for this policy: "favorites", "settings", "passwords", "addressesAndMore", "extensions", "history", "openTabs", "edgeWallet", "collections", "apps", and "edgeFeatureUsage". The "edgeFeatureUsage" data type are supported starting in Microsoft Edge version 134. These data type names are case sensitive.

Users can't override the disabled data types.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SyncTypesListDisabled
- GP name: Configure the list of types that are excluded from synchronization
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
favorites
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SyncTypesListDisabled
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SyncTypesListDisabled\1 =

```
favorites
```

## Mac information and settings

- Preference Key name: SyncTypesListDisabled
- Example value:

```xml
<array>
  <string>favorites</string>
</array>
```

## Android information and settings

- Preference Key name: SyncTypesListDisabled
- Example value:

```
["favorites"]
```

## iOS information and settings

- Preference Key name: SyncTypesListDisabled
- Example value:

```xml
<array>
  <string>favorites</string>
</array>
```