---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MSAWebSiteSSOUsingThisProfileAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/msawebsitessousingthisprofileallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow single sign-on for Microsoft personal sites using this profile'
locale: en-us
document_id: 3fd3c22e-f175-5f76-9daf-4468c3e6102e
document_version_independent_id: 3fd3c22e-f175-5f76-9daf-4468c3e6102e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MSAWebSiteSSOUsingThisProfileAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/MSAWebSiteSSOUsingThisProfileAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 264
asset_id: microsoft-edge-policies/msawebsitessousingthisprofileallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MSAWebSiteSSOUsingThisProfileAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/f3ce9430-47e6-4404-95f5-feb4a3243b53
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/41589104-efe7-4407-ad9e-1f967185d234
platformId: e9cd3ea5-f5bf-87bd-6c55-c5e850239f03
---

# Microsoft Edge Browser Policy Documentation MSAWebSiteSSOUsingThisProfileAllowed | Microsoft Learn

## Allow single sign-on for Microsoft personal sites using this profile

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

'Allow single sign-on for Microsoft personal sites using this profile' option allows non-MSA profiles to be able to use single sign-on for Microsoft sites using MSA credentials present on the machine. This option shows up for end-users as a toggle in Settings -&gt; Profiles -&gt; Profile Preferences for non-MSA profiles only.

If you disable this policy, non-MSA profiles can't use single sign-on for Microsoft sites using MSA credentials present on the machine.

If you enable this policy or don't configure it, users can use the Settings option to ensure non-MSA profiles are able to use single sign-on for Microsoft sites using MSA credentials present on the machine provided only a single MSA account exists on the machine.

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

- GP unique name: MSAWebSiteSSOUsingThisProfileAllowed
- GP name: Allow single sign-on for Microsoft personal sites using this profile
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
- Value name: MSAWebSiteSSOUsingThisProfileAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: MSAWebSiteSSOUsingThisProfileAllowed
- Example value:

```xml
<false/>
```