---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExemptDomainFileTypePairsFromFileTypeDownloadWarnings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/exemptdomainfiletypepairsfromfiletypedownloadwarnings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable download file type extension-based warnings for specified file types on domains (obsolete)'
locale: en-us
document_id: 9adfd0aa-2da7-a734-d0d3-b151d357a571
document_version_independent_id: 9adfd0aa-2da7-a734-d0d3-b151d357a571
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExemptDomainFileTypePairsFromFileTypeDownloadWarnings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/ExemptDomainFileTypePairsFromFileTypeDownloadWarnings.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 497
asset_id: microsoft-edge-policies/exemptdomainfiletypepairsfromfiletypedownloadwarnings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExemptDomainFileTypePairsFromFileTypeDownloadWarnings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 109b685f-7513-1447-be75-01f4557d0ac6
---

# Microsoft Edge Browser Policy Documentation ExemptDomainFileTypePairsFromFileTypeDownloadWarnings | Microsoft Learn

## Disable download file type extension-based warnings for specified file types on domains (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 109.

## Supported versions

- Windows: 85-109
- macOS: 85-109
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsoleted in favor of [ExemptFileTypeDownloadWarnings](exemptfiletypedownloadwarnings) because of a type mismatch that caused errors in Mac.

You can enable this policy to create a dictionary of file type extensions with a corresponding list of domains that are exempted from file type extension-based download warnings. This exemption lets enterprise administrators block file type extension-based download warnings for files that are associated with a listed domain. For example, if the "jnlp" extension is associated with "website1.com", users don't see a warning when downloading "jnlp" files from "website1.com" but see a download warning when downloading "jnlp" files from "website2.com".

Files with file type extensions specified for domains identified by this policy are still subject to nonfile type extension-based security warnings such as mixed-content download warnings and Microsoft Defender SmartScreen warnings.

If you disable this policy or don't configure it, file types that trigger extension-based download warnings show warnings to the user.

If you enable this policy:

- The URL pattern should be formatted according to https://go.microsoft.com/fwlink/?linkid=2095322.
- The file type extension entered must be in lower-cased ASCII. The leading separator shouldn't be included when listing the file type extension; so, list "jnlp" should be used instead of ".jnlp".

Example:

The following example value prevents file type extension-based download warnings on swf, exe, and jnlp extensions for \*.contoso.com domains. It shows the user a file type extension-based download warning on any other domain for exe and jnlp files but not for swf files.

[ { "file\_extension": "jnlp", "domains": ["contoso.com"] }, { "file\_extension": "exe", "domains": ["contoso.com"] }, { "file\_extension": "swf", "domains": ["\*"] } ]

While the preceding example shows the suppression of file type extension-based download warnings for "swf" files for all domains, applying suppression of such warnings for all domains for any dangerous file type extension isn't recommended due to security concerns. It's shown in the example merely to demonstrate the ability to do so.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExemptDomainFileTypePairsFromFileTypeDownloadWarnings
- GP name: Disable download file type extension-based warnings for specified file types on domains (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{'domains': ['https://contoso.com', 'contoso2.com'], 'file_extension': 'jnlp'}
```

```
{'domains': ['*'], 'file_extension': 'swf'}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ExemptDomainFileTypePairsFromFileTypeDownloadWarnings
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ExemptDomainFileTypePairsFromFileTypeDownloadWarnings\1 =

```
{'domains': ['https://contoso.com', 'contoso2.com'], 'file_extension': 'jnlp'}
```

SOFTWARE\Policies\Microsoft\Edge\ExemptDomainFileTypePairsFromFileTypeDownloadWarnings\2 =

```
{'domains': ['*'], 'file_extension': 'swf'}
```

## Mac information and settings

- Preference Key name: ExemptDomainFileTypePairsFromFileTypeDownloadWarnings
- Example value:

```xml
<array>
  <string>{'domains': ['https://contoso.com', 'contoso2.com'], 'file_extension': 'jnlp'}</string>
  <string>{'domains': ['*'], 'file_extension': 'swf'}</string>
</array>
```