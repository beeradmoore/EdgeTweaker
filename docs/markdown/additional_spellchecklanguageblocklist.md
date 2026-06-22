---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SpellcheckLanguageBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/spellchecklanguageblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force disable spellcheck languages'
locale: en-us
document_id: be0704b0-2936-8dea-ef21-3fae1fb550ea
document_version_independent_id: be0704b0-2936-8dea-ef21-3fae1fb550ea
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SpellcheckLanguageBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/SpellcheckLanguageBlocklist.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 211
asset_id: microsoft-edge-policies/spellchecklanguageblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SpellcheckLanguageBlocklist.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b0ea76e2-940c-bf9d-1e73-197cd632ffef
---

# Microsoft Edge Browser Policy Documentation SpellcheckLanguageBlocklist | Microsoft Learn

## Force disable spellcheck languages

## Supported versions

- Windows: ≥ 78
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Force-disables spellcheck languages. Unrecognized languages in that list will be ignored.

If you enable this policy, spellcheck will be disabled for the languages specified. The user can still enable or disable spellcheck for languages not in the list.

If you don't set this policy, or disable it, there is no change to the user's spellcheck preferences.

If the [SpellcheckEnabled](spellcheckenabled) policy is set to disabled, this policy has no effect.

If a language is included in both the [SpellcheckLanguage](spellchecklanguage) and the 'SpellcheckLanguageBlocklist' policy, the spellcheck language is enabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SpellcheckLanguageBlocklist
- GP name: Force disable spellcheck languages
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
fr
```

```
es
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SpellcheckLanguageBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SpellcheckLanguageBlocklist\1 =

```
fr
```

SOFTWARE\Policies\Microsoft\Edge\SpellcheckLanguageBlocklist\2 =

```
es
```