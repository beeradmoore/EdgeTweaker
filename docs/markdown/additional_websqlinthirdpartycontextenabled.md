---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebSQLInThirdPartyContextEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/websqlinthirdpartycontextenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force WebSQL in third-party contexts to be re-enabled (obsolete)'
locale: en-us
document_id: c29f3f4b-3b54-6046-cb3d-5f7bf32f2e42
document_version_independent_id: c29f3f4b-3b54-6046-cb3d-5f7bf32f2e42
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebSQLInThirdPartyContextEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebSQLInThirdPartyContextEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 254
asset_id: microsoft-edge-policies/websqlinthirdpartycontextenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebSQLInThirdPartyContextEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 34c9a8d3-08c3-e92c-0a22-c96d6365c4a4
---

# Microsoft Edge Browser Policy Documentation WebSQLInThirdPartyContextEnabled | Microsoft Learn

## Force WebSQL in third-party contexts to be re-enabled (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 100.

## Supported versions

- Windows: 97-100
- macOS: 97-100
- Android: 97-100
- iOS: Not supported

## Description

This policy is obsolete because it was intended to be a short-term mechanism to give enterprises more time to update their web content when it was incompatible with the change to disable WebSQL in third-party contexts. It doesn't work in Microsoft Edge after version 100.

WebSQL in third-party contexts (for example, cross-site iframes) is off by default as of Microsoft Edge version 97 and was fully removed in version 101.

If you enable this policy, WebSQL in third-party contexts is re-enabled.

If you disable this policy or don't configure it, WebSQL in third-party contexts remains off.

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

- GP unique name: WebSQLInThirdPartyContextEnabled
- GP name: Force WebSQL in third-party contexts to be re-enabled (obsolete)
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
- Value name: WebSQLInThirdPartyContextEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WebSQLInThirdPartyContextEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: WebSQLInThirdPartyContextEnabled
- Example value:

```
true
```