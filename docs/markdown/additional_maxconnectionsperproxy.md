---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MaxConnectionsPerProxy | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/maxconnectionsperproxy
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Maximum number of concurrent connections to the proxy server for non-WebSocket requests'
locale: en-us
document_id: ddcd3f2b-15b2-380a-1050-484f99f9570e
document_version_independent_id: ddcd3f2b-15b2-380a-1050-484f99f9570e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MaxConnectionsPerProxy.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/MaxConnectionsPerProxy.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 293
asset_id: microsoft-edge-policies/maxconnectionsperproxy
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MaxConnectionsPerProxy.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b208cec3-810f-26ba-0a36-278391f61bfb
---

# Microsoft Edge Browser Policy Documentation MaxConnectionsPerProxy | Microsoft Learn

## Maximum number of concurrent connections to the proxy server for non-WebSocket requests

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 149
- iOS: Not supported

## Description

Specifies the maximum number of simultaneous connections to a proxy server for non-WebSocket requests.

Some proxy servers cannot handle a high number of concurrent connections per client. In these cases, reducing the value of this policy can improve reliability.

However, some web applications maintain multiple long-lived connections (for example, hanging GET requests). Setting a value lower than the default may cause browser networking hangs if many such applications are open.

To modify WebSocket request limits, see [MaxConnectionsPerProxyForWebSocket](maxconnectionsperproxyforwebsocket).

If you don't configure this policy, the default value of 128 is used.

The value must be between 6 and 256:

- Values lower than 6 are treated as 6.
- Values higher than 256 are treated as 256 (99 in versions of Microsoft Edge 148 and earlier).

We recommend changing this value from the default only if required by your proxy server configuration.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: MaxConnectionsPerProxy
- GP name: Maximum number of concurrent connections to the proxy server for non-WebSocket requests
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
32
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: MaxConnectionsPerProxy
- Value type: REG\_DWORD

#### Example registry value

```
0x00000020
```

## Mac information and settings

- Preference Key name: MaxConnectionsPerProxy
- Example value:

```xml
<integer>32</integer>
```

## Android information and settings

- Preference Key name: MaxConnectionsPerProxy
- Example value:

```
32
```