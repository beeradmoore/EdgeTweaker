---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LiveVideoTranslationEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/livevideotranslationenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allows users to translate videos to different languages.'
locale: en-us
document_id: 1bf5d492-c611-79d2-2f46-781598f3152b
document_version_independent_id: 1bf5d492-c611-79d2-2f46-781598f3152b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LiveVideoTranslationEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/LiveVideoTranslationEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 279
asset_id: microsoft-edge-policies/livevideotranslationenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LiveVideoTranslationEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 74e1a3ef-444c-7c63-c19b-1447e761e613
---

# Microsoft Edge Browser Policy Documentation LiveVideoTranslationEnabled | Microsoft Learn

## Allows users to translate videos to different languages.

## Supported versions

- Windows: ≥ 141
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy configures the on-device real-time video translation feature in Microsoft Edge. With this feature, users can watch videos translated into their selected language in real time.

When a user selects the Translate icon and chooses a source (video language) and target language (translated language), translation components are downloaded on first use (approximately 200 MB per language pair).

These components can be updated periodically to improve performance and translation quality. Translation is performed locally on the user’s device and no data is sent outside of the device. The feature is available only for non-DRM videos, on supported high-end devices, with select language pairs, and in select regions. For more information, see https://www.microsoft.com/en-us/edge/features/real-time-video-translation.

If you enable or don’t configure this policy, the on-device real-time video translation feature is enabled and users will see the Translate button when hovering over videos.

If you disable this policy, the on-device real-time video translation feature is disabled and the Translate button is not shown.

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

- GP unique name: LiveVideoTranslationEnabled
- GP name: Allows users to translate videos to different languages.
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
- Value name: LiveVideoTranslationEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```