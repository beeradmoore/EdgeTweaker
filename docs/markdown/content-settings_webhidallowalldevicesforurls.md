---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebHidAllowAllDevicesForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webhidallowalldevicesforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow listed sites to connect to any HID device'
locale: en-us
document_id: a16ad878-179b-b7dd-42b6-ea8faaff38d3
document_version_independent_id: a16ad878-179b-b7dd-42b6-ea8faaff38d3
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebHidAllowAllDevicesForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/WebHidAllowAllDevicesForUrls.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 215
asset_id: microsoft-edge-policies/webhidallowalldevicesforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebHidAllowAllDevicesForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: b92cfca2-ff2a-e341-fd3d-cb445400f610
---

# Microsoft Edge Browser Policy Documentation WebHidAllowAllDevicesForUrls | Microsoft Learn

## Allow listed sites to connect to any HID device

## Supported versions

- Windows: ≥ 109
- macOS: ≥ 109
- Android: Not supported
- iOS: Not supported

## Description

This setting allows you to list sites which are automatically granted permission to access all available devices.

The URLs must be valid; else, the policy is ignored. Only the origin (scheme, host, and port) of the URL is evaluated.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* isn't an accepted value for this policy.

This policy overrides [DefaultWebHidGuardSetting](defaultwebhidguardsetting), [WebHidAskForUrls](webhidaskforurls), [WebHidBlockedForUrls](webhidblockedforurls), and the user's preferences.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebHidAllowAllDevicesForUrls
- GP name: Allow listed sites to connect to any HID device
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://microsoft.com
```

```
https://chromium.org
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WebHidAllowAllDevicesForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WebHidAllowAllDevicesForUrls\1 =

```
https://microsoft.com
```

SOFTWARE\Policies\Microsoft\Edge\WebHidAllowAllDevicesForUrls\2 =

```
https://chromium.org
```

## Mac information and settings

- Preference Key name: WebHidAllowAllDevicesForUrls
- Example value:

```xml
<array>
  <string>https://microsoft.com</string>
  <string>https://chromium.org</string>
</array>
```