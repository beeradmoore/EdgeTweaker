---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation XSLTEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/xsltenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the availability of the XSLT feature'
locale: en-us
document_id: c9f96554-11bd-4e4a-6f68-5fb4d6a181fd
document_version_independent_id: c9f96554-11bd-4e4a-6f68-5fb4d6a181fd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/XSLTEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/XSLTEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 211
asset_id: microsoft-edge-policies/xsltenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/XSLTEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f27d2781-ae27-71d0-8810-11180cf63d0a
---

# Microsoft Edge Browser Policy Documentation XSLTEnabled | Microsoft Learn

## Control the availability of the XSLT feature

## Supported versions

- Windows: ≥ 147
- macOS: ≥ 147
- Android: Not supported
- iOS: Not supported

## Description

Controls whether the XSLT feature (the XSLTProcessor JavaScript API and the XSL processing instruction) is available in Microsoft Edge.

If you enable this policy, XSLT is available regardless of the browser's default configuration.

If you disable this policy, XSLT is unavailable regardless of the browser's default configuration.

If you don't configure this policy, XSLT availability is determined by the browser's default configuration and any applicable field trials.

This policy is temporary and will be removed in a future version of Microsoft Edge.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: XSLTEnabled
- GP name: Control the availability of the XSLT feature
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
- Value name: XSLTEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: XSLTEnabled
- Example value:

```xml
<true/>
```