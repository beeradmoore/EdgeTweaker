---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MicrosoftEditorSynonymsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/microsofteditorsynonymsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Synonyms are provided when using Microsoft Editor spell checker'
locale: en-us
document_id: 6d610037-b154-665e-d8a6-9732ed2f5d68
document_version_independent_id: 6d610037-b154-665e-d8a6-9732ed2f5d68
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MicrosoftEditorSynonymsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/MicrosoftEditorSynonymsEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 232
asset_id: microsoft-edge-policies/microsofteditorsynonymsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MicrosoftEditorSynonymsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5dff4749-69fd-8300-73a9-059775178410
---

# Microsoft Edge Browser Policy Documentation MicrosoftEditorSynonymsEnabled | Microsoft Learn

## Synonyms are provided when using Microsoft Editor spell checker

## Supported versions

- Windows: ≥ 105
- macOS: ≥ 105
- Android: Not supported
- iOS: Not supported

## Description

The Microsoft Editor service provides enhanced spell and grammar checking for editable text fields on web pages, and synonyms can be suggested as an integrated feature.

If you enable this policy, Microsoft Editor spell checker provides synonyms for suggestions for misspelled words.

If you disable or don't configure this policy, Microsoft Editor spell checker won't provide synonyms for suggestions for misspelled words.

If the [SpellcheckEnabled](spellcheckenabled) policy or the [MicrosoftEditorProofingEnabled](microsofteditorproofingenabled) policy are set to disabled, or the user disables spell checking or chooses not to use Microsoft Editor spell checker in the settings page, this policy will have no effect.

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

- GP unique name: MicrosoftEditorSynonymsEnabled
- GP name: Synonyms are provided when using Microsoft Editor spell checker
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: MicrosoftEditorSynonymsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: MicrosoftEditorSynonymsEnabled
- Example value:

```xml
<false/>
```