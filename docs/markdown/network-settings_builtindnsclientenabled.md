---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BuiltInDnsClientEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/builtindnsclientenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Use built-in DNS client'
locale: en-us
document_id: 900a8cd5-8283-9f28-5568-49046402a10d
document_version_independent_id: 900a8cd5-8283-9f28-5568-49046402a10d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BuiltInDnsClientEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/BuiltInDnsClientEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 263
asset_id: microsoft-edge-policies/builtindnsclientenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BuiltInDnsClientEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6bf724cc-ab92-faa0-74ff-2aab742c1340
---

# Microsoft Edge Browser Policy Documentation BuiltInDnsClientEnabled | Microsoft Learn

## Use built-in DNS client

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Controls whether to use the built-in DNS client.

This policy controls which software stack is used to communicate with the DNS server: the operating system DNS client, or Microsoft Edge's built-in DNS client. This policy doesn't affect which DNS servers are used: if, for example, the operating system is configured to use an enterprise DNS server, that same server would be used by the built-in DNS client. It also does not control if DNS-over-HTTPS is used; Microsoft Edge always uses the built-in resolver for DNS-over-HTTPS requests. See the [DnsOverHttpsMode](dnsoverhttpsmode) policy for information on controlling DNS-over-HTTPS.

If you enable this policy or you don't configure this policy, the built-in DNS client is used.

If you disable this policy, the built-in DNS client is only used when DNS-over-HTTPS is in use.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: BuiltInDnsClientEnabled
- GP name: Use built-in DNS client
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BuiltInDnsClientEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: BuiltInDnsClientEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: BuiltInDnsClientEnabled
- Example value:

```
true
```