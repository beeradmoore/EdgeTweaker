---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordProtectionChangePasswordURL | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordprotectionchangepasswordurl
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the change password URL'
locale: en-us
document_id: 56b40c98-7faf-fa43-1ad3-aa05ac541b64
document_version_independent_id: 56b40c98-7faf-fa43-1ad3-aa05ac541b64
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordProtectionChangePasswordURL.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PasswordProtectionChangePasswordURL.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 248
asset_id: microsoft-edge-policies/passwordprotectionchangepasswordurl
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordProtectionChangePasswordURL.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: a2136ce1-392e-a033-b851-b39860d933e3
---

# Microsoft Edge Browser Policy Documentation PasswordProtectionChangePasswordURL | Microsoft Learn

## Configure the change password URL

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Configures the change password URL (HTTP and HTTPS schemes only).

Password protection service will send users to this URL to change their password after seeing a warning in the browser.

If you enable this policy, then password protection service sends users to this URL to change their password.

If you disable this policy or don't configure it, then password protection service can't redirect users to a change password URL.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, joined to Microsoft Azure Active Directory, or instances that enrolled for device management. On macOS, this policy is available only on instances that are managed via MDM or joined to a domain via MCX.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PasswordProtectionChangePasswordURL
- GP name: Configure the change password URL
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contoso.com/change_password.html
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PasswordProtectionChangePasswordURL
- Value type: REG\_SZ

#### Example registry value

```
https://contoso.com/change_password.html
```

## Mac information and settings

- Preference Key name: PasswordProtectionChangePasswordURL
- Example value:

```xml
<string>https://contoso.com/change_password.html</string>
```