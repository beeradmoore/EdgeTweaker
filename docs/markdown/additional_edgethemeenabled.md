---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeThemeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgethemeenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Theme and Wallpaper customization in Microsoft Edge'
locale: en-us
document_id: c414277f-8e31-6b68-f81d-abdc2a89ed51
document_version_independent_id: c414277f-8e31-6b68-f81d-abdc2a89ed51
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeThemeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/EdgeThemeEnabled.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 141
asset_id: microsoft-edge-policies/edgethemeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeThemeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9badb351-4884-ab19-eac1-1b36da2bb574
---

# Microsoft Edge Browser Policy Documentation EdgeThemeEnabled | Microsoft Learn

## Enable Theme and Wallpaper customization in Microsoft Edge

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 151
- iOS: ≥ 151

## Description

Controls whether users can access and apply Theme and Wallpaper customization in Microsoft Edge.

If you enable or don't configure this policy, Theme and Wallpaper customization is available.

If you disable this policy, Microsoft Edge hides Theme and Wallpaper entry points and renders the default new tab page appearance without deleting existing user-selected Theme or Wallpaper data.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: EdgeThemeEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: EdgeThemeEnabled
- Example value:

```xml
<true/>
```