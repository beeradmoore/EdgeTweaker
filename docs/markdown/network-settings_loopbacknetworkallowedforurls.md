---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LoopbackNetworkAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/loopbacknetworkallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow sites to make network requests to the local device.'
locale: en-us
document_id: ca88afc9-1434-03a9-414b-fdefe095e9fa
document_version_independent_id: ca88afc9-1434-03a9-414b-fdefe095e9fa
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LoopbackNetworkAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/LoopbackNetworkAllowedForUrls.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 307
asset_id: microsoft-edge-policies/loopbacknetworkallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LoopbackNetworkAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: ed20d97e-a89f-c4e9-c067-b46460c58218
---

# Microsoft Edge Browser Policy Documentation LoopbackNetworkAllowedForUrls | Microsoft Learn

## Allow sites to make network requests to the local device.

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

Specifies a list of URL patterns for which requests initiated from matching origins are exempt from Local Network Access restrictions when accessing loopback addresses (127.0.0.1, ::1, localhost).

If a requesting origin matches a URL pattern specified in this policy, requests to loopback addresses are allowed and are not subject to Local Network Access restrictions.

For origins not covered by this policy, the user's personal settings and local network access restrictions apply.

If this policy is disabled or not configured, no additional exemptions are granted beyond the user's existing configuration.

Multiple policies can specify origins that affect requests to the local device. If an origin matches more than one of the following policies, they are applied in the following order of precedence:

- LoopbackNetworkBlockedForUrls
- LoopbackNetworkAllowedForUrls
- LocalNetworkAccessBlockedForUrls
- LocalNetworkAccessAllowedForUrls

For guidance on valid URL pattern syntax, see [Enterprise policy URL pattern format](/en-us/deployedge/edge-learnmore-ent-policy-url-patterns) .

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

- GP unique name: LoopbackNetworkAllowedForUrls
- GP name: Allow sites to make network requests to the local device.
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Network settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
http://www.example.com:8080
```

```
[*.]example.edu
```

```
*
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LoopbackNetworkAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LoopbackNetworkAllowedForUrls\1 =

```
http://www.example.com:8080
```

SOFTWARE\Policies\Microsoft\Edge\LoopbackNetworkAllowedForUrls\2 =

```
[*.]example.edu
```

SOFTWARE\Policies\Microsoft\Edge\LoopbackNetworkAllowedForUrls\3 =

```
*
```

## Mac information and settings

- Preference Key name: LoopbackNetworkAllowedForUrls
- Example value:

```xml
<array>
  <string>http://www.example.com:8080</string>
  <string>[*.]example.edu</string>
  <string>*</string>
</array>
```

## Android information and settings

- Preference Key name: LoopbackNetworkAllowedForUrls
- Example value:

```
["http://www.example.com:8080", "[*.]example.edu", "*"]
```