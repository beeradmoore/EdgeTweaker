---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ConfigureKeyboardShortcuts | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/configurekeyboardshortcuts
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of commands for which to disable keyboard shortcuts'
locale: en-us
document_id: 23817240-98d2-c175-488f-bf11248b2afd
document_version_independent_id: 23817240-98d2-c175-488f-bf11248b2afd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ConfigureKeyboardShortcuts.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/ConfigureKeyboardShortcuts.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 216
asset_id: microsoft-edge-policies/configurekeyboardshortcuts
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ConfigureKeyboardShortcuts.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: be1e1e0f-fde1-ffdc-2766-a8228f9e0c0d
---

# Microsoft Edge Browser Policy Documentation ConfigureKeyboardShortcuts | Microsoft Learn

## Configure the list of commands for which to disable keyboard shortcuts

## Supported versions

- Windows: ≥ 101
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configure the list of Microsoft Edge commands for which keyboard shortcuts must be disabled.

See https://go.microsoft.com/fwlink/?linkid=2186950 for a list of possible commands to disable.

If you enable this policy, commands in the 'disabled' list are no longer activated by keyboard shortcuts.

If you disable this policy, all keyboard shortcuts behave as usual.

Note: Disabling a command only removes its shortcut mapping. Commands in the 'disabled' list still function if accessed via browser UI.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ConfigureKeyboardShortcuts
- GP name: Configure the list of commands for which to disable keyboard shortcuts
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"disabled": ["new_tab", "fullscreen"]}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ConfigureKeyboardShortcuts
- Value type: REG\_SZ

#### Example registry value

```
{"disabled": ["new_tab", "fullscreen"]}
```

#### Expanded example registry value

```
{
  "disabled": [
    "new_tab",
    "fullscreen"
  ]
}
```