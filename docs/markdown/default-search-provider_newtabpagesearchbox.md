---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageSearchBox | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagesearchbox
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the new tab page search box experience'
locale: en-us
document_id: b234cd94-cd19-f991-6b58-99ab4bc60d26
document_version_independent_id: b234cd94-cd19-f991-6b58-99ab4bc60d26
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageSearchBox.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NewTabPageSearchBox.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 331
asset_id: microsoft-edge-policies/newtabpagesearchbox
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageSearchBox.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 9b617674-7ef0-c5bd-a0b8-f045fa2c6690
---

# Microsoft Edge Browser Policy Documentation NewTabPageSearchBox | Microsoft Learn

## Configure the new tab page search box experience

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 85
- Android: Not supported
- iOS: Not supported

## Description

You can configure the new tab page search box to use "Search box (Recommended)" or "Address bar" to search on new tabs. This policy only works if you set the search engine to a value other than Bing by setting the following two policies: [DefaultSearchProviderEnabled](defaultsearchproviderenabled) and [DefaultSearchProviderSearchURL](defaultsearchprovidersearchurl).

If you disable or don't configure this policy and:

- If the address bar default search engine is Bing, the new tab page uses the search box to search on new tabs.
- If the address bar default search engine isn't Bing, users are offered an additional choice (use "Address bar") when searching on new tabs.

If you enable this policy and set it to:

- "Search box (Recommended)" ('bing'), the new tab page uses the search box to search on new tabs.
- "Address bar" ('redirect'), the new tab page search box uses the address bar to search on new tabs.

Policy options mapping:

- bing (bing) = Search box (Recommended)
- redirect (redirect) = Address bar

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- bing = Search box (Recommended)
- redirect = Address bar

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NewTabPageSearchBox
- GP name: Configure the new tab page search box experience
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Default search provider
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Default search provider
- GP ADMX file name: MSEdge.admx

#### Example value

```
Search box (Recommended)
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NewTabPageSearchBox
- Value type: REG\_SZ

#### Example registry value

```
bing
```

## Mac information and settings

- Preference Key name: NewTabPageSearchBox
- Example value:

```xml
<string>bing</string>
```