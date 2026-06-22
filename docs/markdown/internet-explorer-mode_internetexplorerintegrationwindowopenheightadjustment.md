---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationWindowOpenHeightAdjustment | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationwindowopenheightadjustment
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the pixel adjustment between window.open heights sourced from IE mode pages vs. Edge mode pages'
locale: en-us
document_id: 666ee631-f6d8-5f87-585d-a5db44864c43
document_version_independent_id: 666ee631-f6d8-5f87-585d-a5db44864c43
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationWindowOpenHeightAdjustment.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationWindowOpenHeightAdjustment.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 224
asset_id: microsoft-edge-policies/internetexplorerintegrationwindowopenheightadjustment
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationWindowOpenHeightAdjustment.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 08f9af89-dab6-e98f-b0b2-47a24608b154
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationWindowOpenHeightAdjustment | Microsoft Learn

## Configure the pixel adjustment between window.open heights sourced from IE mode pages vs. Edge mode pages

## Supported versions

- Windows: ≥ 95
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you specify a custom adjustment to the height of popup windows generated via window.open from the Internet Explorer mode site.

If you configure this policy, Microsoft Edge will add the adjustment value to the height, in pixels. The exact difference depends on the UI configuration of both IE and Edge, but a typical difference is 5.

If you disable or don't configure this policy, Microsoft Edge will treat IE mode window.open the same as Edge mode window.open in window height calculations.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationWindowOpenHeightAdjustment
- GP name: Configure the pixel adjustment between window.open heights sourced from IE mode pages vs. Edge mode pages
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
5
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationWindowOpenHeightAdjustment
- Value type: REG\_DWORD

#### Example registry value

```
0x00000005
```