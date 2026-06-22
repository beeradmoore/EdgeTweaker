---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeAutofillMlEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeautofillmlenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Machine learning powered autofill suggestions'
locale: en-us
document_id: 1a7f7c0e-6c1e-095e-01ad-c65949c072f6
document_version_independent_id: 1a7f7c0e-6c1e-095e-01ad-c65949c072f6
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeAutofillMlEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/EdgeAutofillMlEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 254
asset_id: microsoft-edge-policies/edgeautofillmlenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeAutofillMlEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/d6f38669-3d05-40f2-afd8-e49f7dd20884
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/55265cca-de9b-48dc-a77a-9047cc39a575
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: aacaa06c-c396-443a-2743-11cbe2aaeb4d
---

# Microsoft Edge Browser Policy Documentation EdgeAutofillMlEnabled | Microsoft Learn

## Machine learning powered autofill suggestions

## Supported versions

- Windows: ≥ 132
- macOS: ≥ 132
- Android: Not supported
- iOS: ≥ 135

## Description

Allows ML technology to predict and fill in forms and text fields for better browsing. Your personal data is secure and isn't used elsewhere.

If you enable this policy or don't configure it, users can benefit from machine learning powered autofill suggestions, which improve efficiency by offering more accurate, context aware form recommendations based on historical autofill data.

If you disable this policy, machine learning-powered autofill suggestions aren't shown, and autofill no longer uses cloud-based machine learning models to enhance form filling with smarter, context aware suggestions. Instead, autofill will rely on basic form data without the benefits of machine learning.

This policy will be disabled if you disable [AutofillAddressEnabled](autofilladdressenabled).

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EdgeAutofillMlEnabled
- GP name: Machine learning powered autofill suggestions
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
- Value name: EdgeAutofillMlEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: EdgeAutofillMlEnabled
- Example value:

```xml
<false/>
```

## iOS information and settings

- Preference Key name: EdgeAutofillMlEnabled
- Example value:

```xml
<false/>
```