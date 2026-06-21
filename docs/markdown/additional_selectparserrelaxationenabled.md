---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SelectParserRelaxationEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/selectparserrelaxationenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Controls whether the new HTML parser behavior for the &lt;select&gt; element is enabled (obsolete)'
locale: en-us
document_id: 0cf99a0e-f79d-0eb4-b206-b7f18af60c88
document_version_independent_id: 0cf99a0e-f79d-0eb4-b206-b7f18af60c88
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SelectParserRelaxationEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SelectParserRelaxationEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 222
asset_id: microsoft-edge-policies/selectparserrelaxationenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SelectParserRelaxationEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: cc40cbd5-a953-51ec-5c49-8014b73b3417
---

# Microsoft Edge Browser Policy Documentation SelectParserRelaxationEnabled | Microsoft Learn

## Controls whether the new HTML parser behavior for the &lt;select&gt; element is enabled (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 138.

## Supported versions

- Windows: 132-138
- macOS: 132-138
- Android: Not supported
- iOS: Not supported

## Description

The HTML parser is being changed to allow additional HTML tags inside the &lt;select&gt; element. This policy supports the old HTML parser behavior through Microsoft Edge version 138.

If this policy is enabled or unset, the HTML parser allows additional tags inside the &lt;select&gt; element.

If this policy is disabled, then the HTML parser restricts which tags can be put in the &lt;select&gt; element.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SelectParserRelaxationEnabled
- GP name: Controls whether the new HTML parser behavior for the &lt;select&gt; element is enabled (obsolete)
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
- Value name: SelectParserRelaxationEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SelectParserRelaxationEnabled
- Example value:

```xml
<true/>
```