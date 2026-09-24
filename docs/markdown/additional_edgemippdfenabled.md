---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeMipPdfEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgemippdfenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-08-18T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Microsoft Purview-protected PDF support'
locale: en-us
document_id: ff24398c-1c6f-f7b1-c608-d5108fc21fb7
document_version_independent_id: ff24398c-1c6f-f7b1-c608-d5108fc21fb7
updated_at: 2026-08-20T21:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeMipPdfEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a865810b1ad85218e3939ff6e3d545300a47968e/edgeenterprise/microsoft-edge-policies/EdgeMipPdfEnabled.md
git_commit_id: a865810b1ad85218e3939ff6e3d545300a47968e
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 143
asset_id: microsoft-edge-policies/edgemippdfenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeMipPdfEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/57eae111-0f3b-497e-be07-450fd1409dea
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/ac8bf8ab-8134-4c9a-9f2e-58b31575b492
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: cb31d88d-c866-d433-288a-579ed0c8acff
---

# Microsoft Edge Browser Policy Documentation EdgeMipPdfEnabled | Microsoft Learn

## Microsoft Purview-protected PDF support

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: Not supported
- iOS: ≥ 152

## Description

This policy controls whether Microsoft Edge supports opening Microsoft Purview-protected PDF files.

If you enable this policy, Microsoft Edge enables Microsoft Purview-protected PDF support even when the feature isn't otherwise enabled.

If you disable this policy, Microsoft Edge doesn't open Microsoft Purview-protected PDF files, even when the feature is enabled through edge://flags or an experiment.

If you don't configure this policy, Microsoft Purview-protected PDF support follows its feature configuration, including the user's edge://flags selection.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## iOS information and settings

- Preference Key name: EdgeMipPdfEnabled
- Example value:

```xml
<true/>
```