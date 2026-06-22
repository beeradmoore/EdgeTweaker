---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ImportOpenTabs | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/importopentabs
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow importing of open tabs'
locale: en-us
document_id: 93485ad3-1c8e-0ad0-76af-a41b34972f10
document_version_independent_id: 93485ad3-1c8e-0ad0-76af-a41b34972f10
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ImportOpenTabs.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/ImportOpenTabs.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 263
asset_id: microsoft-edge-policies/importopentabs
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ImportOpenTabs.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 273d5eb9-357d-a554-c267-d7fe17015efd
---

# Microsoft Edge Browser Policy Documentation ImportOpenTabs | Microsoft Learn

## Allow importing of open tabs

## Supported versions

- Windows: ≥ 79
- macOS: ≥ 79
- Android: Not supported
- iOS: Not supported

## Description

Allows users to import open and pinned tabs from another browser into Microsoft Edge.

If you enable this policy, the **Open tabs** check box is automatically selected in the **Import browser data** dialog box.

If you disable this policy, open tabs aren't imported at first run, and users can't import them manually.

If you don't configure this policy, open tabs are imported at first run, and users can choose whether to import them manually during later browsing sessions.

You can also set this policy as a recommendation. This means that Microsoft Edge imports open tabs on first run, but users can select or clear the **Open tabs** option during manual import.

**Note**: This policy currently only supports importing from Google Chrome (on Windows 7, 8, and 10 and on macOS).

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ImportOpenTabs
- GP name: Allow importing of open tabs
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ImportOpenTabs
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ImportOpenTabs
- Example value:

```xml
<true/>
```