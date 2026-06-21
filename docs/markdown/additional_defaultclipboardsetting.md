---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultClipboardSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultclipboardsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Default clipboard site permission'
locale: en-us
document_id: 0619cde2-7cf7-6cae-363e-7e033984efc6
document_version_independent_id: 0619cde2-7cf7-6cae-363e-7e033984efc6
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultClipboardSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultClipboardSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 317
asset_id: microsoft-edge-policies/defaultclipboardsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultClipboardSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 13b5a162-bff8-3b6f-cbbc-5baee5501824
---

# Microsoft Edge Browser Policy Documentation DefaultClipboardSetting | Microsoft Learn

## Default clipboard site permission

## Supported versions

- Windows: ≥ 109
- macOS: ≥ 109
- Android: ≥ 146
- iOS: Not supported

## Description

This policy controls the default value for the clipboard site permission.

Setting the policy to 2 blocks sites from using the clipboard site permission.

Setting the policy to 3 or leaving it unset lets the user change the setting and decide if the clipboard APIs are available when a site wants to use an API.

This policy can be overridden for specific URL patterns using the [ClipboardAllowedForUrls](clipboardallowedforurls) and [ClipboardBlockedForUrls](clipboardblockedforurls) policies.

This policy only affects clipboard operations controlled by the clipboard site permission and doesn't affect sanitized clipboard writes or trusted copy and paste operations.

Policy options mapping:

- BlockClipboard (2) = Do not allow any site to use the clipboard site permission
- AskClipboard (3) = Allow sites to ask the user to grant the clipboard site permission

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockClipboard (2) = Do not allow any site to use the clipboard site permission
- AskClipboard (3) = Allow sites to ask the user to grant the clipboard site permission

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: DefaultClipboardSetting
- GP name: Default clipboard site permission
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Do not allow any site to use the clipboard site permission
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultClipboardSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultClipboardSetting
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: DefaultClipboardSetting
- Example value:

```
2
```