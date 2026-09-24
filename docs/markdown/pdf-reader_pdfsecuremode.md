---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PDFSecureMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/pdfsecuremode
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-09-11T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Secure mode and Certificate-based Digital Signature validation in native PDF reader'
locale: en-us
document_id: 6e9ec063-71c5-baa6-96f1-b28a5845eafd
document_version_independent_id: 6e9ec063-71c5-baa6-96f1-b28a5845eafd
updated_at: 2026-09-11T20:36:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PDFSecureMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/bad5d510d6c89974a30e53029e162d63c894b1ea/edgeenterprise/microsoft-edge-policies/PDFSecureMode.md
git_commit_id: bad5d510d6c89974a30e53029e162d63c894b1ea
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 249
asset_id: microsoft-edge-policies/pdfsecuremode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PDFSecureMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 17aa0783-4cc5-3cbb-e67f-db5918d745e5
---

# Microsoft Edge Browser Policy Documentation PDFSecureMode | Microsoft Learn

## Secure mode and Certificate-based Digital Signature validation in native PDF reader

## Supported versions

- Windows: ≥ 100
- macOS: ≥ 100
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether the native PDF reader validates certificate-based digital signatures in PDF files in a secure environment and displays the validation status. Starting with Microsoft Edge version 154, this capability is enabled by default on Windows. It remains disabled by default on macOS and on Windows in earlier versions.

If you enable this policy, the native PDF reader validates certificate-based digital signatures and provides an option to view the validation status.

If you don't configure this policy, the default behavior described above applies.

If you disable this policy, the native PDF reader doesn't validate certificate-based digital signatures or provide an option to view the validation status.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PDFSecureMode
- GP name: Secure mode and Certificate-based Digital Signature validation in native PDF reader
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
- Value name: PDFSecureMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PDFSecureMode
- Example value:

```xml
<true/>
```