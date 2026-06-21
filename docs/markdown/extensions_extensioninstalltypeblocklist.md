---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionInstallTypeBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensioninstalltypeblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Blocklist for extension install types'
locale: en-us
document_id: 5c0a6238-8e30-537b-f105-a20b471e7d3d
document_version_independent_id: 5c0a6238-8e30-537b-f105-a20b471e7d3d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionInstallTypeBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ExtensionInstallTypeBlocklist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 210
asset_id: microsoft-edge-policies/extensioninstalltypeblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionInstallTypeBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 659cb784-8cab-094d-4d4f-4978dbfc2ade
---

# Microsoft Edge Browser Policy Documentation ExtensionInstallTypeBlocklist | Microsoft Learn

## Blocklist for extension install types

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: Not supported
- iOS: Not supported

## Description

The blocklist controls which extension install types are disallowed.

Setting the "command\_line" will block an extension from being loaded from command line.

Policy options mapping:

- command\_line (command\_line) = Blocks extensions from being loaded from command line

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- command\_line = Blocks extensions from being loaded from command line

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionInstallTypeBlocklist
- GP name: Blocklist for extension install types
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Blocks extensions from being loaded from command line
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallTypeBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallTypeBlocklist\1 =

```
command_line
```

## Mac information and settings

- Preference Key name: ExtensionInstallTypeBlocklist
- Example value:

```xml
<array>
  <string>command_line</string>
</array>
```