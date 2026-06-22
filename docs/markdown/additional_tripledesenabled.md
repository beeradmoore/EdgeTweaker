---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TripleDESEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/tripledesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable 3DES cipher suites in TLS (obsolete)'
locale: en-us
document_id: 4f39fcb8-ba11-68f5-6c39-792f18838c85
document_version_independent_id: 4f39fcb8-ba11-68f5-6c39-792f18838c85
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TripleDESEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/TripleDESEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 217
asset_id: microsoft-edge-policies/tripledesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TripleDESEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ba4f3576-e332-82a4-f8e7-b65f368e87e6
---

# Microsoft Edge Browser Policy Documentation TripleDESEnabled | Microsoft Learn

## Enable 3DES cipher suites in TLS (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 96.

## Supported versions

- Windows: 93-96
- macOS: 93-96
- Android: Not supported
- iOS: Not supported

## Description

This policy was removed in version 97 after 3DES was removed from Microsoft Edge.

If you enable this policy, then 3DES cipher suites in TLS are enabled. If you disable this policy, then the 3DES cipher suites in TLS are disabled. If the policy is unset, 3DES cipher suites are disabled by default. This policy may be used to temporarily retain compatibility with an outdated server. This is a stopgap measure and the server should be reconfigured.

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

- GP unique name: TripleDESEnabled
- GP name: Enable 3DES cipher suites in TLS (obsolete)
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
- Value name: TripleDESEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: TripleDESEnabled
- Example value:

```xml
<false/>
```