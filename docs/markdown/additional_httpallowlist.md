---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HttpAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/httpallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: HTTP Allowlist'
locale: en-us
document_id: d75034bc-fde3-5039-de5a-8b6ea3ecd9db
document_version_independent_id: d75034bc-fde3-5039-de5a-8b6ea3ecd9db
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HttpAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/HttpAllowlist.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 240
asset_id: microsoft-edge-policies/httpallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HttpAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 8affad3d-ac5f-82c9-c2cb-7cca44aa4814
---

# Microsoft Edge Browser Policy Documentation HttpAllowlist | Microsoft Learn

## HTTP Allowlist

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: ≥ 123
- iOS: Not supported

## Description

Setting the policy specifies a list of hostnames or hostname patterns (such as '[\*.]example.com') that won't be upgraded to HTTPS. Organizations can use this policy to maintain access to servers that don't support HTTPS, without needing to disable [HttpsUpgradesEnabled](httpsupgradesenabled).

Supplied hostnames must be canonicalized: Any IDNs must be converted to their A-label format, and all ASCII letters must be lowercase.

Blanket host wildcards (that is, "*" or "[*]") aren't allowed. Instead, HTTPS-First Mode and HTTPS Upgrades should be explicitly disabled via their specific policies.

Note: This policy doesn't apply to HSTS upgrades.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HttpAllowlist
- GP name: HTTP Allowlist
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
testserver.example.com
```

```
[*.]example.org
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\HttpAllowlist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\HttpAllowlist\1 =

```
testserver.example.com
```

SOFTWARE\Policies\Microsoft\Edge\HttpAllowlist\2 =

```
[*.]example.org
```

## Mac information and settings

- Preference Key name: HttpAllowlist
- Example value:

```xml
<array>
  <string>testserver.example.com</string>
  <string>[*.]example.org</string>
</array>
```

## Android information and settings

- Preference Key name: HttpAllowlist
- Example value:

```
["testserver.example.com", "[*.]example.org"]
```