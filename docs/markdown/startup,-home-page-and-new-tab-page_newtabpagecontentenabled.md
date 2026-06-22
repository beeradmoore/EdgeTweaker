---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NewTabPageContentEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/newtabpagecontentenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Microsoft content on the new tab page'
locale: en-us
document_id: b8f60707-e69d-4d19-872e-103c3ef7438d
document_version_independent_id: b8f60707-e69d-4d19-872e-103c3ef7438d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NewTabPageContentEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/NewTabPageContentEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 326
asset_id: microsoft-edge-policies/newtabpagecontentenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NewTabPageContentEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0f622f95-61a1-2930-39ce-47e0d0b1975c
---

# Microsoft Edge Browser Policy Documentation NewTabPageContentEnabled | Microsoft Learn

## Allow Microsoft content on the new tab page

## Supported versions

- Windows: ≥ 91
- macOS: ≥ 91
- Android: Not supported
- iOS: Not supported

## Description

This policy applies for Microsoft Edge to all profile types, namely unsigned local user profiles, profiles signed in using a Microsoft Account, profiles signed in using Active Directory, and profiles signed in using Microsoft Entra ID. The Enterprise new tab page for profiles signed in using Microsoft Entra ID can be configured in the Microsoft 365 admin portal, but this policy setting takes precedence; therefore, any Microsoft 365 admin portal configurations are ignored.

If you enable or don't configure this policy, Microsoft Edge displays Microsoft content on the new tab page. The user can choose different display options for the content. These options include, but aren't limited to: "Content off", "Content visible on scroll", "Headings only", and "Content visible". Enabling this policy doesn't force content to be visible - the users can keep setting their own preferred content position.

If you disable this policy, Microsoft Edge doesn't display Microsoft content on the new tab page. The Content control in the NTP settings flyout is disabled and set to "Content off", and the Layout control in the NTP settings flyout is disabled and set to "Custom".

Related policies: [NewTabPageAllowedBackgroundTypes](newtabpageallowedbackgroundtypes), [NewTabPageQuickLinksEnabled](newtabpagequicklinksenabled)

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

- GP unique name: NewTabPageContentEnabled
- GP name: Allow Microsoft content on the new tab page
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: NewTabPageContentEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: NewTabPageContentEnabled
- Example value:

```xml
<false/>
```