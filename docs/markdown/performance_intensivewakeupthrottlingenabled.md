---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation IntensiveWakeUpThrottlingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/intensivewakeupthrottlingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the IntensiveWakeUpThrottling feature'
locale: en-us
document_id: 5383cff5-3112-1e55-140b-a8bc76335779
document_version_independent_id: 5383cff5-3112-1e55-140b-a8bc76335779
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/IntensiveWakeUpThrottlingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/IntensiveWakeUpThrottlingEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 318
asset_id: microsoft-edge-policies/intensivewakeupthrottlingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/IntensiveWakeUpThrottlingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 22839f50-0ba4-d500-7bb2-f3b968039a4d
---

# Microsoft Edge Browser Policy Documentation IntensiveWakeUpThrottlingEnabled | Microsoft Learn

## Control the IntensiveWakeUpThrottling feature

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 85
- Android: ≥ 147
- iOS: Not supported

## Description

When enabled, the IntensiveWakeUpThrottling feature causes Javascript timers in background tabs to be aggressively throttled and coalesced, running no more than once per minute after a page was backgrounded for 5 minutes or more.

This feature is a web standards compliant feature, but it may break functionality on some websites by causing certain actions to be delayed by up to a minute. However, it results in significant CPU and battery savings when enabled. For more information, see https://bit.ly/30b1XR4.

If you enable this policy, the feature is force enabled, and users can't override this setting. If you disable this policy, the feature is force disabled, and users can't override this setting. If you don't configure this policy, the feature is controlled by its own internal logic. Users can manually configure this setting.

The policy is applied per renderer process, with the most recent value of the policy setting in force when a renderer process starts. A full restart is required to ensure that all the loaded tabs receive a consistent policy setting. It's harmless for processes to be running with different values of this policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: IntensiveWakeUpThrottlingEnabled
- GP name: Control the IntensiveWakeUpThrottling feature
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
- Value name: IntensiveWakeUpThrottlingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: IntensiveWakeUpThrottlingEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: IntensiveWakeUpThrottlingEnabled
- Example value:

```
true
```