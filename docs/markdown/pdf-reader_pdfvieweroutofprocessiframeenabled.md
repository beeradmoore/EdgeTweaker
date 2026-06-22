---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PdfViewerOutOfProcessIframeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/pdfvieweroutofprocessiframeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Use out-of-process iframe PDF Viewer'
locale: en-us
document_id: 59c7ca4e-f550-80b6-9cbc-e44b1122dbcd
document_version_independent_id: 59c7ca4e-f550-80b6-9cbc-e44b1122dbcd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PdfViewerOutOfProcessIframeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/PdfViewerOutOfProcessIframeEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 253
asset_id: microsoft-edge-policies/pdfvieweroutofprocessiframeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PdfViewerOutOfProcessIframeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c9d8dbfc-0469-8a4e-354b-6208e65e76a8
---

# Microsoft Edge Browser Policy Documentation PdfViewerOutOfProcessIframeEnabled | Microsoft Learn

## Use out-of-process iframe PDF Viewer

## Supported versions

- Windows: ≥ 133
- macOS: ≥ 133
- Android: Not supported
- iOS: Not supported

## Description

Determines whether the PDF viewer in Microsoft Edge uses an out-of-process iframe (OOPIF). This is the new PDF viewer architecture going forward, as it's simpler in design and makes adding new features easier. The current GuestView PDF viewer, which relies on an outdated and overly complex architecture, is being deprecated.

If you enable this policy or don't configure it, Microsoft Edge uses the OOPIF PDF viewer architecture. The default behavior will be decided by Microsoft Edge.

If you disable this policy, Microsoft Edge strictly uses the existing GuestView PDF viewer. This approach embeds a web page with its own separate frame tree into another web page.

This policy will be removed in the future, after the OOPIF PDF viewer feature has fully rolled out.

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

- GP unique name: PdfViewerOutOfProcessIframeEnabled
- GP name: Use out-of-process iframe PDF Viewer
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
- Value name: PdfViewerOutOfProcessIframeEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PdfViewerOutOfProcessIframeEnabled
- Example value:

```xml
<true/>
```