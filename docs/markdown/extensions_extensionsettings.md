---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensionsettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure extension management settings'
locale: en-us
document_id: 5571b6a9-e0d5-53dd-5e9a-5cf35d61ea5b
document_version_independent_id: 5571b6a9-e0d5-53dd-5e9a-5cf35d61ea5b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/ExtensionSettings.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 889
asset_id: microsoft-edge-policies/extensionsettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionSettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f277fd72-10e4-410a-9269-cef21383854c
---

# Microsoft Edge Browser Policy Documentation ExtensionSettings | Microsoft Learn

## Configure extension management settings

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 135
- iOS: Not supported

## Description

Setting this policy controls extension management settings for Microsoft Edge, including those configured by other extension-related policies. This policy supersedes any legacy policies.

This policy maps an extension ID or update URL to a specific configuration. You can define a default configuration using the special ID "\*", which applies to extensions without a custom configuration.

Note that any per-ID extension setting from either [ExtensionInstallForcelist](extensioninstallforcelist), [ExtensionInstallAllowlist](extensioninstallallowlist), [ExtensionInstallBlocklist](extensioninstallblocklist), or [ExtensionSettings](extensionsettings) will only inherit 'installation\_mode' and 'update\_url' from the "\*" defaults. It will not inherit any other properties. With an update URL, configuration applies to extensions with the exact update URL stated in the extension manifest. If the 'override\_update\_url' flag is set to true, the extension is installed and updated using the update URL specified in the [ExtensionInstallForcelist](extensioninstallforcelist) policy or in 'update\_url' field in this policy. The flag 'override\_update\_url' is ignored if the 'update\_url' is the Edge Add-ons website update URL. For more details, check out the detailed guide to ExtensionSettings policy available at https://go.microsoft.com/fwlink/?linkid=2161555.

To block extensions from a particular third party store, you only need to block the update\_url for that store. For example, if you want to block extensions from Chrome Web Store, you can use the following JSON.

{"update\_url:https://clients2.google.com/service/update2/crx":{"installation\_mode":"blocked"}}

Note that you can still use [ExtensionInstallForcelist](extensioninstallforcelist) and [ExtensionInstallAllowlist](extensioninstallallowlist) to allow / force install specific extensions even if the store is blocked using the JSON in the previous example.

If the 'sidebar\_auto\_open\_blocked' flag is set to true in an extension's configuration, the hub-app (sidebar app) corresponding to the specified extension will be prevented from automatically opening.

On Windows instances, apps and extensions from outside the Microsoft Edge Add-ons website can only be forced installed if the instance is joined to a Microsoft Active Directory domain or joined to Microsoft Azure Active Directory®.

On macOS instances, apps and extensions from outside the Microsoft Edge Add-ons website can only be force installed if the instance is managed via MDM, joined to a domain via MCX.

Starting in Microsoft Edge version 149, the [Microsoft365CopilotChatIconEnabled](microsoft365copilotchaticonenabled) policy controls the display of Copilot in the toolbar.

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

- GP unique name: ExtensionSettings
- GP name: Configure extension management settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"*": {"allowed_types": ["hosted_app"], "blocked_install_message": "Custom error message.", "blocked_permissions": ["downloads", "bookmarks"], "install_sources": ["https://company-intranet/apps"], "installation_mode": "blocked", "runtime_allowed_hosts": ["*://good.contoso.com"], "runtime_blocked_hosts": ["*://*.contoso.com"]}, "abcdefghijklmnopabcdefghijklmnop": {"blocked_permissions": ["history"], "file_url_navigation_allowed": true, "installation_mode": "allowed", "minimum_version_required": "1.0.1"}, "bcdefghijklmnopabcdefghijklmnopa": {"allowed_permissions": ["downloads"], "installation_mode": "force_installed", "override_update_url": true, "runtime_allowed_hosts": ["*://good.contoso.com"], "runtime_blocked_hosts": ["*://*.contoso.com"], "sidebar_auto_open_blocked": true, "toolbar_state": "force_shown", "update_url": "https://contoso.com/update_url"}, "cdefghijklmnopabcdefghijklmnopab": {"blocked_install_message": "Custom error message.", "installation_mode": "blocked"}, "defghijklmnopabcdefghijklmnopabc,efghijklmnopabcdefghijklmnopabcd": {"blocked_install_message": "Custom error message.", "installation_mode": "blocked"}, "fghijklmnopabcdefghijklmnopabcde": {"blocked_install_message": "Custom removal message.", "installation_mode": "removed"}, "update_url:https://www.contoso.com/update.xml": {"allowed_permissions": ["downloads"], "blocked_permissions": ["wallpaper"], "installation_mode": "allowed"}}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ExtensionSettings
- Value type: REG\_SZ

#### Example registry value

```
{"*": {"allowed_types": ["hosted_app"], "blocked_install_message": "Custom error message.", "blocked_permissions": ["downloads", "bookmarks"], "install_sources": ["https://company-intranet/apps"], "installation_mode": "blocked", "runtime_allowed_hosts": ["*://good.contoso.com"], "runtime_blocked_hosts": ["*://*.contoso.com"]}, "abcdefghijklmnopabcdefghijklmnop": {"blocked_permissions": ["history"], "file_url_navigation_allowed": true, "installation_mode": "allowed", "minimum_version_required": "1.0.1"}, "bcdefghijklmnopabcdefghijklmnopa": {"allowed_permissions": ["downloads"], "installation_mode": "force_installed", "override_update_url": true, "runtime_allowed_hosts": ["*://good.contoso.com"], "runtime_blocked_hosts": ["*://*.contoso.com"], "sidebar_auto_open_blocked": true, "toolbar_state": "force_shown", "update_url": "https://contoso.com/update_url"}, "cdefghijklmnopabcdefghijklmnopab": {"blocked_install_message": "Custom error message.", "installation_mode": "blocked"}, "defghijklmnopabcdefghijklmnopabc,efghijklmnopabcdefghijklmnopabcd": {"blocked_install_message": "Custom error message.", "installation_mode": "blocked"}, "fghijklmnopabcdefghijklmnopabcde": {"blocked_install_message": "Custom removal message.", "installation_mode": "removed"}, "update_url:https://www.contoso.com/update.xml": {"allowed_permissions": ["downloads"], "blocked_permissions": ["wallpaper"], "installation_mode": "allowed"}}
```

#### Expanded example registry value

```
{
  "*": {
    "allowed_types": [
      "hosted_app"
    ],
    "blocked_install_message": "Custom error message.",
    "blocked_permissions": [
      "downloads",
      "bookmarks"
    ],
    "install_sources": [
      "https://company-intranet/apps"
    ],
    "installation_mode": "blocked",
    "runtime_allowed_hosts": [
      "*://good.contoso.com"
    ],
    "runtime_blocked_hosts": [
      "*://*.contoso.com"
    ]
  },
  "abcdefghijklmnopabcdefghijklmnop": {
    "blocked_permissions": [
      "history"
    ],
    "file_url_navigation_allowed": true,
    "installation_mode": "allowed",
    "minimum_version_required": "1.0.1"
  },
  "bcdefghijklmnopabcdefghijklmnopa": {
    "allowed_permissions": [
      "downloads"
    ],
    "installation_mode": "force_installed",
    "override_update_url": true,
    "runtime_allowed_hosts": [
      "*://good.contoso.com"
    ],
    "runtime_blocked_hosts": [
      "*://*.contoso.com"
    ],
    "sidebar_auto_open_blocked": true,
    "toolbar_state": "force_shown",
    "update_url": "https://contoso.com/update_url"
  },
  "cdefghijklmnopabcdefghijklmnopab": {
    "blocked_install_message": "Custom error message.",
    "installation_mode": "blocked"
  },
  "defghijklmnopabcdefghijklmnopabc,efghijklmnopabcdefghijklmnopabcd": {
    "blocked_install_message": "Custom error message.",
    "installation_mode": "blocked"
  },
  "fghijklmnopabcdefghijklmnopabcde": {
    "blocked_install_message": "Custom removal message.",
    "installation_mode": "removed"
  },
  "update_url:https://www.contoso.com/update.xml": {
    "allowed_permissions": [
      "downloads"
    ],
    "blocked_permissions": [
      "wallpaper"
    ],
    "installation_mode": "allowed"
  }
}
```

## Mac information and settings

- Preference Key name: ExtensionSettings
- Example value:

```xml
<key>ExtensionSettings</key>
<dict>
  <key>*</key>
  <dict>
    <key>allowed_types</key>
    <array>
      <string>hosted_app</string>
    </array>
    <key>blocked_install_message</key>
    <string>Custom error message.</string>
    <key>blocked_permissions</key>
    <array>
      <string>downloads</string>
      <string>bookmarks</string>
    </array>
    <key>install_sources</key>
    <array>
      <string>https://company-intranet/apps</string>
    </array>
    <key>installation_mode</key>
    <string>blocked</string>
    <key>runtime_allowed_hosts</key>
    <array>
      <string>*://good.contoso.com</string>
    </array>
    <key>runtime_blocked_hosts</key>
    <array>
      <string>*://*.contoso.com</string>
    </array>
  </dict>
  <key>abcdefghijklmnopabcdefghijklmnop</key>
  <dict>
    <key>blocked_permissions</key>
    <array>
      <string>history</string>
    </array>
    <key>file_url_navigation_allowed</key>
    <true/>
    <key>installation_mode</key>
    <string>allowed</string>
    <key>minimum_version_required</key>
    <string>1.0.1</string>
  </dict>
  <key>bcdefghijklmnopabcdefghijklmnopa</key>
  <dict>
    <key>allowed_permissions</key>
    <array>
      <string>downloads</string>
    </array>
    <key>installation_mode</key>
    <string>force_installed</string>
    <key>override_update_url</key>
    <true/>
    <key>runtime_allowed_hosts</key>
    <array>
      <string>*://good.contoso.com</string>
    </array>
    <key>runtime_blocked_hosts</key>
    <array>
      <string>*://*.contoso.com</string>
    </array>
    <key>sidebar_auto_open_blocked</key>
    <true/>
    <key>toolbar_state</key>
    <string>force_shown</string>
    <key>update_url</key>
    <string>https://contoso.com/update_url</string>
  </dict>
  <key>cdefghijklmnopabcdefghijklmnopab</key>
  <dict>
    <key>blocked_install_message</key>
    <string>Custom error message.</string>
    <key>installation_mode</key>
    <string>blocked</string>
  </dict>
  <key>defghijklmnopabcdefghijklmnopabc,efghijklmnopabcdefghijklmnopabcd</key>
  <dict>
    <key>blocked_install_message</key>
    <string>Custom error message.</string>
    <key>installation_mode</key>
    <string>blocked</string>
  </dict>
  <key>fghijklmnopabcdefghijklmnopabcde</key>
  <dict>
    <key>blocked_install_message</key>
    <string>Custom removal message.</string>
    <key>installation_mode</key>
    <string>removed</string>
  </dict>
  <key>update_url:https://www.contoso.com/update.xml</key>
  <dict>
    <key>allowed_permissions</key>
    <array>
      <string>downloads</string>
    </array>
    <key>blocked_permissions</key>
    <array>
      <string>wallpaper</string>
    </array>
    <key>installation_mode</key>
    <string>allowed</string>
  </dict>
</dict>
```

## Android information and settings

- Preference Key name: ExtensionSettings
- Example value:

```
{"*": {"allowed_types": ["hosted_app"], "blocked_install_message": "Custom error message.", "blocked_permissions": ["downloads", "bookmarks"], "install_sources": ["https://company-intranet/apps"], "installation_mode": "blocked", "runtime_allowed_hosts": ["*://good.contoso.com"], "runtime_blocked_hosts": ["*://*.contoso.com"]}, "abcdefghijklmnopabcdefghijklmnop": {"blocked_permissions": ["history"], "file_url_navigation_allowed": true, "installation_mode": "allowed", "minimum_version_required": "1.0.1"}, "bcdefghijklmnopabcdefghijklmnopa": {"allowed_permissions": ["downloads"], "installation_mode": "force_installed", "override_update_url": true, "runtime_allowed_hosts": ["*://good.contoso.com"], "runtime_blocked_hosts": ["*://*.contoso.com"], "sidebar_auto_open_blocked": true, "toolbar_state": "force_shown", "update_url": "https://contoso.com/update_url"}, "cdefghijklmnopabcdefghijklmnopab": {"blocked_install_message": "Custom error message.", "installation_mode": "blocked"}, "defghijklmnopabcdefghijklmnopabc,efghijklmnopabcdefghijklmnopabcd": {"blocked_install_message": "Custom error message.", "installation_mode": "blocked"}, "fghijklmnopabcdefghijklmnopabcde": {"blocked_install_message": "Custom removal message.", "installation_mode": "removed"}, "update_url:https://www.contoso.com/update.xml": {"allowed_permissions": ["downloads"], "blocked_permissions": ["wallpaper"], "installation_mode": "allowed"}}
```