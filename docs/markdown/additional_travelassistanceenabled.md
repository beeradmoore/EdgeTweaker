---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TravelAssistanceEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/travelassistanceenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable travel assistance (obsolete)'
locale: en-us
document_id: 68bd7df4-f0b4-2f2e-2392-2f4c68942f26
document_version_independent_id: 68bd7df4-f0b4-2f2e-2392-2f4c68942f26
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TravelAssistanceEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/TravelAssistanceEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 261
asset_id: microsoft-edge-policies/travelassistanceenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TravelAssistanceEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b8d89c92-dd9f-72b2-5e28-6553823336ad
---

# Microsoft Edge Browser Policy Documentation TravelAssistanceEnabled | Microsoft Learn

## Enable travel assistance (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 105.

## Supported versions

- Windows: 93-105
- macOS: 93-105
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete as the feature is now contained within the Edge Sidebar and can be managed using the [HubsSidebarEnabled](hubssidebarenabled) policy. It doesn't work in Microsoft Edge after version 105. Configure this policy to allow/disallow travel assistance.

The travel assistance feature gives helpful and relevant information to a user who performs a travel-related task within the browser. This feature provides trusted and validated suggestions/information to the users from across sources gathered by Microsoft.

If you enable or don't configure this setting, travel assistance is enabled for the users when they are performing travel-related tasks.

If you disable this setting, travel assistance will be disabled, and users won't be able to see any travel-related recommendations.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: TravelAssistanceEnabled
- GP name: Enable travel assistance (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: TravelAssistanceEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: TravelAssistanceEnabled
- Example value:

```xml
<true/>
```