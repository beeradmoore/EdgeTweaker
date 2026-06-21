---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AddressBarWorkSearchResultsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/addressbarworksearchresultsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Work Search suggestions in the address bar'
locale: en-us
document_id: cf1f2e51-3473-f233-a7b8-b3845956b317
document_version_independent_id: cf1f2e51-3473-f233-a7b8-b3845956b317
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AddressBarWorkSearchResultsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AddressBarWorkSearchResultsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 251
asset_id: microsoft-edge-policies/addressbarworksearchresultsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AddressBarWorkSearchResultsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
platformId: ab3852fb-6354-494b-3e86-3dfe37f84bdf
---

# Microsoft Edge Browser Policy Documentation AddressBarWorkSearchResultsEnabled | Microsoft Learn

## Enable Work Search suggestions in the address bar

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: ≥ 135
- iOS: ≥ 135

## Description

Enables the display of relevant workplace suggestions in the address bar’s suggestion dropdown when users type a query in the address bar.

If this policy is enabled or not configured, users can view internal work-related suggestions, such as bookmarks, files, and people results powered by Microsoft 365, in the Microsoft Edge address bar suggestion dropdown. To access these results, users must be signed into Microsoft Edge with their Entra ID account associated with that organization.

If this policy is disabled, users can't see internal workplace results in the Microsoft Edge address bar suggestion dropdown.

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

- GP unique name: AddressBarWorkSearchResultsEnabled
- GP name: Enable Work Search suggestions in the address bar
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
- Value name: AddressBarWorkSearchResultsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AddressBarWorkSearchResultsEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AddressBarWorkSearchResultsEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: AddressBarWorkSearchResultsEnabled
- Example value:

```xml
<true/>
```