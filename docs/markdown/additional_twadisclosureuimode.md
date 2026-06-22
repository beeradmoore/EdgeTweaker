---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TwaDisclosureUiMode | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/twadisclosureuimode
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Trusted Web Activity disclosure UI mode'
locale: en-us
document_id: 2f60b07b-1e8d-209a-98cc-ddff344c858d
document_version_independent_id: 2f60b07b-1e8d-209a-98cc-ddff344c858d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TwaDisclosureUiMode.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/TwaDisclosureUiMode.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 240
asset_id: microsoft-edge-policies/twadisclosureuimode
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TwaDisclosureUiMode.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d54118f5-f4e8-57ae-d42d-ef07282328a9
---

# Microsoft Edge Browser Policy Documentation TwaDisclosureUiMode | Microsoft Learn

## Configure Trusted Web Activity disclosure UI mode

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: ≥ 140
- iOS: Not supported

## Description

This policy controls the user interface used to display the "Running in Microsoft Edge" disclosure when a Trusted Web Activity (TWA) is launched.

If you enable this policy, you can specify which UI variant is used to show the disclosure message.

If you disable or don't configure this policy, Microsoft Edge uses the default disclosure UI.

Note: An InfoBar remains visible until the user dismisses it, whereas Snackbar and Notification variants automatically hide after a short delay.

Policy options mapping:

- Default (0) = Let Microsoft Edge decide (default)
- V1InfoBar (1) = Show disclosure as an InfoBar (stays visible until dismissed)
- V2NotificationOrSnackbar (2) = Show disclosure as a Notification or Snackbar (auto-hides after a short delay)

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Let Microsoft Edge decide (default)
- V1InfoBar (1) = Show disclosure as an InfoBar (stays visible until dismissed)
- V2NotificationOrSnackbar (2) = Show disclosure as a Notification or Snackbar (auto-hides after a short delay)

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Android information and settings

- Preference Key name: TwaDisclosureUiMode
- Example value:

```
2
```