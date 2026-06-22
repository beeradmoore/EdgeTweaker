---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowDeletingBrowserHistory | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowdeletingbrowserhistory
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable deleting browser and download history'
locale: en-us
document_id: 88b85c89-88ac-a03f-98ba-b38d9d53bae3
document_version_independent_id: 88b85c89-88ac-a03f-98ba-b38d9d53bae3
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowDeletingBrowserHistory.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/AllowDeletingBrowserHistory.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 267
asset_id: microsoft-edge-policies/allowdeletingbrowserhistory
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowDeletingBrowserHistory.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e465a522-5c8e-c87c-72d6-3fe69be2ad09
---

# Microsoft Edge Browser Policy Documentation AllowDeletingBrowserHistory | Microsoft Learn

## Enable deleting browser and download history

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Enables deleting browser history and download history and prevents users from changing this setting.

Even if this policy is disabled, the browsing and download history aren't guaranteed to be retained: users can edit or delete the history database files directly, and the browser itself can remove (based on expiration period) or archive any or all history items at any time.

If you enable this policy or don't configure it, users can delete the browsing and download history.

If you disable this policy, users can't delete browsing and download history. Disabling this policy disables history sync and open tab sync.

If you enable this policy, don't enable the [ClearBrowsingDataOnExit](clearbrowsingdataonexit) policy, because they both deal with deleting data. If you enable both, the [ClearBrowsingDataOnExit](clearbrowsingdataonexit) policy takes precedence and deletes all data when Microsoft Edge closes, regardless of how this policy is configured.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllowDeletingBrowserHistory
- GP name: Enable deleting browser and download history
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AllowDeletingBrowserHistory
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AllowDeletingBrowserHistory
- Example value:

```xml
<true/>
```