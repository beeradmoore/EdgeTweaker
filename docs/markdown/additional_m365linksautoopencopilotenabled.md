---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation M365LinksAutoOpenCopilotEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/m365linksautoopencopilotenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Automatically open Copilot side pane with contextual insights for links opened from Outlook'
locale: en-us
document_id: e8602993-dc50-ee87-379b-b7bb5d9850b0
document_version_independent_id: e8602993-dc50-ee87-379b-b7bb5d9850b0
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/M365LinksAutoOpenCopilotEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/M365LinksAutoOpenCopilotEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 326
asset_id: microsoft-edge-policies/m365linksautoopencopilotenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/M365LinksAutoOpenCopilotEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/3e34b70d-bca0-4369-a01b-71d1edfd427b
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
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

This policy controls whether Microsoft Edge automatically opens the Microsoft Copilot side pane when users open web links from Outlook emails sent from the same tenant.

Starting in Microsoft Edge version 148, when users open eligible links from Outlook emails sent from the same tenant, Microsoft Edge automatically opens the Copilot side pane with contextual insights. Copilot can use the originating Outlook email as context to surface relevant insights and suggested next steps alongside the web content.

If you enable this policy or don't configure it, the Copilot side pane opens automatically when users open links from Outlook emails sent from the same tenant.

If you disable this policy, the Copilot side pane doesn't open automatically when users open links from Outlook emails sent from the same tenant.

This feature applies only to links opened from Outlook emails sent from the same tenant and requires Microsoft Copilot to be available for the user in Microsoft Edge.

This feature is disabled if the [CopilotPageContext](copilotpagecontext) policy or the [EdgeEntraCopilotPageContext](edgeentracopilotpagecontext) policy is disabled, regardless of this policy's configuration. Copilot requires access to page content to provide contextual insights.

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