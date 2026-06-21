---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RestoreOnStartupURLs | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/restoreonstartupurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Sites to open when the browser starts'
locale: en-us
document_id: 6a886257-837f-353b-f3d5-95419efd275c
document_version_independent_id: 6a886257-837f-353b-f3d5-95419efd275c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RestoreOnStartupURLs.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RestoreOnStartupURLs.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 241
asset_id: microsoft-edge-policies/restoreonstartupurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RestoreOnStartupURLs.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 543b9a12-7a20-2598-625d-164bc31c479f
---

# Microsoft Edge Browser Policy Documentation RestoreOnStartupURLs | Microsoft Learn

## Sites to open when the browser starts

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Specify a list of websites to open automatically when the browser starts. If you don't configure this policy, no site is opened on startup.

This policy only works if you also set the [RestoreOnStartup](restoreonstartup) policy to 'Open a list of URLs' (4).

This policy is available only on specific Windows instances. These instances include devices that are joined to a Microsoft Active Directory domain, devices joined to Microsoft Azure Active Directory`, or devices enrolled for device management.

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

- GP unique name: RestoreOnStartupURLs
- GP name: Sites to open when the browser starts
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Startup, home page and new tab page
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contoso.com
```

```
https://www.fabrikam.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\RestoreOnStartupURLs
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended\RestoreOnStartupURLs
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\RestoreOnStartupURLs\1 =

```
https://contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\RestoreOnStartupURLs\2 =

```
https://www.fabrikam.com
```

## Mac information and settings

- Preference Key name: RestoreOnStartupURLs
- Example value:

```xml
<array>
  <string>https://contoso.com</string>
  <string>https://www.fabrikam.com</string>
</array>
```