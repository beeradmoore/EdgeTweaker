---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionsPerformanceDetectorEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensionsperformancedetectorenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Extensions Performance Detector enabled'
locale: en-us
document_id: 5e1e4d26-b283-547a-d715-824519b1a42f
document_version_independent_id: 5e1e4d26-b283-547a-d715-824519b1a42f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionsPerformanceDetectorEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ExtensionsPerformanceDetectorEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 260
asset_id: microsoft-edge-policies/extensionsperformancedetectorenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionsPerformanceDetectorEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8fd9e19f-e2bd-42f7-ec09-4635831fc1f1
---

# Microsoft Edge Browser Policy Documentation ExtensionsPerformanceDetectorEnabled | Microsoft Learn

## Extensions Performance Detector enabled

## Supported versions

- Windows: ≥ 130
- macOS: ≥ 130
- Android: Not supported
- iOS: Not supported

## Description

This policy controls if users can access the Extensions Performance Detector Recommended Action feature in Browser Essentials. This feature alerts extension users if their extensions are causing performance regressions in the browser and allows them to take action to resolve the issue.

If you enable or don't configure this policy, users receive Extensions Performance Detector notifications from Browser Essentials. When there's an active alert, users are able to view the impact of extensions on their browser's performance and make an informed decision to disable impacting extensions. The detector will exclude browser-managed extensions, such as Google Docs offline, component extensions, and organization-managed extensions (that is, extensions that can't be disabled).

If you disable this policy, users won't receive notifications or be able to view the Extensions Performance Detector Recommended Action.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExtensionsPerformanceDetectorEnabled
- GP name: Extensions Performance Detector enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Performance
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Performance
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ExtensionsPerformanceDetectorEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ExtensionsPerformanceDetectorEnabled
- Example value:

```xml
<true/>
```