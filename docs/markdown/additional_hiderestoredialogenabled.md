---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HideRestoreDialogEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/hiderestoredialogenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Hide restore pages dialog after browser crash'
locale: en-us
document_id: a369e33e-baac-87e4-7998-3ae6e80e15ef
document_version_independent_id: a369e33e-baac-87e4-7998-3ae6e80e15ef
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HideRestoreDialogEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/HideRestoreDialogEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 235
asset_id: microsoft-edge-policies/hiderestoredialogenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HideRestoreDialogEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 33392821-8cad-8c40-02a2-0b7d4c8273f2
---

# Microsoft Edge Browser Policy Documentation HideRestoreDialogEnabled | Microsoft Learn

## Hide restore pages dialog after browser crash

## Supported versions

- Windows: ≥ 100
- macOS: ≥ 100
- Android: Not supported
- iOS: Not supported

## Description

This policy gives an option to hide the "Restore pages" dialog after Microsoft Edge has crashed. The "Restore pages" dialog gives users the option to restore the pages that were previously open before Microsoft Edge crashed.

If you enable this policy, the "Restore pages" dialog isn't shown. In the event of a crash, Microsoft Edge doesn't restore previous tabs and starts the session with a new tab page.

If you disable or don't set this policy, the "Restore pages" dialog is shown.

If you set this policy, don't set the [ClearBrowsingDataOnExit](clearbrowsingdataonexit) or [SavingBrowserHistoryDisabled](savingbrowserhistorydisabled) policy since that prevents history from being saved which also disables the dialog.

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

- GP unique name: HideRestoreDialogEnabled
- GP name: Hide restore pages dialog after browser crash
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
- Value name: HideRestoreDialogEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: HideRestoreDialogEnabled
- Example value:

```xml
<false/>
```