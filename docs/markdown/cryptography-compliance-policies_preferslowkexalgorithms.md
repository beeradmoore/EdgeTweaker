---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PreferSlowKexAlgorithms | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/preferslowkexalgorithms
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Prefer specific key exchange algorithms for TLS'
locale: en-us
document_id: 257db182-e791-56e8-68ad-f654b11e7464
document_version_independent_id: 257db182-e791-56e8-68ad-f654b11e7464
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PreferSlowKexAlgorithms.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/PreferSlowKexAlgorithms.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 338
asset_id: microsoft-edge-policies/preferslowkexalgorithms
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PreferSlowKexAlgorithms.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7636fcb0-b318-37e5-bd9a-9cc893b078a5
---

# Microsoft Edge Browser Policy Documentation PreferSlowKexAlgorithms | Microsoft Learn

## Prefer specific key exchange algorithms for TLS

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

This policy configures Microsoft Edge to prioritize certain key agreement algorithms (supported groups) in TLS 1.3 based on compliance requirements.

If you set this policy to 'cnsa2', Microsoft Edge prefers the algorithms required for the Commercial National Security Algorithm Suite 2.0 (CNSA 2.0). If you leave this policy unset or set it to 'default', the browser uses its standard key exchange order.

This policy does not guarantee negotiation of a specific algorithm. It is designed to help server operators distinguish clients with compliance requirements and apply higher-strength, non-default algorithms only when appropriate.

This policy applies only to TLS 1.3 and QUIC. The default cryptography used by Microsoft Edge already provides strong security, but enabling this policy may reduce performance when accessing websites.

Policy options mapping:

- CNSA2.0 (cnsa2) = Prefer key exchange methods satisfying the requirements of CNSA 2.0
- Default (default) = Use Microsoft Edge's default supported groups

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- CNSA2.0 (cnsa2) = Prefer key exchange methods satisfying the requirements of CNSA 2.0
- Default (default) = Use Microsoft Edge's default supported groups

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

- GP unique name: PreferSlowKexAlgorithms
- GP name: Prefer specific key exchange algorithms for TLS
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Cryptography compliance policies
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Prefer key exchange methods satisfying the requirements of CNSA 2.0
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PreferSlowKexAlgorithms
- Value type: REG\_SZ

#### Example registry value

```
cnsa2
```

## Mac information and settings

- Preference Key name: PreferSlowKexAlgorithms
- Example value:

```xml
<string>cnsa2</string>
```

## Android information and settings

- Preference Key name: PreferSlowKexAlgorithms
- Example value:

```
cnsa2
```