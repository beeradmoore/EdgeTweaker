---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WorkspacesNavigationSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/workspacesnavigationsettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure navigation settings per groups of URLs in Microsoft Edge Workspaces'
locale: en-us
document_id: 1280469f-eb28-365f-3922-6249a9846f60
document_version_independent_id: 1280469f-eb28-365f-3922-6249a9846f60
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WorkspacesNavigationSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WorkspacesNavigationSettings.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 382
asset_id: microsoft-edge-policies/workspacesnavigationsettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WorkspacesNavigationSettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b85a9564-4441-4f5f-15e5-65968d976e78
---

# Microsoft Edge Browser Policy Documentation WorkspacesNavigationSettings | Microsoft Learn

## Configure navigation settings per groups of URLs in Microsoft Edge Workspaces

## Supported versions

- Windows: ≥ 110
- macOS: ≥ 110
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you define groups of URLs, and apply specific Microsoft Edge Workspaces navigation settings to each group.

If you configure this policy, Microsoft Edge Workspaces use the configured settings when deciding whether and how to share navigations among collaborators in a Microsoft Edge Workspace.

If you don't configure this policy, Microsoft Edge Workspaces use only default and internally configured navigation settings.

For more information about configuration options, see https://go.microsoft.com/fwlink/?linkid=2218655

Note, format url\_patterns according to https://go.microsoft.com/fwlink/?linkid=2095322. You can configure the url\_regex\_patterns in this policy to match multiple URLs using a Perl style regular expression for the pattern. Note that pattern matches are case sensitive. For more information about the regular expression rules that are used, refer to https://go.microsoft.com/fwlink/p/?linkid=2133903.

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

- GP unique name: WorkspacesNavigationSettings
- GP name: Configure navigation settings per groups of URLs in Microsoft Edge Workspaces
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Edge Workspaces settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"navigation_options": {"do_not_send_to": true, "remove_all_query_parameters": true}, "url_patterns": ["https://contoso.com", "https://www.fabrikam.com", ".exact.hostname.com"]}, {"navigation_options": {"query_parameters_to_remove": ["username", "login_hint"]}, "url_patterns": ["https://adatum.com"]}, {"navigation_options": {"do_not_send_from": true, "prefer_initial_url": true}, "url_regex_patterns": ["\\Ahttps://.*?tafe\\..*?trs.*?\\.fabrikam.com/Sts"]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WorkspacesNavigationSettings
- Value type: REG\_SZ

#### Example registry value

```
[{"navigation_options": {"do_not_send_to": true, "remove_all_query_parameters": true}, "url_patterns": ["https://contoso.com", "https://www.fabrikam.com", ".exact.hostname.com"]}, {"navigation_options": {"query_parameters_to_remove": ["username", "login_hint"]}, "url_patterns": ["https://adatum.com"]}, {"navigation_options": {"do_not_send_from": true, "prefer_initial_url": true}, "url_regex_patterns": ["\\Ahttps://.*?tafe\\..*?trs.*?\\.fabrikam.com/Sts"]}]
```

#### Expanded example registry value

```
[
  {
    "navigation_options": {
      "do_not_send_to": true,
      "remove_all_query_parameters": true
    },
    "url_patterns": [
      "https://contoso.com",
      "https://www.fabrikam.com",
      ".exact.hostname.com"
    ]
  },
  {
    "navigation_options": {
      "query_parameters_to_remove": [
        "username",
        "login_hint"
      ]
    },
    "url_patterns": [
      "https://adatum.com"
    ]
  },
  {
    "navigation_options": {
      "do_not_send_from": true,
      "prefer_initial_url": true
    },
    "url_regex_patterns": [
      "\\Ahttps://.*?tafe\\..*?trs.*?\\.fabrikam.com/Sts"
    ]
  }
]
```

## Mac information and settings

- Preference Key name: WorkspacesNavigationSettings
- Example value:

```xml
<key>WorkspacesNavigationSettings</key>
<array>
  <dict>
    <key>navigation_options</key>
    <dict>
      <key>do_not_send_to</key>
      <true/>
      <key>remove_all_query_parameters</key>
      <true/>
    </dict>
    <key>url_patterns</key>
    <array>
      <string>https://contoso.com</string>
      <string>https://www.fabrikam.com</string>
      <string>.exact.hostname.com</string>
    </array>
  </dict>
  <dict>
    <key>navigation_options</key>
    <dict>
      <key>query_parameters_to_remove</key>
      <array>
        <string>username</string>
        <string>login_hint</string>
      </array>
    </dict>
    <key>url_patterns</key>
    <array>
      <string>https://adatum.com</string>
    </array>
  </dict>
  <dict>
    <key>navigation_options</key>
    <dict>
      <key>do_not_send_from</key>
      <true/>
      <key>prefer_initial_url</key>
      <true/>
    </dict>
    <key>url_regex_patterns</key>
    <array>
      <string>\Ahttps://.*?tafe\..*?trs.*?\.fabrikam.com/Sts</string>
    </array>
  </dict>
</array>
```