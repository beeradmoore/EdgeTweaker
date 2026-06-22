---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TrackingPrevention | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/trackingprevention
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block tracking of users&#x27; web-browsing activity'
locale: en-us
document_id: ec3f679b-856f-a13f-5018-af102c32e983
document_version_independent_id: ec3f679b-856f-a13f-5018-af102c32e983
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TrackingPrevention.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/TrackingPrevention.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 335
asset_id: microsoft-edge-policies/trackingprevention
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TrackingPrevention.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 22092447-cead-4fc2-23db-dc6f9adae0fa
---

# Microsoft Edge Browser Policy Documentation TrackingPrevention | Microsoft Learn

## Block tracking of users' web-browsing activity

## Supported versions

- Windows: ≥ 78
- macOS: ≥ 78
- Android: Not supported
- iOS: Not supported

## Description

Lets you decide whether to block websites from tracking users' web-browsing activity.

If you disable this policy or don't configure it, users set their own level of tracking prevention.

Policy options mapping:

- TrackingPreventionOff (0) = Off (no tracking prevention)
- TrackingPreventionBasic (1) = Basic (blocks harmful trackers, content and ads will be personalized)
- TrackingPreventionBalanced (2) = Balanced (blocks harmful trackers and trackers from sites user has not visited; content and ads will be less personalized)
- TrackingPreventionStrict (3) = Strict (blocks harmful trackers and majority of trackers from all sites; content and ads will have minimal personalization. Some parts of sites might not work)

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- TrackingPreventionOff (0) = Off (no tracking prevention)
- TrackingPreventionBasic (1) = Basic (blocks harmful trackers, content and ads will be personalized)
- TrackingPreventionBalanced (2) = Balanced (blocks harmful trackers and trackers from sites user has not visited; content and ads will be less personalized)
- TrackingPreventionStrict (3) = Strict (blocks harmful trackers and majority of trackers from all sites; content and ads will have minimal personalization. Some parts of sites might not work)

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

- GP unique name: TrackingPrevention
- GP name: Block tracking of users' web-browsing activity
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Balanced (blocks harmful trackers and trackers from sites user has not visited; content and ads will be less personalized)
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: TrackingPrevention
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: TrackingPrevention
- Example value:

```xml
<integer>2</integer>
```