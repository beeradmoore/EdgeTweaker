---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WalletDonationEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/walletdonationenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Wallet Donation Enabled (deprecated)'
locale: en-us
document_id: 3f4377b6-e79f-3146-80c0-fa3ea2d21df5
document_version_independent_id: 3f4377b6-e79f-3146-80c0-fa3ea2d21df5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WalletDonationEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WalletDonationEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/walletdonationenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WalletDonationEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3bec9d82-8bbe-5ade-a361-7c8c0a3e45b2
---

# Microsoft Edge Browser Policy Documentation WalletDonationEnabled | Microsoft Learn

## Wallet Donation Enabled (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 115
- macOS: ≥ 115
- Android: Not supported
- iOS: Not supported

## Description

The Wallet Donation feature in Microsoft Edge allows users to view their donation summary, explore Nonprofit organizations (NPOs), donate to an NPO, manage their monthly donations, and view their donation history.

If you enable or don't configure this policy, users can use the Wallet Donation feature.

If you disable this policy, users can't use the Wallet Donation feature.

This policy is deprecated because the Wallet Donation feature has been removed from Microsoft Edge.

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

- GP unique name: WalletDonationEnabled
- GP name: Wallet Donation Enabled (deprecated)
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
- Value name: WalletDonationEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WalletDonationEnabled
- Example value:

```xml
<true/>
```