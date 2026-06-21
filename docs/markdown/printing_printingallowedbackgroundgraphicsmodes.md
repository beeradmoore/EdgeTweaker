---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintingAllowedBackgroundGraphicsModes | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printingallowedbackgroundgraphicsmodes
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict background graphics printing mode'
locale: en-us
document_id: c45031ed-b2c9-951c-1198-e0889137e5b5
document_version_independent_id: c45031ed-b2c9-951c-1198-e0889137e5b5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintingAllowedBackgroundGraphicsModes.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PrintingAllowedBackgroundGraphicsModes.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/printingallowedbackgroundgraphicsmodes
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintingAllowedBackgroundGraphicsModes.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a5f62ebb-b033-a8fb-e8e9-7da98c42a988
---

# Microsoft Edge Browser Policy Documentation PrintingAllowedBackgroundGraphicsModes | Microsoft Learn

## Restrict background graphics printing mode

## Supported versions

- Windows: ≥ 89
- macOS: ≥ 89
- Android: Not supported
- iOS: Not supported

## Description

Restricts background graphics printing mode. If this policy isn't set there's no restriction on printing background graphics.

Policy options mapping:

- any (any) = Allow printing with and without background graphics
- enabled (enabled) = Allow printing only with background graphics
- disabled (disabled) = Allow printing only without background graphics

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- any = Allow printing with and without background graphics
- enabled = Allow printing only with background graphics
- disabled = Allow printing only without background graphics

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintingAllowedBackgroundGraphicsModes
- GP name: Restrict background graphics printing mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow printing only with background graphics
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrintingAllowedBackgroundGraphicsModes
- Value type: REG\_SZ

#### Example registry value

```
enabled
```

## Mac information and settings

- Preference Key name: PrintingAllowedBackgroundGraphicsModes
- Example value:

```xml
<string>enabled</string>
```