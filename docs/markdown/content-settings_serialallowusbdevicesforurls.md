---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SerialAllowUsbDevicesForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/serialallowusbdevicesforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Automatically grant sites permission to connect to USB serial devices'
locale: en-us
document_id: 82e7d83a-3b26-401e-64ef-1bf409a419b7
document_version_independent_id: 82e7d83a-3b26-401e-64ef-1bf409a419b7
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SerialAllowUsbDevicesForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SerialAllowUsbDevicesForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 338
asset_id: microsoft-edge-policies/serialallowusbdevicesforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SerialAllowUsbDevicesForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2127cd20-6368-c733-7211-ae05faf9478a
---

# Microsoft Edge Browser Policy Documentation SerialAllowUsbDevicesForUrls | Microsoft Learn

## Automatically grant sites permission to connect to USB serial devices

## Supported versions

- Windows: ≥ 97
- macOS: ≥ 97
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy lets you list sites that are automatically granted permission to access USB serial devices with vendor and product IDs that match the vendor\_id and product\_id fields.

Optionally you can omit the product\_id field. This enables site access to the vendor's devices. When you provide a product ID, then you give the site access to a specific device from the vendor but not all devices.

The URLs must be valid, or the policy is ignored. Only the origin (scheme, host, and port) of the URL is considered.

This policy overrides [DefaultSerialGuardSetting](defaultserialguardsetting), [SerialAskForUrls](serialaskforurls), [SerialBlockedForUrls](serialblockedforurls), and the user's preferences.

This policy only affects access to USB devices through the Web Serial API. To grant access to USB devices through the WebUSB API, see the [WebUsbAllowDevicesForUrls](webusballowdevicesforurls) policy.

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

- GP unique name: SerialAllowUsbDevicesForUrls
- GP name: Automatically grant sites permission to connect to USB serial devices
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://specific-device.example.com"]}, {"devices": [{"vendor_id": 1234}], "urls": ["https://all-vendor-devices.example.com"]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: SerialAllowUsbDevicesForUrls
- Value type: REG\_SZ

#### Example registry value

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://specific-device.example.com"]}, {"devices": [{"vendor_id": 1234}], "urls": ["https://all-vendor-devices.example.com"]}]
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
      "https://specific-device.example.com"
    ]
  },
  {
    "devices": [
      {
        "vendor_id": 1234
      }
    ],
    "urls": [
      "https://all-vendor-devices.example.com"
    ]
  }
]
```

## Mac information and settings

- Preference Key name: SerialAllowUsbDevicesForUrls
- Example value:

```xml
<key>SerialAllowUsbDevicesForUrls</key>
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
      <string>https://specific-device.example.com</string>
    </array>
  </dict>
  <dict>
    <key>devices</key>
    <array>
      <dict>
        <key>vendor_id</key>
        <integer>1234</integer>
      </dict>
    </array>
    <key>urls</key>
    <array>
      <string>https://all-vendor-devices.example.com</string>
    </array>
  </dict>
</array>
```