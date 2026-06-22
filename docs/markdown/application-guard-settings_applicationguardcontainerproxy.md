---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ApplicationGuardContainerProxy | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/applicationguardcontainerproxy
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Application Guard Container Proxy'
locale: en-us
document_id: 92dcfe4b-9911-1283-b7bc-d22740e04be4
document_version_independent_id: 92dcfe4b-9911-1283-b7bc-d22740e04be4
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ApplicationGuardContainerProxy.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/ApplicationGuardContainerProxy.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 344
asset_id: microsoft-edge-policies/applicationguardcontainerproxy
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ApplicationGuardContainerProxy.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: aa60a17f-e7c1-eba6-1e10-95f6e80ea325
---

# Microsoft Edge Browser Policy Documentation ApplicationGuardContainerProxy | Microsoft Learn

## Application Guard Container Proxy

## Supported versions

- Windows: ≥ 84
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configures the proxy settings for Microsoft Edge Application Guard.

If you enable this policy, Microsoft Edge Application Guard ignores other sources of proxy configurations.

If you don't configure this policy, Microsoft Edge Application Guard uses the proxy configuration of the host.

This policy doesn't affect the proxy configuration of Microsoft Edge outside of Application Guard (on the host).

The ProxyMode field lets you specify the proxy server used by Microsoft Edge Application Guard.

The ProxyPacUrl field is a URL to a proxy.pac file. This policy doesn't affect the proxy configuration of Microsoft Edge outside of Application Guard (on the host).

The ProxyMode field lets you specify the proxy server that's used by Microsoft Edge Application Guard.

The ProxyPacUrl field is a URL for a proxy .pac file.

The ProxyServer field is a URL for the proxy server.

If you choose the 'direct' value as 'ProxyMode', all the other fields are ignored.

If you choose the 'auto\_detect' value as 'ProxyMode', all the other fields are ignored.

If you choose the 'fixed\_servers' value as 'ProxyMode', the 'ProxyServer' field is used.

If you choose the 'pac\_script' value as 'ProxyMode', the 'ProxyPacUrl' field is used.

For more information about identifying Application Guard traffic via dual proxy, see https://go.microsoft.com/fwlink/?linkid=2134653.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ApplicationGuardContainerProxy
- GP name: Application Guard Container Proxy
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Application Guard settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"ProxyMode": "direct", "ProxyPacUrl": "https://internal.site/example.pac", "ProxyServer": "123.123.123.123:8080"}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ApplicationGuardContainerProxy
- Value type: REG\_SZ

#### Example registry value

```
{"ProxyMode": "direct", "ProxyPacUrl": "https://internal.site/example.pac", "ProxyServer": "123.123.123.123:8080"}
```

#### Expanded example registry value

```
{
  "ProxyMode": "direct",
  "ProxyPacUrl": "https://internal.site/example.pac",
  "ProxyServer": "123.123.123.123:8080"
}
```