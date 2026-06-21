---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AllowedDomainsForApps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/alloweddomainsforapps
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Define domains allowed to access Google Workspace'
locale: en-us
document_id: 348789e2-ed17-44a4-f31c-4fdccc62af01
document_version_independent_id: 348789e2-ed17-44a4-f31c-4fdccc62af01
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AllowedDomainsForApps.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AllowedDomainsForApps.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 250
asset_id: microsoft-edge-policies/alloweddomainsforapps
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AllowedDomainsForApps.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: eaad21e2-6d15-15cb-bb98-379dafbf099d
---

# Microsoft Edge Browser Policy Documentation AllowedDomainsForApps | Microsoft Learn

## Define domains allowed to access Google Workspace

## Supported versions

- Windows: ≥ 104
- macOS: ≥ 104
- Android: ≥ 138
- iOS: Not supported

## Description

Setting the policy on Microsoft Edge turns on the restricted sign-in feature in Google Workspace and prevents users from changing this setting. Users can only access Google tools using accounts from the specified domains. To allow gmail or googlemail accounts, add consumer\_accounts to the list of domains. This policy is based on the Chrome policy of the same name.

If you don't provide a domain name or leave this policy unset, users can access Google Workspace with any account.

Users can't change or override this setting.

Note: This policy causes the X-GoogApps-Allowed-Domains header to be appended to all HTTP and HTTPS requests to all google.com domains, as described in https://go.microsoft.com/fwlink/?linkid=2197973.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- String

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AllowedDomainsForApps
- GP name: Define domains allowed to access Google Workspace
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
example.com
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AllowedDomainsForApps
- Value type: REG\_SZ

#### Example registry value

```
example.com
```

## Mac information and settings

- Preference Key name: AllowedDomainsForApps
- Example value:

```xml
<string>example.com</string>
```

## Android information and settings

- Preference Key name: AllowedDomainsForApps
- Example value:

```
example.com
```