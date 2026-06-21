---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProfileTypeInProfileButtonEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/profiletypeinprofilebuttonenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Controls the display of the profile button label for the work or school profile'
locale: en-us
document_id: d4099795-c1f3-e0de-3080-f1a0060dc7fd
document_version_independent_id: d4099795-c1f3-e0de-3080-f1a0060dc7fd
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProfileTypeInProfileButtonEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ProfileTypeInProfileButtonEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 208
asset_id: microsoft-edge-policies/profiletypeinprofilebuttonenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProfileTypeInProfileButtonEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: c1258588-9183-225b-e018-2e918bfa407d
---

# Microsoft Edge Browser Policy Documentation ProfileTypeInProfileButtonEnabled | Microsoft Learn

## Controls the display of the profile button label for the work or school profile

## Supported versions

- Windows: ≥ 136
- macOS: ≥ 136
- Android: Not supported
- iOS: Not supported

## Description

Controls whether the label for the work or school profile type is shown in the profile button.

This policy doesn't apply when the OrganizationalBrandingOnWorkProfileUIEnabled policy is enabled.

If you enable this policy, the label for the work or school profile type appears in the profile button.

If you disable this policy or leave it not configured, the label isn't shown.

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

- GP unique name: ProfileTypeInProfileButtonEnabled
- GP name: Controls the display of the profile button label for the work or school profile
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Profile settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ProfileTypeInProfileButtonEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ProfileTypeInProfileButtonEnabled
- Example value:

```xml
<false/>
```