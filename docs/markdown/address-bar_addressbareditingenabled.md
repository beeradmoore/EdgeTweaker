---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AddressBarEditingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/addressbareditingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure address bar editing'
locale: en-us
document_id: b37988e3-495a-1deb-cc94-010ea4f5b20d
document_version_independent_id: b37988e3-495a-1deb-cc94-010ea4f5b20d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AddressBarEditingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AddressBarEditingEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 236
asset_id: microsoft-edge-policies/addressbareditingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AddressBarEditingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
platformId: 36adb6b3-bcf6-f918-67ad-fda024973ba8
---

# Microsoft Edge Browser Policy Documentation AddressBarEditingEnabled | Microsoft Learn

## Configure address bar editing

## Supported versions

- Windows: ≥ 98
- macOS: ≥ 98
- Android: Not supported
- iOS: Not supported

## Description

If you enable or don't configure this policy, users can change the URL in the address bar.

If you disable this policy, it prevents users from changing the URL in the address bar.

Note: This policy doesn't prevent the browser from navigating to any URL. Users can still navigate to any URL using the search option in the default New Tab Page, or using any link that leads to a web search engine. To ensure that users can only go to sites you expect, consider configuring the following policies in addition to this policy:

- [NewTabPageLocation](newtabpagelocation)
- [HomepageLocation](homepagelocation)
- [HomepageIsNewTabPage](homepageisnewtabpage)
- [URLBlocklist](urlblocklist) and [URLAllowlist](urlallowlist) to scope the pages that browser can navigate to.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AddressBarEditingEnabled
- GP name: Configure address bar editing
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
- Value name: AddressBarEditingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AddressBarEditingEnabled
- Example value:

```xml
<true/>
```