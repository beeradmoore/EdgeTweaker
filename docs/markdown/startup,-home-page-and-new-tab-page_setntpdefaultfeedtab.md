---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SetNTPDefaultFeedTab | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/setntpdefaultfeedtab
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-09T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the default Copilot new tab page feed tab to Work or Discover'
locale: en-us
document_id: 46147448-dd92-148d-fb34-a4b0046c13eb
document_version_independent_id: 46147448-dd92-148d-fb34-a4b0046c13eb
updated_at: 2026-07-09T16:47:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SetNTPDefaultFeedTab.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/2ed5877d3568c6aa41653e7516b38e38467236df/edgeenterprise/microsoft-edge-policies/SetNTPDefaultFeedTab.md
git_commit_id: 2ed5877d3568c6aa41653e7516b38e38467236df
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 285
asset_id: microsoft-edge-policies/setntpdefaultfeedtab
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SetNTPDefaultFeedTab.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
platformId: ff1f0491-fa5a-0b91-54e7-c2bfdb38c43d
---

# Microsoft Edge Browser Policy Documentation SetNTPDefaultFeedTab | Microsoft Learn

## Set the default Copilot new tab page feed tab to Work or Discover

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy sets the default feed tab on the Copilot new tab page to Work or Discover.

If you set this policy to 'Work' (0) or don't configure this policy, Microsoft Edge sets the default feed tab to Work.

If you set this policy to 'Discover' (1), Microsoft Edge sets the default feed tab to Discover.

This policy only takes effect when [ConfigureNTPFeedTabVisibility](configurentpfeedtabvisibility) is set to 'EnableBothWorkDiscover' (0) or isn't configured. If only one feed tab is visible, this policy has no effect.

Policy options mapping:

- NTPDefaultFeedTabWork (0) = Work
- NTPDefaultFeedTabDiscover (1) = Discover

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- NTPDefaultFeedTabWork (0) = Work
- NTPDefaultFeedTabDiscover (1) = Discover

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SetNTPDefaultFeedTab
- GP name: Set the default Copilot new tab page feed tab to Work or Discover
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
Work
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SetNTPDefaultFeedTab
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: SetNTPDefaultFeedTab
- Example value:

```xml
<integer>0</integer>
```