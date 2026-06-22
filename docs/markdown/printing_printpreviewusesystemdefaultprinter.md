---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintPreviewUseSystemDefaultPrinter | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printpreviewusesystemdefaultprinter
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the system default printer as the default printer'
locale: en-us
document_id: 27d3a6de-ba6c-4c39-9ecd-3b4e6614188a
document_version_independent_id: 27d3a6de-ba6c-4c39-9ecd-3b4e6614188a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintPreviewUseSystemDefaultPrinter.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/PrintPreviewUseSystemDefaultPrinter.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 204
asset_id: microsoft-edge-policies/printpreviewusesystemdefaultprinter
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintPreviewUseSystemDefaultPrinter.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 21c4989f-3f89-a94b-70cc-7b4a2765b06f
---

# Microsoft Edge Browser Policy Documentation PrintPreviewUseSystemDefaultPrinter | Microsoft Learn

## Set the system default printer as the default printer

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Tells Microsoft Edge to use the system default printer as the default choice in Print Preview instead of the most recently used printer.

If you disable this policy or don't configure it, Print Preview uses the most recently used printer as the default destination choice.

If you enable this policy, Print Preview uses the OS system default printer as the default destination choice.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintPreviewUseSystemDefaultPrinter
- GP name: Set the system default printer as the default printer
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Printing
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: PrintPreviewUseSystemDefaultPrinter
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: PrintPreviewUseSystemDefaultPrinter
- Example value:

```xml
<false/>
```