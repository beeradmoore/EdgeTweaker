---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ConfigureNTPFeedTabVisibility | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/configurentpfeedtabvisibility
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure whether the Discover or Work feed tabs are shown on the New Tab Page.'
locale: en-us
document_id: b54e1dfd-cdee-d4db-9284-13b428543c8e
document_version_independent_id: b54e1dfd-cdee-d4db-9284-13b428543c8e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ConfigureNTPFeedTabVisibility.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ConfigureNTPFeedTabVisibility.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 345
asset_id: microsoft-edge-policies/configurentpfeedtabvisibility
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ConfigureNTPFeedTabVisibility.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d0a1f299-7213-88de-8118-dcb8ce0e0d82
---

# Microsoft Edge Browser Policy Documentation ConfigureNTPFeedTabVisibility | Microsoft Learn

## Configure whether the Discover or Work feed tabs are shown on the New Tab Page.

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy configures whether the Discover or Work feed tabs are shown on the New Tab Page. By default, both Work and Discover tabs are enabled.

If you set this policy to 'EnableBothWorkDiscover' (0) or do not configure this policy, Microsoft Edge shows both the Work and Discover feed tabs on the new tab page.

If you set this policy to 'EnableOnlyWork' (1), Microsoft Edge shows only the Work feed tab on the new tab page.

If you set this policy to 'EnableOnlyDiscover' (2), Microsoft Edge shows only the Discover feed tab on the new tab page.

This policy works with the SetNTPDefaultFeedTab policy, which controls which feed tab is selected by default when both tabs are available.

Policy options mapping:

- EnableBothWorkDiscover (0) = Enable both Work and Discover tabs
- EnableOnlyWork (1) = Enable only Work tab
- EnableOnlyDiscover (2) = Enable only Discover tab

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- EnableBothWorkDiscover (0) = Enable both Work and Discover tabs
- EnableOnlyWork (1) = Enable only Work tab
- EnableOnlyDiscover (2) = Enable only Discover tab

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ConfigureNTPFeedTabVisibility
- GP name: Configure whether the Discover or Work feed tabs are shown on the New Tab Page.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enable both Work and Discover tabs
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ConfigureNTPFeedTabVisibility
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ConfigureNTPFeedTabVisibility
- Example value:

```xml
<integer>0</integer>
```