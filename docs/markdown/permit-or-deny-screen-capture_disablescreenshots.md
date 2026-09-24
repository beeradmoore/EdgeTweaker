---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DisableScreenshots | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/disablescreenshots
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-09-11T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable taking screenshots'
locale: en-us
document_id: cfb8e8d1-fe33-8bf0-19ec-bc52a27e962b
document_version_independent_id: cfb8e8d1-fe33-8bf0-19ec-bc52a27e962b
updated_at: 2026-09-11T20:36:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DisableScreenshots.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/bad5d510d6c89974a30e53029e162d63c894b1ea/edgeenterprise/microsoft-edge-policies/DisableScreenshots.md
git_commit_id: bad5d510d6c89974a30e53029e162d63c894b1ea
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 227
asset_id: microsoft-edge-policies/disablescreenshots
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DisableScreenshots.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 27fa46ce-d356-3af3-779c-c1f5fecea8dc
---

# Microsoft Edge Browser Policy Documentation DisableScreenshots | Microsoft Learn

## Disable taking screenshots

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 146
- iOS: Not supported

## Description

Controls if users can take screenshots of the browser page.

If you enable this policy, users can't take screenshots using keyboard shortcuts or extension APIs.

If you disable or don't configure this policy, users can take screenshots.

As of Microsoft Edge version 154, enabling this policy also prevents extensions from attaching the debugger via 'chrome.debugger.attach()'.

Note: Even if you disable screenshots using this policy, users might still be able to take screenshots using Web Capture within the browser or other methods outside of the browser. For example, using an operating system feature or another application.

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

- GP unique name: DisableScreenshots
- GP name: Disable taking screenshots
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
- Value name: DisableScreenshots
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DisableScreenshots
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: DisableScreenshots
- Example value:

```
true
```