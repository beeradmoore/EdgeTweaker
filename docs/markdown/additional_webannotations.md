---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebAnnotations | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webannotations
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow detecting plain text entities in web pages.'
locale: en-us
document_id: dcffc017-7a9a-2c39-9f71-d271b1b7119e
document_version_independent_id: dcffc017-7a9a-2c39-9f71-d271b1b7119e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebAnnotations.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/WebAnnotations.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 225
asset_id: microsoft-edge-policies/webannotations
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebAnnotations.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a6e064db-7a88-e9b6-6005-f3dd5599a645
---

# Microsoft Edge Browser Policy Documentation WebAnnotations | Microsoft Learn

## Allow detecting plain text entities in web pages.

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: Not supported
- iOS: ≥ 147

## Description

This policy decides if plain text entities are detected on webpages, letting users trigger contextual actions by interacting with them. The policy has multiple properties, one for each entity type. The entity types are default, addresses ... .

If the value for an entity is unset, the behavior of the default entity is applied. The default behavior for default is enabled.

The values for each entity types are default, enabled, disabled or longpressonly. If the value is set to default, the behavior of the default entity is applied. If the value is set to enabled, entities are detected, underlines and triggered either by one tap or long press. If the value is set to disabled, entities are not detected and not actionable. If the value is set to longpressonly, entities are detected and only actionable using long press.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## iOS information and settings

- Preference Key name: WebAnnotations
- Example value:

```xml
<key>WebAnnotations</key>
<dict>
  <key>addresses</key>
  <string>longpressonly</string>
  <key>calendar</key>
  <string>default</string>
  <key>default</key>
  <string>enabled</string>
  <key>email</key>
  <string>disabled</string>
  <key>package</key>
  <string>default</string>
  <key>phonenumbers</key>
  <string>default</string>
  <key>units</key>
  <string>default</string>
</dict>
```