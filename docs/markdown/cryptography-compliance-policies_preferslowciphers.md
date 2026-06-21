---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PreferSlowCiphers | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/preferslowciphers
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Prefer specific encryption cipher algorithms for TLS'
locale: en-us
document_id: e8f0c5d6-26c6-2d81-9b62-949c8c41c50f
document_version_independent_id: e8f0c5d6-26c6-2d81-9b62-949c8c41c50f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PreferSlowCiphers.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PreferSlowCiphers.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 388
asset_id: microsoft-edge-policies/preferslowciphers
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PreferSlowCiphers.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 73ee7851-e789-16d4-df48-09f6eeb39435
---

# Microsoft Edge Browser Policy Documentation PreferSlowCiphers | Microsoft Learn

## Prefer specific encryption cipher algorithms for TLS

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

This policy configures Microsoft Edge to order its preferred encryption ciphers in TLS 1.3 based on algorithms approved by a specific compliance regime.

Setting this policy does not guarantee that any specific algorithms will be negotiated.

This policy allows server operators who support both compliant and non-compliant clients to differentiate between them, and use certain non-default algorithms with increased cryptographic strength only for clients explicitly configured to prefer them.

Setting the policy to 'cnsa' configures Microsoft Edge to prefer ciphers required for compliance with the Commercial National Security Algorithm Suite versions 1.0 and 2.0 (CNSA 1.0 and 2.0).

Not setting the policy, or setting it to 'default', configures Microsoft Edge to use its default ciphers.

Setting this policy isn't required for security. The default cryptography used by Microsoft Edge is strong enough to withstand a brute-force attack using the entire power of the Sun.

Setting this policy will cause Microsoft Edge to be slower when accessing websites.

This policy only affects TLS 1.3 and QUIC. It doesn't affect earlier versions of TLS.

Policy options mapping:

- CNSA (cnsa) = Prefer ciphers satisfying the requirements of CNSA 1.0 and 2.0
- Default (default) = Use Microsoft Edge's default cipher order

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- CNSA (cnsa) = Prefer ciphers satisfying the requirements of CNSA 1.0 and 2.0
- Default (default) = Use Microsoft Edge's default cipher order

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PreferSlowCiphers
- GP name: Prefer specific encryption cipher algorithms for TLS
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Cryptography compliance policies
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Prefer ciphers satisfying the requirements of CNSA 1.0 and 2.0
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PreferSlowCiphers
- Value type: REG\_SZ

#### Example registry value

```
cnsa
```

## Mac information and settings

- Preference Key name: PreferSlowCiphers
- Example value:

```xml
<string>cnsa</string>
```

## Android information and settings

- Preference Key name: PreferSlowCiphers
- Example value:

```
cnsa
```