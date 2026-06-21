---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ConfigureOnPremisesAccountAutoSignIn | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/configureonpremisesaccountautosignin
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure automatic sign in with an Active Directory domain account when there is no Azure AD domain account'
locale: en-us
document_id: c2263d6f-fee6-9425-84d0-9d5fe126ebe7
document_version_independent_id: c2263d6f-fee6-9425-84d0-9d5fe126ebe7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ConfigureOnPremisesAccountAutoSignIn.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ConfigureOnPremisesAccountAutoSignIn.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 460
asset_id: microsoft-edge-policies/configureonpremisesaccountautosignin
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ConfigureOnPremisesAccountAutoSignIn.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/1433a524-c01f-4b87-beab-670c040dea4f
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/312f1f05-a431-4193-8a4d-e6245d5966de
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 6d8f6adb-0c33-6669-359f-16b14d7bf420
---

# Microsoft Edge Browser Policy Documentation ConfigureOnPremisesAccountAutoSignIn | Microsoft Learn

## Configure automatic sign in with an Active Directory domain account when there is no Azure AD domain account

## Supported versions

- Windows: ≥ 81
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Enables the use of Azure Active Directory (Azure AD) accounts for automatic sign in if your users' machines are Domain Joined and if your environment isn't hybrid joined. If you want users automatically signed in with their Azure AD accounts instead, Azure AD join (See https://go.microsoft.com/fwlink/?linkid=2118197 for more information) or hybrid join (See https://go.microsoft.com/fwlink/?linkid=2118365 for more information) your environment.

On every launch, Microsoft Edge tries to sign in using this policy, as long as the first profile being launched isn't signed in or an auto sign in doesn't happen before.

If you configure the [BrowserSignin](browsersignin) policy to disabled, this policy doesn't take any effect.

If you enable this policy and set it to 'SignInAndMakeDomainAccountNonRemovable', Microsoft Edge automatically signs in users that are on domain-joined machines using their Azure AD accounts.

If you set this policy to 'Disabled' or don't set it, Microsoft Edge doesn't automatically sign in users that are on domain-joined machines with Azure AD accounts.

From Microsoft Edge version 89, if there's an existing on-premises profile with [RoamingProfileSupportEnabled](roamingprofilesupportenabled) policy disabled, and if the machine is now hybrid joined, that is, it has an Azure AD account, it autoupgrades the on-premises profile to Azure AD profile to get full Azure AD sync facilities.

From Microsoft Edge version 93, if policy [ImplicitSignInEnabled](implicitsigninenabled) is disabled, this policy doesn't take any effect.

From Microsoft Edge version 94, if policy [OnlyOnPremisesImplicitSigninEnabled](onlyonpremisesimplicitsigninenabled) is enabled, and this policy is set to 'SignInAndMakeDomainAccountNonRemovable', it takes effect even on hybrid-joined environment. Microsoft Edge automatically signs in users using their Azure AD domain account even if there are Microsoft Account (MSA) or Azure AD accounts.

Policy options mapping:

- Disabled (0) = Disabled
- SignInAndMakeDomainAccountNonRemovable (1) = Sign in and make domain account non-removable

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Disabled (0) = Disabled
- SignInAndMakeDomainAccountNonRemovable (1) = Sign in and make domain account non-removable

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ConfigureOnPremisesAccountAutoSignIn
- GP name: Configure automatic sign in with an Active Directory domain account when there is no Azure AD domain account
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ConfigureOnPremisesAccountAutoSignIn
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```