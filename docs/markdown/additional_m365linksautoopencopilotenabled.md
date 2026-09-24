---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation M365LinksAutoOpenCopilotEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/m365linksautoopencopilotenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Automatically open Copilot side pane with contextual insights for links opened from Outlook'
locale: en-us
document_id: e8602993-dc50-ee87-379b-b7bb5d9850b0
document_version_independent_id: e8602993-dc50-ee87-379b-b7bb5d9850b0
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/M365LinksAutoOpenCopilotEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/M365LinksAutoOpenCopilotEnabled.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 282
asset_id: microsoft-edge-policies/m365linksautoopencopilotenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/M365LinksAutoOpenCopilotEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/3e34b70d-bca0-4369-a01b-71d1edfd427b
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/8ca32b3f-fa14-46df-b09a-9c4a591d6396
platformId: 295d4386-57a0-6830-2d69-ec1d237a9a44
---

# Microsoft Edge Browser Policy Documentation M365LinksAutoOpenCopilotEnabled | Microsoft Learn

## Automatically open Copilot side pane with contextual insights for links opened from Outlook

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge automatically opens the Microsoft Copilot side pane when users open eligible web links from Outlook emails sent from the same tenant.

Starting in Microsoft Edge version 148, eligible links from Outlook emails sent from the same tenant can open with the Copilot side pane. Copilot can use the originating Outlook email as context to surface relevant insights and suggested next steps alongside the web content.

If you enable this policy or don't configure it, the Copilot side pane opens automatically when users open eligible links from Outlook emails sent from the same tenant.

If you disable this policy, the Copilot side pane doesn't open automatically for those links.

This policy is not yet supported. When support becomes available, eligible links from Outlook emails sent from the same tenant can open with the Copilot side pane.

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

- GP unique name: M365LinksAutoOpenCopilotEnabled
- GP name: Automatically open Copilot side pane with contextual insights for links opened from Outlook
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
- Value name: M365LinksAutoOpenCopilotEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: M365LinksAutoOpenCopilotEnabled
- Example value:

```xml
<true/>
```