---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProxyPacUrl | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proxypacurl
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the proxy .pac file URL (deprecated)'
locale: en-us
document_id: d9eb0f8e-95f2-680b-4d52-28d85cc3aa3f
document_version_independent_id: d9eb0f8e-95f2-680b-4d52-28d85cc3aa3f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProxyPacUrl.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ProxyPacUrl.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 278
asset_id: microsoft-edge-policies/proxypacurl
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProxyPacUrl.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 50a00da4-995c-c6ef-b929-cb4401b2501c
---

# Microsoft Edge Browser Policy Documentation ProxyPacUrl | Microsoft Learn

## Set the proxy .pac file URL (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: Not supported

## Description

This policy is deprecated; use [ProxySettings](proxysettings) instead. It doesn't work in Microsoft Edge version 91.

Specifies the URL for a proxy auto-config (PAC) file.

This policy is applied only if the [ProxySettings](proxysettings) policy isn't specified, and if you've selected pac\_script in the [ProxyMode](proxymode) policy. If you've selected any other mode for configuring proxy policies, don't enable or configure this policy.

If you enable this policy, specify the URL for a PAC file, which defines how the browser automatically chooses the appropriate proxy server for fetching a particular website.

If you disable or don't configure this policy, no PAC file is specified. Leave this policy unconfigured if you've specified any other method for setting proxy policies.

For detailed examples, see https://go.microsoft.com/fwlink/?linkid=2094936.

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

- GP unique name: ProxyPacUrl
- GP name: Set the proxy .pac file URL (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Proxy server
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://internal.contoso.com/example.pac
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProxyPacUrl
- Value type: REG\_SZ

#### Example registry value

```
https://internal.contoso.com/example.pac
```

## Mac information and settings

- Preference Key name: ProxyPacUrl
- Example value:

```xml
<string>https://internal.contoso.com/example.pac</string>
```

## Android information and settings

- Preference Key name: ProxyPacUrl
- Example value:

```
https://internal.contoso.com/example.pac
```