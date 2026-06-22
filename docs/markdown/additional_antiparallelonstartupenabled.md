---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AntiParallelOnStartUpEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/antiparallelonstartupenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Anti-Parallel On Start Up'
locale: en-us
document_id: b5ca701e-d8ce-6f2b-ed45-32022dbf05d7
document_version_independent_id: b5ca701e-d8ce-6f2b-ed45-32022dbf05d7
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AntiParallelOnStartUpEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/AntiParallelOnStartUpEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 148
asset_id: microsoft-edge-policies/antiparallelonstartupenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AntiParallelOnStartUpEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 44e8823e-da6c-2714-5ec6-70a2e8f09f7a
---

# Microsoft Edge Browser Policy Documentation AntiParallelOnStartUpEnabled | Microsoft Learn

## Anti-Parallel On Start Up

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: Not supported
- iOS: ≥ 146

## Description

This policy controls whether Microsoft Edge prevents parallel page loads between restored tabs and tabs opened from external links during startup.

If you enable this policy, Microsoft Edge delays network requests when a tab enters the background during startup. This prevents parallel page loads between restored tabs and tabs opened from external links. Queued requests resume when the tab becomes active.

If you disable or don't configure this policy, Microsoft Edge allows parallel page loads during startup as usual.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## iOS information and settings

- Preference Key name: AntiParallelOnStartUpEnabled
- Example value:

```xml
<true/>
```