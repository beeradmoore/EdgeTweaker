---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebAuthenticationRemoteDesktopAllowedOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webauthenticationremotedesktopallowedorigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allowed Origins for Proxied WebAuthn Requests from Remote Desktop Applications.'
locale: en-us
document_id: 1b7bab65-44fb-e156-a119-357d5704cb86
document_version_independent_id: 1b7bab65-44fb-e156-a119-357d5704cb86
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebAuthenticationRemoteDesktopAllowedOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebAuthenticationRemoteDesktopAllowedOrigins.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 234
asset_id: microsoft-edge-policies/webauthenticationremotedesktopallowedorigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebAuthenticationRemoteDesktopAllowedOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/ddab3cd8-636f-4a91-896e-1c23f399a6bd
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/f409bb5d-e203-40c5-9d95-0ee717231beb
platformId: fe889c0d-85bf-a960-5c07-0f7fe4e4ed86
---

# Microsoft Edge Browser Policy Documentation WebAuthenticationRemoteDesktopAllowedOrigins | Microsoft Learn

## Allowed Origins for Proxied WebAuthn Requests from Remote Desktop Applications.

## Supported versions

- Windows: ≥ 137
- macOS: ≥ 137
- Android: ≥ 140
- iOS: Not supported

## Description

This policy defines a list of allowed HTTPS origins for remote desktop client applications that initiate WebAuthn API requests from a browsing session on a remote host.

Origins specified in this policy can request WebAuthn authentication for Relying Party IDs (RP IDs) they wouldn't typically be authorized to claim.

Only HTTPS origins are supported. Wildcards aren't permitted. Entries that don't meet these requirements will be ignored.

For more information about the WebAuthn Remote Desktop Support feature, see https://github.com/w3c/webauthn/wiki/Explainer:-Remote-Desktop-Support/a4e158c569f456c759d0ddd294a9015bd4d4eb9a.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebAuthenticationRemoteDesktopAllowedOrigins
- GP name: Allowed Origins for Proxied WebAuthn Requests from Remote Desktop Applications.
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://server:8080/
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WebAuthenticationRemoteDesktopAllowedOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WebAuthenticationRemoteDesktopAllowedOrigins\1 =

```
https://server:8080/
```

## Mac information and settings

- Preference Key name: WebAuthenticationRemoteDesktopAllowedOrigins
- Example value:

```xml
<array>
  <string>https://server:8080/</string>
</array>
```

## Android information and settings

- Preference Key name: WebAuthenticationRemoteDesktopAllowedOrigins
- Example value:

```
["https://server:8080/"]
```