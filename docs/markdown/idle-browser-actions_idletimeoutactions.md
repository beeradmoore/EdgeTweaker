---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation IdleTimeoutActions | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/idletimeoutactions
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Actions to run when the computer is idle'
locale: en-us
document_id: ded4e859-07a7-0d28-c4d0-e5c9fa176319
document_version_independent_id: ded4e859-07a7-0d28-c4d0-e5c9fa176319
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/IdleTimeoutActions.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/IdleTimeoutActions.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 500
asset_id: microsoft-edge-policies/idletimeoutactions
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/IdleTimeoutActions.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 34248718-fe56-90bb-f78f-7750fcfb75d3
---

# Microsoft Edge Browser Policy Documentation IdleTimeoutActions | Microsoft Learn

## Actions to run when the computer is idle

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: ≥ 122
- iOS: ≥ 122

## Description

When the timeout from the IdleTimeout policy is reached, the browser runs the actions configured in this policy.

If you don't configure the IdleTimeout policy, this policy has no effect.

If you don't configure this policy or no actions are selected, the IdleTimeout policy has no effect.

Supported actions are:

'close\_browsers': close all browser windows and Progressive Web Apps (PWAs) for this profile.

'reload\_pages': reload all webpages. For some pages, the user might be prompted for confirmation first.

'sign\_out': sign out of browser. (This action only applies to iOS.)

'close\_tabs': close all open tabs and create an NTP (New Tab Page). Supported in Android and iOS.

'clear\_browsing\_history', 'clear\_download\_history', 'clear\_cookies\_and\_other\_site\_data', 'clear\_cached\_images\_and\_files', 'clear\_password\_signing', 'clear\_autofill', 'clear\_site\_settings': clear the corresponding browsing data. Deleting cookies using this policy doesn't sign the user out of their profile, the user stays signed in.

Setting 'clear\_browsing\_history', 'clear\_password\_signing', 'clear\_autofill', and 'clear\_site\_settings' disables sync for the respective data types if sync isn't already disabled by setting either the SyncDisabled policy or BrowserSignin to disabled.

Policy options mapping:

- close\_browsers (close\_browsers) = Close Browsers
- clear\_browsing\_history (clear\_browsing\_history) = Clear Browsing History
- clear\_download\_history (clear\_download\_history) = Clear Download History
- clear\_cookies\_and\_other\_site\_data (clear\_cookies\_and\_other\_site\_data) = Clear Cookies and Other Site Data
- clear\_cached\_images\_and\_files (clear\_cached\_images\_and\_files) = Clear Cached Images and Files
- clear\_password\_signin (clear\_password\_signin) = Clear Password sign in
- clear\_autofill (clear\_autofill) = Clear Autofill
- clear\_site\_settings (clear\_site\_settings) = Clear Site Settings
- reload\_pages (reload\_pages) = Reload Pages
- sign\_out (sign\_out) = Sign Out
- close\_tabs (close\_tabs) = Close Tabs

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- close\_browsers = Close Browsers
- clear\_browsing\_history = Clear Browsing History
- clear\_download\_history = Clear Download History
- clear\_cookies\_and\_other\_site\_data = Clear Cookies and Other Site Data
- clear\_cached\_images\_and\_files = Clear Cached Images and Files
- clear\_password\_signin = Clear Password sign in
- clear\_autofill = Clear Autofill
- clear\_site\_settings = Clear Site Settings
- reload\_pages = Reload Pages
- sign\_out = Sign Out
    - Windows: Not supported
    - macOS: Not supported
    - Android: Not supported
    - iOS: ≥ 122
- close\_tabs = Close Tabs
    - Windows: Not supported
    - macOS: Not supported
    - Android: ≥ 122
    - iOS: ≥ 122

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

- GP unique name: IdleTimeoutActions
- GP name: Actions to run when the computer is idle
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Idle Browser Actions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Close Browsers
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\IdleTimeoutActions
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\IdleTimeoutActions\1 =

```
close_browsers
```

## Mac information and settings

- Preference Key name: IdleTimeoutActions
- Example value:

```xml
<array>
  <string>close_browsers</string>
</array>
```

## Android information and settings

- Preference Key name: IdleTimeoutActions
- Example value:

```
["close_browsers"]
```

## iOS information and settings

- Preference Key name: IdleTimeoutActions
- Example value:

```xml
<array>
  <string>close_browsers</string>
</array>
```