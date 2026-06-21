---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceBingSafeSearch | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcebingsafesearch
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enforce Bing SafeSearch'
locale: en-us
document_id: 910e297c-c8e0-6a8b-b077-8edfec2f4c5f
document_version_independent_id: 910e297c-c8e0-6a8b-b077-8edfec2f4c5f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceBingSafeSearch.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ForceBingSafeSearch.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 315
asset_id: microsoft-edge-policies/forcebingsafesearch
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceBingSafeSearch.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2035a79b-0998-7f4e-7ee1-9e6b7ce4a690
---

# Microsoft Edge Browser Policy Documentation ForceBingSafeSearch | Microsoft Learn

## Enforce Bing SafeSearch

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Ensure that queries in Bing web search are done with SafeSearch set to the value specified. Users can't change this setting.

If you configure this policy to 'BingSafeSearchNoRestrictionsMode', SafeSearch in Bing search falls back to the bing.com value.

If you configure this policy to 'BingSafeSearchModerateMode', the moderate setting is used in SafeSearch. The moderate setting filters adult videos and images but not text from search results.

If you configure this policy to 'BingSafeSearchStrictMode', the strict setting in SafeSearch is used. The strict setting filters adult text, images, and videos.

If you disable this policy or don't configure it, SafeSearch in Bing search isn't enforced, and users can set the value they want on bing.com.

Policy options mapping:

- BingSafeSearchNoRestrictionsMode (0) = Don't configure search restrictions in Bing
- BingSafeSearchModerateMode (1) = Configure moderate search restrictions in Bing
- BingSafeSearchStrictMode (2) = Configure strict search restrictions in Bing

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BingSafeSearchNoRestrictionsMode (0) = Don't configure search restrictions in Bing
- BingSafeSearchModerateMode (1) = Configure moderate search restrictions in Bing
- BingSafeSearchStrictMode (2) = Configure strict search restrictions in Bing

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceBingSafeSearch
- GP name: Enforce Bing SafeSearch
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Don't configure search restrictions in Bing
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ForceBingSafeSearch
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ForceBingSafeSearch
- Example value:

```xml
<integer>0</integer>
```