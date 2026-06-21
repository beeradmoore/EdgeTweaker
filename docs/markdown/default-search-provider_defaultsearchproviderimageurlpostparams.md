---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultSearchProviderImageURLPostParams | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultsearchproviderimageurlpostparams
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Parameters for an image URL that uses POST'
locale: en-us
document_id: 1a166c1a-fc33-9076-5fc2-1eee66cbfcb7
document_version_independent_id: 1a166c1a-fc33-9076-5fc2-1eee66cbfcb7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderImageURLPostParams.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderImageURLPostParams.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 312
asset_id: microsoft-edge-policies/defaultsearchproviderimageurlpostparams
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultSearchProviderImageURLPostParams.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: df99b708-fdf2-53e7-09d1-3b8052c86754
---

# Microsoft Edge Browser Policy Documentation DefaultSearchProviderImageURLPostParams | Microsoft Learn

## Parameters for an image URL that uses POST

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 84

## Description

If you enable this policy, it specifies the parameters used when an image search that uses POST is performed. The policy consists of comma-separated name/value pairs. If a value is a template parameter, like {imageThumbnail} in the preceding example, it's replaced with real image thumbnail data. This policy is applied only if you enable the [DefaultSearchProviderEnabled](defaultsearchproviderenabled) and [DefaultSearchProviderSearchURL](defaultsearchprovidersearchurl) policies.

Specify Bing's Image Search URL Post Params as: 'imageBin={google:imageThumbnailBase64}'.

Specify Google's Image Search URL Post Params as: 'encoded\_image={google:imageThumbnail},image\_url={google:imageURL},sbisrc={google:imageSearchSource},original\_width={google:imageOriginalWidth},original\_height={google:imageOriginalHeight}'.

If you don't set this policy, image search requests are sent using the GET method.

Starting in Microsoft Edge 84, you can set this policy as a recommended policy. If the user set a default search provider, the default search provider configured by this recommended policy can't be added to the list of search providers the user can choose from. If this is the desired behavior, use the [ManagedSearchEngines](managedsearchengines) policy.

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

- GP unique name: DefaultSearchProviderImageURLPostParams
- GP name: Parameters for an image URL that uses POST
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Default search provider
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Default search provider
- GP ADMX file name: MSEdge.admx

#### Example value

```
content={imageThumbnail},url={imageURL},sbisrc={SearchSource}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DefaultSearchProviderImageURLPostParams
- Value type: REG\_SZ

#### Example registry value

```
content={imageThumbnail},url={imageURL},sbisrc={SearchSource}
```

## Mac information and settings

- Preference Key name: DefaultSearchProviderImageURLPostParams
- Example value:

```xml
<string>content={imageThumbnail},url={imageURL},sbisrc={SearchSource}</string>
```

## Android information and settings

- Preference Key name: DefaultSearchProviderImageURLPostParams
- Example value:

```
content={imageThumbnail},url={imageURL},sbisrc={SearchSource}
```

## iOS information and settings

- Preference Key name: DefaultSearchProviderImageURLPostParams
- Example value:

```xml
<string>content={imageThumbnail},url={imageURL},sbisrc={SearchSource}</string>
```