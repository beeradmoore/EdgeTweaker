---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NetworkPredictionOptions | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/networkpredictionoptions
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable network prediction'
locale: en-us
document_id: eaa72e38-4c3d-d5f8-dd45-ebb0b2e9b138
document_version_independent_id: eaa72e38-4c3d-d5f8-dd45-ebb0b2e9b138
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NetworkPredictionOptions.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NetworkPredictionOptions.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 301
asset_id: microsoft-edge-policies/networkpredictionoptions
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NetworkPredictionOptions.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 842819dc-f8cb-4141-85f0-425fb467666f
---

# Microsoft Edge Browser Policy Documentation NetworkPredictionOptions | Microsoft Learn

## Enable network prediction

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 38
- iOS: Not supported

## Description

Enables network prediction and prevents users from changing this setting.

This controls DNS prefetching, TCP and SSL preconnection, and prerendering of web pages.

If you don't configure this policy, network prediction is enabled but the user can change it.

Policy options mapping:

- NetworkPredictionAlways (0) = Predict network actions on any network connection
- NetworkPredictionWifiOnly (1) = Not supported, if this value is used it will be treated as if 'Predict network actions on any network connection' (0) was set
- NetworkPredictionNever (2) = Don't predict network actions on any network connection

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- NetworkPredictionAlways (0) = Predict network actions on any network connection
- NetworkPredictionWifiOnly (1) = Not supported, if this value is used it will be treated as if 'Predict network actions on any network connection' (0) was set
- NetworkPredictionNever (2) = Don't predict network actions on any network connection

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NetworkPredictionOptions
- GP name: Enable network prediction
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Don't predict network actions on any network connection
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NetworkPredictionOptions
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: NetworkPredictionOptions
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: NetworkPredictionOptions
- Example value:

```
2
```