---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TyposquattingAllowListDomains | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/typosquattingallowlistdomains
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of domains for which Microsoft Edge  Website Typo Protection won&#x27;t trigger warnings'
locale: en-us
document_id: f4f61df8-ba8f-34f7-e585-b0d85b95c7a1
document_version_independent_id: f4f61df8-ba8f-34f7-e585-b0d85b95c7a1
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TyposquattingAllowListDomains.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/TyposquattingAllowListDomains.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 325
asset_id: microsoft-edge-policies/typosquattingallowlistdomains
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TyposquattingAllowListDomains.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: e6de24b3-afd0-9b46-2f29-e46b3d7f8ba4
---

# Microsoft Edge Browser Policy Documentation TyposquattingAllowListDomains | Microsoft Learn

## Configure the list of domains for which Microsoft Edge Website Typo Protection won't trigger warnings

## Supported versions

- Windows: ≥ 121
- macOS: ≥ 121
- Android: ≥ 124
- iOS: Not supported

## Description

Configures the list of Microsoft Edge Website Typo Protection trusted domains. This means: Microsoft Edge Website Typo Protection won't check for potentially malicious typosquatting websites.

If you enable this policy, Microsoft Edge Website Typo Protection trusts these domains. If you disable or don't set this policy, default Microsoft Edge Website Typo Protection protection is applied to all resources.

This only takes effect when TyposquattingCheckerEnabled policy isn't set or is set to enabled.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10/11 Pro; or Enterprise instances that enrolled for device management; or macOS instances that are that are managed via MDM or joined to a domain via MCX. This policy doesn't apply if your organization has enabled Microsoft Defender for Endpoint. You must configure your allowlists and blocklists in Microsoft 365 Defender portal using Indicators (Settings &gt; Endpoints &gt; Indicators).

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

- GP unique name: TyposquattingAllowListDomains
- GP name: Configure the list of domains for which Microsoft Edge Website Typo Protection won't trigger warnings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Edge Website Typo Protection settings
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\TyposquattingAllowListDomains
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\TyposquattingAllowListDomains\1 =

```
mydomain.com
```

SOFTWARE\Policies\Microsoft\Edge\TyposquattingAllowListDomains\2 =

```
myuniversity.edu
```

## Mac information and settings

- Preference Key name: TyposquattingAllowListDomains
- Example value:

```xml
<array>
  <string>mydomain.com</string>
  <string>myuniversity.edu</string>
</array>
```

## Android information and settings

- Preference Key name: TyposquattingAllowListDomains
- Example value:

```
["mydomain.com", "myuniversity.edu"]
```