---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ManagedFavorites | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/managedfavorites
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure favorites'
locale: en-us
document_id: b0712466-a119-5bdd-e595-90d78bfaf946
document_version_independent_id: b0712466-a119-5bdd-e595-90d78bfaf946
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ManagedFavorites.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ManagedFavorites.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 517
asset_id: microsoft-edge-policies/managedfavorites
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ManagedFavorites.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 426dc927-9321-a3be-63a3-af658ce395dd
---

# Microsoft Edge Browser Policy Documentation ManagedFavorites | Microsoft Learn

## Configure favorites

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 30
- iOS: ≥ 85

## Description

Configures a list of managed favorites.

The policy creates a list of favorites. Each favorite contains the keys "name" and "url," which hold the favorite's name and its target. You can configure a subfolder by defining a favorite without an "url" key but with an extra "children" key that contains a list of favorites as defined earlier (some of which may be folders again). Microsoft Edge amends incomplete URLs as if they were submitted via the Address Bar, for example "microsoft.com" becomes "https://microsoft.com/".

These favorites are placed in a folder that can't be modified by the user (but the user can choose to hide it from the favorites bar). By default the folder name is "Managed favorites" but you can change it by adding to the list of favorites a dictionary containing the key "toplevel\_name" with the desired folder name as the value.

Managed favorites aren't synced to the user account and can't be modified by extensions.

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

- GP unique name: ManagedFavorites
- GP name: Configure favorites
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"toplevel_name": "My managed favorites folder"}, {"name": "Microsoft", "url": "microsoft.com"}, {"name": "Bing", "url": "bing.com"}, {"children": [{"name": "Microsoft Edge Insiders", "url": "www.microsoftedgeinsider.com"}, {"name": "Microsoft Edge", "url": "www.microsoft.com/windows/microsoft-edge"}], "name": "Microsoft Edge links"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ManagedFavorites
- Value type: REG\_SZ

#### Example registry value

```
[{"toplevel_name": "My managed favorites folder"}, {"name": "Microsoft", "url": "microsoft.com"}, {"name": "Bing", "url": "bing.com"}, {"children": [{"name": "Microsoft Edge Insiders", "url": "www.microsoftedgeinsider.com"}, {"name": "Microsoft Edge", "url": "www.microsoft.com/windows/microsoft-edge"}], "name": "Microsoft Edge links"}]
```

#### Expanded example registry value

```
[
  {
    "toplevel_name": "My managed favorites folder"
  },
  {
    "name": "Microsoft",
    "url": "microsoft.com"
  },
  {
    "name": "Bing",
    "url": "bing.com"
  },
  {
    "children": [
      {
        "name": "Microsoft Edge Insiders",
        "url": "www.microsoftedgeinsider.com"
      },
      {
        "name": "Microsoft Edge",
        "url": "www.microsoft.com/windows/microsoft-edge"
      }
    ],
    "name": "Microsoft Edge links"
  }
]
```

## Mac information and settings

- Preference Key name: ManagedFavorites
- Example value:

```xml
<key>ManagedFavorites</key>
<array>
  <dict>
    <key>toplevel_name</key>
    <string>My managed favorites folder</string>
  </dict>
  <dict>
    <key>name</key>
    <string>Microsoft</string>
    <key>url</key>
    <string>microsoft.com</string>
  </dict>
  <dict>
    <key>name</key>
    <string>Bing</string>
    <key>url</key>
    <string>bing.com</string>
  </dict>
  <dict>
    <key>children</key>
    <array>
      <dict>
        <key>name</key>
        <string>Microsoft Edge Insiders</string>
        <key>url</key>
        <string>www.microsoftedgeinsider.com</string>
      </dict>
      <dict>
        <key>name</key>
        <string>Microsoft Edge</string>
        <key>url</key>
        <string>www.microsoft.com/windows/microsoft-edge</string>
      </dict>
    </array>
    <key>name</key>
    <string>Microsoft Edge links</string>
  </dict>
</array>
```

## Android information and settings

- Preference Key name: ManagedFavorites
- Example value:

```
[{"toplevel_name": "My managed favorites folder"}, {"name": "Microsoft", "url": "microsoft.com"}, {"name": "Bing", "url": "bing.com"}, {"children": [{"name": "Microsoft Edge Insiders", "url": "www.microsoftedgeinsider.com"}, {"name": "Microsoft Edge", "url": "www.microsoft.com/windows/microsoft-edge"}], "name": "Microsoft Edge links"}]
```

## iOS information and settings

- Preference Key name: ManagedFavorites
- Example value:

```xml
<key>ManagedFavorites</key>
<array>
  <dict>
    <key>toplevel_name</key>
    <string>My managed favorites folder</string>
  </dict>
  <dict>
    <key>name</key>
    <string>Microsoft</string>
    <key>url</key>
    <string>microsoft.com</string>
  </dict>
  <dict>
    <key>name</key>
    <string>Bing</string>
    <key>url</key>
    <string>bing.com</string>
  </dict>
  <dict>
    <key>children</key>
    <array>
      <dict>
        <key>name</key>
        <string>Microsoft Edge Insiders</string>
        <key>url</key>
        <string>www.microsoftedgeinsider.com</string>
      </dict>
      <dict>
        <key>name</key>
        <string>Microsoft Edge</string>
        <key>url</key>
        <string>www.microsoft.com/windows/microsoft-edge</string>
      </dict>
    </array>
    <key>name</key>
    <string>Microsoft Edge links</string>
  </dict>
</array>
```