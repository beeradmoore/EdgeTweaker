---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultBrowserSettingsCampaignEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultbrowsersettingscampaignenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enables default browser settings campaigns'
locale: en-us
document_id: 1f4c6cdb-c996-042e-5610-119c9f53f569
document_version_independent_id: 1f4c6cdb-c996-042e-5610-119c9f53f569
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultBrowserSettingsCampaignEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/DefaultBrowserSettingsCampaignEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/defaultbrowsersettingscampaignenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultBrowserSettingsCampaignEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/9b11aaae-66fe-4b2c-9a1f-36ce40bf4e7f
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/c0b42e77-fe0d-40dd-9718-99dacb85bf74
platformId: a6883337-5247-ce76-0748-01086d9ce369
---

# Microsoft Edge Browser Policy Documentation DefaultBrowserSettingsCampaignEnabled | Microsoft Learn

## Enables default browser settings campaigns

## Supported versions

- Windows: ≥ 113
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy enables the default browser settings campaign. If a user selects to accept the campaign, their default browser and/or default search engine will be changed to Microsoft Edge and Microsoft Bing, respectively. If the user dismisses the campaign, the user's browser settings remain unchanged.

If you enable or don't configure this policy, users will be prompted to set Microsoft Edge as the default browser and Microsoft Bing as the default search engine, if they don't have those browser settings.

If you disable this policy, users won't be prompted to set Microsoft Edge as the default browser, or to set Microsoft Bing as the default search engine.

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

- GP unique name: DefaultBrowserSettingsCampaignEnabled
- GP name: Enables default browser settings campaigns
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
- Value name: DefaultBrowserSettingsCampaignEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```