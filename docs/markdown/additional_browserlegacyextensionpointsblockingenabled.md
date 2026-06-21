---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BrowserLegacyExtensionPointsBlockingEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/browserlegacyextensionpointsblockingenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable browser legacy extension point blocking'
locale: en-us
document_id: 2bdc5b39-055d-42bf-42ae-36bf4a5824aa
document_version_independent_id: 2bdc5b39-055d-42bf-42ae-36bf4a5824aa
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BrowserLegacyExtensionPointsBlockingEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/BrowserLegacyExtensionPointsBlockingEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 222
asset_id: microsoft-edge-policies/browserlegacyextensionpointsblockingenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BrowserLegacyExtensionPointsBlockingEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e0af9b37-7731-ac34-443e-10a61e920bf6
---

# Microsoft Edge Browser Policy Documentation BrowserLegacyExtensionPointsBlockingEnabled | Microsoft Learn

## Enable browser legacy extension point blocking

## Supported versions

- Windows: ≥ 95
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Sets the ProcessExtensionPointDisablePolicy on Microsoft Edge's browser process to block code injection from legacy third party applications.

If you enable or don't configure this policy, the ProcessExtensionPointDisablePolicy is applied to block legacy extension points in the browser process.

If you disable this policy, the ProcessExtensionPointDisablePolicy isn't applied to block legacy extension points in the browser process. This action has a detrimental effect on Microsoft Edge's security and stability as unknown and potentially hostile code can load inside Microsoft Edge's browser process. Only turn off the policy if there are compatibility issues with third-party software that must run inside Microsoft Edge's browser process.

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

- GP unique name: BrowserLegacyExtensionPointsBlockingEnabled
- GP name: Enable browser legacy extension point blocking
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
- Value name: BrowserLegacyExtensionPointsBlockingEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```