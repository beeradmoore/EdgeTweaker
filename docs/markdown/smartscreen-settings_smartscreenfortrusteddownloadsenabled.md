---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SmartScreenForTrustedDownloadsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/smartscreenfortrusteddownloadsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Force Microsoft Defender SmartScreen checks on downloads from trusted sources'
locale: en-us
document_id: a2e27be1-57b6-46f6-80af-25587f7f7c04
document_version_independent_id: a2e27be1-57b6-46f6-80af-25587f7f7c04
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SmartScreenForTrustedDownloadsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/SmartScreenForTrustedDownloadsEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/smartscreenfortrusteddownloadsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SmartScreenForTrustedDownloadsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c671beaa-a830-4c9f-aceb-97379ee031ca
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8921374c-4dbe-4ed0-b011-a39e18bfbd98
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: f77ea25e-73de-2a48-831e-1f338283f1ae
---

# Microsoft Edge Browser Policy Documentation SmartScreenForTrustedDownloadsEnabled | Microsoft Learn

## Force Microsoft Defender SmartScreen checks on downloads from trusted sources

## Supported versions

- Windows: ≥ 78
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy setting lets you configure whether Microsoft Defender SmartScreen checks download reputation from a trusted source.

In Windows, the policy determines a trusted source by checking its Internet zone. If the source comes from the local system, intranet, or trusted sites zone, then the download is considered trusted and safe.

If you enable or don't configure this setting, Microsoft Defender SmartScreen checks the download's reputation regardless of source.

If you disable this setting, Microsoft Defender SmartScreen doesn't check the download's reputation when downloading from a trusted source.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10 Pro or Enterprise instances that enrolled for device management.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SmartScreenForTrustedDownloadsEnabled
- GP name: Force Microsoft Defender SmartScreen checks on downloads from trusted sources
- GP path (Mandatory): Administrative Templates/Microsoft Edge/SmartScreen settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/SmartScreen settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SmartScreenForTrustedDownloadsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```