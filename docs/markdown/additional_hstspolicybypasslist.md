---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HSTSPolicyBypassList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/hstspolicybypasslist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of names that will bypass the HSTS policy check'
locale: en-us
document_id: ca093416-fb10-c215-9773-c11b2c9815ff
document_version_independent_id: ca093416-fb10-c215-9773-c11b2c9815ff
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HSTSPolicyBypassList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/HSTSPolicyBypassList.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 266
asset_id: microsoft-edge-policies/hstspolicybypasslist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HSTSPolicyBypassList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4e6fab7b-f7e5-e2d4-b45b-434d4763bf5b
---

# Microsoft Edge Browser Policy Documentation HSTSPolicyBypassList | Microsoft Learn

## Configure the list of names that will bypass the HSTS policy check

## Supported versions

- Windows: ≥ 79
- macOS: ≥ 79
- Android: ≥ 78
- iOS: Not supported

## Description

Setting the policy specifies a list of hostnames that bypass preloaded HSTS (HTTP Strict Transport Security) upgrades from http to https.

Only single-label hostnames are allowed in this policy, and this policy only applies to static HSTS-preloaded entries (for example, "app", "new", "search", and "play"). This policy doesn't prevent HSTS upgrades for servers that have dynamically requested HSTS upgrades using a Strict-Transport-Security response header.

Supplied hostnames must be canonicalized: Any IDNs must be converted to their A-label format, and all ASCII letters must be lowercase. This policy only applies to the specific single-label hostnames specified and not to subdomains of those names.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HSTSPolicyBypassList
- GP name: Configure the list of names that will bypass the HSTS policy check
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
meet
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\HSTSPolicyBypassList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\HSTSPolicyBypassList\1 =

```
meet
```

## Mac information and settings

- Preference Key name: HSTSPolicyBypassList
- Example value:

```xml
<array>
  <string>meet</string>
</array>
```

## Android information and settings

- Preference Key name: HSTSPolicyBypassList
- Example value:

```
["meet"]
```