---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NonRemovableProfileEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nonremovableprofileenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure whether a user always has a default profile automatically signed in with their work or school account'
locale: en-us
document_id: a3b1595c-59a4-5cfa-dc55-04d8203029ec
document_version_independent_id: a3b1595c-59a4-5cfa-dc55-04d8203029ec
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NonRemovableProfileEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NonRemovableProfileEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 343
asset_id: microsoft-edge-policies/nonremovableprofileenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NonRemovableProfileEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b11d5610-d3c0-d4f6-1651-9facf345c887
---

# Microsoft Edge Browser Policy Documentation NonRemovableProfileEnabled | Microsoft Learn

## Configure whether a user always has a default profile automatically signed in with their work or school account

## Supported versions

- Windows: ≥ 78
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy determines if a user can remove the Microsoft Edge profile automatically signed in with a user's work or school account.

If you enable this policy, a nonremovable profile is created with the user's work or school account on Windows. This profile can't be signed out or removed. The profile is nonremovable only if profile is signed-in with either on-premises account or Azure AD account that matches OS sign-in account.

If you disable or don't configure this policy, the profile automatically signs in with a user's work or school account on Windows can be signed out or removed by the user.

If you want to configure browser sign in, use the [BrowserSignin](browsersignin) policy.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10 Pro, or Enterprise instances that enrolled for device management.

From Microsoft Edge version 89 onward, if there is an existing on-premises profile with sync disabled and machine is hybrid joined, it will auto-upgrade the on-premises profile to Azure AD profile and make it non-removable instead of creating a new non-removable Azure AD profile.

From Microsoft Edge version 93 onward, if policy [ImplicitSignInEnabled](implicitsigninenabled) is disabled, this policy doesn't take any effect.

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

- GP unique name: NonRemovableProfileEnabled
- GP name: Configure whether a user always has a default profile automatically signed in with their work or school account
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
- Value name: NonRemovableProfileEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```