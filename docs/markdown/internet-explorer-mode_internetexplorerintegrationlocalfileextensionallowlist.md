---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalFileExtensionAllowList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationlocalfileextensionallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Open local files in Internet Explorer mode file extension allow list'
locale: en-us
document_id: ac44c27b-aa8f-0260-c37f-c4fc256d08b5
document_version_independent_id: ac44c27b-aa8f-0260-c37f-c4fc256d08b5
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalFileExtensionAllowList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalFileExtensionAllowList.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/internetexplorerintegrationlocalfileextensionallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationLocalFileExtensionAllowList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 73300fc4-d8b3-906c-8331-7e43dfc359d4
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationLocalFileExtensionAllowList | Microsoft Learn

## Open local files in Internet Explorer mode file extension allow list

## Supported versions

- Windows: ≥ 88
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy limits which file:// URLs are allowed to launch into Internet Explorer mode based on file extension.

This setting works when [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) is set to 'IEMode'.

When a file:// URL is requested to launch in Internet Explorer mode, the file extension of the URL must be present in this list for the URL to be allowed to launch in Internet Explorer mode. A URL that's blocked from opening in Internet Explorer mode is instead opened in Microsoft Edge mode.

If you set this policy to the special value "\*" or don't configure it, all file extensions are allowed.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2094210

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

- GP unique name: InternetExplorerIntegrationLocalFileExtensionAllowList
- GP name: Open local files in Internet Explorer mode file extension allow list
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
.mht
```

```
.pdf
```

```
.vsdx
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\InternetExplorerIntegrationLocalFileExtensionAllowList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\InternetExplorerIntegrationLocalFileExtensionAllowList\1 =

```
.mht
```

SOFTWARE\Policies\Microsoft\Edge\InternetExplorerIntegrationLocalFileExtensionAllowList\2 =

```
.pdf
```

SOFTWARE\Policies\Microsoft\Edge\InternetExplorerIntegrationLocalFileExtensionAllowList\3 =

```
.vsdx
```