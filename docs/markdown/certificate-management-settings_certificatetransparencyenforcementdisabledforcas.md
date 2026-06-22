---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CertificateTransparencyEnforcementDisabledForCas | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/certificatetransparencyenforcementdisabledforcas
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable Certificate Transparency enforcement for a list of subjectPublicKeyInfo hashes'
locale: en-us
document_id: 685eff67-47ee-6136-9bf9-4995989ee6de
document_version_independent_id: 685eff67-47ee-6136-9bf9-4995989ee6de
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForCas.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForCas.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 432
asset_id: microsoft-edge-policies/certificatetransparencyenforcementdisabledforcas
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CertificateTransparencyEnforcementDisabledForCas.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 82095b9f-9a7a-76d4-f4ae-798e7702c7bd
---

# Microsoft Edge Browser Policy Documentation CertificateTransparencyEnforcementDisabledForCas | Microsoft Learn

## Disable Certificate Transparency enforcement for a list of subjectPublicKeyInfo hashes

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 67
- iOS: Not supported

## Description

Disables enforcement of Certificate Transparency requirements for a list of subjectPublicKeyInfo hashes.

This policy lets you disable Certificate Transparency disclosure requirements for certificate chains that contain certificates with one of the specified subjectPublicKeyInfo hashes. This allows certificates that would otherwise be untrusted because they weren't properly publicly disclosed to still be used for Enterprise hosts.

To disable Certificate Transparency enforcement when this policy is set, one of the following sets of conditions must be met:

1. The hash is of the server certificate's subjectPublicKeyInfo.
2. The hash is of a subjectPublicKeyInfo that appears in a CA certificate in the certificate chain, that CA certificate is constrained via the X.509v3 nameConstraints extension, one or more directoryName nameConstraints are present in the permittedSubtrees, and the directoryName contains an organizationName attribute.
3. The hash is of a subjectPublicKeyInfo that appears in a CA certificate in the certificate chain, the CA certificate has one or more organizationName attributes in the certificate Subject, and the server's certificate contains the same number of organizationName attributes, in the same order, and with byte-for-byte identical values.

A subjectPublicKeyInfo hash is specified by concatenating the hash algorithm name, the "/" character, and the Base64 encoding of that hash algorithm applied to the DER-encoded subjectPublicKeyInfo of the specified certificate. This Base64 encoding is the same format as an SPKI Fingerprint, as defined in RFC 7469, Section 2.4. Unrecognized hash algorithms are ignored. The only supported hash algorithm at this time is "sha256".

If you disable this policy or don't configure it, any certificate required to be disclosed via Certificate Transparency is treated as untrusted if not disclosed according to the Certificate Transparency policy.

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

- GP unique name: CertificateTransparencyEnforcementDisabledForCas
- GP name: Disable Certificate Transparency enforcement for a list of subjectPublicKeyInfo hashes
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForCas
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForCas\1 =

```
sha256/AAAAAAAAAAAAAAAAAAAAAA==
```

SOFTWARE\Policies\Microsoft\Edge\CertificateTransparencyEnforcementDisabledForCas\2 =

```
sha256//////////////////////w==
```

## Mac information and settings

- Preference Key name: CertificateTransparencyEnforcementDisabledForCas
- Example value:

```xml
<array>
  <string>sha256/AAAAAAAAAAAAAAAAAAAAAA==</string>
  <string>sha256//////////////////////w==</string>
</array>
```

## Android information and settings

- Preference Key name: CertificateTransparencyEnforcementDisabledForCas
- Example value:

```
["sha256/AAAAAAAAAAAAAAAAAAAAAA==", "sha256//////////////////////w=="]
```