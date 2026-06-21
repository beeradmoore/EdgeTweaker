---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CryptoWalletEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/cryptowalletenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable CryptoWallet feature (obsolete)'
locale: en-us
document_id: b3f1937c-6ac6-c592-8b78-0b8135b82869
document_version_independent_id: b3f1937c-6ac6-c592-8b78-0b8135b82869
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CryptoWalletEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CryptoWalletEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 219
asset_id: microsoft-edge-policies/cryptowalletenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CryptoWalletEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 67b2f121-2dec-995d-9d18-0f9993402a03
---

# Microsoft Edge Browser Policy Documentation CryptoWalletEnabled | Microsoft Learn

## Enable CryptoWallet feature (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 128.

## Supported versions

- Windows: 112-128
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsoleted because this feature will no longer be supported, starting in Microsoft Edge 128. There's no replacement for this policy. Enables CryptoWallet feature in Microsoft Edge.

If you enable this policy or don't configure it, users can use CryptoWallet feature that allows users to securely store, manage, and transact digital assets such as Bitcoin, Ethereum, and other cryptocurrencies. Therefore, Microsoft Edge may access Microsoft servers to communicate with the web3 world during the use of the CryptoWallet feature.

If you disable this policy, users can't use CryptoWallet feature.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CryptoWalletEnabled
- GP name: Enable CryptoWallet feature (obsolete)
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
- Value name: CryptoWalletEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```