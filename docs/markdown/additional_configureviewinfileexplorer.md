---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ConfigureViewInFileExplorer | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/configureviewinfileexplorer
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the View in File Explorer feature for SharePoint pages in Microsoft Edge'
locale: en-us
document_id: 034fc901-843f-b2b0-3d9a-2588c2d0a651
document_version_independent_id: 034fc901-843f-b2b0-3d9a-2588c2d0a651
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ConfigureViewInFileExplorer.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/ConfigureViewInFileExplorer.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 384
asset_id: microsoft-edge-policies/configureviewinfileexplorer
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ConfigureViewInFileExplorer.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/9d7be3ef-f27c-4c7f-9eba-67c3cd429995
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/feeb50f3-b677-44f9-b3a6-5f2f58182b0d
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b42a01a4-d4a9-0c49-364f-9774da80d2e7
---

# Microsoft Edge Browser Policy Documentation ConfigureViewInFileExplorer | Microsoft Learn

## Configure the View in File Explorer feature for SharePoint pages in Microsoft Edge

## Supported versions

- Windows: ≥ 93
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting allows you to configure the View in File Explorer capability for file management in SharePoint Online while using Microsoft Edge.

You'll need to list the specific domains where this is allowed and list cookies needed for SharePoint authentication (rtFa and FedAuth).

Behind the scenes, the policy allows URLs with the viewinfileexplorer: scheme to open WebDAV URLs in Windows File Explorer on pages matching the list of domains and uses the cookies you specified for WebDAV authentication.

If you enable this policy, you can use the "View in File Explorer" feature on the SharePoint document libraries you list. You'll need to specify the SharePoint domain and authentication cookies. See example value below.

If you disable or don't configure this policy, you can't use the "View in File Explorer" feature on SharePoint document libraries.

Note that while this is an available option through Microsoft Edge, rather than use the View in File Explorer option, the recommended approach to managing files and folders outside of SharePoint is to sync your SharePoint files or move or copy files in SharePoint. Sync your SharePoint files: https://go.microsoft.com/fwlink/p/?linkid=2166983 Move or copy files in SharePoint: https://go.microsoft.com/fwlink/p/?linkid=2167123

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, or Windows 10 Pro or Enterprise instances enrolled for device management.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ConfigureViewInFileExplorer
- GP name: Configure the View in File Explorer feature for SharePoint pages in Microsoft Edge
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"cookies": ["rtFa", "FedAuth"], "domain": "contoso.sharepoint.com"}, {"cookies": ["rtFa", "FedAuth"], "domain": "contoso2.sharepoint.com"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ConfigureViewInFileExplorer
- Value type: REG\_SZ

#### Example registry value

```
[{"cookies": ["rtFa", "FedAuth"], "domain": "contoso.sharepoint.com"}, {"cookies": ["rtFa", "FedAuth"], "domain": "contoso2.sharepoint.com"}]
```

#### Expanded example registry value

```
[
  {
    "cookies": [
      "rtFa",
      "FedAuth"
    ],
    "domain": "contoso.sharepoint.com"
  },
  {
    "cookies": [
      "rtFa",
      "FedAuth"
    ],
    "domain": "contoso2.sharepoint.com"
  }
]
```