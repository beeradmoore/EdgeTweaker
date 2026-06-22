---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/controldefaultstateofallowextensionfromotherstoressettingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure default state of Allow extensions from other stores setting'
locale: en-us
document_id: bbdd9c3d-6f7f-06fb-0b99-e70f5043f8bd
document_version_independent_id: bbdd9c3d-6f7f-06fb-0b99-e70f5043f8bd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 294
asset_id: microsoft-edge-policies/controldefaultstateofallowextensionfromotherstoressettingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1d9e80db-24a7-03ba-527b-a9dc6fe02b4a
---

# Microsoft Edge Browser Policy Documentation ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled | Microsoft Learn

## Configure default state of Allow extensions from other stores setting

## Supported versions

- Windows: ≥ 101
- macOS: ≥ 101
- Android: Not supported
- iOS: Not supported

## Description

This policy allows you to control the default state of the Allow extensions from other stores setting. This policy can't be used to stop installation of extensions from other stores such as Chrome Web Store. To stop installation of extensions from other stores, use the Extension Settings policy: https://go.microsoft.com/fwlink/?linkid=2187098.

When enabled, Allow extensions from other stores are turned on. So, users don't have to turn on the flag manually while installing extensions from other supported stores such as Chrome Web Store. However a user can override this setting. If the user turned on the setting and then turned it off, this setting may not work. If the Admin first sets the policy as Enabled, but then changes it to not configured or disabled, it has no impact on user settings and the setting remains as it is.

When disabled or not configured, the user can manage the Allow extensions from other store setting.

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled
- GP name: Configure default state of Allow extensions from other stores setting
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Extensions
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ControlDefaultStateOfAllowExtensionFromOtherStoresSettingEnabled
- Example value:

```xml
<true/>
```