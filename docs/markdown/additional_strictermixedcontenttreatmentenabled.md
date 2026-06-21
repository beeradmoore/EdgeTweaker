---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation StricterMixedContentTreatmentEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/strictermixedcontenttreatmentenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable stricter treatment for mixed content (obsolete)'
locale: en-us
document_id: a78f0505-6d31-28e8-df98-469eddab94ff
document_version_independent_id: a78f0505-6d31-28e8-df98-469eddab94ff
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/StricterMixedContentTreatmentEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/StricterMixedContentTreatmentEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 283
asset_id: microsoft-edge-policies/strictermixedcontenttreatmentenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/StricterMixedContentTreatmentEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 22447ff7-ad89-ba6c-eb41-4d511f32c5b5
---

# Microsoft Edge Browser Policy Documentation StricterMixedContentTreatmentEnabled | Microsoft Learn

## Enable stricter treatment for mixed content (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 84.

## Supported versions

- Windows: 81-84
- macOS: 81-84
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because it was only intended to be a short-term mechanism to give enterprises more time to update their web content if it was found to be incompatible with stricter mixed content treatment.

This policy controls the treatment for mixed content (HTTP content in HTTPS sites) in the browser.

If you set this policy to true or not set, audio and video mixed content is automatically upgraded to HTTPS (that is, the URL will be rewritten as HTTPS, without a fallback if the resource isn't available over HTTPS), and a 'Not Secure' warning is shown in the URL bar for image mixed content.

If you set the policy to false, auto upgrades are disabled for audio and video, and no warning is shown for images.

This policy doesn't affect other types of mixed content other than audio, video, and images.

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

- GP unique name: StricterMixedContentTreatmentEnabled
- GP name: Enable stricter treatment for mixed content (obsolete)
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
- Value name: StricterMixedContentTreatmentEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: StricterMixedContentTreatmentEnabled
- Example value:

```xml
<true/>
```