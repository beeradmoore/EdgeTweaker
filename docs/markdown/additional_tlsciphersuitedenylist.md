---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TLSCipherSuiteDenyList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/tlsciphersuitedenylist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specify the TLS cipher suites to disable'
locale: en-us
document_id: 6f2cc8f5-32ff-00ce-a511-a2ad1f8610e4
document_version_independent_id: 6f2cc8f5-32ff-00ce-a511-a2ad1f8610e4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TLSCipherSuiteDenyList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/TLSCipherSuiteDenyList.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 253
asset_id: microsoft-edge-policies/tlsciphersuitedenylist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TLSCipherSuiteDenyList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c6e24ecb-6f26-1bf4-ba50-22902fa8e93b
---

# Microsoft Edge Browser Policy Documentation TLSCipherSuiteDenyList | Microsoft Learn

## Specify the TLS cipher suites to disable

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 85
- Android: Not supported
- iOS: Not supported

## Description

Configure the list of cipher suites that are disabled for TLS connections.

If you configure this policy, the list of configured cipher suites won't be used when establishing TLS connections.

If you don't configure this policy, the browser chooses which TLS cipher suites to use.

Cipher suite values to be disabled are specified as 16-bit hexadecimal values. The values are assigned by the Internet Assigned Numbers Authority (IANA) registry.

The TLS 1.3 cipher suite TLS\_AES\_128\_GCM\_SHA256 (0x1301) is required for TLS 1.3 and can't be disabled by this policy.

This policy does not affect QUIC-based connections. QUIC can be turned off via the [QuicAllowed](quicallowed) policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: TLSCipherSuiteDenyList
- GP name: Specify the TLS cipher suites to disable
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
0x1303
```

```
0xcca8
```

```
0xcca9
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\TLSCipherSuiteDenyList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\TLSCipherSuiteDenyList\1 =

```
0x1303
```

SOFTWARE\Policies\Microsoft\Edge\TLSCipherSuiteDenyList\2 =

```
0xcca8
```

SOFTWARE\Policies\Microsoft\Edge\TLSCipherSuiteDenyList\3 =

```
0xcca9
```

## Mac information and settings

- Preference Key name: TLSCipherSuiteDenyList
- Example value:

```xml
<array>
  <string>0x1303</string>
  <string>0xcca8</string>
  <string>0xcca9</string>
</array>
```