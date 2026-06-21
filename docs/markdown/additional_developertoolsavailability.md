---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation DeveloperToolsAvailability | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/developertoolsavailability
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control where developer tools can be used'
locale: en-us
document_id: 7c353c70-0cd2-8edc-140d-64155e78ec62
document_version_independent_id: 7c353c70-0cd2-8edc-140d-64155e78ec62
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailability.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailability.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 468
asset_id: microsoft-edge-policies/developertoolsavailability
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/DeveloperToolsAvailability.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: da7a8ad2-e4d3-e406-b996-036fd56616fa
---

# Microsoft Edge Browser Policy Documentation DeveloperToolsAvailability | Microsoft Learn

## Control where developer tools can be used

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: Not supported
- iOS: Not supported

## Description

Controls whether users can access developer tools in Microsoft Edge.

If you set this policy to 'DeveloperToolsDisallowedForForceInstalledExtensions' (default), users can access developer tools and the JavaScript console, except in the context of extensions installed by enterprise policy.

If you set this policy to 'DeveloperToolsAllowed', users can access developer tools and the JavaScript console in all contexts, including extensions installed by enterprise policy.

If you set this policy to 'DeveloperToolsDisallowed', users cannot access developer tools or inspect website elements. Keyboard shortcuts, menu options, and context menu entries that open developer tools or the JavaScript console are disabled.

As of version 99, this policy also controls access to the 'View page source' feature. If you set this policy to 'DeveloperToolsDisallowed', users cannot view page source through keyboard shortcuts or the context menu. To fully block source viewing, add 'view-source:\*' to the [URLBlocklist](urlblocklist) policy.

As of version 119, this policy also controls whether developer mode for Isolated Web Apps can be enabled.

As of version 128, this policy does not control developer mode on the extensions page if the [ExtensionDeveloperModeSettings](extensiondevelopermodesettings) policy is configured.

Developer tools availability is determined in the following order of precedence:

1. If a URL matches a pattern in [DeveloperToolsAvailabilityAllowlist](developertoolsavailabilityallowlist), developer tools are allowed.
2. If the allowlist is configured and the blocklist is not, URLs not on the allowlist are blocked.
3. If a URL matches a pattern in [DeveloperToolsAvailabilityBlocklist](developertoolsavailabilityblocklist), developer tools are blocked.
4. If a URL is not covered by either list, this policy ([DeveloperToolsAvailability](developertoolsavailability)) applies.

Policy options mapping:

- DeveloperToolsDisallowedForForceInstalledExtensions (0) = Block the developer tools on extensions installed by enterprise policy, allow in other contexts
- DeveloperToolsAllowed (1) = Allow using the developer tools
- DeveloperToolsDisallowed (2) = Don't allow using the developer tools

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- DeveloperToolsDisallowedForForceInstalledExtensions (0) = Block the developer tools on extensions installed by enterprise policy, allow in other contexts
- DeveloperToolsAllowed (1) = Allow using the developer tools
- DeveloperToolsDisallowed (2) = Don't allow using the developer tools

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

- GP unique name: DeveloperToolsAvailability
- GP name: Control where developer tools can be used
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Don't allow using the developer tools
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: DeveloperToolsAvailability
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: DeveloperToolsAvailability
- Example value:

```xml
<integer>2</integer>
```