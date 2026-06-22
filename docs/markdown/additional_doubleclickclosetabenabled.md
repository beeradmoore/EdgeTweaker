---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DoubleClickCloseTabEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/doubleclickclosetabenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Double Click feature in Microsoft Edge enabled (only available in China)'
locale: en-us
document_id: 5b9e840d-1a58-039f-9aaf-415e11e9cf5c
document_version_independent_id: 5b9e840d-1a58-039f-9aaf-415e11e9cf5c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DoubleClickCloseTabEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/DoubleClickCloseTabEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 205
asset_id: microsoft-edge-policies/doubleclickclosetabenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DoubleClickCloseTabEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 70886cae-35b2-16f2-05b5-a65a0bb3e57a
---

# Microsoft Edge Browser Policy Documentation DoubleClickCloseTabEnabled | Microsoft Learn

## Double Click feature in Microsoft Edge enabled (only available in China)

## Supported versions

- Windows: ≥ 104
- macOS: ≥ 104
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you configure the double click feature in Microsoft Edge.

Double Click lets users close a tab by double clicking the left mouse button.

If you enable or don't configure this policy, you can use the double click feature to close a tab on Microsoft Edge to start using this feature.

If you disable this policy, you can't use the double click feature in Microsoft Edge.

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

- GP unique name: DoubleClickCloseTabEnabled
- GP name: Double Click feature in Microsoft Edge enabled (only available in China)
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
- Value name: DoubleClickCloseTabEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DoubleClickCloseTabEnabled
- Example value:

```xml
<true/>
```