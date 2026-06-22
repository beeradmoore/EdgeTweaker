---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation GamerModeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/gamermodeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Gamer Mode (obsolete)'
locale: en-us
document_id: 13ab198d-89d6-aa66-e87c-669fe05f0e62
document_version_independent_id: 13ab198d-89d6-aa66-e87c-669fe05f0e62
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/GamerModeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/GamerModeEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 211
asset_id: microsoft-edge-policies/gamermodeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/GamerModeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2ffa4741-7a6d-8ee4-af24-ef00063fb77b
---

# Microsoft Edge Browser Policy Documentation GamerModeEnabled | Microsoft Learn

## Enable Gamer Mode (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 140.

## Supported versions

- Windows: 117-140
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge Gamer Mode allows gamers to personalize their browser with gaming themes and gives them the option of enabling Efficiency Mode for PC gaming, the Gaming feed on new tabs, sidebar apps for gamers, and more.

If you enable or don't configure this policy, users can opt into Gamer Mode. If you disable this policy, Gamer Mode is disabled. Note: With Microsoft Edge version 141, this policy is obsolete because the Gamer Mode feature is removed.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: GamerModeEnabled
- GP name: Enable Gamer Mode (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Games settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Games settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: GamerModeEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```