---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeLockedViewModeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgelockedviewmodeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure locked view mode on iOS and Android'
locale: en-us
document_id: 405355aa-2f70-4b58-f29a-d1716f010ef1
document_version_independent_id: 405355aa-2f70-4b58-f29a-d1716f010ef1
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeLockedViewModeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeLockedViewModeEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 209
asset_id: microsoft-edge-policies/edgelockedviewmodeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeLockedViewModeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a5efe2ae-f339-694f-11f2-362025196876
---

# Microsoft Edge Browser Policy Documentation EdgeLockedViewModeEnabled | Microsoft Learn

## Configure locked view mode on iOS and Android

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 143
- iOS: ≥ 143

## Description

This policy lets you enable locked view mode in Microsoft Edge on iOS and Android devices. Locked view mode provides a controlled and focused browsing experience for scenarios such as kiosks or restricted workflows.

If you enable this policy:

- The URL address bar becomes read-only, preventing users from changing the web address.
- Users can’t create new tabs.
- Contextual search on web pages is disabled.
- The following buttons in the overflow menu are disabled:
- New InPrivate tab
- Send to Devices
- Drop
- Add to Phone (Android)
- Download Page (Android) If you disable or don’t configure this policy:
- The browser functions normally, allowing users to switch views, open or close tabs, and access all standard features. NOTE This policy only takes effect if the EdgeLockedViewModeAllowedActions policy is enabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Android information and settings

- Preference Key name: EdgeLockedViewModeEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: EdgeLockedViewModeEnabled
- Example value:

```xml
<true/>
```