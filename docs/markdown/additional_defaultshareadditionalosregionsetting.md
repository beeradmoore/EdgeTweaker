---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DefaultShareAdditionalOSRegionSetting | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/defaultshareadditionalosregionsetting
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Set the default &quot;share additional operating system region&quot; setting'
locale: en-us
document_id: 03c8ad7c-effa-6118-5590-be5834cc8b23
document_version_independent_id: 03c8ad7c-effa-6118-5590-be5834cc8b23
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DefaultShareAdditionalOSRegionSetting.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/DefaultShareAdditionalOSRegionSetting.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 475
asset_id: microsoft-edge-policies/defaultshareadditionalosregionsetting
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DefaultShareAdditionalOSRegionSetting.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2b916d3c-b5c1-e241-9933-f479cbe1329b
---

# Microsoft Edge Browser Policy Documentation DefaultShareAdditionalOSRegionSetting | Microsoft Learn

## Set the default "share additional operating system region" setting

## Supported versions

- Windows: ≥ 108
- macOS: ≥ 108
- Android: Not supported
- iOS: Not supported

## Description

This policy controls the default value for the "share additional operating system region" setting in Microsoft Edge.

The "share additional operating system region" Microsoft Edge setting controls whether the OS Regional format setting is shared with the web through the default JavaScript locale. If shared, websites can query the OS Regional format using JavaScript code, for example; "Intl.DateTimeFormat().resolvedOptions().locale". The default value for the setting is "Limited".

If you set this policy to "Limited", the OS Regional format is shared only if its language part matches the Microsoft Edge display language.

If you set this policy to "Always", the OS Regional format is always shared. This value could cause unexpected website behavior if the OS Regional format language is different from the Microsoft Edge display language. For example, if a website uses the JavaScript default locale to format dates, the names of the days and months are displayed in one language while the surrounding text is displayed in another language.

If you set this policy to "Never", the OS Regional format is never shared.

Example 1: In this example the OS Regional format is set to "en-GB", and the browser display language is set to "en-US". Then the OS Regional format is shared if the policy is set to "Limited", or "Always".

Example 2: In this example the OS Regional format is set to "es-MX", and the browser display language is set to "en-US". Then the OS Regional format is shared if the policy is set to "Always"; however, the OS Regional format isn't shared if the policy is set to "Limited".

For more information about this setting, see https://go.microsoft.com/fwlink/?linkid=2222282.

Policy options mapping:

- Limited (0) = Limited
- Always (1) = Always share the OS Regional format
- Never (2) = Never share the OS Regional format

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Limited (0) = Limited
- Always (1) = Always share the OS Regional format
- Never (2) = Never share the OS Regional format

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

- GP unique name: DefaultShareAdditionalOSRegionSetting
- GP name: Set the default "share additional operating system region" setting
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Limited
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: DefaultShareAdditionalOSRegionSetting
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: DefaultShareAdditionalOSRegionSetting
- Example value:

```xml
<integer>0</integer>
```