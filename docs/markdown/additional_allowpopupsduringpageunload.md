---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowPopupsDuringPageUnload | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowpopupsduringpageunload
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allows a page to show popups during its unloading (obsolete)'
locale: en-us
document_id: 2bd60ed1-d266-c078-8061-47703b94bd5f
document_version_independent_id: 2bd60ed1-d266-c078-8061-47703b94bd5f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowPopupsDuringPageUnload.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AllowPopupsDuringPageUnload.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 233
asset_id: microsoft-edge-policies/allowpopupsduringpageunload
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowPopupsDuringPageUnload.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5c5cd3c9-774f-882c-dd9a-67dcae3c71fa
---

# Microsoft Edge Browser Policy Documentation AllowPopupsDuringPageUnload | Microsoft Learn

## Allows a page to show popups during its unloading (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 87.

## Supported versions

- Windows: 78-87
- macOS: 78-87
- Android: 74-87
- iOS: Not supported

## Description

This policy allows an admin to specify that a page can show popups during its unloading.

When the policy is set to enabled, pages are allowed to show popups while they're being unloaded.

When the policy is set to disabled or unset, pages aren't allowed to show popups while they're being unloaded. This restriction is as per the spec: (https://html.spec.whatwg.org/#apis-for-creating-and-navigating-browsing-contexts-by-name).

This policy was removed in Microsoft Edge 88 and is ignored if set.

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

- GP unique name: AllowPopupsDuringPageUnload
- GP name: Allows a page to show popups during its unloading (obsolete)
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
- Value name: AllowPopupsDuringPageUnload
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: AllowPopupsDuringPageUnload
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: AllowPopupsDuringPageUnload
- Example value:

```
false
```