---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewSmartScreenLibraryEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newsmartscreenlibraryenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable new SmartScreen library (obsolete)'
locale: en-us
document_id: c7104960-55fe-0321-1665-ba0ce5d3df46
document_version_independent_id: c7104960-55fe-0321-1665-ba0ce5d3df46
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewSmartScreenLibraryEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/NewSmartScreenLibraryEnabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 290
asset_id: microsoft-edge-policies/newsmartscreenlibraryenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewSmartScreenLibraryEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d7f78ef2-9f93-87c2-6829-e168d80cd982
---

# Microsoft Edge Browser Policy Documentation NewSmartScreenLibraryEnabled | Microsoft Learn

## Enable new SmartScreen library (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 107.

## Supported versions

- Windows: 95-107
- macOS: 95-107
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because it was only intended to be a short-term mechanism to support the update to a new SmartScreen client.

Allows the Microsoft Edge browser to load the new SmartScreen library (libSmartScreenN) for any SmartScreen checks on site URLs or application downloads.

If you enable or don't configure this policy, Microsoft Edge uses the new SmartScreen library (libSmartScreenN).

If you disable this policy, Microsoft Edge uses the old SmartScreen library (libSmartScreen).

Before Microsoft Edge version 103, if you don't configure this policy, Microsoft Edge uses the old SmartScreen library (libSmartScreen).

This policy is only available on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10 Pro or Enterprise instances that enrolled for device management. This also includes macOS instances that are that are managed via MDM or joined to a domain via MCX.

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

- GP unique name: NewSmartScreenLibraryEnabled
- GP name: Enable new SmartScreen library (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/SmartScreen settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/SmartScreen settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: NewSmartScreenLibraryEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: NewSmartScreenLibraryEnabled
- Example value:

```xml
<true/>
```