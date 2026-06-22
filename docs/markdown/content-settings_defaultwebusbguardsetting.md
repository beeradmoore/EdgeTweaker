---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultWebUsbGuardSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultwebusbguardsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control use of the WebUSB API'
locale: en-us
document_id: 02cc5b1b-6ef3-9e37-2e41-b2d5d356d828
document_version_independent_id: 02cc5b1b-6ef3-9e37-2e41-b2d5d356d828
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultWebUsbGuardSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/DefaultWebUsbGuardSetting.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 316
asset_id: microsoft-edge-policies/defaultwebusbguardsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultWebUsbGuardSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0b8a6f29-1dc6-af71-892a-415444c4bc5a
---

# Microsoft Edge Browser Policy Documentation DefaultWebUsbGuardSetting | Microsoft Learn

## Control use of the WebUSB API

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Set whether websites can access connected USB devices. You can completely block access or ask the user each time a website wants to get access to connected USB devices.

You can override this policy for specific URL patterns by using the [WebUsbAskForUrls](webusbaskforurls) and [WebUsbBlockedForUrls](webusbblockedforurls) policies.

If you don't configure this policy, sites can ask users whether they can access the connected USB devices ('AskWebUsb') by default, and users can change this setting.

Policy options mapping:

- BlockWebUsb (2) = Do not allow any site to request access to USB devices via the WebUSB API
- AskWebUsb (3) = Allow sites to ask the user to grant access to a connected USB device

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockWebUsb (2) = Do not allow any site to request access to USB devices via the WebUSB API
- AskWebUsb (3) = Allow sites to ask the user to grant access to a connected USB device

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

- GP unique name: DefaultWebUsbGuardSetting
- GP name: Control use of the WebUSB API
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not allow any site to request access to USB devices via the WebUSB API
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultWebUsbGuardSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultWebUsbGuardSetting
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: DefaultWebUsbGuardSetting
- Example value:

```
2
```