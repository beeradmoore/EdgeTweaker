---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WhatsNewPageForEntraProfilesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/whatsnewpageforentraprofilesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control whether an informational webpage for Edge for Business is shown in the new tab after major browser updates'
locale: en-us
document_id: fb74740d-6954-2179-c141-7c24aadde86a
document_version_independent_id: fb74740d-6954-2179-c141-7c24aadde86a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WhatsNewPageForEntraProfilesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/WhatsNewPageForEntraProfilesEnabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 282
asset_id: microsoft-edge-policies/whatsnewpageforentraprofilesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WhatsNewPageForEntraProfilesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 78cd1550-ff1c-7544-d9c6-1c9307f00087
---

# Microsoft Edge Browser Policy Documentation WhatsNewPageForEntraProfilesEnabled | Microsoft Learn

## Control whether an informational webpage for Edge for Business is shown in the new tab after major browser updates

## Supported versions

- Windows: ≥ 144
- macOS: ≥ 144
- Android: Not supported
- iOS: Not supported

## Description

Starting in Microsoft Edge version 145, users with Microsoft Entra ID profiles will see an informational page about new Edge for Business features after major browser updates. This page highlights recent enhancements designed to promote secure and productive browsing.

This policy controls whether users with Microsoft Entra ID profiles see this informational page. This policy applies only to Microsoft Entra ID profiles and does not apply to Microsoft account (MSA) profiles.

This policy is available starting in Microsoft Edge version 144 to allow configuration ahead of the changes introduced in version 145.

If you enable this policy or do not configure it, Microsoft Edge shows the informational page by default. If you disable this policy, Microsoft Edge does not show the informational page to users.

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

- GP unique name: WhatsNewPageForEntraProfilesEnabled
- GP name: Control whether an informational webpage for Edge for Business is shown in the new tab after major browser updates
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
- Value name: WhatsNewPageForEntraProfilesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WhatsNewPageForEntraProfilesEnabled
- Example value:

```xml
<true/>
```