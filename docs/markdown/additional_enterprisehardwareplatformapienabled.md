---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnterpriseHardwarePlatformAPIEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enterprisehardwareplatformapienabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow managed extensions to use the Enterprise Hardware Platform API'
locale: en-us
document_id: ab562609-85fc-87c0-207c-08755b5772a5
document_version_independent_id: ab562609-85fc-87c0-207c-08755b5772a5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnterpriseHardwarePlatformAPIEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EnterpriseHardwarePlatformAPIEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 195
asset_id: microsoft-edge-policies/enterprisehardwareplatformapienabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnterpriseHardwarePlatformAPIEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: ab125203-9179-f0e0-618e-931e1826599c
---

# Microsoft Edge Browser Policy Documentation EnterpriseHardwarePlatformAPIEnabled | Microsoft Learn

## Allow managed extensions to use the Enterprise Hardware Platform API

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: ≥ 71
- iOS: Not supported

## Description

When this policy is set to enabled, extensions installed by enterprise policy are allowed to use the Enterprise Hardware Platform API. When this policy is set to disabled or isn't set, no extensions are allowed to use the Enterprise Hardware Platform API. This policy also applies to component extensions.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnterpriseHardwarePlatformAPIEnabled
- GP name: Allow managed extensions to use the Enterprise Hardware Platform API
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
- Value name: EnterpriseHardwarePlatformAPIEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EnterpriseHardwarePlatformAPIEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: EnterpriseHardwarePlatformAPIEnabled
- Example value:

```
true
```