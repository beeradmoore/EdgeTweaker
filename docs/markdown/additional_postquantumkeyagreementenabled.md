---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PostQuantumKeyAgreementEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/postquantumkeyagreementenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable post-quantum key agreement for TLS (obsolete)'
locale: en-us
document_id: 81bfb6fb-06d1-99b3-6694-615853a8faff
document_version_independent_id: 81bfb6fb-06d1-99b3-6694-615853a8faff
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PostQuantumKeyAgreementEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/PostQuantumKeyAgreementEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 347
asset_id: microsoft-edge-policies/postquantumkeyagreementenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PostQuantumKeyAgreementEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a17b44ed-f8eb-ddf1-c9ef-500f5404770d
---

# Microsoft Edge Browser Policy Documentation PostQuantumKeyAgreementEnabled | Microsoft Learn

## Enable post-quantum key agreement for TLS (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 146.

## Supported versions

- Windows: 120-146
- macOS: 120-146
- Android: 140-146
- iOS: Not supported

## Description

This policy configures whether Microsoft Edge offers a post-quantum key agreement algorithm in TLS. This lets supporting servers protect user traffic from being decrypted by quantum computers.

If you enable or don't configure this policy, Microsoft Edge offers a post-quantum key agreement in TLS connections. TLS connections are protected from quantum computers when communicating with compatible servers.

If you disable this policy, Microsoft Edge won't offer a post-quantum key agreement in TLS connections. User traffic is unprotected from decryption by quantum computers.

Offering a post-quantum key agreement is backwards-compatible. Existing TLS servers and networking middleware are expected to ignore the new option and continue selecting previous options.

However, devices that don't implement TLS correctly may malfunction when offered the new option. For example, they might disconnect in response to unrecognized options or the resulting larger messages. These devices aren't post-quantum-ready and will interfere with an enterprise's post-quantum transition. If this issue is encountered, administrators should contact the vendor for a fix.

This policy has been removed starting in Microsoft Edge version 147. Post-quantum key agreement is now enabled by default and cannot be disabled. Enterprises should work with device vendors to obtain fixes for proper post-quantum support.

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

- GP unique name: PostQuantumKeyAgreementEnabled
- GP name: Enable post-quantum key agreement for TLS (obsolete)
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
- Value name: PostQuantumKeyAgreementEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PostQuantumKeyAgreementEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: PostQuantumKeyAgreementEnabled
- Example value:

```
true
```