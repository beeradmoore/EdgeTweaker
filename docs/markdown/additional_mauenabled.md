---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MAUEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/mauenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Always use Microsoft AutoUpdate as the updater for Microsoft Edge (obsolete)'
locale: en-us
document_id: 80901e92-b7c5-bf5a-576d-89eeb9cf1517
document_version_independent_id: 80901e92-b7c5-bf5a-576d-89eeb9cf1517
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MAUEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/MAUEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 169
asset_id: microsoft-edge-policies/mauenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MAUEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: c299b6a8-93ac-5a25-c053-4e5e3d3b8149
---

# Microsoft Edge Browser Policy Documentation MAUEnabled | Microsoft Learn

## Always use Microsoft AutoUpdate as the updater for Microsoft Edge (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 139.

## Supported versions

- Windows: Not supported
- macOS: 93-139
- Android: Not supported
- iOS: Not supported

## Description

From Microsoft Edge version 140, this policy is obsolete because Microsoft Edge now uses EdgeUpdater for browser updates. Updates are no longer delivered through Microsoft AutoUpdate.

This policy determines which updater is used to update Microsoft Edge.

If you enable this policy, Microsoft Edge only uses Microsoft AutoUpdate for updates.

If you disable or don't configure this policy, Microsoft Edge is updated using EdgeUpdater.

Note: This policy is no longer applicable starting with Microsoft Edge version 140.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Mac information and settings

- Preference Key name: MAUEnabled
- Example value:

```xml
<true/>
```