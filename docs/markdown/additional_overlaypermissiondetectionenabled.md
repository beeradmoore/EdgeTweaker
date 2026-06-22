---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OverlayPermissionDetectionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/overlaypermissiondetectionenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Overlay Permission Detection'
locale: en-us
document_id: 07304180-b6aa-56ac-6871-7903898bd1f9
document_version_independent_id: 07304180-b6aa-56ac-6871-7903898bd1f9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OverlayPermissionDetectionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/OverlayPermissionDetectionEnabled.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 203
asset_id: microsoft-edge-policies/overlaypermissiondetectionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OverlayPermissionDetectionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e1408c26-e5bd-8474-d155-b01814a13559
---

# Microsoft Edge Browser Policy Documentation OverlayPermissionDetectionEnabled | Microsoft Learn

## Enable Overlay Permission Detection

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 119
- iOS: Not supported

## Description

This policy allows administrators to enable or disable the detection of overlay permissions in Microsoft Edge. If any app on the device has overlay drawing permissions, then Microsoft Edge displays an error message stating, "This site can't ask for your permission. Close any bubbles or overlays from other apps, then try again" when the browser requests any device permissions.

If enabled or left unset, Microsoft Edge turns on this detection feature to remind users of potential risks. If you disable this policy, Microsoft Edge turns off this detection feature.

Disabling overlay permission detection can increase the risk of malicious overlays or pop-ups gaining access to sensitive information without user consent. Therefore, it's recommended to use this policy with caution and only in trusted environments or when there's a specific need to bypass overlay detection.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: OverlayPermissionDetectionEnabled
- Example value:

```
true
```