---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InsecureContentBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/insecurecontentblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block insecure content on specified sites'
locale: en-us
document_id: 3b6d0199-6d97-cd55-36f6-c312b83bdb0e
document_version_independent_id: 3b6d0199-6d97-cd55-36f6-c312b83bdb0e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InsecureContentBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InsecureContentBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 226
asset_id: microsoft-edge-policies/insecurecontentblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InsecureContentBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: b5ff14c1-de7a-f73d-f0f8-19e968626f2c
---

# Microsoft Edge Browser Policy Documentation InsecureContentBlockedForUrls | Microsoft Learn

## Block insecure content on specified sites

## Supported versions

- Windows: ≥ 80
- macOS: ≥ 80
- Android: Not supported
- iOS: Not supported

## Description

Creates a list of URL patterns to specify sites that aren't allowed to display blockable (that is, active) mixed content (that is, HTTP content on HTTPS sites) and for which optionally blockable mixed content upgrades are disabled.

If you don't configure this policy, blockable mixed content is blocked, and optionally blockable mixed content is upgraded. However, users are allowed to set exceptions to allow insecure mixed content for specific sites.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. Wildcards (\*) are allowed.

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

- GP unique name: InsecureContentBlockedForUrls
- GP name: Block insecure content on specified sites
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\InsecureContentBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\InsecureContentBlockedForUrls\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\InsecureContentBlockedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: InsecureContentBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```