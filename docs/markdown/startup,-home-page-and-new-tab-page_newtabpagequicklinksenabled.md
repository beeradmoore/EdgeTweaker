---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageQuickLinksEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagequicklinksenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow quick links on the new tab page'
locale: en-us
document_id: 1f1c4453-8f68-d4b8-aa7a-d68b0bcc9af8
document_version_independent_id: 1f1c4453-8f68-d4b8-aa7a-d68b0bcc9af8
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageQuickLinksEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NewTabPageQuickLinksEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 265
asset_id: microsoft-edge-policies/newtabpagequicklinksenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageQuickLinksEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 722df8d8-6f60-20ec-a83e-733984179803
---

# Microsoft Edge Browser Policy Documentation NewTabPageQuickLinksEnabled | Microsoft Learn

## Allow quick links on the new tab page

## Supported versions

- Windows: ≥ 91
- macOS: ≥ 91
- Android: Not supported
- iOS: Not supported

## Description

If you enable or don't configure this policy, Microsoft Edge displays quick links on the new tab page, and the user can interact with the control, turning quick links on and off. Enabling this policy doesn't force quick links to be visible - the user can continue to turn quick links on and off.

If you disable this policy, Microsoft Edge hides quick links on the new tab page and disables the quick links control in the NTP settings flyout.

This policy only applies for Microsoft Edge local user profiles, profiles signed in using a Microsoft Account, and profiles signed in using Active Directory. To configure the Enterprise new tab page for profiles signed in using Azure Active Directory, use the M365 admin portal.

Related policies: [NewTabPageAllowedBackgroundTypes](newtabpageallowedbackgroundtypes), [NewTabPageContentEnabled](newtabpagecontentenabled)

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

- GP unique name: NewTabPageQuickLinksEnabled
- GP name: Allow quick links on the new tab page
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NewTabPageQuickLinksEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: NewTabPageQuickLinksEnabled
- Example value:

```xml
<true/>
```