---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ShowAcrobatSubscriptionButton | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/showacrobatsubscriptionbutton
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Shows button on native PDF viewer in Microsoft Edge that allows users to sign up for Adobe Acrobat subscription'
locale: en-us
document_id: 730938fa-1fd1-7760-4cb2-6f9ac7c0791b
document_version_independent_id: 730938fa-1fd1-7760-4cb2-6f9ac7c0791b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ShowAcrobatSubscriptionButton.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ShowAcrobatSubscriptionButton.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/showacrobatsubscriptionbutton
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ShowAcrobatSubscriptionButton.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c2ba65aa-6ee4-e8b6-0314-f1f5c74d22f0
---

# Microsoft Edge Browser Policy Documentation ShowAcrobatSubscriptionButton | Microsoft Learn

## Shows button on native PDF viewer in Microsoft Edge that allows users to sign up for Adobe Acrobat subscription

## Supported versions

- Windows: ≥ 111
- macOS: ≥ 111
- Android: Not supported
- iOS: Not supported

## Description

This policy lets the native PDF viewer in Microsoft Edge show a button that lets a user looking for advanced digital document features to discover and subscribe to premium offerings. This is done via the Acrobat extension.

If you enable or don't configure this policy, the button shows up on the native PDF viewer in Microsoft Edge. A user can buy Adobe subscription to access their premium offerings.

If you disable this policy, the button isn't visible on the native PDF viewer in Microsoft Edge. A user can't discover Adobe's advanced PDF tools or buy their subscriptions.

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

- GP unique name: ShowAcrobatSubscriptionButton
- GP name: Shows button on native PDF viewer in Microsoft Edge that allows users to sign up for Adobe Acrobat subscription
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
- Value name: ShowAcrobatSubscriptionButton
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ShowAcrobatSubscriptionButton
- Example value:

```xml
<true/>
```