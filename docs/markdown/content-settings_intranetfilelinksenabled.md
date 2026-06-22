---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation IntranetFileLinksEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/intranetfilelinksenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow intranet zone file URL links from Microsoft Edge to open in Windows File Explorer'
locale: en-us
document_id: 97aea45e-1d14-2980-7a59-3ac942d1a4ff
document_version_independent_id: 97aea45e-1d14-2980-7a59-3ac942d1a4ff
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/IntranetFileLinksEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/IntranetFileLinksEnabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 280
asset_id: microsoft-edge-policies/intranetfilelinksenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/IntranetFileLinksEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: adfce92c-588a-edac-adf9-8803f32f8e74
---

# Microsoft Edge Browser Policy Documentation IntranetFileLinksEnabled | Microsoft Learn

## Allow intranet zone file URL links from Microsoft Edge to open in Windows File Explorer

## Supported versions

- Windows: ≥ 95
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting allows file URL links to intranet zone files from intranet zone HTTPS websites to open Windows File Explorer for that file or directory.

If you enable this policy, intranet zone file URL links originating from intranet zone HTTPS pages open Windows File Explorer to the parent directory of the file and select the file. Intranet zone directory URL links originating from intranet zone HTTPS pages open Windows File Explorer to the directory with no items in the directory selected.

If you disable or don't configure this policy, file URL links don't open.

Microsoft Edge uses the definition of intranet zone as configured for Internet Explorer. https://localhost/ is blocked as an exception of allowed intranet zone host, while loopback addresses (127.0.0.\*, [::1]) are considered internet zone by default.

Users may opt out of prompts on a per-protocol/per-site basis unless the [ExternalProtocolDialogShowAlwaysOpenCheckbox](externalprotocoldialogshowalwaysopencheckbox) policy is disabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: IntranetFileLinksEnabled
- GP name: Allow intranet zone file URL links from Microsoft Edge to open in Windows File Explorer
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: IntranetFileLinksEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```