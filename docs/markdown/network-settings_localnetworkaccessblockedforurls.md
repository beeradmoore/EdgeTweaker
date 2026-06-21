---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalNetworkAccessBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localnetworkaccessblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block sites from making network requests to local devices and local network endpoints.'
locale: en-us
document_id: 1dbe75aa-5796-6488-77fb-3340907d193e
document_version_independent_id: 1dbe75aa-5796-6488-77fb-3340907d193e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/LocalNetworkAccessBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 320
asset_id: microsoft-edge-policies/localnetworkaccessblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalNetworkAccessBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: c47b7c09-d4e2-5da7-8577-02f927acde0c
---

# Microsoft Edge Browser Policy Documentation LocalNetworkAccessBlockedForUrls | Microsoft Learn

## Block sites from making network requests to local devices and local network endpoints.

## Supported versions

- Windows: ≥ 140
- macOS: ≥ 140
- Android: ≥ 144
- iOS: Not supported

## Description

Specifies a list of URL patterns for which requests initiated from matching origins are blocked from issuing Local Network Access requests.

Network requests initiated from websites served by matching origins are prevented from accessing local device and local network endpoints.

For origins not covered by the patterns specified here, the user's personal configuration applies.

There are multiple policies that control origins impacting requests to local device and local network endpoints. If an origin matches more than one of the following policies, the policies take precedence in the following order:

- LocalNetworkBlockedForUrls
- LocalNetworkAllowedForUrls
- LoopbackNetworkAccessBlockedForUrls
- LoopbackNetworkAccessAllowedForUrls
- LocalNetworkAccessBlockedForUrls
- LocalNetworkAccessAllowedForUrls

For detailed information about valid URL pattern syntax, see: [Enterprise policy URL pattern format](/en-us/deployedge/edge-learnmore-ent-policy-url-patterns)

For more information about Local Network Access, see: https://wicg.github.io/local-network-access/

Note: This policy blocks specified public websites from accessing private IP addresses. It helps reduce exposure of internal network resources unless access is explicitly permitted by policy.

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

- GP unique name: LocalNetworkAccessBlockedForUrls
- GP name: Block sites from making network requests to local devices and local network endpoints.
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessBlockedForUrls\1 =

```
http://www.example.com:8080
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessBlockedForUrls\2 =

```
[*.]example.edu
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkAccessBlockedForUrls\3 =

```
*
```

## Mac information and settings

- Preference Key name: LocalNetworkAccessBlockedForUrls
- Example value:

```xml
<array>
  <string>http://www.example.com:8080</string>
  <string>[*.]example.edu</string>
  <string>*</string>
</array>
```

## Android information and settings

- Preference Key name: LocalNetworkAccessBlockedForUrls
- Example value:

```
["http://www.example.com:8080", "[*.]example.edu", "*"]
```