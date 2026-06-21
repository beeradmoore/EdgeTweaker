---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OrganizationLogoOverlayOnAppIconEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/organizationlogooverlayonappiconenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow your organization&#x27;s logo from Microsoft Entra to be overlaid on the Microsoft Edge app icon of a work or school profile'
locale: en-us
document_id: 8ae21d93-adbf-a012-fe93-f3411e807741
document_version_independent_id: 8ae21d93-adbf-a012-fe93-f3411e807741
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OrganizationLogoOverlayOnAppIconEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/OrganizationLogoOverlayOnAppIconEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 251
asset_id: microsoft-edge-policies/organizationlogooverlayonappiconenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OrganizationLogoOverlayOnAppIconEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/57eae307-c3a1-4cac-b645-1a899934bac8
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/ee561821-1ac7-45a8-9409-6ba5eb7a5b97
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2ff02438-6487-e5c0-8ca5-c8b720c078e9
---

# Microsoft Edge Browser Policy Documentation OrganizationLogoOverlayOnAppIconEnabled | Microsoft Learn

## Allow your organization's logo from Microsoft Entra to be overlaid on the Microsoft Edge app icon of a work or school profile

## Supported versions

- Windows: ≥ 120
- macOS: ≥ 120
- Android: Not supported
- iOS: Not supported

## Description

Allows your organization's logo from Entra, if any, to be overlaid on the Microsoft Edge app icon of a profile that's signed in with an Entra ID (formerly known as Azure Active Directory) account. This requires a browser restart to take effect.

If you enable this policy, your organization's logo from Entra is used.

If you disable or don't configure this policy, your organization's logo from Entra won't be used.

For more information about configuring your organization's logo on Entra, visit https://go.microsoft.com/fwlink/?linkid=2254514.

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

- GP unique name: OrganizationLogoOverlayOnAppIconEnabled
- GP name: Allow your organization's logo from Microsoft Entra to be overlaid on the Microsoft Edge app icon of a work or school profile
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
- Value name: OrganizationLogoOverlayOnAppIconEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: OrganizationLogoOverlayOnAppIconEnabled
- Example value:

```xml
<true/>
```