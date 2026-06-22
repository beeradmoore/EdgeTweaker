---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation URLBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/urlblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block access to a list of URLs'
locale: en-us
document_id: 81424937-a87b-1ed6-c2e3-239284dc246d
document_version_independent_id: 81424937-a87b-1ed6-c2e3-239284dc246d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/URLBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/URLBlocklist.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 316
asset_id: microsoft-edge-policies/urlblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/URLBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 322e576c-2dc7-beaa-c01c-27158a0b3282
---

# Microsoft Edge Browser Policy Documentation URLBlocklist | Microsoft Learn

## Block access to a list of URLs

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 85

## Description

Defines a list of sites, based on URL patterns, that are blocked (your users can't load them).

Format the URL pattern according to https://go.microsoft.com/fwlink/?linkid=2095322.

You can define exceptions in the [URLAllowlist](urlallowlist) policy. These policies are limited to 1000 entries; subsequent entries are ignored.

Blocking internal 'edge://\*' URLs isn't recommended - this may lead to unexpected errors.

This policy doesn't prevent the page from updating dynamically through JavaScript. For example, if you block 'contoso.com/abc', users can visit 'contoso.com' and select on a link to visit 'contoso.com/abc', as long as the page doesn't refresh.

If you don't configure this policy, no URLs are blocked.

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

- GP unique name: URLBlocklist
- GP name: Block access to a list of URLs
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
hosting.com/bad_path
```

```
https://server:8080/path
```

```
.exact.hostname.com
```

```
custom_scheme:*
```

```
*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\URLBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\1 =

```
contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\2 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\3 =

```
hosting.com/bad_path
```

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\4 =

```
https://server:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\5 =

```
.exact.hostname.com
```

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\6 =

```
custom_scheme:*
```

SOFTWARE\Policies\Microsoft\Edge\URLBlocklist\7 =

```
*
```

## Mac information and settings

- Preference Key name: URLBlocklist
- Example value:

```xml
<array>
  <string>contoso.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/bad_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
  <string>custom_scheme:*</string>
  <string>*</string>
</array>
```

## Android information and settings

- Preference Key name: URLBlocklist
- Example value:

```
["contoso.com", "https://ssl.server.com", "hosting.com/bad_path", "https://server:8080/path", ".exact.hostname.com", "custom_scheme:*", "*"]
```

## iOS information and settings

- Preference Key name: URLBlocklist
- Example value:

```xml
<array>
  <string>contoso.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/bad_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
  <string>custom_scheme:*</string>
  <string>*</string>
</array>
```