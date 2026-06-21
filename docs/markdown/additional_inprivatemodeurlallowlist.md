---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InPrivateModeUrlAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/inprivatemodeurlallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow access to a list of URLs in InPrivate mode.'
locale: en-us
document_id: f97e0c87-253b-c53d-e59c-da9ba13e0407
document_version_independent_id: f97e0c87-253b-c53d-e59c-da9ba13e0407
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InPrivateModeUrlAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InPrivateModeUrlAllowlist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 395
asset_id: microsoft-edge-policies/inprivatemodeurlallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InPrivateModeUrlAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: d3ee253f-1ab5-2877-ff7e-e0832b638ad7
---

# Microsoft Edge Browser Policy Documentation InPrivateModeUrlAllowlist | Microsoft Learn

## Allow access to a list of URLs in InPrivate mode.

## Supported versions

- Windows: ≥ 147
- macOS: ≥ 147
- Android: ≥ 147
- iOS: ≥ 147

## Description

This policy allows administrators to specify a list of URL patterns that are permitted to open in InPrivate mode. It can be used to create exceptions for URL patterns defined in [InPrivateModeUrlBlocklist](inprivatemodeurlblocklist). See how to format a URL pattern (https://go.microsoft.com/fwlink/?linkid=2095322).

If both this policy and [InPrivateModeUrlBlocklist](inprivatemodeurlblocklist) are configured, the allowlist takes precedence. URLs that match a pattern on this allowlist are allowed. URLs that match the blocklist but not this allowlist are blocked. URLs that match neither list fall back to [URLBlocklist](urlblocklist) and [URLAllowlist](urlallowlist).

If this policy is configured and [InPrivateModeUrlBlocklist](inprivatemodeurlblocklist) is not configured, only the URLs specified in this allowlist can be opened in InPrivate mode. All other URLs are blocked.

If [InPrivateModeAvailability](inprivatemodeavailability) is set to disallow (value 1) but this policy is configured, InPrivate mode is available only for URLs that match the allowlist.

If this policy is not configured, no exceptions are applied to [InPrivateModeUrlBlocklist](inprivatemodeurlblocklist) or [InPrivateModeAvailability](inprivatemodeavailability).

This policy applies only to InPrivate mode. To allow URLs across all browsing modes and profiles, use the [URLAllowlist](urlallowlist) policy.

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

- GP unique name: InPrivateModeUrlAllowlist
- GP name: Allow access to a list of URLs in InPrivate mode.
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\1 =

```
example.com
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\2 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\3 =

```
hosting.com/bad_path
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\4 =

```
https://server:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\5 =

```
.exact.hostname.com
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\6 =

```
file://*
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\7 =

```
custom_scheme:*
```

SOFTWARE\Policies\Microsoft\Edge\InPrivateModeUrlAllowlist\8 =

```
*
```

## Mac information and settings

- Preference Key name: InPrivateModeUrlAllowlist
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

- Preference Key name: InPrivateModeUrlAllowlist
- Example value:

```
["example.com", "https://ssl.server.com", "hosting.com/bad_path", "https://server:8080/path", ".exact.hostname.com", "file://*", "custom_scheme:*", "*"]
```

## iOS information and settings

- Preference Key name: InPrivateModeUrlAllowlist
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