---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WindowsHelloForHTTPAuthEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/windowshelloforhttpauthenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Windows Hello For HTTP Auth Enabled'
locale: en-us
document_id: 812e404f-1ae1-55a0-f4c3-86f8c5269789
document_version_independent_id: 812e404f-1ae1-55a0-f4c3-86f8c5269789
updated_at: 2026-05-22T21:23:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WindowsHelloForHTTPAuthEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c5fdc1b372ed33d781627b537c4f1e90a8b4d2d6/edgeenterprise/microsoft-edge-policies/WindowsHelloForHTTPAuthEnabled.md
git_commit_id: c5fdc1b372ed33d781627b537c4f1e90a8b4d2d6
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 175
asset_id: microsoft-edge-policies/windowshelloforhttpauthenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WindowsHelloForHTTPAuthEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/5717abce-88c6-42bd-821b-0d6370225d52
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/b472b5d5-52dd-4477-99f9-23fa324788f7
platformId: aa6dff2a-d217-fa0f-1b4b-2683a7a5ee44
---

# Microsoft Edge Browser Policy Documentation WindowsHelloForHTTPAuthEnabled | Microsoft Learn

## Windows Hello For HTTP Auth Enabled

## Supported versions

- Windows: ≥ 90
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls which credential prompt should be used to respond to NTLM and Negotiate authentication challenges.

If you disable this policy, Edge will display its built-in username and password prompt.

If you enable or don’t configure this policy, the Windows credential prompt is used.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WindowsHelloForHTTPAuthEnabled
- GP name: Windows Hello For HTTP Auth Enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge/HTTP authentication
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/HTTP authentication
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: WindowsHelloForHTTPAuthEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```