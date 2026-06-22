---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SignInCtaOnNtpEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/signinctaonntpenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable sign in click to action dialog (obsolete)'
locale: en-us
document_id: 4075f0c8-d2ad-d392-7a38-12b4f79e84de
document_version_independent_id: 4075f0c8-d2ad-d392-7a38-12b4f79e84de
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SignInCtaOnNtpEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/SignInCtaOnNtpEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 230
asset_id: microsoft-edge-policies/signinctaonntpenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SignInCtaOnNtpEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a8171cbe-bac5-ba95-c295-d729202fc54a
---

# Microsoft Edge Browser Policy Documentation SignInCtaOnNtpEnabled | Microsoft Learn

## Enable sign in click to action dialog (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 130.

## Supported versions

- Windows: 99-130
- macOS: 99-130
- Android: Not supported
- iOS: Not supported

## Description

Configure this policy to show sign in click to action dialog on New tab page.

If you enable or don't configure this policy, sign in click to action dialog is shown on New tab page.

If you disable this policy, sign in click to action dialog isn't shown on the New tab page.

This policy is obsolete as the feature isn't enabled in Microsoft Edge, and this policy isn't supported for Microsoft Edge in the future.

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SignInCtaOnNtpEnabled
- GP name: Enable sign in click to action dialog (obsolete)
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Identity and sign-in
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SignInCtaOnNtpEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SignInCtaOnNtpEnabled
- Example value:

```xml
<true/>
```