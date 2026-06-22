---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BuiltInAIAPIsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/builtinaiapisenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow pages to use the built-in AI APIs.'
locale: en-us
document_id: 89fdd13f-e48f-210a-c207-b6b65e306595
document_version_independent_id: 89fdd13f-e48f-210a-c207-b6b65e306595
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BuiltInAIAPIsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/BuiltInAIAPIsEnabled.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 198
asset_id: microsoft-edge-policies/builtinaiapisenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BuiltInAIAPIsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d799ff22-5e7d-535f-6f51-214f5a1e75e3
---

# Microsoft Edge Browser Policy Documentation BuiltInAIAPIsEnabled | Microsoft Learn

## Allow pages to use the built-in AI APIs.

## Supported versions

- Windows: ≥ 138
- macOS: ≥ 138
- Android: Not supported
- iOS: Not supported

## Description

Use this policy to control whether websites can access the built-in AI APIs, including the LanguageModel API, Summarization API, Writer API, and Rewriter API.

Enable this policy to allow pages to use the APIs. If you don’t configure this policy, the APIs are still allowed.

Disable this policy to block access to the APIs. The APIs will return an error when used.

For more information, see https://github.com/webmachinelearning/writing-assistance-apis/blob/main/README.md.

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

- GP unique name: BuiltInAIAPIsEnabled
- GP name: Allow pages to use the built-in AI APIs.
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
- Value name: BuiltInAIAPIsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: BuiltInAIAPIsEnabled
- Example value:

```xml
<true/>
```