---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AlternateErrorPagesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/alternateerrorpagesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Suggest similar pages when a webpage can&#x27;t be found'
locale: en-us
document_id: e04a8181-877e-f080-3bb1-2547a4cce12f
document_version_independent_id: e04a8181-877e-f080-3bb1-2547a4cce12f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AlternateErrorPagesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AlternateErrorPagesEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 315
asset_id: microsoft-edge-policies/alternateerrorpagesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AlternateErrorPagesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/12ed19f9-ebdf-4c8a-8bcd-7a681836774d
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3a764584-4f97-452b-8f1d-36f19b12f6ae
platformId: cc10d4cf-3fdd-5625-5ac4-2c1328227e6b
---

# Microsoft Edge Browser Policy Documentation AlternateErrorPagesEnabled | Microsoft Learn

## Suggest similar pages when a webpage can't be found

## Supported versions

- Windows: ≥ 80
- macOS: ≥ 80
- Android: ≥ 30
- iOS: Not supported

## Description

Allow Microsoft Edge to issue a connection to a web service to generate URL and search suggestions for connectivity issues such as DNS errors.

If you enable this policy, a web service is used to generate url and search suggestions for network errors.

If you disable this policy, no calls to the web service are made and a standard error page is shown.

If you don't configure this policy, Microsoft Edge respects the user preference that's set under Services at edge://settings/privacy. Specifically, there's a **Suggest similar pages when a webpage can't be found** toggle, which the user can switch on or off. If you enable this policy (AlternateErrorPagesEnabled), the **Suggest similar pages when a webpage can't be found** setting is turned on, but the user can't change the setting by using the toggle. If you disable this policy, the **Suggest similar pages when a webpage can't be found** setting is turned off, and the user can't change the setting by using the toggle.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AlternateErrorPagesEnabled
- GP name: Suggest similar pages when a webpage can't be found
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: AlternateErrorPagesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: AlternateErrorPagesEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: AlternateErrorPagesEnabled
- Example value:

```
true
```