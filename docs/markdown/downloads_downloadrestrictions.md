---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DownloadRestrictions | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/downloadrestrictions
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow download restrictions'
locale: en-us
document_id: c3a7cde5-815f-a0dc-28b9-998fc98f01c2
document_version_independent_id: c3a7cde5-815f-a0dc-28b9-998fc98f01c2
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DownloadRestrictions.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DownloadRestrictions.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 441
asset_id: microsoft-edge-policies/downloadrestrictions
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DownloadRestrictions.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c671beaa-a830-4c9f-aceb-97379ee031ca
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8921374c-4dbe-4ed0-b011-a39e18bfbd98
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5a60412c-d37b-1059-3ebb-f99c45509e6b
---

# Microsoft Edge Browser Policy Documentation DownloadRestrictions | Microsoft Learn

## Allow download restrictions

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 140
- iOS: Not supported

## Description

Configures the type of downloads that Microsoft Edge completely blocks, without letting users override the security decision.

Set 'BlockDangerousDownloads' to allow all downloads except for those that carry Microsoft Defender SmartScreen warnings of known dangerous downloads or that have dangerous file type extensions.

Set 'BlockPotentiallyDangerousDownloads' to allow all downloads except for those that carry Microsoft Defender SmartScreen warnings of potentially dangerous or unwanted downloads or that have dangerous file type extensions.

Set 'BlockAllDownloads' to block all downloads.

Set 'BlockMaliciousDownloads' to allow all downloads except for those that carry Microsoft Defender SmartScreen warnings of known malicious downloads.

If you don't configure this policy or set the 'DefaultDownloadSecurity' option, the downloads go through the usual security restrictions based on Microsoft Defender SmartScreen analysis results.

Note that these restrictions apply to downloads from web page content, as well as the 'download link...' context menu option. These restrictions don't apply to saving or downloading the currently displayed page, nor do they apply to the Save as PDF option from the printing options.

See https://go.microsoft.com/fwlink/?linkid=2094934 for more info on Microsoft Defender SmartScreen.

Policy options mapping:

- DefaultDownloadSecurity (0) = No special restrictions
- BlockDangerousDownloads (1) = Block malicious downloads and dangerous file types
- BlockPotentiallyDangerousDownloads (2) = Block potentially dangerous or unwanted downloads and dangerous file types
- BlockAllDownloads (3) = Block all downloads
- BlockMaliciousDownloads (4) = Block malicious downloads

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- DefaultDownloadSecurity (0) = No special restrictions
- BlockDangerousDownloads (1) = Block malicious downloads and dangerous file types
- BlockPotentiallyDangerousDownloads (2) = Block potentially dangerous or unwanted downloads and dangerous file types
- BlockAllDownloads (3) = Block all downloads
- BlockMaliciousDownloads (4) = Block malicious downloads
    - Windows: ≥ 100
    - macOS: ≥ 100
    - Android: ≥ 140
    - iOS: Not supported

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DownloadRestrictions
- GP name: Allow download restrictions
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Block potentially dangerous or unwanted downloads and dangerous file types
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DownloadRestrictions
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DownloadRestrictions
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: DownloadRestrictions
- Example value:

```
2
```