---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SmartScreenAllowListDomains | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/smartscreenallowlistdomains
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure the list of domains for which Microsoft Defender SmartScreen won&#x27;t trigger warnings'
locale: en-us
document_id: 7afacc19-a3f0-191e-cf2e-7a0b1c8d9ce3
document_version_independent_id: 7afacc19-a3f0-191e-cf2e-7a0b1c8d9ce3
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SmartScreenAllowListDomains.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SmartScreenAllowListDomains.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 347
asset_id: microsoft-edge-policies/smartscreenallowlistdomains
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SmartScreenAllowListDomains.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c671beaa-a830-4c9f-aceb-97379ee031ca
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8921374c-4dbe-4ed0-b011-a39e18bfbd98
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 3c8a8d6b-fc9e-3868-afe5-110d4ea63709
---

# Microsoft Edge Browser Policy Documentation SmartScreenAllowListDomains | Microsoft Learn

## Configure the list of domains for which Microsoft Defender SmartScreen won't trigger warnings

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 118
- iOS: ≥ 118

## Description

Configures the list of Microsoft Defender SmartScreen trusted domains. This means:

- Microsoft Defender SmartScreen won't check for potentially malicious resources like phishing software and other malware if the source URLs match these domains.
- The Microsoft Defender SmartScreen download protection service won't check downloads hosted on these domains.

If you enable this policy, Microsoft Defender SmartScreen trusts these domains. If you disable or don't set this policy, default Microsoft Defender SmartScreen protection is applied to all resources.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10/11 Pro or Enterprise instances that enrolled for device management, or macOS instances that are that are managed via mobile device management (MDM) or joined to a domain via MCX. Note: If your organization has enabled Microsoft Defender for Endpoint, this policy and any allowlists created with the policy are ignored. You must configure your allowlists and blocklists in Microsoft 365 Defender portal using "Indicators" (Settings &gt; Endpoints &gt; Indicators).

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

- GP unique name: SmartScreenAllowListDomains
- GP name: Configure the list of domains for which Microsoft Defender SmartScreen won't trigger warnings
- GP path (Mandatory): Administrative Templates/Microsoft Edge/SmartScreen settings
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

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\SmartScreenAllowListDomains
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\SmartScreenAllowListDomains\1 =

```
mydomain.com
```

SOFTWARE\Policies\Microsoft\Edge\SmartScreenAllowListDomains\2 =

```
myuniversity.edu
```

## Mac information and settings

- Preference Key name: SmartScreenAllowListDomains
- Example value:

```xml
<array>
  <string>mydomain.com</string>
  <string>myuniversity.edu</string>
</array>
```

## Android information and settings

- Preference Key name: SmartScreenAllowListDomains
- Example value:

```
["mydomain.com", "myuniversity.edu"]
```

## iOS information and settings

- Preference Key name: SmartScreenAllowListDomains
- Example value:

```xml
<array>
  <string>mydomain.com</string>
  <string>myuniversity.edu</string>
</array>
```