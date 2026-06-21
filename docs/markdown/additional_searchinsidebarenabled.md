---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SearchInSidebarEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/searchinsidebarenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Search in Sidebar enabled'
locale: en-us
document_id: 5b02ec42-242b-1d60-57af-880c3e6e71c2
document_version_independent_id: 5b02ec42-242b-1d60-57af-880c3e6e71c2
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SearchInSidebarEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SearchInSidebarEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 283
asset_id: microsoft-edge-policies/searchinsidebarenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SearchInSidebarEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: e64b1cdc-e5ae-c3bb-bafe-a45f7c689107
---

# Microsoft Edge Browser Policy Documentation SearchInSidebarEnabled | Microsoft Learn

## Search in Sidebar enabled

## Supported versions

- Windows: ≥ 110
- macOS: ≥ 110
- Android: Not supported
- iOS: Not supported

## Description

Search in Sidebar allows users to open search result in sidebar (including sidebar search for Progressive Web Apps).

If you configure this policy to 'EnableSearchInSidebar' or don't configure it, Search in sidebar is enabled.

If you configure this policy to 'DisableSearchInSidebarForKidsMode', Search in sidebar is disabled when in Kids mode. Some methods that would normally invoke sidebar search will invoke a traditional search instead.

If you configure this policy to 'DisableSearchInSidebar', Search in sidebar is disabled. Some methods that would invoke sidebar search invoke a traditional search instead.

Policy options mapping:

- EnableSearchInSidebar (0) = Enable search in sidebar
- DisableSearchInSidebarForKidsMode (1) = Disable search in sidebar for Kids Mode
- DisableSearchInSidebar (2) = Disable search in sidebar

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- EnableSearchInSidebar (0) = Enable search in sidebar
- DisableSearchInSidebarForKidsMode (1) = Disable search in sidebar for Kids Mode
- DisableSearchInSidebar (2) = Disable search in sidebar

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SearchInSidebarEnabled
- GP name: Search in Sidebar enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enable search in sidebar
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: SearchInSidebarEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: SearchInSidebarEnabled
- Example value:

```xml
<integer>0</integer>
```