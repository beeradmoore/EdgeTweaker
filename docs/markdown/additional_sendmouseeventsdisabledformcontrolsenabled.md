---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SendMouseEventsDisabledFormControlsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sendmouseeventsdisabledformcontrolsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control the new behavior for event dispatching on disabled form controls (obsolete)'
locale: en-us
document_id: dbd89e90-0222-6ce2-1a4c-febcb6372f58
document_version_independent_id: dbd89e90-0222-6ce2-1a4c-febcb6372f58
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SendMouseEventsDisabledFormControlsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/SendMouseEventsDisabledFormControlsEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 272
asset_id: microsoft-edge-policies/sendmouseeventsdisabledformcontrolsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SendMouseEventsDisabledFormControlsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/97159432-14a9-4307-a469-d2f2c75f0e33
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/50565c62-5f6b-4687-be38-323113c72c2e
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 09ce641d-9064-5652-9ebb-7204d28ac3a4
---

# Microsoft Edge Browser Policy Documentation SendMouseEventsDisabledFormControlsEnabled | Microsoft Learn

## Control the new behavior for event dispatching on disabled form controls (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 120.

## Supported versions

- Windows: 109-120
- macOS: 109-120
- Android: Not supported
- iOS: Not supported

## Description

Event dispatching on disabled form controls is being changed in Microsoft Edge to improve compatibility with other browsers and to improve the developer experience.

With this change, MouseEvents get dispatched on disabled form control elements. Exceptions for this behavior are click, mouseup, and mousedown. Some examples of the new events are mousemove, mouseenter, and mouseleave.

This change also truncates the event path of click, mouseup, and mousedown when they’re dispatched on children of disabled form controls. These events aren’t dispatched on the disabled form control or on any of its ancestors.

Note: This new behavior might break some websites.

If you enable or don't configure this policy, the new behavior is used.

If you disable this policy, the old behavior is used.

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

- GP unique name: SendMouseEventsDisabledFormControlsEnabled
- GP name: Control the new behavior for event dispatching on disabled form controls (obsolete)
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
- Value name: SendMouseEventsDisabledFormControlsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SendMouseEventsDisabledFormControlsEnabled
- Example value:

```xml
<true/>
```