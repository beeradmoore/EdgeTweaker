---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnhanceSecurityModeBypassListDomains | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enhancesecuritymodebypasslistdomains
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of domains for which enhance security mode will not be enforced'
locale: en-us
document_id: 4a1f03c9-0f70-63ed-a9db-ec4a2318939a
document_version_independent_id: 4a1f03c9-0f70-63ed-a9db-ec4a2318939a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeBypassListDomains.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeBypassListDomains.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 181
asset_id: microsoft-edge-policies/enhancesecuritymodebypasslistdomains
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnhanceSecurityModeBypassListDomains.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: f1aa3e5d-7b12-9742-1182-4e23c4ffdaf9
---

# Microsoft Edge Browser Policy Documentation EnhanceSecurityModeBypassListDomains | Microsoft Learn

## Configure the list of domains for which enhance security mode will not be enforced

## Supported versions

- Windows: ≥ 98
- macOS: ≥ 98
- Android: Not supported
- iOS: Not supported

## Description

Configures the list of enhance security trusted domains. This means that enhance security mode isn't enforced when loading the sites in trusted domains.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnhanceSecurityModeBypassListDomains
- GP name: Configure the list of domains for which enhance security mode will not be enforced
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
mydomain.com
```

```
myuniversity.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\EnhanceSecurityModeBypassListDomains
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\EnhanceSecurityModeBypassListDomains\1 =

```
mydomain.com
```

SOFTWARE\Policies\Microsoft\Edge\EnhanceSecurityModeBypassListDomains\2 =

```
myuniversity.edu
```

## Mac information and settings

- Preference Key name: EnhanceSecurityModeBypassListDomains
- Example value:

```xml
<array>
  <string>mydomain.com</string>
  <string>myuniversity.edu</string>
</array>
```