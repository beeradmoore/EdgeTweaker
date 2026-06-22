---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation KeyboardFocusableScrollersEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/keyboardfocusablescrollersenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable keyboard focusable scrollers (obsolete)'
locale: en-us
document_id: 22a07037-9430-9f2c-fef1-fc61d123bc41
document_version_independent_id: 22a07037-9430-9f2c-fef1-fc61d123bc41
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/KeyboardFocusableScrollersEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/KeyboardFocusableScrollersEnabled.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 192
asset_id: microsoft-edge-policies/keyboardfocusablescrollersenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/KeyboardFocusableScrollersEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: aa6bb737-0ffb-f902-e0d0-a0c02c2814ed
---

# Microsoft Edge Browser Policy Documentation KeyboardFocusableScrollersEnabled | Microsoft Learn

## Enable keyboard focusable scrollers (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 138.

## Supported versions

- Windows: 128-138
- macOS: 128-138
- Android: Not supported
- iOS: Not supported

## Description

This policy provides a temporary opt-out for the new keyboard focusable scrollers behavior.

When this policy is Enabled or unset, scrollers without focusable children are keyboard focusable by default.

When this policy is Disabled, scrollers aren't keyboard focusable by default.

This policy is a temporary workaround. Starting in Microsoft Edge version 139, this policy is obsolete.

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

- GP unique name: KeyboardFocusableScrollersEnabled
- GP name: Enable keyboard focusable scrollers (obsolete)
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
- Value name: KeyboardFocusableScrollersEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: KeyboardFocusableScrollersEnabled
- Example value:

```xml
<true/>
```