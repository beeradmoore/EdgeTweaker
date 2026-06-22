---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordManagerRestrictLengthEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordmanagerrestrictlengthenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict the length of passwords that can be saved in the Password Manager'
locale: en-us
document_id: 9652628f-bc29-adcc-980c-e4e38082f9f0
document_version_independent_id: 9652628f-bc29-adcc-980c-e4e38082f9f0
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordManagerRestrictLengthEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/PasswordManagerRestrictLengthEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 204
asset_id: microsoft-edge-policies/passwordmanagerrestrictlengthenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordManagerRestrictLengthEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1a6623db-755c-329e-56fa-1aecb57751c4
---

# Microsoft Edge Browser Policy Documentation PasswordManagerRestrictLengthEnabled | Microsoft Learn

## Restrict the length of passwords that can be saved in the Password Manager

## Supported versions

- Windows: ≥ 104
- macOS: ≥ 104
- Android: Not supported
- iOS: Not supported

## Description

Make Microsoft Edge restrict the length of usernames and/or passwords that can be saved in the Password Manager.

If you enable this policy, Microsoft Edge doesn't let the user save credentials with usernames and/or passwords longer than 256 characters.

If you disable or don't configure this policy, Microsoft Edge lets the user save credentials with arbitrarily long usernames and/or passwords.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PasswordManagerRestrictLengthEnabled
- GP name: Restrict the length of passwords that can be saved in the Password Manager
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
- Value name: PasswordManagerRestrictLengthEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PasswordManagerRestrictLengthEnabled
- Example value:

```xml
<true/>
```