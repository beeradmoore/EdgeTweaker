---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ReadAloudEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/readaloudenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Read Aloud feature in Microsoft Edge'
locale: en-us
document_id: 3e909066-c18b-b7b7-2f52-adf786406a50
document_version_independent_id: 3e909066-c18b-b7b7-2f52-adf786406a50
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ReadAloudEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ReadAloudEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 253
asset_id: microsoft-edge-policies/readaloudenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ReadAloudEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f10c03a9-6a70-cf32-ca89-c7980a6bfac5
---

# Microsoft Edge Browser Policy Documentation ReadAloudEnabled | Microsoft Learn

## Enable Read Aloud feature in Microsoft Edge

## Supported versions

- Windows: ≥ 113
- macOS: ≥ 113
- Android: ≥ 145
- iOS: ≥ 145

## Description

Enables the Read Aloud feature within Microsoft Edge. With this feature, users can listen to the content on the web page. This feature enables users to multi-task or improve their reading comprehension by hearing content at their own pace.

If you enable this policy or don't configure it, the Read Aloud option shows up in the address bar, right click context menu, more menu, on the PDF toolbar, and within Immersive Reader. If you disable this policy, users can't access the Read Aloud feature from the address bar, right click context menu, more menu, on the PDF toolbar, and within Immersive Reader.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ReadAloudEnabled
- GP name: Enable Read Aloud feature in Microsoft Edge
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ReadAloudEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ReadAloudEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: ReadAloudEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: ReadAloudEnabled
- Example value:

```xml
<true/>
```