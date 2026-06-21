---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation MandatoryExtensionsForInPrivateNavigation | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/mandatoryextensionsforinprivatenavigation
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specify extensions users must allow in order to navigate using InPrivate mode'
locale: en-us
document_id: 28643a19-0d61-dcc8-7a5a-968e272aacfb
document_version_independent_id: 28643a19-0d61-dcc8-7a5a-968e272aacfb
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/MandatoryExtensionsForInPrivateNavigation.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/MandatoryExtensionsForInPrivateNavigation.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 229
asset_id: microsoft-edge-policies/mandatoryextensionsforinprivatenavigation
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/MandatoryExtensionsForInPrivateNavigation.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: c0d0e27c-b531-8102-0a67-62b4b0a04cde
---

# Microsoft Edge Browser Policy Documentation MandatoryExtensionsForInPrivateNavigation | Microsoft Learn

## Specify extensions users must allow in order to navigate using InPrivate mode

## Supported versions

- Windows: ≥ 139
- macOS: ≥ 139
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you specify a list of extension IDs that the user must explicitly allow to run in InPrivate mode in order to enable InPrivate browsing.

If users don't allow all listed extensions to run in InPrivate mode, they're unable to navigate using InPrivate.

If any extension in the list isn't installed, InPrivate navigation is blocked.

This policy only applies when InPrivate mode is enabled. If InPrivate mode is disabled using the InPrivateModeAvailability policy, this policy has no effect.

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

- GP unique name: MandatoryExtensionsForInPrivateNavigation
- GP name: Specify extensions users must allow in order to navigate using InPrivate mode
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
abcdefghijklmnopabcdefghijklmnop
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\MandatoryExtensionsForInPrivateNavigation
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\MandatoryExtensionsForInPrivateNavigation\1 =

```
abcdefghijklmnopabcdefghijklmnop
```

## Mac information and settings

- Preference Key name: MandatoryExtensionsForInPrivateNavigation
- Example value:

```xml
<array>
  <string>abcdefghijklmnopabcdefghijklmnop</string>
</array>
```