---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation Edge3PSerpTelemetryEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edge3pserptelemetryenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Edge 3P SERP Telemetry Enabled'
locale: en-us
document_id: 6f808fa8-e675-e76b-a626-1d5a2ff1e4b1
document_version_independent_id: 6f808fa8-e675-e76b-a626-1d5a2ff1e4b1
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/Edge3PSerpTelemetryEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/Edge3PSerpTelemetryEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 196
asset_id: microsoft-edge-policies/edge3pserptelemetryenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/Edge3PSerpTelemetryEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d9ee637b-0130-47ce-1c59-7961987aab94
---

# Microsoft Edge Browser Policy Documentation Edge3PSerpTelemetryEnabled | Microsoft Learn

## Edge 3P SERP Telemetry Enabled

## Supported versions

- Windows: ≥ 120
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Edge3P Telemetry in Microsoft Edge captures the searches that a user does on third-party search providers without identifying the person or the device only if the user has consented to this collection of data. User can turn off the collection at any time in the browser settings.

If you enable or don't configure this policy, Edge 3P SERP Telemetry feature is enabled.

If you disable this policy, Edge 3P SERP Telemetry feature is disabled.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: Edge3PSerpTelemetryEnabled
- GP name: Edge 3P SERP Telemetry Enabled
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
- Value name: Edge3PSerpTelemetryEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```