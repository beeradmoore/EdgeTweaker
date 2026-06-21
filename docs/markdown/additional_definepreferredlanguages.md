---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefinePreferredLanguages | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/definepreferredlanguages
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Define an ordered list of preferred languages that websites should display in if the site supports the language'
locale: en-us
document_id: be45c4a5-9a7d-570c-c1f4-c600a2391830
document_version_independent_id: be45c4a5-9a7d-570c-c1f4-c600a2391830
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefinePreferredLanguages.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefinePreferredLanguages.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 292
asset_id: microsoft-edge-policies/definepreferredlanguages
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefinePreferredLanguages.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5c73e9a1-150b-195c-d974-863fc2b2acfe
---

# Microsoft Edge Browser Policy Documentation DefinePreferredLanguages | Microsoft Learn

## Define an ordered list of preferred languages that websites should display in if the site supports the language

## Supported versions

- Windows: ≥ 89
- macOS: ≥ 89
- Android: Not supported
- iOS: Not supported

## Description

Configures the language variants that Microsoft Edge sends to websites as part of the Accept-Language request HTTP header and prevents users from adding, removing, or changing the order of preferred languages in Microsoft Edge settings. Users who want to change the languages Microsoft Edge displays in or offers to translate pages to will be limited to the languages configured in this policy.

If you enable this policy, websites will appear in the first language in the list that they support unless other site-specific logic is used to determine the display language. The language variants defined in this policy override the languages configured as part of the [SpellcheckLanguage](spellchecklanguage) policy.

If you don't configure or disable this policy, Microsoft Edge sends websites the user-specified preferred languages as part of the Accept-Language request HTTP header.

For detailed information on valid language variants, see https://go.microsoft.com/fwlink/?linkid=2148854.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefinePreferredLanguages
- GP name: Define an ordered list of preferred languages that websites should display in if the site supports the language
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
en-US,fr,es
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefinePreferredLanguages
- Value type: REG\_SZ

#### Example registry value

```
en-US,fr,es
```

## Mac information and settings

- Preference Key name: DefinePreferredLanguages
- Example value:

```xml
<string>en-US,fr,es</string>
```