---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PreventTyposquattingPromptOverride | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/preventtyposquattingpromptoverride
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Prevent bypassing Edge Website Typo Protection prompts for sites'
locale: en-us
document_id: 86ba4121-e8dc-21c3-ad52-dc18f4fd5475
document_version_independent_id: 86ba4121-e8dc-21c3-ad52-dc18f4fd5475
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PreventTyposquattingPromptOverride.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/PreventTyposquattingPromptOverride.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 267
asset_id: microsoft-edge-policies/preventtyposquattingpromptoverride
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PreventTyposquattingPromptOverride.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 30087073-1373-ae9a-6697-5c17f7f3e392
---

# Microsoft Edge Browser Policy Documentation PreventTyposquattingPromptOverride | Microsoft Learn

## Prevent bypassing Edge Website Typo Protection prompts for sites

## Supported versions

- Windows: ≥ 121
- macOS: ≥ 121
- Android: ≥ 124
- iOS: Not supported

## Description

This policy setting lets you decide whether users can override the Edge Website Typo Protection warnings about potential typosquatting websites.

If you enable this setting, users can't ignore Edge Website Typo Protection warnings, and they're blocked from continuing to the site.

If you disable or don't configure this setting, users can ignore Edge Website Typo Protection warnings and continue to the site.

This only takes effect when TyposquattingCheckerEnabled policy isn't set or is set to enabled.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10 Pro or Enterprise instances that enrolled for device management, or macOS instances that are managed via MDM or joined to a domain via MCX.

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

- GP unique name: PreventTyposquattingPromptOverride
- GP name: Prevent bypassing Edge Website Typo Protection prompts for sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Edge Website Typo Protection settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PreventTyposquattingPromptOverride
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PreventTyposquattingPromptOverride
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: PreventTyposquattingPromptOverride
- Example value:

```
true
```