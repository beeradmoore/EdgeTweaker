---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AuthNegotiateDelegateAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/authnegotiatedelegateallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specifies a list of servers that Microsoft Edge can delegate user credentials to'
locale: en-us
document_id: 6b840177-b6ee-3a68-57d3-563c8affde68
document_version_independent_id: 6b840177-b6ee-3a68-57d3-563c8affde68
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AuthNegotiateDelegateAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/AuthNegotiateDelegateAllowlist.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 198
asset_id: microsoft-edge-policies/authnegotiatedelegateallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AuthNegotiateDelegateAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5a488d8b-da29-2c90-b9cc-847b6566ab1e
---

# Microsoft Edge Browser Policy Documentation AuthNegotiateDelegateAllowlist | Microsoft Learn

## Specifies a list of servers that Microsoft Edge can delegate user credentials to

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Configure the list of servers that Microsoft Edge can delegate to.

Separate multiple server names with commas. Wildcards (\*) are allowed.

If you don't configure this policy, Microsoft Edge doesn't delegate user credentials even if a server is detected as Intranet.

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

- GP unique name: AuthNegotiateDelegateAllowlist
- GP name: Specifies a list of servers that Microsoft Edge can delegate user credentials to
- GP path (Mandatory): Administrative Templates/Microsoft Edge/HTTP authentication
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AuthNegotiateDelegateAllowlist
- Value type: REG\_SZ

#### Example registry value

```
contoso.com
```

## Mac information and settings

- Preference Key name: AuthNegotiateDelegateAllowlist
- Example value:

```xml
<string>contoso.com</string>
```

## Android information and settings

- Preference Key name: AuthNegotiateDelegateAllowlist
- Example value:

```
contoso.com
```