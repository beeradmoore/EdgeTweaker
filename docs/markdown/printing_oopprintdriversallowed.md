---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OopPrintDriversAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/oopprintdriversallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Out-of-process print drivers allowed'
locale: en-us
document_id: b1d0fdb7-66b8-3eb8-e9c1-7addfa09c6f5
document_version_independent_id: b1d0fdb7-66b8-3eb8-e9c1-7addfa09c6f5
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OopPrintDriversAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/OopPrintDriversAllowed.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 218
asset_id: microsoft-edge-policies/oopprintdriversallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OopPrintDriversAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 49109e57-4ed5-ca05-4da4-8cd413f25bce
---

# Microsoft Edge Browser Policy Documentation OopPrintDriversAllowed | Microsoft Learn

## Out-of-process print drivers allowed

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: Not supported
- iOS: Not supported

## Description

This policy determines whether Microsoft Edge handles interactions with printer drivers through a separate service process.

Using a service process for tasks like querying available printers, retrieving print driver settings, and submitting documents to local printers improves browser stability and prevents UI freezing during Print Preview.

Enabled or Not Set: Microsoft Edge uses a separate service process for these printing tasks.

Disabled: Microsoft Edge performs these printing tasks within the browser process.

Note: This policy will be deprecated in the future once the transition to out-of-process print drivers is fully implemented.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: OopPrintDriversAllowed
- GP name: Out-of-process print drivers allowed
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: OopPrintDriversAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: OopPrintDriversAllowed
- Example value:

```xml
<true/>
```