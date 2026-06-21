---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CreatePasskeysInICloudKeychain | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/createpasskeysinicloudkeychain
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control whether passkey creation will default to iCloud Keychain.'
locale: en-us
document_id: 7ca7770b-43da-d422-84fc-3a36910bde11
document_version_independent_id: 7ca7770b-43da-d422-84fc-3a36910bde11
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CreatePasskeysInICloudKeychain.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CreatePasskeysInICloudKeychain.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/createpasskeysinicloudkeychain
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CreatePasskeysInICloudKeychain.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 57a5d94b-05c1-027b-1950-310c06d0df74
---

# Microsoft Edge Browser Policy Documentation CreatePasskeysInICloudKeychain | Microsoft Learn

## Control whether passkey creation will default to iCloud Keychain.

## Supported versions

- Windows: Not supported
- macOS: ≥ 132
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge may direct passkey/WebAuthn creation requests directly to iCloud Keychain on macOS version 13.5 or later. If iCloud Keychain syncing isn't enabled yet, this will prompt the user to sign in with iCloud, or might prompt them to enable iCloud Keychain syncing.

If you have enabled this policy, then iCloud Keychain is the default whenever the WebAuthn request is compatible with that choice.

If you haven't configured this policy, then the default behavior depends on factors such as whether iCloud Drive is enabled, or whether the user has recently used or created a credential in their Microsoft Edge profile.

If you have disabled this policy, iCloud Keychain isn't used by default and the previous behavior (of creating the credential in the Microsoft Edge profile) is used instead. Users can still select iCloud Keychain as an option, and can still see iCloud Keychain credentials when signing in.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Mac information and settings

- Preference Key name: CreatePasskeysInICloudKeychain
- Example value:

```xml
<false/>
```