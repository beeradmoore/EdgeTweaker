---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutomaticDownloadsBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/automaticdownloadsblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block multiple automatic downloads in quick succession on specific sites'
locale: en-us
document_id: 51db6022-fbfb-1daf-8417-5ae257d4ed69
document_version_independent_id: 51db6022-fbfb-1daf-8417-5ae257d4ed69
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutomaticDownloadsBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/AutomaticDownloadsBlockedForUrls.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 203
asset_id: microsoft-edge-policies/automaticdownloadsblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutomaticDownloadsBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a713a46b-f572-67b6-5e1d-c6ccc1c067df
---

# Microsoft Edge Browser Policy Documentation AutomaticDownloadsBlockedForUrls | Microsoft Learn

## Block multiple automatic downloads in quick succession on specific sites

## Supported versions

- Windows: ≥ 110
- macOS: ≥ 110
- Android: Not supported
- iOS: Not supported

## Description

Define a list of sites, based on URL patterns, where multiple successive automatic downloads aren't allowed. If you don't configure this policy, [DefaultAutomaticDownloadsSetting](defaultautomaticdownloadssetting) applies for all sites, if that setting is active. If it isn't set, then the user's personal setting applies. For more detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322.

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

- GP unique name: AutomaticDownloadsBlockedForUrls
- GP name: Block multiple automatic downloads in quick succession on specific sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contoso.com
```

```
[*.]contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\AutomaticDownloadsBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\AutomaticDownloadsBlockedForUrls\1 =

```
https://contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\AutomaticDownloadsBlockedForUrls\2 =

```
[*.]contoso.com
```

## Mac information and settings

- Preference Key name: AutomaticDownloadsBlockedForUrls
- Example value:

```xml
<array>
  <string>https://contoso.com</string>
  <string>[*.]contoso.com</string>
</array>
```