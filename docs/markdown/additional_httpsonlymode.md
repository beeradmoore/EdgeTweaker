---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HttpsOnlyMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/httpsonlymode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow HTTPS-Only Mode to be enabled'
locale: en-us
document_id: 95fc1b94-16f7-ac30-09a9-b0b65134e527
document_version_independent_id: 95fc1b94-16f7-ac30-09a9-b0b65134e527
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HttpsOnlyMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/HttpsOnlyMode.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 398
asset_id: microsoft-edge-policies/httpsonlymode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HttpsOnlyMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: bf6a9374-73ce-cf67-8b54-dcab65d093d6
---

# Microsoft Edge Browser Policy Documentation HttpsOnlyMode | Microsoft Learn

## Allow HTTPS-Only Mode to be enabled

## Supported versions

- Windows: ≥ 140
- macOS: ≥ 140
- Android: ≥ 139
- iOS: Not supported

## Description

This policy controls whether users can enable HTTPS-Only Mode (Always Use Secure Connections) in Settings. HTTPS-Only Mode attempts to upgrade all navigation to HTTPS.

If this setting isn't set or is set to Allowed, users are able to enable HTTPS-Only Mode. If this setting is set to Disallowed, HTTPS-Only Mode will be disabled. If this setting is set to Force Enabled, HTTPS-Only Mode is enabled in Strict mode. If this setting is set to Force Balance Enabled, HTTPS-Only Mode is enabled in Balanced mode.

The settings Force Enabled and Force Enabled can be recommended to users. HTTPS-Only Mode will be set to Strict or Balanced initially, but users are allowed to change it.

If you set this policy to a value that isn't supported by the version of Microsoft Edge that receives the policy, Microsoft Edge defaults to the Allowed setting.

The separate HttpAllowlist policy can be used to exempt specific hostnames or hostname patterns from being upgraded to HTTPS by this feature.

Policy options mapping:

- allowed (allowed) = Don't restrict users' HTTPS-Only Mode setting
- disallowed (disallowed) = Disable HTTPS-Only Mode
- force\_enabled (force\_enabled) = Force enable HTTPS-Only Mode in Strict mode
- force\_balanced\_enabled (force\_balanced\_enabled) = Force enable HTTPS-Only Mode in Balanced Mode

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- allowed = Don't restrict users' HTTPS-Only Mode setting
- disallowed = Disable HTTPS-Only Mode
- force\_enabled = Force enable HTTPS-Only Mode in Strict mode
- force\_balanced\_enabled = Force enable HTTPS-Only Mode in Balanced Mode

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: HttpsOnlyMode
- GP name: Allow HTTPS-Only Mode to be enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disable HTTPS-Only Mode
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: HttpsOnlyMode
- Value type: REG\_SZ

#### Example registry value

```
disallowed
```

## Mac information and settings

- Preference Key name: HttpsOnlyMode
- Example value:

```xml
<string>disallowed</string>
```

## Android information and settings

- Preference Key name: HttpsOnlyMode
- Example value:

```
disallowed
```