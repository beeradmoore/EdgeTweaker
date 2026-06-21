---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebUsbBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webusbblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block WebUSB on specific sites'
locale: en-us
document_id: 63222547-5e91-2527-355f-167c22dcfacc
document_version_independent_id: 63222547-5e91-2527-355f-167c22dcfacc
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebUsbBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/WebUsbBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 232
asset_id: microsoft-edge-policies/webusbblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebUsbBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 55c35385-4f4c-920f-b6f9-d506cbc8dd69
---

# Microsoft Edge Browser Policy Documentation WebUsbBlockedForUrls | Microsoft Learn

## Block WebUSB on specific sites

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 138
- iOS: Not supported

## Description

Define a list of sites, based on URL patterns, that can't ask the user to grant them access to a USB device.

If you don't configure this policy, the global default value from the [DefaultWebUsbGuardSetting](defaultwebusbguardsetting) policy (if set) or the user's personal configuration is used for all sites.

URL patterns in this policy can't conflict with those configured in the [WebUsbAskForUrls](webusbaskforurls) policy. You can't both allow and block a URL. For detailed information on valid url patterns, see https://go.microsoft.com/fwlink/?linkid=2095322.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: WebUsbBlockedForUrls
- GP name: Block WebUSB on specific sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\WebUsbBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\WebUsbBlockedForUrls\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\WebUsbBlockedForUrls\2 =

```
[*.]contoso.edu
```

## Mac information and settings

- Preference Key name: WebUsbBlockedForUrls
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
</array>
```

## Android information and settings

- Preference Key name: WebUsbBlockedForUrls
- Example value:

```
["https://www.contoso.com", "[*.]contoso.edu"]
```