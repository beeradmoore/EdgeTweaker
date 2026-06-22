---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalNetworkAccessPermissionsPolicyDefaultEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localnetworkaccesspermissionspolicydefaultenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Local Network Access (LNA) requests in subframes without explicit delegation'
locale: en-us
document_id: 47e141c0-12c0-8e17-a0a8-bd52cdac1801
document_version_independent_id: 47e141c0-12c0-8e17-a0a8-bd52cdac1801
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessPermissionsPolicyDefaultEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessPermissionsPolicyDefaultEnabled.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 267
asset_id: microsoft-edge-policies/localnetworkaccesspermissionspolicydefaultenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalNetworkAccessPermissionsPolicyDefaultEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 3cb154d1-7351-5ec9-dfd9-bf475c649813
---

# Microsoft Edge Browser Policy Documentation LocalNetworkAccessPermissionsPolicyDefaultEnabled | Microsoft Learn

## Allow Local Network Access (LNA) requests in subframes without explicit delegation

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

Controls whether Local Network Access (LNA) permissions are inherited by cross-origin subframes.

By default, Local Network Access permissions can be requested in cross-origin subframes only if they are explicitly delegated.

If you enable this policy, subframes inherit all LNA Permissions Policy features by default and can make local network requests, which trigger the permission prompt.

If you disable or don't configure this policy, subframes must be explicitly delegated the Permissions Policy feature to make local network requests and trigger the permission prompt.

This policy applies to the Permissions Policy features "local-network-access", "loopback-network", and "local-network".

For more information about Local Network Access, see [Adapting your website for new Local Network Access restrictions in Microsoft Edge](/en-us/deployedge/ms-edge-local-network-access).

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

- GP unique name: LocalNetworkAccessPermissionsPolicyDefaultEnabled
- GP name: Allow Local Network Access (LNA) requests in subframes without explicit delegation
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: LocalNetworkAccessPermissionsPolicyDefaultEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: LocalNetworkAccessPermissionsPolicyDefaultEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: LocalNetworkAccessPermissionsPolicyDefaultEnabled
- Example value:

```
true
```