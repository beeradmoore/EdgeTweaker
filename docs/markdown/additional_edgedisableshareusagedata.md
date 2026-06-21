---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeDisableShareUsageData | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgedisableshareusagedata
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable data sharing usage data for personalization for iOS and Android'
locale: en-us
document_id: 4deb4ae7-3f1d-1156-cccb-dddca70ebb55
document_version_independent_id: 4deb4ae7-3f1d-1156-cccb-dddca70ebb55
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeDisableShareUsageData.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeDisableShareUsageData.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 142
asset_id: microsoft-edge-policies/edgedisableshareusagedata
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeDisableShareUsageData.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/7cf8f81d-2989-4e5d-aa91-5191d10a3323
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/1cb9c90f-9a3f-4389-8367-0a20c542621f
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 06fe52b2-e33d-59f3-816b-90341b2682d3
---

# Microsoft Edge Browser Policy Documentation EdgeDisableShareUsageData | Microsoft Learn

## Disable data sharing usage data for personalization for iOS and Android

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 143
- iOS: ≥ 143

## Description

This policy controls whether Microsoft Edge for iOS and Android can collect and share usage data to personalize the browsing experience. If you enable this policy, usage data collection and sharing for personalization will be disabled. If you disable or don't configure this policy, usage data may be collected and shared to provide personalized features.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: EdgeDisableShareUsageData
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: EdgeDisableShareUsageData
- Example value:

```xml
<true/>
```