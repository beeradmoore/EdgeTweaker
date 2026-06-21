---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultSerialGuardSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultserialguardsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control use of the Serial API'
locale: en-us
document_id: 7b8ba093-9dbf-1803-7076-13082e2451ed
document_version_independent_id: 7b8ba093-9dbf-1803-7076-13082e2451ed
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultSerialGuardSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultSerialGuardSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 331
asset_id: microsoft-edge-policies/defaultserialguardsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultSerialGuardSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 91764d11-6206-bf66-6c57-7cd6a022b9bb
---

# Microsoft Edge Browser Policy Documentation DefaultSerialGuardSetting | Microsoft Learn

## Control use of the Serial API

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: ≥ 147
- iOS: Not supported

## Description

Set whether websites can access serial ports. You can completely block access or ask the user each time a website wants to get access to a serial port.

Setting the policy to 3 lets websites ask for access to serial ports. Setting the policy to 2 denies access to serial ports.

You can override this policy for specific URL patterns by using the [SerialAskForUrls](serialaskforurls) and [SerialBlockedForUrls](serialblockedforurls) policies.

If you don't configure this policy, by default, websites can ask users whether they can access a serial port, and users can change this setting.

Policy options mapping:

- BlockSerial (2) = Do not allow any site to request access to serial ports via the Serial API
- AskSerial (3) = Allow sites to ask for user permission to access a serial port

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockSerial (2) = Do not allow any site to request access to serial ports via the Serial API
- AskSerial (3) = Allow sites to ask for user permission to access a serial port

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

- GP unique name: DefaultSerialGuardSetting
- GP name: Control use of the Serial API
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not allow any site to request access to serial ports via the Serial API
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultSerialGuardSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultSerialGuardSetting
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: DefaultSerialGuardSetting
- Example value:

```
2
```