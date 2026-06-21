---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowSyncXHRInPageDismissal | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowsyncxhrinpagedismissal
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow pages to send synchronous XHR requests during page dismissal (obsolete)'
locale: en-us
document_id: 8bb2982c-40e0-ddfc-05ca-70db78d5f0d4
document_version_independent_id: 8bb2982c-40e0-ddfc-05ca-70db78d5f0d4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowSyncXHRInPageDismissal.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AllowSyncXHRInPageDismissal.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 266
asset_id: microsoft-edge-policies/allowsyncxhrinpagedismissal
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowSyncXHRInPageDismissal.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9b0fd838-d312-4cf0-4e4a-bbdcdf385369
---

# Microsoft Edge Browser Policy Documentation AllowSyncXHRInPageDismissal | Microsoft Learn

## Allow pages to send synchronous XHR requests during page dismissal (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 99.

## Supported versions

- Windows: 79-99
- macOS: 79-99
- Android: 78-99
- iOS: Not supported

## Description

This policy is obsolete because it was only intended to be a short-term mechanism to give enterprises more time to update their web content if and when it was found to be incompatible with the change to disallow synchronous XHR requests during page dismissal. It doesn't work in Microsoft Edge after version 99.

This policy lets you specify that a page can send synchronous XHR requests during page dismissal.

If you enable this policy, pages can send synchronous XHR requests during page dismissal.

If you disable this policy or don't configure this policy, pages aren't allowed to send synchronous XHR requests during page dismissal.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllowSyncXHRInPageDismissal
- GP name: Allow pages to send synchronous XHR requests during page dismissal (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AllowSyncXHRInPageDismissal
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: AllowSyncXHRInPageDismissal
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: AllowSyncXHRInPageDismissal
- Example value:

```
false
```