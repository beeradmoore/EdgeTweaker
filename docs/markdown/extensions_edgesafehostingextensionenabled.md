---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeSafeHostingExtensionEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgesafehostingextensionenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control Microsoft Edge Safe Hosting Extension'
locale: en-us
document_id: e8a1a0fd-ee78-bbd9-49a7-a41e254567be
document_version_independent_id: e8a1a0fd-ee78-bbd9-49a7-a41e254567be
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeSafeHostingExtensionEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/EdgeSafeHostingExtensionEnabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 252
asset_id: microsoft-edge-policies/edgesafehostingextensionenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeSafeHostingExtensionEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 268b977b-1bbe-b751-94ee-78ccb9ef994d
---

# Microsoft Edge Browser Policy Documentation EdgeSafeHostingExtensionEnabled | Microsoft Learn

## Control Microsoft Edge Safe Hosting Extension

## Supported versions

- Windows: ≥ 145
- macOS: ≥ 145
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether the Microsoft Edge Safe Hosting component extension is installed automatically when users visit supported Microsoft services, such as Microsoft 365 Copilot app.

The Microsoft Edge Safe Hosting extension provides additional security capabilities for these services. When a user accesses a supported service, the extension installs automatically to enable those protections.

If you enable or don't configure this policy, the extension installs automatically and remains installed for 90 days after the user's last visit, then is removed if no further activity occurs.

If you disable this policy, the extension won't install automatically. If it’s already installed, it will be removed.

Note: This policy controls only automatic installation. It doesn’t prevent users from manually installing other extensions from the Microsoft Edge Add-ons website.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EdgeSafeHostingExtensionEnabled
- GP name: Control Microsoft Edge Safe Hosting Extension
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EdgeSafeHostingExtensionEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: EdgeSafeHostingExtensionEnabled
- Example value:

```xml
<true/>
```