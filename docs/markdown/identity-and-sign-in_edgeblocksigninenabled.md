---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeBlockSignInEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeblocksigninenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block Sign In to Edge'
locale: en-us
document_id: 6870ddac-3c39-19d7-dbaa-968fefe683ef
document_version_independent_id: 6870ddac-3c39-19d7-dbaa-968fefe683ef
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeBlockSignInEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeBlockSignInEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 117
asset_id: microsoft-edge-policies/edgeblocksigninenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeBlockSignInEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f7d92120-181f-cbc4-5c53-7d97e0d9790b
---

# Microsoft Edge Browser Policy Documentation EdgeBlockSignInEnabled | Microsoft Learn

## Block Sign In to Edge

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 121
- iOS: ≥ 121

## Description

This policy allows administrators to disable sign in behaviors in Edge mobile.

If this policy is set false or not configured, users can sign in normally.

If this policy is set true, users can't sign in.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: EdgeBlockSignInEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: EdgeBlockSignInEnabled
- Example value:

```xml
<true/>
```