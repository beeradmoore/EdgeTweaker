---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation IntranetRedirectBehavior | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/intranetredirectbehavior
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Intranet Redirection Behavior'
locale: en-us
document_id: ca75dc81-fb28-4617-6f90-5cdc2696e18a
document_version_independent_id: ca75dc81-fb28-4617-6f90-5cdc2696e18a
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/IntranetRedirectBehavior.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/IntranetRedirectBehavior.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 365
asset_id: microsoft-edge-policies/intranetredirectbehavior
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/IntranetRedirectBehavior.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9fe7c41a-e299-0d09-fa49-38d0f3fa2f93
---

# Microsoft Edge Browser Policy Documentation IntranetRedirectBehavior | Microsoft Learn

## Intranet Redirection Behavior

## Supported versions

- Windows: ≥ 88
- macOS: ≥ 88
- Android: Not supported
- iOS: Not supported

## Description

This policy configures behavior for intranet redirection via DNS interception checks. The checks attempt to discover whether the browser is behind a proxy that redirects unknown host names.

If this policy isn't configured, the browser uses the default behavior of DNS interception checks and intranet redirect suggestions. In M88, they're enabled by default but will be disabled by default in the future release.

[DNSInterceptionChecksEnabled](dnsinterceptionchecksenabled) is a related policy that might also disable DNS interception checks. However, this policy is a more flexible version which might separately control intranet redirection infobars and might be expanded in the future. If either [DNSInterceptionChecksEnabled](dnsinterceptionchecksenabled) or this policy make a request to disable interception checks, the checks will be disabled. If DNS interception checks are disabled by this policy but [GoToIntranetSiteForSingleWordEntryInAddressBar](gotointranetsiteforsinglewordentryinaddressbar) is enabled, single word queries still result in intranet navigations.

Policy options mapping:

- Default (0) = Use default browser behavior.
- DisableInterceptionChecksDisableInfobar (1) = Disable DNS interception checks and did-you-mean "http://intranetsite/" infobars.
- DisableInterceptionChecksEnableInfobar (2) = Disable DNS interception checks; allow did-you-mean "http://intranetsite/" infobars.
- EnableInterceptionChecksEnableInfobar (3) = Allow DNS interception checks and did-you-mean "http://intranetsite/" infobars.

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- Default (0) = Use default browser behavior.
- DisableInterceptionChecksDisableInfobar (1) = Disable DNS interception checks and did-you-mean "http://intranetsite/" infobars.
- DisableInterceptionChecksEnableInfobar (2) = Disable DNS interception checks; allow did-you-mean "http://intranetsite/" infobars.
- EnableInterceptionChecksEnableInfobar (3) = Allow DNS interception checks and did-you-mean "http://intranetsite/" infobars.

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

- GP unique name: IntranetRedirectBehavior
- GP name: Intranet Redirection Behavior
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disable DNS interception checks and did-you-mean "http://intranetsite/" infobars.
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: IntranetRedirectBehavior
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: IntranetRedirectBehavior
- Example value:

```xml
<integer>1</integer>
```