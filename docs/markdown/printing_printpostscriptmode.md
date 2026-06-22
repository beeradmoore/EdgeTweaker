---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintPostScriptMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printpostscriptmode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Print PostScript Mode'
locale: en-us
document_id: f025b6cd-c85a-20c8-b651-8de873bac221
document_version_independent_id: f025b6cd-c85a-20c8-b651-8de873bac221
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintPostScriptMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/PrintPostScriptMode.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 237
asset_id: microsoft-edge-policies/printpostscriptmode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintPostScriptMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 09c9c1fb-4f64-d7a7-f3f4-2ad5a9632c70
---

# Microsoft Edge Browser Policy Documentation PrintPostScriptMode | Microsoft Learn

## Print PostScript Mode

## Supported versions

- Windows: ≥ 96
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Controls how Microsoft Edge prints on Microsoft Windows.

Printing to a PostScript printer on Microsoft Windows different PostScript generation methods can affect printing performance.

If you set this policy to Default, Microsoft Edge uses a set of default options when generating PostScript. Text in particular, is always rendered using Type 3 fonts.

If you set this policy to Type42, Microsoft Edge renders text using Type 42 fonts if possible. This should increase printing speed for some PostScript printers.

If you don't configure this policy, Microsoft Edge remains in Default mode.

Policy options mapping:

- Default (0) = Default
- Type42 (1) = Type42

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Default
- Type42 (1) = Type42

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

- GP unique name: PrintPostScriptMode
- GP name: Print PostScript Mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Type42
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrintPostScriptMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```