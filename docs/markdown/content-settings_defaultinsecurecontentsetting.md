---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultInsecureContentSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultinsecurecontentsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control use of insecure content exceptions'
locale: en-us
document_id: 7293a8d7-ba7a-7776-fdbb-7d2d8dcb586a
document_version_independent_id: 7293a8d7-ba7a-7776-fdbb-7d2d8dcb586a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultInsecureContentSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DefaultInsecureContentSetting.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 257
asset_id: microsoft-edge-policies/defaultinsecurecontentsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultInsecureContentSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 57418b2e-c1e4-d9d1-1512-619127137b6b
---

# Microsoft Edge Browser Policy Documentation DefaultInsecureContentSetting | Microsoft Learn

## Control use of insecure content exceptions

## Supported versions

- Windows: ≥ 80
- macOS: ≥ 80
- Android: Not supported
- iOS: Not supported

## Description

Allows you to set whether users can add exceptions to allow mixed content for specific sites.

This policy can be overridden for specific URL patterns using the [InsecureContentAllowedForUrls](insecurecontentallowedforurls) and [InsecureContentBlockedForUrls](insecurecontentblockedforurls) policies.

If this policy isn't set, users are allowed to add exceptions to allow blockable mixed content and disable autoupgrades for optionally blockable mixed content.

Policy options mapping:

- BlockInsecureContent (2) = Don't allow any site to load mixed content
- AllowExceptionsInsecureContent (3) = Allow users to add exceptions to allow mixed content

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- BlockInsecureContent (2) = Don't allow any site to load mixed content
- AllowExceptionsInsecureContent (3) = Allow users to add exceptions to allow mixed content

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

- GP unique name: DefaultInsecureContentSetting
- GP name: Control use of insecure content exceptions
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Don't allow any site to load mixed content
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DefaultInsecureContentSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DefaultInsecureContentSetting
- Example value:

```xml
<integer>2</integer>
```