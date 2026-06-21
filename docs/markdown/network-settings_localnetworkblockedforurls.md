---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LocalNetworkBlockedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/localnetworkblockedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block sites from making network requests to local network endpoints.'
locale: en-us
document_id: b5ec1c07-6d00-d1ed-3dab-8eb2caaa3b82
document_version_independent_id: b5ec1c07-6d00-d1ed-3dab-8eb2caaa3b82
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LocalNetworkBlockedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/LocalNetworkBlockedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 303
asset_id: microsoft-edge-policies/localnetworkblockedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LocalNetworkBlockedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 5637aae6-6fb6-c6dc-ae34-ed19eb41c0d6
---

# Microsoft Edge Browser Policy Documentation LocalNetworkBlockedForUrls | Microsoft Learn

## Block sites from making network requests to local network endpoints.

## Supported versions

- Windows: ≥ 146
- macOS: ≥ 146
- Android: ≥ 146
- iOS: Not supported

## Description

Controls which website origins are blocked from making Local Network Access requests to local network endpoints.

Network requests initiated from websites that match the specified URL patterns are blocked from issuing Local Network Access requests.

For origins not covered by the patterns specified in this policy, the user's personal configuration applies.

For detailed information about valid URL patterns, see [Enterprise policy URL pattern format](/en-us/deployedge/edge-learnmore-ent-policy-url-patterns).

For more information about Local Network Access restrictions, see https://wicg.github.io/local-network-access/.

Multiple policies can list origins that affect requests to local network endpoints. If an origin matches more than one of the following policies, they take precedence in the following order:

- LocalNetworkBlockedForUrls
- LocalNetworkAllowedForUrls
- LoopbackNetworkBlockedForUrls
- LoopbackNetworkAllowedForUrls
- LocalNetworkAccessBlockedForUrls
- LocalNetworkAccessAllowedForUrls

This policy controls access to local network endpoints (private IP addresses) and can be used to block specific websites from accessing local network resources.

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

- GP unique name: LocalNetworkBlockedForUrls
- GP name: Block sites from making network requests to local network endpoints.
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LocalNetworkBlockedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkBlockedForUrls\1 =

```
http://www.example.com:8080
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkBlockedForUrls\2 =

```
[*.]example.edu
```

SOFTWARE\Policies\Microsoft\Edge\LocalNetworkBlockedForUrls\3 =

```
*
```

## Mac information and settings

- Preference Key name: LocalNetworkBlockedForUrls
- Example value:

```xml
<array>
  <string>http://www.example.com:8080</string>
  <string>[*.]example.edu</string>
  <string>*</string>
</array>
```

## Android information and settings

- Preference Key name: LocalNetworkBlockedForUrls
- Example value:

```
["http://www.example.com:8080", "[*.]example.edu", "*"]
```