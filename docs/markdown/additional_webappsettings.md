---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebAppSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webappsettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Web App management settings'
locale: en-us
document_id: 4484b5db-8b73-7d95-6558-11398226f9fa
document_version_independent_id: 4484b5db-8b73-7d95-6558-11398226f9fa
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebAppSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/WebAppSettings.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 560
asset_id: microsoft-edge-policies/webappsettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebAppSettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/7ebba99b-05c3-4387-8883-f7bbf6632cb8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/006ab567-b18c-4cf1-9a25-c24daa46ede1
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1abb857d-7c30-0585-8e70-a6011548106c
---

# Microsoft Edge Browser Policy Documentation WebAppSettings | Microsoft Learn

## Web App management settings

## Supported versions

- Windows: ≥ 120
- macOS: ≥ 120
- Android: Not supported
- iOS: Not supported

## Description

This policy allows an admin to specify settings for installed web apps. This policy maps a Web App ID to its specific setting. A default configuration can be set using the special ID \*, which applies to all web apps without a custom configuration in this policy.

- The manifest\_id field is the Manifest ID for the Web App. See https://developer.chrome.com/blog/pwa-manifest-id/ for instructions on how to determine the Manifest ID for an installed web app.
- The run\_on\_os\_login field specifies if a web app can be run during OS sign in. If you set this field to blocked, the web app doesn't run during OS sign in, and the user can't enable this later. If you set this field to run\_windowed, the web app runs during OS sign in, and the user can't disable this later. If you set this field to allowed, the user configures the web app to run at OS sign in. The default policy configuration only allows the allowed and blocked values.
- (Starting with Microsoft Edge version 120) The prevent\_close\_after\_run\_on\_os\_login field specifies if a web app can be prevented from closing in any way. For example, by the user, by task manager, or by web APIs. This behavior can only be enabled if run\_on\_os\_login is set to run\_windowed. If the app is already running, this setting will only take effect after the app is restarted. If this field isn't defined, users can close the app. (This is currently not supported in Microsoft Edge.)
- (Since version 118) The force\_unregister\_os\_integration field specifies if all OS integration for a web app, that is, shortcuts, file handlers, protocol handlers and so on, will be removed or not. If an app is already running, this property comes into effect after the app restarts. This should be used with caution, since it can override any OS integration that is set automatically during the startup of the web applications system. This currently only works on Windows, Mac and Linux platforms.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebAppSettings
- GP name: Web App management settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"manifest_id": "https://foo.example/index.html", "run_on_os_login": "allowed"}, {"manifest_id": "https://bar.example/index.html", "run_on_os_login": "allowed"}, {"manifest_id": "https://foobar.example/index.html", "prevent_close_after_run_on_os_login": true, "run_on_os_login": "run_windowed"}, {"manifest_id": "*", "run_on_os_login": "blocked"}, {"force_unregister_os_integration": true, "manifest_id": "https://foo.example/index.html"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebAppSettings
- Value type: REG\_SZ

#### Example registry value

```
[{"manifest_id": "https://foo.example/index.html", "run_on_os_login": "allowed"}, {"manifest_id": "https://bar.example/index.html", "run_on_os_login": "allowed"}, {"manifest_id": "https://foobar.example/index.html", "prevent_close_after_run_on_os_login": true, "run_on_os_login": "run_windowed"}, {"manifest_id": "*", "run_on_os_login": "blocked"}, {"force_unregister_os_integration": true, "manifest_id": "https://foo.example/index.html"}]
```

#### Expanded example registry value

```
[
  {
    "manifest_id": "https://foo.example/index.html",
    "run_on_os_login": "allowed"
  },
  {
    "manifest_id": "https://bar.example/index.html",
    "run_on_os_login": "allowed"
  },
  {
    "manifest_id": "https://foobar.example/index.html",
    "prevent_close_after_run_on_os_login": true,
    "run_on_os_login": "run_windowed"
  },
  {
    "manifest_id": "*",
    "run_on_os_login": "blocked"
  },
  {
    "force_unregister_os_integration": true,
    "manifest_id": "https://foo.example/index.html"
  }
]
```

## Mac information and settings

- Preference Key name: WebAppSettings
- Example value:

```xml
<key>WebAppSettings</key>
<array>
  <dict>
    <key>manifest_id</key>
    <string>https://foo.example/index.html</string>
    <key>run_on_os_login</key>
    <string>allowed</string>
  </dict>
  <dict>
    <key>manifest_id</key>
    <string>https://bar.example/index.html</string>
    <key>run_on_os_login</key>
    <string>allowed</string>
  </dict>
  <dict>
    <key>manifest_id</key>
    <string>https://foobar.example/index.html</string>
    <key>prevent_close_after_run_on_os_login</key>
    <true/>
    <key>run_on_os_login</key>
    <string>run_windowed</string>
  </dict>
  <dict>
    <key>manifest_id</key>
    <string>*</string>
    <key>run_on_os_login</key>
    <string>blocked</string>
  </dict>
  <dict>
    <key>force_unregister_os_integration</key>
    <true/>
    <key>manifest_id</key>
    <string>https://foo.example/index.html</string>
  </dict>
</array>
```