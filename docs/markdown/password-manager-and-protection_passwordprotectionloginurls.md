---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordProtectionLoginURLs | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordprotectionloginurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of enterprise login URLs where the password protection service should capture salted hashes of a password'
locale: en-us
document_id: bdbb80de-a528-f4da-bf10-263ca087346d
document_version_independent_id: bdbb80de-a528-f4da-bf10-263ca087346d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordProtectionLoginURLs.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PasswordProtectionLoginURLs.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 282
asset_id: microsoft-edge-policies/passwordprotectionloginurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordProtectionLoginURLs.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1736ebe0-353e-37a6-5810-00f806486245
---

# Microsoft Edge Browser Policy Documentation PasswordProtectionLoginURLs | Microsoft Learn

## Configure the list of enterprise login URLs where the password protection service should capture salted hashes of a password

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Configure the list of enterprise login URLs (HTTP and HTTPS schemes only) where Microsoft Edge should capture the salted hashes of passwords and use it for password reuse detection.

If you enable this policy, the password protection service captures fingerprints of passwords on the defined URLs.

If you disable this policy or don't configure it, no password fingerprints are captured.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or instances that enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

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

- GP unique name: PasswordProtectionLoginURLs
- GP name: Configure the list of enterprise login URLs where the password protection service should capture salted hashes of a password
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contoso.com/login.html
```

```
https://login.contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\PasswordProtectionLoginURLs
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\PasswordProtectionLoginURLs\1 =

```
https://contoso.com/login.html
```

SOFTWARE\Policies\Microsoft\Edge\PasswordProtectionLoginURLs\2 =

```
https://login.contoso.com
```

## Mac information and settings

- Preference Key name: PasswordProtectionLoginURLs
- Example value:

```xml
<array>
  <string>https://contoso.com/login.html</string>
  <string>https://login.contoso.com</string>
</array>
```