---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ImportExtensions | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/importextensions
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow importing of extensions'
locale: en-us
document_id: 28f21939-dc87-c195-0631-507d4a74c7d1
document_version_independent_id: 28f21939-dc87-c195-0631-507d4a74c7d1
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ImportExtensions.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ImportExtensions.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 253
asset_id: microsoft-edge-policies/importextensions
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ImportExtensions.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 08d937a4-695a-6185-cfef-f097f3e01b67
---

# Microsoft Edge Browser Policy Documentation ImportExtensions | Microsoft Learn

## Allow importing of extensions

## Supported versions

- Windows: ≥ 81
- macOS: ≥ 81
- Android: Not supported
- iOS: Not supported

## Description

Allows users to import extensions from another browser into Microsoft Edge.

If you enable this policy, the **Extensions** check box is automatically selected in the **Import browser data** dialog box.

If you disable this policy, extensions aren't imported at first run, and users can't import them manually.

If you don't configure this policy, extensions are imported at first run, and users can choose whether to import them manually during later browsing sessions.

You can also set this policy as a recommendation. This means that Microsoft Edge imports extensions on first run, but users can select or clear the **extensions** option during manual import.

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

- GP unique name: ImportExtensions
- GP name: Allow importing of extensions
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
- Value name: ImportExtensions
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ImportExtensions
- Example value:

```xml
<true/>
```