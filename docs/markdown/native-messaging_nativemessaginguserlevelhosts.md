---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NativeMessagingUserLevelHosts | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nativemessaginguserlevelhosts
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow user-level native messaging hosts (installed without admin permissions)'
locale: en-us
document_id: bb9d8bed-ccfe-11d3-cf2e-774a07ef63ac
document_version_independent_id: bb9d8bed-ccfe-11d3-cf2e-774a07ef63ac
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NativeMessagingUserLevelHosts.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/NativeMessagingUserLevelHosts.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 178
asset_id: microsoft-edge-policies/nativemessaginguserlevelhosts
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NativeMessagingUserLevelHosts.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c206997c-1205-05f7-294d-25730597b367
---

# Microsoft Edge Browser Policy Documentation NativeMessagingUserLevelHosts | Microsoft Learn

## Allow user-level native messaging hosts (installed without admin permissions)

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

If you set this policy to Enabled or leave it unset, Microsoft Edge can use native messaging hosts installed at the user level.

If you set this policy to Disabled, Microsoft Edge can only use these hosts if they're installed at the system level.

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

- GP unique name: NativeMessagingUserLevelHosts
- GP name: Allow user-level native messaging hosts (installed without admin permissions)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Native Messaging
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NativeMessagingUserLevelHosts
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: NativeMessagingUserLevelHosts
- Example value:

```xml
<false/>
```