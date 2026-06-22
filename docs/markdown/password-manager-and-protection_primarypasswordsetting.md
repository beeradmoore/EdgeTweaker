---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrimaryPasswordSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/primarypasswordsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configures a setting that asks users to enter their device password while using password autofill'
locale: en-us
document_id: a2804616-0e04-6192-2025-e83c991e3356
document_version_independent_id: a2804616-0e04-6192-2025-e83c991e3356
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrimaryPasswordSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/PrimaryPasswordSetting.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 564
asset_id: microsoft-edge-policies/primarypasswordsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrimaryPasswordSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 2cf0d5cd-5a7e-eb8c-4d8e-57dfb760aa80
---

# Microsoft Edge Browser Policy Documentation PrimaryPasswordSetting | Microsoft Learn

## Configures a setting that asks users to enter their device password while using password autofill

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

This feature helps users add an additional layer of privacy to their online accounts by requiring device authentication (as a way of confirming the user's identity) before the saved password is autofilled into a web form. This layer ensures that non-authorized persons can't use saved passwords for autofill. This feature doesn't protect against locally running malware.

This group policy configures the radio button selector that enables this feature for users. It also has a frequency control where users can specify how often they would like to be prompted for authentication.

If you set this policy to 'Automatically', disable this policy, or don't configure this policy, autofill won't have any authentication flow.

If you set this policy to 'WithDevicePassword', users have to enter their device password (or preferred mode of authentication under Windows) to prove their identity before their password is autofilled. Authentication modes include Windows Hello, PIN, face recognition, or fingerprint. The frequency for authentication prompt is set to 'Ask permission once per browsing session' by default. However, users can change it to the other option, which is 'Always ask permission'.

If you set this policy to 'WithCustomPrimaryPassword', users are asked to create their custom password and to be redirected to Settings. After the custom password is set, users can authenticate themselves using the custom password and their passwords get autofilled after successful authentication. The frequency for authentication prompt is set to 'Ask permission once per browsing session' by default. However, users can change it to the other option, which is 'Always ask permission'.

If you set this policy to 'AutofillOff', saved passwords are no longer suggested for autofill.

The Custom Primary Password feature will be removed with Edge 149. From this version onward, the Custom Primary Password option will no longer be available. Users who currently have this setting enabled will be automatically migrated to the "Prompt for the device sign-in options" authentication method. Any associated group policies for Custom Primary Password will also be marked as obsolete.

Policy options mapping:

- Automatically (0) = Automatically
- WithDevicePassword (1) = With device password
- WithCustomPrimaryPassword (2) = With custom primary password
- AutofillOff (3) = Autofill off

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Automatically (0) = Automatically
- WithDevicePassword (1) = With device password
- WithCustomPrimaryPassword (2) = With custom primary password
    - Windows: 107-146
    - macOS: 107-146
    - Android: Not supported
    - iOS: Not supported
- AutofillOff (3) = Autofill off
    - Windows: ≥ 107
    - macOS: ≥ 107
    - Android: Not supported
    - iOS: Not supported

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrimaryPasswordSetting
- GP name: Configures a setting that asks users to enter their device password while using password autofill
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Automatically
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrimaryPasswordSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: PrimaryPasswordSetting
- Example value:

```xml
<integer>0</integer>
```