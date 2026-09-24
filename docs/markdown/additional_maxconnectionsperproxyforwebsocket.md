---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MaxConnectionsPerProxyForWebSocket | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/maxconnectionsperproxyforwebsocket
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Maximum number of concurrent connections to the proxy server for WebSocket requests'
locale: en-us
document_id: 8fff5b93-cff4-8e01-1b17-950771759a3a
document_version_independent_id: 8fff5b93-cff4-8e01-1b17-950771759a3a
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MaxConnectionsPerProxyForWebSocket.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/MaxConnectionsPerProxyForWebSocket.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 313
asset_id: microsoft-edge-policies/maxconnectionsperproxyforwebsocket
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MaxConnectionsPerProxyForWebSocket.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 847aa692-7127-2fc5-248f-a79520222bd6
---

# Microsoft Edge Browser Policy Documentation MaxConnectionsPerProxyForWebSocket | Microsoft Learn

## Maximum number of concurrent connections to the proxy server for WebSocket requests

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: ≥ 148
- iOS: Not supported

## Description

Specifies the maximum number of simultaneous connections to a proxy server for WebSocket requests.

To configure limits for non-WebSocket requests, see the [MaxConnectionsPerProxy](maxconnectionsperproxy) policy.

If you don't configure this policy, the default value of 128 is used.

Some web applications maintain multiple concurrent connections, such as long-lived or hanging requests. Setting a value lower than the default can cause networking delays when many of these applications are open.

Some proxy servers can't handle a high number of concurrent connections per client. In these cases, reducing this value might improve reliability.

The supported range is 6 to 256:

- Values less than 6 are treated as 6.
- Values greater than 256 are treated as 256.

When the [AllowSocketPoolSizeRandomizationForProxies](allowsocketpoolsizerandomizationforproxies) policy is enabled, which is the default, the effective upper limit can be randomized up to 2x the value specified by this policy as a security mechanism.

We recommend modifying this value only if required by your proxy server configuration or network environment.

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

- GP unique name: MaxConnectionsPerProxyForWebSocket
- GP name: Maximum number of concurrent connections to the proxy server for WebSocket requests
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
- Value name: MaxConnectionsPerProxyForWebSocket
- Value type: REG\_DWORD

#### Example registry value

```
0x00000020
```

## Mac information and settings

- Preference Key name: MaxConnectionsPerProxyForWebSocket
- Example value:

```xml
<integer>32</integer>
```

## Android information and settings

- Preference Key name: MaxConnectionsPerProxyForWebSocket
- Example value:

```
32
```