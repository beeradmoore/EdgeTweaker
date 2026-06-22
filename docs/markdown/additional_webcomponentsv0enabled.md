---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebComponentsV0Enabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webcomponentsv0enabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Re-enable Web Components v0 API until M84 (obsolete)'
locale: en-us
document_id: 992065f4-1307-4e6c-a1f8-d12c54c8f39d
document_version_independent_id: 992065f4-1307-4e6c-a1f8-d12c54c8f39d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebComponentsV0Enabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/WebComponentsV0Enabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 248
asset_id: microsoft-edge-policies/webcomponentsv0enabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebComponentsV0Enabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2afa392a-32ee-aa85-9f3b-df507b960551
---

# Microsoft Edge Browser Policy Documentation WebComponentsV0Enabled | Microsoft Learn

## Re-enable Web Components v0 API until M84 (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 84.

## Supported versions

- Windows: 80-84
- macOS: 80-84
- Android: 80-84
- iOS: Not supported

## Description

This policy doesn't work because this policy allowed these features to be selectively re-enabled until Microsoft Edge version 85. The Web Components v0 APIs (Shadow DOM v0, Custom Elements v0, and HTML Imports) were deprecated in 2018, and are disabled by default starting in Microsoft Edge version 80.

If you set this policy to True, the Web Components v0 features are enabled for all sites.

If you set this policy to False or don't set this policy, the Web Components v0 features are disabled by default, starting in Microsoft Edge version 80.

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

- GP unique name: WebComponentsV0Enabled
- GP name: Re-enable Web Components v0 API until M84 (obsolete)
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
- Value name: WebComponentsV0Enabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WebComponentsV0Enabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: WebComponentsV0Enabled
- Example value:

```
true
```