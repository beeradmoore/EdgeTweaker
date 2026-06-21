---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EfficiencyModeOnPowerEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/efficiencymodeonpowerenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable efficiency mode when the device is connected to a power source'
locale: en-us
document_id: d4e45e97-2aca-87bd-758e-7a8d8825e9de
document_version_independent_id: d4e45e97-2aca-87bd-758e-7a8d8825e9de
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EfficiencyModeOnPowerEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EfficiencyModeOnPowerEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 231
asset_id: microsoft-edge-policies/efficiencymodeonpowerenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EfficiencyModeOnPowerEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 06bc8120-c1bb-6368-337e-ac73d04cd015
---

# Microsoft Edge Browser Policy Documentation EfficiencyModeOnPowerEnabled | Microsoft Learn

## Enable efficiency mode when the device is connected to a power source

## Supported versions

- Windows: ≥ 106
- macOS: ≥ 106
- Android: Not supported
- iOS: Not supported

## Description

Allows efficiency mode to become active when the device is connected to a power source. On devices with no battery, this policy has no effect.

If you enable this policy, efficiency mode will become active when the device is connected to a power source.

If you disable or don't configure this policy, efficiency mode will never become active when the device is connected to a power source.

This policy has no effect if the [EfficiencyModeEnabled](efficiencymodeenabled) policy is disabled.

Learn more about efficiency mode: https://go.microsoft.com/fwlink/?linkid=2173921

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

- GP unique name: EfficiencyModeOnPowerEnabled
- GP name: Enable efficiency mode when the device is connected to a power source
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Performance
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Performance
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: EfficiencyModeOnPowerEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EfficiencyModeOnPowerEnabled
- Example value:

```xml
<true/>
```