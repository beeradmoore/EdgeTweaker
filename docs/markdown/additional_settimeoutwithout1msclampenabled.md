---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SetTimeoutWithout1MsClampEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/settimeoutwithout1msclampenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control Javascript setTimeout() function minimum timeout (obsolete)'
locale: en-us
document_id: d5880ba3-a360-20b5-69f8-f0e9b0707459
document_version_independent_id: d5880ba3-a360-20b5-69f8-f0e9b0707459
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SetTimeoutWithout1MsClampEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/SetTimeoutWithout1MsClampEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 307
asset_id: microsoft-edge-policies/settimeoutwithout1msclampenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SetTimeoutWithout1MsClampEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/540ac133-a371-4dbb-8f94-28d6cc77a70b
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/60bfc045-f127-4841-9d00-ea35495a5800
platformId: e56a4447-5f0f-9917-4bfc-86c5489a98f6
---

# Microsoft Edge Browser Policy Documentation SetTimeoutWithout1MsClampEnabled | Microsoft Learn

## Control Javascript setTimeout() function minimum timeout (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 109.

## Supported versions

- Windows: 101-109
- macOS: 101-109
- Android: 101-109
- iOS: Not supported

## Description

This policy is obsolete and doesn't work in Microsoft Edge after version 109. This policy was only provided temporarily to allow Enterprises to adapt to the new clamping behavior.

If you enable this policy, the JavaScript setTimeout() with a timeout of 0 ms is no longer fixed to 1 ms to schedule timer-based callbacks. If you disable this policy, the JavaScript setTimeout() with a timeout of 0 ms is fixed to 1 ms to schedule timer-based callbacks. If you don't configure this policy, use the browser's default behavior for setTimeout() function.

This is a web standards compliancy feature; however, it may change task ordering on a webpage, leading to unexpected behavior on sites that are dependent on a certain ordering. It also affects sites with many setTimeout()s with a timeout of 0-ms usage, for example, increasing CPU load.

For users where this policy is unset, Microsoft Edge Stable rolls out the change gradually on the stable channel.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SetTimeoutWithout1MsClampEnabled
- GP name: Control Javascript setTimeout() function minimum timeout (obsolete)
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
- Value name: SetTimeoutWithout1MsClampEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SetTimeoutWithout1MsClampEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: SetTimeoutWithout1MsClampEnabled
- Example value:

```
true
```