---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionDeveloperModeSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensiondevelopermodesettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the availability of developer mode on extensions page'
locale: en-us
document_id: b0593061-abd8-9d41-b7b4-91f8a408f61d
document_version_independent_id: b0593061-abd8-9d41-b7b4-91f8a408f61d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionDeveloperModeSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/ExtensionDeveloperModeSettings.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 298
asset_id: microsoft-edge-policies/extensiondevelopermodesettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionDeveloperModeSettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9f09c3b6-9d7b-7bb1-af3a-fc35d47b6e4c
---

# Microsoft Edge Browser Policy Documentation ExtensionDeveloperModeSettings | Microsoft Learn

## Control the availability of developer mode on extensions page

## Supported versions

- Windows: ≥ 128
- macOS: ≥ 128
- Android: Not supported
- iOS: Not supported

## Description

Control if users can turn on Developer Mode on edge://extensions.

If the policy isn't set, users can turn on developer mode on the extension page unless DeveloperToolsAvailability policy is set to DeveloperToolsDisallowed (2). If the policy is set to Allow (0), users can turn on developer mode on the extensions page. If the policy is set to Disallow (1), users can't turn on developer mode on the extensions page.

If this policy is set, DeveloperToolsAvailability can no longer control extensions developer mode.

Policy options mapping:

- Allow (0) = Allow the usage of developer mode on extensions page
- Disallow (1) = Do not allow the usage of developer mode on extensions page

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Allow (0) = Allow the usage of developer mode on extensions page
- Disallow (1) = Do not allow the usage of developer mode on extensions page

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionDeveloperModeSettings
- GP name: Control the availability of developer mode on extensions page
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not allow the usage of developer mode on extensions page
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ExtensionDeveloperModeSettings
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ExtensionDeveloperModeSettings
- Example value:

```xml
<integer>1</integer>
```