---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ProcessIsolationEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/processisolationenabled
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: gabrielbanda
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-07-14T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Process Isolation'
locale: en-us
document_id: a781ecb5-b713-13b1-6523-1cef24c88e07
document_version_independent_id: a781ecb5-b713-13b1-6523-1cef24c88e07
updated_at: 2026-07-16T17:13:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ProcessIsolationEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/a289da80f95e4dc4398e2381af574918c10f5cdf/edgeenterprise/microsoft-edge-policies/ProcessIsolationEnabled.md
git_commit_id: a289da80f95e4dc4398e2381af574918c10f5cdf
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 288
asset_id: microsoft-edge-policies/processisolationenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ProcessIsolationEnabled.md
platformId: c458cd97-3357-f12c-9c65-86b1c27f6c68
---

# Microsoft Edge Browser Policy Documentation ProcessIsolationEnabled | Microsoft Learn

## Enable Process Isolation

## Supported versions

- Windows: ≥ 151
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

This policy controls Process Isolation in Microsoft Edge.

When this policy is enabled, Microsoft Edge uses Process Isolation to help improve browser security by preventing authorized applications on the device from reading or modifying the contents of Microsoft Edge's running processes. This also helps prevent other applications from accessing encrypted data used by Microsoft Edge.

Enabling Process Isolation may cause incompatibilities with third party applications that rely on being able to inject or tamper with Microsoft Edge's processes, such as antivirus, screen reader or window manager applications.

Setting the policy to Enabled turns on process isolation in Microsoft Edge.

Setting the policy to Disabled turns off process isolation in Microsoft Edge.

If this policy is unset, Microsoft Edge will follow the default rollout process for the Process Isolation feature, which means that the feature will be gradually rolled out to an increasing number of users.

Note: This policy is applied when Microsoft Edge starts. If the policy is changed while Microsoft Edge is running, the new setting will take effect on the next restart.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ProcessIsolationEnabled
- GP name: Enable Process Isolation
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
- Value name: ProcessIsolationEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```