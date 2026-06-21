---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation FileOrDirectoryPickerWithoutGestureAllowedForOrigins | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/fileordirectorypickerwithoutgestureallowedfororigins
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow file or directory picker APIs to be called without prior user gesture'
locale: en-us
document_id: 4a50ce60-882d-571f-f45a-5d912d4e051e
document_version_independent_id: 4a50ce60-882d-571f-f45a-5d912d4e051e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/FileOrDirectoryPickerWithoutGestureAllowedForOrigins.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/FileOrDirectoryPickerWithoutGestureAllowedForOrigins.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 236
asset_id: microsoft-edge-policies/fileordirectorypickerwithoutgestureallowedfororigins
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/FileOrDirectoryPickerWithoutGestureAllowedForOrigins.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 118af133-4805-714c-8fb5-abd2f2cceed7
---

# Microsoft Edge Browser Policy Documentation FileOrDirectoryPickerWithoutGestureAllowedForOrigins | Microsoft Learn

## Allow file or directory picker APIs to be called without prior user gesture

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: Not supported
- iOS: Not supported

## Description

For security reasons, the showOpenFilePicker(), showSaveFilePicker(), and showDirectoryPicker() web APIs require a prior user gesture ("transient activation") to be called; else, they fail.

If you enable this policy, admins can specify origins on which these APIs can be called without prior user gesture.

For detailed information on valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. \* isn't an accepted value for this policy.

If you disable or don't configure this policy, all origins will require a prior user gesture to call these APIs.

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

- GP unique name: FileOrDirectoryPickerWithoutGestureAllowedForOrigins
- GP name: Allow file or directory picker APIs to be called without prior user gesture
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\FileOrDirectoryPickerWithoutGestureAllowedForOrigins
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\FileOrDirectoryPickerWithoutGestureAllowedForOrigins\1 =

```
https://www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\FileOrDirectoryPickerWithoutGestureAllowedForOrigins\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: FileOrDirectoryPickerWithoutGestureAllowedForOrigins
- Example value:

```xml
<array>
  <string>https://www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```