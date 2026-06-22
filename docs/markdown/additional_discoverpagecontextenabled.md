---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DiscoverPageContextEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/discoverpagecontextenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Discover access to page contents for AAD profiles (obsolete)'
locale: en-us
document_id: 341eacf3-64df-9555-a208-38273cf0c9da
document_version_independent_id: 341eacf3-64df-9555-a208-38273cf0c9da
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DiscoverPageContextEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/DiscoverPageContextEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 317
asset_id: microsoft-edge-policies/discoverpagecontextenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DiscoverPageContextEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/1433a524-c01f-4b87-beab-670c040dea4f
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/312f1f05-a431-4193-8a4d-e6245d5966de
platformId: be73a9f7-b1b3-05fe-f26d-85077b4ec9b4
---

# Microsoft Edge Browser Policy Documentation DiscoverPageContextEnabled | Microsoft Learn

## Enable Discover access to page contents for AAD profiles (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 127.

## Supported versions

- Windows: 113-127
- macOS: 113-127
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete as of Microsoft Edge version 127. Two new Microsoft Edge Policies took its place. Those policies are CopilotPageContext (Control Copilot access to page contents for AAD profiles) and CopilotCDPPageContext (Control Copilot with Commercial Data Protection access to page contents for AAD profiles).

This policy didn't allow for separate control of Copilot and Copilot with Commercial Data Protection. The new policies allow separate control of these versions of Copilot. The new policies also allow admins to force-enable Copilot access to Microsoft Edge page contents by enabling the policy, whereas DiscoverPageContextEnabled only allows force-disabling of Copilot page access.

This policy controls Discover access to page contents for AAD profiles. Discover is an extension that hosts Bing Chat. To summarize pages and interact with text selections, it must access the page contents. When enabled, page contents are sent to Bing. This policy doesn't affect MSA profiles.

If you enable or don't configure this policy, Discover has access to page contents.

If you disable this policy, Discover can't access page contents.

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

- GP unique name: DiscoverPageContextEnabled
- GP name: Enable Discover access to page contents for AAD profiles (obsolete)
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
- Value name: DiscoverPageContextEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: DiscoverPageContextEnabled
- Example value:

```xml
<true/>
```