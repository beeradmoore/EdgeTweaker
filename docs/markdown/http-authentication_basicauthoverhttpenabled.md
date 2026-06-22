---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BasicAuthOverHttpEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/basicauthoverhttpenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Basic authentication for HTTP'
locale: en-us
document_id: c22db815-a114-ec62-9ee7-615f9606dfb1
document_version_independent_id: c22db815-a114-ec62-9ee7-615f9606dfb1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BasicAuthOverHttpEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/BasicAuthOverHttpEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 184
asset_id: microsoft-edge-policies/basicauthoverhttpenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BasicAuthOverHttpEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 84a2a415-6f3d-d40b-fa4c-eb8d6f3702fd
---

# Microsoft Edge Browser Policy Documentation BasicAuthOverHttpEnabled | Microsoft Learn

## Allow Basic authentication for HTTP

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

If you enable or don't configure this policy, Basic authentication challenges received over nonsecure HTTP are allowed.

If you disable this policy, nonsecure HTTP requests from the Basic authentication scheme are blocked, and only secure HTTPS is allowed.

This policy setting is ignored (and Basic is always forbidden) if the [AuthSchemes](authschemes) policy is set and doesn't include Basic.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: BasicAuthOverHttpEnabled
- GP name: Allow Basic authentication for HTTP
- GP path (Mandatory): Administrative Templates/Microsoft Edge/HTTP authentication
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BasicAuthOverHttpEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: BasicAuthOverHttpEnabled
- Example value:

```xml
<false/>
```