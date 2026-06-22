---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceForegroundPriorityForAllTabs | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forceforegroundpriorityforalltabs
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force foreground priority for all tabs'
locale: en-us
document_id: 9b468f4a-e7c6-1070-39f8-a2e9b6f220cd
document_version_independent_id: 9b468f4a-e7c6-1070-39f8-a2e9b6f220cd
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceForegroundPriorityForAllTabs.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/ForceForegroundPriorityForAllTabs.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 232
asset_id: microsoft-edge-policies/forceforegroundpriorityforalltabs
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceForegroundPriorityForAllTabs.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 24bb93ce-754c-f988-ad77-5934b5cac620
---

# Microsoft Edge Browser Policy Documentation ForceForegroundPriorityForAllTabs | Microsoft Learn

## Force foreground priority for all tabs

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether background web content runs at foreground priority.

By default, the browser optimizes resource usage by lowering the scheduling priority of content in background tabs. This helps improve overall system responsiveness and performance for the active tab.

If you enable this policy, background web content runs at the same foreground priority as the active tab, regardless of visibility state.

If you disable or don't configure this policy, the browser determines the priority of web content based on standard heuristics. For example, content that is not visible, not playing audio, and not participating in video calls may be deprioritized.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceForegroundPriorityForAllTabs
- GP name: Force foreground priority for all tabs
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
- Value name: ForceForegroundPriorityForAllTabs
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ForceForegroundPriorityForAllTabs
- Example value:

```xml
<true/>
```