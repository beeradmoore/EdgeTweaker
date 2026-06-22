---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HappyEyeballsV3Enabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/happyeyeballsv3enabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Use the Happy Eyeballs V3 algorithm for connection attempts'
locale: en-us
document_id: 5fa2a0e0-ff18-6ddf-fd8d-67747f4e6fca
document_version_independent_id: 5fa2a0e0-ff18-6ddf-fd8d-67747f4e6fca
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HappyEyeballsV3Enabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/HappyEyeballsV3Enabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/happyeyeballsv3enabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HappyEyeballsV3Enabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: df1570f6-378f-859d-5db6-94844f120679
---

# Microsoft Edge Browser Policy Documentation HappyEyeballsV3Enabled | Microsoft Learn

## Use the Happy Eyeballs V3 algorithm for connection attempts

## Supported versions

- Windows: ≥ 137
- macOS: ≥ 137
- Android: ≥ 140
- iOS: Not supported

## Description

Controls whether Microsoft Edge uses the Happy Eyeballs V3 algorithm to optimize connection attempts. This algorithm improves reliability and performance in dual-stack (IPv4/IPv6) networks by racing connection attempts across IP versions and HTTP protocols (e.g., HTTP/3 vs. others). For more details, see https://datatracker.ietf.org/doc/draft-pauly-happy-happyeyeballs-v3.

Enabled: Uses the algorithm for connection attempts.

Disabled or not configured: Disables the algorithm.

Note: This policy supports dynamic refresh.

Important: This policy is temporary and will be removed in a future version.

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

- GP unique name: HappyEyeballsV3Enabled
- GP name: Use the Happy Eyeballs V3 algorithm for connection attempts
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: HappyEyeballsV3Enabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: HappyEyeballsV3Enabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: HappyEyeballsV3Enabled
- Example value:

```
true
```