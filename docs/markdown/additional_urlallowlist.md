---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation URLAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/urlallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Define a list of allowed URLs'
locale: en-us
document_id: c8ceea63-ef8f-e0ba-519e-c8d0b0acf9b1
document_version_independent_id: c8ceea63-ef8f-e0ba-519e-c8d0b0acf9b1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/URLAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/URLAllowlist.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 345
asset_id: microsoft-edge-policies/urlallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/URLAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 539154c3-9aba-06a0-74d4-960b86d58a66
---

# Microsoft Edge Browser Policy Documentation URLAllowlist | Microsoft Learn

## Define a list of allowed URLs

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 85

## Description

Setting the policy provides access to the listed URLs as exceptions to [URLBlocklist](urlblocklist).

Format the URL pattern according to https://go.microsoft.com/fwlink/?linkid=2095322.

You can use this policy to open exceptions to restrictive blocklists. For example, you can include '\*' in the blocklist to block all requests, and then use this policy to allow access to a limited list of URLs. You can use this policy to open exceptions to certain schemes, subdomains of other domains, ports, or specific paths.

The most specific filter determines if a URL is blocked or allowed. The allowed list takes precedence over the blocked list.

This policy is limited to 1000 entries; subsequent entries are ignored.

This policy also allows the browser to automatically invoke external applications registered as protocol handlers for protocols like "tel:" or "ssh:".

If you don't configure this policy, there are no exceptions to the blocklist in the [URLBlocklist](urlblocklist) policy.

This policy doesn't work as expected with file://\* wildcards.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: URLAllowlist
- GP name: Define a list of allowed URLs
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
contoso.com
```

```
https://ssl.server.com
```

```
hosting.com/good_path
```

```
https://server:8080/path
```

```
.exact.hostname.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\URLAllowlist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\URLAllowlist\1 =

```
contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\URLAllowlist\2 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\URLAllowlist\3 =

```
hosting.com/good_path
```

SOFTWARE\Policies\Microsoft\Edge\URLAllowlist\4 =

```
https://server:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\URLAllowlist\5 =

```
.exact.hostname.com
```

## Mac information and settings

- Preference Key name: URLAllowlist
- Example value:

```xml
<array>
  <string>contoso.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/good_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
</array>
```

## Android information and settings

- Preference Key name: URLAllowlist
- Example value:

```
["contoso.com", "https://ssl.server.com", "hosting.com/good_path", "https://server:8080/path", ".exact.hostname.com"]
```

## iOS information and settings

- Preference Key name: URLAllowlist
- Example value:

```xml
<array>
  <string>contoso.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/good_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
</array>
```