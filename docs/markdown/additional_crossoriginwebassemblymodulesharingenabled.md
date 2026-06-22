---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CrossOriginWebAssemblyModuleSharingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/crossoriginwebassemblymodulesharingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specifies whether WebAssembly modules can be sent cross-origin (obsolete)'
locale: en-us
document_id: 04fe1390-abc0-9284-a0d9-b667f191a4a3
document_version_independent_id: 04fe1390-abc0-9284-a0d9-b667f191a4a3
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CrossOriginWebAssemblyModuleSharingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/CrossOriginWebAssemblyModuleSharingEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 239
asset_id: microsoft-edge-policies/crossoriginwebassemblymodulesharingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CrossOriginWebAssemblyModuleSharingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f4743a74-a8b6-1d89-4fb9-0da6040e3963
---

# Microsoft Edge Browser Policy Documentation CrossOriginWebAssemblyModuleSharingEnabled | Microsoft Learn

## Specifies whether WebAssembly modules can be sent cross-origin (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 98.

## Supported versions

- Windows: 95-98
- macOS: 95-98
- Android: Not supported
- iOS: Not supported

## Description

Specifies whether WebAssembly modules can be sent to another window or worker cross-origin. Cross-origin WebAssembly module sharing was deprecated as part of the efforts to deprecate document.domain, see https://github.com/mikewest/deprecating-document-domain. This policy allowed re-enabling of cross-origin WebAssembly module sharing. This policy is obsolete because it was intended to offer a longer transition period in the deprecation process.

If you enable this policy, sites can send WebAssembly modules cross-origin without restrictions.

If you disable or don't configure this policy, sites can only send WebAssembly modules to windows and workers in the same origin.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CrossOriginWebAssemblyModuleSharingEnabled
- GP name: Specifies whether WebAssembly modules can be sent cross-origin (obsolete)
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
- Value name: CrossOriginWebAssemblyModuleSharingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CrossOriginWebAssemblyModuleSharingEnabled
- Example value:

```xml
<true/>
```