---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CACertificateManagementAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/cacertificatemanagementallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to manage installed CA certificates.'
locale: en-us
document_id: 936040ac-55f3-1936-2d7c-24f2ee8b815d
document_version_independent_id: 936040ac-55f3-1936-2d7c-24f2ee8b815d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CACertificateManagementAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/CACertificateManagementAllowed.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 273
asset_id: microsoft-edge-policies/cacertificatemanagementallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CACertificateManagementAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 54f57365-cce7-d257-867d-0cd120bd2e5c
---

# Microsoft Edge Browser Policy Documentation CACertificateManagementAllowed | Microsoft Learn

## Allow users to manage installed CA certificates.

## Supported versions

- Windows: ≥ 133
- macOS: ≥ 133
- Android: Not supported
- iOS: Not supported

## Description

This policy determines the level of access users have when managing CA certificates in Microsoft Edge.

Setting the policy to UserOnly (1) allows users to manage only user-imported certificates. Trust settings for built-in certificates cannot be changed.

Setting the policy to None (2) lets users view certificates but not manage them.

Note: The certificate management experience is available starting in Microsoft Edge version 136.

Policy options mapping:

- All (0) = Allow users to manage all certificates
- UserOnly (1) = Allow users to manage user certificates
- None (2) = Disallow users from managing certificates

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- All (0) = Allow users to manage all certificates
- UserOnly (1) = Allow users to manage user certificates
- None (2) = Disallow users from managing certificates

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CACertificateManagementAllowed
- GP name: Allow users to manage installed CA certificates.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Certificate management settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow users to manage user certificates
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: CACertificateManagementAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CACertificateManagementAllowed
- Example value:

```xml
<integer>1</integer>
```