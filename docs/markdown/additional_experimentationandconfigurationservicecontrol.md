---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ExperimentationAndConfigurationServiceControl | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/experimentationandconfigurationservicecontrol
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Control communication with the Experimentation and Configuration Service'
locale: en-us
document_id: f2d6c1f3-98e1-d8bc-743f-db1af4bf4405
document_version_independent_id: f2d6c1f3-98e1-d8bc-743f-db1af4bf4405
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ExperimentationAndConfigurationServiceControl.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ExperimentationAndConfigurationServiceControl.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 447
asset_id: microsoft-edge-policies/experimentationandconfigurationservicecontrol
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ExperimentationAndConfigurationServiceControl.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5ef4a711-ec17-610b-d6a4-8cdffd7de3d3
---

# Microsoft Edge Browser Policy Documentation ExperimentationAndConfigurationServiceControl | Microsoft Learn

## Control communication with the Experimentation and Configuration Service

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 121
- iOS: ≥ 121

## Description

The Experimentation and Configuration Service is used to deploy Experimentation and Configuration payloads to the client.

Experimentation payload consists of a list of early-in-development features that Microsoft is enabling for testing and feedback.

Configuration payload consists of a list of recommended settings that Microsoft wants to deploy to optimize the user experience.

Configuration payload may also contain a list of actions to take on certain domains for compatibility reasons. For example, the browser may override the User Agent string on a website if that website is broken. Each of these actions is intended to be temporary while Microsoft tries to resolve the issue with the site owner.

If you set this policy to 'FullMode', the full payload is downloaded from the Experimentation and Configuration Service. This includes both the experimentation and configuration payloads.

If you set this policy to 'ConfigurationsOnlyMode', only the configuration payload is downloaded.

If you set this policy to 'RestrictedMode', the communication with the Experimentation and Configuration Service is stopped completely. Microsoft doesn't recommend this setting.

If you don't configure this policy on a managed device, the behavior on Beta and Stable channels is the same as the 'ConfigurationsOnlyMode'. On Canary and Dev channels, the behavior is the same as 'FullMode'.

If you don't configure this policy on an unmanaged device, the behavior is the same as the 'FullMode'.

Policy options mapping:

- FullMode (2) = Retrieve configurations and experiments
- ConfigurationsOnlyMode (1) = Retrieve configurations only
- RestrictedMode (0) = Disable communication with the Experimentation and Configuration Service

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- FullMode (2) = Retrieve configurations and experiments
- ConfigurationsOnlyMode (1) = Retrieve configurations only
- RestrictedMode (0) = Disable communication with the Experimentation and Configuration Service

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ExperimentationAndConfigurationServiceControl
- GP name: Control communication with the Experimentation and Configuration Service
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Retrieve configurations and experiments
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ExperimentationAndConfigurationServiceControl
- Value type: REG\_DWORD

#### Example registry value

```
0x00000002
```

## Mac information and settings

- Preference Key name: ExperimentationAndConfigurationServiceControl
- Example value:

```xml
<integer>2</integer>
```

## Android information and settings

- Preference Key name: ExperimentationAndConfigurationServiceControl
- Example value:

```
2
```

## iOS information and settings

- Preference Key name: ExperimentationAndConfigurationServiceControl
- Example value:

```xml
<integer>2</integer>
```