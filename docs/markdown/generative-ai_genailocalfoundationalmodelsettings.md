---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation GenAILocalFoundationalModelSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/genailocalfoundationalmodelsettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Settings for GenAI local foundational model'
locale: en-us
document_id: c47f7b6a-692f-a9d0-ec62-02d8d24a9151
document_version_independent_id: c47f7b6a-692f-a9d0-ec62-02d8d24a9151
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/GenAILocalFoundationalModelSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/GenAILocalFoundationalModelSettings.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 296
asset_id: microsoft-edge-policies/genailocalfoundationalmodelsettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/GenAILocalFoundationalModelSettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: fdeac8b1-03af-0623-77ea-79eb0eb5b4ec
---

# Microsoft Edge Browser Policy Documentation GenAILocalFoundationalModelSettings | Microsoft Learn

## Settings for GenAI local foundational model

## Supported versions

- Windows: ≥ 132
- macOS: ≥ 132
- Android: ≥ 147
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge downloads the foundational GenAI model and uses it for local inference.

If you enable this policy and set the value to Allowed (0), the model is downloaded automatically and used for inference.

If you enable this policy and set the value to Disallowed (1), the model isn't downloaded, and the existing model (if already downloaded) is deleted.

If you disable or don't configure this policy, the default applies, and the model is downloaded automatically and used for inference.

Note: This policy supports dynamic refresh, so changes take effect without requiring a browser restart.

Model downloading can also be disabled by ComponentUpdatesEnabled.

Policy options mapping:

- Allowed (0) = Downloads model automatically
- Disallowed (1) = Do not download model

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Allowed (0) = Downloads model automatically
- Disallowed (1) = Do not download model

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: GenAILocalFoundationalModelSettings
- GP name: Settings for GenAI local foundational model
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Generative AI
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not download model
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: GenAILocalFoundationalModelSettings
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: GenAILocalFoundationalModelSettings
- Example value:

```xml
<integer>1</integer>
```

## Android information and settings

- Preference Key name: GenAILocalFoundationalModelSettings
- Example value:

```
1
```