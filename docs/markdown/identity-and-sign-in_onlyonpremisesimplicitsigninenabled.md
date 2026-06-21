---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OnlyOnPremisesImplicitSigninEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/onlyonpremisesimplicitsigninenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Only on-premises account enabled for implicit sign-in'
locale: en-us
document_id: a76e2fbd-64e8-e4a1-793d-eec03a347597
document_version_independent_id: a76e2fbd-64e8-e4a1-793d-eec03a347597
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OnlyOnPremisesImplicitSigninEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/OnlyOnPremisesImplicitSigninEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 213
asset_id: microsoft-edge-policies/onlyonpremisesimplicitsigninenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OnlyOnPremisesImplicitSigninEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/1433a524-c01f-4b87-beab-670c040dea4f
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/312f1f05-a431-4193-8a4d-e6245d5966de
platformId: 3b51df37-0785-9b5d-066b-5b2891b63e9a
---

# Microsoft Edge Browser Policy Documentation OnlyOnPremisesImplicitSigninEnabled | Microsoft Learn

## Only on-premises account enabled for implicit sign-in

## Supported versions

- Windows: ≥ 94
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configures this policy to decide whether only on-premises accounts are enabled for implicit sign in.

If you enable this policy, only on-premises accounts are enabled for implicit sign in. Microsoft Edge doesn't attempt to implicitly sign in to Microsoft Services account (MSA) or Azure Active Directory (AAD) accounts. Upgrade from on-premises accounts to AAD accounts are also stopped.

If you disable or don't configure this policy, all accounts are enabled for implicit sign in.

This policy only takes effect when policy [ConfigureOnPremisesAccountAutoSignIn](configureonpremisesaccountautosignin) is enabled and is set to 'SignInAndMakeDomainAccountNonRemovable'.

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

- GP unique name: OnlyOnPremisesImplicitSigninEnabled
- GP name: Only on-premises account enabled for implicit sign-in
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
- Value name: OnlyOnPremisesImplicitSigninEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```