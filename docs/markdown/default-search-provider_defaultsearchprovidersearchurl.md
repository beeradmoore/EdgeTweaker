---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultSearchProviderSearchURL | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultsearchprovidersearchurl
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default search provider search URL'
locale: en-us
document_id: 75c53200-8f4f-76f3-7c2c-9ce3afdcce9f
document_version_independent_id: 75c53200-8f4f-76f3-7c2c-9ce3afdcce9f
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderSearchURL.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderSearchURL.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 281
asset_id: microsoft-edge-policies/defaultsearchprovidersearchurl
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultSearchProviderSearchURL.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f943e1bf-f24b-a59b-9697-fa3facafec2e
---

# Microsoft Edge Browser Policy Documentation DefaultSearchProviderSearchURL | Microsoft Learn

## Default search provider search URL

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 84

## Description

Specifies the URL of the search engine used for a default search. The URL contains the string '{searchTerms}', which is replaced at query time by the terms the user is searching for.

Specify Bing's search URL as:

'{bing:baseURL}search?q={searchTerms}'.

Specify Google's search URL as: '{google:baseURL}search?q={searchTerms}&{google:RLZ}{google:originalQueryForSuggestion}{google:assistedQueryStats}{google:searchFieldtrialParameter}{google:searchClient}{google:sourceId}ie={inputEncoding}'.

This policy is required when you enable the [DefaultSearchProviderEnabled](defaultsearchproviderenabled) policy; if you don't enable the latter policy, this policy is ignored.

Starting in Microsoft Edge 84, you can set this policy as a recommended policy. If the user has already set a default search provider, the default search provider configured by this recommended policy won't be added to the list of search providers the user can choose from. If this is the desired behavior, use the [ManagedSearchEngines](managedsearchengines) policy.

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

- GP unique name: DefaultSearchProviderSearchURL
- GP name: Default search provider search URL
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Default search provider
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Default search provider
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://search.contoso.com/search?q={searchTerms}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DefaultSearchProviderSearchURL
- Value type: REG\_SZ

#### Example registry value

```
https://search.contoso.com/search?q={searchTerms}
```

## Mac information and settings

- Preference Key name: DefaultSearchProviderSearchURL
- Example value:

```xml
<string>https://search.contoso.com/search?q={searchTerms}</string>
```

## Android information and settings

- Preference Key name: DefaultSearchProviderSearchURL
- Example value:

```
https://search.contoso.com/search?q={searchTerms}
```

## iOS information and settings

- Preference Key name: DefaultSearchProviderSearchURL
- Example value:

```xml
<string>https://search.contoso.com/search?q={searchTerms}</string>
```