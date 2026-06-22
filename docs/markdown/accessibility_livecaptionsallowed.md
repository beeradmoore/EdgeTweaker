---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LiveCaptionsAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/livecaptionsallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Live captions allowed'
locale: en-us
document_id: f9505dcc-c5b8-5140-eb4a-848dc5dc2c4a
document_version_independent_id: f9505dcc-c5b8-5140-eb4a-848dc5dc2c4a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LiveCaptionsAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/LiveCaptionsAllowed.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 293
asset_id: microsoft-edge-policies/livecaptionsallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LiveCaptionsAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: fe206dcf-b27e-31e7-d77e-53971304c09e
---

# Microsoft Edge Browser Policy Documentation LiveCaptionsAllowed | Microsoft Learn

## Live captions allowed

## Supported versions

- Windows: ≥ 103
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Allow users to turn the Live captions feature on or off.

Live captions is an accessibility feature that converts speech from the audio that plays in Microsoft Edge into text and shows this text in a separate window. The entire process happens on the device and no audio or caption text ever leaves the device.

Note: This feature isn't generally available. Clients that have the [ExperimentationAndConfigurationServiceControl](experimentationandconfigurationservicecontrol) policy set to 'FullMode' receive the feature before broad availability. Broad availability is announced via Microsoft Edge release notes.

If you enable or don't configure this policy, users can turn on this feature or turn it off at edge://settings/accessibility.

If you disable this policy, users can't turn on this accessibility feature. If speech recognition files were downloaded previously, they will be deleted from the device in 30 days. We recommend avoiding this option unless it's needed in your environment.

If users choose to turn on Live captions, speech recognition files (approximately 100 megabytes) are downloaded to the device on first run and then periodically to improve performance and accuracy. These files will be deleted after 30 days.

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

- GP unique name: LiveCaptionsAllowed
- GP name: Live captions allowed
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
- Value name: LiveCaptionsAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```