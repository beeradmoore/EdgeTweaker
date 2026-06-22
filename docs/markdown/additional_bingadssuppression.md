---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BingAdsSuppression | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/bingadssuppression
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block all ads on Bing search results'
locale: en-us
document_id: 7f6a0dca-714c-a0ee-8f37-3ba178db1cca
document_version_independent_id: 7f6a0dca-714c-a0ee-8f37-3ba178db1cca
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BingAdsSuppression.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/BingAdsSuppression.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 285
asset_id: microsoft-edge-policies/bingadssuppression
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BingAdsSuppression.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 262e4d75-4459-3431-3880-b25aab410d29
---

# Microsoft Edge Browser Policy Documentation BingAdsSuppression | Microsoft Learn

## Block all ads on Bing search results

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: Not supported
- iOS: Not supported

## Description

Enables an ad-free search experience on Bing.com

If you enable this policy, then a user can search on bing.com and have an ad-free search experience. At the same time, the SafeSearch setting is set to 'Strict' and can't be changed by the user.

If you don't configure this policy, then the default experience has ads in the search results on bing.com. SafeSearch is set to 'Moderate' by default and can be changed by the user.

This policy is only available for K-12 SKUs that are identified as EDU tenants by Microsoft.

Refer to https://go.microsoft.com/fwlink/?linkid=2119711 to learn more about this policy or if the following scenarios apply to you:

- You have an EDU tenant, but the policy doesn't work.
- You had your IP allowlisted for having an ad free search experience.
- You were experiencing an ad-free search experience on Microsoft Edge Legacy and want to upgrade to the new version of Microsoft Edge.

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

- GP unique name: BingAdsSuppression
- GP name: Block all ads on Bing search results
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BingAdsSuppression
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: BingAdsSuppression
- Example value:

```xml
<true/>
```