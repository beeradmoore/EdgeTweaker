---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultPluginsSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultpluginssetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default Adobe Flash setting (obsolete)'
locale: en-us
document_id: 93122456-e968-a684-b392-b0f47a8b6d35
document_version_independent_id: 93122456-e968-a684-b392-b0f47a8b6d35
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultPluginsSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/DefaultPluginsSetting.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 290
asset_id: microsoft-edge-policies/defaultpluginssetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultPluginsSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7b0f4f17-c7fd-7e47-5311-78f76ba4e37f
---

# Microsoft Edge Browser Policy Documentation DefaultPluginsSetting | Microsoft Learn

## Default Adobe Flash setting (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 87.

## Supported versions

- Windows: 77-87
- macOS: 77-87
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because Flash is no longer supported by Microsoft Edge.

[PluginsAllowedForUrls](pluginsallowedforurls) and [PluginsBlockedForUrls](pluginsblockedforurls) are checked first, then this policy. The options are 'ClickToPlay' and 'BlockPlugins'. If you set this policy to 'BlockPlugins', this plugin is denied for all websites. 'ClickToPlay' lets the Flash plugin run, but users click the placeholder to start it.

If you don't configure this policy, the user can change this setting manually.

Note: Automatic playback is only for domains explicitly listed in the [PluginsAllowedForUrls](pluginsallowedforurls) policy. To turn automatic playback on for all sites, add http://\* and https://\* to the allowed list of URLs.

Policy options mapping:

- BlockPlugins (2) = Block the Adobe Flash plugin
- ClickToPlay (3) = Click to play

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockPlugins (2) = Block the Adobe Flash plugin
- ClickToPlay (3) = Click to play

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

- GP unique name: DefaultPluginsSetting
- GP name: Default Adobe Flash setting (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Block the Adobe Flash plugin
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultPluginsSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultPluginsSetting
- Example value:

```xml
<integer>2</integer>
```