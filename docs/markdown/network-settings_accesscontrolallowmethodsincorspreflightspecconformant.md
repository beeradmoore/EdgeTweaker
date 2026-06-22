---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AccessControlAllowMethodsInCORSPreflightSpecConformant | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/accesscontrolallowmethodsincorspreflightspecconformant
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Make Access-Control-Allow-Methods matching in CORS preflight spec conformant'
locale: en-us
document_id: 4745fb5b-7aa7-d2c8-1da0-0e04369f7266
document_version_independent_id: 4745fb5b-7aa7-d2c8-1da0-0e04369f7266
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AccessControlAllowMethodsInCORSPreflightSpecConformant.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/AccessControlAllowMethodsInCORSPreflightSpecConformant.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 254
asset_id: microsoft-edge-policies/accesscontrolallowmethodsincorspreflightspecconformant
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AccessControlAllowMethodsInCORSPreflightSpecConformant.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1e335067-2e7b-fb54-b084-97c1cb9b1ba1
---

# Microsoft Edge Browser Policy Documentation AccessControlAllowMethodsInCORSPreflightSpecConformant | Microsoft Learn

## Make Access-Control-Allow-Methods matching in CORS preflight spec conformant

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: ≥ 140
- iOS: Not supported

## Description

This policy controls whether request methods are uppercased when matching with Access-Control-Allow-Methods response headers in CORS preflight.

If you disable this policy, request methods are uppercased. This is the behavior on or before Microsoft Edge 108.

If you enable or don't configure this policy, request methods aren't uppercased, unless matching case-insensitively with DELETE, GET, HEAD, OPTIONS, POST, or PUT.

This would reject fetch(url, {method: 'Foo'}) + "Access-Control-Allow-Methods: FOO" response header, and would accept fetch(url, {method: 'Foo'}) + "Access-Control-Allow-Methods: Foo" response header.

Note: request methods "post" and "put" aren't affected, while "patch" is affected.

This policy is intended to be temporary and will be removed in the future.

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

- GP unique name: AccessControlAllowMethodsInCORSPreflightSpecConformant
- GP name: Make Access-Control-Allow-Methods matching in CORS preflight spec conformant
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AccessControlAllowMethodsInCORSPreflightSpecConformant
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AccessControlAllowMethodsInCORSPreflightSpecConformant
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AccessControlAllowMethodsInCORSPreflightSpecConformant
- Example value:

```
true
```