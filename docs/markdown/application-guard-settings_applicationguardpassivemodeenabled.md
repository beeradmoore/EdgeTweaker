---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ApplicationGuardPassiveModeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/applicationguardpassivemodeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Ignore Application Guard site list configuration and browse Microsoft Edge normally'
locale: en-us
document_id: 12c4c577-8a51-3411-481a-bd414c1a0d4d
document_version_independent_id: 12c4c577-8a51-3411-481a-bd414c1a0d4d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ApplicationGuardPassiveModeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/ApplicationGuardPassiveModeEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 234
asset_id: microsoft-edge-policies/applicationguardpassivemodeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ApplicationGuardPassiveModeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 746d37fc-dfb7-4008-79d5-8184ef0f4e26
---

# Microsoft Edge Browser Policy Documentation ApplicationGuardPassiveModeEnabled | Microsoft Learn

## Ignore Application Guard site list configuration and browse Microsoft Edge normally

## Supported versions

- Windows: ≥ 94
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Set whether Microsoft Edge should ignore the Application Guard site list configuration for trusted and untrusted sites.

If you enable this policy, all navigations from Microsoft Edge are accessed normally within Microsoft Edge without redirecting to the Application Guard container, including navigations to untrusted sites. Note: This policy ONLY impacts Microsoft Edge; so, navigations from other browsers are redirected to the Application Guard Container if you have the corresponding extensions enabled.

If you disable or don't configure this policy, Microsoft Edge doesn't ignore the Application Guard site list. If users try to navigate to an untrusted site in the host, the site opens in the container.

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

- GP unique name: ApplicationGuardPassiveModeEnabled
- GP name: Ignore Application Guard site list configuration and browse Microsoft Edge normally
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Application Guard settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ApplicationGuardPassiveModeEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```