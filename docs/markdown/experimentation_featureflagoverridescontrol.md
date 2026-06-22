---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation FeatureFlagOverridesControl | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/featureflagoverridescontrol
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure users ability to override feature flags'
locale: en-us
document_id: 7d3cb44b-429c-1610-a8c6-1a7b1a90487d
document_version_independent_id: 7d3cb44b-429c-1610-a8c6-1a7b1a90487d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/FeatureFlagOverridesControl.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/FeatureFlagOverridesControl.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 310
asset_id: microsoft-edge-policies/featureflagoverridescontrol
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/FeatureFlagOverridesControl.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 577e99a7-fa23-9931-b735-d4ad0911d2e3
---

# Microsoft Edge Browser Policy Documentation FeatureFlagOverridesControl | Microsoft Learn

## Configure users ability to override feature flags

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

Configures users ability to override state of feature flags. If you set this policy to 'CommandLineOverridesEnabled', users can override state of feature flags using command line arguments but not edge://flags page.

If you set this policy to 'OverridesEnabled', users can override state of feature flags using command line arguments or edge://flags page.

If you set this policy to 'OverridesDisabled', users can't override state of feature flags using command line arguments or edge://flags page.

If you don't configure this policy, the behavior is the same as the 'OverridesEnabled'.

Policy options mapping:

- CommandLineOverridesEnabled (2) = Allow users to override feature flags using command line arguments only
- OverridesEnabled (1) = Allow users to override feature flags
- OverridesDisabled (0) = Prevent users from overriding feature flags

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- CommandLineOverridesEnabled (2) = Allow users to override feature flags using command line arguments only
- OverridesEnabled (1) = Allow users to override feature flags
- OverridesDisabled (0) = Prevent users from overriding feature flags

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: FeatureFlagOverridesControl
- GP name: Configure users ability to override feature flags
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Experimentation
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Allow users to override feature flags
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: FeatureFlagOverridesControl
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: FeatureFlagOverridesControl
- Example value:

```xml
<integer>1</integer>
```