---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ScarewareBlockerAllowListDomains | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/scarewareblockerallowlistdomains
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of domains where Microsoft Edge Scareware blockers don&#x27;t run'
locale: en-us
document_id: 50981f48-b0b9-5455-3e21-c88a06dee919
document_version_independent_id: 50981f48-b0b9-5455-3e21-c88a06dee919
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ScarewareBlockerAllowListDomains.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/067834446df3984e8949dfae4cf23506dc85cc1a/edgeenterprise/microsoft-edge-policies/ScarewareBlockerAllowListDomains.md
git_commit_id: 067834446df3984e8949dfae4cf23506dc85cc1a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 227
asset_id: microsoft-edge-policies/scarewareblockerallowlistdomains
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ScarewareBlockerAllowListDomains.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 166763ca-f128-6460-c658-64e6e0046cbc
---

# Microsoft Edge Browser Policy Documentation ScarewareBlockerAllowListDomains | Microsoft Learn

## Configure the list of domains where Microsoft Edge Scareware blockers don't run

## Supported versions

- Windows: ≥ 142
- macOS: ≥ 142
- Android: Not supported
- iOS: Not supported

## Description

This policy configures the list of trusted domains for Microsoft Edge Scareware blocker. When a website's source URL matches any domain in this list, Microsoft Edge Scareware blocker doesn't analyze that site.

This policy takes effect only if the ScarewareBlockerProtectionEnabled policy is enabled.

If you enable this policy, Microsoft Edge Scareware blocker trusts the specified domains.

If you disable or don't configure this policy, Microsoft Edge Scareware blocker analyzes all sites.

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

- GP unique name: ScarewareBlockerAllowListDomains
- GP name: Configure the list of domains where Microsoft Edge Scareware blockers don't run
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Scareware Blocker settings
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\ScarewareBlockerAllowListDomains
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\ScarewareBlockerAllowListDomains\1 =

```
mydomain.com
```

SOFTWARE\Policies\Microsoft\Edge\ScarewareBlockerAllowListDomains\2 =

```
myuniversity.edu
```

## Mac information and settings

- Preference Key name: ScarewareBlockerAllowListDomains
- Example value:

```xml
<array>
  <string>mydomain.com</string>
  <string>myuniversity.edu</string>
</array>
```