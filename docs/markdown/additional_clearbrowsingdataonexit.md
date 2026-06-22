---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ClearBrowsingDataOnExit | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/clearbrowsingdataonexit
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Clear browsing data when Microsoft Edge closes'
locale: en-us
document_id: 437a3075-2b2d-ce35-3fde-0e0e7201282f
document_version_independent_id: 437a3075-2b2d-ce35-3fde-0e0e7201282f
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ClearBrowsingDataOnExit.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/ClearBrowsingDataOnExit.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 285
asset_id: microsoft-edge-policies/clearbrowsingdataonexit
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ClearBrowsingDataOnExit.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 877c918c-132e-6db8-304e-ca3d87519e45
---

# Microsoft Edge Browser Policy Documentation ClearBrowsingDataOnExit | Microsoft Learn

## Clear browsing data when Microsoft Edge closes

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge doesn't clear the browsing data by default when it closes. Browsing data includes information entered in forms, passwords, and even the websites visited.

If you enable this policy, all browsing data is deleted each time Microsoft Edge closes. Note that if you enable this policy, it takes precedence over how you configured [DefaultCookiesSetting](defaultcookiessetting)

If you disable or don't configure this policy, users can configure the Clear browsing data option in Settings.

If you enable this policy, don't configure the [AllowDeletingBrowserHistory](allowdeletingbrowserhistory) or the [ClearCachedImagesAndFilesOnExit](clearcachedimagesandfilesonexit) policy, because they all deal with deleting browsing data. If you configure the preceding policies and this policy, all browsing data is deleted when Microsoft Edge closes, regardless of how you configured [AllowDeletingBrowserHistory](allowdeletingbrowserhistory) or [ClearCachedImagesAndFilesOnExit](clearcachedimagesandfilesonexit).

To exclude cookies from being deleted on exit, configure the [SaveCookiesOnExit](savecookiesonexit) policy. To exclude passwords from being deleted on exit, configure the [PasswordDeleteOnBrowserCloseEnabled](passworddeleteonbrowsercloseenabled) policy.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ClearBrowsingDataOnExit
- GP name: Clear browsing data when Microsoft Edge closes
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ClearBrowsingDataOnExit
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ClearBrowsingDataOnExit
- Example value:

```xml
<true/>
```