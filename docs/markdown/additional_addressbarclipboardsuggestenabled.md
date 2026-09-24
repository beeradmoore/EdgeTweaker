---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AddressBarClipboardSuggestEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/addressbarclipboardsuggestenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable clipboard suggestions in the address bar'
locale: en-us
document_id: dee60b5d-039e-6f97-592a-172c793ffd8a
document_version_independent_id: dee60b5d-039e-6f97-592a-172c793ffd8a
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AddressBarClipboardSuggestEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/AddressBarClipboardSuggestEnabled.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 202
asset_id: microsoft-edge-policies/addressbarclipboardsuggestenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AddressBarClipboardSuggestEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0845f6cd-dff9-ded6-9e1b-f5a39e72f00e
---

# Microsoft Edge Browser Policy Documentation AddressBarClipboardSuggestEnabled | Microsoft Learn

## Enable clipboard suggestions in the address bar

## Supported versions

- Windows: ≥ 151
- macOS: ≥ 151
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether suggestions based on clipboard content are shown in the address bar suggestion dropdown.

If you enable this policy or don't configure it, Microsoft Edge may show suggestions based on clipboard content in the address bar suggestion dropdown.

If you disable this policy, Microsoft Edge doesn't show suggestions based on clipboard content in the address bar suggestion dropdown.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AddressBarClipboardSuggestEnabled
- GP name: Enable clipboard suggestions in the address bar
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
- Value name: AddressBarClipboardSuggestEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AddressBarClipboardSuggestEnabled
- Example value:

```xml
<true/>
```