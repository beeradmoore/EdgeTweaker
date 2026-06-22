---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProactiveAuthEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/proactiveauthenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Proactive Authentication (obsolete)'
locale: en-us
document_id: 54c51c72-e2c6-8869-7e5c-8ac47cca062d
document_version_independent_id: 54c51c72-e2c6-8869-7e5c-8ac47cca062d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProactiveAuthEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/ProactiveAuthEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 259
asset_id: microsoft-edge-policies/proactiveauthenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProactiveAuthEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0f28521f-4806-3dad-4d7b-0eb62763b341
---

# Microsoft Edge Browser Policy Documentation ProactiveAuthEnabled | Microsoft Learn

## Enable Proactive Authentication (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 90.

## Supported versions

- Windows: 77-90
- macOS: 77-90
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because it doesn't work independently of browser sign in. It doesn't work in Microsoft Edge after version 90. If you want to configure browser sign in, use the [BrowserSignin](browsersignin) policy.

Lets you configure whether to turn on Proactive Authentication in Microsoft Edge.

If you enable this policy, Microsoft Edge tries to seamlessly authenticate to websites and services using the account which is signed-in to the browser.

If you disable this policy, Microsoft Edge doesn't try to authenticate with websites or services using single sign-on (SSO). Authenticated experiences like the Enterprise New Tab Page won't work (for example, recent and recommended Office documents will not be available).

If you don't configure this policy, Proactive Authentication is turned on.

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

- GP unique name: ProactiveAuthEnabled
- GP name: Enable Proactive Authentication (obsolete)
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
- Value name: ProactiveAuthEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ProactiveAuthEnabled
- Example value:

```xml
<true/>
```