---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CopilotCDPPageContext | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/copilotcdppagecontext
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control Copilot with Commercial Data Protection access to page context for Microsoft Entra ID profiles (obsolete)'
locale: en-us
document_id: 65083d7d-e6be-c6fb-f57f-649cb5e36ce4
document_version_independent_id: 65083d7d-e6be-c6fb-f57f-649cb5e36ce4
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CopilotCDPPageContext.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CopilotCDPPageContext.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 310
asset_id: microsoft-edge-policies/copilotcdppagecontext
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CopilotCDPPageContext.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 81d7aef9-4470-d4b3-f391-192af7afadf6
---

# Microsoft Edge Browser Policy Documentation CopilotCDPPageContext | Microsoft Learn

## Control Copilot with Commercial Data Protection access to page context for Microsoft Entra ID profiles (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 132.

## Supported versions

- Windows: 124-132
- macOS: 124-132
- Android: Not supported
- iOS: Not supported

## Description

This policy has been obsoleted as of Edge 133. Instead of this obsolete policy, we recommend using [EdgeEntraCopilotPageContext](edgeentracopilotpagecontext).

This policy controls access to page contents for Copilot with Commercial Data Protection in the Edge sidebar. This policy applies only to Microsoft Entra ID profiles. To summarize pages and interact with text selections, it needs to be able to access the page contents. This policy doesn't apply to MSA profiles. This policy doesn't control access for Copilot without Commercial Data Protection. Access for Copilot without Commercial Data Protection is controlled by the policy CopilotPageContext.

If you enable this policy, Copilot with Commercial Data Protection will have access to page context.

If you don't configure this policy, a user can enable access to page context for Copilot with Commercial Data Protection using the setting toggle in Edge.

If you disable this policy, Copilot with Commercial Data Protection won't be able to access page context.

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

- GP unique name: CopilotCDPPageContext
- GP name: Control Copilot with Commercial Data Protection access to page context for Microsoft Entra ID profiles (obsolete)
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
- Value name: CopilotCDPPageContext
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CopilotCDPPageContext
- Example value:

```xml
<true/>
```