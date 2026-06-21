---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SmartActionsBlockList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/smartactionsblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block smart actions for a list of services'
locale: en-us
document_id: 52967d73-9029-a07a-d5ca-6efba262dba9
document_version_independent_id: 52967d73-9029-a07a-d5ca-6efba262dba9
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SmartActionsBlockList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SmartActionsBlockList.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 432
asset_id: microsoft-edge-policies/smartactionsblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SmartActionsBlockList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8ea148e9-a795-a636-96aa-8284ebaf0d7d
---

# Microsoft Edge Browser Policy Documentation SmartActionsBlockList | Microsoft Learn

## Block smart actions for a list of services

## Supported versions

- Windows: ≥ 89
- macOS: ≥ 89
- Android: Not supported
- iOS: Not supported

## Description

List specific services, such as PDFs, and websites that don't show smart actions. (Smart actions are actions like "define" which are available in full and mini context menus in Microsoft Edge.)

If you enable the policy:

- The smart action in the mini and full context menu is disabled for all profiles for services that match the given list.
- Users won't see the smart action in the mini and full context menu on text selection for services that match the given list.
- In Microsoft Edge settings, the smart action in the mini and full context menu is disabled for services that match the given list.

If you disable or don't configure this policy:

- The smart action in the mini and full context menu is enabled for all profiles.
- Users will see the smart action in the mini and full context menu on text selection.
- In Microsoft Edge settings, the smart action in the mini and full context menu is enabled.

Policy options mapping:

- smart\_actions (smart\_actions) = Smart actions in pdfs and on websites
- smart\_actions\_website (smart\_actions\_website) = Smart actions on websites
- smart\_actions\_pdf (smart\_actions\_pdf) = Smart actions in PDF

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- smart\_actions = Smart actions in pdfs and on websites
    - Windows: ≥ 120
    - macOS: ≥ 120
    - Android: Not supported
    - iOS: Not supported
- smart\_actions\_website = Smart actions on websites
    - Windows: ≥ 120
    - macOS: ≥ 120
    - Android: Not supported
    - iOS: Not supported
- smart\_actions\_pdf = Smart actions in PDF
    - Windows: ≥ 89
    - macOS: ≥ 89
    - Android: Not supported
    - iOS: Not supported

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SmartActionsBlockList
- GP name: Block smart actions for a list of services
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Smart actions in pdfs and on websites
```

```
Smart actions on websites
```

```
Smart actions in PDF
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SmartActionsBlockList
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended\SmartActionsBlockList
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SmartActionsBlockList\1 =

```
smart_actions
```

SOFTWARE\Policies\Microsoft\Edge\SmartActionsBlockList\2 =

```
smart_actions_website
```

SOFTWARE\Policies\Microsoft\Edge\SmartActionsBlockList\3 =

```
smart_actions_pdf
```

## Mac information and settings

- Preference Key name: SmartActionsBlockList
- Example value:

```xml
<array>
  <string>smart_actions</string>
  <string>smart_actions_website</string>
  <string>smart_actions_pdf</string>
</array>
```