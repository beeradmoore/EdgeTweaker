---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HideFirstRunExperience | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/hidefirstrunexperience
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Hide the First-run experience and splash screen'
locale: en-us
document_id: f8bcf6bb-18d1-de48-bcf2-d02c2609ee26
document_version_independent_id: f8bcf6bb-18d1-de48-bcf2-d02c2609ee26
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HideFirstRunExperience.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/HideFirstRunExperience.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 357
asset_id: microsoft-edge-policies/hidefirstrunexperience
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HideFirstRunExperience.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ec1e2c96-380a-e58e-9085-24e2d4f0aa7b
---

# Microsoft Edge Browser Policy Documentation HideFirstRunExperience | Microsoft Learn

## Hide the First-run experience and splash screen

## Supported versions

- Windows: ≥ 80
- macOS: ≥ 80
- Android: ≥ 124
- iOS: ≥ 124

## Description

If you enable this policy, the First-run experience and the splash screen won't be shown to users when they run Microsoft Edge for the first time.

For the configuration options shown in the First Run Experience, the browser defaults to the following results:

-On the New Tab Page, the feed type is set to MSN News and the layout to Inspirational.

-The user is still automatically signed in to Microsoft Edge if the Windows account is of Azure AD or MSA type.

-Sync won't be enabled by default and users will be prompted to choose whether they'd like to sync on browser startup. You can use the [ForceSync](forcesync) or the [SyncDisabled](syncdisabled) policy to configure sync and the sync consent prompt.

If you disable or don't configure this policy, the First-run experience and the Splash screen will be shown.

Note: The specific configuration options shown to the user in the First Run Experience, can also be managed by using other specific policies. You can use the HideFirstRunExperience policy in combination with these policies to configure a specific browser experience on your managed devices. Some of these other policies are:

-[AutoImportAtFirstRun](autoimportatfirstrun)

-[NewTabPageLocation](newtabpagelocation)

-[NewTabPageSetFeedType](newtabpagesetfeedtype)

-[ForceSync](forcesync)

-[SyncDisabled](syncdisabled)

-[BrowserSignin](browsersignin)

-[NonRemovableProfileEnabled](nonremovableprofileenabled)

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

- GP unique name: HideFirstRunExperience
- GP name: Hide the First-run experience and splash screen
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
- Value name: HideFirstRunExperience
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: HideFirstRunExperience
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: HideFirstRunExperience
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: HideFirstRunExperience
- Example value:

```xml
<true/>
```