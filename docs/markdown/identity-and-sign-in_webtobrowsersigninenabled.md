---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebToBrowserSignInEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webtobrowsersigninenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Web To Browser Sign-in Enabled'
locale: en-us
document_id: 5d3ed757-a685-6f76-3fe6-4a755e0298f1
document_version_independent_id: 5d3ed757-a685-6f76-3fe6-4a755e0298f1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebToBrowserSignInEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/WebToBrowserSignInEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 204
asset_id: microsoft-edge-policies/webtobrowsersigninenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebToBrowserSignInEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: bfd2002f-23e0-aecc-6a02-a0e3f6f85e97
---

# Microsoft Edge Browser Policy Documentation WebToBrowserSignInEnabled | Microsoft Learn

## Web To Browser Sign-in Enabled

## Supported versions

- Windows: ≥ 133
- macOS: ≥ 133
- Android: Not supported
- iOS: Not supported

## Description

Allow user to sign in to the same account in Microsoft Edge when a user signs in to a Microsoft website. If this policy is enabled or not configured, users can get sign in CTA or seamless sign in experience(if [SeamlessWebToBrowserSignInEnabled](seamlesswebtobrowsersigninenabled) is enabled) when user sign in on Microsoft website. If this policy is disabled, user won't get sign in CTA or seamless sign in experience when user sign in on Microsoft website.

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

- GP unique name: WebToBrowserSignInEnabled
- GP name: Web To Browser Sign-in Enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Identity and sign-in
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebToBrowserSignInEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: WebToBrowserSignInEnabled
- Example value:

```xml
<false/>
```