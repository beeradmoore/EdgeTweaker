---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnhanceSecurityMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enhancesecuritymode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enhance the security state in Microsoft Edge'
locale: en-us
document_id: a89aede3-f8f0-bc7a-b9eb-2a7b3351f6bd
document_version_independent_id: a89aede3-f8f0-bc7a-b9eb-2a7b3351f6bd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnhanceSecurityMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/EnhanceSecurityMode.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 350
asset_id: microsoft-edge-policies/enhancesecuritymode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnhanceSecurityMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 594a1148-c81d-da31-a3eb-9e30cf04c8fc
---

# Microsoft Edge Browser Policy Documentation EnhanceSecurityMode | Microsoft Learn

## Enhance the security state in Microsoft Edge

## Supported versions

- Windows: ≥ 98
- macOS: ≥ 98
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you enhance the security state in Microsoft Edge.

If you set this policy to 'StandardMode', the enhanced mode is turned off, and Microsoft Edge falls back to its standard security mode.

If you set this policy to 'BalancedMode', the security state is in balanced mode.

If you set this policy to 'StrictMode', the security state is in strict mode.

If you set this policy to 'BasicMode', the security state is in basic mode.

Note: Sites that use WebAssembly (WASM) aren't supported on 32-bit systems when [EnhanceSecurityMode](enhancesecuritymode) is enabled. If you require access to a site that uses WASM, consider adding it to your exception list as described in https://go.microsoft.com/fwlink/?linkid=2183321.

Starting from Microsoft Edge version 113, 'BasicMode' is deprecated and is treated the same as 'BalancedMode'. It doesn't work in Microsoft Edge version 116.

For detailed information about Enhanced Security Mode, see https://go.microsoft.com/fwlink/?linkid=2185895.

Policy options mapping:

- StandardMode (0) = Standard mode
- BalancedMode (1) = Balanced mode
- StrictMode (2) = Strict mode
- BasicMode (3) = (Deprecated) Basic mode

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- StandardMode (0) = Standard mode
- BalancedMode (1) = Balanced mode
- StrictMode (2) = Strict mode
- BasicMode (3) = (Deprecated) Basic mode
    - Windows: ≥ 104
    - macOS: ≥ 104
    - Android: Not supported
    - iOS: Not supported

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnhanceSecurityMode
- GP name: Enhance the security state in Microsoft Edge
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Standard mode
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EnhanceSecurityMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: EnhanceSecurityMode
- Example value:

```xml
<integer>0</integer>
```