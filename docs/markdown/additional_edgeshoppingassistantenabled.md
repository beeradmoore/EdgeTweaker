---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeShoppingAssistantEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeshoppingassistantenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Shopping in Microsoft Edge Enabled'
locale: en-us
document_id: 2d6edd2a-58ee-f85c-6b50-e35fc7c0a316
document_version_independent_id: 2d6edd2a-58ee-f85c-6b50-e35fc7c0a316
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeShoppingAssistantEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeShoppingAssistantEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 272
asset_id: microsoft-edge-policies/edgeshoppingassistantenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeShoppingAssistantEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: cdcc3cf1-03ae-3ab0-ecd6-b6821a2a379a
---

# Microsoft Edge Browser Policy Documentation EdgeShoppingAssistantEnabled | Microsoft Learn

## Shopping in Microsoft Edge Enabled

## Supported versions

- Windows: ≥ 87
- macOS: ≥ 87
- Android: Not supported
- iOS: Not supported

## Description

This policy lets users compare the prices of a product they're looking at, get coupons or rebates from the website they're on, autoapply coupons, and help checkout faster using autofill data.

If you enable or don't configure this policy, shopping features such as price comparison, coupons, rebates, and express checkout are automatically applied for retail domains. Coupons for the current retailer and prices from other retailers are fetched from a server.

If you disable this policy, shopping features such as price comparison, coupons, rebates, and express checkout aren't automatically found for retail domains.

Starting from version 90.0.818.56, the behavior of the messaging letting users know that there's a coupon, rebate, price comparison, or price history available on shopping domains is also done through a horizontal banner below the address bar. Previously, this messaging was done on the address bar.

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

- GP unique name: EdgeShoppingAssistantEnabled
- GP name: Shopping in Microsoft Edge Enabled
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
- Value name: EdgeShoppingAssistantEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EdgeShoppingAssistantEnabled
- Example value:

```xml
<true/>
```