---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation JavaScriptOptimizerAllowedForSites | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/javascriptoptimizerallowedforsites
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow JavaScript optimization on these sites'
locale: en-us
document_id: bc65088a-6824-3647-b20d-f6faecfe85d7
document_version_independent_id: bc65088a-6824-3647-b20d-f6faecfe85d7
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/JavaScriptOptimizerAllowedForSites.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/JavaScriptOptimizerAllowedForSites.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 341
asset_id: microsoft-edge-policies/javascriptoptimizerallowedforsites
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/JavaScriptOptimizerAllowedForSites.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: eb892b78-475b-b8f4-8a57-9209ede1243b
---

# Microsoft Edge Browser Policy Documentation JavaScriptOptimizerAllowedForSites | Microsoft Learn

## Allow JavaScript optimization on these sites

## Supported versions

- Windows: ≥ 134
- macOS: ≥ 134
- Android: ≥ 138
- iOS: Not supported

## Description

Allows you to set a list of site URL patterns that specify sites for which advanced JavaScript optimizations are enabled.

For detailed information on valid site url patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. Wildcards, \*, are allowed.

JavaScript optimization policy exceptions will only be enforced at a site granularity (eTLD+1). A policy set for only subdomain.contoso.com doesn't correctly apply to contoso.com or subdomain.contoso.com since they both resolve to the same eTLD+1 (contoso.com) for which there's no policy. In this case, policy must be set on contoso.com to apply correctly for both contoso.com and subdomain.contoso.com.

This policy applies on a frame-by-frame basis and not based on top-level origin URL alone; so, for example, if contoso.com is listed in the [JavaScriptOptimizerAllowedForSites](javascriptoptimizerallowedforsites) policy but contoso.com loads a frame containing fabrikam.com, then contoso.com has JavaScript optimizations enabled, but fabrikam.com uses the policy from [DefaultJavaScriptOptimizerSetting](defaultjavascriptoptimizersetting), if set, or default to JavaScript optimizations enabled. Blocklist entries have higher priority than allowlist entries, which in turn have higher priority than the configured default value.

If you don't configure this policy for a site, then the policy from [DefaultJavaScriptOptimizerSetting](defaultjavascriptoptimizersetting) applies to the site, if set, otherwise Javascript optimization is enabled for the site.

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

- GP unique name: JavaScriptOptimizerAllowedForSites
- GP name: Allow JavaScript optimization on these sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\JavaScriptOptimizerAllowedForSites
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\JavaScriptOptimizerAllowedForSites\1 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: JavaScriptOptimizerAllowedForSites
- Example value:

```xml
<array>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: JavaScriptOptimizerAllowedForSites
- Example value:

```
["[*.]example.edu"]
```