---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoOpenAllowedForURLs | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autoopenallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: URLs where AutoOpenFileTypes can apply'
locale: en-us
document_id: 6dd50fce-3a5f-1723-df71-65dbe391a2eb
document_version_independent_id: 6dd50fce-3a5f-1723-df71-65dbe391a2eb
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoOpenAllowedForURLs.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/AutoOpenAllowedForURLs.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 267
asset_id: microsoft-edge-policies/autoopenallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoOpenAllowedForURLs.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6c8a3b09-7a24-b44e-6077-329e8b42a7b4
---

# Microsoft Edge Browser Policy Documentation AutoOpenAllowedForURLs | Microsoft Learn

## URLs where AutoOpenFileTypes can apply

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 85
- Android: Not supported
- iOS: Not supported

## Description

A list of URLs to which [AutoOpenFileTypes](autoopenfiletypes) applies to. This policy has no impact on automatically open values set by users via the download shelf ... &gt; "Always open files of this type" menu entry.

If you set URLs in this policy, files will only automatically open by policy if the URL is part of this set and the file type is listed in [AutoOpenFileTypes](autoopenfiletypes). If either condition is false, the download won't automatically open by policy.

If you don't set this policy, all downloads where the file type is in [AutoOpenFileTypes](autoopenfiletypes) automatically opens.

A URL pattern has to be formatted according to https://go.microsoft.com/fwlink/?linkid=2095322.

This policy doesn't work as expected with file://\* wildcards.

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

- GP unique name: AutoOpenAllowedForURLs
- GP name: URLs where AutoOpenFileTypes can apply
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
hosting.com/good_path
```

```
https://server:8080/path
```

```
.exact.hostname.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\AutoOpenAllowedForURLs
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\AutoOpenAllowedForURLs\1 =

```
example.com
```

SOFTWARE\Policies\Microsoft\Edge\AutoOpenAllowedForURLs\2 =

```
https://ssl.server.com
```

SOFTWARE\Policies\Microsoft\Edge\AutoOpenAllowedForURLs\3 =

```
hosting.com/good_path
```

SOFTWARE\Policies\Microsoft\Edge\AutoOpenAllowedForURLs\4 =

```
https://server:8080/path
```

SOFTWARE\Policies\Microsoft\Edge\AutoOpenAllowedForURLs\5 =

```
.exact.hostname.com
```

## Mac information and settings

- Preference Key name: AutoOpenAllowedForURLs
- Example value:

```xml
<array>
  <string>example.com</string>
  <string>https://ssl.server.com</string>
  <string>hosting.com/good_path</string>
  <string>https://server:8080/path</string>
  <string>.exact.hostname.com</string>
</array>
```