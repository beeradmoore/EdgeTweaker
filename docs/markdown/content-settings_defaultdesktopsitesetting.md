---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultDesktopSiteSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultdesktopsitesetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the default view mode for websites'
locale: en-us
document_id: c7c7c35d-8010-05ad-985f-293b53108f3f
document_version_independent_id: c7c7c35d-8010-05ad-985f-293b53108f3f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultDesktopSiteSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultDesktopSiteSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 184
asset_id: microsoft-edge-policies/defaultdesktopsitesetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultDesktopSiteSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 897bf7a3-7c0f-2666-0a21-7ca2deb87d97
---

# Microsoft Edge Browser Policy Documentation DefaultDesktopSiteSetting | Microsoft Learn

## Configure the default view mode for websites

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 135
- iOS: ≥ 135

## Description

This policy determines the default view mode for websites.

If you set this policy to 'DefaultMobileView or don't configure the policy, all websites open in mobile view by default.

If you set this policy to 'DefaultDesktopSite, all websites open in desktop view by default.

Policy options mapping:

- DefaultDesktopSite (1) = Open all websites with Desktop view
- DefaultMobileView (2) = Open all websites with Mobile view

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- DefaultDesktopSite (1) = Open all websites with Desktop view
- DefaultMobileView (2) = Open all websites with Mobile view

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Android information and settings

- Preference Key name: DefaultDesktopSiteSetting
- Example value:

```
1
```

## iOS information and settings

- Preference Key name: DefaultDesktopSiteSetting
- Example value:

```xml
<integer>1</integer>
```