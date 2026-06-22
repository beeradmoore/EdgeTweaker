---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShadowStackCrashRollbackBehavior | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/shadowstackcrashrollbackbehavior
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure ShadowStack crash rollback behavior (obsolete)'
locale: en-us
document_id: 6c79ea0c-db9e-41e3-41a6-9a8d794b2bff
document_version_independent_id: 6c79ea0c-db9e-41e3-41a6-9a8d794b2bff
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShadowStackCrashRollbackBehavior.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/ShadowStackCrashRollbackBehavior.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 337
asset_id: microsoft-edge-policies/shadowstackcrashrollbackbehavior
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShadowStackCrashRollbackBehavior.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ea54f76b-d32b-6462-3683-c1482d95b863
---

# Microsoft Edge Browser Policy Documentation ShadowStackCrashRollbackBehavior | Microsoft Learn

## Configure ShadowStack crash rollback behavior (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 109.

## Supported versions

- Windows: 95-109
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy is deprecated as it served only as a short-term mechanism to give enterprises more time to update their environments and report issues if they're found to be incompatible with Hardware-enforced Stack Protection. It doesn't work in Microsoft Edge starting with version 109.

Microsoft Edge includes a Hardware-enforced Stack Protection security feature. This feature can result in the browser crashing unexpectedly in cases that don't represent an attempt to compromise the browser's security.

Using this policy, you can control the behavior of the Hardware-enforced Stack Protection feature after a crash triggered by this feature is encountered.

Set this policy to 'Disable' to disable the feature.

Set this policy to 'DisableUntilUpdate' to disable the feature until Microsoft Edge updates next time.

Set this policy to 'Enable' to keep the feature enabled.

Policy options mapping:

- Disable (0) = Disable Hardware-enforced Stack Protection
- DisableUntilUpdate (1) = Disable Hardware-enforced Stack Protection until the next Microsoft Edge update
- Enable (2) = Enable Hardware-enforced Stack Protection

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Disable (0) = Disable Hardware-enforced Stack Protection
- DisableUntilUpdate (1) = Disable Hardware-enforced Stack Protection until the next Microsoft Edge update
- Enable (2) = Enable Hardware-enforced Stack Protection

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

- GP unique name: ShadowStackCrashRollbackBehavior
- GP name: Configure ShadowStack crash rollback behavior (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disable Hardware-enforced Stack Protection
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ShadowStackCrashRollbackBehavior
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```