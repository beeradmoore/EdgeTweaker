---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoDiscardSleepingTabsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autodiscardsleepingtabsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure auto discard sleeping tabs'
locale: en-us
document_id: 200a660c-32cd-76c9-6195-68f6da308ee0
document_version_independent_id: 200a660c-32cd-76c9-6195-68f6da308ee0
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoDiscardSleepingTabsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/AutoDiscardSleepingTabsEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 238
asset_id: microsoft-edge-policies/autodiscardsleepingtabsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoDiscardSleepingTabsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0ad6df64-2795-bc36-9651-913d35f7c1ab
---

# Microsoft Edge Browser Policy Documentation AutoDiscardSleepingTabsEnabled | Microsoft Learn

## Configure auto discard sleeping tabs

## Supported versions

- Windows: ≥ 120
- macOS: ≥ 120
- Android: Not supported
- iOS: Not supported

## Description

Setting this policy enables inactive (sleeping) tabs to be automatically discarded after 1.5 days of inactivity. This is done to save memory. When the user switches back to a discarded tab, the tab needs to be reloaded.

If the [SleepingTabsEnabled](sleepingtabsenabled) policy is enabled, then this feature is enabled by default.

If the [SleepingTabsEnabled](sleepingtabsenabled) is disabled, then this feature is disabled by default and can't be enabled.

If enabled, idle background tabs will be discarded after 1.5 days.

If disabled, idle background tab won't be discarded after 1.5 days. Tabs can still be discarded for other reasons if this policy is disabled.

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

- GP unique name: AutoDiscardSleepingTabsEnabled
- GP name: Configure auto discard sleeping tabs
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Sleeping tabs settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Sleeping tabs settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AutoDiscardSleepingTabsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AutoDiscardSleepingTabsEnabled
- Example value:

```xml
<true/>
```