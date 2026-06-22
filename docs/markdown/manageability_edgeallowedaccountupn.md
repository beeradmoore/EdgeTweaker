---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeAllowedAccountUPN | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeallowedaccountupn
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure allowed account UPN pattern for sign-in'
locale: en-us
document_id: abea0c1e-2869-c529-2772-51ed3f8d38f7
document_version_independent_id: abea0c1e-2869-c529-2772-51ed3f8d38f7
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeAllowedAccountUPN.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/EdgeAllowedAccountUPN.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 174
asset_id: microsoft-edge-policies/edgeallowedaccountupn
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeAllowedAccountUPN.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7eeffe0f-a616-f48f-043c-04c6c8015460
---

# Microsoft Edge Browser Policy Documentation EdgeAllowedAccountUPN | Microsoft Learn

## Configure allowed account UPN pattern for sign-in

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 141
- iOS: ≥ 140

## Description

This policy specifies the User Principal Name (UPN) or UPN pattern allowed to sign in to Microsoft Edge.

If you configure this policy with a UPN or UPN pattern, only accounts that match the specified pattern can sign in to Microsoft Edge and access browser features.

If you disable or don't configure this policy, any account can sign in to Microsoft Edge (subject to other account restriction policies).

Examples:

- "john.doe@contoso.com" - only this specific account is allowed
- "{EnrollmentUser}" - allows the account that enrolled the device
- "\*" - allows all account

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Android information and settings

- Preference Key name: EdgeAllowedAccountUPN
- Example value:

```
{EnrollmentUser}
```

## iOS information and settings

- Preference Key name: EdgeAllowedAccountUPN
- Example value:

```xml
<string>{EnrollmentUser}</string>
```