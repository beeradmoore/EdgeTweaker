---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintingPaperSizeDefault | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printingpapersizedefault
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default printing page size'
locale: en-us
document_id: e91a6fc0-cfb7-c93b-06aa-adea474b4726
document_version_independent_id: e91a6fc0-cfb7-c93b-06aa-adea474b4726
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintingPaperSizeDefault.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PrintingPaperSizeDefault.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 233
asset_id: microsoft-edge-policies/printingpapersizedefault
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintingPaperSizeDefault.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a90caa46-4086-052e-ef00-03820b14f155
---

# Microsoft Edge Browser Policy Documentation PrintingPaperSizeDefault | Microsoft Learn

## Default printing page size

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

Overrides default printing page size.

Name should contain one of the listed formats or 'custom' if required paper size isn't in the list. If 'custom' value is provided custom\_size property should be specified. It describes the desired height and width in micrometers. Otherwise custom\_size property shouldn't be specified. Policy that violates these rules is ignored.

If the page size is unavailable on the printer chosen by the user, this policy is ignored.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintingPaperSizeDefault
- GP name: Default printing page size
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"custom_size": {"height": 297000, "width": 210000}, "name": "custom"}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrintingPaperSizeDefault
- Value type: REG\_SZ

#### Example registry value

```
{"custom_size": {"height": 297000, "width": 210000}, "name": "custom"}
```

#### Expanded example registry value

```
{
  "custom_size": {
    "height": 297000,
    "width": 210000
  },
  "name": "custom"
}
```

## Mac information and settings

- Preference Key name: PrintingPaperSizeDefault
- Example value:

```xml
<key>PrintingPaperSizeDefault</key>
<dict>
  <key>custom_size</key>
  <dict>
    <key>height</key>
    <integer>297000</integer>
    <key>width</key>
    <integer>210000</integer>
  </dict>
  <key>name</key>
  <string>custom</string>
</dict>
```