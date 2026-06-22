---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoLaunchProtocolsFromOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autolaunchprotocolsfromorigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Define a list of protocols that can launch an external application from listed origins without prompting the user'
locale: en-us
document_id: ace7fefb-0d46-997d-9c68-f15b4de06286
document_version_independent_id: ace7fefb-0d46-997d-9c68-f15b4de06286
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoLaunchProtocolsFromOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/AutoLaunchProtocolsFromOrigins.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 438
asset_id: microsoft-edge-policies/autolaunchprotocolsfromorigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoLaunchProtocolsFromOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/49ce37d9-33ea-421e-9eb9-c852f2d9c13f
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/d2e24716-af9a-48e2-bf0d-f248d9cc672a
platformId: 5d4df861-475b-8862-1937-bedbd4dbc93b
---

# Microsoft Edge Browser Policy Documentation AutoLaunchProtocolsFromOrigins | Microsoft Learn

## Define a list of protocols that can launch an external application from listed origins without prompting the user

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 85
- Android: Not supported
- iOS: Not supported

## Description

Allows you to set a list of protocols, and for each protocol an associated list of allowed origin patterns, that can launch an external application without prompting the user. The trailing separator shouldn't be included when listing the protocol and the protocol should be all lower case. For example, list "skype" instead of "skype:", "skype://" or "Skype".

If you configure this policy, a protocol is only permitted to launch an external application without prompting by policy if:

- the protocol is listed
- the origin of the site trying to launch the protocol matches one of the origin patterns in that protocol's allowed\_origins list.

If either condition is false, the external protocol launch prompt isn't omitted, by policy.

If you don't configure this policy, no protocols can launch without a prompt. Users can opt out of prompts on a per-protocol/per-site basis unless the [ExternalProtocolDialogShowAlwaysOpenCheckbox](externalprotocoldialogshowalwaysopencheckbox) policy is set to Disabled. This policy has no impact on per-protocol/per-site prompt exemptions set by users.

The origin-matching patterns use a similar format to those for the [URLBlocklist](urlblocklist) policy, which are documented at https://go.microsoft.com/fwlink/?linkid=2095322.

However, origin-matching patterns for this policy can't contain "/path" or "@query" elements. Any pattern that contains a "/path" or "@query" element is ignored.

This policy doesn't work as expected with file://\* wildcards.

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

- GP unique name: AutoLaunchProtocolsFromOrigins
- GP name: Define a list of protocols that can launch an external application from listed origins without prompting the user
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
- Value name: AutoLaunchProtocolsFromOrigins
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

- Preference Key name: AutoLaunchProtocolsFromOrigins
- Example value:

```xml
<key>AutoLaunchProtocolsFromOrigins</key>
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