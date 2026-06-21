---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation M365AuthPopupsInWorkEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/m365authpopupsinworkenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow M365 authentication popups in work profiles'
locale: en-us
document_id: bdee4320-f626-9713-e059-c947def81b33
document_version_independent_id: bdee4320-f626-9713-e059-c947def81b33
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/M365AuthPopupsInWorkEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/M365AuthPopupsInWorkEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 219
asset_id: microsoft-edge-policies/m365authpopupsinworkenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/M365AuthPopupsInWorkEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/1dd701e0-441f-4b0a-9806-aa47decc4e35
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/0a2fc935-5977-4aa6-9f55-0be03bd2acb8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a1438450-9284-df70-f63e-84dbc5268cd1
---

# Microsoft Edge Browser Policy Documentation M365AuthPopupsInWorkEnabled | Microsoft Learn

## Allow M365 authentication popups in work profiles

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge allows Microsoft 365 authentication pop-ups to bypass the pop-up blocker in work profiles.

When users are signed in with a work account, some Microsoft 365 sites (for example, microsoft.com, cloud.microsoft, and visualstudio.com) may open authentication pop-ups to login.microsoftonline.com, login.live.com, or login.microsoft.com. These pop-ups are required to complete sign-in.

If you enable this policy or don't configure it, Microsoft 365 authentication pop-ups are allowed in work profiles.

If you disable this policy, Microsoft 365 authentication pop-ups follow the default settings like other pop-ups.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: M365AuthPopupsInWorkEnabled
- GP name: Allow M365 authentication popups in work profiles
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Identity and sign-in
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: M365AuthPopupsInWorkEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: M365AuthPopupsInWorkEnabled
- Example value:

```xml
<true/>
```