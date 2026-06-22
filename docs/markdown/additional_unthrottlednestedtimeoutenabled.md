---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UnthrottledNestedTimeoutEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/unthrottlednestedtimeoutenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: JavaScript setTimeout will not be clamped until a higher nesting threshold is set (deprecated)'
locale: en-us
document_id: 2bc24f29-df56-63d6-25e3-4d3aefc0e4a8
document_version_independent_id: 2bc24f29-df56-63d6-25e3-4d3aefc0e4a8
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UnthrottledNestedTimeoutEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/UnthrottledNestedTimeoutEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 303
asset_id: microsoft-edge-policies/unthrottlednestedtimeoutenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UnthrottledNestedTimeoutEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 92ab6bce-55f9-9a4f-1ffa-2b53bfc286c5
---

# Microsoft Edge Browser Policy Documentation UnthrottledNestedTimeoutEnabled | Microsoft Learn

## JavaScript setTimeout will not be clamped until a higher nesting threshold is set (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 105
- macOS: ≥ 105
- Android: ≥ 105
- iOS: Not supported

## Description

This policy is deprecated because it's a temporary policy for web standards compliance. It doesn't work in Microsoft Edge version 107 onward. If you enable this policy, the JavaScript setTimeout and setInterval, with an interval smaller than 4 ms, aren't clamped. This improves short horizon performance; however, websites abusing the API still have their setTimeout usages clamped. If you disable or don't configure this policy, the JavaScript setTimeout and setInterval, with an interval smaller than 4 ms, are clamped.

This is a web standards compliancy feature that changes task ordering on a webpage, leading to unexpected behavior on sites that are dependent on a certain ordering. It also affects sites with a lot of usage of a timeout of 0 ms for setTimeout, for example, increasing CPU load.

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

- GP unique name: UnthrottledNestedTimeoutEnabled
- GP name: JavaScript setTimeout will not be clamped until a higher nesting threshold is set (deprecated)
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
- Value name: UnthrottledNestedTimeoutEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: UnthrottledNestedTimeoutEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: UnthrottledNestedTimeoutEnabled
- Example value:

```
true
```