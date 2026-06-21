---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceEphemeralProfiles | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forceephemeralprofiles
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable use of ephemeral profiles'
locale: en-us
document_id: dc89601e-ff08-34e4-1627-7606abc05426
document_version_independent_id: dc89601e-ff08-34e4-1627-7606abc05426
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceEphemeralProfiles.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ForceEphemeralProfiles.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 324
asset_id: microsoft-edge-policies/forceephemeralprofiles
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceEphemeralProfiles.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 59b8604d-f7b4-cc4c-8008-9b92e46ffd8c
---

# Microsoft Edge Browser Policy Documentation ForceEphemeralProfiles | Microsoft Learn

## Enable use of ephemeral profiles

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Controls whether user profiles are switched to ephemeral mode. An ephemeral profile is created when a session begins, is deleted when the session ends, and is associated with the user's original profile.

If you enable this policy, profiles run in ephemeral mode. This setting lets users work from their own devices without saving browsing data to those devices. If you enable this policy as an OS policy (by using GPO on Windows, for example), it applies to every profile on the system.

If you disable this policy or don't configure it, users get their regular profiles when they sign in to the browser.

In ephemeral mode, profile data is saved on disk only for the length of the user session. Features like browser history, extensions and their data, web data like cookies, and web databases aren't saved after the browser is closed. This setting doesn't prevent a user from manually downloading any data to disk, or from saving pages or printing them. If the user enabled sync, all data is preserved in their sync accounts just like with regular profiles. Users can also use InPrivate browsing in ephemeral mode unless you explicitly disable this setting.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceEphemeralProfiles
- GP name: Enable use of ephemeral profiles
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
- Value name: ForceEphemeralProfiles
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ForceEphemeralProfiles
- Example value:

```xml
<true/>
```