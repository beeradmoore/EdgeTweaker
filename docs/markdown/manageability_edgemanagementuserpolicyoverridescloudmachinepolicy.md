---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeManagementUserPolicyOverridesCloudMachinePolicy | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgemanagementuserpolicyoverridescloudmachinepolicy
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow cloud-based Microsoft Edge management service user policies to override local user policies.'
locale: en-us
document_id: fa976d84-5f47-9609-1627-ad1af04ce1ff
document_version_independent_id: fa976d84-5f47-9609-1627-ad1af04ce1ff
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeManagementUserPolicyOverridesCloudMachinePolicy.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeManagementUserPolicyOverridesCloudMachinePolicy.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 204
asset_id: microsoft-edge-policies/edgemanagementuserpolicyoverridescloudmachinepolicy
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeManagementUserPolicyOverridesCloudMachinePolicy.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5823e35a-4a81-0155-faea-8ce2af092b8a
---

# Microsoft Edge Browser Policy Documentation EdgeManagementUserPolicyOverridesCloudMachinePolicy | Microsoft Learn

## Allow cloud-based Microsoft Edge management service user policies to override local user policies.

## Supported versions

- Windows: ≥ 119
- macOS: ≥ 119
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, cloud-based Microsoft Edge management service user policies take precedence if it conflicts with local user policy.

If you disable or don't configure this policy, Microsoft Edge management service user policies take precedence.

The policy can be combined with [EdgeManagementPolicyOverridesPlatformPolicy](edgemanagementpolicyoverridesplatformpolicy). If both policies are enabled, all cloud-based Microsoft Edge management service policies take precedence over conflicting local service policies.

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

- GP unique name: EdgeManagementUserPolicyOverridesCloudMachinePolicy
- GP name: Allow cloud-based Microsoft Edge management service user policies to override local user policies.
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
- Value name: EdgeManagementUserPolicyOverridesCloudMachinePolicy
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: EdgeManagementUserPolicyOverridesCloudMachinePolicy
- Example value:

```xml
<false/>
```