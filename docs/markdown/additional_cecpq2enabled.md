---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CECPQ2Enabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/cecpq2enabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: CECPQ2 post-quantum key-agreement enabled for TLS (obsolete)'
locale: en-us
document_id: ff853a3e-b89e-6673-cf47-8c22434b642d
document_version_independent_id: ff853a3e-b89e-6673-cf47-8c22434b642d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CECPQ2Enabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CECPQ2Enabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 270
asset_id: microsoft-edge-policies/cecpq2enabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CECPQ2Enabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: df995908-165c-8f99-a65e-2309684a9abb
---

# Microsoft Edge Browser Policy Documentation CECPQ2Enabled | Microsoft Learn

## CECPQ2 post-quantum key-agreement enabled for TLS (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 113.

## Supported versions

- Windows: 93-113
- macOS: 93-113
- Android: Not supported
- iOS: Not supported

## Description

This policy was removed in Microsoft Edge version 114 and is ignored if set. It served to disable CECPQ2, but CECPQ2 is disabled by default. A separate policy is introduced to control the rollout of the replacement of CECPQ2. That replacement is a combination of the standard key-agreement X25519 with NIST's chosen post-quantum KEM, called "Kyber".

If you enable or don't configure this policy, then Microsoft Edge follows the default rollout process for CECPQ2, a post-quantum key-agreement algorithm in Transport Layer Security (TLS).

CECPQ2 results in larger TLS messages that, in rare cases, can trigger bugs in some networking hardware. This policy can be set to False to disable CECPQ2 while networking issues are resolved.

This policy is a temporary measure and is removed in future versions of Microsoft Edge.

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

- GP unique name: CECPQ2Enabled
- GP name: CECPQ2 post-quantum key-agreement enabled for TLS (obsolete)
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
- Value name: CECPQ2Enabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CECPQ2Enabled
- Example value:

```xml
<true/>
```