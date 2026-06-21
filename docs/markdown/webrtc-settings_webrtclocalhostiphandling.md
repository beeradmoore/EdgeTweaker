---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebRtcLocalhostIpHandling | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webrtclocalhostiphandling
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict exposure of local IP address by WebRTC'
locale: en-us
document_id: fcb240dd-aea8-363f-a07b-16eea47cb264
document_version_independent_id: fcb240dd-aea8-363f-a07b-16eea47cb264
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebRtcLocalhostIpHandling.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebRtcLocalhostIpHandling.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 367
asset_id: microsoft-edge-policies/webrtclocalhostiphandling
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebRtcLocalhostIpHandling.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d2ff3257-220a-d93b-66eb-b1b42ee9c0bc
---

# Microsoft Edge Browser Policy Documentation WebRtcLocalhostIpHandling | Microsoft Learn

## Restrict exposure of local IP address by WebRTC

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Allows you to set whether or not WebRTC exposes the user's local IP address.

If you set this policy to "AllowAllInterfaces" or "AllowPublicAndPrivateInterfaces", WebRTC exposes the local IP address.

If you set this policy to "AllowPublicInterfaceOnly" or "DisableNonProxiedUdp", WebRTC doesn't expose the local IP address.

If you don't set this policy, or if you disable it, WebRTC exposes the local IP address.

Note that this policy doesn't provide an option to exclude specific domains.

Policy options mapping:

- AllowAllInterfaces (default) = Allow all interfaces. This exposes the local IP address
- AllowPublicAndPrivateInterfaces (default\_public\_and\_private\_interfaces) = Allow public and private interfaces over http default route. This exposes the local IP address
- AllowPublicInterfaceOnly (default\_public\_interface\_only) = Allow public interface over http default route. This doesn't expose the local IP address
- DisableNonProxiedUdp (disable\_non\_proxied\_udp) = Use TCP unless proxy server supports UDP. This doesn't expose the local IP address

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowAllInterfaces (default) = Allow all interfaces. This exposes the local IP address
- AllowPublicAndPrivateInterfaces (default\_public\_and\_private\_interfaces) = Allow public and private interfaces over http default route. This exposes the local IP address
- AllowPublicInterfaceOnly (default\_public\_interface\_only) = Allow public interface over http default route. This doesn't expose the local IP address
- DisableNonProxiedUdp (disable\_non\_proxied\_udp) = Use TCP unless proxy server supports UDP. This doesn't expose the local IP address

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

- GP unique name: WebRtcLocalhostIpHandling
- GP name: Restrict exposure of local IP address by WebRTC
- GP path (Mandatory): Administrative Templates/Microsoft Edge/WebRtc settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow all interfaces. This exposes the local IP address
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebRtcLocalhostIpHandling
- Value type: REG\_SZ

#### Example registry value

```
default
```

## Mac information and settings

- Preference Key name: WebRtcLocalhostIpHandling
- Example value:

```xml
<string>default</string>
```