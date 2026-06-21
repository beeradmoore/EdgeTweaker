---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebXRImmersiveArEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webxrimmersivearenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow creating WebXR&#x27;s &quot;immersive-ar&quot; sessions'
locale: en-us
document_id: c3971ac4-e558-f715-8389-06d8d0f8d6ff
document_version_independent_id: c3971ac4-e558-f715-8389-06d8d0f8d6ff
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebXRImmersiveArEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebXRImmersiveArEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 160
asset_id: microsoft-edge-policies/webxrimmersivearenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebXRImmersiveArEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0f6489cd-2983-57f2-b1c2-faad808bf022
---

# Microsoft Edge Browser Policy Documentation WebXRImmersiveArEnabled | Microsoft Learn

## Allow creating WebXR's "immersive-ar" sessions

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 147
- iOS: Not supported

## Description

Configures whether the sites that the user navigates to are allowed to create immersive Augmented Reality sessions using WebXR Device API.

When this policy is unset or enabled, the WebXR Device API will accept "immersive-ar" during session creation, thus allowing the users to enter Augmented Reality experiences.

When this policy is disabled, the WebXR Device API will reject requests to create sessions with mode set to "immersive-ar". The existing "immersive-ar" sessions (if any) will not be terminated.

For more details about "immersive-ar" sessions, please see WebXR Augmented Reality Module specification.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: WebXRImmersiveArEnabled
- Example value:

```
true
```