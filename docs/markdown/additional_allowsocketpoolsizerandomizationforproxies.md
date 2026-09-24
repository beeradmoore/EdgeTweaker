---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowSocketPoolSizeRandomizationForProxies | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowsocketpoolsizerandomizationforproxies
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow socket pool size randomization for proxies'
locale: en-us
document_id: bda3cbec-c1d6-e9f6-7666-28d8d3e965ad
document_version_independent_id: bda3cbec-c1d6-e9f6-7666-28d8d3e965ad
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowSocketPoolSizeRandomizationForProxies.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/AllowSocketPoolSizeRandomizationForProxies.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 301
asset_id: microsoft-edge-policies/allowsocketpoolsizerandomizationforproxies
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowSocketPoolSizeRandomizationForProxies.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 39069f8b-c54d-4f34-1c69-b4504081134c
---

# Microsoft Edge Browser Policy Documentation AllowSocketPoolSizeRandomizationForProxies | Microsoft Learn

## Allow socket pool size randomization for proxies

## Supported versions

- Windows: ≥ 150
- macOS: ≥ 150
- Android: ≥ 150
- iOS: Not supported

## Description

Controls whether Microsoft Edge randomizes socket pool sizes for proxy connections.

Socket pool size randomization is a security mechanism that helps prevent attackers from using deterministic connection limits to infer cross-site information. For example, if the configured proxy socket pool limit is 128, Microsoft Edge can randomly set the effective limit between 128 and 256. This can allow up to twice as many proxy connections, though the expected increase is closer to 1.2x in practice.

This policy affects the limits configured by the [MaxConnectionsPerProxy](maxconnectionsperproxy) and [MaxConnectionsPerProxyForWebSocket](maxconnectionsperproxyforwebsocket) policies. When this policy is enabled, the effective upper limit can be randomized up to 2x the values configured by those policies.

If you enable this policy or don't configure it, Microsoft Edge enables socket pool size randomization for proxy connections.

If you disable this policy, Microsoft Edge disables socket pool size randomization for proxy connections. The values configured by [MaxConnectionsPerProxy](maxconnectionsperproxy) and [MaxConnectionsPerProxyForWebSocket](maxconnectionsperproxyforwebsocket) are used as the upper limits without randomization.

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

- GP unique name: AllowSocketPoolSizeRandomizationForProxies
- GP name: Allow socket pool size randomization for proxies
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
- Value name: AllowSocketPoolSizeRandomizationForProxies
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AllowSocketPoolSizeRandomizationForProxies
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AllowSocketPoolSizeRandomizationForProxies
- Example value:

```
true
```