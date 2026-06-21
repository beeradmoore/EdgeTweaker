---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation RelatedMatchesCloudServiceEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/relatedmatchescloudserviceenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Related Matches in Find on Page (obsolete)'
locale: en-us
document_id: a1136284-1ea5-fb11-249e-8b6f9d54965a
document_version_independent_id: a1136284-1ea5-fb11-249e-8b6f9d54965a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/RelatedMatchesCloudServiceEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/RelatedMatchesCloudServiceEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 246
asset_id: microsoft-edge-policies/relatedmatchescloudserviceenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/RelatedMatchesCloudServiceEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e1effa42-6c6d-7b28-d820-d0fc08d04877
---

# Microsoft Edge Browser Policy Documentation RelatedMatchesCloudServiceEnabled | Microsoft Learn

## Configure Related Matches in Find on Page (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 134.

## Supported versions

- Windows: 99-134
- macOS: 99-134
- Android: Not supported
- iOS: Not supported

## Description

Specifies how the user receives related matches in Find on Page, which provides spellcheck, synonyms, and Q&A results in Microsoft Edge.

If you enable or don't configure this policy, users can receive related matches in Find on Page on all sites. The results are processed through a cloud service.

If you disable this policy, users can receive related matches in Find on Page on a limited set of sites. In this case, results are processed locally on the user's device.

Note: This policy is obsolete. The associated cloud service is discontinued, so the feature and policy aren't supported on any versions of Microsoft Edge.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: RelatedMatchesCloudServiceEnabled
- GP name: Configure Related Matches in Find on Page (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: RelatedMatchesCloudServiceEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: RelatedMatchesCloudServiceEnabled
- Example value:

```xml
<true/>
```