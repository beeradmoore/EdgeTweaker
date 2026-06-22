---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebHidAskForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webhidaskforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow the WebHID API on these sites'
locale: en-us
document_id: 17cb6587-5d7c-6484-4a3a-23970db13e82
document_version_independent_id: 17cb6587-5d7c-6484-4a3a-23970db13e82
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebHidAskForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/WebHidAskForUrls.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/webhidaskforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebHidAskForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 3e4388e7-1eed-4d32-566b-e9bda8ea7fa8
---

# Microsoft Edge Browser Policy Documentation WebHidAskForUrls | Microsoft Learn

## Allow the WebHID API on these sites

## Supported versions

- Windows: ≥ 100
- macOS: ≥ 100
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy lets you list the URL patterns that specify which sites can ask users to grant them access to a HID device.

Leaving the policy unset means [DefaultWebHidGuardSetting](defaultwebhidguardsetting) applies for all sites, if set. If not, users' personal settings apply.

For URL patterns that don't match the policy, the following values are applied in order of precedence:

- [WebHidBlockedForUrls](webhidblockedforurls) (if there's a match),
- [DefaultWebHidGuardSetting](defaultwebhidguardsetting) (if set), or
- Users' personal settings.

URL patterns must not conflict with [WebHidBlockedForUrls](webhidblockedforurls). Neither policy takes precedence if a URL matches both patterns.

For detailed information about valid url patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* isn't an accepted value for this policy.

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

- GP unique name: WebHidAskForUrls
- GP name: Allow the WebHID API on these sites
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WebHidAskForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WebHidAskForUrls\1 =

```
https://microsoft.com
```

SOFTWARE\Policies\Microsoft\Edge\WebHidAskForUrls\2 =

```
https://chromium.org
```

## Mac information and settings

- Preference Key name: WebHidAskForUrls
- Example value:

```xml
<array>
  <string>https://microsoft.com</string>
  <string>https://chromium.org</string>
</array>
```