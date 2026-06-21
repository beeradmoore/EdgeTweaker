---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowWebAuthnWithBrokenTlsCerts | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowwebauthnwithbrokentlscerts
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Web Authentication requests on sites with broken TLS certificates.'
locale: en-us
document_id: 35b4dee2-8a09-1521-c770-6135fb0c0714
document_version_independent_id: 35b4dee2-8a09-1521-c770-6135fb0c0714
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowWebAuthnWithBrokenTlsCerts.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AllowWebAuthnWithBrokenTlsCerts.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 187
asset_id: microsoft-edge-policies/allowwebauthnwithbrokentlscerts
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowWebAuthnWithBrokenTlsCerts.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: bffaa23b-6325-742b-cd38-a0a4e03653d2
---

# Microsoft Edge Browser Policy Documentation AllowWebAuthnWithBrokenTlsCerts | Microsoft Learn

## Allow Web Authentication requests on sites with broken TLS certificates.

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: ≥ 138
- iOS: Not supported

## Description

If you enable this policy, Microsoft Edge allows Web Authentication requests on websites that have TLS certificates with errors (that is, websites considered not secure).

If you disable or don't configure this policy, the default behavior of blocking such requests apply.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllowWebAuthnWithBrokenTlsCerts
- GP name: Allow Web Authentication requests on sites with broken TLS certificates.
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
- Value name: AllowWebAuthnWithBrokenTlsCerts
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AllowWebAuthnWithBrokenTlsCerts
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AllowWebAuthnWithBrokenTlsCerts
- Example value:

```
true
```