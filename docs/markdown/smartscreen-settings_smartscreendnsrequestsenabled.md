---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation SmartScreenDnsRequestsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/smartscreendnsrequestsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Microsoft Defender SmartScreen DNS requests'
locale: en-us
document_id: 177d1dba-17ba-e9fa-e587-374f99b6a08b
document_version_independent_id: 177d1dba-17ba-e9fa-e587-374f99b6a08b
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/SmartScreenDnsRequestsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/SmartScreenDnsRequestsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 268
asset_id: microsoft-edge-policies/smartscreendnsrequestsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/SmartScreenDnsRequestsEnabled.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c671beaa-a830-4c9f-aceb-97379ee031ca
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8921374c-4dbe-4ed0-b011-a39e18bfbd98
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 5e481b6d-88de-1e14-db71-538837dd36e3
---

# Microsoft Edge Browser Policy Documentation SmartScreenDnsRequestsEnabled | Microsoft Learn

## Enable Microsoft Defender SmartScreen DNS requests

## Supported versions

- Windows: ≥ 97
- macOS: ≥ 97
- Android: ≥ 118
- iOS: ≥ 118

## Description

This policy lets you configure whether to enable DNS requests made by Microsoft Defender SmartScreen. Note: Disabling DNS requests prevent Microsoft Defender SmartScreen from getting IP addresses, and potentially impact the IP-based protections provided.

If you enable or don't configure this setting, Microsoft Defender SmartScreen can make DNS requests.

If you disable this setting, Microsoft Defender SmartScreen can't make any DNS requests.

This policy is available only on Windows instances that are joined to a Microsoft Active Directory domain, Windows 10 Pro or Enterprise instances that enrolled for device management, or macOS instances that are managed via MDM or joined to a domain via MCX.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: SmartScreenDnsRequestsEnabled
- GP name: Enable Microsoft Defender SmartScreen DNS requests
- GP path (Mandatory): Administrative Templates/Microsoft Edge/SmartScreen settings
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/SmartScreen settings
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: SmartScreenDnsRequestsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: SmartScreenDnsRequestsEnabled
- Example value:

```xml
<true/>
```

## Android information and settings

- Preference Key name: SmartScreenDnsRequestsEnabled
- Example value:

```
true
```

## iOS information and settings

- Preference Key name: SmartScreenDnsRequestsEnabled
- Example value:

```xml
<true/>
```