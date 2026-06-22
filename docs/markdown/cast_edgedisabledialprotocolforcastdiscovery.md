---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeDisableDialProtocolForCastDiscovery | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgedisabledialprotocolforcastdiscovery
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable DIAL protocol for cast device discovery'
locale: en-us
document_id: 9a7473ac-278a-faad-0a46-14d05d4ca1ed
document_version_independent_id: 9a7473ac-278a-faad-0a46-14d05d4ca1ed
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeDisableDialProtocolForCastDiscovery.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/EdgeDisableDialProtocolForCastDiscovery.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 172
asset_id: microsoft-edge-policies/edgedisabledialprotocolforcastdiscovery
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeDisableDialProtocolForCastDiscovery.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 7f0da8fc-c625-b144-6cf4-51b6934bf537
---

# Microsoft Edge Browser Policy Documentation EdgeDisableDialProtocolForCastDiscovery | Microsoft Learn

## Disable DIAL protocol for cast device discovery

## Supported versions

- Windows: ≥ 121
- macOS: ≥ 121
- Android: Not supported
- iOS: Not supported

## Description

Enable this policy to disable the DIAL (Discovery And Launch) protocol for cast device discovery. (If EnableMediaRouter is disabled, this policy has no effect).

Enable this policy to disable DIAL protocol.

By default, Cast device discovery uses DIAL protocol.

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

- GP unique name: EdgeDisableDialProtocolForCastDiscovery
- GP name: Disable DIAL protocol for cast device discovery
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Cast
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EdgeDisableDialProtocolForCastDiscovery
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EdgeDisableDialProtocolForCastDiscovery
- Example value:

```xml
<true/>
```