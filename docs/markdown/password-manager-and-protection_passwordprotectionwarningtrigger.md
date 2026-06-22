---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordProtectionWarningTrigger | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordprotectionwarningtrigger
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure password protection warning trigger'
locale: en-us
document_id: 2a6ab1c8-0b10-f971-35e0-7525b80b91cf
document_version_independent_id: 2a6ab1c8-0b10-f971-35e0-7525b80b91cf
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordProtectionWarningTrigger.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/PasswordProtectionWarningTrigger.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 296
asset_id: microsoft-edge-policies/passwordprotectionwarningtrigger
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordProtectionWarningTrigger.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: b256fe51-7ea8-d50e-64f1-b0cebb8f73e7
---

# Microsoft Edge Browser Policy Documentation PasswordProtectionWarningTrigger | Microsoft Learn

## Configure password protection warning trigger

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Allows you to control when to trigger password protection warning. Password protection alerts users when they reuse their protected password on potentially suspicious sites.

You can use the [PasswordProtectionLoginURLs](passwordprotectionloginurls) and [PasswordProtectionChangePasswordURL](passwordprotectionchangepasswordurl) policies to configure which passwords to protect.

Exemptions: Passwords for the sites listed in [PasswordProtectionLoginURLs](passwordprotectionloginurls) and [PasswordProtectionChangePasswordURL](passwordprotectionchangepasswordurl), and for the sites listed in [SmartScreenAllowListDomains](smartscreenallowlistdomains), don't trigger a password-protection warning.

Set to PasswordProtectionWarningOff to not show password protection warnings.

Set to PasswordProtectionWarningOnPasswordReuse to show password protection warnings when the users reuse their protected password on a non-allowlisted site.

If you disable or don't configure this policy, then the warning trigger isn't shown.

Policy options mapping:

- PasswordProtectionWarningOff (0) = Password protection warning is off
- PasswordProtectionWarningOnPasswordReuse (1) = Password protection warning is triggered by password reuse

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- PasswordProtectionWarningOff (0) = Password protection warning is off
- PasswordProtectionWarningOnPasswordReuse (1) = Password protection warning is triggered by password reuse

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PasswordProtectionWarningTrigger
- GP name: Configure password protection warning trigger
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Password protection warning is triggered by password reuse
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PasswordProtectionWarningTrigger
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PasswordProtectionWarningTrigger
- Example value:

```xml
<integer>1</integer>
```