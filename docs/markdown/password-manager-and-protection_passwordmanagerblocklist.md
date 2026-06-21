---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordManagerBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordmanagerblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of domains for which the password manager UI (Save and Fill) will be disabled'
locale: en-us
document_id: 158a3404-9246-98cc-a871-86534efc1303
document_version_independent_id: 158a3404-9246-98cc-a871-86534efc1303
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordManagerBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PasswordManagerBlocklist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 271
asset_id: microsoft-edge-policies/passwordmanagerblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordManagerBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 28d69602-594f-36e1-15b0-bfedf2b31e2e
---

# Microsoft Edge Browser Policy Documentation PasswordManagerBlocklist | Microsoft Learn

## Configure the list of domains for which the password manager UI (Save and Fill) will be disabled

## Supported versions

- Windows: ≥ 99
- macOS: ≥ 99
- Android: Not supported
- iOS: Not supported

## Description

Configure the list of domains where Microsoft Edge should disable the password manager. This means that Save and Fill workflows are disabled, ensuring that passwords for those websites can't be saved or auto filled into web forms.

If you enable this policy, the password manager is disabled for the specified set of domains.

If you disable or don't configure this policy, password manager works as usual for all domains.

If you configure this policy, that is, add domains for which password manager is blocked, users can't change or override the behavior in Microsoft Edge. In addition, users can't use password manager for those URLs.

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

- GP unique name: PasswordManagerBlocklist
- GP name: Configure the list of domains for which the password manager UI (Save and Fill) will be disabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://contoso.com/
```

```
https://login.contoso.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\PasswordManagerBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\PasswordManagerBlocklist\1 =

```
https://contoso.com/
```

SOFTWARE\Policies\Microsoft\Edge\PasswordManagerBlocklist\2 =

```
https://login.contoso.com
```

## Mac information and settings

- Preference Key name: PasswordManagerBlocklist
- Example value:

```xml
<array>
  <string>https://contoso.com/</string>
  <string>https://login.contoso.com</string>
</array>
```