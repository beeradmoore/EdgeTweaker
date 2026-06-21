---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RestoreOnStartupUserURLsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/restoreonstartupuserurlsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to add and remove their own sites during startup when the RestoreOnStartupURLs policy is configured.'
locale: en-us
document_id: 16a6ab2c-f317-5254-9fdd-20798e0c594b
document_version_independent_id: 16a6ab2c-f317-5254-9fdd-20798e0c594b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RestoreOnStartupUserURLsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RestoreOnStartupUserURLsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 248
asset_id: microsoft-edge-policies/restoreonstartupuserurlsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RestoreOnStartupUserURLsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4891d7b3-3c12-aea3-e364-39a1d39fcbf5
---

# Microsoft Edge Browser Policy Documentation RestoreOnStartupUserURLsEnabled | Microsoft Learn

## Allow users to add and remove their own sites during startup when the RestoreOnStartupURLs policy is configured.

## Supported versions

- Windows: ≥ 107
- macOS: ≥ 111
- Android: Not supported
- iOS: Not supported

## Description

This policy only works if you set the [RestoreOnStartup](restoreonstartup) policy to 'Open a list of URLs' (4) and the RestoreOnStartupURLs policy as mandatory. If you enable this policy, users are allowed to add and remove their own URLs to open when starting Microsoft Edge while maintaining the admin specified mandatory list of sites specified by setting [RestoreOnStartup](restoreonstartup) policy to open a list of URLS and providing the list of sites in the RestoreOnStartupURLs policy.

If you disable or don't configure this policy, there's no change to how the [RestoreOnStartup](restoreonstartup) and RestoreOnStartupURLs policies work.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RestoreOnStartupUserURLsEnabled
- GP name: Allow users to add and remove their own sites during startup when the RestoreOnStartupURLs policy is configured.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Startup, home page and new tab page
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RestoreOnStartupUserURLsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: RestoreOnStartupUserURLsEnabled
- Example value:

```xml
<true/>
```