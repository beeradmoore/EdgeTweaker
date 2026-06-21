---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation VerticalTabsAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/verticaltabsallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configures availability of a vertical layout for tabs on the side of the browser'
locale: en-us
document_id: 9735b638-cab0-9198-bbb3-328b54a35655
document_version_independent_id: 9735b638-cab0-9198-bbb3-328b54a35655
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/VerticalTabsAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/VerticalTabsAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 254
asset_id: microsoft-edge-policies/verticaltabsallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/VerticalTabsAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 148cf26c-6b01-71f3-72af-ebf296694224
---

# Microsoft Edge Browser Policy Documentation VerticalTabsAllowed | Microsoft Learn

## Configures availability of a vertical layout for tabs on the side of the browser

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

Configures whether a user can access an alternative layout where tabs are vertically aligned on the side of the browser instead of at the top. When there are several tabs open, this layout provides better tab viewing and management. There's better visibility of the site titles, it's easier to scan aligned icons, and there's more space to manage and close tabs.

If you disable this policy, then the vertical tab layout isn't available as an option for users.

If you enable or don't configure this policy, the tab layout remains at the top, but a user has the option to turn on vertical tabs on the side.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: VerticalTabsAllowed
- GP name: Configures availability of a vertical layout for tabs on the side of the browser
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
- Value name: VerticalTabsAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: VerticalTabsAllowed
- Example value:

```xml
<true/>
```