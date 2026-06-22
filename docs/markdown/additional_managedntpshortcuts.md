---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ManagedNtpShortcuts | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/managedntpshortcuts
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure managed shortcuts on the New Tab Page'
locale: en-us
document_id: 2f6c84d7-96f9-1f90-b899-b2d2be7cb78f
document_version_independent_id: 2f6c84d7-96f9-1f90-b899-b2d2be7cb78f
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ManagedNtpShortcuts.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/ManagedNtpShortcuts.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 279
asset_id: microsoft-edge-policies/managedntpshortcuts
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ManagedNtpShortcuts.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d36ac2e4-8b91-d923-bebf-159690027803
---

# Microsoft Edge Browser Policy Documentation ManagedNtpShortcuts | Microsoft Learn

## Configure managed shortcuts on the New Tab Page

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 145
- iOS: ≥ 145

## Description

This policy controls which shortcut items are managed and displayed on the Microsoft Edge New Tab page.

If you enable this policy, you can select one or more shortcut items to display on the New Tab page. The selected shortcuts are managed by the policy and shown to users:

Favorites: Shows the Favorites shortcut.

History: Shows the History shortcut.

RecentTabs: Shows the Recent tabs shortcut.

Collections: Shows the Collections shortcut.

SharedLinks: Shows the Shared links shortcut.

EDrop: Shows the EDrop shortcut.

Camera: Shows the Camera shortcut.

If you disable this policy or don't configure it, Microsoft Edge displays the default set of shortcuts based on user preferences.

Policy options mapping:

- Favorites (Favorites) = Favorites
- History (History) = History
- RecentTabs (RecentTabs) = Recent Tabs
- Collections (Collections) = Collections
- SharedLinks (SharedLinks) = Shared Links
- EDrop (EDrop) = EDrop
- Camera (Camera) = Camera

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Favorites = Favorites
- History = History
- RecentTabs = Recent Tabs
- Collections = Collections
- SharedLinks = Shared Links
- EDrop = EDrop
- Camera = Camera

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Android information and settings

- Preference Key name: ManagedNtpShortcuts
- Example value:

```
["Camera", "EDrop", "Favorites", "History", "RecentTabs", "Collections"]
```

## iOS information and settings

- Preference Key name: ManagedNtpShortcuts
- Example value:

```xml
<array>
  <string>Camera</string>
  <string>EDrop</string>
  <string>Favorites</string>
  <string>History</string>
  <string>RecentTabs</string>
  <string>Collections</string>
</array>
```