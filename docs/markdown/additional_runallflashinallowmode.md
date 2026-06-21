---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RunAllFlashInAllowMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/runallflashinallowmode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Extend Adobe Flash content setting to all content (obsolete)'
locale: en-us
document_id: 2efa1f68-1224-d504-b164-85caba9e248c
document_version_independent_id: 2efa1f68-1224-d504-b164-85caba9e248c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RunAllFlashInAllowMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RunAllFlashInAllowMode.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 248
asset_id: microsoft-edge-policies/runallflashinallowmode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RunAllFlashInAllowMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e10ee774-8b42-9d94-7e4c-e1b5afc37f20
---

# Microsoft Edge Browser Policy Documentation RunAllFlashInAllowMode | Microsoft Learn

## Extend Adobe Flash content setting to all content (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 88.

## Supported versions

- Windows: 77-88
- macOS: 77-88
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because Flash is no longer supported by Microsoft Edge.

If you enable this policy, all Adobe Flash content embedded in websites that are set to allow Adobe Flash in the content settings, either by the user or by enterprise policy, run. This includes content from other origins and/or small content.

To control which websites are allowed to run Adobe Flash, see the specifications in the [DefaultPluginsSetting](defaultpluginssetting), [PluginsAllowedForUrls](pluginsallowedforurls), and [PluginsBlockedForUrls](pluginsblockedforurls) policies.

If you disable this policy or don't configure it, Adobe Flash content from other origins (sites that aren't specified in the preceding three policies) or small content might be blocked.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RunAllFlashInAllowMode
- GP name: Extend Adobe Flash content setting to all content (obsolete)
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
- Value name: RunAllFlashInAllowMode
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: RunAllFlashInAllowMode
- Example value:

```xml
<true/>
```