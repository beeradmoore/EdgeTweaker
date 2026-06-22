---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation LegacySameSiteCookieBehaviorEnabledForDomainList | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/legacysamesitecookiebehaviorenabledfordomainlist
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Revert to legacy SameSite behavior for cookies on specified sites (obsolete)'
locale: en-us
document_id: 7ff11630-4a39-7905-633e-1dc80b51b2d3
document_version_independent_id: 7ff11630-4a39-7905-633e-1dc80b51b2d3
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/LegacySameSiteCookieBehaviorEnabledForDomainList.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76/edgeenterprise/microsoft-edge-policies/LegacySameSiteCookieBehaviorEnabledForDomainList.md
git_commit_id: 8cd4d512de65e3d5eaef17bde3d3d32d6cc79a76
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 320
asset_id: microsoft-edge-policies/legacysamesitecookiebehaviorenabledfordomainlist
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/LegacySameSiteCookieBehaviorEnabledForDomainList.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 6dbdeb25-0d84-6d91-bd6b-00230a42fc53
---

# Microsoft Edge Browser Policy Documentation LegacySameSiteCookieBehaviorEnabledForDomainList | Microsoft Learn

## Revert to legacy SameSite behavior for cookies on specified sites (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 132.

## Supported versions

- Windows: 80-132
- macOS: 80-132
- Android: 79-132
- iOS: Not supported

## Description

Cookies set for domains match specified patterns revert to legacy SameSite behavior.

Reverting to legacy behavior causes cookies that don't specify a SameSite attribute to be treated as if they were "SameSite=None", removes the requirement for "SameSite=None" cookies to carry the "Secure" attribute, and skips the scheme comparison when evaluating if two sites are same-site.

If you don't set this policy, the global default value is used. The global default is also used for cookies on domains not covered by the patterns you specify.

The global default value can be configured using the [LegacySameSiteCookieBehaviorEnabled](legacysamesitecookiebehaviorenabled) policy. If [LegacySameSiteCookieBehaviorEnabled](legacysamesitecookiebehaviorenabled) is unset, the global default value falls back to other configuration sources.

For detailed information about valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322.

Patterns you list in this policy are treated as domains, not URLs, so you shouldn't specify a scheme or port.

The policy is discontinued from Edge 132.

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

- GP unique name: LegacySameSiteCookieBehaviorEnabledForDomainList
- GP name: Revert to legacy SameSite behavior for cookies on specified sites (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
www.example.com
```

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\LegacySameSiteCookieBehaviorEnabledForDomainList
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\LegacySameSiteCookieBehaviorEnabledForDomainList\1 =

```
www.example.com
```

SOFTWARE\Policies\Microsoft\Edge\LegacySameSiteCookieBehaviorEnabledForDomainList\2 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: LegacySameSiteCookieBehaviorEnabledForDomainList
- Example value:

```xml
<array>
  <string>www.example.com</string>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: LegacySameSiteCookieBehaviorEnabledForDomainList
- Example value:

```
["www.example.com", "[*.]example.edu"]
```