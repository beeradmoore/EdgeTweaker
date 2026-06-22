---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ThrottleNonVisibleCrossOriginIframesAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/throttlenonvisiblecrossoriginiframesallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allows enabling throttling of non-visible, cross-origin iframes (obsolete)'
locale: en-us
document_id: 3695295d-ff8b-f4a5-7c81-91193f91cab5
document_version_independent_id: 3695295d-ff8b-f4a5-7c81-91193f91cab5
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ThrottleNonVisibleCrossOriginIframesAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/ThrottleNonVisibleCrossOriginIframesAllowed.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 218
asset_id: microsoft-edge-policies/throttlenonvisiblecrossoriginiframesallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ThrottleNonVisibleCrossOriginIframesAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b4296c58-3d0a-7b23-0e55-b233906f716b
---

# Microsoft Edge Browser Policy Documentation ThrottleNonVisibleCrossOriginIframesAllowed | Microsoft Learn

## Allows enabling throttling of non-visible, cross-origin iframes (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 123.

## Supported versions

- Windows: 116-123
- macOS: 116-123
- Android: Not supported
- iOS: Not supported

## Description

Throttling of cross-origin frames that are display:none and nonvisible is a feature designed to make cross-process and same-process cross-origin frames consistent in their rendering behavior. For more information on cross-process vs. same-process throttling, see https://go.microsoft.com/fwlink/?linkid=2239564.

This enterprise policy allows administrators to control whether their users can turn on the additional throttling or not.

If you enable or don't configure this policy, users can opt in to throttling.

If you disable this policy, users can't enable throttling.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ThrottleNonVisibleCrossOriginIframesAllowed
- GP name: Allows enabling throttling of non-visible, cross-origin iframes (obsolete)
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
- Value name: ThrottleNonVisibleCrossOriginIframesAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ThrottleNonVisibleCrossOriginIframesAllowed
- Example value:

```xml
<true/>
```