---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RestrictCoreSharingOnRenderer | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/restrictcoresharingonrenderer
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Restrict CPU core sharing for renderer process'
locale: en-us
document_id: cf04c3b2-e81c-cf39-134f-02554ae032b4
document_version_independent_id: cf04c3b2-e81c-cf39-134f-02554ae032b4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RestrictCoreSharingOnRenderer.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RestrictCoreSharingOnRenderer.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 266
asset_id: microsoft-edge-policies/restrictcoresharingonrenderer
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RestrictCoreSharingOnRenderer.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9e5eb521-4382-a907-8171-ce4e9a4c445b
---

# Microsoft Edge Browser Policy Documentation RestrictCoreSharingOnRenderer | Microsoft Learn

## Restrict CPU core sharing for renderer process

## Supported versions

- Windows: ≥ 140
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy helps mitigate side-channel cross-process memory attacks by isolating the renderer process to a dedicated CPU core, preventing other processes from being scheduled on the same core. This mitigation is supported on Microsoft® Windows® 11 24H2 and later. If the operating system doesn't support the necessary scheduling features, this policy has no effect. Enabling this policy may reduce performance in demanding workloads, similar to the impact of disabling hyperthreading. For more information, refer [PROCESS_MITIGATION_SIDE_CHANNEL_ISOLATION_POLICY structure (winnt.h)](/en-us/windows/win32/api/winnt/ns-winnt-process_mitigation_side_channel_isolation_policy) If you enable this policy, other processes can't be scheduled on the same CPU core as a renderer process. If you disable this policy, other processes can be scheduled on the same CPU core as a renderer process. If you don't configure this policy, other processes can be scheduled on the same core as the renderer process. Behavior can vary depending on Microsoft Edge version and platform.

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

- GP unique name: RestrictCoreSharingOnRenderer
- GP name: Restrict CPU core sharing for renderer process
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
- Value name: RestrictCoreSharingOnRenderer
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```