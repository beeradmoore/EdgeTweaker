---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation StrictMimetypeCheckForWorkerScriptsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/strictmimetypecheckforworkerscriptsenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-21T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable strict MIME type checking for worker scripts'
locale: en-us
document_id: 322f161a-af91-1516-b366-08ba6a99c2cf
document_version_independent_id: 322f161a-af91-1516-b366-08ba6a99c2cf
updated_at: 2026-07-23T17:24:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/StrictMimetypeCheckForWorkerScriptsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/68812a75863f3e9c8e7f9a3c986f810f4a267a84/edgeenterprise/microsoft-edge-policies/StrictMimetypeCheckForWorkerScriptsEnabled.md
git_commit_id: 68812a75863f3e9c8e7f9a3c986f810f4a267a84
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 279
asset_id: microsoft-edge-policies/strictmimetypecheckforworkerscriptsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/StrictMimetypeCheckForWorkerScriptsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ce12b89b-5a93-0f23-1063-252040f50a61
---

# Microsoft Edge Browser Policy Documentation StrictMimetypeCheckForWorkerScriptsEnabled | Microsoft Learn

## Enable strict MIME type checking for worker scripts

## Supported versions

- Windows: ≥ 150
- macOS: ≥ 150
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether strict MIME type checking is used for worker scripts.

If you enable or don't configure this policy, worker scripts use strict MIME type checking for JavaScript. Worker scripts that use legacy MIME types are rejected.

If you disable this policy, worker scripts use lax MIME type checking. This allows worker scripts that use legacy MIME types, such as text/ascii, to continue to load and run.

Browsers traditionally used lax MIME type checking, which allowed JavaScript resources to load with several legacy MIME types. This behavior can create security risks by allowing resources to load as scripts when they weren't intended to be used that way.

Microsoft Edge uses strict MIME type checking by default. Enabling this policy follows the default behavior. Disabling this policy lets admins temporarily retain the legacy behavior for compatibility.

For more information about JavaScript and ECMAScript media types, see https://html.spec.whatwg.org/multipage/scripting.html#scriptingLanguage.

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

- GP unique name: StrictMimetypeCheckForWorkerScriptsEnabled
- GP name: Enable strict MIME type checking for worker scripts
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
- Value name: StrictMimetypeCheckForWorkerScriptsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: StrictMimetypeCheckForWorkerScriptsEnabled
- Example value:

```xml
<false/>
```