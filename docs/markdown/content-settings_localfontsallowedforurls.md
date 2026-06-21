---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalFontsAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localfontsallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Local Fonts permission on these sites'
locale: en-us
document_id: d3469678-9eb0-db9b-bf43-63fafaf8be19
document_version_independent_id: d3469678-9eb0-db9b-bf43-63fafaf8be19
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalFontsAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/LocalFontsAllowedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 229
asset_id: microsoft-edge-policies/localfontsallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalFontsAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: e00aa53a-50ae-80cf-3f6c-8c7cf9a9334b
---

# Microsoft Edge Browser Policy Documentation LocalFontsAllowedForUrls | Microsoft Learn

## Allow Local Fonts permission on these sites

## Supported versions

- Windows: ≥ 149
- macOS: ≥ 149
- Android: Not supported
- iOS: Not supported

## Description

Specifies a list of site URL patterns for which the local fonts permission is automatically granted. Sites in this list can access information about local fonts.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. Wildcards, \*, are supported. This policy matches based on origin only; any path in the URL pattern is ignored.

If a site isn't included in this policy, the [DefaultLocalFontsSetting](defaultlocalfontssetting) policy applies if configured. Otherwise, the browser default behavior applies, and users can choose the permission on a per-site basis.

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

- GP unique name: LocalFontsAllowedForUrls
- GP name: Allow Local Fonts permission on these sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LocalFontsAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LocalFontsAllowedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\LocalFontsAllowedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: LocalFontsAllowedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```