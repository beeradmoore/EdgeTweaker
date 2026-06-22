---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DynamicCodeSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/dynamiccodesettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Dynamic Code Settings'
locale: en-us
document_id: 57f56c24-2819-56fd-2073-ffe564a99117
document_version_independent_id: 57f56c24-2819-56fd-2073-ffe564a99117
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DynamicCodeSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DynamicCodeSettings.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 274
asset_id: microsoft-edge-policies/dynamiccodesettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DynamicCodeSettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/68cb9039-df60-49b0-8ef8-89ad96497f63
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/725b6df3-93e8-472d-834e-e7e0d2953d35
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f348261d-fd4b-f87a-8c6b-385762e53e63
---

# Microsoft Edge Browser Policy Documentation DynamicCodeSettings | Microsoft Learn

## Dynamic Code Settings

## Supported versions

- Windows: ≥ 128
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls the dynamic code settings for Microsoft Edge.

Disabling dynamic code improves the security of Microsoft Edge by preventing potentially hostile dynamic code and third-party code from making changes to Microsoft Edge's behavior. However this might cause compatibility issues with third-party software (for example, certain printer drivers) that must run in the browser process.

If you set this policy to 0 (the default) or leave unset, then Microsoft Edge uses the default settings.

If you set this policy to 1 – (EnabledForBrowser) then the Microsoft Edge browser process is prevented from creating dynamic code.

Policy options mapping:

- Default (0) = Default dynamic code settings
- EnabledForBrowser (1) = Prevent the browser process from creating dynamic code

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Default dynamic code settings
- EnabledForBrowser (1) = Prevent the browser process from creating dynamic code

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DynamicCodeSettings
- GP name: Dynamic Code Settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Prevent the browser process from creating dynamic code
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DynamicCodeSettings
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```