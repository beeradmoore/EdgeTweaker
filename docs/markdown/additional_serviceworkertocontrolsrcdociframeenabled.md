---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ServiceWorkerToControlSrcdocIframeEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/serviceworkertocontrolsrcdociframeenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow ServiceWorker to control srcdoc iframes'
locale: en-us
document_id: 2e5ba73a-8909-f191-b53f-69847e750390
document_version_independent_id: 2e5ba73a-8909-f191-b53f-69847e750390
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ServiceWorkerToControlSrcdocIframeEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ServiceWorkerToControlSrcdocIframeEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 201
asset_id: microsoft-edge-policies/serviceworkertocontrolsrcdociframeenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ServiceWorkerToControlSrcdocIframeEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2a96e235-1c51-1c81-2b84-25d09f766cda
---

# Microsoft Edge Browser Policy Documentation ServiceWorkerToControlSrcdocIframeEnabled | Microsoft Learn

## Allow ServiceWorker to control srcdoc iframes

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: ≥ 140
- iOS: Not supported

## Description

https://github.com/w3c/ServiceWorker/issues/765 asks srcdoc iframe with the "allow-same-origin" sandbox attribute to be under ServiceWorker control.

By default (if left unset) or when set to Enabled, Microsoft Edge makes srcdoc iframes with "allow-same-origin" sandbox attributes to be under ServiceWorker control.

Setting the policy to Disabled prevents ServiceWorker control over srcdoc iframes.

This policy is temporary and planned for deprecation in 2026.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ServiceWorkerToControlSrcdocIframeEnabled
- GP name: Allow ServiceWorker to control srcdoc iframes
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
- Value name: ServiceWorkerToControlSrcdocIframeEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ServiceWorkerToControlSrcdocIframeEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: ServiceWorkerToControlSrcdocIframeEnabled
- Example value:

```
true
```