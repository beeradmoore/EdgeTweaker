---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TyposquattingCheckerEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/typosquattingcheckerenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Edge Website Typo Protection'
locale: en-us
document_id: 088b5efd-50ae-47ac-1621-e3d350da5cd8
document_version_independent_id: 088b5efd-50ae-47ac-1621-e3d350da5cd8
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TyposquattingCheckerEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/TyposquattingCheckerEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 239
asset_id: microsoft-edge-policies/typosquattingcheckerenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TyposquattingCheckerEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ade070ab-31a5-e6a3-8879-54ff5519451f
---

# Microsoft Edge Browser Policy Documentation TyposquattingCheckerEnabled | Microsoft Learn

## Configure Edge Website Typo Protection

## Supported versions

- Windows: ≥ 96
- macOS: ≥ 96
- Android: ≥ 124
- iOS: Not supported

## Description

This policy setting lets you configure whether to turn on Edge Website Typo Protection. Edge Website Typo Protection provides warning messages to help protect your users from potential typosquatting sites. By default, Edge Website Typo Protection is turned on.

If you enable this policy, Edge Website Typo Protection is turned on.

If you disable this policy, Edge Website Typo Protection is turned off.

If you don't configure this policy, Edge Website Typo Protection is turned on but users can choose whether to use Edge Website Typo Protection.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: TyposquattingCheckerEnabled
- GP name: Configure Edge Website Typo Protection
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Edge Website Typo Protection settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Edge Website Typo Protection settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: TyposquattingCheckerEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: TyposquattingCheckerEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: TyposquattingCheckerEnabled
- Example value:

```
true
```