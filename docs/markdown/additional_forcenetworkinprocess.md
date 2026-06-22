---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceNetworkInProcess | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcenetworkinprocess
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force networking code to run in the browser process (obsolete)'
locale: en-us
document_id: 2f64dab7-1c75-b9af-7bfd-685d8c50bbd1
document_version_independent_id: 2f64dab7-1c75-b9af-7bfd-685d8c50bbd1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceNetworkInProcess.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/ForceNetworkInProcess.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 215
asset_id: microsoft-edge-policies/forcenetworkinprocess
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceNetworkInProcess.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 04345382-9db3-f5e4-42f8-e7d54a89e1bc
---

# Microsoft Edge Browser Policy Documentation ForceNetworkInProcess | Microsoft Learn

## Force networking code to run in the browser process (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 83.

## Supported versions

- Windows: 78-83
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because it was only intended to be a short-term mechanism to give enterprises more time to migrate to third party software that doesn't depend on hooking networking APIs. Proxy servers are recommended over Label-Switched Paths (LSPs) and Win32 API patching.

This policy forces networking code to run in the browser process.

This policy is disabled by default. If enabled, users are open to security issues when the networking process is sandboxed.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceNetworkInProcess
- GP name: Force networking code to run in the browser process (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ForceNetworkInProcess
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```