---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InPrivateModeUrlBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/inprivatemodeurlblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block access to a list of URLs in InPrivate mode.'
locale: en-us
document_id: 8171f1ed-df16-8121-70af-1651baed0b8e
document_version_independent_id: 8171f1ed-df16-8121-70af-1651baed0b8e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InPrivateModeUrlBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InPrivateModeUrlBlocklist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 372
asset_id: microsoft-edge-policies/inprivatemodeurlblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InPrivateModeUrlBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 814c19f6-e639-781f-56a6-3a6f8d91dcd3
---

# Microsoft Edge Browser Policy Documentation InPrivateModeUrlBlocklist | Microsoft Learn

## Block access to a list of URLs in InPrivate mode.

## Supported versions

- Windows: ≥ 147
- macOS: ≥ 147
- Android: ≥ 147
- iOS: ≥ 147

## Description

This policy controls which URLs are blocked from loading in InPrivate mode in Microsoft Edge.

Administrators can specify a list of URL patterns that are blocked when users browse in InPrivate mode. For information about the supported URL pattern format, see https://go.microsoft.com/fwlink/?linkid=2095322.

If both [InPrivateModeUrlBlocklist](inprivatemodeurlblocklist) and [InPrivateModeUrlAllowlist](inprivatemodeurlallowlist) are configured, the allowlist takes precedence.

- URLs that match the allowlist are allowed.
- URLs that match the blocklist but not the allowlist are blocked.
- URLs that match neither list follow the behavior defined by the general [URLBlocklist](urlblocklist) and [URLAllowlist](urlallowlist) policies.

If [InPrivateModeUrlAllowlist](inprivatemodeurlallowlist) is configured and this policy is not configured, only URLs on the allowlist can be opened in InPrivate mode.

If [InPrivateModeAvailability](inprivatemodeavailability) is set to disallow (value 1) and [InPrivateModeUrlAllowlist](inprivatemodeurlallowlist) is configured, InPrivate mode is available only for URLs that match the allowlist.

This policy applies only to InPrivate mode. To block URLs across all browsing modes, use [URLBlocklist](urlblocklist).

This policy supports up to 1000 entries.

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

- GP unique name: InPrivateModeUrlBlocklist
- GP name: Block access to a list of URLs in InPrivate mode.
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
example.com
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
file://*
```

```
custom_scheme:*
```

```
*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\1 =

```
example.com
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\2 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\3 =

```
hosting.com/bad_path
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\4 =

```
https://server:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\5 =

```
.exact.hostname.com
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\6 =

```
file://*
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\7 =

```
custom_scheme:*
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlBlocklist\8 =

```
*
```

## Mac information and settings

- Preference Key name: InPrivateModeUrlBlocklist
- Example value:

```xml
<array>
  <string>example.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/bad_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
  <string>file://*</string>
  <string>custom_scheme:*</string>
  <string>*</string>
</array>
```

## Android information and settings

- Preference Key name: InPrivateModeUrlBlocklist
- Example value:

```
["example.com", "https://ssl.server.com", "hosting.com/bad_path", "https://server:8080/path", ".exact.hostname.com", "file://*", "custom_scheme:*", "*"]
```

## iOS information and settings

- Preference Key name: InPrivateModeUrlBlocklist
- Example value:

```xml
<array>
  <string>example.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/bad_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
  <string>file://*</string>
  <string>custom_scheme:*</string>
  <string>*</string>
</array>
```