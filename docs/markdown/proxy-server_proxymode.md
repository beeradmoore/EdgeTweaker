---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProxyMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proxymode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure proxy server settings (deprecated)'
locale: en-us
document_id: dfdc2b0e-dd42-0bab-2663-676421675efd
document_version_independent_id: dfdc2b0e-dd42-0bab-2663-676421675efd
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProxyMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ProxyMode.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 401
asset_id: microsoft-edge-policies/proxymode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProxyMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 26f018f5-fe44-0a32-2cda-33b2e7fbf62e
---

# Microsoft Edge Browser Policy Documentation ProxyMode | Microsoft Learn

## Configure proxy server settings (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: Not supported

## Description

This policy is deprecated and doesn't work in Microsoft Edge version 91. Use [ProxySettings](proxysettings) instead.

If you set this policy to Enabled, you can specify the proxy server Microsoft Edge uses and prevents users from changing proxy settings. Microsoft Edge ignores all proxy-related options specified from the command line. The policy is only applied if the [ProxySettings](proxysettings) policy isn't specified.

Other options are ignored if you choose one of the following options:

- direct = Never use a proxy server and always connect directly
- system = Use system proxy settings
- auto\_detect = Auto detect the proxy server

If you choose to use:

- fixed\_servers = Fixed proxy servers. You can specify further options with [ProxyServer](proxyserver) and [ProxyBypassList](proxybypasslist).
- pac\_script = A .pac proxy script. Use [ProxyPacUrl](proxypacurl) to set the URL to a proxy .pac file.

For detailed examples, go to https://go.microsoft.com/fwlink/?linkid=2094936.

If you don't configure this policy, users can choose their own proxy settings.

Policy options mapping:

- ProxyDisabled (direct) = Never use a proxy
- ProxyAutoDetect (auto\_detect) = Auto detect proxy settings
- ProxyPacScript (pac\_script) = Use a .pac proxy script
- ProxyFixedServers (fixed\_servers) = Use fixed proxy servers
- ProxyUseSystem (system) = Use system proxy settings

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- ProxyDisabled (direct) = Never use a proxy
- ProxyAutoDetect (auto\_detect) = Auto detect proxy settings
- ProxyPacScript (pac\_script) = Use a .pac proxy script
- ProxyFixedServers (fixed\_servers) = Use fixed proxy servers
- ProxyUseSystem (system) = Use system proxy settings

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

- GP unique name: ProxyMode
- GP name: Configure proxy server settings (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Never use a proxy
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProxyMode
- Value type: REG\_SZ

#### Example registry value

```
direct
```

## Mac information and settings

- Preference Key name: ProxyMode
- Example value:

```xml
<string>direct</string>
```

## Android information and settings

- Preference Key name: ProxyMode
- Example value:

```
direct
```