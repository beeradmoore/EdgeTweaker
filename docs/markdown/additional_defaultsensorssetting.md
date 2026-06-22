---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultSensorsSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultsensorssetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default sensors setting'
locale: en-us
document_id: dd42c146-2a81-7399-d802-985880e6e8c8
document_version_independent_id: dd42c146-2a81-7399-d802-985880e6e8c8
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultSensorsSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/DefaultSensorsSetting.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 288
asset_id: microsoft-edge-policies/defaultsensorssetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultSensorsSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5317110e-4d58-d71c-99ef-7c5cd9d46b1c
---

# Microsoft Edge Browser Policy Documentation DefaultSensorsSetting | Microsoft Learn

## Default sensors setting

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: ≥ 138
- iOS: Not supported

## Description

Set whether websites can access and use sensors such as motion and light sensors. You can completely block or allow websites to get access to sensors.

Setting the policy to 1 lets websites access and use sensors. Setting the policy to 2 denies access to sensors.

You can override this policy for specific URL patterns by using the [SensorsAllowedForUrls](sensorsallowedforurls) and [SensorsBlockedForUrls](sensorsblockedforurls) policies.

If you don't configure this policy, websites can access and use sensors, and users can change this setting. This setting is the global default for [SensorsAllowedForUrls](sensorsallowedforurls) and [SensorsBlockedForUrls](sensorsblockedforurls).

Policy options mapping:

- AllowSensors (1) = Allow sites to access sensors
- BlockSensors (2) = Do not allow any site to access sensors

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowSensors (1) = Allow sites to access sensors
- BlockSensors (2) = Do not allow any site to access sensors

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

- GP unique name: DefaultSensorsSetting
- GP name: Default sensors setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not allow any site to access sensors
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultSensorsSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultSensorsSetting
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: DefaultSensorsSetting
- Example value:

```
2
```