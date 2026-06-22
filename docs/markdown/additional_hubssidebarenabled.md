---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation HubsSidebarEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/hubssidebarenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Show Hubs Sidebar'
locale: en-us
document_id: 5310d222-4168-0370-e3ae-4c1a088cd6e5
document_version_independent_id: 5310d222-4168-0370-e3ae-4c1a088cd6e5
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/HubsSidebarEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/HubsSidebarEnabled.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 225
asset_id: microsoft-edge-policies/hubssidebarenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/HubsSidebarEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 65e36289-0ff7-e74b-375e-1737bd4188d9
---

# Microsoft Edge Browser Policy Documentation HubsSidebarEnabled | Microsoft Learn

## Show Hubs Sidebar

## Supported versions

- Windows: ≥ 99
- macOS: ≥ 99
- Android: Not supported
- iOS: Not supported

## Description

The Sidebar is a launcher bar located on the right side of Microsoft Edge.

If you enable this policy, the Sidebar is always visible.

If you disable this policy, the Sidebar is never shown.

If you don't configure this policy, the Sidebar's visibility follows the user's Microsoft Edge settings.

As of Microsoft Edge version 141, the [Microsoft365CopilotChatIconEnabled](microsoft365copilotchaticonenabled) policy is the only means of controlling the display of Copilot in the toolbar.

Note: The recommended version of this policy-also known as the "Default Settings (users can override)" policy-is obsolete. This policy has never supported the recommended capability.

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

- GP unique name: HubsSidebarEnabled
- GP name: Show Hubs Sidebar
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
- Value name: HubsSidebarEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: HubsSidebarEnabled
- Example value:

```xml
<true/>
```