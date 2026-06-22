---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation KioskDeleteDownloadsOnExit | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/kioskdeletedownloadsonexit
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Delete files downloaded as part of kiosk session when Microsoft Edge closes'
locale: en-us
document_id: f997da72-39fc-9909-1f49-293d89106ef8
document_version_independent_id: f997da72-39fc-9909-1f49-293d89106ef8
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/KioskDeleteDownloadsOnExit.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/KioskDeleteDownloadsOnExit.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 195
asset_id: microsoft-edge-policies/kioskdeletedownloadsonexit
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/KioskDeleteDownloadsOnExit.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: dee6b51d-c1ec-99e6-a7fc-10e6b5b2263c
---

# Microsoft Edge Browser Policy Documentation KioskDeleteDownloadsOnExit | Microsoft Learn

## Delete files downloaded as part of kiosk session when Microsoft Edge closes

## Supported versions

- Windows: ≥ 87
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy only applies to Microsoft Edge kiosk mode.

If you enable this policy, files downloaded as part of the kiosk session are deleted each time Microsoft Edge closes.

If you disable this policy or don't configure it, files downloaded as part of the kiosk session aren't deleted when Microsoft Edge closes.

For detailed information on configuring kiosk Mode, see https://go.microsoft.com/fwlink/?linkid=2137578.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: KioskDeleteDownloadsOnExit
- GP name: Delete files downloaded as part of kiosk session when Microsoft Edge closes
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Kiosk Mode settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: KioskDeleteDownloadsOnExit
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```