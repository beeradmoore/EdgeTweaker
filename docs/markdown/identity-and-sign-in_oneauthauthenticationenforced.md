---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OneAuthAuthenticationEnforced | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/oneauthauthenticationenforced
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
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: OneAuth Authentication Flow Enforced for signin'
locale: en-us
document_id: d2cf24b9-57d3-bcc9-0416-9e4ace49feee
document_version_independent_id: d2cf24b9-57d3-bcc9-0416-9e4ace49feee
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OneAuthAuthenticationEnforced.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/OneAuthAuthenticationEnforced.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 296
asset_id: microsoft-edge-policies/oneauthauthenticationenforced
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OneAuthAuthenticationEnforced.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/1ae5c491-970a-4062-8301-6336e69f9026
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/f2c3e52e-3667-4e8a-bf11-20b9eaccdc8c
platformId: 97d0f9b3-ead2-42b8-49fc-e4509c75ec87
---

# Microsoft Edge Browser Policy Documentation OneAuthAuthenticationEnforced | Microsoft Learn

## OneAuth Authentication Flow Enforced for signin

## Supported versions

- Windows: ≥ 93
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy allows users to decide whether to use the OneAuth library for sign-in and token fetch in Microsoft Edge on Windows 10 RS3 and later.

If you disable or don't configure this policy, sign-in process uses Windows Account Manager. Microsoft Edge would be able to use accounts you signed in to Windows, Microsoft Office, or other Microsoft applications for sign in, without the need for a password. Or, you can provide valid account and password to sign in, which are stored in Windows Account Manager for future usage. You can investigate all accounts stored in Windows Account Manager through Windows Settings -&gt; Accounts -&gt; Email and accounts page.

If you enable this policy, OneAuth authentication flow is used for account sign in. The OneAuth authentication flow has fewer dependencies and works without Windows shell. The account you use isn't stored in the Email and accounts page.

This policy only takes effect on Windows 10 RS3 and later. On Windows 10 earlier to RS3, OneAuth is used for authentication in Microsoft Edge by default.

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

- GP unique name: OneAuthAuthenticationEnforced
- GP name: OneAuth Authentication Flow Enforced for signin
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
- Value name: OneAuthAuthenticationEnforced
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```