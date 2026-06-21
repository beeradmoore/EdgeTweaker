---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UserAgentClientHintsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/useragentclienthintsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable the User-Agent Client Hints feature (obsolete)'
locale: en-us
document_id: d92c4da7-e84a-d6d1-7637-47242dbd2190
document_version_independent_id: d92c4da7-e84a-d6d1-7637-47242dbd2190
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UserAgentClientHintsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/UserAgentClientHintsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 247
asset_id: microsoft-edge-policies/useragentclienthintsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UserAgentClientHintsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 32889393-54e5-dbef-0eb7-b21185d96f2b
---

# Microsoft Edge Browser Policy Documentation UserAgentClientHintsEnabled | Microsoft Learn

## Enable the User-Agent Client Hints feature (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 93.

## Supported versions

- Windows: 86-93
- macOS: 86-93
- Android: 86-93
- iOS: Not supported

## Description

This policy is obsolete because it was intended for short-term adaptation purposes only. It doesn't work in Microsoft Edge after version 93.

When enabled the User-Agent Client Hints feature sends granular request headers that provide information about the user browser (for example, the browser version) and environment (for example, the system architecture).

This is an additive feature, but the new headers may break some websites that restrict the characters that requests may contain.

If you enable or don't configure this policy, the User-Agent Client Hints feature is enabled. If you disable this policy, this feature is unavailable.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: UserAgentClientHintsEnabled
- GP name: Enable the User-Agent Client Hints feature (obsolete)
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
- Value name: UserAgentClientHintsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: UserAgentClientHintsEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: UserAgentClientHintsEnabled
- Example value:

```
true
```