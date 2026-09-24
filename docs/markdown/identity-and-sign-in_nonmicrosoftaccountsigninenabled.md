---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NonMicrosoftAccountSignInEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nonmicrosoftaccountsigninenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable sign-in to Microsoft Edge using non-Microsoft accounts'
locale: en-us
document_id: 959bc5ec-12c7-b11d-2b71-ac1f015d0a76
document_version_independent_id: 959bc5ec-12c7-b11d-2b71-ac1f015d0a76
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NonMicrosoftAccountSignInEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/NonMicrosoftAccountSignInEnabled.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 240
asset_id: microsoft-edge-policies/nonmicrosoftaccountsigninenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NonMicrosoftAccountSignInEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d6afd769-8109-491a-69bb-42e0978b1765
---

# Microsoft Edge Browser Policy Documentation NonMicrosoftAccountSignInEnabled | Microsoft Learn

## Enable sign-in to Microsoft Edge using non-Microsoft accounts

## Supported versions

- Windows: ≥ 150
- macOS: ≥ 150
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether users can sign in to Microsoft Edge using non-Microsoft accounts, such as Google or Apple accounts.

If you enable this policy or don't configure it, users can sign in to Microsoft Edge with non-Microsoft accounts when the feature is available. Related sign-in entry points, such as Google or Apple sign-in buttons in the profile flyout and unified sign-in experience, are shown when available.

If you disable this policy, users can't sign in to Microsoft Edge with non-Microsoft accounts. Related sign-in entry points and code paths are hidden and disabled, regardless of related feature flag settings.

Users can still sign in with Microsoft accounts.

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

- GP unique name: NonMicrosoftAccountSignInEnabled
- GP name: Enable sign-in to Microsoft Edge using non-Microsoft accounts
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Identity and sign-in
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NonMicrosoftAccountSignInEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: NonMicrosoftAccountSignInEnabled
- Example value:

```xml
<true/>
```