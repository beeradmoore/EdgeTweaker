---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AccessibilityImageLabelsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/accessibilityimagelabelsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Let screen reader users get image descriptions from Microsoft'
locale: en-us
document_id: 73a3e515-3dc5-b689-375d-05b4e338b033
document_version_independent_id: 73a3e515-3dc5-b689-375d-05b4e338b033
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AccessibilityImageLabelsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AccessibilityImageLabelsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 239
asset_id: microsoft-edge-policies/accessibilityimagelabelsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AccessibilityImageLabelsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: cfd1195f-b342-c9f2-f60a-5ff00e99b8b6
---

# Microsoft Edge Browser Policy Documentation AccessibilityImageLabelsEnabled | Microsoft Learn

## Let screen reader users get image descriptions from Microsoft

## Supported versions

- Windows: ≥ 97
- macOS: ≥ 97
- Android: Not supported
- iOS: Not supported

## Description

Lets screen reader users get descriptions of unlabeled images on the web.

If you enable or don't configure this policy, users have the option of using an anonymous Microsoft service. This service provides automatic descriptions for unlabeled images users encounter on the web when they're using a screen reader.

If you disable this policy, users can't enable the Get Image Descriptions from Microsoft feature.

When this feature is enabled, the content of images that need a generated description is sent to Microsoft servers to generate a description.

No cookies or other user data is sent to Microsoft, and Microsoft doesn't save or log any image content.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AccessibilityImageLabelsEnabled
- GP name: Let screen reader users get image descriptions from Microsoft
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AccessibilityImageLabelsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: AccessibilityImageLabelsEnabled
- Example value:

```xml
<false/>
```