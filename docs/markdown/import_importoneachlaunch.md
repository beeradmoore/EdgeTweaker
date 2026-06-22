---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ImportOnEachLaunch | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/importoneachlaunch
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow import of data from other browsers on each Microsoft Edge launch'
locale: en-us
document_id: 918063b4-0dc0-80ad-abdb-c4f320de808b
document_version_independent_id: 918063b4-0dc0-80ad-abdb-c4f320de808b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ImportOnEachLaunch.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ImportOnEachLaunch.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 229
asset_id: microsoft-edge-policies/importoneachlaunch
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ImportOnEachLaunch.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 86825dad-f901-bb22-7689-97387018840f
---

# Microsoft Edge Browser Policy Documentation ImportOnEachLaunch | Microsoft Learn

## Allow import of data from other browsers on each Microsoft Edge launch

## Supported versions

- Windows: ≥ 104
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, users will see a prompt to import their browsing data from other browsers on each Microsoft Edge launch.

If you disable this policy, users will never see a prompt to import their browsing data from other browsers on each Microsoft Edge launch.

If the policy is left unconfigured, users can activate this feature from a Microsoft Edge prompt or from the Settings page.

Note: A similar policy named [AutoImportAtFirstRun](autoimportatfirstrun) exists. This policy should be used if you want to import supported data from other browsers only once while setting up your device.

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

- GP unique name: ImportOnEachLaunch
- GP name: Allow import of data from other browsers on each Microsoft Edge launch
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
- Value name: ImportOnEachLaunch
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```