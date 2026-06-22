---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DeveloperToolsAvailabilityBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/developertoolsavailabilityblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: List of URL patterns for which developer tools are blocked'
locale: en-us
document_id: 3aafa2cd-0565-84c8-474a-9187f9826b46
document_version_independent_id: 3aafa2cd-0565-84c8-474a-9187f9826b46
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailabilityBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailabilityBlocklist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 342
asset_id: microsoft-edge-policies/developertoolsavailabilityblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailabilityBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0c291f4d-a8a6-b7df-892c-e80489708653
---

# Microsoft Edge Browser Policy Documentation DeveloperToolsAvailabilityBlocklist | Microsoft Learn

## List of URL patterns for which developer tools are blocked

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy specifies URL patterns where developer tools are blocked. For information on the URL format, see https://go.microsoft.com/fwlink/?linkid=2095322.

URL patterns are evaluated against the URL of every frame on the page being inspected. If any frame matches a pattern in this policy, developer tools are blocked for the entire page.

If you configure this policy and do not configure the [DeveloperToolsAvailabilityAllowlist](developertoolsavailabilityallowlist) policy, developer tools are blocked when any frame matches a pattern in this policy. If no frames match, availability is determined by the [DeveloperToolsAvailability](developertoolsavailability) policy.

If you configure both this policy and the [DeveloperToolsAvailabilityAllowlist](developertoolsavailabilityallowlist) policy, the allowlist takes precedence. URLs that match the allowlist are allowed, even if they also match this policy. URLs that match this policy (but not the allowlist) are blocked. If a URL matches neither, the [DeveloperToolsAvailability](developertoolsavailability) policy determines availability.

If you disable or do not configure this policy, developer tools availability is determined by the [DeveloperToolsAvailabilityAllowlist](developertoolsavailabilityallowlist) and [DeveloperToolsAvailability](developertoolsavailability) policies.

This policy supports up to 1,000 entries.

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

- GP unique name: DeveloperToolsAvailabilityBlocklist
- GP name: List of URL patterns for which developer tools are blocked
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contoso.com
```

```
contoso.com
```

```
https://ssl.server.com
```

```
contoso.com/bad_path
```

```
https://server.contoso.com:8080/path
```

```
.exact.hostname.com
```

```
*
```

```
file://*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\1 =

```
https://contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\2 =

```
contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\3 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\4 =

```
contoso.com/bad_path
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\5 =

```
https://server.contoso.com:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\6 =

```
.exact.hostname.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\7 =

```
*
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityBlocklist\8 =

```
file://*
```

## Mac information and settings

- Preference Key name: DeveloperToolsAvailabilityBlocklist
- Example value:

```xml
<array>
  <string>https://contoso.com</string>
  <string>contoso.com</string>
  <string>https://ssl.server.com</string>
  <string>contoso.com/bad_path</string>
  <string>https://server.contoso.com:8080/path</string>
  <string>.exact.hostname.com</string>
  <string>*</string>
  <string>file://*</string>
</array>
```