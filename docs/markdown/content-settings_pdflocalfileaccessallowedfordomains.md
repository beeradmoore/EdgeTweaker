---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PdfLocalFileAccessAllowedForDomains | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/pdflocalfileaccessallowedfordomains
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow specified sites to access file:// URLs in the PDF Viewer'
locale: en-us
document_id: 3615ec5f-5a49-2fe1-9b67-dcb1a690cd93
document_version_independent_id: 3615ec5f-5a49-2fe1-9b67-dcb1a690cd93
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PdfLocalFileAccessAllowedForDomains.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PdfLocalFileAccessAllowedForDomains.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 198
asset_id: microsoft-edge-policies/pdflocalfileaccessallowedfordomains
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PdfLocalFileAccessAllowedForDomains.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 75cb050f-188e-1c3d-7f46-1a9b6cafb8eb
---

# Microsoft Edge Browser Policy Documentation PdfLocalFileAccessAllowedForDomains | Microsoft Learn

## Allow specified sites to access file:// URLs in the PDF Viewer

## Supported versions

- Windows: ≥ 147
- macOS: ≥ 147
- Android: Not supported
- iOS: Not supported

## Description

Controls which sites can access file:// URLs in the PDF Viewer.

If you enable this policy, sites in the list can access file:// URLs in the PDF Viewer.

If you disable or don't configure this policy, sites cannot access file:// URLs in the PDF Viewer.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PdfLocalFileAccessAllowedForDomains
- GP name: Allow specified sites to access file:// URLs in the PDF Viewer
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
example.com
```

```
contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\PdfLocalFileAccessAllowedForDomains
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\PdfLocalFileAccessAllowedForDomains\1 =

```
example.com
```

SOFTWARE\Policies\Microsoft\Edge\PdfLocalFileAccessAllowedForDomains\2 =

```
contoso.com
```

## Mac information and settings

- Preference Key name: PdfLocalFileAccessAllowedForDomains
- Example value:

```xml
<array>
  <string>example.com</string>
  <string>contoso.com</string>
</array>
```