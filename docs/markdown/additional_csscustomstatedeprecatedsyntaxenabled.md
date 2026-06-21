---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CSSCustomStateDeprecatedSyntaxEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/csscustomstatedeprecatedsyntaxenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Controls whether the deprecated :--foo syntax for CSS custom state is enabled (obsolete)'
locale: en-us
document_id: 6c10c626-909d-4f01-bf94-8d0821fcfc8e
document_version_independent_id: 6c10c626-909d-4f01-bf94-8d0821fcfc8e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CSSCustomStateDeprecatedSyntaxEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CSSCustomStateDeprecatedSyntaxEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 232
asset_id: microsoft-edge-policies/csscustomstatedeprecatedsyntaxenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CSSCustomStateDeprecatedSyntaxEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1cbe12dc-f069-f631-0d03-cf2017ff72fb
---

# Microsoft Edge Browser Policy Documentation CSSCustomStateDeprecatedSyntaxEnabled | Microsoft Learn

## Controls whether the deprecated :--foo syntax for CSS custom state is enabled (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 132.

## Supported versions

- Windows: 127-132
- macOS: 127-132
- Android: Not supported
- iOS: Not supported

## Description

The :--foo syntax for the CSS custom state feature is being changed to :state(foo) in Microsoft Edge to comply with changes that are made in Firefox and Safari. This policy allows the deprecated syntax to be used until Stable 132.

This deprecation breaks some Microsoft Edge-only websites that use the deprecated :--foo syntax.

If you enable this policy, the deprecated syntax is enabled.

If you disable or don't configure this policy, the deprecated syntax is disabled.

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

- GP unique name: CSSCustomStateDeprecatedSyntaxEnabled
- GP name: Controls whether the deprecated :--foo syntax for CSS custom state is enabled (obsolete)
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
- Value name: CSSCustomStateDeprecatedSyntaxEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: CSSCustomStateDeprecatedSyntaxEnabled
- Example value:

```xml
<true/>
```