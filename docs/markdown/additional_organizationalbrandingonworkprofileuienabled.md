---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OrganizationalBrandingOnWorkProfileUIEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/organizationalbrandingonworkprofileuienabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow the use of your organization&#x27;s branding assets from Microsoft Entra on the profile-related UI of a work or school profile'
locale: en-us
document_id: e70b095b-0293-d022-851e-272c3edd745a
document_version_independent_id: e70b095b-0293-d022-851e-272c3edd745a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OrganizationalBrandingOnWorkProfileUIEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/OrganizationalBrandingOnWorkProfileUIEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/organizationalbrandingonworkprofileuienabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OrganizationalBrandingOnWorkProfileUIEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/57eae307-c3a1-4cac-b645-1a899934bac8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/ee561821-1ac7-45a8-9409-6ba5eb7a5b97
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6b717d46-6b27-fb8a-494f-deb2ac673e7f
---

# Microsoft Edge Browser Policy Documentation OrganizationalBrandingOnWorkProfileUIEnabled | Microsoft Learn

## Allow the use of your organization's branding assets from Microsoft Entra on the profile-related UI of a work or school profile

## Supported versions

- Windows: ≥ 119
- macOS: ≥ 119
- Android: Not supported
- iOS: Not supported

## Description

Allow the use of your organization's branding assets from Entra, if any, on the profile-related UI of a profile that's signed in with an Entra ID (formerly known as Azure Active Directory) account. This requires a browser restart to take effect.

If you enable this policy, your organization's branding assets from Entra are used.

If you disable or don't configure this policy, your organization's branding assets from Entra aren't used.

For more information about configuring your organization's branding assets on Entra, visit https://go.microsoft.com/fwlink/?linkid=2254514.

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: OrganizationalBrandingOnWorkProfileUIEnabled
- GP name: Allow the use of your organization's branding assets from Microsoft Entra on the profile-related UI of a work or school profile
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: OrganizationalBrandingOnWorkProfileUIEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: OrganizationalBrandingOnWorkProfileUIEnabled
- Example value:

```xml
<true/>
```