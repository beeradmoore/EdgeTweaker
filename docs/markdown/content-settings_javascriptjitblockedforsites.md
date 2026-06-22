---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation JavaScriptJitBlockedForSites | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/javascriptjitblockedforsites
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Block JavaScript from using JIT on these sites'
locale: en-us
document_id: de9dbf48-de2b-10b0-e37f-d93a48740d4a
document_version_independent_id: de9dbf48-de2b-10b0-e37f-d93a48740d4a
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/JavaScriptJitBlockedForSites.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/JavaScriptJitBlockedForSites.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 372
asset_id: microsoft-edge-policies/javascriptjitblockedforsites
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/JavaScriptJitBlockedForSites.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 2b8f944d-534a-113a-0522-ba0f44b528e2
---

# Microsoft Edge Browser Policy Documentation JavaScriptJitBlockedForSites | Microsoft Learn

## Block JavaScript from using JIT on these sites

## Supported versions

- Windows: ≥ 93
- macOS: ≥ 93
- Android: ≥ 138
- iOS: Not supported

## Description

Allows you to set a list of site URL patterns that specify sites that aren't allowed to run JavaScript JIT (Just In Time) compiler enabled.

Disabling the JavaScript JIT means that Microsoft Edge may render web content more slowly, and may also disable parts of JavaScript including WebAssembly. Disabling the JavaScript JIT may allow Microsoft Edge to render web content in a more secure configuration.

For detailed information on valid URL patterns, see https://go.microsoft.com/fwlink/?linkid=2095322. Wildcards, \*, are allowed.

JavaScript JIT policy exceptions will only be enforced at a site granularity (eTLD+1). A policy set for only subdomain.contoso.com will not correctly apply to contoso.com or subdomain.contoso.com since they both resolve to the same eTLD+1 (contoso.com) for which there is no policy. In this case, policy must be set on contoso.com to apply correctly for both contoso.com and subdomain.contoso.com.

This policy applies on a frame-by-frame basis and not based on top-level origin URL alone; so, for example, if contoso.com is listed in the JavaScriptJitBlockedForSites policy but contoso.com loads a frame containing fabrikam.com, then contoso.com has JavaScript JIT disabled, but fabrikam.com uses the policy from [DefaultJavaScriptJitSetting](defaultjavascriptjitsetting), if set, or default to JavaScript JIT enabled.

If you don't configure this policy for a site, then the policy from [DefaultJavaScriptJitSetting](defaultjavascriptjitsetting) applies to the site, if set; otherwise, JavaScript JIT is enabled for the site.

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

- GP unique name: JavaScriptJitBlockedForSites
- GP name: Block JavaScript from using JIT on these sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
[*.]example.edu
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\JavaScriptJitBlockedForSites
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\JavaScriptJitBlockedForSites\1 =

```
[*.]example.edu
```

## Mac information and settings

- Preference Key name: JavaScriptJitBlockedForSites
- Example value:

```xml
<array>
  <string>[*.]example.edu</string>
</array>
```

## Android information and settings

- Preference Key name: JavaScriptJitBlockedForSites
- Example value:

```
["[*.]example.edu"]
```