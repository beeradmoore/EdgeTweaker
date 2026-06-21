---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewPDFReaderEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newpdfreaderenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Microsoft Edge built-in PDF reader powered by Adobe Acrobat enabled'
locale: en-us
document_id: 723112f2-72c5-8016-7eaf-ed6a8573a71d
document_version_independent_id: 723112f2-72c5-8016-7eaf-ed6a8573a71d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewPDFReaderEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NewPDFReaderEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 240
asset_id: microsoft-edge-policies/newpdfreaderenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewPDFReaderEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2bd11e47-b123-68e4-fa57-a7a3d4e75178
---

# Microsoft Edge Browser Policy Documentation NewPDFReaderEnabled | Microsoft Learn

## Microsoft Edge built-in PDF reader powered by Adobe Acrobat enabled

## Supported versions

- Windows: ≥ 111
- macOS: ≥ 111
- Android: Not supported
- iOS: Not supported

## Description

The policy lets Microsoft Edge launch the new version of the built-in PDF reader that's powered by Adobe Acrobat's PDF rendering engine. The new PDF reader ensures that there's no loss of functionality and delivers an enhanced PDF experience. This experience includes richer rendering, improved performance, strong security for PDF handling, and greater accessibility.

If you enable this policy, Microsoft Edge will use the new Adobe Acrobat powered built-in PDF reader to open all PDF files.

If you disable or don't configure this policy, Microsoft Edge will use the existing PDF reader to open all PDF files.

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

- GP unique name: NewPDFReaderEnabled
- GP name: Microsoft Edge built-in PDF reader powered by Adobe Acrobat enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NewPDFReaderEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: NewPDFReaderEnabled
- Example value:

```xml
<true/>
```