---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RoamingProfileSupportEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/roamingprofilesupportenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable using roaming copies for Microsoft Edge profile data'
locale: en-us
document_id: 2b218260-8536-5568-adf1-16a2f5eac8eb
document_version_independent_id: 2b218260-8536-5568-adf1-16a2f5eac8eb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RoamingProfileSupportEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RoamingProfileSupportEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 208
asset_id: microsoft-edge-policies/roamingprofilesupportenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RoamingProfileSupportEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 96521b54-0439-2319-8755-d159f3121b05
---

# Microsoft Edge Browser Policy Documentation RoamingProfileSupportEnabled | Microsoft Learn

## Enable using roaming copies for Microsoft Edge profile data

## Supported versions

- Windows: ≥ 85
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Enable this policy to use roaming profiles on Windows. The settings stored in Microsoft Edge profiles (favorites and preferences) are also saved to a file stored in the Roaming user profile folder (or the location specified by the administrator through the [RoamingProfileLocation](roamingprofilelocation) policy).

If you disable this policy or don't configure it, only the regular local profiles are used.

The [SyncDisabled](syncdisabled) only disables cloud synchronization and has no effect on this policy.

For more information on using roaming user profiles, see https://go.microsoft.com/fwlink/?linkid=2150058.

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

- GP unique name: RoamingProfileSupportEnabled
- GP name: Enable using roaming copies for Microsoft Edge profile data
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
- Value name: RoamingProfileSupportEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```