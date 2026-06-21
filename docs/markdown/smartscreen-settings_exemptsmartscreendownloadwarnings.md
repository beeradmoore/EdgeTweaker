---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExemptSmartScreenDownloadWarnings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/exemptsmartscreendownloadwarnings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable SmartScreen AppRep based warnings for specified file types on specified domains'
locale: en-us
document_id: 033c1234-7533-03ac-982e-323e23a469e6
document_version_independent_id: 033c1234-7533-03ac-982e-323e23a469e6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExemptSmartScreenDownloadWarnings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ExemptSmartScreenDownloadWarnings.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 426
asset_id: microsoft-edge-policies/exemptsmartscreendownloadwarnings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExemptSmartScreenDownloadWarnings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0445a68b-e88f-c9dd-2eff-9d1d1f60fb9a
---

# Microsoft Edge Browser Policy Documentation ExemptSmartScreenDownloadWarnings | Microsoft Learn

## Disable SmartScreen AppRep based warnings for specified file types on specified domains

## Supported versions

- Windows: ≥ 118
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

You can enable this policy to create a dictionary of file type extensions with a corresponding list of domains that are exempted from SmartScreen AppRep warnings. For example, if the `vbe` extension is associated with "contoso.com," users can't see a SmartScreen AppRep warning when downloading `vbe` files from "contoso.com." They can, however, see a download warning when downloading `vbe` files from "fabrikam.com."

Files with file type extensions specified for domains identified by this policy are still subject to file type extension-based security warnings and mixed-content download warnings.

If you disable this policy or don't configure it, files that trigger SmartScreen AppRep download warnings show warnings to the user.

If you enable this policy:

- The URL pattern should be formatted according to https://go.microsoft.com/fwlink/?linkid=2095322.
- The file type extension entered must be in lower-cased ASCII. The leading separator shouldn't be included when listing the file type extension; so, `vbe` should be used instead of `.vbe`.

Example:

The following example prevents SmartScreen AppRep warnings on msi, exe, and vbe extensions for \*.contoso.com domains. It might show the user a SmartScreen AppRep warning on any other domain for exe and msi files but not for vbe files.

[ { "file\_extension": "msi", "domains": ["contoso.com"] }, { "file\_extension": "exe", "domains": ["contoso.com"] }, { "file\_extension": "vbe", "domains": ["\*"] } ]

Note: While the preceding example shows the suppression of SmartScreen AppRep download warnings for `vbe` files for all domains, applying suppression of such warnings for all domains isn't recommended due to security concerns. The ability to suppress warnings for all domains is shown in the example merely to demonstrate the ability to do so.

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

- GP unique name: ExemptSmartScreenDownloadWarnings
- GP name: Disable SmartScreen AppRep based warnings for specified file types on specified domains
- GP path (Mandatory): Administrative Templates/Microsoft Edge/SmartScreen settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[{"domains": ["https://contoso.com", "contoso2.com"], "file_extension": "msi"}, {"domains": ["*"], "file_extension": "vbe"}]
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ExemptSmartScreenDownloadWarnings
- Value type: REG\_SZ

#### Example registry value

```
[{"domains": ["https://contoso.com", "contoso2.com"], "file_extension": "msi"}, {"domains": ["*"], "file_extension": "vbe"}]
```

#### Expanded example registry value

```
[
  {
    "domains": [
      "https://contoso.com",
      "contoso2.com"
    ],
    "file_extension": "msi"
  },
  {
    "domains": [
      "*"
    ],
    "file_extension": "vbe"
  }
]
```