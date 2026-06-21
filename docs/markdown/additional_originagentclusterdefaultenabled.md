---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OriginAgentClusterDefaultEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/originagentclusterdefaultenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Origin-keyed agent clustering enabled by default'
locale: en-us
document_id: 20b37326-0bc6-442a-015a-c21cbf95175c
document_version_independent_id: 20b37326-0bc6-442a-015a-c21cbf95175c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OriginAgentClusterDefaultEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/OriginAgentClusterDefaultEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 245
asset_id: microsoft-edge-policies/originagentclusterdefaultenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OriginAgentClusterDefaultEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: dfecfb05-8334-d0f1-6dbe-9b44feae2129
---

# Microsoft Edge Browser Policy Documentation OriginAgentClusterDefaultEnabled | Microsoft Learn

## Origin-keyed agent clustering enabled by default

## Supported versions

- Windows: ≥ 103
- macOS: ≥ 103
- Android: Not supported
- iOS: Not supported

## Description

The Origin-Agent-Cluster: HTTP header controls whether a document is isolated in an origin-keyed agent cluster or in a site-keyed agent cluster. This functionality has security implications because an origin-keyed agent cluster allows isolating documents by origin. The consequence of this for developers is that the document.domain accessor can no longer be set when origin-keyed agent clustering is enabled.

If you enable or don't configure this policy, documents without the Origin-Agent-Cluster: header are assigned to origin-keyed agent clustering by default. On these documents, the document.domain accessor isn't settable.

If you disable this policy, documents without the Origin-Agent-Cluster: header are assigned to site-keyed agent clusters by default. On these documents, the document.domain accessor is settable.

For more information, see https://go.microsoft.com/fwlink/?linkid=2191896.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: OriginAgentClusterDefaultEnabled
- GP name: Origin-keyed agent clustering enabled by default
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: OriginAgentClusterDefaultEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: OriginAgentClusterDefaultEnabled
- Example value:

```xml
<false/>
```