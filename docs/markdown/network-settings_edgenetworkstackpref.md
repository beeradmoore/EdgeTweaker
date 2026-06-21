---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeNetworkStackPref | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgenetworkstackpref
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Switch network stack between Chromium and iOS'
locale: en-us
document_id: 630ff12b-ae87-7836-60e1-abfaf49feed0
document_version_independent_id: 630ff12b-ae87-7836-60e1-abfaf49feed0
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeNetworkStackPref.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeNetworkStackPref.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 209
asset_id: microsoft-edge-policies/edgenetworkstackpref
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeNetworkStackPref.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5e6df960-071c-f2c3-2247-44068d81ed76
---

# Microsoft Edge Browser Policy Documentation EdgeNetworkStackPref | Microsoft Learn

## Switch network stack between Chromium and iOS

## Supported versions

- Windows: Not supported
- macOS: Not supported
- Android: Not supported
- iOS: ≥ 142

## Description

The network architecture in Microsoft Edge for iOS can use either the Chromium network stack or the iOS network stack. The network stack handles Microsoft Edge service communication, including sync services and auto search suggestions.

If you configure this policy, you can choose which network stack to use by setting one of the following values: 0 (Default): Use the Chromium network stack 1: Use the iOS network stack

If you disable or don’t configure this policy, Microsoft Edge uses the default Chromium network stack.

Policy options mapping:

- ChromiumNetworkStack (0) = Use the Chromium network stack
- iOSNetworkStack (1) = Use the iOS network stack

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- ChromiumNetworkStack (0) = Use the Chromium network stack
- iOSNetworkStack (1) = Use the iOS network stack

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## iOS information and settings

- Preference Key name: EdgeNetworkStackPref
- Example value:

```xml
<integer>0</integer>
```