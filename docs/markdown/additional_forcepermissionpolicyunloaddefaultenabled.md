---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForcePermissionPolicyUnloadDefaultEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcepermissionpolicyunloaddefaultenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Controls whether unload event handlers can be disabled.'
locale: en-us
document_id: b0c0e0e5-6046-de78-ea7b-abb7ab80183e
document_version_independent_id: b0c0e0e5-6046-de78-ea7b-abb7ab80183e
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForcePermissionPolicyUnloadDefaultEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/aed83b531d25ba6dc84d0be2c4122b451bbfa304/edgeenterprise/microsoft-edge-policies/ForcePermissionPolicyUnloadDefaultEnabled.md
git_commit_id: aed83b531d25ba6dc84d0be2c4122b451bbfa304
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 305
asset_id: microsoft-edge-policies/forcepermissionpolicyunloaddefaultenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForcePermissionPolicyUnloadDefaultEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9bb3b2ad-3ed1-5c77-aef5-4c391d826575
---

# Microsoft Edge Browser Policy Documentation ForcePermissionPolicyUnloadDefaultEnabled | Microsoft Learn

## Controls whether unload event handlers can be disabled.

## Supported versions

- Windows: ≥ 118
- macOS: ≥ 118
- Android: ≥ 118
- iOS: Not supported

## Description

unload event handlers are being deprecated. Whether they fire depends on the unload Permissions-Policy. Currently, the policy allows them by default. In the future, they move to being disallowed by default, and sites must explicitly enable them using Permissions-Policy headers. This enterprise policy can be used to opt out of this gradual deprecation by forcing the default to stay enabled.

Pages might depend on unload event handlers to save data or to signal the end of a user session to the server. This dependency isn't recommended because it's unreliable and impacts performance by blocking use of BackForwardCache. Recommended alternatives exist, but the unload event has been used for a long time. Some applications might still rely on them.

If you disable this policy or don't configure it, unload event handlers are gradually deprecated in-line with the deprecation rollout, and sites that don't set Permissions-Policy header stop firing `unload` events.

If you enable this policy, the unload event handlers continue to work by default.

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

- GP unique name: ForcePermissionPolicyUnloadDefaultEnabled
- GP name: Controls whether unload event handlers can be disabled.
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
- Value name: ForcePermissionPolicyUnloadDefaultEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ForcePermissionPolicyUnloadDefaultEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: ForcePermissionPolicyUnloadDefaultEnabled
- Example value:

```
true
```