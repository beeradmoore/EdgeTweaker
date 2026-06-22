---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebAppInstallForceList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webappinstallforcelist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure list of force-installed Web Apps'
locale: en-us
document_id: aad8bd39-419f-17d2-92e4-d8ff2315458d
document_version_independent_id: aad8bd39-419f-17d2-92e4-d8ff2315458d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebAppInstallForceList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/WebAppInstallForceList.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 591
asset_id: microsoft-edge-policies/webappinstallforcelist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebAppInstallForceList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/7ebba99b-05c3-4387-8883-f7bbf6632cb8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/006ab567-b18c-4cf1-9a25-c24daa46ede1
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: bde9ecee-1a86-6741-b2f4-1db6e0aca900
---

# Microsoft Edge Browser Policy Documentation WebAppInstallForceList | Microsoft Learn

## Configure list of force-installed Web Apps

## Supported versions

- Windows: ≥ 80
- macOS: ≥ 80
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy specifies a list of web apps that install silently, without user interaction. Users can't turn off the policy or uninstall these web apps.

Each list item of the policy is an object with a mandatory member: url (the URL of the web app to install)

and 6 optional members:

- default\_launch\_container (for how the web app opens—a new tab is the default)
- create\_desktop\_shortcut (True if you want to create Linux and Microsoft Windows desktop shortcuts).
- fallback\_app\_name (Starting with Microsoft Edge version 90, you can permanently override the app name if it's not a Progressive Web App (PWA) or you can temporarily override the app name if authentication is required before installation can be completed. If both custom\_name and fallback\_app\_name are provided, the latter is ignored.)
- custom\_name (Starting with Microsoft Edge version 112 on all desktop platforms, you can permanently override the app name for all web apps and PWAs.)
- custom\_icon (Starting with Microsoft Edge version 112 on all desktop platforms, you can override the app icon of installed apps. The icons have to be square, maximal 1 MB in size, and in one of the following formats: jpeg, png, gif, webp, ico. The hash value has to be the SHA256 hash of the icon file. The url should be accessible without authentication to ensure that the icon can be used upon app installation.)
- install\_as\_shortcut (Starting with Microsoft Edge version 107). If enabled, the given url is installed as a shortcut, as if done via the "Create Shortcut..." option in the desktop browser GUI. When installed as a shortcut, it won't be updated if the manifest in url changes. If disabled or unset, the web app at the given url is installed normally. (This isn't currently supported in Microsoft Edge.)

The 'WebAppInstallByUserEnabled' policy doesn't affect this policy. Web apps specified by this policy are installed regardless of the 'WebAppInstallByUserEnabled' policy setting.

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

- GP unique name: WebAppInstallForceList
- GP name: Configure list of force-installed Web Apps
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"create_desktop_shortcut": true, "default_launch_container": "window", "url": "https://www.contoso.com/maps"}, {"default_launch_container": "tab", "url": "https://app.contoso.edu"}, {"default_launch_container": "window", "fallback_app_name": "Editor", "url": "https://app.contoso.edu/editor"}, {"custom_name": "Spreadsheets", "default_launch_container": "window", "install_as_shortcut": true, "url": "https://app.contoso.edu/sheets"}, {"custom_icon": {"hash": "c28f469c450e9ab2b86ea47038d2b324c6ad3b1e9a4bd8960da13214afd0ca38", "url": "https://mydomain.example.com/sunny_icon.png"}, "url": "https://weather.example.com"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebAppInstallForceList
- Value type: REG\_SZ

#### Example registry value

```
[{"create_desktop_shortcut": true, "default_launch_container": "window", "url": "https://www.contoso.com/maps"}, {"default_launch_container": "tab", "url": "https://app.contoso.edu"}, {"default_launch_container": "window", "fallback_app_name": "Editor", "url": "https://app.contoso.edu/editor"}, {"custom_name": "Spreadsheets", "default_launch_container": "window", "install_as_shortcut": true, "url": "https://app.contoso.edu/sheets"}, {"custom_icon": {"hash": "c28f469c450e9ab2b86ea47038d2b324c6ad3b1e9a4bd8960da13214afd0ca38", "url": "https://mydomain.example.com/sunny_icon.png"}, "url": "https://weather.example.com"}]
```

#### Expanded example registry value

```
[
  {
    "create_desktop_shortcut": true,
    "default_launch_container": "window",
    "url": "https://www.contoso.com/maps"
  },
  {
    "default_launch_container": "tab",
    "url": "https://app.contoso.edu"
  },
  {
    "default_launch_container": "window",
    "fallback_app_name": "Editor",
    "url": "https://app.contoso.edu/editor"
  },
  {
    "custom_name": "Spreadsheets",
    "default_launch_container": "window",
    "install_as_shortcut": true,
    "url": "https://app.contoso.edu/sheets"
  },
  {
    "custom_icon": {
      "hash": "c28f469c450e9ab2b86ea47038d2b324c6ad3b1e9a4bd8960da13214afd0ca38",
      "url": "https://mydomain.example.com/sunny_icon.png"
    },
    "url": "https://weather.example.com"
  }
]
```

## Mac information and settings

- Preference Key name: WebAppInstallForceList
- Example value:

```xml
<key>WebAppInstallForceList</key>
<array>
  <dict>
    <key>create_desktop_shortcut</key>
    <true/>
    <key>default_launch_container</key>
    <string>window</string>
    <key>url</key>
    <string>https://www.contoso.com/maps</string>
  </dict>
  <dict>
    <key>default_launch_container</key>
    <string>tab</string>
    <key>url</key>
    <string>https://app.contoso.edu</string>
  </dict>
  <dict>
    <key>default_launch_container</key>
    <string>window</string>
    <key>fallback_app_name</key>
    <string>Editor</string>
    <key>url</key>
    <string>https://app.contoso.edu/editor</string>
  </dict>
  <dict>
    <key>custom_name</key>
    <string>Spreadsheets</string>
    <key>default_launch_container</key>
    <string>window</string>
    <key>install_as_shortcut</key>
    <true/>
    <key>url</key>
    <string>https://app.contoso.edu/sheets</string>
  </dict>
  <dict>
    <key>custom_icon</key>
    <dict>
      <key>hash</key>
      <string>c28f469c450e9ab2b86ea47038d2b324c6ad3b1e9a4bd8960da13214afd0ca38</string>
      <key>url</key>
      <string>https://mydomain.example.com/sunny_icon.png</string>
    </dict>
    <key>url</key>
    <string>https://weather.example.com</string>
  </dict>
</array>
```