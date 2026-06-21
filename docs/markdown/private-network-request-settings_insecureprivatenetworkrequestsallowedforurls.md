---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InsecurePrivateNetworkRequestsAllowedForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/insecureprivatenetworkrequestsallowedforurls
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow the listed sites to make requests to more-private network endpoints from in an insecure manner (obsolete)'
locale: en-us
document_id: 09436bb0-f6bb-1ee4-d649-027cab6b9ec1
document_version_independent_id: 09436bb0-f6bb-1ee4-d649-027cab6b9ec1
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InsecurePrivateNetworkRequestsAllowedForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/InsecurePrivateNetworkRequestsAllowedForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 282
asset_id: microsoft-edge-policies/insecureprivatenetworkrequestsallowedforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InsecurePrivateNetworkRequestsAllowedForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d679d845-4064-1e66-7637-7c3da8367ae7
---

# Microsoft Edge Browser Policy Documentation InsecurePrivateNetworkRequestsAllowedForUrls | Microsoft Learn

## Allow the listed sites to make requests to more-private network endpoints from in an insecure manner (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 137.

## Supported versions

- Windows: 92-137
- macOS: 92-137
- Android: Not supported
- iOS: Not supported

## Description

List of URL patterns. Requests initiated from websites served by matching origins aren't subject to Private Network Access checks.

If this policy isn't set, this policy behaves as if set to the empty list.

For origins not covered by the patterns specified here, the global default value is used either from the [InsecurePrivateNetworkRequestsAllowed](insecureprivatenetworkrequestsallowed) policy, if it's set, or the user's personal configuration otherwise.

For detailed information on valid URL patterns, see [Filter format for URL list-based policies](/en-us/DeployEdge/edge-learnmmore-url-list-filter%20format).

This policy is obsolete. The previous blanket override has been replaced by the permission-based Local Network Access model, which blocks cross-space requests until users grant explicit consent.

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

- GP unique name: InsecurePrivateNetworkRequestsAllowedForUrls
- GP name: Allow the listed sites to make requests to more-private network endpoints from in an insecure manner (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Private Network Request Settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
http://www.example.com:8080
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\InsecurePrivateNetworkRequestsAllowedForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\InsecurePrivateNetworkRequestsAllowedForUrls\1 =

```
http://www.example.com:8080
```

SOFTWARE\Policies\Microsoft\Edge\InsecurePrivateNetworkRequestsAllowedForUrls\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: InsecurePrivateNetworkRequestsAllowedForUrls
- Example value:

```xml
<array>
  <string>http://www.example.com:8080</string>
  <string>[*.]example.edu</string>
</array>
```