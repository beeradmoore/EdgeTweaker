---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProxyServer | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proxyserver
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure address or URL of proxy server (deprecated)'
locale: en-us
document_id: 6e77f7f2-0d1f-2414-f329-04d23a13ad9a
document_version_independent_id: 6e77f7f2-0d1f-2414-f329-04d23a13ad9a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProxyServer.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ProxyServer.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 276
asset_id: microsoft-edge-policies/proxyserver
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProxyServer.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7edf630a-c416-e2b7-930e-da9b00e0ab5e
---

# Microsoft Edge Browser Policy Documentation ProxyServer | Microsoft Learn

## Configure address or URL of proxy server (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: Not supported

## Description

This policy is deprecated, use [ProxySettings](proxysettings) instead. It doesn't work in Microsoft Edge version 91.

Specifies the URL of the proxy server.

This policy is applied only if the [ProxySettings](proxysettings) policy isn't specified and you selected fixed\_servers in the [ProxyMode](proxymode) policy. If you selected any other mode for configuring proxy policies, don't enable or configure this policy.

If you enable this policy, the proxy server configured by this policy is used for all URLs.

If you disable or don't configure this policy, users can choose their own proxy settings while in this proxy mode. Leave this policy unconfigured if you specified any other method for setting proxy policies.

For more options and detailed examples, see https://go.microsoft.com/fwlink/?linkid=2094936.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ProxyServer
- GP name: Configure address or URL of proxy server (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
123.123.123.123:8080
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProxyServer
- Value type: REG\_SZ

#### Example registry value

```
123.123.123.123:8080
```

## Mac information and settings

- Preference Key name: ProxyServer
- Example value:

```xml
<string>123.123.123.123:8080</string>
```

## Android information and settings

- Preference Key name: ProxyServer
- Example value:

```
123.123.123.123:8080
```