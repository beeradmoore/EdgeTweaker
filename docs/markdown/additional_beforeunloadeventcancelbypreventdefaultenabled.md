---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BeforeunloadEventCancelByPreventDefaultEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/beforeunloadeventcancelbypreventdefaultenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the behavior for the cancel dialog produced by the beforeunload event (obsolete)'
locale: en-us
document_id: c9bdb186-fee0-b9ac-2666-919b80de3015
document_version_independent_id: c9bdb186-fee0-b9ac-2666-919b80de3015
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BeforeunloadEventCancelByPreventDefaultEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/BeforeunloadEventCancelByPreventDefaultEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 271
asset_id: microsoft-edge-policies/beforeunloadeventcancelbypreventdefaultenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BeforeunloadEventCancelByPreventDefaultEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b9d04f2b-d7ca-c708-c1d1-c77582b7b296
---

# Microsoft Edge Browser Policy Documentation BeforeunloadEventCancelByPreventDefaultEnabled | Microsoft Learn

## Control the behavior for the cancel dialog produced by the beforeunload event (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 130.

## Supported versions

- Windows: 118-130
- macOS: 118-130
- Android: Not supported
- iOS: Not supported

## Description

This policy provides a temporary opt-out for two related fixes to the behavior of the confirmation dialog that’s shown by the beforeunload event.

If you've enabled this policy, the new (correct) behavior is used. If you've disabled this policy, the old (legacy) behavior is used. If you haven't configured this policy, the default behavior is used. Note: This policy is a temporary workaround and is going to be removed in a future release.

New and correct behavior: In `beforeunload`, calling `event.preventDefault()` triggers the confirmation dialog. Setting `event.returnValue` to the empty string doesn’t trigger the confirmation dialog.

Old and legacy behavior: In `beforeunload`, calling `event.preventDefault()` doesn’t trigger the confirmation dialog. Setting `event.returnValue` to the empty string triggers the confirmation dialog.

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

- GP unique name: BeforeunloadEventCancelByPreventDefaultEnabled
- GP name: Control the behavior for the cancel dialog produced by the beforeunload event (obsolete)
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
- Value name: BeforeunloadEventCancelByPreventDefaultEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: BeforeunloadEventCancelByPreventDefaultEnabled
- Example value:

```xml
<true/>
```