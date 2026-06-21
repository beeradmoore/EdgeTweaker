---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EfficiencyModeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/efficiencymodeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Efficiency mode enabled'
locale: en-us
document_id: b1457d6c-f554-5eda-3903-e06ecbc535e7
document_version_independent_id: b1457d6c-f554-5eda-3903-e06ecbc535e7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EfficiencyModeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EfficiencyModeEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 251
asset_id: microsoft-edge-policies/efficiencymodeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EfficiencyModeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7d202120-19bc-fe4b-7a77-635db26149c2
---

# Microsoft Edge Browser Policy Documentation EfficiencyModeEnabled | Microsoft Learn

## Efficiency mode enabled

## Supported versions

- Windows: ≥ 106
- macOS: ≥ 106
- Android: Not supported
- iOS: Not supported

## Description

Enables efficiency mode which helps extend battery life by saving computer resources. By default, efficiency mode is enabled for devices with a battery and is disabled otherwise.

If you enable this policy, efficiency mode becomes active according to the setting chosen by the user. You can configure the efficiency mode setting using the [EfficiencyMode](efficiencymode) policy. If the device doesn't have a battery, efficiency mode is always active.

If you disable this policy, efficiency mode is never active. The [EfficiencyMode](efficiencymode) and [EfficiencyModeOnPowerEnabled](efficiencymodeonpowerenabled) policies will have no effect.

If you don't configure this policy, efficiency mode will be enabled for devices with a battery and disabled otherwise. Users can choose the efficiency mode option they want in edge://settings/system.

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

- GP unique name: EfficiencyModeEnabled
- GP name: Efficiency mode enabled
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
- Value name: EfficiencyModeEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EfficiencyModeEnabled
- Example value:

```xml
<true/>
```