---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ScarewareBlockerProtectionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/scarewareblockerprotectionenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure Microsoft Edge Scareware blocker protection'
locale: en-us
document_id: 5710a8c6-2847-9a7d-ec0c-03ed06c34f6d
document_version_independent_id: 5710a8c6-2847-9a7d-ec0c-03ed06c34f6d
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ScarewareBlockerProtectionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/04e81ba037b09e50cf52c9da23c8f08a98063036/edgeenterprise/microsoft-edge-policies/ScarewareBlockerProtectionEnabled.md
git_commit_id: 04e81ba037b09e50cf52c9da23c8f08a98063036
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 275
asset_id: microsoft-edge-policies/scarewareblockerprotectionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ScarewareBlockerProtectionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d42892e1-43ce-a82c-277e-d9a28f56f1db
---

# Microsoft Edge Browser Policy Documentation ScarewareBlockerProtectionEnabled | Microsoft Learn

## Configure Microsoft Edge Scareware blocker protection

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 142
- Android: Not supported
- iOS: Not supported

## Description

This policy setting allows administrators to control whether Microsoft Edge enables Scareware blocker, an AI-powered feature for protecting users from potential tech scams. To support this feature, Microsoft Edge downloads a machine learning model file from Microsoft to the device.

If you enable or don’t configure this policy, Microsoft Edge Scareware blocker uses local AI to detect potential tech scams.

If you disable this policy, Microsoft Edge Scareware blocker is disabled. The machine learning model file doesn't download to the device, and if downloaded, a deletion occurs.

When this policy is enabled, the policies [ScarewareBlockerBlocksDetectedSitesEnabled](scarewareblockerblocksdetectedsitesenabled), [ScarewareBlockerSendDetectedSitesToSmartScreenEnabled](scarewareblockersenddetectedsitestosmartscreenenabled), and [ScarewareBlockerAllowListDomains](scarewareblockerallowlistdomains) are used to configure the behavior of the Scareware blocker feature. If both of those policies are disabled, enabling this policy has no effect.

When this policy is disabled, the policies [ScarewareBlockerBlocksDetectedSitesEnabled](scarewareblockerblocksdetectedsitesenabled), [ScarewareBlockerSendDetectedSitesToSmartScreenEnabled](scarewareblockersenddetectedsitestosmartscreenenabled), and [ScarewareBlockerAllowListDomains](scarewareblockerallowlistdomains) have no effect.

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

- GP unique name: ScarewareBlockerProtectionEnabled
- GP name: Configure Microsoft Edge Scareware blocker protection
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Scareware Blocker settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Scareware Blocker settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: ScarewareBlockerProtectionEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ScarewareBlockerProtectionEnabled
- Example value:

```xml
<true/>
```