---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShareBrowsingHistoryWithCopilotSearchAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sharebrowsinghistorywithcopilotsearchallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow sharing tenant-approved browsing history with Microsoft 365 Copilot Search'
locale: en-us
document_id: 74b0b7a6-5ded-5f77-8fc3-2cff94b53beb
document_version_independent_id: 74b0b7a6-5ded-5f77-8fc3-2cff94b53beb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShareBrowsingHistoryWithCopilotSearchAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ShareBrowsingHistoryWithCopilotSearchAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 249
asset_id: microsoft-edge-policies/sharebrowsinghistorywithcopilotsearchallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShareBrowsingHistoryWithCopilotSearchAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
platformId: 3e35ef39-792b-8ee7-3c25-3cd9eebd1144
---

# Microsoft Edge Browser Policy Documentation ShareBrowsingHistoryWithCopilotSearchAllowed | Microsoft Learn

## Allow sharing tenant-approved browsing history with Microsoft 365 Copilot Search

## Supported versions

- Windows: ≥ 143
- macOS: ≥ 143
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether browsing history in Microsoft Edge is shared with Microsoft 365 Copilot Search to provide more relevant search results. Only tenant-approved, work-related sites are shared.

This feature is available only to users who are signed in to Microsoft Edge with an Entra ID account and have an eligible Microsoft 365 Copilot license.

If you enable or don't configure this policy, browsing history will be shared with Microsoft 365 Copilot Search by default, and users can turn off sharing using the toggle in Microsoft Edge settings.

If you disable this policy, browsing history won't be shared with Microsoft 365 Copilot Search.

Learn more about how Copilot uses data and consent at https://go.microsoft.com/fwlink/?linkid=2333202

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

- GP unique name: ShareBrowsingHistoryWithCopilotSearchAllowed
- GP name: Allow sharing tenant-approved browsing history with Microsoft 365 Copilot Search
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
- Value name: ShareBrowsingHistoryWithCopilotSearchAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ShareBrowsingHistoryWithCopilotSearchAllowed
- Example value:

```xml
<true/>
```