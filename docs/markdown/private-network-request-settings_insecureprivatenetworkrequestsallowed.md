---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation InsecurePrivateNetworkRequestsAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/insecureprivatenetworkrequestsallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Specifies whether to allow websites to make requests to any network endpoint in an insecure manner. (obsolete)'
locale: en-us
document_id: 9d0cfbee-e561-f963-7804-b15a5ba406dc
document_version_independent_id: 9d0cfbee-e561-f963-7804-b15a5ba406dc
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/InsecurePrivateNetworkRequestsAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/76844e8037a562830bed88251bdc4c96b85554bb/edgeenterprise/microsoft-edge-policies/InsecurePrivateNetworkRequestsAllowed.md
git_commit_id: 76844e8037a562830bed88251bdc4c96b85554bb
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 358
asset_id: microsoft-edge-policies/insecureprivatenetworkrequestsallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/InsecurePrivateNetworkRequestsAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: f724bba5-83a2-85d2-13bb-5c61c015c98d
---

# Microsoft Edge Browser Policy Documentation InsecurePrivateNetworkRequestsAllowed | Microsoft Learn

## Specifies whether to allow websites to make requests to any network endpoint in an insecure manner. (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 137.

## Supported versions

- Windows: 92-137
- macOS: 92-137
- Android: Not supported
- iOS: Not supported

## Description

Controls whether websites are allowed to make requests to more-private network endpoints.

When this policy is enabled, all Private Network Access checks are disabled for all origins. This may allow attackers to perform cross-site request forgery (CSRF) attacks on private network servers.

When this policy is disabled or not configured, the default behavior for requests to more-private network endpoints depend on the user's personal configuration for the BlockInsecurePrivateNetworkRequests, PrivateNetworkAccessSendPreflights, and PrivateNetworkAccessRespectPreflightResults feature flags. These flags may be controlled by experimentation or set via the command line.

This policy relates to the Private Network Access specification. See https://wicg.github.io/private-network-access/ for more details.

A network endpoint is more private than another if:

1. Its IP address is localhost and the other isn't.
2. Its IP address is private and the other is public. In the future, depending on spec evolution, this policy might apply to all cross-origin requests directed at private IPs or localhost.

When this policy enabled, websites are allowed to make requests to any network endpoint, subject to other cross-origin checks.

This policy is obsolete. The previous blanket override has been replaced by the permission-based Local Network Access model, which blocks cross-space requests until users grant explicit consent.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: InsecurePrivateNetworkRequestsAllowed
- GP name: Specifies whether to allow websites to make requests to any network endpoint in an insecure manner. (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Private Network Request Settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: InsecurePrivateNetworkRequestsAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: InsecurePrivateNetworkRequestsAllowed
- Example value:

```xml
<false/>
```