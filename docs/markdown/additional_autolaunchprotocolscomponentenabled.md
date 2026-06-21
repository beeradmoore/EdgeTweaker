---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoLaunchProtocolsComponentEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autolaunchprotocolscomponentenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: AutoLaunch Protocols Component Enabled'
locale: en-us
document_id: 196a2342-16af-51b8-0e59-4d3e0d1c8bba
document_version_independent_id: 196a2342-16af-51b8-0e59-4d3e0d1c8bba
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoLaunchProtocolsComponentEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AutoLaunchProtocolsComponentEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 193
asset_id: microsoft-edge-policies/autolaunchprotocolscomponentenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoLaunchProtocolsComponentEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4b01ad49-9acc-5c4b-53a9-6e9658905468
---

# Microsoft Edge Browser Policy Documentation AutoLaunchProtocolsComponentEnabled | Microsoft Learn

## AutoLaunch Protocols Component Enabled

## Supported versions

- Windows: ≥ 96
- macOS: ≥ 96
- Android: Not supported
- iOS: Not supported

## Description

Specifies whether the AutoLaunch Protocols component should be enabled. This component allows Microsoft to provide a list similar to that of the [AutoLaunchProtocolsFromOrigins](autolaunchprotocolsfromorigins) policy, allowing certain external protocols to launch without prompt or blocking certain protocols (on specified origins). By default, this component is enabled.

If you enable or don't configure this policy, the AutoLaunch Protocols component is enabled.

If you disable this policy, the AutoLaunch Protocols component is disabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AutoLaunchProtocolsComponentEnabled
- GP name: AutoLaunch Protocols Component Enabled
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
- Value name: AutoLaunchProtocolsComponentEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AutoLaunchProtocolsComponentEnabled
- Example value:

```xml
<true/>
```