---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DeletingUndecryptablePasswordsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/deletingundecryptablepasswordsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable deleting undecryptable passwords'
locale: en-us
document_id: 137dd5f1-cf3f-a275-b1f0-f469f6265106
document_version_independent_id: 137dd5f1-cf3f-a275-b1f0-f469f6265106
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DeletingUndecryptablePasswordsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DeletingUndecryptablePasswordsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 261
asset_id: microsoft-edge-policies/deletingundecryptablepasswordsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DeletingUndecryptablePasswordsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4bb6d1fe-b1e2-f9cb-d148-91f7622109bb
---

# Microsoft Edge Browser Policy Documentation DeletingUndecryptablePasswordsEnabled | Microsoft Learn

## Enable deleting undecryptable passwords

## Supported versions

- Windows: ≥ 132
- macOS: ≥ 132
- Android: Not supported
- iOS: ≥ 139

## Description

This policy controls whether the built-in password manager can delete undecryptable passwords from its database. This is required to restore the full functionality of the built-in password manager, but it may include a permanent data loss. Undecryptable password values don't become decryptable on their own.

If fixing them is possible, it usually requires complex user actions.

Enabling this policy or leaving it unset means that users with undecryptable passwords saved to the built-in password manager will lose them. Passwords that are still in a working state remain untouched.

Disabling this policy means users will have their password manager data untouched but will experience a broken password manager functionality.

If the policy is set, users can't override it in Microsoft Edge.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DeletingUndecryptablePasswordsEnabled
- GP name: Enable deleting undecryptable passwords
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DeletingUndecryptablePasswordsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DeletingUndecryptablePasswordsEnabled
- Example value:

```xml
<true/>
```

## iOS information and settings

- Preference Key name: DeletingUndecryptablePasswordsEnabled
- Example value:

```xml
<true/>
```