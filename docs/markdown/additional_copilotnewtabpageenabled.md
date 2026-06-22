---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CopilotNewTabPageEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/copilotnewtabpageenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable the Copilot new tab page'
locale: en-us
document_id: 80e0cfb4-73ef-d7bb-b9a2-b4d1b32c3ed6
document_version_independent_id: 80e0cfb4-73ef-d7bb-b9a2-b4d1b32c3ed6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CopilotNewTabPageEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CopilotNewTabPageEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 329
asset_id: microsoft-edge-policies/copilotnewtabpageenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CopilotNewTabPageEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d7e345a1-48df-64b5-084c-18e64d8d080b
---

# Microsoft Edge Browser Policy Documentation CopilotNewTabPageEnabled | Microsoft Learn

## Enable the Copilot new tab page

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: ≥ 148
- iOS: ≥ 148

## Description

This policy configures the availability of the Copilot new tab page in Microsoft Edge for Business.

The Copilot new tab page combines search and chat into a single input box and includes personalized cards that provide quick access to relevant files, calendar events, and suggested Copilot prompts. Users who do not have a Microsoft 365 Copilot license might experience limited relevance in Copilot prompt card content.

Most policies that customize the New Tab Page are supported on the Copilot new tab page. For a complete list of supported and unsupported policies, see https://go.microsoft.com/fwlink/?linkid=2330462.

This policy applies only to Microsoft Entra ID profiles and controls the Copilot new tab page experience in Microsoft Edge for Business. This policy does not apply to the Copilot new tab page on MSA profiles.

If you enable this policy, the Copilot new tab page is turned on.

If you disable or don't configure this policy, the Copilot new tab page is turned off. When the policy is not configured, users can turn it on via user settings.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CopilotNewTabPageEnabled
- GP name: Enable the Copilot new tab page
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: CopilotNewTabPageEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CopilotNewTabPageEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: CopilotNewTabPageEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: CopilotNewTabPageEnabled
- Example value:

```xml
<true/>
```