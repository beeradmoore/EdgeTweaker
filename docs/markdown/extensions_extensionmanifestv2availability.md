---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExtensionManifestV2Availability | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/extensionmanifestv2availability
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control Manifest v2 extension availability'
locale: en-us
document_id: 3aedd024-2bc6-5052-2b8f-fd48b86b8d62
document_version_independent_id: 3aedd024-2bc6-5052-2b8f-fd48b86b8d62
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExtensionManifestV2Availability.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/ExtensionManifestV2Availability.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 404
asset_id: microsoft-edge-policies/extensionmanifestv2availability
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExtensionManifestV2Availability.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 26d8b949-c312-e74a-f5e8-6ce604f9d885
---

# Microsoft Edge Browser Policy Documentation ExtensionManifestV2Availability | Microsoft Learn

## Control Manifest v2 extension availability

## Supported versions

- Windows: ≥ 123
- macOS: ≥ 123
- Android: Not supported
- iOS: Not supported

## Description

Control if Manifest v2 extensions can be used by browser.

Manifest v2 extensions support will be deprecated and all extensions need to be migrated to v3 in the future. More information about and the timeline of the migration hasn't been established.

If the policy is set to Default or not set, v2 extension loading is decided by browser. This follows the preceding timeline when it's established.

If the policy is set to Disable, v2 extensions installation are blocked, and existing ones are disabled. This option is going to be treated the same as if the policy is unset after v2 support is turned off by default.

If the policy is set to Enable, v2 extensions are allowed. The option is going to be treated the same as if the policy isn't set before v2 support is turned off by default.

If the policy is set to EnableForForcedExtensions, force installed v2 extensions are allowed. This includes extensions that are listed by [ExtensionInstallForcelist](extensioninstallforcelist) or [ExtensionSettings](extensionsettings) with installation\_mode "force\_installed" or "normal\_installed". All other v2 extensions are disabled. The option is always available regardless of the manifest migration state.

Extensions availabilities are still controlled by other policies.

Policy options mapping:

- Default (0) = Default browser behavior
- Disable (1) = Manifest v2 is disabled
- Enable (2) = Manifest v2 is enabled
- EnableForForcedExtensions (3) = Manifest v2 is enabled for forced extensions only

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Default browser behavior
- Disable (1) = Manifest v2 is disabled
- Enable (2) = Manifest v2 is enabled
- EnableForForcedExtensions (3) = Manifest v2 is enabled for forced extensions only

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

- GP unique name: ExtensionManifestV2Availability
- GP name: Control Manifest v2 extension availability
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Extensions
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Manifest v2 is enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ExtensionManifestV2Availability
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: ExtensionManifestV2Availability
- Example value:

```xml
<integer>2</integer>
```