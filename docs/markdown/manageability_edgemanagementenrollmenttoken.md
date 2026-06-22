---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeManagementEnrollmentToken | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgemanagementenrollmenttoken
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Microsoft Edge management enrollment token'
locale: en-us
document_id: fc9e6a74-5efa-d53a-27e5-b935f2f928a9
document_version_independent_id: fc9e6a74-5efa-d53a-27e5-b935f2f928a9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeManagementEnrollmentToken.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/EdgeManagementEnrollmentToken.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 244
asset_id: microsoft-edge-policies/edgemanagementenrollmenttoken
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeManagementEnrollmentToken.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: fa587fa8-4364-896c-a18d-4e88cfe641f8
---

# Microsoft Edge Browser Policy Documentation EdgeManagementEnrollmentToken | Microsoft Learn

## Microsoft Edge management enrollment token

## Supported versions

- Windows: ≥ 115
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Microsoft Edge management service in Microsoft 365 Admin Center lets you set policy and manage users through a Microsoft Edge focused cloud-based management experience. This policy lets you specify an enrollment token that's used to register with Microsoft Edge management service and deploy the associated policies. The user must be signed in to Microsoft Edge with a valid work or school account; otherwise, Microsoft Edge doesn't download the policy.

If you enable this policy, Microsoft Edge attempts to use the specified enrollment token to register with the Microsoft Edge management service and download the published policy.

If you disable or don't configure this policy, Microsoft Edge doesn't attempt to connect to the Microsoft Edge management service.

This policy can only be set as a platform policy.

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

- GP unique name: EdgeManagementEnrollmentToken
- GP name: Microsoft Edge management enrollment token
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Manageability
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
RgAAAACBbzoQDmUrRfq3WeKUoFeEBwBOqK2QPYsBT5V3lQFoKND-AAAAAAEVAAAOqK2QPYvBT5V4lQFoKMD-AAADTXvzAAAA0
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EdgeManagementEnrollmentToken
- Value type: REG\_SZ

#### Example registry value

```
RgAAAACBbzoQDmUrRfq3WeKUoFeEBwBOqK2QPYsBT5V3lQFoKND-AAAAAAEVAAAOqK2QPYvBT5V4lQFoKMD-AAADTXvzAAAA0
```