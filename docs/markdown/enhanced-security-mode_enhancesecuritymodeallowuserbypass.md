---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnhanceSecurityModeAllowUserBypass | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enhancesecuritymodeallowuserbypass
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to bypass Enhanced Security Mode'
locale: en-us
document_id: 2a60ae4b-4b84-ba9e-5fdc-28c5d8f1403f
document_version_independent_id: 2a60ae4b-4b84-ba9e-5fdc-28c5d8f1403f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeAllowUserBypass.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeAllowUserBypass.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 188
asset_id: microsoft-edge-policies/enhancesecuritymodeallowuserbypass
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeAllowUserBypass.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3090ad6e-d3d2-b4b3-f494-4a6d8a0ca5b6
---

# Microsoft Edge Browser Policy Documentation EnhanceSecurityModeAllowUserBypass | Microsoft Learn

## Allow users to bypass Enhanced Security Mode

## Supported versions

- Windows: ≥ 122
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge lets users bypass Enhanced Security Mode on a site via Settings page or PageInfo flyout. This policy lets you configure whether users can bypass Enhanced Security Mode.

If you disable this policy, Microsoft Edge can't allow users to bypass Enhanced Security Mode.

If you enable or don't configure this policy, Microsoft Edge allows users to bypass Enhanced Security Mode.

For detailed information about Enhanced Security Mode, see https://go.microsoft.com/fwlink/?linkid=2185895

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

- GP unique name: EnhanceSecurityModeAllowUserBypass
- GP name: Allow users to bypass Enhanced Security Mode
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
- Value name: EnhanceSecurityModeAllowUserBypass
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```