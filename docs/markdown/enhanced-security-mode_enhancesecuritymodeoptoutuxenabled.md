---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnhanceSecurityModeOptOutUXEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enhancesecuritymodeoptoutuxenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Manage opt-out user experience for Enhanced Security Mode (ESM) in Microsoft Edge (obsolete)'
locale: en-us
document_id: c0ca3cca-c674-ccb2-9463-61f1a074646b
document_version_independent_id: c0ca3cca-c674-ccb2-9463-61f1a074646b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeOptOutUXEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeOptOutUXEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 259
asset_id: microsoft-edge-policies/enhancesecuritymodeoptoutuxenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeOptOutUXEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: cddf3131-49bf-053e-341e-640a46f14ddd
---

# Microsoft Edge Browser Policy Documentation EnhanceSecurityModeOptOutUXEnabled | Microsoft Learn

## Manage opt-out user experience for Enhanced Security Mode (ESM) in Microsoft Edge (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 135.

## Supported versions

- Windows: 115-135
- macOS: 115-135
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because we determined that this experimental opt-out UX isn't required.

This policy lets you manage whether the opt-out user experience for enhanced security mode is presented when ESM is turned on for Microsoft Edge.

If you enable or don't configure this policy, the UI for the opt-out user experience is on.

If you disable this policy, the UI for the opt-out user experience is off.

Note: If this policy is used, only the User Interface for the opt-out experience is supressed - ESM is still turned on. For more information, see the [EnhanceSecurityMode](enhancesecuritymode) policy.

For detailed information about Enhanced Security Mode, see https://go.microsoft.com/fwlink/?linkid=2185895.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnhanceSecurityModeOptOutUXEnabled
- GP name: Manage opt-out user experience for Enhanced Security Mode (ESM) in Microsoft Edge (obsolete)
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
- Value name: EnhanceSecurityModeOptOutUXEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EnhanceSecurityModeOptOutUXEnabled
- Example value:

```xml
<true/>
```