---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation GoToIntranetSiteForSingleWordEntryInAddressBar | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/gotointranetsiteforsinglewordentryinaddressbar
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force direct intranet site navigation instead of searching on single word entries in the Address Bar'
locale: en-us
document_id: c3d41866-8600-f602-a3b3-783ff1670edd
document_version_independent_id: c3d41866-8600-f602-a3b3-783ff1670edd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/GoToIntranetSiteForSingleWordEntryInAddressBar.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/GoToIntranetSiteForSingleWordEntryInAddressBar.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 317
asset_id: microsoft-edge-policies/gotointranetsiteforsinglewordentryinaddressbar
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/GoToIntranetSiteForSingleWordEntryInAddressBar.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2455bd57-3f22-ef3c-129e-d4bf6f8635fc
---

# Microsoft Edge Browser Policy Documentation GoToIntranetSiteForSingleWordEntryInAddressBar | Microsoft Learn

## Force direct intranet site navigation instead of searching on single word entries in the Address Bar

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, the top autosuggest result in the address bar suggestion list navigates to intranet sites if the text entered in the address bar is a single word without punctuation.

Default navigation when typing a single word without punctuation conducts a navigation to an intranet site matching the entered text.

If you enable this policy, the second autosuggest result in the address bar suggestion list conducts a web search exactly as it was entered, if this text is a single word without punctuation. The default search provider is used unless a policy to prevent web search is also enabled.

Two effects of enabling this policy are:

Navigation to sites in response to single word queries that would typically resolve to a history item will no longer happen. Instead, the browser will attempt navigate to internal sites that may not exist in an organization's intranet. This will result in a 404 error.

Popular, single-word search terms will require manual selection of search suggestions to properly conduct a search.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: GoToIntranetSiteForSingleWordEntryInAddressBar
- GP name: Force direct intranet site navigation instead of searching on single word entries in the Address Bar
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: GoToIntranetSiteForSingleWordEntryInAddressBar
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: GoToIntranetSiteForSingleWordEntryInAddressBar
- Example value:

```xml
<false/>
```