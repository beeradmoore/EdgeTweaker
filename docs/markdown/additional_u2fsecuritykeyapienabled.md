---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation U2fSecurityKeyApiEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/u2fsecuritykeyapienabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow using the deprecated U2F Security Key API (obsolete)'
locale: en-us
document_id: ffde671e-7509-58fd-80f6-76a46143c5c9
document_version_independent_id: ffde671e-7509-58fd-80f6-76a46143c5c9
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/U2fSecurityKeyApiEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/U2fSecurityKeyApiEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 255
asset_id: microsoft-edge-policies/u2fsecuritykeyapienabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/U2fSecurityKeyApiEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 58ebe083-bdb9-747d-850a-9340dbe135e6
---

# Microsoft Edge Browser Policy Documentation U2fSecurityKeyApiEnabled | Microsoft Learn

## Allow using the deprecated U2F Security Key API (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 103.

## Supported versions

- Windows: 98-103
- macOS: 98-103
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because it was intended to be a short-term mechanism to give enterprises more time to update their web content that's incompatible with the change to remove the U2F Security Key API. It doesn't work in Microsoft Edge after version 103.

If you enable this policy, the deprecated U2F Security Key API can be used and the deprecation reminder prompt shown for U2F API requests is suppressed.

If you disable this policy or don't configure it, the U2F Security Key API is disabled by default and can only be used by sites that register for and use the U2FSecurityKeyAPI origin trial, which ended after Microsoft Edge version 103.

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

- GP unique name: U2fSecurityKeyApiEnabled
- GP name: Allow using the deprecated U2F Security Key API (obsolete)
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
- Value name: U2fSecurityKeyApiEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: U2fSecurityKeyApiEnabled
- Example value:

```xml
<true/>
```