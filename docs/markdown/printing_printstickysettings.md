---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PrintStickySettings | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/printstickysettings
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Print preview sticky settings'
locale: en-us
document_id: 3c9b6380-9dc1-5008-6d15-0095d6a40c1d
document_version_independent_id: 3c9b6380-9dc1-5008-6d15-0095d6a40c1d
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PrintStickySettings.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PrintStickySettings.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 352
asset_id: microsoft-edge-policies/printstickysettings
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PrintStickySettings.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: a07bdf0d-8a0d-4e01-1c72-d2598ae3a427
---

# Microsoft Edge Browser Policy Documentation PrintStickySettings | Microsoft Learn

## Print preview sticky settings

## Supported versions

- Windows: ≥ 98
- macOS: ≥ 98
- Android: Not supported
- iOS: Not supported

## Description

Specifies whether print preview should apply last used settings for Microsoft Edge PDF and webpages.

If you set this policy to 'EnableAll' or don't configure it, Microsoft Edge applies the last used print preview settings for both PDF and webpages.

If you set this policy to 'DisableAll', Microsoft Edge doesn't apply the last used print preview settings for both PDF and webpages.

If you set this policy to 'DisablePdf', Microsoft Edge doesn't apply the last used print preview settings for PDF printing and retains it for webpages.

If you set this policy to 'DisableWebpage', Microsoft Edge doesn't apply the last used print preview settings for webpage printing and retain it for PDF.

This policy is only available if you enable or don't configure the [PrintingEnabled](printingenabled) policy.

Policy options mapping:

- EnableAll (0) = Enable sticky settings for PDF and Webpages
- DisableAll (1) = Disable sticky settings for PDF and Webpages
- DisablePdf (2) = Disable sticky settings for PDF
- DisableWebpage (3) = Disable sticky settings for Webpages

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- EnableAll (0) = Enable sticky settings for PDF and Webpages
- DisableAll (1) = Disable sticky settings for PDF and Webpages
- DisablePdf (2) = Disable sticky settings for PDF
- DisableWebpage (3) = Disable sticky settings for Webpages

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PrintStickySettings
- GP name: Print preview sticky settings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Printing
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disable sticky settings for PDF and Webpages
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: PrintStickySettings
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PrintStickySettings
- Example value:

```xml
<integer>1</integer>
```