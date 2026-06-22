---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RelaunchWindow | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/relaunchwindow
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the time interval for relaunch'
locale: en-us
document_id: 413d9efb-bb73-8566-f68c-9e5a800ba00f
document_version_independent_id: 413d9efb-bb73-8566-f68c-9e5a800ba00f
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RelaunchWindow.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/RelaunchWindow.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 306
asset_id: microsoft-edge-policies/relaunchwindow
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RelaunchWindow.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 3e3f320b-e4fe-4dd9-37ef-05d818062ecb
---

# Microsoft Edge Browser Policy Documentation RelaunchWindow | Microsoft Learn

## Set the time interval for relaunch

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

Specifies a target time window for the end of the relaunch notification period.

Users are notified of the need for a browser relaunch or device restart based on the [RelaunchNotification](relaunchnotification) and [RelaunchNotificationPeriod](relaunchnotificationperiod) policy settings. Browsers and devices are forcibly restarted at the end of the notification period when the [RelaunchNotification](relaunchnotification) policy is set to Required. This RelaunchWindow policy can be used to defer the end of the notification period so that it falls within a specific time window.

If you don't configure this policy, the default target time window is the whole day (that is, the end of the notification period is never deferred).

Note: Though the policy can accept multiple items in entries, all items except the first are ignored. Warning: Setting this policy can delay application of software updates.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RelaunchWindow
- GP name: Set the time interval for relaunch
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"entries": [{"duration_mins": 240, "start": {"hour": 2, "minute": 15}}]}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RelaunchWindow
- Value type: REG\_SZ

#### Example registry value

```
{"entries": [{"duration_mins": 240, "start": {"hour": 2, "minute": 15}}]}
```

#### Expanded example registry value

```
{
  "entries": [
    {
      "duration_mins": 240,
      "start": {
        "hour": 2,
        "minute": 15
      }
    }
  ]
}
```

## Mac information and settings

- Preference Key name: RelaunchWindow
- Example value:

```xml
<key>RelaunchWindow</key>
<dict>
  <key>entries</key>
  <array>
    <dict>
      <key>duration_mins</key>
      <integer>240</integer>
      <key>start</key>
      <dict>
        <key>hour</key>
        <integer>2</integer>
        <key>minute</key>
        <integer>15</integer>
      </dict>
    </dict>
  </array>
</dict>
```