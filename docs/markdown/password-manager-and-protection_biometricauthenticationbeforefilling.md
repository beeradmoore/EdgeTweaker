---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BiometricAuthenticationBeforeFilling | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/biometricauthenticationbeforefilling
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Device authentication for password autofill'
locale: en-us
document_id: ddcb921b-f00f-4233-d097-335497d1aa33
document_version_independent_id: ddcb921b-f00f-4233-d097-335497d1aa33
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BiometricAuthenticationBeforeFilling.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/BiometricAuthenticationBeforeFilling.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 261
asset_id: microsoft-edge-policies/biometricauthenticationbeforefilling
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BiometricAuthenticationBeforeFilling.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/97159432-14a9-4307-a469-d2f2c75f0e33
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/50565c62-5f6b-4687-be38-323113c72c2e
platformId: cd74b21b-e3a3-0705-781d-053092cf2b0c
---

# Microsoft Edge Browser Policy Documentation BiometricAuthenticationBeforeFilling | Microsoft Learn

## Enable Device authentication for password autofill

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 134
- iOS: ≥ 140

## Description

This policy controls whether users must authenticate with their device password, biometric authentication, or PIN before autofilling saved passwords in web forms. Enabling this setting adds an extra layer of privacy by ensuring only authorized users can use stored credentials.

The feature helps users add an extra layer of privacy to their online accounts by requiring device authentication (as a way of confirming the user's identity) before the saved password is auto filled into a web form. This ensures that nonauthorized persons can't use saved passwords for autofill.

If you enable this policy, the 'Require biometric or PIN' will be enabled and users would be asked to enter their device biometric or PIN while using password autofill. Users can't change it in Microsoft Edge Android.

If you disable or don't configure this policy, the user can turn on/off device authentication when autofilling. By default, the 'Require biometric or PIN' will be disabled and autofill won't have any authentication flow.

True = "Require Biometric or PIN" is mandatory before autofill

False = "Require Biometric or PIN" is optional before autofill

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Android information and settings

- Preference Key name: BiometricAuthenticationBeforeFilling
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: BiometricAuthenticationBeforeFilling
- Example value:

```xml
<true/>
```