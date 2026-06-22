---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AddressBarTrendingSuggestEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/addressbartrendingsuggestenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Microsoft Bing trending suggestions in the address bar'
locale: en-us
document_id: b9813464-0aef-1980-6739-6cad2dfb3e11
document_version_independent_id: b9813464-0aef-1980-6739-6cad2dfb3e11
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AddressBarTrendingSuggestEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/AddressBarTrendingSuggestEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 202
asset_id: microsoft-edge-policies/addressbartrendingsuggestenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AddressBarTrendingSuggestEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/9b11aaae-66fe-4b2c-9a1f-36ce40bf4e7f
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/c0b42e77-fe0d-40dd-9718-99dacb85bf74
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6ed2e8ae-7369-b4f4-4482-e843650d5d99
---

# Microsoft Edge Browser Policy Documentation AddressBarTrendingSuggestEnabled | Microsoft Learn

## Enable Microsoft Bing trending suggestions in the address bar

## Supported versions

- Windows: ≥ 135
- macOS: ≥ 135
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Microsoft Bing trending suggestions appear in the address bar’s suggestion dropdown when users select the address bar while on a New Tab Page.

If this policy is enabled or not configured, Microsoft Bing trending suggestions appear in the address bar suggestion dropdown.

If this policy is disabled, Microsoft Edge doesn't display Microsoft Bing trending suggestions when users select the address bar.

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

- GP unique name: AddressBarTrendingSuggestEnabled
- GP name: Enable Microsoft Bing trending suggestions in the address bar
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
- Value name: AddressBarTrendingSuggestEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AddressBarTrendingSuggestEnabled
- Example value:

```xml
<true/>
```