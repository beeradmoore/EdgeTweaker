---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultThirdPartyStoragePartitioningSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultthirdpartystoragepartitioningsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default setting for third-party storage partitioning (obsolete)'
locale: en-us
document_id: 23ffc453-9cce-6a2e-7bf3-cd24449013ac
document_version_independent_id: 23ffc453-9cce-6a2e-7bf3-cd24449013ac
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultThirdPartyStoragePartitioningSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultThirdPartyStoragePartitioningSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 304
asset_id: microsoft-edge-policies/defaultthirdpartystoragepartitioningsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultThirdPartyStoragePartitioningSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: de0316d1-bbc5-51a5-06ae-837ac8bdfbbc
---

# Microsoft Edge Browser Policy Documentation DefaultThirdPartyStoragePartitioningSetting | Microsoft Learn

## Default setting for third-party storage partitioning (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 145.

## Supported versions

- Windows: 115-145
- macOS: 115-145
- Android: 138-145
- iOS: Not supported

## Description

This policy controls whether third-party storage partitioning is allowed by default.

If this policy is set to 1 - AllowPartitioning, or unset, third-party storage partitioning will be allowed by default. This default may be overridden for specific top-level origins by other means.

If this policy is set to 2 - BlockPartitioning, third-party storage partitioning will be disabled for all contexts.

Use ThirdPartyStoragePartitioningBlockedForOrigins to disable third-party storage partitioning for specific top-level origins.

This feature has been removed starting in Microsoft Edge version 146. To ensure compatibility, use the requestStorageAccess method instead. For more information, see https://developer.mozilla.org/en-US/docs/Web/API/Document/requestStorageAccess.

Policy options mapping:

- AllowPartitioning (1) = Allow third-party storage partitioning by default.
- BlockPartitioning (2) = Disable third-party storage partitioning.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowPartitioning (1) = Allow third-party storage partitioning by default.
- BlockPartitioning (2) = Disable third-party storage partitioning.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultThirdPartyStoragePartitioningSetting
- GP name: Default setting for third-party storage partitioning (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow third-party storage partitioning by default.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultThirdPartyStoragePartitioningSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultThirdPartyStoragePartitioningSetting
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: DefaultThirdPartyStoragePartitioningSetting
- Example value:

```
1
```