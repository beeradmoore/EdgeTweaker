---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WebDriverOverridesIncompatiblePolicies | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/webdriveroverridesincompatiblepolicies
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow WebDriver to Override Incompatible Policies (obsolete)'
locale: en-us
document_id: 262d2aee-c038-61bf-8b3c-fa59c447f61a
document_version_independent_id: 262d2aee-c038-61bf-8b3c-fa59c447f61a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WebDriverOverridesIncompatiblePolicies.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/WebDriverOverridesIncompatiblePolicies.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 207
asset_id: microsoft-edge-policies/webdriveroverridesincompatiblepolicies
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WebDriverOverridesIncompatiblePolicies.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: edd4c86e-b498-6452-9676-bda7fd904cca
---

# Microsoft Edge Browser Policy Documentation WebDriverOverridesIncompatiblePolicies | Microsoft Learn

## Allow WebDriver to Override Incompatible Policies (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 84.

## Supported versions

- Windows: 77-84
- macOS: 77-84
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because WebDriver is now compatible with all existing policies.

This policy allows users of the WebDriver feature to override policies that can interfere with its operation.

Currently this policy disables [SitePerProcess](siteperprocess) and [IsolateOrigins](isolateorigins) policies.

If you enable this policy, WebDriver can override incomaptible policies. If you disable or don't configure this policy, WebDriver isn't allowed to override incompatible policies.

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

- GP unique name: WebDriverOverridesIncompatiblePolicies
- GP name: Allow WebDriver to Override Incompatible Policies (obsolete)
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
- Value name: WebDriverOverridesIncompatiblePolicies
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: WebDriverOverridesIncompatiblePolicies
- Example value:

```xml
<true/>
```