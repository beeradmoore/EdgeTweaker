---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeManagementPolicyOverridesPlatformPolicy | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgemanagementpolicyoverridesplatformpolicy
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Microsoft Edge management service policy overrides platform policy.'
locale: en-us
document_id: 46f54855-cbde-7594-358a-a46e99e6673e
document_version_independent_id: 46f54855-cbde-7594-358a-a46e99e6673e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeManagementPolicyOverridesPlatformPolicy.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/EdgeManagementPolicyOverridesPlatformPolicy.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 201
asset_id: microsoft-edge-policies/edgemanagementpolicyoverridesplatformpolicy
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeManagementPolicyOverridesPlatformPolicy.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b6035c3a-4d64-1ed4-aa8a-5fa0bfdc0e55
---

# Microsoft Edge Browser Policy Documentation EdgeManagementPolicyOverridesPlatformPolicy | Microsoft Learn

## Microsoft Edge management service policy overrides platform policy.

## Supported versions

- Windows: ≥ 119
- macOS: ≥ 119
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, the cloud-based Microsoft Edge management service policy takes precedence if it conflicts with platform policy.

If you disable or don't configure this policy, platform policy takes precedence if it conflicts with the cloud-based Microsoft Edge management service policy.

This mandatory policy affects machine scope cloud-based Microsoft Edge management policies.

Machine policies apply to all edge browser instances regardless of the user who is logged in.

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

- GP unique name: EdgeManagementPolicyOverridesPlatformPolicy
- GP name: Microsoft Edge management service policy overrides platform policy.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Manageability
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EdgeManagementPolicyOverridesPlatformPolicy
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: EdgeManagementPolicyOverridesPlatformPolicy
- Example value:

```xml
<false/>
```