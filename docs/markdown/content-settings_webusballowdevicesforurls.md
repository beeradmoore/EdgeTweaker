---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebUsbAllowDevicesForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webusballowdevicesforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Grant access to specific sites to connect to specific USB devices'
locale: en-us
document_id: d6b0aa10-f146-bb28-c063-ec8b0f5f1054
document_version_independent_id: d6b0aa10-f146-bb28-c063-ec8b0f5f1054
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebUsbAllowDevicesForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebUsbAllowDevicesForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 514
asset_id: microsoft-edge-policies/webusballowdevicesforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebUsbAllowDevicesForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7817ee6b-c786-1b91-b926-55029a0a7a5b
---

# Microsoft Edge Browser Policy Documentation WebUsbAllowDevicesForUrls | Microsoft Learn

## Grant access to specific sites to connect to specific USB devices

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Allows you to set a list of URLs that specify which sites will automatically be granted permission to access a USB device with the given vendor and product IDs. Each item in the list must contain both devices and URLs for the policy to be valid. Each item in devices can contain a vendor ID and product ID field. Any ID that is omitted is treated as a wildcard with one exception, and that exception is that a product ID can't be specified without a vendor ID also being specified. Otherwise, the policy isn't valid and is ignored.

The USB permission model uses the URL of the requesting site ("requesting URL") and the URL of the top-level frame site ("embedding URL") to grant permission to the requesting URL to access the USB device. The requesting URL may be different than the embedding URL when the requesting site is loaded in an iframe. Therefore, the "urls" field can contain up to two URL strings delimited by a comma to specify the requesting and embedding URL respectively. If only one URL is specified, then access to the corresponding USB devices is granted when the requesting site's URL matches this URL regardless of embedding status. The URLs in "urls" must be valid URLs; otherwise, the policy is ignored.

This is deprecated and only supported for backwards compatibility in the following manner. If both a requesting and embedding URL are specified, then the embedding URL is granted the permission as top-level origin, and the requesting URL is ignored entirely.

If you don't configure this policy, the global default value is used for all sites either from the [DefaultWebUsbGuardSetting](defaultwebusbguardsetting) policy if it is set, or the user's personal configuration otherwise.

URL patterns in this policy shouldn't clash with the ones configured via [WebUsbBlockedForUrls](webusbblockedforurls). If there's a clash, this policy takes precedence over [WebUsbBlockedForUrls](webusbblockedforurls) and [WebUsbAskForUrls](webusbaskforurls).

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

- GP unique name: WebUsbAllowDevicesForUrls
- GP name: Grant access to specific sites to connect to specific USB devices
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://contoso.com", "https://fabrikam.com"]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebUsbAllowDevicesForUrls
- Value type: REG\_SZ

#### Example registry value

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://contoso.com", "https://fabrikam.com"]}]
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
      "https://contoso.com",
      "https://fabrikam.com"
    ]
  }
]
```

## Mac information and settings

- Preference Key name: WebUsbAllowDevicesForUrls
- Example value:

```xml
<key>WebUsbAllowDevicesForUrls</key>
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
      <string>https://contoso.com</string>
      <string>https://fabrikam.com</string>
    </array>
  </dict>
</array>
```

## Android information and settings

- Preference Key name: WebUsbAllowDevicesForUrls
- Example value:

```
[{"devices": [{"product_id": 5678, "vendor_id": 1234}], "urls": ["https://contoso.com", "https://fabrikam.com"]}]
```