---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebRtcIPHandlingUrl | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webrtciphandlingurl
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: WebRTC IP Handling Policy for URL Patterns'
locale: en-us
document_id: ccde182b-384f-c2ce-c4bb-e5adbab1129d
document_version_independent_id: ccde182b-384f-c2ce-c4bb-e5adbab1129d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebRtcIPHandlingUrl.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/WebRtcIPHandlingUrl.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 314
asset_id: microsoft-edge-policies/webrtciphandlingurl
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebRtcIPHandlingUrl.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9ef1fe0c-30bb-cd02-3002-2282ac0062f6
---

# Microsoft Edge Browser Policy Documentation WebRtcIPHandlingUrl | Microsoft Learn

## WebRTC IP Handling Policy for URL Patterns

## Supported versions

- Windows: ≥ 135
- macOS: ≥ 135
- Android: Not supported
- iOS: Not supported

## Description

Controls which IP addresses and network interfaces WebRTC can use when establishing connections for specific URL patterns.

How It Works: Accepts a list of URL patterns, each paired with a handling type. WebRTC evaluates patterns sequentially; the first match determines the handling type. If no match is found, WebRTC defaults to the WebRtcLocalhostIpHandling WebRtcLocalhostIpHandling. policy. This policy applies only to origins—URL path components are ignored. Wildcards (\*) are supported in URL patterns.

Supported Handling Values: default – Uses all available network interfaces. default\_public\_and\_private\_interfaces – WebRTC uses all public and private interfaces. default\_public\_interface\_only – WebRTC uses only public interfaces. disable\_non\_proxied\_udp – WebRTC uses UDP SOCKS proxying or falls back to TCP proxying.

More Information: Valid input patterns: https://go.microsoft.com/fwlink/?linkid=2095322 Handling types: https://tools.ietf.org/html/rfc8828.html#section-5.2

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebRtcIPHandlingUrl
- GP name: WebRTC IP Handling Policy for URL Patterns
- GP path (Mandatory): Administrative Templates/Microsoft Edge/WebRtc settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"handling": "default_public_and_private_interfaces", "url": "https://www.example.com"}, {"handling": "default_public_interface_only", "url": "https://[*.]example.edu"}, {"handling": "disable_non_proxied_udp", "url": "*"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebRtcIPHandlingUrl
- Value type: REG\_SZ

#### Example registry value

```
[{"handling": "default_public_and_private_interfaces", "url": "https://www.example.com"}, {"handling": "default_public_interface_only", "url": "https://[*.]example.edu"}, {"handling": "disable_non_proxied_udp", "url": "*"}]
```

#### Expanded example registry value

```
[
  {
    "handling": "default_public_and_private_interfaces",
    "url": "https://www.example.com"
  },
  {
    "handling": "default_public_interface_only",
    "url": "https://[*.]example.edu"
  },
  {
    "handling": "disable_non_proxied_udp",
    "url": "*"
  }
]
```

## Mac information and settings

- Preference Key name: WebRtcIPHandlingUrl
- Example value:

```xml
<key>WebRtcIPHandlingUrl</key>
<array>
  <dict>
    <key>handling</key>
    <string>default_public_and_private_interfaces</string>
    <key>url</key>
    <string>https://www.example.com</string>
  </dict>
  <dict>
    <key>handling</key>
    <string>default_public_interface_only</string>
    <key>url</key>
    <string>https://[*.]example.edu</string>
  </dict>
  <dict>
    <key>handling</key>
    <string>disable_non_proxied_udp</string>
    <key>url</key>
    <string>*</string>
  </dict>
</array>
```