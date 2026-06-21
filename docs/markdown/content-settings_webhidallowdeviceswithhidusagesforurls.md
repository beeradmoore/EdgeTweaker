---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebHidAllowDevicesWithHidUsagesForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webhidallowdeviceswithhidusagesforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Automatically grant permission to these sites to connect to HID devices containing top-level collections with the given HID usage'
locale: en-us
document_id: 7cebf3e0-18c1-ee81-48c9-a8f1a8a7180b
document_version_independent_id: 7cebf3e0-18c1-ee81-48c9-a8f1a8a7180b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebHidAllowDevicesWithHidUsagesForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebHidAllowDevicesWithHidUsagesForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 360
asset_id: microsoft-edge-policies/webhidallowdeviceswithhidusagesforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebHidAllowDevicesWithHidUsagesForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8274fbc1-4c04-c458-b76a-c872cc01d04a
---

# Microsoft Edge Browser Policy Documentation WebHidAllowDevicesWithHidUsagesForUrls | Microsoft Learn

## Automatically grant permission to these sites to connect to HID devices containing top-level collections with the given HID usage

## Supported versions

- Windows: ≥ 109
- macOS: ≥ 109
- Android: Not supported
- iOS: Not supported

## Description

This setting allows you to list the URLs that specify which sites are automatically granted permission to access an HID device containing a top-level collection with the given HID usage.

Each item in the list requires both usages and urls fields for the policy to be valid.

- Each item in the usages field must have a usage\_page and may have a usage field.
- Omitting the usage field creates a policy matching any device containing a top-level collection with a usage from the specified usage page.
- An item which has a usage field without a usage\_page field is invalid and is ignored.

If you don't set this policy, then [DefaultWebHidGuardSetting](defaultwebhidguardsetting) applies, if it's set. If not, the user's personal setting applies.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* is not an accepted value for this policy.

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

- GP unique name: WebHidAllowDevicesWithHidUsagesForUrls
- GP name: Automatically grant permission to these sites to connect to HID devices containing top-level collections with the given HID usage
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"urls": ["https://microsoft.com", "https://chromium.org"], "usages": [{"usage": 5678, "usage_page": 1234}]}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WebHidAllowDevicesWithHidUsagesForUrls
- Value type: REG\_SZ

#### Example registry value

```
[{"urls": ["https://microsoft.com", "https://chromium.org"], "usages": [{"usage": 5678, "usage_page": 1234}]}]
```

#### Expanded example registry value

```
[
  {
    "urls": [
      "https://microsoft.com",
      "https://chromium.org"
    ],
    "usages": [
      {
        "usage": 5678,
        "usage_page": 1234
      }
    ]
  }
]
```

## Mac information and settings

- Preference Key name: WebHidAllowDevicesWithHidUsagesForUrls
- Example value:

```xml
<key>WebHidAllowDevicesWithHidUsagesForUrls</key>
<array>
  <dict>
    <key>urls</key>
    <array>
      <string>https://microsoft.com</string>
      <string>https://chromium.org</string>
    </array>
    <key>usages</key>
    <array>
      <dict>
        <key>usage</key>
        <integer>5678</integer>
        <key>usage_page</key>
        <integer>1234</integer>
      </dict>
    </array>
  </dict>
</array>
```