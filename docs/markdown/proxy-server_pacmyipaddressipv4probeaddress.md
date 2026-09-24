---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PacMyIpAddressIPv4ProbeAddress | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/pacmyipaddressipv4probeaddress
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-08-05T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the IPv4 route-probe address for PAC scripts'
locale: en-us
document_id: 5e6a2184-e2db-e63b-6162-8e5bde9a0112
document_version_independent_id: 5e6a2184-e2db-e63b-6162-8e5bde9a0112
updated_at: 2026-08-05T22:47:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PacMyIpAddressIPv4ProbeAddress.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/2a7d54003b65970728477e7826af3ddf75dacaf3/edgeenterprise/microsoft-edge-policies/PacMyIpAddressIPv4ProbeAddress.md
git_commit_id: 2a7d54003b65970728477e7826af3ddf75dacaf3
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 284
asset_id: microsoft-edge-policies/pacmyipaddressipv4probeaddress
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PacMyIpAddressIPv4ProbeAddress.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8f2ac391-82b5-281e-815f-4c38ec4ae77f
---

# Microsoft Edge Browser Policy Documentation PacMyIpAddressIPv4ProbeAddress | Microsoft Learn

## Set the IPv4 route-probe address for PAC scripts

## Supported versions

- Windows: ≥ 153
- macOS: ≥ 153
- Android: Not supported
- iOS: Not supported

## Description

This policy sets the IPv4 destination that Microsoft Edge uses to determine the local network address or addresses returned to PAC scripts by the myIpAddress() and myIpAddressEx() helper functions. The route probe sends no application data.

This policy applies only when Microsoft Edge uses its built-in proxy resolver to evaluate PAC scripts. It doesn't apply when a native or system resolver is used.

If you configure this policy, set it to a valid IPv4 address literal. Host names, malformed values, IPv6 addresses, loopback addresses, link-local addresses, and multicast addresses are rejected. Addresses in 0.0.0.0/8, the reserved 240.0.0.0/4 range, and the limited broadcast address are also rejected. Private addresses are supported.

If you don't configure this policy or configure it with an empty string, Microsoft Edge uses its built-in default IPv4 destination. The built-in destination can change between versions.

A browser restart is required for changes to take effect.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PacMyIpAddressIPv4ProbeAddress
- GP name: Set the IPv4 route-probe address for PAC scripts
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
192.0.2.1
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PacMyIpAddressIPv4ProbeAddress
- Value type: REG\_SZ

#### Example registry value

```
192.0.2.1
```

## Mac information and settings

- Preference Key name: PacMyIpAddressIPv4ProbeAddress
- Example value:

```xml
<string>192.0.2.1</string>
```