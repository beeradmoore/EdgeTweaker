---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebRtcAllowLegacyTLSProtocols | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webrtcallowlegacytlsprotocols
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow legacy TLS/DTLS downgrade in WebRTC (obsolete)'
locale: en-us
document_id: 6f0eec57-40cf-0f90-e526-afdcb76e7208
document_version_independent_id: 6f0eec57-40cf-0f90-e526-afdcb76e7208
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebRtcAllowLegacyTLSProtocols.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/WebRtcAllowLegacyTLSProtocols.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 194
asset_id: microsoft-edge-policies/webrtcallowlegacytlsprotocols
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebRtcAllowLegacyTLSProtocols.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 35822eb8-4e20-cc11-9526-9e27beed1ef0
---

# Microsoft Edge Browser Policy Documentation WebRtcAllowLegacyTLSProtocols | Microsoft Learn

## Allow legacy TLS/DTLS downgrade in WebRTC (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 120.

## Supported versions

- Windows: 88-120
- macOS: 88-120
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, WebRTC peer connections can downgrade to obsolete versions of the TLS/DTLS (DTLS 1.0, TLS 1.0 and TLS 1.1) protocols. If you disable or don't set this policy, these TLS/DTLS versions are disabled.

This policy was removed in Microsoft Edge 121 and is ignored if set.

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

- GP unique name: WebRtcAllowLegacyTLSProtocols
- GP name: Allow legacy TLS/DTLS downgrade in WebRTC (obsolete)
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
- Value name: WebRtcAllowLegacyTLSProtocols
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: WebRtcAllowLegacyTLSProtocols
- Example value:

```xml
<false/>
```