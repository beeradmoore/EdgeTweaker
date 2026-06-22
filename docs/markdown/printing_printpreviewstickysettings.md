---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintPreviewStickySettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printpreviewstickysettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the sticky print preview settings'
locale: en-us
document_id: cd45be1a-5969-76eb-48bd-859d5e58f5de
document_version_independent_id: cd45be1a-5969-76eb-48bd-859d5e58f5de
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintPreviewStickySettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/PrintPreviewStickySettings.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 386
asset_id: microsoft-edge-policies/printpreviewstickysettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintPreviewStickySettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1f2c2b52-c3c8-f17b-925b-a2a8064d25bb
---

# Microsoft Edge Browser Policy Documentation PrintPreviewStickySettings | Microsoft Learn

## Configure the sticky print preview settings

## Supported versions

- Windows: ≥ 110
- macOS: ≥ 110
- Android: Not supported
- iOS: Not supported

## Description

Configuring this policy sets the print preview settings as the most recent choice in Print Preview instead of the default print preview settings.

Each item of this policy expects a boolean:

Layout specifies if the webpage layout should be kept sticky or not in print preview settings. If you set this to True, the webpage layout uses the recent choice; otherwise, it sets to default value.

Size specifies if the page size should be kept sticky or not in print preview settings. If you set this to True, the page size uses the recent choice; otherwise, it sets to default value.

Scale Type specifies if the scaling percentage and scale type should be kept sticky or not in print preview settings. If you set this to True, the scale percentage and scale type both use the recent choice; otherwise, it will set to default value.

Margins specifies if the page margin should be kept sticky or not in print preview settings. If you set this to True, the page margins use the recent choice; otherwise, it sets to default value.

If you enable this policy, the selected values use the most recent choice in Print Preview.

If you disable or don't configure this policy, print preview settings aren't impacted.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintPreviewStickySettings
- GP name: Configure the sticky print preview settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Printing
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"layout": false, "margins": true, "scaleType": false, "size": true}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: PrintPreviewStickySettings
- Value type: REG\_SZ

#### Example registry value

```
{"layout": false, "margins": true, "scaleType": false, "size": true}
```

#### Expanded example registry value

```
{
  "layout": false,
  "margins": true,
  "scaleType": false,
  "size": true
}
```

## Mac information and settings

- Preference Key name: PrintPreviewStickySettings
- Example value:

```xml
<key>PrintPreviewStickySettings</key>
<dict>
  <key>layout</key>
  <false/>
  <key>margins</key>
  <true/>
  <key>scaleType</key>
  <false/>
  <key>size</key>
  <true/>
</dict>
```