---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SandboxExternalProtocolBlocked | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sandboxexternalprotocolblocked
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Microsoft Edge to block navigations to external protocols in a sandboxed iframe'
locale: en-us
document_id: ea27d26e-3b01-6a36-94cb-eb8aefd1050d
document_version_independent_id: ea27d26e-3b01-6a36-94cb-eb8aefd1050d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SandboxExternalProtocolBlocked.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/SandboxExternalProtocolBlocked.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 216
asset_id: microsoft-edge-policies/sandboxexternalprotocolblocked
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SandboxExternalProtocolBlocked.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 731f9c10-d246-f25b-7e40-49f3fcfda7ba
---

# Microsoft Edge Browser Policy Documentation SandboxExternalProtocolBlocked | Microsoft Learn

## Allow Microsoft Edge to block navigations to external protocols in a sandboxed iframe

## Supported versions

- Windows: ≥ 99
- macOS: ≥ 99
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge blocks navigations to external protocols inside a sandboxed iframe.

If you enable or don't configure this policy, Microsoft Edge blocks those navigations.

If you disable this policy, Microsoft Edge doesn't block those navigations.

This policy can be used by administrators who need more time to update their internal website affected by this new restriction. This Enterprise policy is temporary; it's intended to be removed after Microsoft Edge version 117.

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

- GP unique name: SandboxExternalProtocolBlocked
- GP name: Allow Microsoft Edge to block navigations to external protocols in a sandboxed iframe
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
- Value name: SandboxExternalProtocolBlocked
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SandboxExternalProtocolBlocked
- Example value:

```xml
<true/>
```