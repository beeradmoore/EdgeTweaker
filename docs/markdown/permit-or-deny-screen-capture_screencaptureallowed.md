---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ScreenCaptureAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/screencaptureallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow or deny screen capture'
locale: en-us
document_id: 0179aca9-caed-a492-d23a-9fd57523464c
document_version_independent_id: 0179aca9-caed-a492-d23a-9fd57523464c
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ScreenCaptureAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ScreenCaptureAllowed.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 221
asset_id: microsoft-edge-policies/screencaptureallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ScreenCaptureAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 9698e903-767a-da48-56e9-218ffc1be0b5
---

# Microsoft Edge Browser Policy Documentation ScreenCaptureAllowed | Microsoft Learn

## Allow or deny screen capture

## Supported versions

- Windows: ≥ 83
- macOS: ≥ 83
- Android: ≥ 147
- iOS: Not supported

## Description

If you enable this policy, or don't configure this policy, a webpage uses screen-share APIs (for example, getDisplayMedia() or the Desktop Capture extension API) for a screen capture. If you disable this policy, calls to screen-share APIs fail. For example, if you're using a web-based online meeting, video or screen sharing won't work. However, this policy isn't considered. (and a site will be allowed to use screen-share APIs) if the site matches an origin pattern in any of the following policies: [ScreenCaptureAllowedByOrigins](screencaptureallowedbyorigins), [WindowCaptureAllowedByOrigins](windowcaptureallowedbyorigins), [TabCaptureAllowedByOrigins](tabcaptureallowedbyorigins), [SameOriginTabCaptureAllowedByOrigins](sameorigintabcaptureallowedbyorigins).

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

- GP unique name: ScreenCaptureAllowed
- GP name: Allow or deny screen capture
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
- Value name: ScreenCaptureAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ScreenCaptureAllowed
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: ScreenCaptureAllowed
- Example value:

```
false
```