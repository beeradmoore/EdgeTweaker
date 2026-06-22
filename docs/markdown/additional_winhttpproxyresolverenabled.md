---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WinHttpProxyResolverEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/winhttpproxyresolverenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Use Windows proxy resolver'
locale: en-us
document_id: efc8c4eb-9690-42f7-1df1-39fe53d59067
document_version_independent_id: efc8c4eb-9690-42f7-1df1-39fe53d59067
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WinHttpProxyResolverEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/WinHttpProxyResolverEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 247
asset_id: microsoft-edge-policies/winhttpproxyresolverenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WinHttpProxyResolverEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: f8cd18d0-5c24-e0d7-ec70-f496673bceab
---

# Microsoft Edge Browser Policy Documentation WinHttpProxyResolverEnabled | Microsoft Learn

## Use Windows proxy resolver

## Supported versions

- Windows: ≥ 84
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy will be superseded by a similar feature in a future release. For more information, see https://crbug.com/1032820.

Use Windows to resolve proxies for all browser networking instead of the proxy resolver built into Microsoft Edge. The Windows proxy resolver enables Windows proxy features such as DirectAccess/NRPT.

This policy comes with the problems described by https://crbug.com/644030. It causes PAC files to be fetched and executed by Windows code, including PAC files set via the [ProxyPacUrl](proxypacurl) policy. Since network fetches for the PAC file happen via Windows instead of Microsoft Edge code, network policies such as [DnsOverHttpsMode](dnsoverhttpsmode) won't apply to network fetches for a PAC file.

If you enable this policy, the Windows proxy resolver is used.

If you disable or don't configure this policy, the Microsoft Edge proxy resolver is used.

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

- GP unique name: WinHttpProxyResolverEnabled
- GP name: Use Windows proxy resolver
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
- Value name: WinHttpProxyResolverEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```