---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation StandardizedBrowserZoomEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/standardizedbrowserzoomenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Standardized Browser Zoom Behavior'
locale: en-us
document_id: c8d58c3d-af1f-38c5-0157-1c77fd26dd1c
document_version_independent_id: c8d58c3d-af1f-38c5-0157-1c77fd26dd1c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/StandardizedBrowserZoomEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/StandardizedBrowserZoomEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 227
asset_id: microsoft-edge-policies/standardizedbrowserzoomenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/StandardizedBrowserZoomEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4c775a6c-b122-861f-3139-8917eae94a37
---

# Microsoft Edge Browser Policy Documentation StandardizedBrowserZoomEnabled | Microsoft Learn

## Enable Standardized Browser Zoom Behavior

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

Configures whether the CSS "zoom" property follows the current CSS specification or legacy behavior.

When this policy is enabled or not configured, the CSS "zoom" property follows the current specification defined by the CSS Working Group: https://drafts.csswg.org/css-viewport/#zoom-property

When this policy is disabled, the CSS "zoom" property uses its legacy, pre-standardized behavior.

This policy is temporary and is intended to provide time for organizations to migrate web content to the updated behavior. In a future Microsoft Edge release, this policy will be removed and the standardized behavior will be enforced by default.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: StandardizedBrowserZoomEnabled
- GP name: Enable Standardized Browser Zoom Behavior
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
- Value name: StandardizedBrowserZoomEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: StandardizedBrowserZoomEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: StandardizedBrowserZoomEnabled
- Example value:

```
true
```