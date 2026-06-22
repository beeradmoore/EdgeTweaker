---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoOpenFileTypes | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autoopenfiletypes
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: List of file types that should be automatically opened on download'
locale: en-us
document_id: 31c773be-5883-c233-7e8e-5fcea85d6cac
document_version_independent_id: 31c773be-5883-c233-7e8e-5fcea85d6cac
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoOpenFileTypes.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/AutoOpenFileTypes.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 328
asset_id: microsoft-edge-policies/autoopenfiletypes
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoOpenFileTypes.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 80ef0f15-f237-7ba0-36ed-2d6e7ca1507f
---

# Microsoft Edge Browser Policy Documentation AutoOpenFileTypes | Microsoft Learn

## List of file types that should be automatically opened on download

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 85
- Android: Not supported
- iOS: Not supported

## Description

This policy sets a list of file types that should be automatically opened on download. Note: The leading separator shouldn't be included when listing the file type, so list "txt" instead of ".txt".

By default, these file types are automatically opened on all URLs. You can use the [AutoOpenAllowedForURLs](autoopenallowedforurls) policy to restrict the URLs on which these file types are automatically opened.

Files with types that should be automatically opened are still subject to the enabled Microsoft Defender SmartScreen checks and won't be opened if they fail those checks.

File types that a user has already specified to automatically be opened continue to do so when downloaded. The user continues to be able to specify other file types to be automatically opened.

If you don't set this policy, only file types that a user has already specified to automatically be opened will do so when downloaded.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory or instances that enrolled for device management.

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

- GP unique name: AutoOpenFileTypes
- GP name: List of file types that should be automatically opened on download
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
exe
```

```
txt
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\AutoOpenFileTypes
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\AutoOpenFileTypes\1 =

```
exe
```

SOFTWARE\Policies\Microsoft\Edge\AutoOpenFileTypes\2 =

```
txt
```

## Mac information and settings

- Preference Key name: AutoOpenFileTypes
- Example value:

```xml
<array>
  <string>exe</string>
  <string>txt</string>
</array>
```