---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebRtcPostQuantumKeyAgreement | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webrtcpostquantumkeyagreement
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable post-quantum key agreement for WebRTC'
locale: en-us
document_id: 52e2e9a6-36ef-b9a7-0213-822eed0f316b
document_version_independent_id: 52e2e9a6-36ef-b9a7-0213-822eed0f316b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebRtcPostQuantumKeyAgreement.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebRtcPostQuantumKeyAgreement.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 290
asset_id: microsoft-edge-policies/webrtcpostquantumkeyagreement
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebRtcPostQuantumKeyAgreement.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6e3cad0c-4c17-1f7f-3cd8-6c24d8ca8fca
---

# Microsoft Edge Browser Policy Documentation WebRtcPostQuantumKeyAgreement | Microsoft Learn

## Enable post-quantum key agreement for WebRTC

## Supported versions

- Windows: ≥ 141
- macOS: ≥ 141
- Android: Not supported
- iOS: Not supported

## Description

This policy controls the use of post-quantum key agreement for WebRTC in Microsoft Edge.

If you enable this policy, Microsoft Edge will offer post-quantum key agreement for WebRTC.

If you disable this policy, post-quantum key agreement won't be offered for WebRTC.

If you don't configure this policy, post-quantum key agreement won't be offered for WebRTC. A future version of Microsoft Edge may enable this feature by default.

Offering a post-quantum key agreement is backwards compatible. Existing datagram transport layer security (DTLS) peers and networking middleware are expected to ignore the new option and continue using previous options.

However, devices that don't correctly implement DTLS may malfunction when offered the new option. For example, they may disconnect in response to unrecognized options or larger message sizes. Such devices aren’t post-quantum-ready and may interfere with an organization's post-quantum transition. If this issue occurs, administrators should contact the device vendor for a fix.

This policy is temporary and will be removed in a future release.

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

- GP unique name: WebRtcPostQuantumKeyAgreement
- GP name: Enable post-quantum key agreement for WebRTC
- GP path (Mandatory): Administrative Templates/Microsoft Edge/WebRtc settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebRtcPostQuantumKeyAgreement
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WebRtcPostQuantumKeyAgreement
- Example value:

```xml
<true/>
```