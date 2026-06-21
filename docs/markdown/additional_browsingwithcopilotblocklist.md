---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BrowsingWithCopilotBlockList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/browsingwithcopilotblocklist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Browsing with Copilot Blocked URLs'
locale: en-us
document_id: 85bb366e-df4f-7590-88a8-733f2ce52f6a
document_version_independent_id: 85bb366e-df4f-7590-88a8-733f2ce52f6a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BrowsingWithCopilotBlockList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/BrowsingWithCopilotBlockList.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 287
asset_id: microsoft-edge-policies/browsingwithcopilotblocklist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BrowsingWithCopilotBlockList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/46e3c7c4-fe77-4a6e-b40a-44c569819fa5
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/d0c6fab8-2d7d-4bb0-bf40-589e08d7c132
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2c8e1feb-9609-e09d-8beb-5de024c005e7
---

# Microsoft Edge Browser Policy Documentation BrowsingWithCopilotBlockList | Microsoft Learn

## Browsing with Copilot Blocked URLs

## Supported versions

- Windows: ≥ 148
- macOS: ≥ 148
- Android: Not supported
- iOS: Not supported

## Description

Controls the list of URLs where browsing with Copilot is blocked. Users can't modify this list.

Use this policy to define exceptions to broader allowlists. For example, you can set [BrowsingWithCopilotAllowList](browsingwithcopilotallowlist) to '\*' to allow all sites, and then use this policy to block access to specific URLs.

This policy supports blocking by scheme, subdomain, or port. When multiple URL patterns apply, the most specific match determines whether access is allowed or blocked. Blocklist entries take precedence over allowlist entries.

If you don't configure this policy, no exceptions are applied to [BrowsingWithCopilotAllowList](browsingwithcopilotallowlist).

Browsing with Copilot supports only HTTP and HTTPS protocols. Wildcards (\*) are supported, and subdomains are matched even without wildcards. URL matching is based on the site origin only; any path specified in the pattern is ignored.

For information about URL pattern format, see https://go.microsoft.com/fwlink/?linkid=2095322.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: BrowsingWithCopilotBlockList
- GP name: Browsing with Copilot Blocked URLs
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
https://www.contoso.com
```

```
[*.]contoso.edu
```

```
contoso.net
```

```
login.contoso.us
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\BrowsingWithCopilotBlockList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\BrowsingWithCopilotBlockList\1 =

```
https://www.contoso.com
```

SOFTWARE\Policies\Microsoft\Edge\BrowsingWithCopilotBlockList\2 =

```
[*.]contoso.edu
```

SOFTWARE\Policies\Microsoft\Edge\BrowsingWithCopilotBlockList\3 =

```
contoso.net
```

SOFTWARE\Policies\Microsoft\Edge\BrowsingWithCopilotBlockList\4 =

```
login.contoso.us
```

## Mac information and settings

- Preference Key name: BrowsingWithCopilotBlockList
- Example value:

```xml
<array>
  <string>https://www.contoso.com</string>
  <string>[*.]contoso.edu</string>
  <string>contoso.net</string>
  <string>login.contoso.us</string>
</array>
```