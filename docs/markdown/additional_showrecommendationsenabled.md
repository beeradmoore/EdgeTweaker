---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShowRecommendationsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/showrecommendationsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow feature recommendations and browser assistance notifications from Microsoft Edge'
locale: en-us
document_id: e38dc773-9262-552a-843d-f280766e192c
document_version_independent_id: e38dc773-9262-552a-843d-f280766e192c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShowRecommendationsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ShowRecommendationsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 290
asset_id: microsoft-edge-policies/showrecommendationsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShowRecommendationsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5239bdc2-3289-eb7b-5c25-7f50b3d48e79
---

# Microsoft Edge Browser Policy Documentation ShowRecommendationsEnabled | Microsoft Learn

## Allow feature recommendations and browser assistance notifications from Microsoft Edge

## Supported versions

- Windows: ≥ 89
- macOS: ≥ 89
- Android: Not supported
- iOS: Not supported

## Description

This setting controls the in-browser assistance notifications that are intended to help users get the most out of Microsoft Edge. This is done by recommending features and by helping them use browser features. These notifications take the form of dialog boxes, flyouts, coach marks and banners in the browser. An example of an assistance notification would be when a user has many tabs opened in the browser. In this instance, Microsoft Edge may prompt the user to try out the vertical tabs feature which is designed to give better browser tab management.

Disabling this policy stops this message from appearing again even if the user has too many tabs open. Any features that have been disabled by a management policy aren't suggested to users. If you enable or don't configure this setting, users receive recommendations or notifications from Microsoft Edge. If you disable this setting, users won't receive any recommendations or notifications from Microsoft Edge.

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

- GP unique name: ShowRecommendationsEnabled
- GP name: Allow feature recommendations and browser assistance notifications from Microsoft Edge
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
- Value name: ShowRecommendationsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ShowRecommendationsEnabled
- Example value:

```xml
<true/>
```