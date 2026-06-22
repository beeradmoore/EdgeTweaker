---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MathSolverEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/mathsolverenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Let users snip a Math problem and get the solution with a step-by-step explanation in Microsoft Edge (obsolete)'
locale: en-us
document_id: 67d56352-61aa-ae99-2ea7-3d5298fd1fc6
document_version_independent_id: 67d56352-61aa-ae99-2ea7-3d5298fd1fc6
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MathSolverEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/MathSolverEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 266
asset_id: microsoft-edge-policies/mathsolverenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MathSolverEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f9a1c1a7-8519-61f4-69e6-f7cc55693427
---

# Microsoft Edge Browser Policy Documentation MathSolverEnabled | Microsoft Learn

## Let users snip a Math problem and get the solution with a step-by-step explanation in Microsoft Edge (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 125.

## Supported versions

- Windows: 91-125
- macOS: 91-125
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsoleted because Math Solver is deprecated from Microsoft Edge. This policy doesn't work in Microsoft Edge version 126. This policy lets you manage whether users can use the Math Solver tool in Microsoft Edge or not.

If you enable or don't configure the policy, then a user can take a snip of the Math problem and get the solution including a step-by-step explanation of the solution in a Microsoft Edge side pane.

If you disable the policy, the Math Solver tool is disabled and users can't use it.

Note: Setting the [ComponentUpdatesEnabled](componentupdatesenabled) policy to disabled also disables the Math Solver component.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: MathSolverEnabled
- GP name: Let users snip a Math problem and get the solution with a step-by-step explanation in Microsoft Edge (obsolete)
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
- Value name: MathSolverEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: MathSolverEnabled
- Example value:

```xml
<true/>
```