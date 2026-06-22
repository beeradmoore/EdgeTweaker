---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DnsOverHttpsMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/dnsoverhttpsmode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the mode of DNS-over-HTTPS'
locale: en-us
document_id: 4c6cd95e-24a8-fbcc-815b-3b2058e3c2ee
document_version_independent_id: 4c6cd95e-24a8-fbcc-815b-3b2058e3c2ee
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DnsOverHttpsMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/DnsOverHttpsMode.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 321
asset_id: microsoft-edge-policies/dnsoverhttpsmode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DnsOverHttpsMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 01b79d9b-6643-ba3e-c72f-87b6ccce21ae
---

# Microsoft Edge Browser Policy Documentation DnsOverHttpsMode | Microsoft Learn

## Control the mode of DNS-over-HTTPS

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: ≥ 147
- iOS: Not supported

## Description

Control the mode of the DNS-over-HTTPS resolver. This policy only sets the default mode for each query. The mode can be overridden for special types of queries such as requests to resolve a DNS-over-HTTPS server hostname.

The "off" mode disables DNS-over-HTTPS.

The "automatic" mode sends DNS-over-HTTPS queries first if a DNS-over-HTTPS server is available, and falls back to sending insecure queries on error.

The "secure" mode only sends DNS-over-HTTPS queries and will fail to resolve on error.

If you don't configure this policy for managed devices, DNS-over-HTTPS queries aren't sent. Instead, the browser may send DNS requests to a resolver associated with the user's system resolver. This could lead to a less secure or private DNS resolution process, depending on the resolver in use.

Policy options mapping:

- off (off) = Disable DNS-over-HTTPS
- automatic (automatic) = Enable DNS-over-HTTPS with insecure fallback
- secure (secure) = Enable DNS-over-HTTPS without insecure fallback

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- off = Disable DNS-over-HTTPS
- automatic = Enable DNS-over-HTTPS with insecure fallback
- secure = Enable DNS-over-HTTPS without insecure fallback

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DnsOverHttpsMode
- GP name: Control the mode of DNS-over-HTTPS
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disable DNS-over-HTTPS
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DnsOverHttpsMode
- Value type: REG\_SZ

#### Example registry value

```
off
```

## Mac information and settings

- Preference Key name: DnsOverHttpsMode
- Example value:

```xml
<string>off</string>
```

## Android information and settings

- Preference Key name: DnsOverHttpsMode
- Example value:

```
off
```