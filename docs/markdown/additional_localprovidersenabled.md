---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalProvidersEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localprovidersenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow suggestions from local providers'
locale: en-us
document_id: 24d6efa7-08a1-f513-e07b-e6c2de44e655
document_version_independent_id: 24d6efa7-08a1-f513-e07b-e6c2de44e655
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalProvidersEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/LocalProvidersEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 254
asset_id: microsoft-edge-policies/localprovidersenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalProvidersEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c5165911-c215-27b3-e48d-3a52536bbfdf
---

# Microsoft Edge Browser Policy Documentation LocalProvidersEnabled | Microsoft Learn

## Allow suggestions from local providers

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: Not supported
- iOS: Not supported

## Description

Allow suggestions from suggestion providers on the device (local providers), for example, Favorites and Browsing History, in Microsoft Edge's Address Bar and Auto-Suggest List.

If you enable this policy, suggestions from local providers are used.

If you disable this policy, suggestions from local providers are never used. Local history and local favorites suggestions won't appear.

If you don't configure this policy, suggestions from local providers are allowed but the user can change that using the settings toggle.

Some features may not be available if a policy to disable this feature has been applied. For example, Browsing History suggestions will not be available if you enable the [SavingBrowserHistoryDisabled](savingbrowserhistorydisabled) policy.

This policy requires a browser restart to finish applying.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: LocalProvidersEnabled
- GP name: Allow suggestions from local providers
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: LocalProvidersEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: LocalProvidersEnabled
- Example value:

```xml
<false/>
```