---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SleepingTabsBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sleepingtabsblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block sleeping tabs on specific sites'
locale: en-us
document_id: 078251af-d029-4c4a-79b4-61cfa8d91f2a
document_version_independent_id: 078251af-d029-4c4a-79b4-61cfa8d91f2a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SleepingTabsBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/SleepingTabsBlockedForUrls.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 231
asset_id: microsoft-edge-policies/sleepingtabsblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SleepingTabsBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: d167d8f2-983f-c698-7ce4-16d54954743b
---

# Microsoft Edge Browser Policy Documentation SleepingTabsBlockedForUrls | Microsoft Learn

## Block sleeping tabs on specific sites

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

Define a list of sites, based on URL patterns, that aren't allowed to be put to sleep by sleeping tabs. Sites in this list are also excluded from other performance optimizations like efficiency mode and tab discard.

If the policy [SleepingTabsEnabled](sleepingtabsenabled) is disabled, this list isn't used and no sites are put to sleep automatically.

If you don't configure this policy, all sites are eligible to be put to sleep unless the user's personal configuration blocks them.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SleepingTabsBlockedForUrls
- GP name: Block sleeping tabs on specific sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Sleeping tabs settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Sleeping tabs settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
[*.]contoso.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SleepingTabsBlockedForUrls
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended\SleepingTabsBlockedForUrls
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SleepingTabsBlockedForUrls\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\SleepingTabsBlockedForUrls\2 =

```
[*.]contoso.edu
```

## Mac information and settings

- Preference Key name: SleepingTabsBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
</array>
```