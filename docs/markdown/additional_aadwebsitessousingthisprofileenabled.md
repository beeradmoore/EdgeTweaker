---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AADWebSiteSSOUsingThisProfileEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/aadwebsitessousingthisprofileenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Single sign-on for work or school sites using this profile enabled'
locale: en-us
document_id: 6f8c7266-cde7-bfa9-529c-1f73a2902a98
document_version_independent_id: 6f8c7266-cde7-bfa9-529c-1f73a2902a98
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AADWebSiteSSOUsingThisProfileEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/AADWebSiteSSOUsingThisProfileEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 263
asset_id: microsoft-edge-policies/aadwebsitessousingthisprofileenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AADWebSiteSSOUsingThisProfileEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4e47a795-da61-d9d7-da7c-eb983a025e58
---

# Microsoft Edge Browser Policy Documentation AADWebSiteSSOUsingThisProfileEnabled | Microsoft Learn

## Single sign-on for work or school sites using this profile enabled

## Supported versions

- Windows: ≥ 92
- macOS: ≥ 92
- Android: Not supported
- iOS: Not supported

## Description

'Allow single sign-on for work or school sites using this profile' option allows non-AAD profiles to be able to use single sign-on for work or school sites using work or school credentials present on the machine. This option shows up for end-users as a toggle in Settings -&gt; Profiles -&gt; Profile Preferences for non-AAD profiles only.

If you enable or disable this policy, 'Intelligent enablement of Single sign-on (SSO) for all Windows Azure Active Directory (Azure AD) accounts for users with a single non-Azure AD Microsoft Edge profile' will be turned off.

If you don't configure this policy, users can control whether to use SSO using other credentials present on the machine in edge://settings/profiles/multiProfileSettings.

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

- GP unique name: AADWebSiteSSOUsingThisProfileEnabled
- GP name: Single sign-on for work or school sites using this profile enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AADWebSiteSSOUsingThisProfileEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: AADWebSiteSSOUsingThisProfileEnabled
- Example value:

```xml
<false/>
```