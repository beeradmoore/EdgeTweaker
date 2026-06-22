---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceSyncTypes | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcesynctypes
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of types that are included for synchronization'
locale: en-us
document_id: 40c54bf2-984f-527a-60ae-18b34bf29428
document_version_independent_id: 40c54bf2-984f-527a-60ae-18b34bf29428
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceSyncTypes.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ForceSyncTypes.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 239
asset_id: microsoft-edge-policies/forcesynctypes
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceSyncTypes.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d8f5f263-f2c9-2e9c-c646-e6628105d265
---

# Microsoft Edge Browser Policy Documentation ForceSyncTypes | Microsoft Learn

## Configure the list of types that are included for synchronization

## Supported versions

- Windows: ≥ 96
- macOS: ≥ 96
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, all the specified data types are included for synchronization for Azure AD/Azure AD-Degraded user profiles. This policy can be used to ensure the type of data uploaded to the Microsoft Edge synchronization service.

You can provide one of the following data types for this policy: "favorites", "settings", "passwords", "addressesAndMore", "extensions", "history", "openTabs", "edgeWallet", "collections", "apps", and "edgeFeatureUsage". The "edgeFeatureUsage" data type is supported starting in Microsoft Edge version 134. Note that these data type names are case sensitive.

Users can't override the enabled data types.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceSyncTypes
- GP name: Configure the list of types that are included for synchronization
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
favorites
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ForceSyncTypes
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ForceSyncTypes\1 =

```
favorites
```

## Mac information and settings

- Preference Key name: ForceSyncTypes
- Example value:

```xml
<array>
  <string>favorites</string>
</array>
```