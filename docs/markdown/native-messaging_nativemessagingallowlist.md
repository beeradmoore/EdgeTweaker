---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation NativeMessagingAllowlist | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/nativemessagingallowlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control which native messaging hosts users can use'
locale: en-us
document_id: ef368bc5-d86e-8bc6-da7c-ad8fb062288f
document_version_independent_id: ef368bc5-d86e-8bc6-da7c-ad8fb062288f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/NativeMessagingAllowlist.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/NativeMessagingAllowlist.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 207
asset_id: microsoft-edge-policies/nativemessagingallowlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/NativeMessagingAllowlist.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 4ac06fca-df50-c9f6-7300-e7b73d896c69
---

# Microsoft Edge Browser Policy Documentation NativeMessagingAllowlist | Microsoft Learn

## Control which native messaging hosts users can use

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Setting the policy specifies which native messaging hosts aren't subject to the deny list. A deny list value of \* means all native messaging hosts are denied unless they're explicitly allowed.

All native messaging hosts are allowed by default. However, if a native messaging host is denied by policy, the admin can use the allow list to change that policy.

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

- GP unique name: NativeMessagingAllowlist
- GP name: Control which native messaging hosts users can use
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\NativeMessagingAllowlist
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\NativeMessagingAllowlist\1 =

```
com.native.messaging.host.name1
```

SOFTWARE\Policies\Microsoft\Edge\NativeMessagingAllowlist\2 =

```
com.native.messaging.host.name2
```

## Mac information and settings

- Preference Key name: NativeMessagingAllowlist
- Example value:

```xml
<array>
  <string>com.native.messaging.host.name1</string>
  <string>com.native.messaging.host.name2</string>
</array>
```