---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ViewXFAPDFInIEModeAllowedFileHash | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/viewxfapdfiniemodeallowedfilehash
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: View XFA-based PDF files using IE Mode for allowed file hash.'
locale: en-us
document_id: e1a1945f-334a-fa36-790b-0a3f4d9b68c5
document_version_independent_id: e1a1945f-334a-fa36-790b-0a3f4d9b68c5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ViewXFAPDFInIEModeAllowedFileHash.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ViewXFAPDFInIEModeAllowedFileHash.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 249
asset_id: microsoft-edge-policies/viewxfapdfiniemodeallowedfilehash
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ViewXFAPDFInIEModeAllowedFileHash.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 225f6f33-e2d9-e76d-857c-fa7272f6600b
---

# Microsoft Edge Browser Policy Documentation ViewXFAPDFInIEModeAllowedFileHash | Microsoft Learn

## View XFA-based PDF files using IE Mode for allowed file hash.

## Supported versions

- Windows: ≥ 132
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

XFA is a legacy technology that's deprecated by its original creators. It's not an ISO standard and as such, it doesn't align with the modern web architecture. Continued use poses potential risks and vulnerabilities. For more information, see [ViewXFAPDFInIEModeAllowedOrigins](viewxfapdfiniemodeallowedorigins).

If you enable this policy, you can configure the list of base64 encoded SHA256 file hashes for which XFA PDF files automatically open in Microsoft Edge using IE Mode.

If you disable or don't configure this policy, XFA PDFs won't be considered for opening via IE mode except the files from file origin mentioned in Policy [ViewXFAPDFInIEModeAllowedOrigins](viewxfapdfiniemodeallowedorigins)

For more information, see - [Get-FileHash](https://go.microsoft.com/fwlink/?linkid=2294823), [Dot Net Convert API](https://go.microsoft.com/fwlink/?linkid=2294913).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ViewXFAPDFInIEModeAllowedFileHash
- GP name: View XFA-based PDF files using IE Mode for allowed file hash.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/PDF Reader
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
pZGm1Av0IEBKARczz7exkNYsZb8LzaMrV7J32a2fFG4=
```

```
nFeL0Q+9HX7WFI3RsmSDFTlUtrbclXH67MTdXDwWuu4=
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedFileHash
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedFileHash\1 =

```
pZGm1Av0IEBKARczz7exkNYsZb8LzaMrV7J32a2fFG4=
```

SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedFileHash\2 =

```
nFeL0Q+9HX7WFI3RsmSDFTlUtrbclXH67MTdXDwWuu4=
```