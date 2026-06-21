---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeEntraCopilotPageContext | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeentracopilotpagecontext
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control Copilot access to Microsoft Edge page content for Entra account user profiles when using Copilot in the Microsoft Edge sidepane'
locale: en-us
document_id: a5995cd5-e4c7-1c00-d684-bb7a475bfce8
document_version_independent_id: a5995cd5-e4c7-1c00-d684-bb7a475bfce8
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeEntraCopilotPageContext.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeEntraCopilotPageContext.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 343
asset_id: microsoft-edge-policies/edgeentracopilotpagecontext
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeEntraCopilotPageContext.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 041b7f1c-8737-0ff8-d615-70e9a1037139
---

# Microsoft Edge Browser Policy Documentation EdgeEntraCopilotPageContext | Microsoft Learn

## Control Copilot access to Microsoft Edge page content for Entra account user profiles when using Copilot in the Microsoft Edge sidepane

## Supported versions

- Windows: ≥ 130
- macOS: ≥ 130
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Copilot in the Microsoft Edge side pane can access page content. This includes page summarization and other contextual queries.

This policy applies only to users who are signed in to Microsoft Edge with a Microsoft Entra account and are using Copilot in the side pane. It applies to Copilot experiences in the side pane, including Microsoft 365 Copilot Business Chat and Microsoft Copilot with enterprise data protection (EDP).

If you enable this policy, Copilot can access page content when users submit contextual queries in the side pane.

If you disable this policy, Copilot can't access page content. This also disables the M365LinksAutoOpenCopilotEnabled feature, because Copilot requires page content access to provide contextual insights for Microsoft 365 links.

If you don't configure this policy:

- Access is enabled by default in non-EU regions.
- Access is disabled by default in EU regions.
- Users can turn this setting on or off in Microsoft Edge settings.

Copilot can't access page content on pages protected by data loss prevention (DLP) policies, even if this policy is enabled.

For more information about Copilot data usage and consent, see https://go.microsoft.com/fwlink/?linkid=2288056

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

- GP unique name: EdgeEntraCopilotPageContext
- GP name: Control Copilot access to Microsoft Edge page content for Entra account user profiles when using Copilot in the Microsoft Edge sidepane
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
- Value name: EdgeEntraCopilotPageContext
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EdgeEntraCopilotPageContext
- Example value:

```xml
<true/>
```