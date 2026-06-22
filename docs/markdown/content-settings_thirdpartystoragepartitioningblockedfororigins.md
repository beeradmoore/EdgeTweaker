---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ThirdPartyStoragePartitioningBlockedForOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/thirdpartystoragepartitioningblockedfororigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable third-party storage partitioning for specific top-level origins (obsolete)'
locale: en-us
document_id: d1fadd12-4833-8dc5-d0ca-a84033091762
document_version_independent_id: d1fadd12-4833-8dc5-d0ca-a84033091762
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ThirdPartyStoragePartitioningBlockedForOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ThirdPartyStoragePartitioningBlockedForOrigins.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 273
asset_id: microsoft-edge-policies/thirdpartystoragepartitioningblockedfororigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ThirdPartyStoragePartitioningBlockedForOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: aee3528e-d5d9-5e85-2c15-14f5a4dcf1ff
---

# Microsoft Edge Browser Policy Documentation ThirdPartyStoragePartitioningBlockedForOrigins | Microsoft Learn

## Disable third-party storage partitioning for specific top-level origins (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 145.

## Supported versions

- Windows: 115-145
- macOS: 115-145
- Android: 138-145
- iOS: Not supported

## Description

This policy lets you set a list of URL patterns that specify top-level origins for which third-party storage partitioning (partitioning of cross-origin iframe storage) should be disabled.

If this policy isn't set or a top-level origin doesn't match one of the URL patterns, then the value from [DefaultThirdPartyStoragePartitioningSetting](defaultthirdpartystoragepartitioningsetting) will be used.

Note that the patterns you list are treated as origins, not URLs, so you shouldn't specify a path. For detailed information about valid origin patterns, see https://go.microsoft.com/fwlink/?linkid=2095322.

This feature has been removed starting in Microsoft Edge version 146. To ensure compatibility, use the requestStorageAccess method instead. For more information, see https://developer.mozilla.org/en-US/docs/Web/API/Document/requestStorageAccess.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ThirdPartyStoragePartitioningBlockedForOrigins
- GP name: Disable third-party storage partitioning for specific top-level origins (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ThirdPartyStoragePartitioningBlockedForOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ThirdPartyStoragePartitioningBlockedForOrigins\1 =

```
www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\ThirdPartyStoragePartitioningBlockedForOrigins\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: ThirdPartyStoragePartitioningBlockedForOrigins
- Example value:

```xml
<array>
  <string>www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: ThirdPartyStoragePartitioningBlockedForOrigins
- Example value:

```
["www.example.com", "[*.]example.edu"]
```