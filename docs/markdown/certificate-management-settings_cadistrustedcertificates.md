---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CADistrustedCertificates | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/cadistrustedcertificates
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: TLS certificates that should be distrusted by Microsoft Edge for server authentication'
locale: en-us
document_id: 963c6e63-6b55-92ea-c9a1-71584edeb709
document_version_independent_id: 963c6e63-6b55-92ea-c9a1-71584edeb709
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CADistrustedCertificates.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/CADistrustedCertificates.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 202
asset_id: microsoft-edge-policies/cadistrustedcertificates
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CADistrustedCertificates.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 887c5db8-5f5a-8bb7-db7f-14dc3d495a46
---

# Microsoft Edge Browser Policy Documentation CADistrustedCertificates | Microsoft Learn

## TLS certificates that should be distrusted by Microsoft Edge for server authentication

## Supported versions

- Windows: ≥ 133
- macOS: ≥ 133
- Android: ≥ 138
- iOS: Not supported

## Description

This policy enables defining a list of certificate public keys that should be distrusted by Microsoft Edge for TLS server authentication.

The policy value is a list of base64-encoded X.509 certificates. Any certificate with a matching SPKI (SubjectPublicKeyInfo) is distrusted.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CADistrustedCertificates
- GP name: TLS certificates that should be distrusted by Microsoft Edge for server authentication
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Certificate management settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
MIIB/TCCAaOgAwIBAgIUQthnWVsd1jWpUCNBf/uILjXC+t4wCgYIKoZIzj0EAwIwVDELMAkGA1UEBhMCVVMxETAPBgNVBAgMCFZpcmdpbmlhMQ8wDQYDVQQHDAZSZXN0b24xITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0yMzEyMDcxNjE5NTVaFw0yMzEyMjExNjE5NTVaMFQxCzAJBgNVBAYTAlVTMREwDwYDVQQIDAhWaXJnaW5pYTEPMA0GA1UEBwwGUmVzdG9uMSEwHwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwWTATBgcqhkjOPQIBBggqhkjOPQMBBwNCAAQ9Akav/KB0aVA9FM1QK4J1CEHn5rFOyY/nxcr5HG3+Fom0Kwu5zTR/kz9eOYgtG/1NmCzbiEKaULDfzA8V9aJ7o1MwUTAdBgNVHQ4EFgQUq37bLKiuw8Y/G+rurMf46hw7EekwHwYDVR0jBBgwFoAUq37bLKiuw8Y/G+rurMf46hw7EekwDwYDVR0TAQH/BAUwAwEB/zAKBggqhkjOPQQDAgNIADBFAiEA/JhtLSgtVOcXkgFJ9V5Vb6lhGdiKQFfzO9wTxPeCxCECIFePYPucys2n/r9MOBMHiX/8068ssv+uceqokzUg0mAb
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\CADistrustedCertificates
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\CADistrustedCertificates\1 =

```
MIIB/TCCAaOgAwIBAgIUQthnWVsd1jWpUCNBf/uILjXC+t4wCgYIKoZIzj0EAwIwVDELMAkGA1UEBhMCVVMxETAPBgNVBAgMCFZpcmdpbmlhMQ8wDQYDVQQHDAZSZXN0b24xITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0yMzEyMDcxNjE5NTVaFw0yMzEyMjExNjE5NTVaMFQxCzAJBgNVBAYTAlVTMREwDwYDVQQIDAhWaXJnaW5pYTEPMA0GA1UEBwwGUmVzdG9uMSEwHwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwWTATBgcqhkjOPQIBBggqhkjOPQMBBwNCAAQ9Akav/KB0aVA9FM1QK4J1CEHn5rFOyY/nxcr5HG3+Fom0Kwu5zTR/kz9eOYgtG/1NmCzbiEKaULDfzA8V9aJ7o1MwUTAdBgNVHQ4EFgQUq37bLKiuw8Y/G+rurMf46hw7EekwHwYDVR0jBBgwFoAUq37bLKiuw8Y/G+rurMf46hw7EekwDwYDVR0TAQH/BAUwAwEB/zAKBggqhkjOPQQDAgNIADBFAiEA/JhtLSgtVOcXkgFJ9V5Vb6lhGdiKQFfzO9wTxPeCxCECIFePYPucys2n/r9MOBMHiX/8068ssv+uceqokzUg0mAb
```

## Mac information and settings

- Preference Key name: CADistrustedCertificates
- Example value:

```xml
<array>
  <string>MIIB/TCCAaOgAwIBAgIUQthnWVsd1jWpUCNBf/uILjXC+t4wCgYIKoZIzj0EAwIwVDELMAkGA1UEBhMCVVMxETAPBgNVBAgMCFZpcmdpbmlhMQ8wDQYDVQQHDAZSZXN0b24xITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0yMzEyMDcxNjE5NTVaFw0yMzEyMjExNjE5NTVaMFQxCzAJBgNVBAYTAlVTMREwDwYDVQQIDAhWaXJnaW5pYTEPMA0GA1UEBwwGUmVzdG9uMSEwHwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwWTATBgcqhkjOPQIBBggqhkjOPQMBBwNCAAQ9Akav/KB0aVA9FM1QK4J1CEHn5rFOyY/nxcr5HG3+Fom0Kwu5zTR/kz9eOYgtG/1NmCzbiEKaULDfzA8V9aJ7o1MwUTAdBgNVHQ4EFgQUq37bLKiuw8Y/G+rurMf46hw7EekwHwYDVR0jBBgwFoAUq37bLKiuw8Y/G+rurMf46hw7EekwDwYDVR0TAQH/BAUwAwEB/zAKBggqhkjOPQQDAgNIADBFAiEA/JhtLSgtVOcXkgFJ9V5Vb6lhGdiKQFfzO9wTxPeCxCECIFePYPucys2n/r9MOBMHiX/8068ssv+uceqokzUg0mAb</string>
</array>
```

## Android information and settings

- Preference Key name: CADistrustedCertificates
- Example value:

```
["MIIB/TCCAaOgAwIBAgIUQthnWVsd1jWpUCNBf/uILjXC+t4wCgYIKoZIzj0EAwIwVDELMAkGA1UEBhMCVVMxETAPBgNVBAgMCFZpcmdpbmlhMQ8wDQYDVQQHDAZSZXN0b24xITAfBgNVBAoMGEludGVybmV0IFdpZGdpdHMgUHR5IEx0ZDAeFw0yMzEyMDcxNjE5NTVaFw0yMzEyMjExNjE5NTVaMFQxCzAJBgNVBAYTAlVTMREwDwYDVQQIDAhWaXJnaW5pYTEPMA0GA1UEBwwGUmVzdG9uMSEwHwYDVQQKDBhJbnRlcm5ldCBXaWRnaXRzIFB0eSBMdGQwWTATBgcqhkjOPQIBBggqhkjOPQMBBwNCAAQ9Akav/KB0aVA9FM1QK4J1CEHn5rFOyY/nxcr5HG3+Fom0Kwu5zTR/kz9eOYgtG/1NmCzbiEKaULDfzA8V9aJ7o1MwUTAdBgNVHQ4EFgQUq37bLKiuw8Y/G+rurMf46hw7EekwHwYDVR0jBBgwFoAUq37bLKiuw8Y/G+rurMf46hw7EekwDwYDVR0TAQH/BAUwAwEB/zAKBggqhkjOPQQDAgNIADBFAiEA/JhtLSgtVOcXkgFJ9V5Vb6lhGdiKQFfzO9wTxPeCxCECIFePYPucys2n/r9MOBMHiX/8068ssv+uceqokzUg0mAb"]
```