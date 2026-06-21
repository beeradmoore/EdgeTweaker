---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultSearchProviderEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultsearchproviderenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable the default search provider'
locale: en-us
document_id: a1994d7e-0c00-9071-b65a-f7549b6b43eb
document_version_independent_id: a1994d7e-0c00-9071-b65a-f7549b6b43eb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultSearchProviderEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 348
asset_id: microsoft-edge-policies/defaultsearchproviderenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultSearchProviderEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 0aae940e-34a1-f315-63e2-67fc242f73f1
---

# Microsoft Edge Browser Policy Documentation DefaultSearchProviderEnabled | Microsoft Learn

## Enable the default search provider

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 84

## Description

Enables the ability to use a default search provider.

If you enable this policy, a user can search for a term by typing in the address bar (as long as what they type isn't a URL).

You can specify the default search provider to use by enabling the rest of the default search policies. If these are left empty (not configured) or configured incorrectly, the user can choose the default provider.

If you disable this policy, the user can't search from the address bar.

If you enable or disable this policy, users can't change or override it.

If you don't configure this policy, the default search provider is enabled, and the user can choose the default search provider and set the search provider list.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or instances that enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

Starting in Microsoft Edge 84, you can set this policy as a recommended policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultSearchProviderEnabled
- GP name: Enable the default search provider
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Default search provider
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Default search provider
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DefaultSearchProviderEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultSearchProviderEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: DefaultSearchProviderEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: DefaultSearchProviderEnabled
- Example value:

```xml
<true/>
```