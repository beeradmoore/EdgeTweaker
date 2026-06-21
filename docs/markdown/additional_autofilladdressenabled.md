---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutofillAddressEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autofilladdressenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable AutoFill for addresses'
locale: en-us
document_id: 536f3dd4-9f77-6f8e-58bc-f3ab44ab51f5
document_version_independent_id: 536f3dd4-9f77-6f8e-58bc-f3ab44ab51f5
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutofillAddressEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AutofillAddressEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 281
asset_id: microsoft-edge-policies/autofilladdressenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutofillAddressEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/97159432-14a9-4307-a469-d2f2c75f0e33
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/50565c62-5f6b-4687-be38-323113c72c2e
platformId: beb67f52-0a81-e7af-d40f-acc25910d43a
---

# Microsoft Edge Browser Policy Documentation AutofillAddressEnabled | Microsoft Learn

## Enable AutoFill for addresses

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 69
- iOS: ≥ 145

## Description

Enables the AutoFill feature and allows users to autocomplete address information in web forms through previously stored information.

If you have enabled or not configured this policy, users manage AutoFill for addresses in Microsoft Edge settings. AutoFill allows users to complete address fields in web forms using previously saved information.

If you have disabled this policy, Microsoft Edge doesn't suggest, fill in, or save address information. AutoFill is also disabled for all web forms except payment and password fields, and previously saved addresses aren't available.

If you disable this policy, then [EdgeAutofillMlEnabled](edgeautofillmlenabled) is turned off.

If you disable this policy, all activities for all web forms are stopped, except payment and password forms. No further entries are saved, and Microsoft Edge doesn't suggest or AutoFill any previous entries.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AutofillAddressEnabled
- GP name: Enable AutoFill for addresses
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AutofillAddressEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: AutofillAddressEnabled
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: AutofillAddressEnabled
- Example value:

```
false
```

## iOS information and settings

- Preference Key name: AutofillAddressEnabled
- Example value:

```xml
<false/>
```