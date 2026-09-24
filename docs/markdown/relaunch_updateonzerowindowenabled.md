---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UpdateOnZeroWindowEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/updateonzerowindowenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-29T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Controls background automatic relaunch when all browser windows are closed'
locale: en-us
document_id: e4615c69-2ae1-da83-7095-36a1da5ec8bb
document_version_independent_id: e4615c69-2ae1-da83-7095-36a1da5ec8bb
updated_at: 2026-07-29T23:26:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UpdateOnZeroWindowEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/9f1871942f57afe89efe6bd2f2b953941d236ec7/edgeenterprise/microsoft-edge-policies/UpdateOnZeroWindowEnabled.md
git_commit_id: 9f1871942f57afe89efe6bd2f2b953941d236ec7
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 151
asset_id: microsoft-edge-policies/updateonzerowindowenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UpdateOnZeroWindowEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 100c274d-22ab-6132-c1d8-03dce579de64
---

# Microsoft Edge Browser Policy Documentation UpdateOnZeroWindowEnabled | Microsoft Learn

## Controls background automatic relaunch when all browser windows are closed

## Supported versions

- Windows: Not supported
- macOS: ≥ 152
- Android: Not supported
- iOS: Not supported

## Description

Controls whether Microsoft Edge automatically restarts in the background on macOS to apply a pending browser update after all browser windows are closed.

If you enable this policy or don't configure it, Microsoft Edge can automatically restart in the background to apply a pending browser update after all browser windows are closed.

If you disable this policy, Microsoft Edge won't automatically restart in the background to apply pending browser updates after all browser windows are closed.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Mac information and settings

- Preference Key name: UpdateOnZeroWindowEnabled
- Example value:

```xml
<true/>
```