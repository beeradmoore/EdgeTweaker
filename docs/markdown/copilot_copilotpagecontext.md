---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CopilotPageContext | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/copilotpagecontext
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control Copilot access to page context for Microsoft Entra ID profiles'
locale: en-us
document_id: 4385916d-ac77-a1c8-68fa-ffea4b7d11bc
document_version_independent_id: 4385916d-ac77-a1c8-68fa-ffea4b7d11bc
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CopilotPageContext.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/CopilotPageContext.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 283
asset_id: microsoft-edge-policies/copilotpagecontext
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CopilotPageContext.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 27ee0f26-c74b-95e9-f493-becab7ab8682
---

# Microsoft Edge Browser Policy Documentation CopilotPageContext | Microsoft Learn

## Control Copilot access to page context for Microsoft Entra ID profiles

## Supported versions

- Windows: ≥ 124
- macOS: ≥ 124
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Copilot in the Microsoft Edge side pane can access page content.

This policy applies only to Microsoft Entra ID profiles in Microsoft Edge. It doesn't apply to Microsoft account (MSA) profiles.

Copilot requires access to page content to summarize pages and interact with text selections.

This policy doesn't control access for Copilot with enterprise data protection (EDP). Access for Copilot with EDP is controlled by the [EdgeEntraCopilotPageContext](edgeentracopilotpagecontext) policy.

If you enable this policy, Copilot can access page content.

If you disable this policy, Copilot can't access page content. This also disables the [M365LinksAutoOpenCopilotEnabled](m365linksautoopencopilotenabled) feature, because Copilot requires page content access to provide contextual insights for Microsoft 365 links.

If you don't configure this policy:

- Access is enabled by default in non-EU regions.
- Access is disabled by default in EU regions.
- Users can turn this setting on or off in Microsoft Edge settings.

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

- GP unique name: CopilotPageContext
- GP name: Control Copilot access to page context for Microsoft Entra ID profiles
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
- Value name: CopilotPageContext
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CopilotPageContext
- Example value:

```xml
<true/>
```