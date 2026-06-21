---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EfficiencyMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/efficiencymode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure when energy saver (previously named efficiency mode) should become active'
locale: en-us
document_id: 7625ca35-b32a-baac-6ce2-d9d5c27b2265
document_version_independent_id: 7625ca35-b32a-baac-6ce2-d9d5c27b2265
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EfficiencyMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EfficiencyMode.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 685
asset_id: microsoft-edge-policies/efficiencymode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EfficiencyMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 7fecf96e-8349-6263-8182-f365a1b2d432
---

# Microsoft Edge Browser Policy Documentation EfficiencyMode | Microsoft Learn

## Configure when energy saver (previously named efficiency mode) should become active

## Supported versions

- Windows: ≥ 96
- macOS: ≥ 96
- Android: Not supported
- iOS: Not supported

## Description

This policy setting lets you configure when energy saver becomes active. By default, energy saver is set to 'BalancedSavings'. On devices with no battery, energy saver is disabled by default and does not become active. Please note that Windows Energy Saver settings can influence when energy saver becomes active on all devices.

Individual sites may be blocked from participating in energy saver by configuring the policy [SleepingTabsBlockedForUrls](sleepingtabsblockedforurls).

Set this policy to 'AlwaysActive' and energy saver is always active.

Set this policy to 'NeverActive' and energy saver never becomes active.

Set this policy to 'ActiveWhenUnplugged' and energy saver becomes active when the device is unplugged.

Set this policy to 'ActiveWhenUnpluggedBatteryLow' and energy saver becomes active when the device is unplugged and the battery is low.

Set this policy to 'BalancedSavings' and when the device is unplugged, energy saver takes moderate steps to save battery. When the device is unplugged and the battery is low, energy saver takes extra steps to save battery.

Set this policy to 'MaximumSavings' and when the device is unplugged or unplugged and the battery is low, energy saver takes extra steps to save battery.

If the device does not have a battery, energy saver never becomes active in any mode other than 'AlwaysActive' unless the setting or [EfficiencyModeEnabled](efficiencymodeenabled) policy is enabled.

This policy has no effect if the [EfficiencyModeEnabled](efficiencymodeenabled) policy is disabled.

Learn more about energy saver: https://go.microsoft.com/fwlink/?linkid=2173921

Learn more about energy saver: [Energy Saver](/en-us/windows-hardware/design/component-guidelines/energy-saver)

Policy options mapping:

- AlwaysActive (0) = Energy saver is always active
- NeverActive (1) = Energy saver is never active
- ActiveWhenUnplugged (2) = Energy saver is active when the device is unplugged
- ActiveWhenUnpluggedBatteryLow (3) = Energy saver is active when the device is unplugged and the battery is low
- BalancedSavings (4) = When the device is unplugged, energy saver takes moderate steps to save battery. When the device is unplugged and the battery is low, energy saver takes extra steps to save battery.
- MaximumSavings (5) = When the device is unplugged or unplugged and the battery is low, energy saver takes extra steps to save battery.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AlwaysActive (0) = Energy saver is always active
    - Windows: 96-109
    - macOS: 96-109
    - Android: Not supported
    - iOS: Not supported
- NeverActive (1) = Energy saver is never active
    - Windows: 96-109
    - macOS: 96-109
    - Android: Not supported
    - iOS: Not supported
- ActiveWhenUnplugged (2) = Energy saver is active when the device is unplugged
    - Windows: 96-109
    - macOS: 96-109
    - Android: Not supported
    - iOS: Not supported
- ActiveWhenUnpluggedBatteryLow (3) = Energy saver is active when the device is unplugged and the battery is low
    - Windows: 96-109
    - macOS: 96-109
    - Android: Not supported
    - iOS: Not supported
- BalancedSavings (4) = When the device is unplugged, energy saver takes moderate steps to save battery. When the device is unplugged and the battery is low, energy saver takes extra steps to save battery.
    - Windows: ≥ 106
    - macOS: ≥ 106
    - Android: Not supported
    - iOS: Not supported
- MaximumSavings (5) = When the device is unplugged or unplugged and the battery is low, energy saver takes extra steps to save battery.
    - Windows: ≥ 106
    - macOS: ≥ 106
    - Android: Not supported
    - iOS: Not supported

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EfficiencyMode
- GP name: Configure when energy saver (previously named efficiency mode) should become active
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Performance
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Performance
- GP ADMX file name: MSEdge.admx

#### Example value

```
Energy saver is active when the device is unplugged and the battery is low
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: EfficiencyMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000003
```

## Mac information and settings

- Preference Key name: EfficiencyMode
- Example value:

```xml
<integer>3</integer>
```