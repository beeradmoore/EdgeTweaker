---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DnsOverHttpsTemplates | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/dnsoverhttpstemplates
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specify URI template of desired DNS-over-HTTPS resolver'
locale: en-us
document_id: 43e63529-3557-2665-0daa-e11226d97a66
document_version_independent_id: 43e63529-3557-2665-0daa-e11226d97a66
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DnsOverHttpsTemplates.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/DnsOverHttpsTemplates.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 247
asset_id: microsoft-edge-policies/dnsoverhttpstemplates
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DnsOverHttpsTemplates.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4261b630-c027-fb41-0edb-9a1021eee3b4
---

# Microsoft Edge Browser Policy Documentation DnsOverHttpsTemplates | Microsoft Learn

## Specify URI template of desired DNS-over-HTTPS resolver

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: ≥ 147
- iOS: Not supported

## Description

The URI template of the desired DNS-over-HTTPS resolver. To specify multiple DNS-over-HTTPS resolvers, separate the corresponding URI templates with spaces.

If you set [DnsOverHttpsMode](dnsoverhttpsmode) to "secure", then this policy must be set and can't be empty.

If you set [DnsOverHttpsMode](dnsoverhttpsmode) to "automatic" and this policy is set, then the URI templates specified are used. If you don't set this policy, then hardcoded mappings are used to attempt to upgrade the user's current DNS resolver to a DoH resolver operated by the same provider.

If the URI template contains a dns variable, requests to the resolver use GET; otherwise, requests use POST.

Incorrectly formatted templates will be ignored.

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

- GP unique name: DnsOverHttpsTemplates
- GP name: Specify URI template of desired DNS-over-HTTPS resolver
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://dns.example.net/dns-query{?dns}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DnsOverHttpsTemplates
- Value type: REG\_SZ

#### Example registry value

```
https://dns.example.net/dns-query{?dns}
```

## Mac information and settings

- Preference Key name: DnsOverHttpsTemplates
- Example value:

```xml
<string>https://dns.example.net/dns-query{?dns}</string>
```

## Android information and settings

- Preference Key name: DnsOverHttpsTemplates
- Example value:

```
https://dns.example.net/dns-query{?dns}
```