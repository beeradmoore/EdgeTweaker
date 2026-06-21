---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CertificateTransparencyEnforcementDisabledForLegacyCas | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/certificatetransparencyenforcementdisabledforlegacycas
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable Certificate Transparency enforcement for a list of legacy certificate authorities (obsolete)'
locale: en-us
document_id: 3d14fc8b-463f-8bda-5de7-c03a219822b6
document_version_independent_id: 3d14fc8b-463f-8bda-5de7-c03a219822b6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForLegacyCas.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForLegacyCas.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 393
asset_id: microsoft-edge-policies/certificatetransparencyenforcementdisabledforlegacycas
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForLegacyCas.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b4520c9b-2ec2-49c6-eaf0-088d48b5df13
---

# Microsoft Edge Browser Policy Documentation CertificateTransparencyEnforcementDisabledForLegacyCas | Microsoft Learn

## Disable Certificate Transparency enforcement for a list of legacy certificate authorities (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 131.

## Supported versions

- Windows: 77-131
- macOS: 77-131
- Android: 67-131
- iOS: Not supported

## Description

Disables enforcing Certificate Transparency requirements for a list of legacy certificate authorities (Cas).

This policy lets you disable Certificate Transparency disclosure requirements for certificate chains that contain certificates with one of the specified subjectPublicKeyInfo hashes. This disablement of requirements allows otherwise-untrusted certificates (on account of not being publicly disclosed) to continue to be used for enterprise hosts.

For Certificate Transparency enforcement to be disabled, you must set the hash to a subjectPublicKeyInfo appearing in an authority-issued certificate that's recognized as a legacy certificate authority (CA). A legacy CA is a CA publicly trusted, by default, by one or more operating systems supported by Microsoft Edge.

You specify a subjectPublicKeyInfo hash by concatenating the hash algorithm name, the "/" character, and the Base64 encoding of that hash algorithm applied to the DER-encoded subjectPublicKeyInfo of the specified certificate. This Base64 encoding is the same format as an SPKI Fingerprint, as defined in RFC 7469, Section 2.4. Unrecognized hash algorithms are ignored. The only supported hash algorithm at this time is "sha256".

If you don't configure this policy, any certificate that's required to be disclosed via Certificate Transparency is treated as untrusted if it isn't disclosed according to the Certificate Transparency policy.

This policy is obsolete because the feature to disable Certificate Transparency enforcement for legacy certificates has been removed.

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

- GP unique name: CertificateTransparencyEnforcementDisabledForLegacyCas
- GP name: Disable Certificate Transparency enforcement for a list of legacy certificate authorities (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
sha256/AAAAAAAAAAAAAAAAAAAAAA==
```

```
sha256//////////////////////w==
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForLegacyCas
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForLegacyCas\1 =

```
sha256/AAAAAAAAAAAAAAAAAAAAAA==
```

SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForLegacyCas\2 =

```
sha256//////////////////////w==
```

## Mac information and settings

- Preference Key name: CertificateTransparencyEnforcementDisabledForLegacyCas
- Example value:

```xml
<array>
  <string>sha256/AAAAAAAAAAAAAAAAAAAAAA==</string>
  <string>sha256//////////////////////w==</string>
</array>
```

## Android information and settings

- Preference Key name: CertificateTransparencyEnforcementDisabledForLegacyCas
- Example value:

```
["sha256/AAAAAAAAAAAAAAAAAAAAAA==", "sha256//////////////////////w=="]
```