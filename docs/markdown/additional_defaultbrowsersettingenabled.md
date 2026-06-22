---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultBrowserSettingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultbrowsersettingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set Microsoft Edge as default browser'
locale: en-us
document_id: 2a74672d-fad8-351c-030a-aea34c267054
document_version_independent_id: 2a74672d-fad8-351c-030a-aea34c267054
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultBrowserSettingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DefaultBrowserSettingEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 282
asset_id: microsoft-edge-policies/defaultbrowsersettingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultBrowserSettingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7dd47580-d9a7-2a9c-3aa1-b7e5adc75ac2
---

# Microsoft Edge Browser Policy Documentation DefaultBrowserSettingEnabled | Microsoft Learn

## Set Microsoft Edge as default browser

## Supported versions

- Windows 7: ≥ 77
- macOS: ≥ 77
- Android: ≥ 124
- iOS: ≥ 124

## Description

If you set this policy to True, Microsoft Edge always checks whether it's the default browser on startup and, if possible, automatically registers itself.

If you set this policy to False, Microsoft Edge is stopped from ever checking if it's the default and turns user controls off for this option.

If you don't set this policy, Microsoft Edge lets users control whether it's the default and, if not, whether user notifications should appear.

Note for Windows administrators: This policy only works for PCs running Windows 7. For later versions of Windows, you have to deploy a "default application associations" file that makes Microsoft Edge the handler for the https and http protocols (and, optionally, the ftp protocol and file formats such as .html, .htm, .pdf, .svg, .webp). See https://go.microsoft.com/fwlink/?linkid=2094932 for more information.

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

- GP unique name: DefaultBrowserSettingEnabled
- GP name: Set Microsoft Edge as default browser
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
- Value name: DefaultBrowserSettingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultBrowserSettingEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: DefaultBrowserSettingEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: DefaultBrowserSettingEnabled
- Example value:

```xml
<true/>
```