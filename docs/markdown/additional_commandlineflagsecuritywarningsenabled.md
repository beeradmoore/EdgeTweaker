---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CommandLineFlagSecurityWarningsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/commandlineflagsecuritywarningsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable security warnings for command-line flags'
locale: en-us
document_id: 22463a90-6b25-c73d-b5ab-843f85d8c148
document_version_independent_id: 22463a90-6b25-c73d-b5ab-843f85d8c148
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CommandLineFlagSecurityWarningsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/CommandLineFlagSecurityWarningsEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 238
asset_id: microsoft-edge-policies/commandlineflagsecuritywarningsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CommandLineFlagSecurityWarningsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0e7084b2-1020-26d8-7d0f-3c2fd9267d67
---

# Microsoft Edge Browser Policy Documentation CommandLineFlagSecurityWarningsEnabled | Microsoft Learn

## Enable security warnings for command-line flags

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: Not supported
- iOS: Not supported

## Description

If disabled, this policy prevents security warnings from appearing when Microsoft Edge is launched with potentially dangerous command-line flags.

If enabled or unset, security warnings are displayed when these command-line flags are used to launch Microsoft Edge.

For example, the --disable-gpu-sandbox flag generates this warning: You're using an unsupported command-line flag: --disable-gpu-sandbox. This poses stability and security risks.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

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

- GP unique name: CommandLineFlagSecurityWarningsEnabled
- GP name: Enable security warnings for command-line flags
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
- Value name: CommandLineFlagSecurityWarningsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CommandLineFlagSecurityWarningsEnabled
- Example value:

```xml
<true/>
```