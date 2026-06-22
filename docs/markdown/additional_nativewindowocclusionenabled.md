---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NativeWindowOcclusionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nativewindowocclusionenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Native Window Occlusion (deprecated)'
locale: en-us
document_id: 32caab17-58a8-8111-9975-56fed3c0b634
document_version_independent_id: 32caab17-58a8-8111-9975-56fed3c0b634
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NativeWindowOcclusionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/NativeWindowOcclusionEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 212
asset_id: microsoft-edge-policies/nativewindowocclusionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NativeWindowOcclusionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 5ccd113e-e4fb-0459-3ffa-7b621f9b51eb
---

# Microsoft Edge Browser Policy Documentation NativeWindowOcclusionEnabled | Microsoft Learn

## Enable Native Window Occlusion (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 84
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy is deprecated, use the '[WindowOcclusionEnabled](windowocclusionenabled)' policy instead. It won't work in Microsoft Edge version 92.

Enables native window occlusion in Microsoft Edge.

If you enable this policy, to reduce CPU and power consumption Microsoft Edge detects when a window is covered by other windows, and will suspend work painting pixels.

If you disable this policy Microsoft Edge won't detect when a window is covered by other windows.

If you don't configure this policy, occlusion detection is enabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: NativeWindowOcclusionEnabled
- GP name: Enable Native Window Occlusion (deprecated)
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
- Value name: NativeWindowOcclusionEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```