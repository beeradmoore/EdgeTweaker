---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PictureInPictureOverlayEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/pictureinpictureoverlayenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Picture in Picture overlay feature on supported webpages in Microsoft Edge'
locale: en-us
document_id: 989a8012-9d6d-f39a-f65a-2d61779c5301
document_version_independent_id: 989a8012-9d6d-f39a-f65a-2d61779c5301
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PictureInPictureOverlayEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PictureInPictureOverlayEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 225
asset_id: microsoft-edge-policies/pictureinpictureoverlayenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PictureInPictureOverlayEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2f2bad76-206a-4bf6-2542-88d3278caaa8
---

# Microsoft Edge Browser Policy Documentation PictureInPictureOverlayEnabled | Microsoft Learn

## Enable Picture in Picture overlay feature on supported webpages in Microsoft Edge

## Supported versions

- Windows: ≥ 118
- macOS: ≥ 118
- Android: Not supported
- iOS: ≥ 148

## Description

This policy lets you configure the Picture in Picture floating overlay button in Microsoft Edge.

The Picture in Picture floating overlay button lets the user watch videos in a floating window on top of other windows.

If you enable or don't configure this policy, you can use the Picture in Picture floating overlay button in Microsoft Edge.

If you disable this policy, you can't use the Picture in Picture floating overlay button in Microsoft Edge.

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

- GP unique name: PictureInPictureOverlayEnabled
- GP name: Enable Picture in Picture overlay feature on supported webpages in Microsoft Edge
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
- Value name: PictureInPictureOverlayEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PictureInPictureOverlayEnabled
- Example value:

```xml
<true/>
```

## iOS information and settings

- Preference Key name: PictureInPictureOverlayEnabled
- Example value:

```xml
<true/>
```