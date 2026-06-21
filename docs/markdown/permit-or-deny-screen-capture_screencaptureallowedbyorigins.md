---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ScreenCaptureAllowedByOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/screencaptureallowedbyorigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Desktop, Window, and Tab capture by these origins'
locale: en-us
document_id: a180dc02-a29f-00a4-65d1-6f545a829d4d
document_version_independent_id: a180dc02-a29f-00a4-65d1-6f545a829d4d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ScreenCaptureAllowedByOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ScreenCaptureAllowedByOrigins.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 260
asset_id: microsoft-edge-policies/screencaptureallowedbyorigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ScreenCaptureAllowedByOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 172147ad-026c-dbb3-c346-4810086dac51
---

# Microsoft Edge Browser Policy Documentation ScreenCaptureAllowedByOrigins | Microsoft Learn

## Allow Desktop, Window, and Tab capture by these origins

## Supported versions

- Windows: ≥ 97
- macOS: ≥ 97
- Android: ≥ 147
- iOS: Not supported

## Description

Setting the policy lets you set a list of URL patterns that can use Desktop, Window, and Tab Capture.

Leaving the policy unset means that sites won't be considered for an override at this scope of Capture.

This policy isn't considered if a site matches a URL pattern in any of the following policies: [WindowCaptureAllowedByOrigins](windowcaptureallowedbyorigins), [TabCaptureAllowedByOrigins](tabcaptureallowedbyorigins), [SameOriginTabCaptureAllowedByOrigins](sameorigintabcaptureallowedbyorigins).

If a site matches a URL pattern in this policy, the [ScreenCaptureAllowed](screencaptureallowed) isn't considered.

For detailed information on valid url patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. This policy only matches based on origin, so any path in the URL pattern is ignored.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ScreenCaptureAllowedByOrigins
- GP name: Allow Desktop, Window, and Tab capture by these origins
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Permit or deny screen capture
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ScreenCaptureAllowedByOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ScreenCaptureAllowedByOrigins\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\ScreenCaptureAllowedByOrigins\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: ScreenCaptureAllowedByOrigins
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: ScreenCaptureAllowedByOrigins
- Example value:

```
["https://www.example.com", "[*.]example.edu"]
```