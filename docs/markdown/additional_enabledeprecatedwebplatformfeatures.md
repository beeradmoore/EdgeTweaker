---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnableDeprecatedWebPlatformFeatures | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enabledeprecatedwebplatformfeatures
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Re-enable deprecated web platform features for a limited time (obsolete)'
locale: en-us
document_id: 7601ae92-fd59-2296-ed87-e7a34b2d4e0b
document_version_independent_id: 7601ae92-fd59-2296-ed87-e7a34b2d4e0b
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnableDeprecatedWebPlatformFeatures.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/EnableDeprecatedWebPlatformFeatures.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 362
asset_id: microsoft-edge-policies/enabledeprecatedwebplatformfeatures
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnableDeprecatedWebPlatformFeatures.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 78f0bb7a-61b6-9135-bfa4-ba0bde320787
---

# Microsoft Edge Browser Policy Documentation EnableDeprecatedWebPlatformFeatures | Microsoft Learn

## Re-enable deprecated web platform features for a limited time (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 86.

## Supported versions

- Windows: 77-86
- macOS: 77-86
- Android: 37-86
- iOS: Not supported

## Description

This policy is obsolete because dedicated web platform policies are now used to manage individual web platform feature deprecations.

Specify a list of deprecated web platform features to temporarily re-enable.

This policy lets you re-enable deprecated web platform features for a limited time. Features are identified by a string tag.

If you don't configure this policy, if the list is empty, or if a feature doesn't match one of the supported string tags, all deprecated web platform features remain disabled.

While the policy itself is supported on the above platforms, the feature it's enabling might not be available on all of those platforms. Not all deprecated Web Platform features can be re-enabled. Only the following explicitly listed features can be re-enabled, and only for a limited period of time, which differs per feature. You can review the intent behind the Web Platform feature changes at https://bit.ly/blinkintents.

The general format of the string tag is [DeprecatedFeatureName]\_EffectiveUntil[yyyymmdd].

Policy options mapping:

- ExampleDeprecatedFeature (ExampleDeprecatedFeature\_EffectiveUntil20080902) = Enable ExampleDeprecatedFeature API through 2008/09/02

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- ExampleDeprecatedFeature (ExampleDeprecatedFeature\_EffectiveUntil20080902) = Enable ExampleDeprecatedFeature API through 2008/09/02

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

- GP unique name: EnableDeprecatedWebPlatformFeatures
- GP name: Re-enable deprecated web platform features for a limited time (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enable ExampleDeprecatedFeature API through 2008/09/02
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\EnableDeprecatedWebPlatformFeatures
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\EnableDeprecatedWebPlatformFeatures\1 =

```
ExampleDeprecatedFeature_EffectiveUntil20080902
```

## Mac information and settings

- Preference Key name: EnableDeprecatedWebPlatformFeatures
- Example value:

```xml
<array>
  <string>ExampleDeprecatedFeature_EffectiveUntil20080902</string>
</array>
```

## Android information and settings

- Preference Key name: EnableDeprecatedWebPlatformFeatures
- Example value:

```
["ExampleDeprecatedFeature_EffectiveUntil20080902"]
```