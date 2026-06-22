---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CertificateTransparencyEnforcementDisabledForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/certificatetransparencyenforcementdisabledforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable Certificate Transparency enforcement for specific URLs'
locale: en-us
document_id: c6baf19d-7490-0b3a-8eab-e228a708be66
document_version_independent_id: c6baf19d-7490-0b3a-8eab-e228a708be66
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForUrls.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 277
asset_id: microsoft-edge-policies/certificatetransparencyenforcementdisabledforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9cdd8cb1-f4e3-c590-e98c-0b48bfcca82d
---

# Microsoft Edge Browser Policy Documentation CertificateTransparencyEnforcementDisabledForUrls | Microsoft Learn

## Disable Certificate Transparency enforcement for specific URLs

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 53
- iOS: Not supported

## Description

Disables enforcing Certificate Transparency requirements for the listed URLs.

This policy lets you not disclose certificates for the hostnames in the specified URLs via Certificate Transparency. This lets you use certificates that would otherwise be untrusted, because they weren't properly publicly disclosed, but it makes it harder to detect mis-issued certificates for those hosts.

Form your URL pattern according to https://go.microsoft.com/fwlink/?linkid=2095322. Because certificates are valid for a given hostname, independent of the scheme, port, or path, only the hostname part of the URL is considered. Wildcard hosts aren't supported.

If you don't configure this policy, any certificate that should be disclosed via Certificate Transparency is treated as untrusted if it's not disclosed.

This policy doesn't work as expected with file://\* wildcards.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CertificateTransparencyEnforcementDisabledForUrls
- GP name: Disable Certificate Transparency enforcement for specific URLs
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
contoso.com
```

```
.contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForUrls\1 =

```
contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForUrls\2 =

```
.contoso.com
```

## Mac information and settings

- Preference Key name: CertificateTransparencyEnforcementDisabledForUrls
- Example value:

```xml
<array>
  <string>contoso.com</string>
  <string>.contoso.com</string>
</array>
```

## Android information and settings

- Preference Key name: CertificateTransparencyEnforcementDisabledForUrls
- Example value:

```
["contoso.com", ".contoso.com"]
```