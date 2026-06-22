---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionInstallBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensioninstallblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control which extensions cannot be installed'
locale: en-us
document_id: 8748837b-4348-3c69-458b-1817c8361e25
document_version_independent_id: 8748837b-4348-3c69-458b-1817c8361e25
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionInstallBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/ExtensionInstallBlocklist.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 231
asset_id: microsoft-edge-policies/extensioninstallblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionInstallBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 53e8a611-e80c-f965-766a-81cbff58b0c4
---

# Microsoft Edge Browser Policy Documentation ExtensionInstallBlocklist | Microsoft Learn

## Control which extensions cannot be installed

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Lets you specify which extensions the users CANNOT install. Extensions already installed will be disabled if blocked, without a way for the user to enable them. After a disabled extension is removed from the blocklist it will automatically get re-enabled.

A blocklist value of '\*' means all extensions are blocked unless they are explicitly listed in the allowlist.

If this policy isn't set, the user can install any extension in Microsoft Edge.

Starting in Microsoft Edge version 149, the [Microsoft365CopilotChatIconEnabled](microsoft365copilotchaticonenabled) policy controls the display of Copilot in the toolbar.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionInstallBlocklist
- GP name: Control which extensions cannot be installed
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
extension_id1
```

```
extension_id2
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallBlocklist\1 =

```
extension_id1
```

SOFTWARE\Policies\Microsoft\Edge\ExtensionInstallBlocklist\2 =

```
extension_id2
```

## Mac information and settings

- Preference Key name: ExtensionInstallBlocklist
- Example value:

```xml
<array>
  <string>extension_id1</string>
  <string>extension_id2</string>
</array>
```