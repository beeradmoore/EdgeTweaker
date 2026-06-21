---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalNetworkAccessIpAddressSpaceOverrides | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localnetworkaccessipaddressspaceoverrides
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Override IP address space mappings'
locale: en-us
document_id: b09c2b75-5c57-cf51-ca40-0aba15bdfce6
document_version_independent_id: b09c2b75-5c57-cf51-ca40-0aba15bdfce6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessIpAddressSpaceOverrides.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessIpAddressSpaceOverrides.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 257
asset_id: microsoft-edge-policies/localnetworkaccessipaddressspaceoverrides
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalNetworkAccessIpAddressSpaceOverrides.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: fd4c3c97-41d1-ec9b-1756-fadfecdd3b16
---

# Microsoft Edge Browser Policy Documentation LocalNetworkAccessIpAddressSpaceOverrides | Microsoft Learn

## Override IP address space mappings

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

Specifies IP address space overrides for Local Network Access restrictions. This policy allows administrators to treat specific IP address ranges as public (exempt from Local Network Access restrictions) or as local (subject to Local Network Access restrictions).

IP address space overrides can be specified using one of the following formats:

• [cidr]=[public|local|loopback] where [cidr] is an IP address range in CIDR notation. CIDR overrides apply to all ports.

• [ip-address]:[port]=[public|local|loopback]

IPv6 addresses must be specified in URL-safe (bracketed) format.

For more information about Local Network Access, see https://wicg.github.io/local-network-access/.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: LocalNetworkAccessIpAddressSpaceOverrides
- GP name: Override IP address space mappings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
100.64.0.0/10=public
```

```
[2001:db8::]/32=local
```

```
192.168.0.1:8000=public
```

```
[2001:DB8::8:800:200C:417A]:8080=local
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessIpAddressSpaceOverrides
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessIpAddressSpaceOverrides\1 =

```
100.64.0.0/10=public
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessIpAddressSpaceOverrides\2 =

```
[2001:db8::]/32=local
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessIpAddressSpaceOverrides\3 =

```
192.168.0.1:8000=public
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessIpAddressSpaceOverrides\4 =

```
[2001:DB8::8:800:200C:417A]:8080=local
```

## Mac information and settings

- Preference Key name: LocalNetworkAccessIpAddressSpaceOverrides
- Example value:

```xml
<array>
  <string>100.64.0.0/10=public</string>
  <string>[2001:db8::]/32=local</string>
  <string>192.168.0.1:8000=public</string>
  <string>[2001:DB8::8:800:200C:417A]:8080=local</string>
</array>
```

## Android information and settings

- Preference Key name: LocalNetworkAccessIpAddressSpaceOverrides
- Example value:

```
["100.64.0.0/10=public", "[2001:db8::]/32=local", "192.168.0.1:8000=public", "[2001:DB8::8:800:200C:417A]:8080=local"]
```