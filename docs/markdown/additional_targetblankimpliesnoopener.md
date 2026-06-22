---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TargetBlankImpliesNoOpener | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/targetblankimpliesnoopener
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Do not set window.opener for links targeting _blank (obsolete)'
locale: en-us
document_id: 56925b8c-e9b3-8614-d5bb-37430ace248b
document_version_independent_id: 56925b8c-e9b3-8614-d5bb-37430ace248b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TargetBlankImpliesNoOpener.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/TargetBlankImpliesNoOpener.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 202
asset_id: microsoft-edge-policies/targetblankimpliesnoopener
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TargetBlankImpliesNoOpener.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b887c84b-3283-6bbd-d87e-a372c844a94f
---

# Microsoft Edge Browser Policy Documentation TargetBlankImpliesNoOpener | Microsoft Learn

## Do not set window.opener for links targeting \_blank (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 102.

## Supported versions

- Windows: 88-102
- macOS: 88-102
- Android: 88-102
- iOS: Not supported

## Description

If you enable this policy or leave it unset, the window.opener property is set to null unless the anchor specifies rel="opener".

If you disable this policy, popups that target \_blank are permitted to access (via JavaScript) the page that requested to open the popup.

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

- GP unique name: TargetBlankImpliesNoOpener
- GP name: Do not set window.opener for links targeting \_blank (obsolete)
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
- Value name: TargetBlankImpliesNoOpener
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: TargetBlankImpliesNoOpener
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: TargetBlankImpliesNoOpener
- Example value:

```
false
```