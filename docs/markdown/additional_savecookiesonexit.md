---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SaveCookiesOnExit | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/savecookiesonexit
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Save cookies when Microsoft Edge closes'
locale: en-us
document_id: 8bc23fa6-4be2-7987-8aab-46c1d07185b9
document_version_independent_id: 8bc23fa6-4be2-7987-8aab-46c1d07185b9
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SaveCookiesOnExit.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/SaveCookiesOnExit.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 280
asset_id: microsoft-edge-policies/savecookiesonexit
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SaveCookiesOnExit.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0e72a843-964e-715d-98ce-37f062dcbf47
---

# Microsoft Edge Browser Policy Documentation SaveCookiesOnExit | Microsoft Learn

## Save cookies when Microsoft Edge closes

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

When this policy is enabled, the specified set of cookies is exempt from deletion when the browser closes. This policy is only effective when:

- The 'Cookies and other site data' toggle is configured in Settings/Privacy and services/Clear browsing data on close or
- The policy [ClearBrowsingDataOnExit](clearbrowsingdataonexit) is enabled or
- The policy [DefaultCookiesSetting](defaultcookiessetting) is set to 'Keep cookies for the duration of the session'.

You can define a list of sites, based on URL patterns, that have their cookies preserved across sessions.

Note: Users can still edit the cookie site list to add or remove URLs. However, they can't remove URLs that are added by an Admin.

If you enable this policy, the list of cookies aren't cleared when the browser closes.

If you disable or don't configure this policy, the user's personal configuration is used.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SaveCookiesOnExit
- GP name: Save cookies when Microsoft Edge closes
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
[*.]contoso.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SaveCookiesOnExit
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SaveCookiesOnExit\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\SaveCookiesOnExit\2 =

```
[*.]contoso.edu
```

## Mac information and settings

- Preference Key name: SaveCookiesOnExit
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
</array>
```