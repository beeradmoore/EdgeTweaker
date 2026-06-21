---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation FamilySafetySettingsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/familysafetysettingsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to configure Family safety and Kids Mode'
locale: en-us
document_id: 71e37ac3-9cdf-e7d8-bef3-c3fe5c1b54b9
document_version_independent_id: 71e37ac3-9cdf-e7d8-bef3-c3fe5c1b54b9
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/FamilySafetySettingsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/FamilySafetySettingsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 252
asset_id: microsoft-edge-policies/familysafetysettingsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/FamilySafetySettingsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b7817f8b-4549-e396-cd1e-2664856ca541
---

# Microsoft Edge Browser Policy Documentation FamilySafetySettingsEnabled | Microsoft Learn

## Allow users to configure Family safety and Kids Mode

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: Not supported
- iOS: Not supported

## Description

This policy disables two family safety-related features in the browser. This hides the Family page inside Settings, and navigation to edge://settings/family is blocked. The family settings page describes what features are available with family groups with Microsoft Family Safety. Learn more about Family Safety here: (https://go.microsoft.com/fwlink/?linkid=2098432). Starting in Microsoft Edge version 90, this policy also disables Kids Mode, a kid-friendly browsing mode with custom themes and allow list browsing that requires the device password to exit. Learn more about Kids Mode here: (https://go.microsoft.com/fwlink/?linkid=2146910)

If you enable this policy or don't configure it, the family page in Settings is shown and Kids Mode is available.

If you disable this policy, the family page isn't shown, and Kids Mode is hidden.

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

- GP unique name: FamilySafetySettingsEnabled
- GP name: Allow users to configure Family safety and Kids Mode
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
- Value name: FamilySafetySettingsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: FamilySafetySettingsEnabled
- Example value:

```xml
<true/>
```