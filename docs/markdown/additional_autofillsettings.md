---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutofillSettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autofillsettings
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-09-11T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block AutoFill data types for specific sites'
locale: en-us
document_id: 99a2adeb-ec3a-d76e-6e3b-72866428cbe3
document_version_independent_id: 99a2adeb-ec3a-d76e-6e3b-72866428cbe3
updated_at: 2026-09-11T20:36:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutofillSettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/bad5d510d6c89974a30e53029e162d63c894b1ea/edgeenterprise/microsoft-edge-policies/AutofillSettings.md
git_commit_id: bad5d510d6c89974a30e53029e162d63c894b1ea
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 496
asset_id: microsoft-edge-policies/autofillsettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutofillSettings.md
platformId: 8b582e92-b6b9-fbd7-8672-9c1ac510de5e
---

# Microsoft Edge Browser Policy Documentation AutofillSettings | Microsoft Learn

## Block AutoFill data types for specific sites

## Supported versions

- Windows: ≥ 154
- macOS: ≥ 154
- Android: ≥ 154
- iOS: ≥ 154

## Description

Setting this policy allows you to specify which AutoFill data types are blocked on specific URL patterns.

The policy is structured as a list of dictionaries. Each dictionary must contain:

- "url\_pattern": A content setting URL pattern for the main frame (for example, "https://[\*.]example.com").
- "blocked\_types": A list of strings representing the categories of AutoFill data to block.

The supported values for "blocked\_types" are:

- "contact\_info": Blocks filling and saving of contact information.
- "payments": Blocks filling and saving of credit cards and payment methods.
- "identity\_docs": Blocks filling and saving of identity documents (for example, passports, driver's licenses, and national IDs).
- "travel": Blocks filling and saving of travel information (for example, flight reservations and vehicle registrations).
- "shopping": Blocks filling and saving of shopping information (for example, online orders and shipments).
- "all": Blocks filling and saving of all AutoFill data types.

If a data type is blocked for a site, both the generation of suggestions and the prompt to save or import new data of that type are disabled on that site.

If a URL matches multiple pattern entries in the list, the blocked types from all matching entries are combined. Invalid URL patterns in the list are ignored.

If you don't configure this policy, no AutoFill data types are blocked by domain.

For detailed information on valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. The wildcard \* is supported and matches any URL with any scheme, port, and path.

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

- GP unique name: AutofillSettings
- GP name: Block AutoFill data types for specific sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"blocked_types": ["contact_info", "payments"], "url_pattern": "https://[*.]example.com"}, {"blocked_types": ["payments"], "url_pattern": "https://another-example.com"}, {"blocked_types": ["identity_docs"], "url_pattern": "*"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AutofillSettings
- Value type: REG\_SZ

#### Example registry value

```
[{"blocked_types": ["contact_info", "payments"], "url_pattern": "https://[*.]example.com"}, {"blocked_types": ["payments"], "url_pattern": "https://another-example.com"}, {"blocked_types": ["identity_docs"], "url_pattern": "*"}]
```

#### Expanded example registry value

```
[
  {
    "blocked_types": [
      "contact_info",
      "payments"
    ],
    "url_pattern": "https://[*.]example.com"
  },
  {
    "blocked_types": [
      "payments"
    ],
    "url_pattern": "https://another-example.com"
  },
  {
    "blocked_types": [
      "identity_docs"
    ],
    "url_pattern": "*"
  }
]
```

## Mac information and settings

- Preference Key name: AutofillSettings
- Example value:

```xml
<key>AutofillSettings</key>
<array>
  <dict>
    <key>blocked_types</key>
    <array>
      <string>contact_info</string>
      <string>payments</string>
    </array>
    <key>url_pattern</key>
    <string>https://[*.]example.com</string>
  </dict>
  <dict>
    <key>blocked_types</key>
    <array>
      <string>payments</string>
    </array>
    <key>url_pattern</key>
    <string>https://another-example.com</string>
  </dict>
  <dict>
    <key>blocked_types</key>
    <array>
      <string>identity_docs</string>
    </array>
    <key>url_pattern</key>
    <string>*</string>
  </dict>
</array>
```

## Android information and settings

- Preference Key name: AutofillSettings
- Example value:

```
[{"blocked_types": ["contact_info", "payments"], "url_pattern": "https://[*.]example.com"}, {"blocked_types": ["payments"], "url_pattern": "https://another-example.com"}, {"blocked_types": ["identity_docs"], "url_pattern": "*"}]
```

## iOS information and settings

- Preference Key name: AutofillSettings
- Example value:

```xml
<key>AutofillSettings</key>
<array>
  <dict>
    <key>blocked_types</key>
    <array>
      <string>contact_info</string>
      <string>payments</string>
    </array>
    <key>url_pattern</key>
    <string>https://[*.]example.com</string>
  </dict>
  <dict>
    <key>blocked_types</key>
    <array>
      <string>payments</string>
    </array>
    <key>url_pattern</key>
    <string>https://another-example.com</string>
  </dict>
  <dict>
    <key>blocked_types</key>
    <array>
      <string>identity_docs</string>
    </array>
    <key>url_pattern</key>
    <string>*</string>
  </dict>
</array>
```