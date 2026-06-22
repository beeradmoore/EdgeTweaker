---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AuthServerAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/authserverallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure list of allowed authentication servers'
locale: en-us
document_id: c06f164c-1cf9-4f0c-e92c-507a10643ff4
document_version_independent_id: c06f164c-1cf9-4f0c-e92c-507a10643ff4
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AuthServerAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/AuthServerAllowlist.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 226
asset_id: microsoft-edge-policies/authserverallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AuthServerAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f9f4d8ac-14c7-7f68-b447-c3b89615ff8a
---

# Microsoft Edge Browser Policy Documentation AuthServerAllowlist | Microsoft Learn

## Configure list of allowed authentication servers

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Specifies which servers to enable for integrated authentication. Integrated authentication is only enabled when Microsoft Edge receives an authentication challenge from a proxy or from a server in this list.

Separate multiple server names with commas. Wildcards (\*) are allowed.

If you don't configure this policy, Microsoft Edge tries to detect if a server is on the intranet - only then does it respond to IWA requests. If the server is on the internet, IWA requests from it are ignored by Microsoft Edge.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AuthServerAllowlist
- GP name: Configure list of allowed authentication servers
- GP path (Mandatory): Administrative Templates/Microsoft Edge/HTTP authentication
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
*contoso.com,contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AuthServerAllowlist
- Value type: REG\_SZ

#### Example registry value

```
*contoso.com,contoso.com
```

## Mac information and settings

- Preference Key name: AuthServerAllowlist
- Example value:

```xml
<string>*contoso.com,contoso.com</string>
```

## Android information and settings

- Preference Key name: AuthServerAllowlist
- Example value:

```
*contoso.com,contoso.com
```