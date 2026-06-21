---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebRtcLocalIpsAllowedUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webrtclocalipsallowedurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Manage exposure of local IP addressess by WebRTC'
locale: en-us
document_id: 8f96509e-75c0-d2ff-b889-774043ca98c7
document_version_independent_id: 8f96509e-75c0-d2ff-b889-774043ca98c7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebRtcLocalIpsAllowedUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebRtcLocalIpsAllowedUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 273
asset_id: microsoft-edge-policies/webrtclocalipsallowedurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebRtcLocalIpsAllowedUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 65f83f36-8e18-ca3f-510a-4a0e448e3c6a
---

# Microsoft Edge Browser Policy Documentation WebRtcLocalIpsAllowedUrls | Microsoft Learn

## Manage exposure of local IP addressess by WebRTC

## Supported versions

- Windows: ≥ 80
- macOS: ≥ 80
- Android: Not supported
- iOS: Not supported

## Description

Specifies a list of origins (URLs) or hostname patterns (like "*contoso.com*") for which local IP address should be exposed by WebRTC.

If you enable this policy and set a list of origins (URLs) or hostname patterns, when edge://flags/#enable-webrtc-hide-local-ips-with-mdns is Enabled, WebRTC will expose the local IP address for cases that match patterns in the list.

If you disable or don't configure this policy, and edge://flags/#enable-webrtc-hide-local-ips-with-mdns is Enabled, WebRTC will not expose local IP addresses. The local IP address is concealed with an mDNS hostname.

If you enable, disable, or don't configure this policy, and edge://flags/#enable-webrtc-hide-local-ips-with-mdns is Disabled, WebRTC will expose local IP addresses.

Please note that this policy weakens the protection of local IP addresses that might be needed by administrators.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebRtcLocalIpsAllowedUrls
- GP name: Manage exposure of local IP addressess by WebRTC
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
*contoso.com*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WebRtcLocalIpsAllowedUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WebRtcLocalIpsAllowedUrls\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\WebRtcLocalIpsAllowedUrls\2 =

```
*contoso.com*
```

## Mac information and settings

- Preference Key name: WebRtcLocalIpsAllowedUrls
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>*contoso.com*</string>
</array>
```