---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ImportPasswordsDisabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/importpasswordsdisabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Prevent importing passwords from Password Manager'
locale: en-us
document_id: eed66635-910b-c0f9-b639-bd316fe9491c
document_version_independent_id: eed66635-910b-c0f9-b639-bd316fe9491c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ImportPasswordsDisabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/ImportPasswordsDisabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 157
asset_id: microsoft-edge-policies/importpasswordsdisabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ImportPasswordsDisabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c36b7856-8b78-9c8c-8b53-c11bd7dce8d8
---

# Microsoft Edge Browser Policy Documentation ImportPasswordsDisabled | Microsoft Learn

## Prevent importing passwords from Password Manager

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 142
- iOS: ≥ 142

## Description

This policy controls whether users can import passwords into Microsoft Edge from the built-in Password Manager on mobile platforms.

If you enable this policy, users cannot import passwords. On iOS, the Add button in Password Manager is disabled. This policy applies only to password import and add entry points, and does not affect viewing, editing, or using already saved passwords.

If you disable or don't configure this policy, users can import passwords from Password Manager.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: ImportPasswordsDisabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: ImportPasswordsDisabled
- Example value:

```xml
<true/>
```