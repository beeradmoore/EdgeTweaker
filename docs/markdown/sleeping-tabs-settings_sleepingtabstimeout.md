---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SleepingTabsTimeout | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sleepingtabstimeout
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the background tab inactivity timeout for sleeping tabs'
locale: en-us
document_id: 0aa128ac-4e52-10c0-cdb0-c6342453da17
document_version_independent_id: 0aa128ac-4e52-10c0-cdb0-c6342453da17
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SleepingTabsTimeout.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/SleepingTabsTimeout.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 378
asset_id: microsoft-edge-policies/sleepingtabstimeout
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SleepingTabsTimeout.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 15cf102a-c629-fa22-bbd4-7d2a5604d18a
---

# Microsoft Edge Browser Policy Documentation SleepingTabsTimeout | Microsoft Learn

## Set the background tab inactivity timeout for sleeping tabs

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

This policy setting lets you configure the timeout, in seconds, after which inactive background tabs are automatically put to sleep if sleeping tabs is enabled. By default, this timeout is 7,200 seconds (2 hours).

Tabs are only put to sleep automatically when the policy [SleepingTabsEnabled](sleepingtabsenabled) is enabled or isn't configured, and the user has enabled the sleeping tabs setting.

If you don't configure this policy, users can choose the timeout value.

Policy options mapping:

- 30Seconds (30) = 30 seconds of inactivity
- 5Minutes (300) = 5 minutes of inactivity
- 15Minutes (900) = 15 minutes of inactivity
- 30Minutes (1800) = 30 minutes of inactivity
- 1Hour (3600) = 1 hour of inactivity
- 2Hours (7200) = 2 hours of inactivity
- 3Hours (10800) = 3 hours of inactivity
- 6Hours (21600) = 6 hours of inactivity
- 12Hours (43200) = 12 hours of inactivity

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- 30Seconds (30) = 30 seconds of inactivity
    - Windows: ≥ 103
    - macOS: ≥ 103
    - Android: Not supported
    - iOS: Not supported
- 5Minutes (300) = 5 minutes of inactivity
- 15Minutes (900) = 15 minutes of inactivity
- 30Minutes (1800) = 30 minutes of inactivity
- 1Hour (3600) = 1 hour of inactivity
- 2Hours (7200) = 2 hours of inactivity
- 3Hours (10800) = 3 hours of inactivity
- 6Hours (21600) = 6 hours of inactivity
- 12Hours (43200) = 12 hours of inactivity

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

- GP unique name: SleepingTabsTimeout
- GP name: Set the background tab inactivity timeout for sleeping tabs
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Sleeping tabs settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Sleeping tabs settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
15 minutes of inactivity
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SleepingTabsTimeout
- Value type: REG\_DWORD

#### Example registry value

```
0x00000384
```

## Mac information and settings

- Preference Key name: SleepingTabsTimeout
- Example value:

```xml
<integer>900</integer>
```