---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllHttpAuthSchemesAllowedForOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allhttpauthschemesallowedfororigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: List of origins that allow all HTTP authentication'
locale: en-us
document_id: 2d72fe1b-05c0-cc6b-513c-7e073e43f91a
document_version_independent_id: 2d72fe1b-05c0-cc6b-513c-7e073e43f91a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllHttpAuthSchemesAllowedForOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AllHttpAuthSchemesAllowedForOrigins.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 259
asset_id: microsoft-edge-policies/allhttpauthschemesallowedfororigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllHttpAuthSchemesAllowedForOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7c383ac3-fc62-0708-a99c-f63947a0f25b
---

# Microsoft Edge Browser Policy Documentation AllHttpAuthSchemesAllowedForOrigins | Microsoft Learn

## List of origins that allow all HTTP authentication

## Supported versions

- Windows: ≥ 102
- macOS: ≥ 102
- Android: ≥ 138
- iOS: Not supported

## Description

Set this policy to specify which origins allow all the HTTP authentication schemes Microsoft Edge supports regardless of the [AuthSchemes](authschemes) policy.

Format the origin pattern according to this format (https://support.google.com/chrome/a?p=url_blocklist_filter_format). Up to 1,000 exceptions can be defined in [AllHttpAuthSchemesAllowedForOrigins](allhttpauthschemesallowedfororigins). Wildcards are allowed for the host component (e.g., '\*:8000' matches all hosts on port 8000). To match all schemes or all ports, omit the component entirely (e.g., 'example.com' matches any scheme and any port). A hostname (e.g., 'example.com') also matches its subdomains. To match a host exactly and exclude its subdomains, prepend it with a dot (e.g., '.example.com'). To match all origins, use a single asterisk ('\*').

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllHttpAuthSchemesAllowedForOrigins
- GP name: List of origins that allow all HTTP authentication
- GP path (Mandatory): Administrative Templates/Microsoft Edge/HTTP authentication
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
*.example.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\AllHttpAuthSchemesAllowedForOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\AllHttpAuthSchemesAllowedForOrigins\1 =

```
*.example.com
```

## Mac information and settings

- Preference Key name: AllHttpAuthSchemesAllowedForOrigins
- Example value:

```xml
<array>
  <string>*.example.com</string>
</array>
```

## Android information and settings

- Preference Key name: AllHttpAuthSchemesAllowedForOrigins
- Example value:

```
["*.example.com"]
```