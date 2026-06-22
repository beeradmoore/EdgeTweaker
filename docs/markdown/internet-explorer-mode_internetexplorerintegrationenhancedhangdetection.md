---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationEnhancedHangDetection | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationenhancedhangdetection
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure enhanced hang detection for Internet Explorer mode'
locale: en-us
document_id: 77fa2107-3367-d550-faf4-346aab11189f
document_version_independent_id: 77fa2107-3367-d550-faf4-346aab11189f
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationEnhancedHangDetection.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationEnhancedHangDetection.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 342
asset_id: microsoft-edge-policies/internetexplorerintegrationenhancedhangdetection
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationEnhancedHangDetection.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1c611115-f858-d6f3-6f29-c6c5d2b7e422
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationEnhancedHangDetection | Microsoft Learn

## Configure enhanced hang detection for Internet Explorer mode

## Supported versions

- Windows: ≥ 84
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Enhanced hang detection is a more granular approach to detecting hung webpages in Internet Explorer mode than what standalone Internet Explorer uses. When a hung webpage is detected, the browser applies a mitigation to prevent the rest of the browser from hanging.

This setting allows you to configure the use of enhanced hang detection in case you run into incompatible issues with any of your websites. We recommend disabling this policy only if you see notifications such as "(website) is not responding" in Internet Explorer mode but not in standalone Internet Explorer.

This setting works in conjunction with: [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) is set to 'IEMode' and [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) policy where the list has at least one entry.

If you set this policy to 'Enabled' or don't configure it, websites running in Internet Explorer mode use enhanced hang detection.

If you set this policy to 'Disabled', enhanced hang detection is disabled, and users get the basic Internet Explorer hang detection behavior.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2094210

Policy options mapping:

- Disabled (0) = Enhanced hang detection disabled
- Enabled (1) = Enhanced hang detection enabled

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Disabled (0) = Enhanced hang detection disabled
- Enabled (1) = Enhanced hang detection enabled

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

- GP unique name: InternetExplorerIntegrationEnhancedHangDetection
- GP name: Configure enhanced hang detection for Internet Explorer mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enhanced hang detection enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationEnhancedHangDetection
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```