---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ComposeInlineEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/composeinlineenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control access to Microsoft 365 Copilot writing assistance in Microsoft Edge for Business'
locale: en-us
document_id: a0b3069e-612d-f33f-34f0-56b68a92d128
document_version_independent_id: a0b3069e-612d-f33f-34f0-56b68a92d128
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ComposeInlineEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ComposeInlineEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 317
asset_id: microsoft-edge-policies/composeinlineenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ComposeInlineEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
platformId: fb4b5a77-87d9-6d43-389b-2171ef33d890
---

# Microsoft Edge Browser Policy Documentation ComposeInlineEnabled | Microsoft Learn

## Control access to Microsoft 365 Copilot writing assistance in Microsoft Edge for Business

## Supported versions

- Windows: ≥ 115
- macOS: ≥ 115
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether users can use writing support features in Microsoft Edge for Business, such as Rewrite, which utilizes Microsoft 365 Copilot Chat. With Rewrite, users can receive help with drafting content, rewriting text, and adjusting style directly in their browser tab. In Microsoft Edge, users can trigger it when highlighting editable content in their main browser through the right-click context menu.

This policy applies only to Microsoft Entra accounts and doesn't apply to Microsoft accounts.

If you enable this policy, users can use Rewrite in Microsoft Edge when logged in with an Entra account.

If you disable this policy, users within your tenant can't use Rewrite.

If you don't configure this policy, the default behavior is as follows:

- Rewrite is available to users
- Users can enable or disable Microsoft 365 Copilot access to Microsoft Edge page content using the toggle in Microsoft Edge settings.

Note: Rewrite isn't available on pages protected by data loss prevention (DLP) policies to help maintain compliance.

Learn more about Microsoft 365 Copilot Chat data, privacy, and security here: https://go.microsoft.com/fwlink/?linkid=2321816

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

- GP unique name: ComposeInlineEnabled
- GP name: Control access to Microsoft 365 Copilot writing assistance in Microsoft Edge for Business
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ComposeInlineEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: ComposeInlineEnabled
- Example value:

```xml
<false/>
```