---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowBrowsingWithCopilot | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/allowbrowsingwithcopilot
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Controls the availability of browsing with Copilot in Microsoft Edge.'
locale: en-us
document_id: b7f318c0-3f30-bcb3-2533-6255247276fa
document_version_independent_id: b7f318c0-3f30-bcb3-2533-6255247276fa
updated_at: 2026-05-28T21:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowBrowsingWithCopilot.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/91226c26b4ce9b906f155f8a7fb1504884ea3ae8/edgeenterprise/microsoft-edge-policies/AllowBrowsingWithCopilot.md
git_commit_id: 91226c26b4ce9b906f155f8a7fb1504884ea3ae8
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 290
asset_id: microsoft-edge-policies/allowbrowsingwithcopilot
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowBrowsingWithCopilot.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 124ddb2b-67dd-cef8-b31a-1e5feea7381a
---

# Microsoft Edge Browser Policy Documentation AllowBrowsingWithCopilot | Microsoft Learn

## Controls the availability of browsing with Copilot in Microsoft Edge.

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

When browsing with Copilot is enabled, users can explicitly invoke it for a query. It isn't invoked automatically.

Browsing with Copilot is available only on domains specified in the [BrowsingWithCopilotAllowList](browsingwithcopilotallowlist) policy and is blocked on domains specified in the [BrowsingWithCopilotBlockList](browsingwithcopilotblocklist) policy. If no domains are configured in the allow list, browsing with Copilot is effectively disabled.

This feature is available only to users with an active Microsoft 365 Copilot subscription.

For more information about configuring browsing with Copilot, see https://go.microsoft.com/fwlink/?LinkId=2341535.

If you enable this policy, browsing with Copilot is turned on for all users who receive the policy, and users can't turn it off.

If you disable this policy, browsing with Copilot is turned off for all users who receive the policy, and users can't turn it on.

If you don't configure this policy, browsing with Copilot is off by default, and users can turn it on.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllowBrowsingWithCopilot
- GP name: Controls the availability of browsing with Copilot in Microsoft Edge.
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AllowBrowsingWithCopilot
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AllowBrowsingWithCopilot
- Example value:

```xml
<true/>
```