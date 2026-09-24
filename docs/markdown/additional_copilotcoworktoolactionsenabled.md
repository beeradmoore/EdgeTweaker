---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CopilotCoworkToolActionsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/copilotcoworktoolactionsenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-29T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Cowork to take actions on your behalf'
locale: en-us
document_id: 96b70274-c165-1ea2-fe2c-a09914216a8f
document_version_independent_id: 96b70274-c165-1ea2-fe2c-a09914216a8f
updated_at: 2026-07-29T23:26:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CopilotCoworkToolActionsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/9f1871942f57afe89efe6bd2f2b953941d236ec7/edgeenterprise/microsoft-edge-policies/CopilotCoworkToolActionsEnabled.md
git_commit_id: 9f1871942f57afe89efe6bd2f2b953941d236ec7
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 215
asset_id: microsoft-edge-policies/copilotcoworktoolactionsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CopilotCoworkToolActionsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8261502c-20d9-7660-76ac-4f5e4794514d
---

# Microsoft Edge Browser Policy Documentation CopilotCoworkToolActionsEnabled | Microsoft Learn

## Allow Cowork to take actions on your behalf

## Supported versions

- Windows: ≥ 152
- macOS: ≥ 152
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Cowork is allowed to take actions on behalf of the user in Microsoft Edge.

If you enable this policy, Cowork can take actions on behalf of the user, and users can't change this setting on the Settings page.

If you disable this policy, Cowork can't take actions on behalf of the user, and users can't change this setting on the Settings page.

If you don't configure this policy, users can turn this setting on or off on the Settings page.

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

- GP unique name: CopilotCoworkToolActionsEnabled
- GP name: Allow Cowork to take actions on your behalf
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
- Value name: CopilotCoworkToolActionsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CopilotCoworkToolActionsEnabled
- Example value:

```xml
<true/>
```