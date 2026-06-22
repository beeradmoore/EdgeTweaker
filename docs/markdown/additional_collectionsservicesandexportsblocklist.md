---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation CollectionsServicesAndExportsBlockList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/collectionsservicesandexportsblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block access to a specified list of services and export targets in Collections'
locale: en-us
document_id: 8adb7603-1bb3-cd9f-d7c0-869441f57f88
document_version_independent_id: 8adb7603-1bb3-cd9f-d7c0-869441f57f88
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/CollectionsServicesAndExportsBlockList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/CollectionsServicesAndExportsBlockList.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 399
asset_id: microsoft-edge-policies/collectionsservicesandexportsblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/CollectionsServicesAndExportsBlockList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6bf07875-ce45-8f14-df96-466d5a3e620a
---

# Microsoft Edge Browser Policy Documentation CollectionsServicesAndExportsBlockList | Microsoft Learn

## Block access to a specified list of services and export targets in Collections

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: Not supported
- iOS: Not supported

## Description

List specific services and export targets that users can't access in the Collections feature in Microsoft Edge. This includes displaying additional data from Bing and exporting collections to Microsoft products or external partners.

If you enable this policy, services and export targets that match the given list are blocked.

If you don't configure this policy, no restrictions on the acceptable services and export targets are enforced.

Policy options mapping:

- pinterest\_suggestions (pinterest\_suggestions) = Pinterest suggestions
- collections\_share (collections\_share) = Sharing of Collections
- local\_pdf (local\_pdf) = Save local PDFs in Collections to OneDrive
- send\_word (send\_word) = Send collection to Microsoft Word
- send\_excel (send\_excel) = Send collection to Microsoft Excel
- send\_onenote (send\_onenote) = Send collection to Microsoft OneNote
- send\_pinterest (send\_pinterest) = Send collection to Pinterest

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- pinterest\_suggestions = Pinterest suggestions
    - Windows: 86-105
    - macOS: 86-105
    - Android: Not supported
    - iOS: Not supported
- collections\_share = Sharing of Collections
- local\_pdf = Save local PDFs in Collections to OneDrive
- send\_word = Send collection to Microsoft Word
- send\_excel = Send collection to Microsoft Excel
- send\_onenote = Send collection to Microsoft OneNote
- send\_pinterest = Send collection to Pinterest
    - Windows: 86-105
    - macOS: 86-105
    - Android: Not supported
    - iOS: Not supported

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: CollectionsServicesAndExportsBlockList
- GP name: Block access to a specified list of services and export targets in Collections
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Sharing of Collections
```

```
Save local PDFs in Collections to OneDrive
```

```
Send collection to Microsoft Word
```

```
Send collection to Microsoft Excel
```

```
Send collection to Microsoft OneNote
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\CollectionsServicesAndExportsBlockList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\CollectionsServicesAndExportsBlockList\1 =

```
collections_share
```

SOFTWARE\Policies\Microsoft\Edge\CollectionsServicesAndExportsBlockList\2 =

```
local_pdf
```

SOFTWARE\Policies\Microsoft\Edge\CollectionsServicesAndExportsBlockList\3 =

```
send_word
```

SOFTWARE\Policies\Microsoft\Edge\CollectionsServicesAndExportsBlockList\4 =

```
send_excel
```

SOFTWARE\Policies\Microsoft\Edge\CollectionsServicesAndExportsBlockList\5 =

```
send_onenote
```

## Mac information and settings

- Preference Key name: CollectionsServicesAndExportsBlockList
- Example value:

```xml
<array>
  <string>collections_share</string>
  <string>local_pdf</string>
  <string>send_word</string>
  <string>send_excel</string>
  <string>send_onenote</string>
</array>
```