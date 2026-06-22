---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordDeleteOnBrowserCloseEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passworddeleteonbrowsercloseenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Prevent passwords from being deleted if any Edge settings is enabled to delete browsing data when Microsoft Edge closes'
locale: en-us
document_id: 34af2c3a-baa7-c0de-87ab-99ad422589b2
document_version_independent_id: 34af2c3a-baa7-c0de-87ab-99ad422589b2
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordDeleteOnBrowserCloseEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/PasswordDeleteOnBrowserCloseEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 224
asset_id: microsoft-edge-policies/passworddeleteonbrowsercloseenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordDeleteOnBrowserCloseEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0db56d33-b359-aab3-5e68-506fe735ba53
---

# Microsoft Edge Browser Policy Documentation PasswordDeleteOnBrowserCloseEnabled | Microsoft Learn

## Prevent passwords from being deleted if any Edge settings is enabled to delete browsing data when Microsoft Edge closes

## Supported versions

- Windows: ≥ 117
- macOS: ≥ 117
- Android: Not supported
- iOS: Not supported

## Description

When this policy is enabled, the passwords saved with Edge Password Manager are exempted from deletion when the browser closes. This policy is only effective when the [ClearBrowsingDataOnExit](clearbrowsingdataonexit) policy is enabled.

If you enable this policy, passwords aren't cleared when the browser closes. If you disable or don't configure this policy, the user's personal configuration is used.

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

- GP unique name: PasswordDeleteOnBrowserCloseEnabled
- GP name: Prevent passwords from being deleted if any Edge settings is enabled to delete browsing data when Microsoft Edge closes
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
- Value name: PasswordDeleteOnBrowserCloseEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PasswordDeleteOnBrowserCloseEnabled
- Example value:

```xml
<true/>
```