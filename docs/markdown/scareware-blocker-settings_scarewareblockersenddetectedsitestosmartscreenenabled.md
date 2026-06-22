---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ScarewareBlockerSendDetectedSitesToSmartScreenEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/scarewareblockersenddetectedsitestosmartscreenenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Microsoft Edge Scareware blocker to share URLs of sites detected as potential tech scams with Microsoft Defender SmartScreen'
locale: en-us
document_id: 7180072a-dbae-6555-c43e-ef5dab7ecda4
document_version_independent_id: 7180072a-dbae-6555-c43e-ef5dab7ecda4
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ScarewareBlockerSendDetectedSitesToSmartScreenEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/ScarewareBlockerSendDetectedSitesToSmartScreenEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 239
asset_id: microsoft-edge-policies/scarewareblockersenddetectedsitestosmartscreenenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ScarewareBlockerSendDetectedSitesToSmartScreenEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c671beaa-a830-4c9f-aceb-97379ee031ca
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8921374c-4dbe-4ed0-b011-a39e18bfbd98
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6f340481-6a2f-96a2-ceef-104005dbddf1
---

# Microsoft Edge Browser Policy Documentation ScarewareBlockerSendDetectedSitesToSmartScreenEnabled | Microsoft Learn

## Configure Microsoft Edge Scareware blocker to share URLs of sites detected as potential tech scams with Microsoft Defender SmartScreen

## Supported versions

- Windows: ≥ 142
- macOS: ≥ 142
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge shares URLs of sites that are detected as potential tech scams with Microsoft Defender SmartScreen.

This policy only takes effect if ScarewareBlockerProtectionEnabled is enabled.

If you enable this policy, Microsoft Edge shares URLs of sites detected as potential tech scams with Microsoft Defender SmartScreen.

If you disable or don't configure this policy, Microsoft Edge doesn't share URLs of sites detected as potential tech scams with Microsoft Defender SmartScreen.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ScarewareBlockerSendDetectedSitesToSmartScreenEnabled
- GP name: Configure Microsoft Edge Scareware blocker to share URLs of sites detected as potential tech scams with Microsoft Defender SmartScreen
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Scareware Blocker settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Scareware Blocker settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ScarewareBlockerSendDetectedSitesToSmartScreenEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ScarewareBlockerSendDetectedSitesToSmartScreenEnabled
- Example value:

```xml
<true/>
```