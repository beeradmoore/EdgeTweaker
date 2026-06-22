---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrinterTypeDenyList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printertypedenylist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable printer types on the deny list'
locale: en-us
document_id: 574263c5-2d60-4da9-d771-9bd0852a3a95
document_version_independent_id: 574263c5-2d60-4da9-d771-9bd0852a3a95
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrinterTypeDenyList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/PrinterTypeDenyList.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 413
asset_id: microsoft-edge-policies/printertypedenylist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrinterTypeDenyList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/7428317a-e6c2-4461-ad3e-8a8ad3608734
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/e4f59707-f107-48f2-8d75-0afd91868cd7
platformId: 9e79df5e-7de7-0d73-e7dd-58b1304812fa
---

# Microsoft Edge Browser Policy Documentation PrinterTypeDenyList | Microsoft Learn

## Disable printer types on the deny list

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

The printer types on the deny list aren't discovered or have their capabilities fetched.

Placing all printer types on the deny list effectively disables printing because there's no print destination for documents.

If you don't configure this policy, or the printer list is empty, all printer types are discoverable.

Printer destinations include extension printers and local printers. Extension printers are also known as print provider destinations, and include any destination that belongs to a Microsoft Edge extension. Local printers are also known as native printing destinations, and include destinations available to the local machine and shared network printers.

In Microsoft version 93 or later, if you set this policy to 'pdf' it also disables the 'save as Pdf' option from the right click context menu.

In Microsoft version 103 or later, if you set this policy to 'onedrive' it also disables the 'save as Pdf (OneDrive)' option from print preview.

Policy options mapping:

- privet (privet) = Zeroconf-based (mDNS + DNS-SD) protocol destinations
- extension (extension) = Extension-based destinations
- pdf (pdf) = The 'Save as PDF' destination. (93 or later, also disables from context menu)
- local (local) = Local printer destinations
- onedrive (onedrive) = Save as PDF (OneDrive) printer destinations. (103 or later)

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- privet = Zeroconf-based (mDNS + DNS-SD) protocol destinations
- extension = Extension-based destinations
- pdf = The 'Save as PDF' destination. (93 or later, also disables from context menu)
- local = Local printer destinations
- onedrive = Save as PDF (OneDrive) printer destinations. (103 or later)

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

- GP unique name: PrinterTypeDenyList
- GP name: Disable printer types on the deny list
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Local printer destinations
```

```
Zeroconf-based (mDNS + DNS-SD) protocol destinations
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\PrinterTypeDenyList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\PrinterTypeDenyList\1 =

```
local
```

SOFTWARE\Policies\Microsoft\Edge\PrinterTypeDenyList\2 =

```
privet
```

## Mac information and settings

- Preference Key name: PrinterTypeDenyList
- Example value:

```xml
<array>
  <string>local</string>
  <string>privet</string>
</array>
```