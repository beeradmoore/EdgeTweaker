---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SavingBrowserHistoryDisabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/savingbrowserhistorydisabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Disable saving browser history'
locale: en-us
document_id: c4be9a72-8f93-4b16-8573-9fdcdbad99db
document_version_independent_id: c4be9a72-8f93-4b16-8573-9fdcdbad99db
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SavingBrowserHistoryDisabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SavingBrowserHistoryDisabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 183
asset_id: microsoft-edge-policies/savingbrowserhistorydisabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SavingBrowserHistoryDisabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: eb667ac6-48ed-eacf-ee28-9f2a26beee16
---

# Microsoft Edge Browser Policy Documentation SavingBrowserHistoryDisabled | Microsoft Learn

## Disable saving browser history

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 140
- iOS: ≥ 84

## Description

Disables saving browser history and prevents users from changing this setting.

If you enable this policy, browsing history isn't saved. This also disables tab syncing.

If you disable this policy or don't configure it, browsing history is saved.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SavingBrowserHistoryDisabled
- GP name: Disable saving browser history
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
- Value name: SavingBrowserHistoryDisabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SavingBrowserHistoryDisabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: SavingBrowserHistoryDisabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: SavingBrowserHistoryDisabled
- Example value:

```xml
<true/>
```