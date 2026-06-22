---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalNetworkAccessAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localnetworkaccessallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow sites to make network requests to local devices and local network endpoints.'
locale: en-us
document_id: 5a666e18-9416-f79e-e3c7-c53177d15d01
document_version_independent_id: 5a666e18-9416-f79e-e3c7-c53177d15d01
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessAllowedForUrls.md
git_commit_id: c3d5eb43b67b6fe282ad4810ec3e32aa8f8d46af
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 324
asset_id: microsoft-edge-policies/localnetworkaccessallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalNetworkAccessAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 67fc9dbe-ac26-6214-4ce4-233db842eab5
---

# Microsoft Edge Browser Policy Documentation LocalNetworkAccessAllowedForUrls | Microsoft Learn

## Allow sites to make network requests to local devices and local network endpoints.

## Supported versions

- Windows: ≥ 140
- macOS: ≥ 140
- Android: ≥ 144
- iOS: Not supported

## Description

Specifies a list of URL patterns for which requests initiated from matching origins are exempt from Local Network Access restrictions.

Network requests initiated from websites served by matching origins are not subject to Local Network Access checks.

For origins not covered by the patterns specified here, the user's personal configuration and applicable local network access restrictions apply.

There are multiple policies that control origins impacting requests to local device and local network endpoints. If an origin matches more than one of the following policies, the policies take precedence in the following order:

- LocalNetworkBlockedForUrls
- LocalNetworkAllowedForUrls
- LoopbackNetworkAccessBlockedForUrls
- LoopbackNetworkAccessAllowedForUrls
- LocalNetworkAccessBlockedForUrls
- LocalNetworkAccessAllowedForUrls

For detailed information about valid URL pattern syntax, see: [Enterprise policy URL pattern format](/en-us/deployedge/edge-learnmore-ent-policy-url-patterns)

For more information about Local Network Access, see: https://wicg.github.io/local-network-access/

Note: This policy enables controlled exceptions to local network access restrictions. It allows specified public websites to access private IP addresses when required for trusted local communication scenarios.

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

- GP unique name: LocalNetworkAccessAllowedForUrls
- GP name: Allow sites to make network requests to local devices and local network endpoints.
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessAllowedForUrls\1 =

```
http://www.example.com:8080
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessAllowedForUrls\2 =

```
[*.]example.edu
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessAllowedForUrls\3 =

```
*
```

## Mac information and settings

- Preference Key name: LocalNetworkAccessAllowedForUrls
- Example value:

```xml
<array>
  <string>http://www.example.com:8080</string>
  <string>[*.]example.edu</string>
  <string>*</string>
</array>
```

## Android information and settings

- Preference Key name: LocalNetworkAccessAllowedForUrls
- Example value:

```
["http://www.example.com:8080", "[*.]example.edu", "*"]
```