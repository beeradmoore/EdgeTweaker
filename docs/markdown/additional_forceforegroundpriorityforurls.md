---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceForegroundPriorityForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forceforegroundpriorityforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force foreground priority for specific URLs'
locale: en-us
document_id: d76b7c97-2492-d22f-c0f2-d592f9c9d6f4
document_version_independent_id: d76b7c97-2492-d22f-c0f2-d592f9c9d6f4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceForegroundPriorityForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ForceForegroundPriorityForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 253
asset_id: microsoft-edge-policies/forceforegroundpriorityforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceForegroundPriorityForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: bd178c33-0e48-7ffa-24a4-7dade463c786
---

# Microsoft Edge Browser Policy Documentation ForceForegroundPriorityForUrls | Microsoft Learn

## Force foreground priority for specific URLs

## Supported versions

- Windows: ≥ 149
- macOS: ≥ 149
- Android: Not supported
- iOS: Not supported

## Description

This policy allows you to specify a list of URL patterns for which background web content is forced to run at foreground priority.

If the ForceForegroundPriorityForAllTabs policy is enabled, this policy is ignored because all tabs are already forced to run at foreground priority.

If the ForceForegroundPriorityForAllTabs policy is disabled or not configured, only background content that matches the URL patterns in this list is forced to run at foreground priority.

For more information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322.

If you don’t configure this policy or the list is empty, no background content is forced to run at foreground priority.

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

- GP unique name: ForceForegroundPriorityForUrls
- GP name: Force foreground priority for specific URLs
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com/path?query=val
```

```
example.edu
```

```
https://example.com:8080
```

```
*://example.org:*/
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ForceForegroundPriorityForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ForceForegroundPriorityForUrls\1 =

```
https://www.example.com/path?query=val
```

SOFTWARE\Policies\Microsoft\Edge\ForceForegroundPriorityForUrls\2 =

```
example.edu
```

SOFTWARE\Policies\Microsoft\Edge\ForceForegroundPriorityForUrls\3 =

```
https://example.com:8080
```

SOFTWARE\Policies\Microsoft\Edge\ForceForegroundPriorityForUrls\4 =

```
*://example.org:*/
```

## Mac information and settings

- Preference Key name: ForceForegroundPriorityForUrls
- Example value:

```xml
<array>
  <string>https://www.example.com/path?query=val</string>
  <string>example.edu</string>
  <string>https://example.com:8080</string>
  <string>*://example.org:*/</string>
</array>
```