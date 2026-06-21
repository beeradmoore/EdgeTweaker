---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation IdleTimeout | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/idletimeout
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Delay before running idle actions'
locale: en-us
document_id: abca04b1-f4e5-6b69-7c5b-d5beb52496b7
document_version_independent_id: abca04b1-f4e5-6b69-7c5b-d5beb52496b7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/IdleTimeout.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/IdleTimeout.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/idletimeout
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/IdleTimeout.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 49ad65b9-efd1-8b08-5c0f-77615d4b5400
---

# Microsoft Edge Browser Policy Documentation IdleTimeout | Microsoft Learn

## Delay before running idle actions

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: ≥ 122
- iOS: ≥ 122

## Description

Triggers an action when the computer is idle.

If you set this policy, it specifies the length of time without user input (in minutes) before the browser runs actions configured via the IdleTimeoutActions policy.

If you don't set this policy, the browser doesn't run any action.

The minimum threshold is 1 minute.

"User input" is defined by Operating System APIs, and includes things like moving the mouse or typing on the keyboard.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: IdleTimeout
- GP name: Delay before running idle actions
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Idle Browser Actions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
30
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: IdleTimeout
- Value type: REG\_DWORD

#### Example registry value

```
0x0000001e
```

## Mac information and settings

- Preference Key name: IdleTimeout
- Example value:

```xml
<integer>30</integer>
```

## Android information and settings

- Preference Key name: IdleTimeout
- Example value:

```
30
```

## iOS information and settings

- Preference Key name: IdleTimeout
- Example value:

```xml
<integer>30</integer>
```