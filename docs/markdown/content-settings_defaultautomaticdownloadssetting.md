---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultAutomaticDownloadsSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultautomaticdownloadssetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default automatic downloads setting'
locale: en-us
document_id: e5d59ae1-aab2-1b47-5709-b3c44d991d67
document_version_independent_id: e5d59ae1-aab2-1b47-5709-b3c44d991d67
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultAutomaticDownloadsSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultAutomaticDownloadsSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 272
asset_id: microsoft-edge-policies/defaultautomaticdownloadssetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultAutomaticDownloadsSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0db70526-9be8-74ff-424b-18e5b1e292ef
---

# Microsoft Edge Browser Policy Documentation DefaultAutomaticDownloadsSetting | Microsoft Learn

## Default automatic downloads setting

## Supported versions

- Windows: ≥ 110
- macOS: ≥ 110
- Android: Not supported
- iOS: Not supported

## Description

Administrators can use this policy to control whether websites can perform multiple downloads successively. Individual site behavior can be managed using the AutomaticDownloadsAllowedForUrls and AutomaticDownloadsBlockedForUrls policies.

Default behavior:

- A user gesture is required for each additional download.
- Users can modify their browser settings to disable successive downloads.

Policy options mapping:

- AllowAutomaticDownloads (1) = Allow all websites to perform multiple downloads without requiring a user gesture between each download.
- BlockAutomaticDownloads (2) = Prevent all websites from performing multiple downloads, even after a user gesture.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- AllowAutomaticDownloads (1) = Allow all websites to perform multiple downloads without requiring a user gesture between each download.
- BlockAutomaticDownloads (2) = Prevent all websites from performing multiple downloads, even after a user gesture.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultAutomaticDownloadsSetting
- GP name: Default automatic downloads setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow all websites to perform multiple downloads without requiring a user gesture between each download.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultAutomaticDownloadsSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DefaultAutomaticDownloadsSetting
- Example value:

```xml
<integer>1</integer>
```