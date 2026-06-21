---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordManagerEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordmanagerenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable saving passwords to the password manager'
locale: en-us
document_id: 404c9057-540f-63ef-ab9c-71d29e6ab0bc
document_version_independent_id: 404c9057-540f-63ef-ab9c-71d29e6ab0bc
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordManagerEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PasswordManagerEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 229
asset_id: microsoft-edge-policies/passwordmanagerenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordManagerEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0acb837b-0dd9-d821-6c90-a2a293a56fb7
---

# Microsoft Edge Browser Policy Documentation PasswordManagerEnabled | Microsoft Learn

## Enable saving passwords to the password manager

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 84

## Description

Enable Microsoft Edge to save user passwords. The next time a user visits a site with a saved password, Microsoft Edge will enter the password automatically.

If you enable or don't configure this policy, users can save and add their passwords in Microsoft Edge.

If you disable this policy, users can't save and add new passwords, but they can still use previously saved passwords.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PasswordManagerEnabled
- GP name: Enable saving passwords to the password manager
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Password manager and protection
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: PasswordManagerEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PasswordManagerEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: PasswordManagerEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: PasswordManagerEnabled
- Example value:

```xml
<true/>
```