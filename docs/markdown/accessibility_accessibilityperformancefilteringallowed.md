---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AccessibilityPerformanceFilteringAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/accessibilityperformancefilteringallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Accessibility Performance Filtering.'
locale: en-us
document_id: eefe5f24-3004-56d0-f8c6-8f1eb51617d1
document_version_independent_id: eefe5f24-3004-56d0-f8c6-8f1eb51617d1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AccessibilityPerformanceFilteringAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/AccessibilityPerformanceFilteringAllowed.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 155
asset_id: microsoft-edge-policies/accessibilityperformancefilteringallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AccessibilityPerformanceFilteringAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 41ea55d2-6d75-0528-c0cb-a61bf9c5bff4
---

# Microsoft Edge Browser Policy Documentation AccessibilityPerformanceFilteringAllowed | Microsoft Learn

## Allow Accessibility Performance Filtering.

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 138
- iOS: Not supported

## Description

A policy to control whether the accessibility engine is allowed to dynamically compute a filter for the accessibility tree in Microsoft Edge to improve performance. When the policy is either set to Enabled or not set, the accessibility engine is allowed to dynamically compute filter modes for the accessibility tree in Microsoft Edge, which may lead to a performance improvement. When the policy is set to Disabled, the accessibility engine is not allowed to dynamically compute filter modes for the accessibility tree.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Android information and settings

- Preference Key name: AccessibilityPerformanceFilteringAllowed
- Example value:

```
false
```