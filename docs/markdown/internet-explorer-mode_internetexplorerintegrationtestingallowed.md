---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationTestingAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationtestingallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Internet Explorer mode testing (obsolete)'
locale: en-us
document_id: 96331f79-48b7-24f9-497c-a2353741a14c
document_version_independent_id: 96331f79-48b7-24f9-497c-a2353741a14c
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationTestingAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationTestingAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 367
asset_id: microsoft-edge-policies/internetexplorerintegrationtestingallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationTestingAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 61428b0f-c0dd-2ae6-2f2b-7281f80b6b74
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationTestingAllowed | Microsoft Learn

## Allow Internet Explorer mode testing (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 94.

## Supported versions

- Windows: 86-94
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because it has been superseded by an improved feature. It doesn't work in Microsoft Edge after version 94. To allow users to open applications in Internet Explorer mode, use the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy instead. Alternatively, users can still use the --ie-mode-test flag.

This policy allows users to test applications in Internet Explorer mode by opening an Internet Explorer mode tab in Microsoft Edge.

Users can do so from within the "More tools" menu by selecting 'Open sites in Internet Explorer mode'.

Additionally, users can test their applications in a modern browser without removing applications from the site list using the option 'Open sites in Edge mode'.

This setting works in conjunction with [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) which is set to 'IEMode'.

If you enable this policy, the option 'Open sites in Internet Explorer mode' is visible under "More tools". Users can view their sites in Internet Explorer mode on this tab. Another option 'Open sites in Edge mode' is also visible under "More tools" to help testing sites in a modern browser without removing them from the site list. If the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy is enabled, it takes precedence and these options will not be visible under "More tools".

If you disable or don't configure this policy, users can't see the options 'Open in Internet Explorer mode' and 'Open in Edge mode' under "More tools" menu. However, users can configure these options with the --ie-mode-test flag.

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

- GP unique name: InternetExplorerIntegrationTestingAllowed
- GP name: Allow Internet Explorer mode testing (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationTestingAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```