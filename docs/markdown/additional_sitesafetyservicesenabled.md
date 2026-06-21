---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SiteSafetyServicesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sitesafetyservicesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to configure Site safety services (obsolete)'
locale: en-us
document_id: 86dfaa64-ab8e-bd83-1ee4-5d878ba93b15
document_version_independent_id: 86dfaa64-ab8e-bd83-1ee4-5d878ba93b15
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SiteSafetyServicesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SiteSafetyServicesEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 209
asset_id: microsoft-edge-policies/sitesafetyservicesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SiteSafetyServicesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 144dbb7f-440e-e504-db68-f4b05b56956e
---

# Microsoft Edge Browser Policy Documentation SiteSafetyServicesEnabled | Microsoft Learn

## Allow users to configure Site safety services (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 127.

## Supported versions

- Windows: 101-127
- macOS: 101-127
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete as the feature is being removed after Microsoft Edge version 127.

This policy disables site safety services from showing top site info in the page info dialog.

If you enable this policy or don't configure it, the top site info will be shown.

If you disable this policy, the top site info won't be shown.

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

- GP unique name: SiteSafetyServicesEnabled
- GP name: Allow users to configure Site safety services (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SiteSafetyServicesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SiteSafetyServicesEnabled
- Example value:

```xml
<true/>
```