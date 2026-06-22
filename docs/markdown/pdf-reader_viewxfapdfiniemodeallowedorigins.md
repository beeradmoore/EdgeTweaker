---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ViewXFAPDFInIEModeAllowedOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/viewxfapdfiniemodeallowedorigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: View XFA-based PDF files using IE Mode for allowed file origin.'
locale: en-us
document_id: 041c4f22-0bda-9cc1-c004-fedd98556a6e
document_version_independent_id: 041c4f22-0bda-9cc1-c004-fedd98556a6e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ViewXFAPDFInIEModeAllowedOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/ViewXFAPDFInIEModeAllowedOrigins.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 356
asset_id: microsoft-edge-policies/viewxfapdfiniemodeallowedorigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ViewXFAPDFInIEModeAllowedOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 0071b324-b7e7-ce8b-078f-7deb6774a101
---

# Microsoft Edge Browser Policy Documentation ViewXFAPDFInIEModeAllowedOrigins | Microsoft Learn

## View XFA-based PDF files using IE Mode for allowed file origin.

## Supported versions

- Windows: ≥ 132
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Internet Explorer (IE) mode uses the Adobe Acrobat Active-X PDF Plugin to open XFA-based PDF files. This policy works only if the Active-X plugin is already on the user's device, it's not installed as part of this policy.

It's important to note that XFA is a legacy technology that's deprecated by its original creators. It's not an ISO standard and as such doesn't align with the modern web architecture. Continued use poses potential risks and vulnerabilities.

Given the deprecated status of XFA technology and the lack of any investment by its creators, we strongly recommend that you start planning your transition to more advanced HTML\PDF form-based solutions.

In the interim, this policy provides a workaround for users to view XFA PDF in Microsoft Edge.

If you enable this policy, you can configure the list of origins from which XFA PDF files will be automatically opened in Microsoft Edge using IE Mode.

If you disable or don't configure the policy, XFA PDFs won't be considered for opening via Internet Explorer mode.

For detailed information on valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322

Alternatively, [ViewXFAPDFInIEModeAllowedFileHash](viewxfapdfiniemodeallowedfilehash) can also be used to configure list of file hashes instead of URL origins, which enables those files to be automatically opened in Microsoft Edge using IE Mode.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ViewXFAPDFInIEModeAllowedOrigins
- GP name: View XFA-based PDF files using IE Mode for allowed file origin.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/PDF Reader
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contesso.sharepoint.com/accounts/
```

```
https://contesso.sharepoint.com/transport/
```

```
file://account_forms/
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedOrigins\1 =

```
https://contesso.sharepoint.com/accounts/
```

SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedOrigins\2 =

```
https://contesso.sharepoint.com/transport/
```

SOFTWARE\Policies\Microsoft\Edge\ViewXFAPDFInIEModeAllowedOrigins\3 =

```
file://account_forms/
```