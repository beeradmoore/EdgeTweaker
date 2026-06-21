---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebHidAllowDevicesForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webhidallowdevicesforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow listed sites connect to specific HID devices'
locale: en-us
document_id: 8d084d36-025a-7e19-569c-ce9c6c2f15f7
document_version_independent_id: 8d084d36-025a-7e19-569c-ce9c6c2f15f7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebHidAllowDevicesForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebHidAllowDevicesForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 338
asset_id: microsoft-edge-policies/webhidallowdevicesforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebHidAllowDevicesForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1a6f0c69-81f8-cf62-43fe-fe0d9e93c120
---

# Microsoft Edge Browser Policy Documentation WebHidAllowDevicesForUrls | Microsoft Learn

## Allow listed sites connect to specific HID devices

## Supported versions

- Windows: ≥ 109
- macOS: ≥ 109
- Android: Not supported
- iOS: Not supported

## Description

This setting lets you list the URLs that specify which sites are automatically granted permission to access a HID device with the given vendor and product IDs.

If you set this policy, each item in the list requires both devices and urls fields for the item to be valid; otherwise, the item is ignored.

- Each item in the devices field must have a vendor\_id and may have a product\_id field.
- Omitting the product\_id field will create a policy matching any device with the specified vendor ID.
- An item which has a product\_id field without a vendor\_id field is invalid and is ignored.

If you don't set this policy, then [DefaultWebHidGuardSetting](defaultwebhidguardsetting) applies, if it's set. If not, the user's personal setting applies.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* isn't an accepted value for this policy.

URLs in this policy shouldn't conflict with those configured through [WebHidBlockedForUrls](webhidblockedforurls). If they do, this policy takes precedence over [WebHidBlockedForUrls](webhidblockedforurls).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Dictionary

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebHidAllowDevicesForUrls
- GP name: Allow listed sites connect to specific HID devices
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://microsoft.com", "https://chromium.org"]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebHidAllowDevicesForUrls
- Value type: REG\_SZ

#### Example registry value

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://microsoft.com", "https://chromium.org"]}]
```

#### Expanded example registry value

```
[
  {
    "devices": [
      {
        "product_id": 5678,
        "vendor_id": 1234
      }
    ],
    "urls": [
      "https://microsoft.com",
      "https://chromium.org"
    ]
  }
]
```

## Mac information and settings

- Preference Key name: WebHidAllowDevicesForUrls
- Example value:

```xml
<key>WebHidAllowDevicesForUrls</key>
<array>
  <dict>
    <key>devices</key>
    <array>
      <dict>
        <key>product_id</key>
        <integer>5678</integer>
        <key>vendor_id</key>
        <integer>1234</integer>
      </dict>
    </array>
    <key>urls</key>
    <array>
      <string>https://microsoft.com</string>
      <string>https://chromium.org</string>
    </array>
  </dict>
</array>
```