---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeDiscoverEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgediscoverenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Discover feature In Microsoft Edge (obsolete)'
locale: en-us
document_id: db579ba0-b3e2-e7b0-cea6-5b14ebfd90c8
document_version_independent_id: db579ba0-b3e2-e7b0-cea6-5b14ebfd90c8
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeDiscoverEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/EdgeDiscoverEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 236
asset_id: microsoft-edge-policies/edgediscoverenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeDiscoverEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 171b4af5-9207-5007-eb79-03d442c72d7d
---

# Microsoft Edge Browser Policy Documentation EdgeDiscoverEnabled | Microsoft Learn

## Discover feature In Microsoft Edge (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 105.

## Supported versions

- Windows: 97-105
- macOS: 97-105
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because Discover is now contained within the Edge Sidebar and can be managed using the [HubsSidebarEnabled](hubssidebarenabled) policy.

This policy lets you configure the Discover feature in Microsoft Edge.

Working in the background when enabled, this feature sends URLs to Microsoft Bing to search for related recommendations.

If you enable or don't configure this policy, you can use the Discover button on Microsoft Edge to start using this feature.

If you disable this policy, you can't use the Discover feature in Microsoft Edge.

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

- GP unique name: EdgeDiscoverEnabled
- GP name: Discover feature In Microsoft Edge (obsolete)
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
- Value name: EdgeDiscoverEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EdgeDiscoverEnabled
- Example value:

```xml
<true/>
```