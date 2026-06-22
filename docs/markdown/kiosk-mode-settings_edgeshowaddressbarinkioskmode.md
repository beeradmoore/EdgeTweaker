---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeShowAddressBarInKioskMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeshowaddressbarinkioskmode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show address bar in Microsoft Edge Android kiosk mode'
locale: en-us
document_id: 52df1b77-936b-ceab-7e39-bd76980bd32c
document_version_independent_id: 52df1b77-936b-ceab-7e39-bd76980bd32c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeShowAddressBarInKioskMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/EdgeShowAddressBarInKioskMode.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 123
asset_id: microsoft-edge-policies/edgeshowaddressbarinkioskmode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeShowAddressBarInKioskMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3b70584a-75a3-cca5-cc52-f62eb28f4edb
---

# Microsoft Edge Browser Policy Documentation EdgeShowAddressBarInKioskMode | Microsoft Learn

## Show address bar in Microsoft Edge Android kiosk mode

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 143
- iOS: Not supported

## Description

This policy applies to Microsoft Edge for Android when kiosk mode is enabled.

If you enable this policy, the address bar is visible while in kiosk mode.

If you disable or don't configure this policy, the address bar is hidden while in kiosk mode (default).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: EdgeShowAddressBarInKioskMode
- Example value:

```
true
```