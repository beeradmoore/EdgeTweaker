---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BackForwardCacheForWebSocketsAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/backforwardcacheforwebsocketsallowed
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-08-05T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Back/Forward Cache for WebSockets'
locale: en-us
document_id: 24f641c5-29a2-4481-9a13-96d6e62f3d80
document_version_independent_id: 24f641c5-29a2-4481-9a13-96d6e62f3d80
updated_at: 2026-08-05T22:47:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BackForwardCacheForWebSocketsAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/2a7d54003b65970728477e7826af3ddf75dacaf3/edgeenterprise/microsoft-edge-policies/BackForwardCacheForWebSocketsAllowed.md
git_commit_id: 2a7d54003b65970728477e7826af3ddf75dacaf3
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 258
asset_id: microsoft-edge-policies/backforwardcacheforwebsocketsallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BackForwardCacheForWebSocketsAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0913e0c4-dda7-3cd4-b6c5-89dd3f643c49
---

# Microsoft Edge Browser Policy Documentation BackForwardCacheForWebSocketsAllowed | Microsoft Learn

## Allow Back/Forward Cache for WebSockets

## Supported versions

- Windows: ≥ 152
- macOS: ≥ 152
- Android: ≥ 152
- iOS: Not supported

## Description

This policy controls whether active WebSocket connections are disconnected when a page enters back/forward cache. Active WebSocket connections previously prevented a page from being stored in back/forward cache, but Microsoft Edge has changed this behavior to disconnect the WebSockets instead, allowing the page to be cached and restoring it in a disconnected state.

If this policy is set to Enabled or left unset, WebSockets are disconnected when a page enters back/forward cache.

If this policy is set to Disabled, WebSockets will not be disconnected when a page enters back/forward cache. Since back/forward cache does not support active WebSockets, this means pages with active WebSockets will not be cached.

This policy is intended to be temporary and will be removed in the future.

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

- GP unique name: BackForwardCacheForWebSocketsAllowed
- GP name: Allow Back/Forward Cache for WebSockets
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
- Value name: BackForwardCacheForWebSocketsAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: BackForwardCacheForWebSocketsAllowed
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: BackForwardCacheForWebSocketsAllowed
- Example value:

```
true
```