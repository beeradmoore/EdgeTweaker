---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SleepingTabsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sleepingtabsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure sleeping tabs'
locale: en-us
document_id: 4daa653f-8bea-58f0-cb8c-82cbe3fa522c
document_version_independent_id: 4daa653f-8bea-58f0-cb8c-82cbe3fa522c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SleepingTabsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/SleepingTabsEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 256
asset_id: microsoft-edge-policies/sleepingtabsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SleepingTabsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d5ba1b06-e61d-16d3-0936-dd1172560ad6
---

# Microsoft Edge Browser Policy Documentation SleepingTabsEnabled | Microsoft Learn

## Configure sleeping tabs

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

This policy setting lets you configure whether to turn on sleeping tabs. Sleeping tabs reduces CPU, battery, and memory usage by putting idle background tabs to sleep. Microsoft Edge uses heuristics to avoid putting tabs to sleep that do useful work in the background, such as display notifications, play sound, and stream video. By default, sleeping tabs is turned on.

Individual sites may be blocked from being put to sleep by configuring the policy [SleepingTabsBlockedForUrls](sleepingtabsblockedforurls).

If this policy is enabled, sleeping tabs are turned on.

If this policy is disabled, sleeping tabs are turned off. However, during moderate memory pressure, the system may freeze (sleep) tabs before discarding them.

If this policy is not configured, users can choose whether to enable sleeping tabs.

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

- GP unique name: SleepingTabsEnabled
- GP name: Configure sleeping tabs
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
- Value name: SleepingTabsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SleepingTabsEnabled
- Example value:

```xml
<true/>
```