---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation OriginKeyedProcessesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/originkeyedprocessesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable origin-keyed process isolation for improved security'
locale: en-us
document_id: a379b94e-4461-f97b-20e5-5a6b35ffa181
document_version_independent_id: a379b94e-4461-f97b-20e5-5a6b35ffa181
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/OriginKeyedProcessesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/fc3210297952cfba31492fd71267e3a6764b742c/edgeenterprise/microsoft-edge-policies/OriginKeyedProcessesEnabled.md
git_commit_id: fc3210297952cfba31492fd71267e3a6764b742c
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 262
asset_id: microsoft-edge-policies/originkeyedprocessesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/OriginKeyedProcessesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 1b679039-b9ca-092b-9343-597680c84cb2
---

# Microsoft Edge Browser Policy Documentation OriginKeyedProcessesEnabled | Microsoft Learn

## Enable origin-keyed process isolation for improved security

## Supported versions

- Windows: ≥ 141
- macOS: ≥ 141
- Android: Not supported
- iOS: Not supported

## Description

This policy enables origin-keyed process isolation for most pages, which improves security by separating content from different origins into distinct processes. This can increase the number of processes created. Users can override this setting by using command-line flags or edge://flags to turn the feature on or off.

If you enable this policy, most origins are isolated, even from other origins within the same site. For related configuration, see the IsolateOrigins and SitePerProcess policies.

If you disable this policy, origins can't be isolated from the rest of their site unless the origin explicitly requests isolation.

If you don’t configure this policy, the browser decides which origins to isolate and when. By default, this feature is disabled. The default state can change in the future.

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: OriginKeyedProcessesEnabled
- GP name: Enable origin-keyed process isolation for improved security
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: OriginKeyedProcessesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: OriginKeyedProcessesEnabled
- Example value:

```xml
<true/>
```