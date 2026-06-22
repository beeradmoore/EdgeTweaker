---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation FetchKeepaliveDurationSecondsOnShutdown | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/fetchkeepalivedurationsecondsonshutdown
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Fetch keepalive duration on shutdown'
locale: en-us
document_id: c68753e5-f009-9912-01da-afb500ad8e55
document_version_independent_id: c68753e5-f009-9912-01da-afb500ad8e55
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/FetchKeepaliveDurationSecondsOnShutdown.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/FetchKeepaliveDurationSecondsOnShutdown.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 200
asset_id: microsoft-edge-policies/fetchkeepalivedurationsecondsonshutdown
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/FetchKeepaliveDurationSecondsOnShutdown.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2164b7f7-85da-5fdf-9333-e4867706c778
---

# Microsoft Edge Browser Policy Documentation FetchKeepaliveDurationSecondsOnShutdown | Microsoft Learn

## Fetch keepalive duration on shutdown

## Supported versions

- Windows: ≥ 90
- macOS: ≥ 90
- Android: Not supported
- iOS: Not supported

## Description

Controls the duration (in seconds) that keepalive requests are allowed to prevent the browser from completing its shutdown.

If you configure this policy, the browser blocks completing shutdown while it processes any outstanding keepalive requests (see https://fetch.spec.whatwg.org/#request-keepalive-flag) up to the maximum period of time specified by this policy.

If you disable or don't configure this policy, the default value of 0 seconds is used, and the outstanding keepalive requests are immediately cancelled during browser shutdown.

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

- GP unique name: FetchKeepaliveDurationSecondsOnShutdown
- GP name: Fetch keepalive duration on shutdown
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
1
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: FetchKeepaliveDurationSecondsOnShutdown
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: FetchKeepaliveDurationSecondsOnShutdown
- Example value:

```xml
<integer>1</integer>
```