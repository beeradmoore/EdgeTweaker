---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NativeMessagingBlocklist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nativemessagingblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure native messaging block list'
locale: en-us
document_id: 08019f7f-c21a-87db-9076-0e6fd3bcadc8
document_version_independent_id: 08019f7f-c21a-87db-9076-0e6fd3bcadc8
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NativeMessagingBlocklist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/e6b30ca4c90b64b1ae53d6496833c9718b73975a/edgeenterprise/microsoft-edge-policies/NativeMessagingBlocklist.md
git_commit_id: e6b30ca4c90b64b1ae53d6496833c9718b73975a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 183
asset_id: microsoft-edge-policies/nativemessagingblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NativeMessagingBlocklist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a34a7653-23b4-c87f-ee2c-b174c31b4c89
---

# Microsoft Edge Browser Policy Documentation NativeMessagingBlocklist | Microsoft Learn

## Configure native messaging block list

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Setting this policy specifies which native messaging hosts shouldn't be loaded. A deny list value of \* means all native messaging hosts are denied unless they're explicitly allowed.

If you leave this policy unset, Microsoft Edge loads all installed native messaging hosts.

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

- GP unique name: NativeMessagingBlocklist
- GP name: Configure native messaging block list
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Native Messaging
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
com.native.messaging.host.name1
```

```
com.native.messaging.host.name2
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\NativeMessagingBlocklist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\NativeMessagingBlocklist\1 =

```
com.native.messaging.host.name1
```

SOFTWARE\Policies\Microsoft\Edge\NativeMessagingBlocklist\2 =

```
com.native.messaging.host.name2
```

## Mac information and settings

- Preference Key name: NativeMessagingBlocklist
- Example value:

```xml
<array>
  <string>com.native.messaging.host.name1</string>
  <string>com.native.messaging.host.name2</string>
</array>
```