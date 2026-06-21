---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AdsTransparencyEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/adstransparencyenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure if the ads transparency feature is enabled'
locale: en-us
document_id: 538698c4-1c3b-f5eb-50f2-9153568887d6
document_version_independent_id: 538698c4-1c3b-f5eb-50f2-9153568887d6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AdsTransparencyEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AdsTransparencyEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 248
asset_id: microsoft-edge-policies/adstransparencyenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AdsTransparencyEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0bed5f01-72d2-0609-56a1-dfda6f631091
---

# Microsoft Edge Browser Policy Documentation AdsTransparencyEnabled | Microsoft Learn

## Configure if the ads transparency feature is enabled

## Supported versions

- Windows: ≥ 100
- macOS: ≥ 100
- Android: Not supported
- iOS: Not supported

## Description

Lets you decide whether the ads transparency feature is enabled. This behavior only applies to the "balanced" mode of tracking prevention, and doesn't impact "basic" or "strict" modes. Your users' tracking prevention level can be configured using the [TrackingPrevention](trackingprevention) policy. AdsTransparencyEnabled will only have an effect if [TrackingPrevention](trackingprevention) is set to TrackingPreventionBalanced or isn't configured.

If you enable or don't configure this policy, transparency metadata provided by ads are available to the user when the feature is active.

When the feature is enabled, Tracking Prevention enables exceptions for the associated ad providers that have met Microsoft's privacy standards.

If you disable this policy, Tracking Prevention won't adjust its behavior even when transparency metadata is provided by ads.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AdsTransparencyEnabled
- GP name: Configure if the ads transparency feature is enabled
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
- Value name: AdsTransparencyEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AdsTransparencyEnabled
- Example value:

```xml
<true/>
```