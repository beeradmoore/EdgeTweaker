---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationSiteRedirect | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/internetexplorerintegrationsiteredirect
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specify how &quot;in-page&quot; navigations to unconfigured sites behave when started from Internet Explorer mode pages'
locale: en-us
document_id: f0ec383e-eda2-8fed-feb1-a41671f5286a
document_version_independent_id: f0ec383e-eda2-8fed-feb1-a41671f5286a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationSiteRedirect.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationSiteRedirect.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 521
asset_id: microsoft-edge-policies/internetexplorerintegrationsiteredirect
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InternetExplorerIntegrationSiteRedirect.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5543c53d-1127-7acb-a605-7b2b8adc0763
---

# Microsoft Edge Browser Policy Documentation InternetExplorerIntegrationSiteRedirect | Microsoft Learn

## Specify how "in-page" navigations to unconfigured sites behave when started from Internet Explorer mode pages

## Supported versions

- Windows: ≥ 81
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

An "in-page" navigation is started from a link, a script, or a form on the current page. It can also be a server-side redirect of a previous "in-page" navigation attempt. Conversely, a user can start a navigation that isn't "in-page" and that's independent of the current page in several ways by using the browser controls, for example, using the address bar, the back button, or a favorite link.

This setting lets you specify whether navigations from pages loaded in Internet Explorer mode to unconfigured sites (that aren't configured in the Enterprise Mode Site List) switch back to Microsoft Edge or remain in Internet Explorer mode.

This setting works in conjunction with [InternetExplorerIntegrationLevel](internetexplorerintegrationlevel) policy that's set to 'IEMode', and with [InternetExplorerIntegrationSiteList](internetexplorerintegrationsitelist) policy where the list has at least one entry.

If you disable or don't configure this policy, only sites configured to open in Internet Explorer mode open in that mode. Any site not configured to open in Internet Explorer mode is redirected back to Microsoft Edge.

If you set this policy to 'Default', only sites configured to open in Internet Explorer mode open in that mode. Any site not configured to open in Internet Explorer mode is redirected back to Microsoft Edge.

If you set this policy to 'AutomaticNavigationsOnly', you get the default experience except that all automatic navigations (such as 302 redirects) to unconfigured sites are kept in Internet Explorer mode.

If you set this policy to 'AllInPageNavigations', all navigations from pages loaded in IE mode to unconfigured sites are kept in Internet Explorer mode (Least Recommended).

If the [InternetExplorerIntegrationReloadInIEModeAllowed](internetexplorerintegrationreloadiniemodeallowed) policy allows users to reload sites in Internet Explorer mode, then all in-page navigations from unconfigured sites that users have chosen to reload in Internet Explorer mode are kept in Internet Explorer mode, regardless of how this policy is configured.

To learn more about Internet Explorer mode, see https://go.microsoft.com/fwlink/?linkid=2105106.

Policy options mapping:

- Default (0) = Default
- AutomaticNavigationsOnly (1) = Keep only automatic navigations in Internet Explorer mode
- AllInPageNavigations (2) = Keep all in-page navigations in Internet Explorer mode

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Default
- AutomaticNavigationsOnly (1) = Keep only automatic navigations in Internet Explorer mode
- AllInPageNavigations (2) = Keep all in-page navigations in Internet Explorer mode

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

- GP unique name: InternetExplorerIntegrationSiteRedirect
- GP name: Specify how "in-page" navigations to unconfigured sites behave when started from Internet Explorer mode pages
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Default
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InternetExplorerIntegrationSiteRedirect
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```