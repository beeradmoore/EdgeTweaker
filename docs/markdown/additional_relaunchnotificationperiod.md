---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RelaunchNotificationPeriod | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/relaunchnotificationperiod
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the time period for update notifications'
locale: en-us
document_id: 4f7bb742-963b-61cd-59f7-d123e527b463
document_version_independent_id: 4f7bb742-963b-61cd-59f7-d123e527b463
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RelaunchNotificationPeriod.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RelaunchNotificationPeriod.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 237
asset_id: microsoft-edge-policies/relaunchnotificationperiod
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RelaunchNotificationPeriod.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 827e7b8f-a0f6-c51d-bc54-bbd22d55bff8
---

# Microsoft Edge Browser Policy Documentation RelaunchNotificationPeriod | Microsoft Learn

## Set the time period for update notifications

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Allows you to set the time period, in milliseconds, over which users are notified that Microsoft Edge must be relaunched to apply a pending update.

Over this time period, the user is repeatedly informed of the need for an update. In Microsoft Edge the app menu changes to indicate that a relaunch is needed once one third of the notification period passes. This notification changes color once two thirds of the notification period passes, and again once the full notification period is passed. The additional notifications enabled by the [RelaunchNotification](relaunchnotification) policy follow this same schedule.

If not set, the default period of 604800000 milliseconds (one week) is used.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RelaunchNotificationPeriod
- GP name: Set the time period for update notifications
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
604800000
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RelaunchNotificationPeriod
- Value type: REG\_DWORD

#### Example registry value

```
0x240c8400
```

## Mac information and settings

- Preference Key name: RelaunchNotificationPeriod
- Example value:

```xml
<integer>604800000</integer>
```