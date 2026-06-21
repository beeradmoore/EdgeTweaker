---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MouseGestureEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/mousegestureenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Mouse Gesture Enabled'
locale: en-us
document_id: eedb5c66-93d8-f1da-cb46-242ebcf809bf
document_version_independent_id: eedb5c66-93d8-f1da-cb46-242ebcf809bf
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MouseGestureEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/MouseGestureEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 211
asset_id: microsoft-edge-policies/mousegestureenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MouseGestureEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d30be5a4-eca2-9a81-7e1f-af4c58ac0809
---

# Microsoft Edge Browser Policy Documentation MouseGestureEnabled | Microsoft Learn

## Mouse Gesture Enabled

## Supported versions

- Windows: ≥ 112
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you configure the Mouse Gesture feature in Microsoft Edge.

This feature provides an easy way for users to complete tasks like scroll forward or backward, open new tab, refresh page, etc. They can finish a task by pressing and holding the mouse right button to draw certain patterns on a webpage, instead of clicking the buttons or using keyboard shortcuts.

If you enable or don't configure this policy, you can use the Mouse Gesture feature on Microsoft Edge to start using this feature.

If you disable this policy, you can't use the Mouse Gesture feature in Microsoft Edge.

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

- GP unique name: MouseGestureEnabled
- GP name: Mouse Gesture Enabled
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
- Value name: MouseGestureEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```