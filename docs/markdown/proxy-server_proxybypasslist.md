---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProxyBypassList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proxybypasslist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure proxy bypass rules (deprecated)'
locale: en-us
document_id: 4c16ac64-b4e8-d2dd-759c-4e702b1963de
document_version_independent_id: 4c16ac64-b4e8-d2dd-759c-4e702b1963de
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProxyBypassList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ProxyBypassList.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 283
asset_id: microsoft-edge-policies/proxybypasslist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProxyBypassList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 82944c25-3567-a65c-9578-e97019b74831
---

# Microsoft Edge Browser Policy Documentation ProxyBypassList | Microsoft Learn

## Configure proxy bypass rules (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: Not supported

## Description

This policy is deprecated, use [ProxySettings](proxysettings) instead. It doesn't work in Microsoft Edge version 91.

Defines a list of hosts for which Microsoft Edge bypasses any proxy.

This policy is applied only if the [ProxySettings](proxysettings) policy isn't specified and you selected either fixed\_servers or pac\_script in the [ProxyMode](proxymode) policy. If you selected any other mode for configuring proxy policies, don't enable or configure this policy.

If you enable this policy, you can create a list of hosts for which Microsoft Edge doesn't use a proxy.

If you don't configure this policy, no list of hosts is created for which Microsoft Edge bypasses a proxy. Leave this policy unconfigured if you specified any other method for setting proxy policies.

For more detailed examples, go to https://go.microsoft.com/fwlink/?linkid=2094936.

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

- GP unique name: ProxyBypassList
- GP name: Configure proxy bypass rules (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com, https://www.fabrikam.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProxyBypassList
- Value type: REG\_SZ

#### Example registry value

```
https://www.contoso.com, https://www.fabrikam.com
```

## Mac information and settings

- Preference Key name: ProxyBypassList
- Example value:

```xml
<string>https://www.contoso.com, https://www.fabrikam.com</string>
```

## Android information and settings

- Preference Key name: ProxyBypassList
- Example value:

```
https://www.contoso.com, https://www.fabrikam.com
```