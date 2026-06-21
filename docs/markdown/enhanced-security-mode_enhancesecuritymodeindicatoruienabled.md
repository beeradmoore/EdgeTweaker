---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnhanceSecurityModeIndicatorUIEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enhancesecuritymodeindicatoruienabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Manage the indicator UI of the Enhanced Security Mode (ESM) feature in Microsoft Edge'
locale: en-us
document_id: 234cf1a3-d4d2-ad2c-b757-c9170b545b32
document_version_independent_id: 234cf1a3-d4d2-ad2c-b757-c9170b545b32
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeIndicatorUIEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeIndicatorUIEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 223
asset_id: microsoft-edge-policies/enhancesecuritymodeindicatoruienabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeIndicatorUIEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 33118a45-531b-576e-6ae6-804ffd13b6fc
---

# Microsoft Edge Browser Policy Documentation EnhanceSecurityModeIndicatorUIEnabled | Microsoft Learn

## Manage the indicator UI of the Enhanced Security Mode (ESM) feature in Microsoft Edge

## Supported versions

- Windows: ≥ 115
- macOS: ≥ 115
- Android: Not supported
- iOS: Not supported

## Description

This policy manages whether the indicator User Interface (UI) for enhanced security mode is shown or not when ESM is on.

If you enable or don't configure this policy, the indicator UI is on.

If you disable this policy, the indicator UI is off.

Note: If this policy is used, only the indicator User Interface experience is supressed - ESM is still turned on. For more information, see the [EnhanceSecurityMode](enhancesecuritymode) policy.

For detailed information about Enhanced Security Mode, see https://go.microsoft.com/fwlink/?linkid=2185895

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnhanceSecurityModeIndicatorUIEnabled
- GP name: Manage the indicator UI of the Enhanced Security Mode (ESM) feature in Microsoft Edge
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
- Value name: EnhanceSecurityModeIndicatorUIEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EnhanceSecurityModeIndicatorUIEnabled
- Example value:

```xml
<true/>
```