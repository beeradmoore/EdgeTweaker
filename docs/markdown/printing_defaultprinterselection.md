---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultPrinterSelection | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultprinterselection
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default printer selection rules'
locale: en-us
document_id: 08d48a54-6088-d521-2212-ec028ce40c2f
document_version_independent_id: 08d48a54-6088-d521-2212-ec028ce40c2f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultPrinterSelection.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultPrinterSelection.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 325
asset_id: microsoft-edge-policies/defaultprinterselection
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultPrinterSelection.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 46699fa7-5445-0f44-795b-816f9e7e3b89
---

# Microsoft Edge Browser Policy Documentation DefaultPrinterSelection | Microsoft Learn

## Default printer selection rules

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Overrides Microsoft Edge default printer selection rules. This policy determines the rules for selecting the default printer in Microsoft Edge, which happens the first time a user tries to print a page.

When this policy is set, Microsoft Edge tries to find a printer that matches all of the specified attributes and uses it as default printer. If there are multiple printers that meet the criteria, the first printer that matches is used.

If you don't configure this policy or no matching printers are found within the timeout, the printer defaults to the built-in PDF printer or no printer, if the PDF printer isn't available.

The value is parsed as a JSON object, conforming to the following schema: { "type": "object", "properties": { "idPattern": { "description": "Regular expression to match printer id.", "type": "string" }, "namePattern": { "description": "Regular expression to match printer display name.", "type": "string" } } }

Omitting a field means all values match; for example, if you don't specify connectivity Print Preview starts discovering all kinds of local printers. Regular expression patterns must follow the JavaScript RegExp syntax and matches are case sensitive.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultPrinterSelection
- GP name: Default printer selection rules
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{ "idPattern": ".*public", "namePattern": ".*Color" }
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultPrinterSelection
- Value type: REG\_SZ

#### Example registry value

```
{ "idPattern": ".*public", "namePattern": ".*Color" }
```

## Mac information and settings

- Preference Key name: DefaultPrinterSelection
- Example value:

```xml
<string>{ "idPattern": ".*public", "namePattern": ".*Color" }</string>
```