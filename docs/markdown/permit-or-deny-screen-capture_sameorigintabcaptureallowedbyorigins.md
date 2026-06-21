---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SameOriginTabCaptureAllowedByOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/sameorigintabcaptureallowedbyorigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow Same Origin Tab capture by these origins'
locale: en-us
document_id: 8a12240a-2ee1-49b4-0feb-30d48a9f06c0
document_version_independent_id: 8a12240a-2ee1-49b4-0feb-30d48a9f06c0
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SameOriginTabCaptureAllowedByOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SameOriginTabCaptureAllowedByOrigins.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 244
asset_id: microsoft-edge-policies/sameorigintabcaptureallowedbyorigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SameOriginTabCaptureAllowedByOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 726a0b31-209f-7777-e35c-1a0b7ac05f31
---

# Microsoft Edge Browser Policy Documentation SameOriginTabCaptureAllowedByOrigins | Microsoft Learn

## Allow Same Origin Tab capture by these origins

## Supported versions

- Windows: ≥ 97
- macOS: ≥ 97
- Android: ≥ 147
- iOS: Not supported

## Description

Setting the policy lets you set a list of URL patterns that can capture tabs with their same Origin.

Leaving the policy unset means that sites won't be considered for an override at this scope of capture.

If a site matches a URL pattern in this policy, the following policies won't be considered: [TabCaptureAllowedByOrigins](tabcaptureallowedbyorigins), [WindowCaptureAllowedByOrigins](windowcaptureallowedbyorigins), [ScreenCaptureAllowedByOrigins](screencaptureallowedbyorigins), [ScreenCaptureAllowed](screencaptureallowed).

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

- GP unique name: SameOriginTabCaptureAllowedByOrigins
- GP name: Allow Same Origin Tab capture by these origins
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SameOriginTabCaptureAllowedByOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SameOriginTabCaptureAllowedByOrigins\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\SameOriginTabCaptureAllowedByOrigins\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: SameOriginTabCaptureAllowedByOrigins
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: SameOriginTabCaptureAllowedByOrigins
- Example value:

```
["https://www.example.com", "[*.]example.edu"]
```