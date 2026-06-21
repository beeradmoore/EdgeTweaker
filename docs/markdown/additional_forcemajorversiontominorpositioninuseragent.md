---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceMajorVersionToMinorPositionInUserAgent | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcemajorversiontominorpositioninuseragent
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable or disable freezing the User-Agent string at major version 99 (obsolete)'
locale: en-us
document_id: 1025727f-08e3-32be-ad23-220d5b163cf8
document_version_independent_id: 1025727f-08e3-32be-ad23-220d5b163cf8
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceMajorVersionToMinorPositionInUserAgent.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ForceMajorVersionToMinorPositionInUserAgent.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 451
asset_id: microsoft-edge-policies/forcemajorversiontominorpositioninuseragent
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceMajorVersionToMinorPositionInUserAgent.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d2cb12e1-d19a-3f97-e9d5-84222efa9d8d
---

# Microsoft Edge Browser Policy Documentation ForceMajorVersionToMinorPositionInUserAgent | Microsoft Learn

## Enable or disable freezing the User-Agent string at major version 99 (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 117.

## Supported versions

- Windows: 99-117
- macOS: 99-117
- Android: Not supported
- iOS: Not supported

## Description

This policy was removed in Microsoft Edge 118 and is ignored if configured.

This policy controls whether the User-Agent string major version should be frozen at 99.

The User-Agent request header lets websites identify the application, operating system, vendor, and/or version of the requesting user agent. Some websites make assumptions about how this header is formatted and may encounter issues with version strings that include three digits in the major position (for example, 100.0.0.0).

If you set this policy to 'Default' or don't configure it, then it defaults to browser settings for the User-Agent string major version. If you set this policy to 'ForceEnabled', the User-Agent string will always report the major version as 99 and include the browser's major version in the minor position. For example, browser version 101.0.0.0 would send a User-Agent request header that reports version 99.101.0.0. If you set this policy to 'ForceDisabled', the User-Agent string won't freeze the major version.

This policy is temporary and will be deprecated in the future. If this policy and User-Agent Reduction are both enabled, the User-Agent version string will always be 99.0.0.0.

Policy options mapping:

- Default (0) = Default to browser settings for User-Agent string version.
- ForceDisabled (1) = The User-Agent string won't freeze the major version.
- ForceEnabled (2) = The User-Agent string will freeze the major version as 99 and include the browser's major version in the minor position.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Default to browser settings for User-Agent string version.
- ForceDisabled (1) = The User-Agent string won't freeze the major version.
- ForceEnabled (2) = The User-Agent string will freeze the major version as 99 and include the browser's major version in the minor position.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceMajorVersionToMinorPositionInUserAgent
- GP name: Enable or disable freezing the User-Agent string at major version 99 (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Default to browser settings for User-Agent string version.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ForceMajorVersionToMinorPositionInUserAgent
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ForceMajorVersionToMinorPositionInUserAgent
- Example value:

```xml
<integer>0</integer>
```