---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RelaunchFastIfOutdated | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/relaunchfastifoutdated
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Relaunch browser quickly when the current version is outdated'
locale: en-us
document_id: 51c0ea7d-10fe-7e69-a021-acd0037a942b
document_version_independent_id: 51c0ea7d-10fe-7e69-a021-acd0037a942b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RelaunchFastIfOutdated.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RelaunchFastIfOutdated.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 239
asset_id: microsoft-edge-policies/relaunchfastifoutdated
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RelaunchFastIfOutdated.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c6d02b79-0702-e454-737b-1d5756c85e61
---

# Microsoft Edge Browser Policy Documentation RelaunchFastIfOutdated | Microsoft Learn

## Relaunch browser quickly when the current version is outdated

## Supported versions

- Windows: ≥ 141
- macOS: ≥ 141
- Android: Not supported
- iOS: Not supported

## Description

This policy specifies the minimum release age after which relaunch notifications become more aggressive. The release age is calculated from the time the currently running version was last served to clients.

If a browser relaunch is needed to finalize a pending update and the current version is outdated for more than the number of days specified by this setting, the RelaunchNotificationPeriod policy is overridden to 2 hours. If the RelaunchNotification policy is set to 1 ('Required'), a browser relaunch is forced at the end of the period.

If not set, or if the release age can't be determined, the RelaunchNotificationPeriod policy is used for all updates.

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

- GP unique name: RelaunchFastIfOutdated
- GP name: Relaunch browser quickly when the current version is outdated
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
7
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RelaunchFastIfOutdated
- Value type: REG\_DWORD

#### Example registry value

```
0x00000007
```

## Mac information and settings

- Preference Key name: RelaunchFastIfOutdated
- Example value:

```xml
<integer>7</integer>
```