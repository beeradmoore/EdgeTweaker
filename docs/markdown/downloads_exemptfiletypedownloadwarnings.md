---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExemptFileTypeDownloadWarnings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/exemptfiletypedownloadwarnings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable download file type extension-based warnings for specified file types on domains'
locale: en-us
document_id: 62ec89db-1e2a-7d55-f162-4b99ce5786d5
document_version_independent_id: 62ec89db-1e2a-7d55-f162-4b99ce5786d5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExemptFileTypeDownloadWarnings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ExemptFileTypeDownloadWarnings.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 483
asset_id: microsoft-edge-policies/exemptfiletypedownloadwarnings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExemptFileTypeDownloadWarnings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 658e11a4-ba12-94b6-4b9c-5ddb362d8a8c
---

# Microsoft Edge Browser Policy Documentation ExemptFileTypeDownloadWarnings | Microsoft Learn

## Disable download file type extension-based warnings for specified file types on domains

## Supported versions

- Windows: ≥ 105
- macOS: ≥ 105
- Android: Not supported
- iOS: Not supported

## Description

You can enable this policy to create a dictionary of file type extensions with a corresponding list of domains that are exempted from file type extension-based download warnings. This exemption lets enterprise administrators block file type extension-based download warnings for files that are associated with a listed domain. For example, if the "jnlp" extension is associated with "website1.com", users can't see a warning when downloading "jnlp" files from "website1.com" but can see a download warning when downloading "jnlp" files from "website2.com".

Files with file type extensions specified for domains identified by this policy are still subject to nonfile type extension-based security warnings such as mixed-content download warnings and Microsoft Defender SmartScreen warnings.

If you disable this policy or don't configure it, file types that trigger extension-based download warnings show warnings to the user.

If you enable this policy:

- The URL pattern should be formatted according to https://go.microsoft.com/fwlink/?linkid=2095322.
- The file type extension entered must be in lower-cased ASCII. The leading separator shouldn't be included when listing the file type extension; so, list "jnlp" should be used instead of ".jnlp".

Example:

The following example value prevents file type extension-based download warnings on swf, exe, and jnlp extensions for \*.contoso.com domains. It shows the user a file type extension-based download warning on any other domain for exe and jnlp files, but not for swf files.

[ { "file\_extension": "jnlp", "domains": ["contoso.com"] }, { "file\_extension": "exe", "domains": ["contoso.com"] }, { "file\_extension": "swf", "domains": ["\*"] } ]

While the preceding example shows the suppression of file type extension-based download warnings for "swf" files for all domains, applying suppression of such warnings for all domains for any dangerous file type extension isn't recommended due to security concerns. It's shown in the example merely to demonstrate the ability to do so.

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

- GP unique name: ExemptFileTypeDownloadWarnings
- GP name: Disable download file type extension-based warnings for specified file types on domains
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"domains": ["https://contoso.com", "contoso2.com"], "file_extension": "jnlp"}, {"domains": ["*"], "file_extension": "swf"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ExemptFileTypeDownloadWarnings
- Value type: REG\_SZ

#### Example registry value

```
[{"domains": ["https://contoso.com", "contoso2.com"], "file_extension": "jnlp"}, {"domains": ["*"], "file_extension": "swf"}]
```

#### Expanded example registry value

```
[
  {
    "domains": [
      "https://contoso.com",
      "contoso2.com"
    ],
    "file_extension": "jnlp"
  },
  {
    "domains": [
      "*"
    ],
    "file_extension": "swf"
  }
]
```

## Mac information and settings

- Preference Key name: ExemptFileTypeDownloadWarnings
- Example value:

```xml
<key>ExemptFileTypeDownloadWarnings</key>
<array>
  <dict>
    <key>domains</key>
    <array>
      <string>https://contoso.com</string>
      <string>contoso2.com</string>
    </array>
    <key>file_extension</key>
    <string>jnlp</string>
  </dict>
  <dict>
    <key>domains</key>
    <array>
      <string>*</string>
    </array>
    <key>file_extension</key>
    <string>swf</string>
  </dict>
</array>
```