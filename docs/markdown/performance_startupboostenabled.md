---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation StartupBoostEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/startupboostenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable startup boost'
locale: en-us
document_id: c53c9864-34d1-6207-aa4b-28c43a77beb1
document_version_independent_id: c53c9864-34d1-6207-aa4b-28c43a77beb1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/StartupBoostEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/StartupBoostEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 233
asset_id: microsoft-edge-policies/startupboostenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/StartupBoostEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5fabf110-54b8-fa53-1cad-bd5d824e504c
---

# Microsoft Edge Browser Policy Documentation StartupBoostEnabled | Microsoft Learn

## Enable startup boost

## Supported versions

- Windows: ≥ 88
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Allows Microsoft Edge processes to start at OS sign-in and restart in background after the last browser window is closed.

If Microsoft Edge is running in background mode, the browser might not close when the last window is closed and the browser won't be restarted in background when the window closes. See the [BackgroundModeEnabled](backgroundmodeenabled) policy for information about what happens after configuring Microsoft Edge background mode behavior.

If you enable this policy, startup boost is turned on.

If you disable this policy, startup boost is turned off.

If you don't configure this policy, startup boost may initially be off or on. The user can configure its behavior in edge://settings/system.

Learn more about startup boost: https://go.microsoft.com/fwlink/?linkid=2147018

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: StartupBoostEnabled
- GP name: Enable startup boost
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Performance
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Performance
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: StartupBoostEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```