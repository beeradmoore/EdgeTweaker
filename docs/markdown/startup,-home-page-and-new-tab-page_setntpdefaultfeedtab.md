---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SetNTPDefaultFeedTab | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/setntpdefaultfeedtab
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the default New Tab Page feed tab to Work or Discover'
locale: en-us
document_id: 46147448-dd92-148d-fb34-a4b0046c13eb
document_version_independent_id: 46147448-dd92-148d-fb34-a4b0046c13eb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SetNTPDefaultFeedTab.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SetNTPDefaultFeedTab.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 282
asset_id: microsoft-edge-policies/setntpdefaultfeedtab
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SetNTPDefaultFeedTab.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ff1f0491-fa5a-0b91-54e7-c2bfdb38c43d
---

# Microsoft Edge Browser Policy Documentation SetNTPDefaultFeedTab | Microsoft Learn

## Set the default New Tab Page feed tab to Work or Discover

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy sets the default feed tab on the New Tab Page to Work or Discover.

If you set this policy to 'Work' (0) or don't configure this policy, Microsoft Edge sets the default feed tab to Work.

If you set this policy to 'Discover' (1), Microsoft Edge sets the default feed tab to Discover.

This policy only takes effect when [ConfigureNTPFeedTabVisibility](configurentpfeedtabvisibility) is set to 'EnableBothWorkDiscover' (0) or is not configured. If only one tab is visible, this policy has no effect.

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
- GP name: Set the default New Tab Page feed tab to Work or Discover
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