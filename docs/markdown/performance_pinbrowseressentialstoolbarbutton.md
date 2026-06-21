---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PinBrowserEssentialsToolbarButton | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/pinbrowseressentialstoolbarbutton
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Pin browser essentials toolbar button'
locale: en-us
document_id: 5bead062-baee-8def-4579-2a0f1f7ef80e
document_version_independent_id: 5bead062-baee-8def-4579-2a0f1f7ef80e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PinBrowserEssentialsToolbarButton.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PinBrowserEssentialsToolbarButton.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 234
asset_id: microsoft-edge-policies/pinbrowseressentialstoolbarbutton
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PinBrowserEssentialsToolbarButton.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 89503336-785a-d966-e45e-8dad363cc0ee
---

# Microsoft Edge Browser Policy Documentation PinBrowserEssentialsToolbarButton | Microsoft Learn

## Pin browser essentials toolbar button

## Supported versions

- Windows: ≥ 114
- macOS: ≥ 114
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you configure whether to pin the Browser essentials button on the toolbar.

When the button is pinned, it always appears on the toolbar.

When the button isn't pinned, it only appears when there's an alert. An example of this kind of alert is the performance detector alert that indicates the browser is using high CPU or memory.

If you enable or don't configure this policy, the Browser essentials button is pinned on the toolbar.

If you disable this policy, the Browser essentials button isn't pinned on the toolbar.

Learn more about browser essentials: https://go.microsoft.com/fwlink/?linkid=2240439

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PinBrowserEssentialsToolbarButton
- GP name: Pin browser essentials toolbar button
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Performance
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Performance
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: PinBrowserEssentialsToolbarButton
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PinBrowserEssentialsToolbarButton
- Example value:

```xml
<true/>
```