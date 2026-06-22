---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation UserAgentReduction | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/useragentreduction
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable or disable the User-Agent Reduction (obsolete)'
locale: en-us
document_id: 3e7cf56c-d303-459c-d170-d29e422e8a64
document_version_independent_id: 3e7cf56c-d303-459c-d170-d29e422e8a64
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/UserAgentReduction.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/UserAgentReduction.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 323
asset_id: microsoft-edge-policies/useragentreduction
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/UserAgentReduction.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: fc915513-7dcb-3d26-b8fd-ed371db6ac9b
---

# Microsoft Edge Browser Policy Documentation UserAgentReduction | Microsoft Learn

## Enable or disable the User-Agent Reduction (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 144.

## Supported versions

- Windows: 99-144
- macOS: 99-144
- Android: 140-144
- iOS: Not supported

## Description

The User-Agent HTTP request header has been reduced by default since Microsoft Edge version 119. To continue receiving detailed platform information, migrate to User-Agent Client Hints, which replace the deprecated detailed User-Agent header. For more information, visit: https://web.dev/articles/migrate-to-ua-ch

If you don't configure this policy or set it to Default, the User-Agent header will be reduced and controlled by experimentation.

Set this policy to 'ForceEnabled' to force the reduced version of the User-Agent request header for all origins.

Set this policy to 'ForceDisabled' to always use the full (legacy) User-Agent header.

To learn more about the User-Agent string, read here:

https://go.microsoft.com/fwlink/?linkid=2186267

Policy options mapping:

- Default (0) = Reduced User Agent, or controlled by experimentation.
- ForceDisabled (1) = Full (legacy) User Agent.
- ForceEnabled (2) = Reduced User Agent.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Reduced User Agent, or controlled by experimentation.
- ForceDisabled (1) = Full (legacy) User Agent.
- ForceEnabled (2) = Reduced User Agent.

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

- GP unique name: UserAgentReduction
- GP name: Enable or disable the User-Agent Reduction (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Reduced User Agent, or controlled by experimentation.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: UserAgentReduction
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: UserAgentReduction
- Example value:

```xml
<integer>0</integer>
```

## Android information and settings

- Preference Key name: UserAgentReduction
- Example value:

```
0
```