---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalNetworkAccessRestrictionsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localnetworkaccessrestrictionsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specifies whether to block requests from public websites to devices on a user&#x27;s local network. (obsolete)'
locale: en-us
document_id: db9e17d3-1621-efd8-8d74-3a5d27e07ac6
document_version_independent_id: db9e17d3-1621-efd8-8d74-3a5d27e07ac6
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessRestrictionsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessRestrictionsEnabled.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 324
asset_id: microsoft-edge-policies/localnetworkaccessrestrictionsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalNetworkAccessRestrictionsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 97505977-6fd0-a6bb-1c06-40ee28b32997
---

# Microsoft Edge Browser Policy Documentation LocalNetworkAccessRestrictionsEnabled | Microsoft Learn

## Specifies whether to block requests from public websites to devices on a user's local network. (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 144.

## Supported versions

- Windows: 138-144
- macOS: 138-144
- Android: Not supported
- iOS: Not supported

## Description

Local Network Access restrictions prevent public websites from making requests to devices on a user's local network without explicit user permission.

If you enable this policy, Microsoft Edge blocks any request that would otherwise trigger a DevTools warning due to Local Network Access checks. These requests are denied without prompting the user.

If you disable or don't configure this policy, Microsoft Edge handles these requests using the default behavior, which may include showing warnings in DevTools and allowing the request to proceed depending on the context.

Note: This feature improves local network security by deprecating direct access to private IP addresses from public websites unless explicitly granted by the user. For more information about Local Network Access, see https://wicg.github.io/local-network-access/.

Starting in version 140, Microsoft Edge introduces support for policies that manage Local Network Access behavior on a per-URL basis.

You can configure exceptions to allow specific URLs to bypass Local Network Access restrictions.

You can also block specific URLs from making Local Network Access requests.

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

- GP unique name: LocalNetworkAccessRestrictionsEnabled
- GP name: Specifies whether to block requests from public websites to devices on a user's local network. (obsolete)
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
- Value name: LocalNetworkAccessRestrictionsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: LocalNetworkAccessRestrictionsEnabled
- Example value:

```xml
<true/>
```