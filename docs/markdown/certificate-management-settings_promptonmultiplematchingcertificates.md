---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PromptOnMultipleMatchingCertificates | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/promptonmultiplematchingcertificates
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Prompt the user to select a certificate when multiple certificates match'
locale: en-us
document_id: f3ad6dae-79d1-1e3a-e25e-7ab7a1ad1464
document_version_independent_id: f3ad6dae-79d1-1e3a-e25e-7ab7a1ad1464
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PromptOnMultipleMatchingCertificates.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/PromptOnMultipleMatchingCertificates.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 202
asset_id: microsoft-edge-policies/promptonmultiplematchingcertificates
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PromptOnMultipleMatchingCertificates.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7f8067c9-cee7-38a7-58de-f097038dbc3c
---

# Microsoft Edge Browser Policy Documentation PromptOnMultipleMatchingCertificates | Microsoft Learn

## Prompt the user to select a certificate when multiple certificates match

## Supported versions

- Windows: ≥ 100
- macOS: ≥ 100
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether the user is prompted to select a client certificate when more than one certificate matches [AutoSelectCertificateForUrls](autoselectcertificateforurls). If this policy is set to True, the user is prompted to select a client certificate whenever the auto-selection policy matches multiple certificates. If this policy is set to False or not set, the user may only be prompted when no certificate matches the auto-selection.

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

- GP unique name: PromptOnMultipleMatchingCertificates
- GP name: Prompt the user to select a certificate when multiple certificates match
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
- Value name: PromptOnMultipleMatchingCertificates
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PromptOnMultipleMatchingCertificates
- Example value:

```xml
<true/>
```