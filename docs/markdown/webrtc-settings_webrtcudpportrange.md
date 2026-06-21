---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebRtcUdpPortRange | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webrtcudpportrange
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict the range of local UDP ports used by WebRTC'
locale: en-us
document_id: 93542939-6d9c-ad9d-612a-82beea35a87b
document_version_independent_id: 93542939-6d9c-ad9d-612a-82beea35a87b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebRtcUdpPortRange.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebRtcUdpPortRange.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 208
asset_id: microsoft-edge-policies/webrtcudpportrange
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebRtcUdpPortRange.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 1ad0df18-dfb1-5893-c6a7-2a419beb66b2
---

# Microsoft Edge Browser Policy Documentation WebRtcUdpPortRange | Microsoft Learn

## Restrict the range of local UDP ports used by WebRTC

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 140
- iOS: Not supported

## Description

Restricts the UDP port range used by WebRTC to a specified port interval (endpoints included).

By configuring this policy, you specify the range of local UDP ports that WebRTC can use.

If you don't configure this policy, or if you set it to an empty string or invalid port range, WebRTC can use any available local UDP port.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebRtcUdpPortRange
- GP name: Restrict the range of local UDP ports used by WebRTC
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
10000-11999
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebRtcUdpPortRange
- Value type: REG\_SZ

#### Example registry value

```
10000-11999
```

## Mac information and settings

- Preference Key name: WebRtcUdpPortRange
- Example value:

```xml
<string>10000-11999</string>
```

## Android information and settings

- Preference Key name: WebRtcUdpPortRange
- Example value:

```
10000-11999
```