---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RSAKeyUsageForLocalAnchorsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/rsakeyusageforlocalanchorsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Check RSA key usage for server certificates issued by local trust anchors (obsolete)'
locale: en-us
document_id: 96eee7df-1f18-8811-5662-82694414ddb8
document_version_independent_id: 96eee7df-1f18-8811-5662-82694414ddb8
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RSAKeyUsageForLocalAnchorsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RSAKeyUsageForLocalAnchorsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 463
asset_id: microsoft-edge-policies/rsakeyusageforlocalanchorsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RSAKeyUsageForLocalAnchorsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c6d38a99-e5f6-982b-cc1b-36a06717e919
---

# Microsoft Edge Browser Policy Documentation RSAKeyUsageForLocalAnchorsEnabled | Microsoft Learn

## Check RSA key usage for server certificates issued by local trust anchors (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 135.

## Supported versions

- Windows: 123-135
- macOS: 123-135
- Android: 123-135
- iOS: Not supported

## Description

The X.509 key usage extension declares how the key in a certificate can be used. These instructions ensure certificates aren't used in an unintended context, which protects against a class of cross-protocol attacks on HTTPS and other protocols. HTTPS clients must verify that server certificates match the connection's TLS parameters.

Starting in Microsoft Edge 124, this check is always enabled.

Microsoft Edge 123 and earlier have the following behavior:

If this policy is set to enabled, Microsoft Edge performs this key check. This helps prevent attacks where an attacker manipulates the browser into interpreting a key in ways that the certificate owner didn't intend.

If this policy is set to disabled, Microsoft Edge skips this key check-in HTTPS connections that negotiate TLS 1.2 and use an RSA certificate that chains to a local trust anchor. Examples of local trust anchors include policy-provided or user-installed root certificates. In all other cases, the check is performed independent of this policy's setting.

If this policy isn't configured, Microsoft Edge behaves as if the policy is enabled.

This policy is available for administrators to preview the behavior of a future release, which will enable this check by default. At that point, this policy will remain temporarily available for administrators that need more time to update their certificates to meet the new RSA key usage requirements.

Connections that fail this check will fail with the error ERR\_SSL\_KEY\_USAGE\_INCOMPATIBLE. Sites that fail with this error likely have a misconfigured certificate. Modern ECDHE\_RSA cipher suites use the "digitalSignature" key usage option, while legacy RSA decryption cipher suites use the "keyEncipherment" key usage option. If uncertain, administrators should include both in RSA certificates meant for HTTPS.

The policy has been obsoleted starting from Microsoft Edge version 136, but the key check has been always enabled since Microsoft Edge version 124.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RSAKeyUsageForLocalAnchorsEnabled
- GP name: Check RSA key usage for server certificates issued by local trust anchors (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RSAKeyUsageForLocalAnchorsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: RSAKeyUsageForLocalAnchorsEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: RSAKeyUsageForLocalAnchorsEnabled
- Example value:

```
true
```