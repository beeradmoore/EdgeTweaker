---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeMyApps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgemyapps
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Display My Apps bookmark'
locale: en-us
document_id: e4cca6c8-77ba-7556-d448-425139bf278a
document_version_independent_id: e4cca6c8-77ba-7556-d448-425139bf278a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeMyApps.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/EdgeMyApps.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 131
asset_id: microsoft-edge-policies/edgemyapps
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeMyApps.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6cc1937b-9a51-03c2-3fe7-7cef97473fa4
---

# Microsoft Edge Browser Policy Documentation EdgeMyApps | Microsoft Learn

## Display My Apps bookmark

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 143
- iOS: ≥ 143

## Description

This policy controls whether the My Apps bookmark appears in the organization folder within Microsoft Edge for iOS and Android.

If you enable or don’t configure this policy, Microsoft Edge will show the My Apps bookmark by default.

If you disable this policy, Microsoft Edge will hide the My Apps bookmark.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: EdgeMyApps
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: EdgeMyApps
- Example value:

```xml
<true/>
```