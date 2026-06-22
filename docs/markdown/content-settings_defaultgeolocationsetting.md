---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultGeolocationSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultgeolocationsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default geolocation setting'
locale: en-us
document_id: 63fbf6ea-ecfb-d25b-d46e-97844d7ce453
document_version_independent_id: 63fbf6ea-ecfb-d25b-d46e-97844d7ce453
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultGeolocationSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DefaultGeolocationSetting.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 277
asset_id: microsoft-edge-policies/defaultgeolocationsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultGeolocationSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a1a095f4-1e00-0571-44fd-f94902bd65fb
---

# Microsoft Edge Browser Policy Documentation DefaultGeolocationSetting | Microsoft Learn

## Default geolocation setting

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Set whether websites can track users' physical locations. You can allow tracking by default ('AllowGeolocation'), deny it by default ('BlockGeolocation'), or ask the user each time a website requests their location ('AskGeolocation').

If you don't configure this policy, 'AskGeolocation' is used and the user can change it.

Policy options mapping:

- AllowGeolocation (1) = Allow sites to track users' physical location
- BlockGeolocation (2) = Don't allow any site to track users' physical location
- AskGeolocation (3) = Ask whenever a site wants to track users' physical location

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowGeolocation (1) = Allow sites to track users' physical location
- BlockGeolocation (2) = Don't allow any site to track users' physical location
- AskGeolocation (3) = Ask whenever a site wants to track users' physical location

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultGeolocationSetting
- GP name: Default geolocation setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow sites to track users' physical location
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultGeolocationSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultGeolocationSetting
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: DefaultGeolocationSetting
- Example value:

```
1
```