---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeWalletCheckoutEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgewalletcheckoutenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Wallet Checkout feature'
locale: en-us
document_id: 1720b94f-6b2c-b73b-2833-6c6842edb15c
document_version_independent_id: 1720b94f-6b2c-b73b-2833-6c6842edb15c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeWalletCheckoutEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/EdgeWalletCheckoutEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 163
asset_id: microsoft-edge-policies/edgewalletcheckoutenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeWalletCheckoutEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a9167a6c-d4bc-3655-124e-1c286fb71c12
---

# Microsoft Edge Browser Policy Documentation EdgeWalletCheckoutEnabled | Microsoft Learn

## Enable Wallet Checkout feature

## Supported versions

- Windows: ≥ 114
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Enables Wallet Checkout feature in Microsoft Edge.

If you enable or don't configure this policy, users can choose whether to use wallet checkout while shopping on Microsoft Edge.

If you disable this policy, users can't use wallet checkout while shopping on Microsoft Edge.

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

- GP unique name: EdgeWalletCheckoutEnabled
- GP name: Enable Wallet Checkout feature
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
- Value name: EdgeWalletCheckoutEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```