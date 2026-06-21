---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationReloadInIEModeAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationreloadiniemodeallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow unconfigured sites to be reloaded in Internet Explorer mode'
locale: en-us
document_id: aa3159a1-7670-97bc-be10-49cb23e25475
document_version_independent_id: aa3159a1-7670-97bc-be10-49cb23e25475
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationReloadInIEModeAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationReloadInIEModeAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 387
asset_id: microsoft-edge-policies/internetexplorerintegrationreloadiniemodeallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationReloadInIEModeAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 38f39303-c2f1-f8cd-547b-446c33ce7e21
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationReloadInIEModeAllowed | Microsoft Learn

## Allow unconfigured sites to be reloaded in Internet Explorer mode

## Supported versions

- Windows: ≥ 92
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy allows users to reload unconfigured sites (ones that aren't configured in the Enterprise Mode Site List) in Internet Explorer mode when browsing in Microsoft Edge, and a site requires Internet Explorer for compatibility.

After a site is reloaded in Internet Explorer mode, "in-page" navigation stays in Internet Explorer mode (for example, a link, script, or form on the page, or a server-side redirect from another "in-page" navigation). Users can choose to exit from Internet Explorer mode, or Microsoft Edge automatically exits from Internet Explorer mode when a navigation that isn't "in-page" occurs (for example, using the address bar, the back button, or a favorite link).

Users can also optionally tell Microsoft Edge to use Internet Explorer mode for the site in the future. This choice is remembered for a length of time managed by the [InternetExplorerIntegrationLocalSiteListExpirationDays](internetexplorerintegrationlocalsitelistexpirationdays) policy.

If the [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) policy is set to 'IEMode', then sites explicitly configured by the [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) policy's site list to use Microsoft Edge aren't reloaded in Internet Explorer mode, and sites configured by the site list or by the [SendIntranetToInternetExplorer](sendintranettointernetexplorer) policy to use Internet Explorer mode can't exit from Internet Explorer mode.

If you enable this policy, users are allowed to reload unconfigured sites in Internet Explorer mode.

If you disable this policy, users aren't allowed to reload unconfigured sites in Internet Explorer mode.

If you enable this policy, it takes precedence over how you configured the [InternetExplorerIntegrationTestingAllowed](internetexplorerintegrationtestingallowed) policy, and that policy is disabled.

For more information about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2094210

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InternetExplorerIntegrationReloadInIEModeAllowed
- GP name: Allow unconfigured sites to be reloaded in Internet Explorer mode
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
- Value name: InternetExplorerIntegrationReloadInIEModeAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```