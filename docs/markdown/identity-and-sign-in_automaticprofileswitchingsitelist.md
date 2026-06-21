---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutomaticProfileSwitchingSiteList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/automaticprofileswitchingsitelist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the automatic profile switching site list'
locale: en-us
document_id: 979f9979-f6b7-8b3e-669e-62b0cb0927e0
document_version_independent_id: 979f9979-f6b7-8b3e-669e-62b0cb0927e0
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutomaticProfileSwitchingSiteList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AutomaticProfileSwitchingSiteList.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 397
asset_id: microsoft-edge-policies/automaticprofileswitchingsitelist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutomaticProfileSwitchingSiteList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 897cf671-eb3d-7401-3d46-af9970c042b7
---

# Microsoft Edge Browser Policy Documentation AutomaticProfileSwitchingSiteList | Microsoft Learn

## Configure the automatic profile switching site list

## Supported versions

- Windows: ≥ 120
- macOS: ≥ 120
- Android: Not supported
- iOS: Not supported

## Description

Sets this policy to control which profiles Microsoft Edge uses to open sites in. Switching configurations for sites listed in this policy takes precedence over other heuristics Microsoft Edge uses for switching sites; however, sites not listed on this policy are still subject to switching by those heuristics. If you don't configure this policy, Microsoft Edge continues using its heuristics to automatically switch sites.

This policy maps a URL hostname to a profile that's used to open the site.

The 'site' field takes the form of a URL hostname.

The 'profile' field can take one of the following values:

- 'Work': The most recently used Microsoft Entra signed-in profile is used to open a 'site'.
- 'Personal': The most recently used Microsoft Account (MSA) signed-in profile is used to open a 'site'.
- 'No preference': The currently used profile is used to open a 'site'.
- 'Wildcard email address': This takes the form of '\*@contoso.com'. A profile whose username ends with the contents following the '\*' is used to open a 'site'.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AutomaticProfileSwitchingSiteList
- GP name: Configure the automatic profile switching site list
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Identity and sign-in
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Identity and sign-in
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"profile": "Work", "site": "work.com"}, {"profile": "Personal", "site": "personal.com"}, {"profile": "No preference", "site": "nopreference.com"}, {"profile": "*@contoso.com", "site": "contoso.com"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AutomaticProfileSwitchingSiteList
- Value type: REG\_SZ

#### Example registry value

```
[{"profile": "Work", "site": "work.com"}, {"profile": "Personal", "site": "personal.com"}, {"profile": "No preference", "site": "nopreference.com"}, {"profile": "*@contoso.com", "site": "contoso.com"}]
```

#### Expanded example registry value

```
[
  {
    "profile": "Work",
    "site": "work.com"
  },
  {
    "profile": "Personal",
    "site": "personal.com"
  },
  {
    "profile": "No preference",
    "site": "nopreference.com"
  },
  {
    "profile": "*@contoso.com",
    "site": "contoso.com"
  }
]
```

## Mac information and settings

- Preference Key name: AutomaticProfileSwitchingSiteList
- Example value:

```xml
<key>AutomaticProfileSwitchingSiteList</key>
<array>
  <dict>
    <key>profile</key>
    <string>Work</string>
    <key>site</key>
    <string>work.com</string>
  </dict>
  <dict>
    <key>profile</key>
    <string>Personal</string>
    <key>site</key>
    <string>personal.com</string>
  </dict>
  <dict>
    <key>profile</key>
    <string>No preference</string>
    <key>site</key>
    <string>nopreference.com</string>
  </dict>
  <dict>
    <key>profile</key>
    <string>*@contoso.com</string>
    <key>site</key>
    <string>contoso.com</string>
  </dict>
</array>
```