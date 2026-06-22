---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoplayAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autoplayallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow media autoplay for websites'
locale: en-us
document_id: 22856d08-8544-fc2b-8b5e-b56c32fbcc1b
document_version_independent_id: 22856d08-8544-fc2b-8b5e-b56c32fbcc1b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoplayAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/AutoplayAllowed.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/autoplayallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoplayAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c2c29a68-12b6-74f6-405f-fde4eb8a0030
---

# Microsoft Edge Browser Policy Documentation AutoplayAllowed | Microsoft Learn

## Allow media autoplay for websites

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: Not supported
- iOS: Not supported

## Description

This policy controls media autoplay behavior for websites.

If you don't configure this policy, Microsoft Edge uses the current media autoplay setting, and users can change their autoplay settings.

If you enable this policy, media autoplay is set to "Allow". All websites can autoplay media, and users can't override this setting.

If you disable this policy, media autoplay is set to "Limit" in Microsoft Edge version 148 and later. Autoplay is limited to webpages with high media engagement or active WebRTC streams, and users can't override this setting.

In versions 92 through 145, disabling this policy also set autoplay to "Limit". In versions 146 and 147, disabling this policy set autoplay to "Block".

Tabs must be closed and reopened for this policy to take effect.

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

- GP unique name: AutoplayAllowed
- GP name: Allow media autoplay for websites
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AutoplayAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AutoplayAllowed
- Example value:

```xml
<true/>
```