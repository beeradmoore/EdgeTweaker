---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ThirdPartyPasswordManagersAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/thirdpartypasswordmanagersallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow using Third-Party Password Managers in Microsoft Edge on Android'
locale: en-us
document_id: e927cfc1-537e-f56f-d249-44f445e23bc7
document_version_independent_id: e927cfc1-537e-f56f-d249-44f445e23bc7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ThirdPartyPasswordManagersAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ThirdPartyPasswordManagersAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 196
asset_id: microsoft-edge-policies/thirdpartypasswordmanagersallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ThirdPartyPasswordManagersAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d02c1554-de54-d166-fd75-8b807e596a56
---

# Microsoft Edge Browser Policy Documentation ThirdPartyPasswordManagersAllowed | Microsoft Learn

## Allow using Third-Party Password Managers in Microsoft Edge on Android

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 147
- iOS: Not supported

## Description

Setting the policy to true lets users use a third-party password manager. That password manager will handle saving and filling for all password, payment and autofill data. When the policy is true or not set, a setting will allow to switch between Microsoft Edge's built-in password manager and the password manager configured in Android settings. Since Microsoft Edge uses the same data as Autofill with Google, the setting can only be changed to use third-party password managers if a manager other than Autofill with Google is configured in Android's system settings.

Setting the policy to false means Microsoft Edge will always use the built-in password manager.

This policy doesn't affect third-party password managers that use accessibility APIs.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: ThirdPartyPasswordManagersAllowed
- Example value:

```
true
```