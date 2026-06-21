---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RequireOnlineRevocationChecksForLocalAnchors | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/requireonlinerevocationchecksforlocalanchors
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specify if online OCSP/CRL checks are required for local trust anchors'
locale: en-us
document_id: bfdeaa4e-7c37-4f34-f3a7-ab19964e6d54
document_version_independent_id: bfdeaa4e-7c37-4f34-f3a7-ab19964e6d54
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RequireOnlineRevocationChecksForLocalAnchors.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RequireOnlineRevocationChecksForLocalAnchors.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 208
asset_id: microsoft-edge-policies/requireonlinerevocationchecksforlocalanchors
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RequireOnlineRevocationChecksForLocalAnchors.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d9a12182-fc57-d183-f63e-b8f2f6a26368
---

# Microsoft Edge Browser Policy Documentation RequireOnlineRevocationChecksForLocalAnchors | Microsoft Learn

## Specify if online OCSP/CRL checks are required for local trust anchors

## Supported versions

- Windows: ≥ 123
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Control whether online revocation checks (OCSP/CRL checks) are required. If Microsoft Edge can't get revocation status information, these certificates are treated as revoked ("hard-fail").

If you enable this policy, Microsoft Edge always performs revocation checking for server certificates that successfully validate and are signed by locally installed CA certificates.

If you don't configure or disable this policy, then Microsoft Edge uses the existing online revocation checking settings.

On macOS, this policy has no effect if the [MicrosoftRootStoreEnabled](microsoftrootstoreenabled) policy is set to False.

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

- GP unique name: RequireOnlineRevocationChecksForLocalAnchors
- GP name: Specify if online OCSP/CRL checks are required for local trust anchors
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
- Value name: RequireOnlineRevocationChecksForLocalAnchors
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```