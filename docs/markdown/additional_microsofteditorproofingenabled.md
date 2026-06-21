---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MicrosoftEditorProofingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/microsofteditorproofingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Spell checking provided by Microsoft Editor'
locale: en-us
document_id: f8086842-19d3-1701-2e23-8e7871c81f21
document_version_independent_id: f8086842-19d3-1701-2e23-8e7871c81f21
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MicrosoftEditorProofingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/MicrosoftEditorProofingEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 223
asset_id: microsoft-edge-policies/microsofteditorproofingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MicrosoftEditorProofingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 41189559-b902-14f3-943b-70848b560efb
---

# Microsoft Edge Browser Policy Documentation MicrosoftEditorProofingEnabled | Microsoft Learn

## Spell checking provided by Microsoft Editor

## Supported versions

- Windows: ≥ 105
- macOS: ≥ 105
- Android: Not supported
- iOS: Not supported

## Description

The Microsoft Editor service provides enhanced spell and grammar checking for editable text fields on web pages.

If you enable or don't configure this policy, Microsoft Editor spell check can be used for eligible text fields.

If you disable this policy, spell check can only be provided by local engines that use platform or Hunspell services. The results from these engines might be less informative than the results Microsoft Editor can provide.

If the [SpellcheckEnabled](spellcheckenabled) policy is set to disabled, or the user disables spell checking in the settings page, this policy will have no effect.

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

- GP unique name: MicrosoftEditorProofingEnabled
- GP name: Spell checking provided by Microsoft Editor
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
- Value name: MicrosoftEditorProofingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: MicrosoftEditorProofingEnabled
- Example value:

```xml
<false/>
```