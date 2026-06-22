---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DoNotSilentlyBlockProtocolsFromOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/donotsilentlyblockprotocolsfromorigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Define a list of protocols that can not be silently blocked by anti-flood protection'
locale: en-us
document_id: b38f79e3-2e57-0a9d-dd09-aaaac2783ee6
document_version_independent_id: b38f79e3-2e57-0a9d-dd09-aaaac2783ee6
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DoNotSilentlyBlockProtocolsFromOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/DoNotSilentlyBlockProtocolsFromOrigins.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 393
asset_id: microsoft-edge-policies/donotsilentlyblockprotocolsfromorigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DoNotSilentlyBlockProtocolsFromOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/49ce37d9-33ea-421e-9eb9-c852f2d9c13f
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/d2e24716-af9a-48e2-bf0d-f248d9cc672a
platformId: f53486b2-8b56-cbe8-a0c7-e64201d4d852
---

# Microsoft Edge Browser Policy Documentation DoNotSilentlyBlockProtocolsFromOrigins | Microsoft Learn

## Define a list of protocols that can not be silently blocked by anti-flood protection

## Supported versions

- Windows: ≥ 99
- macOS: ≥ 99
- Android: Not supported
- iOS: Not supported

## Description

Allows you to create a list of protocols and an associated list of allowed origin patterns, for each protocol. These origins aren't silently blocked from launching an external application by anti-flood protection. The trailing separator shouldn't be included when listing the protocol. For example, list "skype" instead of "skype:" or "skype://".

If you configure this policy, a protocol is only permitted to bypass being silently blocked by anti-flood protection if:

- the protocol is listed
- the origin of the site trying to launch the protocol matches one of the origin patterns in that protocol's allowed\_origins list.

If either condition is false, anti-flood protection protection blocks the external protocol launch.

If you don't configure this policy, no protocols can bypass being silently blocked.

The origin-matching patterns use a similar format to those patterns for the [URLBlocklist](urlblocklist) policy, which are documented at https://go.microsoft.com/fwlink/?linkid=2095322.

However, origin-matching patterns for this policy can't contain "/path" or "@query" elements. Any pattern that contains a "/path" or "@query" element is ignored.

This policy doesn't work as expected with file://\* wildcards.

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

- GP unique name: DoNotSilentlyBlockProtocolsFromOrigins
- GP name: Define a list of protocols that can not be silently blocked by anti-flood protection
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"allowed_origins": ["example.com", "http://www.example.com:8080"], "protocol": "spotify"}, {"allowed_origins": ["https://example.com", "https://.mail.example.com"], "protocol": "msteams"}, {"allowed_origins": ["*"], "protocol": "msoutlook"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DoNotSilentlyBlockProtocolsFromOrigins
- Value type: REG\_SZ

#### Example registry value

```
[{"allowed_origins": ["example.com", "http://www.example.com:8080"], "protocol": "spotify"}, {"allowed_origins": ["https://example.com", "https://.mail.example.com"], "protocol": "msteams"}, {"allowed_origins": ["*"], "protocol": "msoutlook"}]
```

#### Expanded example registry value

```
[
  {
    "allowed_origins": [
      "example.com",
      "http://www.example.com:8080"
    ],
    "protocol": "spotify"
  },
  {
    "allowed_origins": [
      "https://example.com",
      "https://.mail.example.com"
    ],
    "protocol": "msteams"
  },
  {
    "allowed_origins": [
      "*"
    ],
    "protocol": "msoutlook"
  }
]
```

## Mac information and settings

- Preference Key name: DoNotSilentlyBlockProtocolsFromOrigins
- Example value:

```xml
<key>DoNotSilentlyBlockProtocolsFromOrigins</key>
<array>
  <dict>
    <key>allowed_origins</key>
    <array>
      <string>example.com</string>
      <string>http://www.example.com:8080</string>
    </array>
    <key>protocol</key>
    <string>spotify</string>
  </dict>
  <dict>
    <key>allowed_origins</key>
    <array>
      <string>https://example.com</string>
      <string>https://.mail.example.com</string>
    </array>
    <key>protocol</key>
    <string>msteams</string>
  </dict>
  <dict>
    <key>allowed_origins</key>
    <array>
      <string>*</string>
    </array>
    <key>protocol</key>
    <string>msoutlook</string>
  </dict>
</array>
```