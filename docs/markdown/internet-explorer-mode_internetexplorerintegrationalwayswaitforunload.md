---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationAlwaysWaitForUnload | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationalwayswaitforunload
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Wait for Internet Explorer mode tabs to completely unload before ending the browser session'
locale: en-us
document_id: 3ec5161a-814f-6623-7902-3cee5c9e910a
document_version_independent_id: 3ec5161a-814f-6623-7902-3cee5c9e910a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationAlwaysWaitForUnload.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationAlwaysWaitForUnload.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 279
asset_id: microsoft-edge-policies/internetexplorerintegrationalwayswaitforunload
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationAlwaysWaitForUnload.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: affad4d8-d58c-2f79-a1c8-cacdc21bf77a
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationAlwaysWaitForUnload | Microsoft Learn

## Wait for Internet Explorer mode tabs to completely unload before ending the browser session

## Supported versions

- Windows: ≥ 105
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy causes Microsoft Edge to continue running until all Internet Explorer tabs have completely finished unloading. This allows Internet Explorer plugins like ActiveX controls to perform other critical work even after the browser has been closed. However, this can cause stability and performance issues, and Microsoft Edge processes may remain active in the background with no visible windows if the webpage or plugin prevents Internet Explorer from unloading. This policy should only be used if your organization depends on a plugin that requires this behavior.

If you enable this policy, Microsoft Edge always waits for Internet Explorer mode tabs to fully unload before ending the browser session.

If you disable or don't configure this policy, Microsoft Edge won't always wait for Internet Explorer mode tabs to fully unload before ending the browser session.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2174004

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationAlwaysWaitForUnload
- GP name: Wait for Internet Explorer mode tabs to completely unload before ending the browser session
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationAlwaysWaitForUnload
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```