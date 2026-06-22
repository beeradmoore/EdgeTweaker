---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutomaticHttpsDefault | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/automatichttpsdefault
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Automatic HTTPS (obsolete)'
locale: en-us
document_id: 8f647a86-5bc5-b4ae-2810-ec1f1d0512f3
document_version_independent_id: 8f647a86-5bc5-b4ae-2810-ec1f1d0512f3
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutomaticHttpsDefault.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/AutomaticHttpsDefault.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 369
asset_id: microsoft-edge-policies/automatichttpsdefault
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutomaticHttpsDefault.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 76855530-882b-4156-b42e-296d80eb36b3
---

# Microsoft Edge Browser Policy Documentation AutomaticHttpsDefault | Microsoft Learn

## Configure Automatic HTTPS (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 139.

## Supported versions

- Windows: 92-139
- macOS: 92-139
- Android: Not supported
- iOS: Not supported

## Description

This policy lets you manage settings for [AutomaticHttpsDefault](automatichttpsdefault), which switches connections from HTTP to HTTPS.

This feature helps protect against man-in-the-middle attacks by enforcing more secure connections, but users might experience more connection errors.

Microsoft Edge attempts to upgrade some navigations from HTTP to HTTPS, when possible. This policy can be used to disable this behavior. If set to "AlwaysUpgrade" or left unset, this feature is enabled by default.

The separate HttpAllowlist policy can be used to exempt specific hostnames or hostname patterns from being upgraded to HTTPS by this feature.

This policy is obsolete, and is replaced with the policy [HttpsUpgradesEnabled](httpsupgradesenabled).

Policy options mapping:

- DisableAutomaticHttps (0) = Automatic HTTPS functionality is disabled.
- UpgradeCapableDomains (1) = (Deprecated) Navigations delivered over HTTP are switched to HTTPS, only on domains likely to support HTTPS.
- AlwaysUpgrade (2) = All navigations delivered over HTTP are switched to HTTPS. Connection errors might occur more often.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- DisableAutomaticHttps (0) = Automatic HTTPS functionality is disabled.
- UpgradeCapableDomains (1) = (Deprecated) Navigations delivered over HTTP are switched to HTTPS, only on domains likely to support HTTPS.
- AlwaysUpgrade (2) = All navigations delivered over HTTP are switched to HTTPS. Connection errors might occur more often.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AutomaticHttpsDefault
- GP name: Configure Automatic HTTPS (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
All navigations delivered over HTTP are switched to HTTPS. Connection errors might occur more often.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AutomaticHttpsDefault
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: AutomaticHttpsDefault
- Example value:

```xml
<integer>2</integer>
```