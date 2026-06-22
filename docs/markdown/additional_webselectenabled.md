---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebSelectEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webselectenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Web Select Enabled (obsolete)'
locale: en-us
document_id: 4596ffbc-33ee-6a8e-571c-af4d93e83462
document_version_independent_id: 4596ffbc-33ee-6a8e-571c-af4d93e83462
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebSelectEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/WebSelectEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 260
asset_id: microsoft-edge-policies/webselectenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebSelectEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7e1e5e80-6a98-29c3-f64c-a1531983c120
---

# Microsoft Edge Browser Policy Documentation WebSelectEnabled | Microsoft Learn

## Web Select Enabled (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 116.

## Supported versions

- Windows: 107-116
- macOS: 107-116
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsoleted because Web Select is part of Web Capture and can be controlled by [WebCaptureEnabled](webcaptureenabled). This policy doesn't work in Microsoft Edge version 117. If Web Capture is disabled by [WebCaptureEnabled](webcaptureenabled), Web select won't be available in Web Capture.

Web select lets users select and copy web content while preserving its formatting when pasted in most cases. It also allows more targeted selection on some web elements, such as copying a single column in a table.

If you enable or don't configure this policy, Web select is available in Web Capture and can be accessed directly using the CTRL+SHIFT+X keyboard shortcut.

If you disable this policy, Web select won't be available in Web Capture and the CTRL+SHIFT+X keyboard shortcut will also not work.

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

- GP unique name: WebSelectEnabled
- GP name: Web Select Enabled (obsolete)
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
- Value name: WebSelectEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WebSelectEnabled
- Example value:

```xml
<true/>
```