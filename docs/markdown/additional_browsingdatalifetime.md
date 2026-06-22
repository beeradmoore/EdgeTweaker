---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BrowsingDataLifetime | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/browsingdatalifetime
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Browsing Data Lifetime Settings'
locale: en-us
document_id: a9a62724-6466-b870-687f-f792783b99e3
document_version_independent_id: a9a62724-6466-b870-687f-f792783b99e3
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BrowsingDataLifetime.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/BrowsingDataLifetime.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 283
asset_id: microsoft-edge-policies/browsingdatalifetime
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BrowsingDataLifetime.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4a743f86-3ef9-a1bf-0baa-209b67530d77
---

# Microsoft Edge Browser Policy Documentation BrowsingDataLifetime | Microsoft Learn

## Browsing Data Lifetime Settings

## Supported versions

- Windows: ≥ 89
- macOS: ≥ 89
- Android: ≥ 96
- iOS: Not supported

## Description

This policy controls how long specific types of browsing data are retained. If Sync is enabled, this policy has no effect.

You can specify the following data types: 'browsing\_history' 'download\_history' 'cookies\_and\_other\_site\_data' 'cached\_images\_and\_files' 'password\_signin' 'autofill' 'site\_settings' 'hosted\_app\_data'

Microsoft Edge periodically deletes data of the selected types that's older than the value set by 'time\_to\_live\_in\_hours'.

Expired data is removed 15 seconds after browser startup and every hour while the browser is running.

Note: Deleting cookies using this policy doesn't sign the user out of their profile, the user stays signed in.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: BrowsingDataLifetime
- GP name: Browsing Data Lifetime Settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"data_types": ["browsing_history"], "time_to_live_in_hours": 24}, {"data_types": ["password_signin", "autofill"], "time_to_live_in_hours": 12}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: BrowsingDataLifetime
- Value type: REG\_SZ

#### Example registry value

```
[{"data_types": ["browsing_history"], "time_to_live_in_hours": 24}, {"data_types": ["password_signin", "autofill"], "time_to_live_in_hours": 12}]
```

#### Expanded example registry value

```
[
  {
    "data_types": [
      "browsing_history"
    ],
    "time_to_live_in_hours": 24
  },
  {
    "data_types": [
      "password_signin",
      "autofill"
    ],
    "time_to_live_in_hours": 12
  }
]
```

## Mac information and settings

- Preference Key name: BrowsingDataLifetime
- Example value:

```xml
<key>BrowsingDataLifetime</key>
<array>
  <dict>
    <key>data_types</key>
    <array>
      <string>browsing_history</string>
    </array>
    <key>time_to_live_in_hours</key>
    <integer>24</integer>
  </dict>
  <dict>
    <key>data_types</key>
    <array>
      <string>password_signin</string>
      <string>autofill</string>
    </array>
    <key>time_to_live_in_hours</key>
    <integer>12</integer>
  </dict>
</array>
```

## Android information and settings

- Preference Key name: BrowsingDataLifetime
- Example value:

```
[{"data_types": ["browsing_history"], "time_to_live_in_hours": 24}, {"data_types": ["password_signin", "autofill"], "time_to_live_in_hours": 12}]
```