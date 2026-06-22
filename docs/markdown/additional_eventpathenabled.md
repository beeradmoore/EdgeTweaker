---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EventPathEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/eventpathenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Re-enable the Event.path API until Microsoft Edge version 115 (obsolete)'
locale: en-us
document_id: f5967a5f-aa11-a73a-db48-110518863f2b
document_version_independent_id: f5967a5f-aa11-a73a-db48-110518863f2b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EventPathEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/EventPathEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 241
asset_id: microsoft-edge-policies/eventpathenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EventPathEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: cd0bcc0a-8a7c-d360-9f80-f79a3dcec3cd
---

# Microsoft Edge Browser Policy Documentation EventPathEnabled | Microsoft Learn

## Re-enable the Event.path API until Microsoft Edge version 115 (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 115.

## Supported versions

- Windows: 107-115
- macOS: 107-115
- Android: 105-115
- iOS: Not supported

## Description

Starting in Microsoft Edge version 109, the nonstandard API Event.path is removed to improve web compatibility. This policy re-enables the API until version 115.

If you enable this policy, the Event.path API is available.

If you disable this policy, the Event.path API is unavailable.

If you don't configure this policy, the Event.path API is in the following default states: available before version 109, and unavailable in version 109 to version 114.

This policy is made obsolete after Microsoft Edge version 115.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EventPathEnabled
- GP name: Re-enable the Event.path API until Microsoft Edge version 115 (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EventPathEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EventPathEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: EventPathEnabled
- Example value:

```
true
```