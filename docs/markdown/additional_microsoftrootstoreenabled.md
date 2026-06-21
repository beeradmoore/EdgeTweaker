---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MicrosoftRootStoreEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/microsoftrootstoreenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Determines whether the Microsoft Root Store and built-in certificate verifier will be used to verify server certificates (obsolete)'
locale: en-us
document_id: 64c676d5-ba34-1a72-39a5-312c2df462cd
document_version_independent_id: 64c676d5-ba34-1a72-39a5-312c2df462cd
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MicrosoftRootStoreEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/MicrosoftRootStoreEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 302
asset_id: microsoft-edge-policies/microsoftrootstoreenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MicrosoftRootStoreEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e4acdfe5-f4f3-3e37-27e1-553d8879254e
---

# Microsoft Edge Browser Policy Documentation MicrosoftRootStoreEnabled | Microsoft Learn

## Determines whether the Microsoft Root Store and built-in certificate verifier will be used to verify server certificates (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 121.

## Supported versions

- Windows: 109-114
- macOS: 109-114
- Android: 114-121
- iOS: Not supported

## Description

If you enable this policy, Microsoft Edge performs verification of server certificates using the built-in certificate verifier with the Microsoft Root Store as the source of public trust.

If you disable this policy, Microsoft Edge uses the system certificate verifier and system root certificates.

If you don't configure this policy, the Microsoft Root Store or system-provided roots may be used.

This policy is planned to be removed in Microsoft Edge version 121 for Android devices when support for using the platform-supplied roots is planned to be removed.

This policy was removed in Microsoft Edge version 115 for Microsoft Windows and macOS, Microsoft Edge version 120 for Linux, and Microsoft Edge version 121 for Android when support for using the platform-supplied certificate verifier and roots was removed.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: MicrosoftRootStoreEnabled
- GP name: Determines whether the Microsoft Root Store and built-in certificate verifier will be used to verify server certificates (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: MicrosoftRootStoreEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: MicrosoftRootStoreEnabled
- Example value:

```xml
<false/>
```

## Android information and settings

- Preference Key name: MicrosoftRootStoreEnabled
- Example value:

```
false
```