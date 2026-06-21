---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DeveloperToolsAvailabilityAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/developertoolsavailabilityallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: List of URL patterns for which developer tools are allowed to be opened'
locale: en-us
document_id: a68fb798-d0c9-2cbf-d053-2e534642e6a6
document_version_independent_id: a68fb798-d0c9-2cbf-d053-2e534642e6a6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailabilityAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailabilityAllowlist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 350
asset_id: microsoft-edge-policies/developertoolsavailabilityallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailabilityAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 21306358-fc22-acdf-663f-35229fa0eebb
---

# Microsoft Edge Browser Policy Documentation DeveloperToolsAvailabilityAllowlist | Microsoft Learn

## List of URL patterns for which developer tools are allowed to be opened

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy controls where developer tools can be used in Microsoft Edge by specifying an allowlist of URL patterns.

URL patterns are matched against the URL of every frame on the page being inspected.

If you configure this policy and do not configure the [DeveloperToolsAvailabilityBlocklist](developertoolsavailabilityblocklist) policy, developer tools are available only when every frame on the page matches a pattern in this allowlist. If any frame does not match, developer tools are blocked for the entire page. For information on the URL format, see https://go.microsoft.com/fwlink/?linkid=2095322 .

If you configure both this policy and the [DeveloperToolsAvailabilityBlocklist](developertoolsavailabilityblocklist) policy, this allowlist takes precedence. URLs that match this allowlist are allowed even if they also match the blocklist. URLs that match the blocklist but not this allowlist are blocked. URLs that match neither are governed by the [DeveloperToolsAvailability](developertoolsavailability) policy.

If you disable or do not configure this policy, developer tools availability is determined by the [DeveloperToolsAvailabilityBlocklist](developertoolsavailabilityblocklist) and [DeveloperToolsAvailability](developertoolsavailability) policies.

This policy applies to developer tools opened for websites, extensions, and web applications.

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

- GP unique name: DeveloperToolsAvailabilityAllowlist
- GP name: List of URL patterns for which developer tools are allowed to be opened
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
contoso.com/good_path
```

```
https://server.contoso.com:8080/path
```

```
.exact.hostname.com
```

```
file://*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist\1 =

```
contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist\2 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist\3 =

```
contoso.com/good_path
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist\4 =

```
https://server.contoso.com:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist\5 =

```
.exact.hostname.com
```

SOFTWARE\Policies\Microsoft\Edge\DeveloperToolsAvailabilityAllowlist\6 =

```
file://*
```

## Mac information and settings

- Preference Key name: DeveloperToolsAvailabilityAllowlist
- Example value:

```xml
<array>
  <string>contoso.com</string>
  <string>https://ssl.server.com</string>
  <string>contoso.com/good_path</string>
  <string>https://server.contoso.com:8080/path</string>
  <string>.exact.hostname.com</string>
  <string>file://*</string>
</array>
```