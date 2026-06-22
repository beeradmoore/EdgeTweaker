---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebCaptureEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webcaptureenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable the Screenshot (previously named Web Capture) feature in Microsoft Edge'
locale: en-us
document_id: a08a4838-e58b-f6c3-ac91-ed702ad4b43d
document_version_independent_id: a08a4838-e58b-f6c3-ac91-ed702ad4b43d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebCaptureEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/WebCaptureEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 222
asset_id: microsoft-edge-policies/webcaptureenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebCaptureEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f8f09959-ef09-9976-8bd5-64788defbfa4
---

# Microsoft Edge Browser Policy Documentation WebCaptureEnabled | Microsoft Learn

## Enable the Screenshot (previously named Web Capture) feature in Microsoft Edge

## Supported versions

- Windows: ≥ 87
- macOS: ≥ 87
- Android: Not supported
- iOS: Not supported

## Description

Note: The web capture feature is rebranded to "Screenshot".

Enables the Screenshot feature in Microsoft Edge. This feature lets users capture web and PDF content, and annotate captures using inking tools. Users can also do a visual image search based on the captured content.

If you enable or don't configure this policy, the Screenshot option appears in the context menu, the Settings and more menu, and by using the keyboard shortcut, CTRL+SHIFT+S.

If you disable this policy, users can't access this feature in Microsoft Edge.

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

- GP unique name: WebCaptureEnabled
- GP name: Enable the Screenshot (previously named Web Capture) feature in Microsoft Edge
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
- Value name: WebCaptureEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WebCaptureEnabled
- Example value:

```xml
<true/>
```