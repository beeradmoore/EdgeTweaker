---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ApplicationBoundEncryptionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/applicationboundencryptionenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Application Bound Encryption'
locale: en-us
document_id: a7dc9b4a-7b0a-85dd-6c3b-046ce80643ff
document_version_independent_id: a7dc9b4a-7b0a-85dd-6c3b-046ce80643ff
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ApplicationBoundEncryptionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ApplicationBoundEncryptionEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 210
asset_id: microsoft-edge-policies/applicationboundencryptionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ApplicationBoundEncryptionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 591375df-36c0-6114-2d05-5f6c518f42c3
---

# Microsoft Edge Browser Policy Documentation ApplicationBoundEncryptionEnabled | Microsoft Learn

## Enable Application Bound Encryption

## Supported versions

- Windows: ≥ 127
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Enabling this policy or leaving it unset binds the encryption keys used for local data storage to Microsoft Edge whenever possible.

Disabling this policy has a detrimental effect on Microsoft Edge's security because unknown and potentially hostile apps can retrieve the encryption keys used to secure data.

Only turn off this policy if there are compatibility issues, such as scenarios where other applications need legitimate access to Microsoft Edge's data. Encrypted user data is expected to be fully portable between different computers or the integrity and location of Microsoft Edge's executable files isn’t consistent.

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

- GP unique name: ApplicationBoundEncryptionEnabled
- GP name: Enable Application Bound Encryption
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
- Value name: ApplicationBoundEncryptionEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```