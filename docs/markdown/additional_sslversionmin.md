---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SSLVersionMin | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sslversionmin
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Minimum TLS version enabled (obsolete)'
locale: en-us
document_id: b3f822a3-2d7d-1728-b59e-fa1ed6b71c63
document_version_independent_id: b3f822a3-2d7d-1728-b59e-fa1ed6b71c63
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SSLVersionMin.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SSLVersionMin.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 316
asset_id: microsoft-edge-policies/sslversionmin
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SSLVersionMin.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 407be42d-ac1f-5f89-0acd-847c901056e8
---

# Microsoft Edge Browser Policy Documentation SSLVersionMin | Microsoft Learn

## Minimum TLS version enabled (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 97.

## Supported versions

- Windows: 77-97
- macOS: 77-97
- Android: 66-97
- iOS: Not supported

## Description

This policy was removed in Microsoft Edge 98 and is ignored if configured. Sets the minimum supported version of TLS.

If you set this policy to 'tls1.2', Microsoft Edge shows an error for TLS 1.0 and TLS 1.1, and the user won't be able to bypass the error.

If you don't configure this policy, Microsoft Edge still shows an error for TLS 1.0 and TLS 1.1 but the user will be able to bypass it.

Support for suppressing the TLS 1.0/1.1 warning was removed from Microsoft Edge starting in version 91. The 'tls1' and 'tls1.1' values are no longer supported.

Policy options mapping:

- TLSv1 (tls1) = TLS 1.0
- TLSv1.1 (tls1.1) = TLS 1.1
- TLSv1.2 (tls1.2) = TLS 1.2

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- TLSv1 (tls1) = TLS 1.0
    - Windows: 77-90
    - macOS: 77-90
    - Android: 66-90
    - iOS: Not supported
- TLSv1.1 (tls1.1) = TLS 1.1
    - Windows: 77-90
    - macOS: 77-90
    - Android: 66-90
    - iOS: Not supported
- TLSv1.2 (tls1.2) = TLS 1.2

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SSLVersionMin
- GP name: Minimum TLS version enabled (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
TLS 1.0
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: SSLVersionMin
- Value type: REG\_SZ

#### Example registry value

```
tls1
```

## Mac information and settings

- Preference Key name: SSLVersionMin
- Example value:

```xml
<string>tls1</string>
```

## Android information and settings

- Preference Key name: SSLVersionMin
- Example value:

```
tls1
```