---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RAMResourceControlsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/ramresourcecontrolsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable RAM (memory) resource controls'
locale: en-us
document_id: a69ada65-752f-1fd9-5de6-753711d7eb30
document_version_independent_id: a69ada65-752f-1fd9-5de6-753711d7eb30
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RAMResourceControlsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RAMResourceControlsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 196
asset_id: microsoft-edge-policies/ramresourcecontrolsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RAMResourceControlsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 43b45f8e-2c6a-74e1-7485-40fd19c64a88
---

# Microsoft Edge Browser Policy Documentation RAMResourceControlsEnabled | Microsoft Learn

## Enable RAM (memory) resource controls

## Supported versions

- Windows: ≥ 143
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether users can access the RAM (memory) resource control feature. This feature lets users set an individual limit on how much RAM (memory) the browser can use.

To set a specific memory limit, use the [TotalMemoryLimitMb](totalmemorylimitmb) policy.

If you enable or don't configure this policy, users can enable resource control and set the amount of RAM that Microsoft Edge can use. Browser performance may be affected by low limits.

If you disable this policy, users can't use resource control.

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

- GP unique name: RAMResourceControlsEnabled
- GP name: Enable RAM (memory) resource controls
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Performance
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RAMResourceControlsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```