---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AdditionalDnsQueryTypesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/additionaldnsquerytypesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow DNS queries for more DNS record types'
locale: en-us
document_id: fd2db3ff-ec0b-f4c1-bab4-b48762852029
document_version_independent_id: fd2db3ff-ec0b-f4c1-bab4-b48762852029
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AdditionalDnsQueryTypesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/AdditionalDnsQueryTypesEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 265
asset_id: microsoft-edge-policies/additionaldnsquerytypesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AdditionalDnsQueryTypesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 72c8ff9e-ed09-5828-f92d-24316a5127b9
---

# Microsoft Edge Browser Policy Documentation AdditionalDnsQueryTypesEnabled | Microsoft Learn

## Allow DNS queries for more DNS record types

## Supported versions

- Windows: ≥ 140
- macOS: ≥ 140
- Android: ≥ 139
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge can query more DNS record types when making insecure (non-Secure DNS) requests.

If this policy is unset or set to Enabled, more record types such as HTTPS (DNS type 65) may be queried in addition to A (DNS type 1) and AAAA (DNS type 28).

If this policy is set to Disabled, Microsoft Edge will only query A and AAAA record types for insecure DNS requests.

This setting doesn't affect DNS queries made via Secure DNS, which may always use more record types.

Note: This is a temporary policy and is planned for removal in a future version of Microsoft Edge. After removal, Microsoft Edge will always be able to query more DNS types during insecure requests.

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

- GP unique name: AdditionalDnsQueryTypesEnabled
- GP name: Allow DNS queries for more DNS record types
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
- Value name: AdditionalDnsQueryTypesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AdditionalDnsQueryTypesEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AdditionalDnsQueryTypesEnabled
- Example value:

```
true
```