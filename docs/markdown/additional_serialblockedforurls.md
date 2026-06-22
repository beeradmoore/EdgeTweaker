---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SerialBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/serialblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block the Serial API on specific sites'
locale: en-us
document_id: 1f102166-a9d7-20b7-0f33-15ac2c838e29
document_version_independent_id: 1f102166-a9d7-20b7-0f33-15ac2c838e29
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SerialBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/SerialBlockedForUrls.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 229
asset_id: microsoft-edge-policies/serialblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SerialBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d541c9ee-e439-d6be-90e2-2413427b2ac6
---

# Microsoft Edge Browser Policy Documentation SerialBlockedForUrls | Microsoft Learn

## Block the Serial API on specific sites

## Supported versions

- Windows: ≥ 86
- macOS: ≥ 86
- Android: ≥ 147
- iOS: Not supported

## Description

Specifies URL patterns for sites that aren't allowed to request access to a serial port.

If not configured, Microsoft Edge uses the value from the DefaultSerialGuardSetting policy (if set), or the user's settings.

For unmatched sites, the following order applies:

1. SerialAskForUrls (if matched).
2. DefaultSerialGuardSetting (if set).
3. User's settings.

URL patterns in this policy must not conflict with those in SerialAskForUrls. This policy takes precedence.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322.

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

- GP unique name: SerialBlockedForUrls
- GP name: Block the Serial API on specific sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
[*.]contoso.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SerialBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SerialBlockedForUrls\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\SerialBlockedForUrls\2 =

```
[*.]contoso.edu
```

## Mac information and settings

- Preference Key name: SerialBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
</array>
```

## Android information and settings

- Preference Key name: SerialBlockedForUrls
- Example value:

```
["https://www.contoso.com", "[*.]contoso.edu"]
```