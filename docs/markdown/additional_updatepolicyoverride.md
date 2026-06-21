---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UpdatePolicyOverride | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/updatepolicyoverride
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specifies how Microsoft Edge Update handles available updates from Microsoft Edge'
locale: en-us
document_id: 21a66fbe-2e06-90be-7560-c93fc27753eb
document_version_independent_id: 21a66fbe-2e06-90be-7560-c93fc27753eb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UpdatePolicyOverride.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/UpdatePolicyOverride.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 267
asset_id: microsoft-edge-policies/updatepolicyoverride
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UpdatePolicyOverride.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 667d2eda-703b-9133-c6f7-62b8fa8e1926
---

# Microsoft Edge Browser Policy Documentation UpdatePolicyOverride | Microsoft Learn

## Specifies how Microsoft Edge Update handles available updates from Microsoft Edge

## Supported versions

- Windows: Not supported
- macOS: ≥ 89
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, Microsoft Edge Update handles Microsoft Edge updates according to how you configure the following options:

- Automatic silent updates only: Updates are applied only when the periodic update check finds them.
- Manual updates only: Updates are applied only when the user runs a manual update check. (Not all apps provide an interface for this option.)

If you select manual updates, make sure you periodically check for updates by using Microsoft Autoupdate.

If you don't enable and configure this policy, Microsoft Edge Update automatically checks for updates.

Policy options mapping:

- automatic-silent-only (automatic-silent-only) = Updates are applied only when they're found by the periodic update check.
- manual-only (manual-only) = Updates are applied only when the user runs a manual update check. (Not all apps provide an interface for this option.)

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- automatic-silent-only = Updates are applied only when they're found by the periodic update check.
- manual-only = Updates are applied only when the user runs a manual update check. (Not all apps provide an interface for this option.)

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- String

## Mac information and settings

- Preference Key name: UpdatePolicyOverride
- Example value:

```xml
<string>automatic-silent-only</string>
```