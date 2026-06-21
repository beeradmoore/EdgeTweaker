---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EncryptedClientHelloEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/encryptedclienthelloenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: TLS Encrypted ClientHello Enabled'
locale: en-us
document_id: 48b1404c-50a3-c1cf-26c7-6120d648080a
document_version_independent_id: 48b1404c-50a3-c1cf-26c7-6120d648080a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EncryptedClientHelloEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EncryptedClientHelloEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 244
asset_id: microsoft-edge-policies/encryptedclienthelloenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EncryptedClientHelloEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 79796b22-6635-45a1-8989-15b3a334c35a
---

# Microsoft Edge Browser Policy Documentation EncryptedClientHelloEnabled | Microsoft Learn

## TLS Encrypted ClientHello Enabled

## Supported versions

- Windows: ≥ 108
- macOS: ≥ 108
- Android: ≥ 108
- iOS: Not supported

## Description

Encrypted ClientHello (ECH) is an extension to TLS that encrypts the sensitive fields of ClientHello to improve privacy.

If ECH is enabled, Microsoft Edge might or might not use ECH depending on server support, the availability of the HTTPS DNS record, or the rollout status.

If you enable or don't configure this policy, Microsoft Edge follows the default rollout process for ECH.

If this policy is disabled, Microsoft Edge won't enable ECH.

Because ECH is an evolving protocol, Microsoft Edge's implementation is subject to change.

As such, this policy is a temporary measure to control the initial experimental implementation. It will be replaced with final controls as the protocol finalizes.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EncryptedClientHelloEnabled
- GP name: TLS Encrypted ClientHello Enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EncryptedClientHelloEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EncryptedClientHelloEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: EncryptedClientHelloEnabled
- Example value:

```
true
```