---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WarnBeforeQuittingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/warnbeforequittingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show a warning dialog when the user is attempting to quit'
locale: en-us
document_id: a1183d64-0e0d-0863-331f-cd7b8c167c73
document_version_independent_id: a1183d64-0e0d-0863-331f-cd7b8c167c73
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WarnBeforeQuittingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/WarnBeforeQuittingEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 137
asset_id: microsoft-edge-policies/warnbeforequittingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WarnBeforeQuittingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: af0ede60-26b2-4fa7-a092-ba564da5f511
---

# Microsoft Edge Browser Policy Documentation WarnBeforeQuittingEnabled | Microsoft Learn

## Show a warning dialog when the user is attempting to quit

## Supported versions

- Windows: Not supported
- macOS: ≥ 146
- Android: Not supported
- iOS: Not supported

## Description

Controls whether the "Warn Before Quitting (⌘Q)" warning dialog is shown when the user attempts to quit Microsoft Edge using the keyboard shortcut.

If you enable or don't configure this policy, a warning dialog is shown when the user is attempting to quit.

If you disable this policy, a warning dialog is not shown when the user is attempting to quit.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Mac information and settings

- Preference Key name: WarnBeforeQuittingEnabled
- Example value:

```xml
<true/>
```