---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultSearchProviderEncodings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultsearchproviderencodings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default search provider encodings'
locale: en-us
document_id: 8a9b2d49-5cf8-1737-39f0-e62255b6734d
document_version_independent_id: 8a9b2d49-5cf8-1737-39f0-e62255b6734d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderEncodings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderEncodings.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 297
asset_id: microsoft-edge-policies/defaultsearchproviderencodings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultSearchProviderEncodings.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c92e4f90-4dd3-f18d-6a3d-fbfdbc6c47e6
---

# Microsoft Edge Browser Policy Documentation DefaultSearchProviderEncodings | Microsoft Learn

## Default search provider encodings

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 84

## Description

Specify the character encodings supported by the search provider. Encodings are code page names like UTF-8, GB2312, and ISO-8859-1. They're tried in the order provided.

This policy is optional. If not configured, the default, UTF-8, is used.

This policy is applied only if you enable the [DefaultSearchProviderEnabled](defaultsearchproviderenabled) and [DefaultSearchProviderSearchURL](defaultsearchprovidersearchurl) policies.

Starting in Microsoft Edge 84, you can set this policy as a recommended policy. If the user has already set a default search provider, the default search provider configured by this recommended policy won't be added to the list of search providers the user can choose from. If this is the desired behavior, use the [ManagedSearchEngines](managedsearchengines) policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultSearchProviderEncodings
- GP name: Default search provider encodings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Default search provider
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Default search provider
- GP ADMX file name: MSEdge.admx

#### Example value

```
UTF-8
```

```
UTF-16
```

```
GB2312
```

```
ISO-8859-1
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\DefaultSearchProviderEncodings
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended\DefaultSearchProviderEncodings
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\DefaultSearchProviderEncodings\1 =

```
UTF-8
```

SOFTWARE\Policies\Microsoft\Edge\DefaultSearchProviderEncodings\2 =

```
UTF-16
```

SOFTWARE\Policies\Microsoft\Edge\DefaultSearchProviderEncodings\3 =

```
GB2312
```

SOFTWARE\Policies\Microsoft\Edge\DefaultSearchProviderEncodings\4 =

```
ISO-8859-1
```

## Mac information and settings

- Preference Key name: DefaultSearchProviderEncodings
- Example value:

```xml
<array>
  <string>UTF-8</string>
  <string>UTF-16</string>
  <string>GB2312</string>
  <string>ISO-8859-1</string>
</array>
```

## Android information and settings

- Preference Key name: DefaultSearchProviderEncodings
- Example value:

```
["UTF-8", "UTF-16", "GB2312", "ISO-8859-1"]
```

## iOS information and settings

- Preference Key name: DefaultSearchProviderEncodings
- Example value:

```xml
<array>
  <string>UTF-8</string>
  <string>UTF-16</string>
  <string>GB2312</string>
  <string>ISO-8859-1</string>
</array>
```