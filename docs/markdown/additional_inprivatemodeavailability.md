---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InPrivateModeAvailability | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/inprivatemodeavailability
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure InPrivate mode availability'
locale: en-us
document_id: 222f75b6-e108-8d26-e198-221bc8f38700
document_version_independent_id: 222f75b6-e108-8d26-e198-221bc8f38700
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InPrivateModeAvailability.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InPrivateModeAvailability.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 321
asset_id: microsoft-edge-policies/inprivatemodeavailability
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InPrivateModeAvailability.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b4c7bddc-89ae-a403-6e1e-32de0ddbd746
---

# Microsoft Edge Browser Policy Documentation InPrivateModeAvailability | Microsoft Learn

## Configure InPrivate mode availability

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 90

## Description

Specifies whether the user can open pages in InPrivate mode in Microsoft Edge.

If you don't configure this policy or set it to 'Enabled', users can open pages in InPrivate mode.

Set this policy to 'Disabled' to stop users from using InPrivate mode.

Set this policy to 'Forced' to always use InPrivate mode.

The [InPrivateModeUrlAllowlist](inprivatemodeurlallowlist) policy takes precedence over this policy and can allow specific URLs to open in InPrivate mode.

If this policy disables InPrivate mode and an allowlist is configured, InPrivate mode is permitted only for URLs that match entries in the allowlist. All other URLs are blocked from opening in InPrivate mode.

Policy options mapping:

- Enabled (0) = InPrivate mode available
- Disabled (1) = InPrivate mode disabled
- Forced (2) = InPrivate mode forced

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Enabled (0) = InPrivate mode available
- Disabled (1) = InPrivate mode disabled
- Forced (2) = InPrivate mode forced
    - Windows: Not supported
    - macOS: Not supported
    - Android: ≥ 116
    - iOS: ≥ 116

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InPrivateModeAvailability
- GP name: Configure InPrivate mode availability
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
InPrivate mode disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InPrivateModeAvailability
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: InPrivateModeAvailability
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: InPrivateModeAvailability
- Example value:

```
1
```

## iOS information and settings

- Preference Key name: InPrivateModeAvailability
- Example value:

```xml
<integer>1</integer>
```