---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeSidebarAppUrlHostAllowList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgesidebarappurlhostallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow specific apps to be opened in Microsoft Edge sidebar'
locale: en-us
document_id: 00cb603d-d524-3cd8-8368-7a8ceb66352a
document_version_independent_id: 00cb603d-d524-3cd8-8368-7a8ceb66352a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeSidebarAppUrlHostAllowList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeSidebarAppUrlHostAllowList.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 245
asset_id: microsoft-edge-policies/edgesidebarappurlhostallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeSidebarAppUrlHostAllowList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b90b8b91-49c2-485a-c11c-ecf4226070a6
---

# Microsoft Edge Browser Policy Documentation EdgeSidebarAppUrlHostAllowList | Microsoft Learn

## Allow specific apps to be opened in Microsoft Edge sidebar

## Supported versions

- Windows: ≥ 131
- macOS: ≥ 131
- Android: Not supported
- iOS: Not supported

## Description

Define a list of sites, based on URL patterns, that aren't subject to the [EdgeSidebarAppUrlHostBlockList](edgesidebarappurlhostblocklist).

If you don't configure this policy, a user can open any app in sidebar except the urls listed in [EdgeSidebarAppUrlHostBlockList](edgesidebarappurlhostblocklist).

If you configure this policy, the apps listed in the allow list could be opened in sidebar even if they are listed in the block list.

By default, all apps are allowed. However, if you prohibited apps by policy, you can use the list of allowed apps to change that policy.

For detailed information about valid url patterns, see https://go.microsoft.com/fwlink/?linkid=2281313.

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

- GP unique name: EdgeSidebarAppUrlHostAllowList
- GP name: Allow specific apps to be opened in Microsoft Edge sidebar
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
[*.]contoso.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\EdgeSidebarAppUrlHostAllowList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\EdgeSidebarAppUrlHostAllowList\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\EdgeSidebarAppUrlHostAllowList\2 =

```
[*.]contoso.edu
```

## Mac information and settings

- Preference Key name: EdgeSidebarAppUrlHostAllowList
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
</array>
```